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
    public partial class FrmProDiag02 : Form
    {
        //defino variables globales 
        SqlCommand comando = new SqlCommand();
        SqlConnection conexion = new SqlConnection("Data Source=132.145.163.113,1433;Initial Catalog=OdontologiaBD;User ID=sa;Password=Admin123@Strong");


        public FrmProDiag02()
        {
            InitializeComponent();
        }

        private void LimpiarObjetos()
        {
            txtDiag.Clear();
            mtbCed.Clear();
            txtDoc.Clear();
            mtbFecha.Clear();
            txtDesc.Clear();
            txtCon.Clear();
        }

        private void btnLim_Click(object sender, EventArgs e)
        {
            LimpiarObjetos();
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RefrescarTabla()
        {
            dgvDatos.DataSource = null;
            try
            {
                conexion.Open(); //Abro la conexión
                DataTable datos = new DataTable();
                SqlDataAdapter Adaptador = new SqlDataAdapter("Select * from Diagnosticos ", conexion);
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

        private void FrmProDiag02_Load(object sender, EventArgs e)
        {
            //Invocar procedimiento para visualizar datos
            RefrescarTabla();

            //Para mostrar la fecha
            lblfecha2.Text = DateTime.Now.ToShortDateString();

        }

        private void FrmProDiag02_Activated(object sender, EventArgs e)
        {
            comando.Connection = conexion;
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

        private void timer_Tick(object sender, EventArgs e)
        {
            lblhora2.Text = DateTime.Now.ToLongTimeString();
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Paso los datos del datagridview a los textbox
            txtDiag.Text = dgvDatos[0, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();
            mtbCed.Text = dgvDatos[1, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();
            txtDoc.Text = dgvDatos[2, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();
            mtbFecha.Text = dgvDatos[3, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();
            txtDesc.Text = dgvDatos[4, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();
            txtCon.Text = dgvDatos[5, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCon.Text))
            {
                //Agrego registro nuevo
                EscribirDatos("Insert into Diagnosticos (ced_pac, id_doc, fecha_dia, descripcion, id_con) Values ('" + mtbCed.Text.Trim() + "' , '" + txtDoc.Text.Trim() + "' , '" + mtbFecha.Text.Trim() + "' , '" + txtDesc.Text.Trim() + "' , '" + txtCon.Text.Trim() + "')");
                MessageBox.Show("Nuevo registro guardado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                //Modificar un registro existente
                EscribirDatos("Update Diagnosticos Set ced_pac = '" + mtbCed.Text.Trim() +
                    "', id_doc = '" + txtDoc.Text.Trim() +
                    "', fecha_dia = '" + mtbFecha.Text.Trim() +
                    "', descripcion =  '" + txtDesc.Text.Trim() +
                    "', id_con = '" + txtCon.Text.Trim() +
                    "' where id_dia = '" + txtDiag.Text + "'");
                MessageBox.Show("Se actualizó el registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }

            RefrescarTabla(); //Invoco función
            LimpiarObjetos();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            EscribirDatos("Delete from Diagnosticos where id_dia= '" + txtDiag.Text + "'");
            MessageBox.Show("Registro borrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            LimpiarObjetos();
            RefrescarTabla();
        }
    }
}
