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
    public partial class FrmProCoti05 : Form
    {

        //defino variables globales 
        SqlCommand comando = new SqlCommand();
        SqlConnection conexion = new SqlConnection("Data Source=132.145.163.113,1433;Initial Catalog=OdontologiaBD;User ID=sa;Password=Admin123@Strong");

        public FrmProCoti05()
        {
            InitializeComponent();
        }

        private void FrmProCoti05_Load(object sender, EventArgs e)
        {
            //Invocar procedimiento para visualizar datos
            RefrescarTabla();

            //Para mostrar la fecha
            lblfecha2.Text = DateTime.Now.ToShortDateString();

            // Cargar Pacientes desde DB
            DataTable dtPac = new DataTable();
            SqlDataAdapter daPac = new SqlDataAdapter("SELECT ced_pac, nom_pac + ' ' + ape_pac as Nombre FROM Pacientes", conexion);
            daPac.Fill(dtPac);
            cbPaciente.DataSource = dtPac;
            cbPaciente.DisplayMember = "Nombre";
            cbPaciente.ValueMember = "ced_pac";
            cbPaciente.SelectedIndex = -1;
        }
        private void LimpiarObjetos()
        {
            txtId.Clear();
            cbPaciente.SelectedValue = -1;
            txtMonto.Clear();
            mtbFecha.Clear();
            txtDet.Clear();
            
        }

        private void btnLim_Click(object sender, EventArgs e)
        {
            LimpiarObjetos();
        }

        private void RefrescarTabla()
        {
            dgvDatos.DataSource = null;
            try
            {
                conexion.Open(); //Abro la conexión
                DataTable datos = new DataTable();
                SqlDataAdapter Adaptador = new SqlDataAdapter("Select * from Cotizaciones", conexion);
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

        private void timer_Tick(object sender, EventArgs e)
        {
            lblhora2.Text = DateTime.Now.ToLongTimeString();
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificamos que se haya hecho clic en una fila con datos real
            if (e.RowIndex >= 0)
            {
                // 0=id_coti, 1=ced_pac, 2=fecha_coti, 3=monto, 4=detalle
                txtId.Text = dgvDatos[0, e.RowIndex].Value.ToString();
                cbPaciente.SelectedValue = dgvDatos[1, e.RowIndex].Value.ToString();

                // --- CORRECCIÓN DE FECHA ---
                if (dgvDatos[2, e.RowIndex].Value != null)
                {
                    DateTime fecha;
                    // Intentamos convertir el valor a un objeto DateTime
                    if (DateTime.TryParse(dgvDatos[2, e.RowIndex].Value.ToString(), out fecha))
                    {
                        // Forzamos el formato dd/MM/yyyy para llenar todos los dígitos del MaskedTextBox
                        mtbFecha.Text = fecha.ToString("dd/MM/yyyy");
                    }
                    else
                    {
                        mtbFecha.Text = dgvDatos[2, e.RowIndex].Value.ToString();
                    }
                }
                // ---------------------------

                txtMonto.Text = dgvDatos[3, e.RowIndex].Value.ToString();
                txtDet.Text = dgvDatos[4, e.RowIndex].Value.ToString();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Convertimos la fecha al formato que SQL entiende (YYYY-MM-DD)
            DateTime fechaConvertida = DateTime.Parse(mtbFecha.Text);
            string fechaSQL = fechaConvertida.ToString("yyyy-MM-dd");

            if (string.IsNullOrEmpty(txtId.Text))
            {
                // INSERT: Usando la variable fechaSQL
                EscribirDatos("Insert into Cotizaciones (ced_pac, fecha_coti, monto, detalle) Values ('" + cbPaciente.SelectedValue + "' , '" + fechaSQL + "' , '" + txtMonto.Text.Trim() + "' , '" + txtDet.Text.Trim() + "')");
                MessageBox.Show("Nuevo registro guardado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                // UPDATE: Usando la variable fechaSQL
                EscribirDatos("Update Cotizaciones Set ced_pac = '" + cbPaciente.SelectedValue +
                    "', fecha_coti = '" + fechaSQL +
                    "', monto = '" + txtMonto.Text.Trim() +
                    "', detalle =  '" + txtDet.Text.Trim() +
                    "' where id_coti = '" + txtId.Text + "'");
                MessageBox.Show("Se actualizó el registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }

            RefrescarTabla();
            LimpiarObjetos();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            EscribirDatos("Delete from Cotizaciones where id_coti= '" + txtId.Text + "'");
            MessageBox.Show("Registro borrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            LimpiarObjetos();
            RefrescarTabla();
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmProCoti05_Activated(object sender, EventArgs e)
        {
            comando.Connection = conexion;
        }
    }
}
