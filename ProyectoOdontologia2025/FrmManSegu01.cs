using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;  //Para trabajar con SQL
using System.Threading;
using System.Globalization;
using System.Diagnostics.Eventing.Reader;

namespace ProyectoOdontologia2025
{
    public partial class FrmManSegu01 : Form
    {

        //defino variables globales 
        SqlCommand comando = new SqlCommand();
        SqlConnection conexion = new SqlConnection("Data Source=localhost; initial catalog=OdontologiaBD; trusted_connection=yes");

        public FrmManSegu01()
        {
            InitializeComponent();
        }

        private void FrmManSegu01_Load(object sender, EventArgs e)
        {
            //Para mostrar la fecha
            lblfecha2.Text = DateTime.Now.ToShortDateString();

            //Invocar procedimiento para visualizar datos
            RefrescarTabla();
        }

        //Creo procedimiento para visualizar los datos en el data grid view
        private void RefrescarTabla()
        {
            dgvDatos.DataSource = null;
            try
            {
                conexion.Open(); //Abro la conexión
                DataTable datos = new DataTable();
                SqlDataAdapter Adaptador = new SqlDataAdapter("Select * from Seguros", conexion);
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


        private void FrmManSegu01_Activated(object sender, EventArgs e)
        {
            comando.Connection = conexion;
        }


        private void btnguardar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                //Agrego registro nuevo
                EscribirDatos("Insert into Seguros (nom_seg, tel_seg) Values ('" + txtNom.Text.Trim() + "' , '" + mtbTel.Text.Trim() + "')");
                MessageBox.Show("Nuevo registro guardado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                //Modificar un registro existente
                EscribirDatos("Update Seguros Set nom_seg = '" + txtNom.Text.Trim() + "', tel_seg =  '" + mtbTel.Text.Trim() + "' where id_seg = '" + txtId.Text + "'");
                MessageBox.Show("Se actualizó el registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }

            RefrescarTabla(); //Invoco función
            LimpiarObjetos();

        }
        private void LimpiarObjetos()
        {
            txtId.Text = "";
            txtNom.Clear();
            mtbTel.Clear();
            txtNom.Focus();
        }

        private void fecha_Tick(object sender, EventArgs e)
        {
            //Para que se muestre la hora
            lblhora2.Text = DateTime.Now.ToLongTimeString();

        }

        private void dgvre_Click(object sender, EventArgs e)
        {
            //Paso los datos del datagridview a los textbox
            txtId.Text = dgvDatos[0, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();
            txtNom.Text = dgvDatos[1, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();
            mtbTel.Text = dgvDatos[2, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();

        }

        

        private void txtnom_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnborrar_Click_1(object sender, EventArgs e)
        {
            EscribirDatos("Delete from Seguros where id_seg= '" + txtId.Text + "'");
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

