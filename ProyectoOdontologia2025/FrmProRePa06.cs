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
            cbPaciente.SelectedIndex = -1;
            cbCita.SelectedIndex = -1;
            cbMetPag.SelectedIndex = -1;
            dtpFecha.Value = DateTime.Now;
            txtMonto.Clear();
            txtId.Clear();
        }


        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvDatos[0, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();
            cbPaciente.SelectedValue = dgvDatos[1, dgvDatos.SelectedCells[0].RowIndex].Value;
            cbCita.SelectedValue = dgvDatos[2, dgvDatos.SelectedCells[0].RowIndex].Value;
            cbMetPag.SelectedValue = dgvDatos[3, dgvDatos.SelectedCells[0].RowIndex].Value;
            txtMonto.Text = dgvDatos[4, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();
            dtpFecha.Value = Convert.ToDateTime(dgvDatos[5, dgvDatos.SelectedCells[0].RowIndex].Value);
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

            // Cargar Métodos de Pago desde DB
            DataTable dtMet = new DataTable();
            SqlDataAdapter daMet = new SqlDataAdapter("SELECT id_mpa, nom_mpa FROM Metodos_Pago", conexion);
            daMet.Fill(dtMet);
            cbMetPag.DataSource = dtMet;
            cbMetPag.DisplayMember = "nom_mpa";
            cbMetPag.ValueMember = "id_mpa";
            cbMetPag.SelectedIndex = -1;

            // Cargar Pacientes desde DB
            DataTable dtPac = new DataTable();
            SqlDataAdapter daPac = new SqlDataAdapter("SELECT ced_pac, nom_pac + ' ' + ape_pac as Nombre FROM Pacientes", conexion);
            daPac.Fill(dtPac);
            cbPaciente.DataSource = dtPac;
            cbPaciente.DisplayMember = "Nombre";
            cbPaciente.ValueMember = "ced_pac";
            cbPaciente.SelectedIndex = -1;

            // La carga de Citas se hará cuando se seleccione un paciente
        }

        private void cbPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPaciente.SelectedValue != null && cbPaciente.SelectedIndex != -1)
            {
                string cedula = cbPaciente.SelectedValue.ToString();
                DataTable dtCit = new DataTable();
                // Corregido: fecha_cit -> fec_cit y casteo para concatenación
                SqlDataAdapter daCit = new SqlDataAdapter("SELECT id_cit, CAST(id_cit AS VARCHAR) + ' - ' + CAST(fec_cit AS VARCHAR) as Display FROM Citas WHERE ced_pac = '" + cedula + "'", conexion);
                daCit.Fill(dtCit);
                cbCita.DataSource = dtCit;
                cbCita.DisplayMember = "Display";
                cbCita.ValueMember = "id_cit";
                cbCita.SelectedIndex = -1;
            }
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
            if (string.IsNullOrEmpty(txtId.Text))
            {
                //Agrego registro nuevo
                EscribirDatos("Insert into Pagos (ced_pac, id_cit, id_mpa, mnt_pag, fec_pag) Values ('" + cbPaciente.SelectedValue + "' , '" + cbCita.SelectedValue + "' , '" + cbMetPag.SelectedValue + "' , '" + txtMonto.Text.Trim() + "' , '" + dtpFecha.Value.ToString("yyyy-MM-dd HH:mm:ss") + "')");
                MessageBox.Show("Nuevo registro guardado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                //Modificar un registro existente
                EscribirDatos("Update Pagos Set ced_pac = '" + cbPaciente.SelectedValue +
                    "', id_cit = '" + cbCita.SelectedValue +
                    "', id_mpa = '" + cbMetPag.SelectedValue +
                    "', mnt_pag = '" + txtMonto.Text.Trim() +
                    "', fec_pag =  '" + dtpFecha.Value.ToString("yyyy-MM-dd HH:mm:ss") +
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

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Debe seleccionar un pago de la lista para generar la factura.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idPago = int.Parse(txtId.Text);
            FrmFacturaPreview factura = new FrmFacturaPreview(idPago);
            factura.ShowDialog();
        }
    }
}
