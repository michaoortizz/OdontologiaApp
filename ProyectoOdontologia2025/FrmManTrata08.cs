using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient; // Para trabajar con SQL
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoOdontologia2025
{
    public partial class FrmManTrata08 : Form
    {
        // Defino variables globales 
        SqlCommand comando = new SqlCommand();
        SqlConnection conexion = new SqlConnection("Data Source=localhost; initial catalog=OdontologiaBD; trusted_connection=yes");

        public FrmManTrata08()
        {
            InitializeComponent();
        }

        // Clase Option para poblar los ComboBox (Igual que en Doctores)
        public class Option
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        private void FrmManTrata08_Load(object sender, EventArgs e)
        {
            // Para mostrar la fecha actual en un label (si tienes uno)
            lblfecha2.Text = DateTime.Now.ToShortDateString();

            // Invocar procedimiento para visualizar datos
            RefrescarTabla();

            // Llenar ComboBox de Tipos de Tratamiento (Ejemplo, ajusta los nombres según tu BD)
            List<Option> listaTipos = new List<Option>
            {
                new Option { Id = 1, Name = "Preventivo" },
                new Option { Id = 2, Name = "Restaurativo" },
                new Option { Id = 3, Name = "Estético" }
            };
            cbTipo.DataSource = listaTipos;
            cbTipo.DisplayMember = "Name";
            cbTipo.ValueMember = "Id";
            cbTipo.SelectedIndex = -1;

            // Llenar ComboBox de Servicios (Ejemplo, ajusta los nombres según tu BD)
            List<Option> listaServicios = new List<Option>
            {
                new Option { Id = 1, Name = "Limpieza" },
                new Option { Id = 2, Name = "Extracción" },
                new Option { Id = 3, Name = "Ortodoncia" }
            };
            cbServicio.DataSource = listaServicios;
            cbServicio.DisplayMember = "Name";
            cbServicio.ValueMember = "Id";
            cbServicio.SelectedIndex = -1;
        }

        private void RefrescarTabla()
        {
            dgvDatos.DataSource = null;
            try
            {
                conexion.Open();
                DataTable datos = new DataTable();
                // Tabla correcta según la base de datos (Tratamientos con 's' al final)
                SqlDataAdapter Adaptador = new SqlDataAdapter("Select * from Tratamientos", conexion);
                Adaptador.Fill(datos);
                BindingSource fuenteDatos = new BindingSource();
                fuenteDatos.DataSource = datos;
                dgvDatos.DataSource = fuenteDatos;
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
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
            txtId.Text = "";
            mtbCed.Clear();
            txtDoc.Clear();
            cbTipo.SelectedIndex = -1;
            cbServicio.SelectedIndex = -1;
            txtDesc.Clear();
            txtCosto.Clear();
            dtpFechaIni.Value = DateTime.Now;
            dtpFechaFin.Value = DateTime.Now;
            txtNombre.Clear();
            txtDurac.Clear();
            txtCita.Clear();
            mtbCed.Focus();
        }

        private void FrmManTrata08_Activated(object sender, EventArgs e)
        {
            comando.Connection = conexion;
        }

        private void hora_Tick(object sender, EventArgs e)
        {
            lblhora2.Text = DateTime.Now.ToLongTimeString();
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Respetando el orden estricto de la tabla Tratamientos (Imagen 5)
            int fila = dgvDatos.SelectedCells[0].RowIndex;

            txtId.Text = dgvDatos[0, fila].Value.ToString();          // id_tra
            mtbCed.Text = dgvDatos[1, fila].Value.ToString();         // ced_pac
            txtDoc.Text = dgvDatos[2, fila].Value.ToString();         // id_doc
            cbTipo.SelectedValue = dgvDatos[3, fila].Value;           // id_ttr
            cbServicio.SelectedValue = dgvDatos[4, fila].Value;       // id_srv
            txtDesc.Text = dgvDatos[5, fila].Value.ToString();        // dsc_tra
            txtCosto.Text = dgvDatos[6, fila].Value.ToString();       // cst_tra
            dtpFechaIni.Text = dgvDatos[7, fila].Value.ToString();      // fec_ini_tra
            dtpFechaFin.Text = dgvDatos[8, fila].Value.ToString();         // fec_fin_tra
            txtNombre.Text = dgvDatos[9, fila].Value.ToString();      // nom_tra
            txtDurac.Text = dgvDatos[10, fila].Value.ToString();      // dur_tra
            txtCita.Text = dgvDatos[11, fila].Value.ToString();       // id_cit
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Convertimos las fechas al formato compatible con SQL (YYYY-MM-DD)
            string fechaInicio = dtpFechaIni.Value.ToString("yyyy-MM-dd");
            string fechaFin = dtpFechaFin.Value.ToString("yyyy-MM-dd");

            if (string.IsNullOrEmpty(txtId.Text))
            {
                // Insert respetando el esquema de la base de datos
                EscribirDatos("Insert into Tratamientos (ced_pac, id_doc, id_ttr, id_srv, dsc_tra, cst_tra, fec_ini_tra, fec_fin_tra, nom_tra, dur_tra, id_cit) Values ('"
                    + mtbCed.Text.Trim() + "' , '"
                    + txtDoc.Text.Trim() + "', '"
                    + cbTipo.SelectedValue + "', '"
                    + cbServicio.SelectedValue + "', '"
                    + txtDesc.Text.Trim() + "', '"
                    + txtCosto.Text.Replace(",", ".") + "', '"
                    + fechaInicio + "', '"
                    + fechaFin + "', '"
                    + txtNombre.Text.Trim() + "', '"
                    + txtDurac.Text.Trim() + "', '"
                    + txtCita.Text.Trim() + "')");

                MessageBox.Show("Nuevo registro guardado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                // Update respetando el esquema de la base de datos
                EscribirDatos("Update Tratamientos Set ced_pac = '" + mtbCed.Text.Trim() +
                              "', id_doc = '" + txtDoc.Text.Trim() +
                              "', id_ttr = '" + cbTipo.SelectedValue +
                              "', id_srv = '" + cbServicio.SelectedValue +
                              "', dsc_tra = '" + txtDesc.Text.Trim() +
                              "', cst_tra = '" + txtCosto.Text.Replace(",", ".") +
                              "', fec_ini_tra = '" + fechaInicio +
                              "', fec_fin_tra = '" + fechaFin +
                              "', nom_tra = '" + txtNombre.Text.Trim() +
                              "', dur_tra = '" + txtDurac.Text.Trim() +
                              "', id_cit = '" + txtCita.Text.Trim() +
                              "' where id_tra = '" + txtId.Text + "'");

                MessageBox.Show("Se actualizó el registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }

            RefrescarTabla();
            LimpiarObjetos();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            // La PK se llama id_tra según la Imagen 5
            EscribirDatos("Delete from Tratamientos where id_tra = '" + txtId.Text + "'");
            MessageBox.Show("Registro borrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            LimpiarObjetos();
            RefrescarTabla();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}