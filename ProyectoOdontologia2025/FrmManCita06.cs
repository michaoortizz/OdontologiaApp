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
using System.Windows.Input;

namespace ProyectoOdontologia2025
{
    public partial class FrmManCita06 : Form
    {
        //defino variables globales 
        SqlCommand comando = new SqlCommand();
        SqlConnection conexion = new SqlConnection("Data Source=localhost; initial catalog=OdontologiaBD; trusted_connection=yes");

        public FrmManCita06()
        {
            InitializeComponent();
        }

        private void gpbInfo_Enter(object sender, EventArgs e)
        {

        }

        public class Option
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        private void FrmManCita06_Load(object sender, EventArgs e)
        {
            //Para mostrar la fecha
            lblfecha2.Text = DateTime.Now.ToShortDateString();


            //Invocar procedimiento para visualizar datos
            RefrescarTabla();

            List<Option> optionsList = new List<Option>
            {
                new Option { Id = 1, Name = "Confirmada" },
                new Option { Id = 2, Name = "Finalizada" },
                new Option { Id = 3, Name = "Pendiente" },
                new Option { Id = 4, Name = "Cancelada" }
            };

            cbEstado.DisplayMember = "Name"; // Property to display in the control
            cbEstado.DataSource = optionsList;
            cbEstado.ValueMember = "Id";
            cbEstado.SelectedIndex = -1;
        }

        private void RefrescarTabla()
        {
            dgvDatos.DataSource = null;
            try
            {
                conexion.Open(); //Abro la conexión
                DataTable datos = new DataTable();
                SqlDataAdapter Adaptador = new SqlDataAdapter("Select * from Citas ", conexion);
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

        private void LimpiarObjetos()
        {
            mtbCed.Text = "";
            txtCita.Clear();
            mtbFecha.Clear();
            mtbFecha.Clear();
            txtDoc.Clear();
            txtUser.Clear();
            txtComentario.Clear();
            txtMotivo.Clear();
            cbEstado.SelectedIndex = -1;
        }

        private void FrmManCita06_Activated(object sender, EventArgs e)
        {
            comando.Connection = conexion;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Para que se muestre la hora
            lblhora2.Text = DateTime.Now.ToLongTimeString();
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCita.Text = dgvDatos[0, dgvDatos.SelectedCells[0].RowIndex].Value.ToString(); 
            mtbCed.Text = dgvDatos[1, dgvDatos.SelectedCells[0].RowIndex].Value.ToString(); 
            txtDoc.Text = dgvDatos[2, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();
            cbEstado.SelectedValue = dgvDatos[3, dgvDatos.SelectedCells[0].RowIndex].Value;
            mtbFecha.Text = dgvDatos[4, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();
            txtMotivo.Text = dgvDatos[5, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();
            txtComentario.Text = dgvDatos[6, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();
            txtUser.Text = dgvDatos[7, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtCita.Text))
            {
                // Agrego registro nuevo respetando el orden y nombres de la imagen 1
                EscribirDatos("Insert into Citas (ced_pac, id_doc, id_eci, fec_cit, mtv_cit, cmt_cit, id_usr) Values ('"
                    + mtbCed.Text.Trim() + "', '"
                    + txtDoc.Text.Trim() + "', '"
                    + cbEstado.SelectedValue + "', '" // Usando el ComboBox de la imagen
                    + mtbFecha.Text.Trim() + "', '"
                    + txtMotivo.Text.Trim() + "', '"
                    + txtComentario.Text.Trim() + "', '"
                    + txtUser.Text.Trim() + "')");

                MessageBox.Show("Nuevo registro guardado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                // Modificar registro existente con los mismos nombres de columna
                EscribirDatos("Update Citas Set ced_pac = '" + mtbCed.Text.Trim() +
                              "', id_doc = '" + txtDoc.Text.Trim() +
                              "', id_eci = '" + cbEstado.SelectedValue +
                              "', fec_cit = '" + mtbFecha.Text.Trim() +
                              "', mtv_cit = '" + txtMotivo.Text.Trim() +
                              "', cmt_cit = '" + txtComentario.Text.Trim() +
                              "', id_usr = '" + txtUser.Text.Trim() +
                              "' where id_cit = '" + txtCita.Text + "'");

                MessageBox.Show("Se actualizó el registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }

            RefrescarTabla(); //Invoco función
            LimpiarObjetos();
        }

        private void lblfecha2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            EscribirDatos("Delete from Citas where id_cit= '" + txtCita.Text + "'");
            MessageBox.Show("Registro borrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            LimpiarObjetos();
            RefrescarTabla();
        }

        private void txtCita_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCita_Click(object sender, EventArgs e)
        {

        }

        private void lblEstado_Click(object sender, EventArgs e)
        {

        }

        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void IdDoc_Click(object sender, EventArgs e)
        {

        }

        private void lblCed_Click(object sender, EventArgs e)
        {

        }

        private void mtbCed_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
    }
