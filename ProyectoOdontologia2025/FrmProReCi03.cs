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
    public partial class FrmProReCi03 : Form
    {
        //defino variables globales 
        SqlCommand comando = new SqlCommand();
        SqlConnection conexion = new SqlConnection("Data Source=localhost; initial catalog=OdontologiaBD; trusted_connection=yes");

        public FrmProReCi03()
        {
            InitializeComponent();
        }
        private void LimpiarObjetos()
        {
            txtCita.Clear();
            mtbCed.Clear();
            txtDoc.Clear();
            cbEstado.SelectedValue= " ";
            mtbHora.Clear();
            mtbFecha.Clear();
            txtMotivo.Clear();
            txtCmt.Clear();
            txtUsu.Clear();
        }

        public class Option
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        private void FrmProReCi03_Load(object sender, EventArgs e)
        {
            //Invocar procedimiento para visualizar datos
            RefrescarTabla();

            //Para mostrar la fecha
            lblfecha2.Text = DateTime.Now.ToShortDateString();

            List<Option> optionsList = new List<Option>
            {
                new Option { Id = 1, Name = "Confirmada" },
                new Option { Id = 2, Name = "Finalizada" },
                new Option { Id = 3, Name = "Pendiente" },
                new Option { Id = 4, Name = "Cancelada" }
            };

            cbEstado.DataSource = optionsList;
            cbEstado.DisplayMember = "Name"; // Property to display in the control
            cbEstado.ValueMember = "Id";
            cbEstado.SelectedIndex = -1;

        }

        private void FrmProReCi03_Activated(object sender, EventArgs e)
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

        private void lblFechaC_Click(object sender, EventArgs e)
        {

        }

        private void mtbFecha_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblhora2.Text = DateTime.Now.ToLongTimeString();
        }

        private void dgvCitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Paso los datos del datagridview a los textbox
            txtCita.Text = dgvCitas[0, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();
            mtbCed.Text = dgvCitas[1, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();
            txtDoc.Text = dgvCitas[2, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();
            cbEstado.SelectedValue = dgvCitas[3, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();
            mtbFecha.Text = dgvCitas[4, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();
            mtbHora.Text = dgvCitas[5, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();
            txtMotivo.Text = dgvCitas[6, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();
            txtCmt.Text = dgvCitas[7, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();
            txtUsu.Text = dgvCitas[8, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();

        }

        private void btnGuard_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCita.Text))
            {
                //Agrego registro nuevo
                EscribirDatos("Insert into Citas (ced_pac, id_doc, id_eci, fecha_cit, hora_cit, mtv_cit, cmt_cit, id_usr) Values ('" + mtbCed.Text.Trim() + "' , '" + txtDoc.Text.Trim() + "' , '" + cbEstado.SelectedValue + "' , '" + mtbFecha.Text.Trim() + "' , '" + mtbHora.Text.Trim() + "', '" + txtMotivo.Text.Trim() + "', '" + txtCmt.Text.Trim() + "', '" + txtUsu.Text.Trim() + "')");
                MessageBox.Show("Nuevo registro guardado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                //Modificar un registro existente
                EscribirDatos("Update Consultas_Medicas Set ced_pac = '" + mtbCed.Text.Trim() +
                    "', id_doc = '" + txtDoc.Text.Trim() +
                    "', id_eci = '" + cbEstado.SelectedValue +
                    "', fecha_cit = '" + mtbFecha.Text.Trim() +
                    "', hora_cit =  '" + txtMotivo.Text.Trim() +
                    "', mtv_cit = '" + txtMotivo.Text.Trim() +
                    "', cmt_cit =  '" + txtCmt.Text.Trim() +
                    "', id_usr = '" + txtUsu.Text.Trim() +
                    "' where id_cit = '" + txtCita.Text + "'");
                MessageBox.Show("Se actualizó el registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }

            RefrescarTabla(); //Invoco función
            LimpiarObjetos();
        }
    }
}
