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
        SqlConnection conexion = new SqlConnection("Data Source=132.145.163.113,1433;Initial Catalog=OdontologiaBD;User ID=sa;Password=Admin123@Strong");

        public FrmProReCi03()
        {
            InitializeComponent();
        }
        private void LimpiarObjetos()
        {
            txtCita.Clear();
            cbPaciente.SelectedValue = -1;
            txtDoc.Clear();
            cbEstado.SelectedValue= -1;
            
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

            // Cargar Estados desde DB
            DataTable dtEs = new DataTable();
            SqlDataAdapter daEs = new SqlDataAdapter("SELECT id_eci, nom_eci as Estado FROM Estado_Cita", conexion);
            daEs.Fill(dtEs);
            cbEstado.DataSource = dtEs;
            cbEstado.DisplayMember = "Estado";
            cbEstado.ValueMember = "id_eci";
            cbEstado.SelectedIndex = -1;

            // Cargar Pacientes desde DB
            DataTable dtPac = new DataTable();
            SqlDataAdapter daPac = new SqlDataAdapter("SELECT ced_pac, nom_pac + ' ' + ape_pac as Nombre FROM Pacientes", conexion);
            daPac.Fill(dtPac);
            cbPaciente.DataSource = dtPac;
            cbPaciente.DisplayMember = "Nombre";
            cbPaciente.ValueMember = "ced_pac";
            cbPaciente.SelectedIndex = -1;

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
                dgvCitas.DataSource = fuenteDatos;

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
            // Verificamos que se haya hecho clic en una fila real (no en el encabezado)
            if (e.RowIndex >= 0)
            {
                // Usamos e.RowIndex que es mucho más seguro
                txtCita.Text = dgvCitas[0, e.RowIndex].Value.ToString();
                cbPaciente.SelectedValue = dgvCitas[1, e.RowIndex].Value.ToString();
                txtDoc.Text = dgvCitas[2, e.RowIndex].Value.ToString();
                cbEstado.SelectedValue = dgvCitas[3, e.RowIndex].Value.ToString();

                // Manejo de Fecha para que no le falten dígitos
                if (dgvCitas[4, e.RowIndex].Value != null)
                {
                    DateTime fecha;
                    if (DateTime.TryParse(dgvCitas[4, e.RowIndex].Value.ToString(), out fecha))
                    {
                        mtbFecha.Text = fecha.ToString("dd/MM/yyyy");
                    }
                }

                // El resto de los campos
                
                txtMotivo.Text = dgvCitas[5, e.RowIndex].Value.ToString();
                txtCmt.Text = dgvCitas[6, e.RowIndex].Value?.ToString();
                txtUsu.Text = dgvCitas[7, e.RowIndex].Value?.ToString();
            }
        }

        private void btnGuard_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCita.Text))
            {
                //Agrego registro nuevo
                EscribirDatos("Insert into Citas (ced_pac, id_doc, id_eci, fec_cit, mtv_cit, cmt_cit, id_usr) Values ('" + cbPaciente.SelectedValue + "' , '" + txtDoc.Text.Trim() + "' , '" + cbEstado.SelectedValue + "' , '" + mtbFecha.Text.Trim() + "', '" + txtMotivo.Text.Trim() + "', '" + txtCmt.Text.Trim() + "', '" + txtUsu.Text.Trim() + "')");
                MessageBox.Show("Nuevo registro guardado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                //Modificar un registro existente
                EscribirDatos("Update Citas Set ced_pac = '" + cbPaciente.SelectedValue +
                    "', id_doc = '" + txtDoc.Text.Trim() +
                    "', id_eci = '" + cbEstado.SelectedValue +
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
