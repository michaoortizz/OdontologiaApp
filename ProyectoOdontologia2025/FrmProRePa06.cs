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
    public partial class FrmProRePa06 : Form
    {
        //defino variables globales 
        SqlCommand comando = new SqlCommand();
        SqlConnection conexion = new SqlConnection("Data Source=132.145.163.113,1433;Initial Catalog=OdontologiaBD;User ID=sa;Password=Admin123@Strong");

        public FrmProRePa06()
        {
            InitializeComponent();
        }

        private void LimpiarObjetos()
        {
            txtCita.Clear();
            mtbCed.Clear();
            cbMetPag.SelectedValue = " ";
            txtCita.Clear();
            mtbFecha.Clear();
            txtMonto.Clear();
        }

        public class Option
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Validación para evitar errores si se hace clic en el encabezado
            if (e.RowIndex >= 0)
            {
                txtId.Text = dgvDatos[0, e.RowIndex].Value.ToString();
                mtbCed.Text = dgvDatos[1, e.RowIndex].Value.ToString();
                txtCita.Text = dgvDatos[2, e.RowIndex].Value.ToString();

                // ASIGNACIÓN DEL MÉTODO DE PAGO
                cbMetPag.SelectedValue = dgvDatos[3, e.RowIndex].Value;

                txtMonto.Text = dgvDatos[4, e.RowIndex].Value.ToString();

                // CORRECCIÓN DE FECHA (Formato completo)
                if (dgvDatos[5, e.RowIndex].Value != null)
                {
                    DateTime fecha;
                    if (DateTime.TryParse(dgvDatos[5, e.RowIndex].Value.ToString(), out fecha))
                    {
                        mtbFecha.Text = fecha.ToString("dd/MM/yyyy");
                    }
                }
            }
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
                SqlDataAdapter Adaptador = new SqlDataAdapter("Select * from Pagos ", conexion);
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

        private void FrmProRePa06_Load(object sender, EventArgs e)
        {
            //Invocar procedimiento para visualizar datos
            RefrescarTabla();

            //Para mostrar la fecha
            lblfecha2.Text = DateTime.Now.ToShortDateString();

            List<Option> optionsList = new List<Option>
            {
                new Option { Id = 1, Name = "Efectivo" },
                new Option { Id = 2, Name = "Tarjeta Crédito" },
                new Option { Id = 3, Name = "Tarjeta Débito" },
                new Option { Id = 4, Name = "Transferencia" },
                new Option { Id = 5, Name = "Seguro" },
                new Option { Id = 6, Name = "Pago Móvil" }
            };

            cbMetPag.DataSource = optionsList;
            cbMetPag.DisplayMember = "Name"; // Property to display in the control
            cbMetPag.ValueMember = "Id";
            cbMetPag.SelectedIndex = -1;
        }

        private void FrmProRePa06_Activated(object sender, EventArgs e)
        {
            comando.Connection = conexion;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblhora2.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Convertimos la fecha del MaskedTextBox a formato SQL
            DateTime fechaConvertida = DateTime.Parse(mtbFecha.Text);
            string fechaSQL = fechaConvertida.ToString("yyyy-MM-dd");

            // Validamos si es un registro nuevo (si txtId está vacío)
            if (string.IsNullOrEmpty(txtId.Text))
            {
                // Insertar usando la variable fechaSQL
                EscribirDatos("Insert into Pagos (ced_pac, id_cit, id_mpa, mnt_pag, fec_pag) Values ('" + mtbCed.Text.Trim() + "' , '" + txtCita.Text.Trim() + "' , '" + cbMetPag.SelectedValue + "' , '" + txtMonto.Text.Trim() + "' , '" + fechaSQL + "')");
                MessageBox.Show("Nuevo registro guardado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Actualizar usando la variable fechaSQL
                EscribirDatos("Update Pagos Set ced_pac = '" + mtbCed.Text.Trim() +
                    "', id_cit = '" + txtCita.Text.Trim() +
                    "', id_mpa = '" + cbMetPag.SelectedValue +
                    "', mnt_pag = '" + txtMonto.Text.Trim() +
                    "', fec_pag =  '" + fechaSQL +
                    "' where id_pag = '" + txtId.Text + "'");
                MessageBox.Show("Se actualizó el registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            RefrescarTabla();
            LimpiarObjetos();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            EscribirDatos("Delete from Pagos where id_pag= '" + txtId.Text + "'");
            MessageBox.Show("Registro borrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            LimpiarObjetos();
            RefrescarTabla();
        }

        private void btnLim_Click(object sender, EventArgs e)
        {
            LimpiarObjetos();
        }
    }
}
