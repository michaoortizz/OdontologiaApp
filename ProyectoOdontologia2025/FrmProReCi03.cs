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
    public partial class FrmProReCi03 : Form
    {
        public FrmProReCi03()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("Server=localhost;Database=OdontologiaBEA;Integrated Security=True;");

        private void RefrescarTabla()
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Citas", conexion);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvCitas.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al refrescar tabla: " + ex.Message);
            }
        }

        private void LimpiarObjetos()
        {
            txtCita.Clear();
            mtbCed.Clear();
            txtDoc.Clear();
            mtbFecha.Clear();
            txtMotivo.Clear();
            txtCmt.Clear();
            txtUsu.Clear();
            cbEstado.SelectedIndex = -1;
        }

        private void EscribirDatos(string query)
        {
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar query: " + ex.Message);
                if (conexion.State == ConnectionState.Open) conexion.Close();
            }
        }

        private void FrmProReCi03_Load(object sender, EventArgs e)
        {
            RefrescarTabla();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblfecha2.Text = DateTime.Now.ToShortDateString();
            lblhora2.Text = DateTime.Now.ToLongTimeString();
        }

        private void lblFechaC_Click(object sender, EventArgs e)
        {

        }

        private void mtbFecha_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dgvCitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCitas.Rows[e.RowIndex];
                txtCita.Text = row.Cells["id_cit"].Value.ToString();
                mtbCed.Text = row.Cells["ced_pac"].Value.ToString();
                txtDoc.Text = row.Cells["id_doc"].Value.ToString();
                mtbFecha.Text = Convert.ToDateTime(row.Cells["fec_cit"].Value).ToShortDateString();
                txtMotivo.Text = row.Cells["mtv_cit"].Value.ToString();
                txtCmt.Text = row.Cells["cmt_cit"].Value.ToString();
                txtUsu.Text = row.Cells["id_usr"].Value.ToString();
                cbEstado.Text = row.Cells["id_eci"].Value.ToString();
            }
        }

        private void FrmProReCi03_Activated(object sender, EventArgs e)
        {
            RefrescarTabla();
        }

        private void btnGuard_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCita.Text))
            {
                //Insertar nuevo registro
                EscribirDatos("Insert into Citas (ced_pac, id_doc, id_eci, fec_cit, mtv_cit, cmt_cit, id_usr) values ('" +
                    mtbCed.Text.Trim() + "','" + txtDoc.Text.Trim() + "','" + cbEstado.Text + "','" + mtbFecha.Text.Trim() + "','" +
                    txtMotivo.Text.Trim() + "','" + txtCmt.Text.Trim() + "','" + txtUsu.Text.Trim() + "')");
                MessageBox.Show("Se guardó el registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                //Modificar un registro existente
                EscribirDatos("Update Citas Set ced_pac = '" + mtbCed.Text.Trim() +
                    "', id_doc = '" + txtDoc.Text.Trim() +
                    "', id_eci = '" + cbEstado.Text +
                    "', fec_cit = '" + mtbFecha.Text.Trim() +
                    "', mtv_cit = '" + txtMotivo.Text.Trim() +
                    "', cmt_cit =  '" + txtCmt.Text.Trim() +
                    "', id_usr = '" + txtUsu.Text.Trim() +
                    "' where id_cit = '" + txtCita.Text + "'");
                MessageBox.Show("Se actualizó el registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }

            RefrescarTabla(); //Invoco función
            LimpiarObjetos();
        }

        private void btnRet_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLim_Click(object sender, EventArgs e)
        {
            LimpiarObjetos();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            EscribirDatos("Delete from Citas where id_cit= '" + txtCita.Text + "'");
            MessageBox.Show("Registro borrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            LimpiarObjetos();
            RefrescarTabla();
        }
    }
}
