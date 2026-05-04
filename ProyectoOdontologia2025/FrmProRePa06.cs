using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProyectoOdontologia2025
{
    public partial class FrmProRePa06 : Form
    {
        public FrmProRePa06()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("Server=localhost;Database=OdontologiaBEA;Integrated Security=True;");

        private void RefrescarTabla()
        {
            try
            {
                string query = "SELECT * FROM Pagos";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvDatos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

        private void LimpiarObjetos()
        {
            txtId.Clear();
            cbPaciente.SelectedIndex = -1;
            cbCita.SelectedIndex = -1;
            cbMetPag.SelectedIndex = -1;
            txtMonto.Clear();
            dtpFecha.Value = DateTime.Now;
        }

        private void FrmProRePa06_Load(object sender, EventArgs e)
        {
            RefrescarTabla();
            CargarCombos();
        }

        private void CargarCombos()
        {
            try
            {
                // Cargar Pacientes
                SqlDataAdapter daPac = new SqlDataAdapter("SELECT ced_pac, nom_pac FROM Pacientes", conexion);
                DataTable dtPac = new DataTable();
                daPac.Fill(dtPac);
                cbPaciente.DataSource = dtPac;
                cbPaciente.DisplayMember = "ced_pac";
                cbPaciente.ValueMember = "ced_pac";
                cbPaciente.SelectedIndex = -1;

                // Cargar Citas
                SqlDataAdapter daCit = new SqlDataAdapter("SELECT id_cit FROM Citas", conexion);
                DataTable dtCit = new DataTable();
                daCit.Fill(dtCit);
                cbCita.DataSource = dtCit;
                cbCita.DisplayMember = "id_cit";
                cbCita.ValueMember = "id_cit";
                cbCita.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar combos: " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtId.Text))
                {
                    // Insertar
                    string query = "INSERT INTO Pagos (ced_pac, id_cit, met_pag, mon_pag, fec_pag) VALUES (@ced, @cita, @met, @mon, @fec)";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@ced", cbPaciente.SelectedValue);
                    cmd.Parameters.AddWithValue("@cita", cbCita.SelectedValue);
                    cmd.Parameters.AddWithValue("@met", cbMetPag.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@mon", decimal.Parse(txtMonto.Text));
                    cmd.Parameters.AddWithValue("@fec", dtpFecha.Value);

                    conexion.Open();
                    cmd.ExecuteNonQuery();
                    conexion.Close();
                    MessageBox.Show("Pago registrado correctamente.");
                }
                else
                {
                    // Actualizar
                    string query = "UPDATE Pagos SET ced_pac=@ced, id_cit=@cita, met_pag=@met, mon_pag=@mon, fec_pag=@fec WHERE id_pag=@id";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@id", int.Parse(txtId.Text));
                    cmd.Parameters.AddWithValue("@ced", cbPaciente.SelectedValue);
                    cmd.Parameters.AddWithValue("@cita", cbCita.SelectedValue);
                    cmd.Parameters.AddWithValue("@met", cbMetPag.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@mon", decimal.Parse(txtMonto.Text));
                    cmd.Parameters.AddWithValue("@fec", dtpFecha.Value);

                    conexion.Open();
                    cmd.ExecuteNonQuery();
                    conexion.Close();
                    MessageBox.Show("Pago actualizado correctamente.");
                }
                RefrescarTabla();
                LimpiarObjetos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
                if (conexion.State == ConnectionState.Open) conexion.Close();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text)) return;
            if (MessageBox.Show("¿Está seguro de borrar este registro?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    string query = "DELETE FROM Pagos WHERE id_pag=@id";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@id", int.Parse(txtId.Text));
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                    conexion.Close();
                    RefrescarTabla();
                    LimpiarObjetos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al borrar: " + ex.Message);
                    if (conexion.State == ConnectionState.Open) conexion.Close();
                }
            }
        }

        private void btnLim_Click(object sender, EventArgs e)
        {
            LimpiarObjetos();
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDatos.Rows[e.RowIndex];
                txtId.Text = row.Cells["id_pag"].Value.ToString();
                cbPaciente.SelectedValue = row.Cells["ced_pac"].Value.ToString();
                cbCita.SelectedValue = row.Cells["id_cit"].Value.ToString();
                cbMetPag.SelectedItem = row.Cells["met_pag"].Value.ToString();
                txtMonto.Text = row.Cells["mon_pag"].Value.ToString();
                dtpFecha.Value = Convert.ToDateTime(row.Cells["fec_pag"].Value);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblfecha2.Text = DateTime.Now.ToShortDateString();
            lblhora2.Text = DateTime.Now.ToLongTimeString();
        }

        private void FrmProRePa06_Activated(object sender, EventArgs e)
        {
            RefrescarTabla();
        }

        private void cbPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Seleccione un pago para generar factura.");
                return;
            }

            int idPago = int.Parse(txtId.Text);
            FrmFacturaPreview factura = new FrmFacturaPreview(idPago);
            factura.ShowDialog();
        }
    }
}
