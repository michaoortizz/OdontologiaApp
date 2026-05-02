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
    public partial class FrmProReCM01 : Form
    {
        //defino variables globales 
        SqlCommand comando = new SqlCommand();
        SqlConnection conexion = new SqlConnection("Data Source=132.145.163.113,1433;Initial Catalog=OdontologiaBD;User ID=sa;Password=Admin123@Strong");

        public FrmProReCM01()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public class Option
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        private void FrmProReCM01_Load(object sender, EventArgs e)
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
            

        private void FrmProReCM01_Activated(object sender, EventArgs e)
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
                SqlDataAdapter Adaptador = new SqlDataAdapter("Select * from Consultas_Medicas ", conexion);
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

        private void LimpiarObjetos()
        {
            txtCon.Clear();
            cbPaciente.SelectedIndex = -1;
            txtDoc.Clear();
            mtbFecha.Clear();
            txtMotivo.Clear();
            txtObs.Clear();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblhora2.Text = DateTime.Now.ToLongTimeString();
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // 0: id_con, 1: ced_pac, 2: id_doc, 3: fec_con, 4: motivo, 5: observaciones
                txtCon.Text = dgvDatos[0, e.RowIndex].Value.ToString();
                cbPaciente.SelectedValue = dgvDatos[1, e.RowIndex].Value.ToString();
                txtDoc.Text = dgvDatos[2, e.RowIndex].Value.ToString();

                // Corregir Fecha
                if (DateTime.TryParse(dgvDatos[3, e.RowIndex].Value.ToString(), out DateTime f))
                    mtbFecha.Text = f.ToString("dd/MM/yyyy");

                txtMotivo.Text = dgvDatos[4, e.RowIndex].Value.ToString();
                txtObs.Text = dgvDatos[5, e.RowIndex].Value.ToString();

                // El tratamiento no está en la tabla visualmente, 
                // tendrías que seleccionarlo manualmente en el combo 
                // o traer id_trata en el SELECT de RefrescarTabla.
            }
        }

        // 2. CORRECCIÓN DEL BOTÓN GUARDAR (Manejo de ComboBox y Fechas)
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCon.Text))
            {
                // AGREGAR REGISTRO NUEVO
                // Nota: He quitado 'id_trata' para que coincida con tus valores. 
                // Si la agregas, debes ponerla tanto en la lista de columnas como en los Values.
                string consulta = "Insert into Consultas_Medicas (ced_pac, id_doc, fec_con, motivo, observaciones) " +
                                  "Values ('" + cbPaciente.SelectedValue + "', " +
                                  "'" + txtDoc.Text.Trim() + "', " +
                                  "'" + mtbFecha.Text.Trim() + "', " +
                                  "'" + txtMotivo.Text.Trim() + "', " +
                                  "'" + txtObs.Text.Trim() + "')";

                EscribirDatos(consulta);
                MessageBox.Show("Nuevo registro guardado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // MODIFICAR REGISTRO EXISTENTE
                string consulta = "Update Consultas_Medicas Set " +
                                  "ced_pac = '" + cbPaciente.SelectedValue + "', " +
                                  "id_doc = '" + txtDoc.Text.Trim() + "', " +
                                  "fec_con = '" + mtbFecha.Text.Trim() + "', " +
                                  "motivo = '" + txtMotivo.Text.Trim() + "', " +
                                  "observaciones = '" + txtObs.Text.Trim() + "' " +
                                  "where id_con = '" + txtCon.Text + "'";

                EscribirDatos(consulta);
                MessageBox.Show("Se actualizó el registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void cbPac_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
