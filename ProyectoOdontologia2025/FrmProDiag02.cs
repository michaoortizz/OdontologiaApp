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
            cbPaciente.SelectedValue = -1;
            txtDoc.Clear();
            mtbFecha.Clear();
            txtDesc.Clear();
            
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

            // Cargar Pacientes desde DB
            DataTable dtPac = new DataTable();
            SqlDataAdapter daPac = new SqlDataAdapter("SELECT ced_pac, nom_pac + ' ' + ape_pac as Nombre FROM Pacientes", conexion);
            daPac.Fill(dtPac);
            cbPaciente.DataSource = dtPac;
            cbPaciente.DisplayMember = "Nombre";
            cbPaciente.ValueMember = "ced_pac";
            cbPaciente.SelectedIndex = -1;
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
            if (e.RowIndex >= 0)
            {
                // Pasamos los textos normales
                txtDiag.Text = dgvDatos[0, e.RowIndex].Value.ToString();
                cbPaciente.SelectedValue = dgvDatos[1, e.RowIndex].Value.ToString();
                txtDoc.Text = dgvDatos[2, e.RowIndex].Value.ToString();
                txtDesc.Text = dgvDatos[4, e.RowIndex].Value.ToString();

                // TRUCO PARA LA FECHA: Convertimos el valor a un formato de fecha corto
                if (dgvDatos[3, e.RowIndex].Value != null)
                {
                    DateTime fecha;
                    if (DateTime.TryParse(dgvDatos[3, e.RowIndex].Value.ToString(), out fecha))
                    {
                        // Esto fuerza a que la fecha tenga el formato día/mes/año completo
                        mtbFecha.Text = fecha.ToString("dd/MM/yyyy");
                    }
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Si txtDiag está vacío, es un registro nuevo
            if (string.IsNullOrEmpty(txtDiag.Text))
            {
                // INSERT: Solo 4 columnas y 4 valores
                string consulta = "Insert into Diagnosticos (ced_pac, id_doc, fecha_dia, descripcion) " +
                                  "Values ('" + cbPaciente.SelectedValue + "', " +
                                  "'" + txtDoc.Text.Trim() + "', " +
                                  "'" + mtbFecha.Text.Trim() + "', " +
                                  "'" + txtDesc.Text.Trim() + "')";

                EscribirDatos(consulta);
                MessageBox.Show("Nuevo registro guardado con éxito", "Aviso");
            }
            else
            {
                // UPDATE: Modificamos los datos usando el ID del diagnóstico
                string consulta = "Update Diagnosticos Set " +
                                  "ced_pac = '" + cbPaciente.SelectedValue + "', " +
                                  "id_doc = '" + txtDoc.Text.Trim() + "', " +
                                  "fecha_dia = '" + mtbFecha.Text.Trim() + "', " +
                                  "descripcion = '" + txtDesc.Text.Trim() + "' " +
                                  "where id_dia = '" + txtDiag.Text + "'";

                EscribirDatos(consulta);
                MessageBox.Show("Registro actualizado correctamente", "Aviso");
            }

            RefrescarTabla();
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
