using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;  //Para trabajar con SQL
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProyectoOdontologia2025.FrmManDoct03;

namespace ProyectoOdontologia2025
{
    public partial class FrmManUsua05 : Form
    {

        //defino variables globales 
        SqlCommand comando = new SqlCommand();
        SqlConnection conexion = new SqlConnection("Data Source=localhost; initial catalog=OdontologiaBD; trusted_connection=yes");

        public FrmManUsua05()
        {
            InitializeComponent();
        }

        public class Option
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        private void FrmManUsua05_Load(object sender, EventArgs e)
        {
            //Para mostrar la fecha
            lblfecha2.Text = DateTime.Now.ToShortDateString();

            //Invocar procedimiento para visualizar datos
            RefrescarTabla();

            List<Option> optionsList = new List<Option>
            {
                new Option { Id = 1, Name = "Administrador" },
                new Option { Id = 2, Name = "Doctor" },
                new Option { Id = 3, Name = "Secretario" }
            };

            cbRol.DataSource = optionsList;
            cbRol.DisplayMember = "Name"; // Property to display in the control
            cbRol.ValueMember = "Id";
            cbRol.SelectedIndex = -1;
        }

        //Creo procedimiento para visualizar los datos en el data grid view
        private void RefrescarTabla()
        {
            dgvDatos.DataSource = null;
            try
            {
                conexion.Open(); //Abro la conexión
                DataTable datos = new DataTable();
                SqlDataAdapter Adaptador = new SqlDataAdapter("Select * from Usuarios", conexion);
                Adaptador.Fill(datos);
                BindingSource fuenteDatos = new BindingSource();
                fuenteDatos.DataSource = datos;
                dgvDatos.DataSource = fuenteDatos;

            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error,
               MessageBoxDefaultButton.Button1);

            }
            finally
            {
                conexion.Close();
            }

        }
        private void EscribirDatos(string Parametro)
        {
            try
            {
                comando.Connection = conexion;
                comando.CommandText = Parametro;

                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                }

                // ASIGNAMOS LA TRANSACCIÓN AL COMANDO
                SqlTransaction transaccion = conexion.BeginTransaction();
                comando.Transaction = transaccion; // <--- ESTO ES VITAL

                comando.ExecuteNonQuery();

                transaccion.Commit(); // Confirmamos
            }
            catch (Exception ex)
            {
                // Si hay error y existe una transacción, la revertimos
                if (comando.Transaction != null)
                {
                    comando.Transaction.Rollback();
                }
                MessageBox.Show("Error al escribir datos: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }


        private void lblmantenimiento_Click(object sender, EventArgs e)
        {

        }

        private void FrmManUsua05_Activated(object sender, EventArgs e)
        {
            comando.Connection = conexion;
        }

        private void Fecha_Tick(object sender, EventArgs e)
        {
            //Para que se muestre la hora
            lblhora2.Text = DateTime.Now.ToLongTimeString();
        }

        private void LimpiarObjetos()
        {
            txtUsu.Text = "";
            txtNombre.Clear();
            txtNomUsu.Clear();
            txtContra.Clear();
            txtEstado.Clear();
            cbRol.SelectedIndex = -1; // Deselecciona cualquier opción seleccionada en el ComboBox
            txtNombre.Focus();
        }

        private void dgvusuarios_Click(object sender, EventArgs e)
        {
            //Paso los datos del datagridview a los textbox
            txtUsu.Text = dgvDatos[0, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();
            txtNombre.Text = dgvDatos[1, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();
            txtNomUsu.Text = dgvDatos[2, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();
            txtContra.Text = dgvDatos[3, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();
            txtEstado.Text = dgvDatos[4, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsu.Text))
            {
                //Agrego registro nuevo
                EscribirDatos("Insert into Usuarios (nom_usr, pas_usr, id_rol, atv_usr, nmb_usr) Values ('" + txtNombre.Text.Trim() + "' , '" + txtContra.Text.Trim() + "', '" + cbRol.SelectedValue + "', '" + txtEstado.Text.Trim() + "', '" + txtNomUsu.Text.Trim() + "')");
                MessageBox.Show("Nuevo registro guardado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                //Modificar un registro existente - Ahora con el mismo orden y nombres de columnas
                EscribirDatos("Update Usuarios Set nom_usr = '" + txtNombre.Text.Trim() +
                              "', pas_usr = '" + txtContra.Text.Trim() +
                              "', id_rol = '" + cbRol.SelectedValue +
                              "', atv_usr = '" + txtEstado.Text.Trim() +
                              "', nmb_usr = '" + txtNomUsu.Text.Trim() +
                              "' where id_usr = '" + txtUsu.Text + "'");
                MessageBox.Show("Se actualizó el registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }

            RefrescarTabla(); //Invoco función
            LimpiarObjetos();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            EscribirDatos("Delete from Usuarios where id_usr= '" + txtUsu.Text + "'");
            MessageBox.Show("Registro borrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            LimpiarObjetos();
            RefrescarTabla();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
