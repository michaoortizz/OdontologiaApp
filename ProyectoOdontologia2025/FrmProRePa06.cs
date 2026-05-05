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

        SqlConnection conexion = new SqlConnection("Data Source=132.145.163.113,1433;Initial Catalog=OdontologiaBD;User ID=sa;Password=Admin123@Strong");

        private void RefrescarTabla()
        {
            try
            {
                string query = @"SELECT p.id_pag, p.ced_pac, pa.nom_pac + ' ' + pa.ape_pac AS [Paciente], 
                                 p.id_cit, m.nom_mpa AS [met_pag], 
                                 p.mnt_pag AS [mon_pag], p.fec_pag 
                                 FROM Pagos p 
                                 JOIN Metodos_Pago m ON p.id_mpa = m.id_mpa
                                 JOIN Pacientes pa ON p.ced_pac = pa.ced_pac";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvDatos.DataSource = dt;

                // Ocultar columna de cédula si se desea, pero mantenerla para selección
                if (dgvDatos.Columns["ced_pac"] != null) dgvDatos.Columns["ced_pac"].Visible = false;
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
                SqlDataAdapter daPac = new SqlDataAdapter("SELECT ced_pac, nom_pac + ' ' + ape_pac as Nombre FROM Pacientes", conexion);
                DataTable dtPac = new DataTable();
                daPac.Fill(dtPac);
                cbPaciente.DataSource = dtPac;
                cbPaciente.DisplayMember = "Nombre";
                cbPaciente.ValueMember = "ced_pac";
                cbPaciente.SelectedIndex = -1;

                // Cargar Métodos de Pago
                SqlDataAdapter daMet = new SqlDataAdapter("SELECT id_mpa, nom_mpa FROM Metodos_Pago", conexion);
                DataTable dtMet = new DataTable();
                daMet.Fill(dtMet);
                cbMetPag.DataSource = dtMet;
                cbMetPag.DisplayMember = "nom_mpa";
                cbMetPag.ValueMember = "id_mpa";
                cbMetPag.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar combos: " + ex.Message);
            }
        }

        private void CargarCitas(string cedula)
        {
            try
            {
                if (string.IsNullOrEmpty(cedula))
                {
                    cbCita.DataSource = null;
                    return;
                }
                SqlDataAdapter daCit = new SqlDataAdapter("SELECT id_cit, fec_cit FROM Citas WHERE ced_pac = @ced", conexion);
                daCit.SelectCommand.Parameters.AddWithValue("@ced", cedula);
                DataTable dtCit = new DataTable();
                daCit.Fill(dtCit);
                cbCita.DataSource = dtCit;
                cbCita.DisplayMember = "fec_cit";
                cbCita.ValueMember = "id_cit";
                cbCita.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar citas: " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtId.Text))
                {
                    // Insertar
                    string query = "INSERT INTO Pagos (ced_pac, id_cit, id_mpa, mnt_pag, fec_pag) VALUES (@ced, @cita, @met, @mon, @fec)";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@ced", cbPaciente.SelectedValue);
                    cmd.Parameters.AddWithValue("@cita", cbCita.SelectedValue);
                    cmd.Parameters.AddWithValue("@met", cbMetPag.SelectedValue);
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
                    string query = "UPDATE Pagos SET ced_pac=@ced, id_cit=@cita, id_mpa=@met, mnt_pag=@mon, fec_pag=@fec WHERE id_pag=@id";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@id", int.Parse(txtId.Text));
                    cmd.Parameters.AddWithValue("@ced", cbPaciente.SelectedValue);
                    cmd.Parameters.AddWithValue("@cita", cbCita.SelectedValue);
                    cmd.Parameters.AddWithValue("@met", cbMetPag.SelectedValue);
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
                cbMetPag.Text = row.Cells["met_pag"].Value.ToString();
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
            if (cbPaciente.SelectedValue != null && cbPaciente.ValueMember != "")
            {
                CargarCitas(cbPaciente.SelectedValue.ToString());
            }
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
