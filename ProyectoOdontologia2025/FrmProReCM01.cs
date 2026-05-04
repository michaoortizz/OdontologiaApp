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
    public partial class FrmProReCM01 : Form
    {
        public FrmProReCM01()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("Server=localhost;Database=OdontologiaBEA;Integrated Security=True;");

        private void RefrescarTabla()
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Consultas_Medicas", conexion);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvDatos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al refrescar tabla: " + ex.Message);
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

        private void FrmProReCM01_Load(object sender, EventArgs e)
        {
            RefrescarTabla();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblfecha2.Text = DateTime.Now.ToShortDateString();
            lblhora2.Text = DateTime.Now.ToLongTimeString();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDatos.Rows[e.RowIndex];
                txtCon.Text = row.Cells["id_con"].Value.ToString();
                mtbCed.Text = row.Cells["ced_pac"].Value.ToString();
                txtDoc.Text = row.Cells["id_doc"].Value.ToString();
                mtbFecha.Text = Convert.ToDateTime(row.Cells["fec_con"].Value).ToShortDateString();
                txtMotivo.Text = row.Cells["mtv_con"].Value.ToString();
                txtObs.Text = row.Cells["obs_con"].Value.ToString();
            }
        }

        private void FrmProReCM01_Activated(object sender, EventArgs e)
        {
            RefrescarTabla();
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCon.Text))
            {
                //Insertar
                EscribirDatos("Insert into Consultas_Medicas (ced_pac, id_doc, fec_con, mtv_con, obs_con) values ('" +
                    mtbCed.Text.Trim() + "','" + txtDoc.Text.Trim() + "','" + mtbFecha.Text.Trim() + "','" +
                    txtMotivo.Text.Trim() + "','" + txtObs.Text.Trim() + "')");
                MessageBox.Show("Se guardó el registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                //Actualizar
                EscribirDatos("Update Consultas_Medicas Set ced_pac = '" + mtbCed.Text.Trim() +
                    "', id_doc = '" + txtDoc.Text.Trim() +
                    "', fec_con = '" + mtbFecha.Text.Trim() +
                    "', mtv_con = '" + txtMotivo.Text.Trim() +
                    "', obs_con =  '" + txtObs.Text.Trim() +
                    "' where id_con = '" + txtCon.Text + "'");
                MessageBox.Show("Se actualizó el registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }

            RefrescarTabla();
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
