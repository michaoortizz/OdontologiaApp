using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoOdontologia2025
{
    public partial class FrmProReCM01 : Form
    {
        //defino variables globales 
        SqlCommand comando = new SqlCommand();
        SqlConnection conexion = new SqlConnection("Data Source=localhost; initial catalog=OdontologiaBD; trusted_connection=yes");


        public FrmProReCM01()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public class Option
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        private void FrmProReCM01_Load(object sender, EventArgs e)
        {
            //Invocar procedimiento para visualizar datos
            RefrescarTabla();

            //Para mostrar la fecha
            lblfecha2.Text = DateTime.Now.ToShortDateString();

            List<Option> optionsList = new List<Option>
            {
                new Option { Id = 1, Name = "Tratamiento inicial" }
            };

            cbTrata.DataSource = optionsList;
            cbTrata.DisplayMember = "Name"; // Property to display in the control
            cbTrata.ValueMember = "Id";
            cbTrata.SelectedIndex = -1;

        }

        private void FrmProReCM01_Activated(object sender, EventArgs e)
        {
            comando.Connection = conexion;
        }

        private void RefrescarTabla()
        {
            dgvDatos.DataSource = null;
            try
            {
                conexion.Open(); //Abro la conexión
                DataTable datos = new DataTable();
                SqlDataAdapter Adaptador = new SqlDataAdapter("Select * from Consultas_Medicas ", conexion);
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
            txtCon.Clear();
            mtbCed.Clear();
            txtDoc.Clear();
            mtbFecha.Clear();
            txtMotivo.Clear();
            txtObs.Clear();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblhora2.Text = DateTime.Now.ToLongTimeString();
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Paso los datos del datagridview a los textbox
            txtCon.Text = dgvDatos[0, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();
            txtCita.Text = dgvDatos[1, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();
            mtbCed.Text = dgvDatos[2, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();
            txtDoc.Text = dgvDatos[3, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();
            cbTrata.SelectedValue = dgvDatos[4, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();
            mtbFecha.Text = dgvDatos[5, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();
            txtMotivo.Text = dgvDatos[6, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();
            txtObs.Text = dgvDatos[7, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCon.Text))
            {
                //Agrego registro nuevo
                EscribirDatos("Insert into Consultas_Medicas (id_cita, ced_pac, id_doc, id_trata, fec_con, motivo, observaciones) Values ('" + txtCita.Text.Trim() + "' , '" + mtbCed.Text.Trim() + "' , '" + txtDoc.Text.Trim() + "' , '" + cbTrata.SelectedValue +"' , '" + mtbFecha.Text.Trim() + "', '" + txtMotivo.Text.Trim() + "', '" + txtObs.Text.Trim() + "')");
                MessageBox.Show("Nuevo registro guardado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                //Modificar un registro existente
                EscribirDatos("Update Consultas_Medicas Set id_cita = '" + txtCita.Text.Trim() +
                    "', ced_pac = '" + mtbCed.Text.Trim() +
                    "', id_doc = '" + txtDoc.Text.Trim() +
                    "', id_trata = '" + cbTrata.SelectedValue +
                    "', fec_con = '" + mtbFecha.Text.Trim() +
                    "', motivo =  '" + txtMotivo.Text.Trim() +
                    "', observaciones = '" + txtObs.Text.Trim() +
                    "' where id_con = '" + txtCon.Text + "'");
                MessageBox.Show("Se actualizó el registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }

            RefrescarTabla(); //Invoco función
            LimpiarObjetos();
        }

        private void btnLim_Click(object sender, EventArgs e)
        {
            LimpiarObjetos();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            EscribirDatos("Delete from Consultas_Medicas where id_con= '" + txtCon.Text + "'");
            MessageBox.Show("Registro borrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            LimpiarObjetos();
            RefrescarTabla();
        }
    }
}
