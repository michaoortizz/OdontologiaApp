using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;  //Para trabajar con SQL
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace ProyectoOdontologia2025
{
    public partial class FrmManDoct03 : Form
    {
        //defino variables globales 
        SqlCommand comando = new SqlCommand();
        SqlConnection conexion = new SqlConnection("Data Source=localhost; initial catalog=OdontologiaBD; trusted_connection=yes");

        public FrmManDoct03()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        public class Option
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        private void FrmManDoct03_Load(object sender, EventArgs e)
        {
            //Para mostrar la fecha
            lblfecha2.Text = DateTime.Now.ToShortDateString();

            //Invocar procedimiento para visualizar datos
            RefrescarTabla();

            List<Option> optionsList = new List<Option>
            {
                new Option { Id = 1, Name = "Ortodoncia" },
                new Option { Id = 2, Name = "Endodoncia" },
                new Option { Id = 3, Name = "Periodoncia" },
                new Option { Id = 4, Name = "Odontopediatría" },
                new Option { Id = 5, Name = "Rehabilitación" },
                new Option { Id = 6, Name = "Oral/Prostodoncia" },
                new Option { Id = 7, Name = "Cirugía Oral y Maxilofacial" },
                new Option { Id = 8, Name = "Radiología Oral" }
            };                                             

            cbEspe.DataSource = optionsList;
            cbEspe.DisplayMember = "Name"; // Property to display in the control
            cbEspe.ValueMember = "Id";
            cbEspe.SelectedIndex = -1;
        }

        //Creo procedimiento para visualizar los datos en el data grid view
        private void RefrescarTabla()
        {
            dgvDatos.DataSource = null;
            try
            {
                conexion.Open(); //Abro la conexión
                DataTable datos = new DataTable();
                SqlDataAdapter Adaptador = new SqlDataAdapter("Select * from Doctores ", conexion);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmManDoct03_Activated(object sender, EventArgs e)
        {
            comando.Connection = conexion;
        }

        private void Fecha_Tick(object sender, EventArgs e)
        {
            //Para que se muestre la hora
            lblhora2.Text = DateTime.Now.ToLongTimeString();
        }



        private void LimpiarObjetos()
        {
            txtId.Text = "";
            txtNombre.Clear();
            txtApellido.Clear();
            txtEmail.Clear();
            cbEspe.SelectedIndex = 0;
            txtCedula.Clear();
            txtTelefono.Clear();
            txtNombre.Focus();
        }

        private void dgvdoctores_Click(object sender, EventArgs e)
        {
            //Paso los datos del datagridview a los textbox
            txtId.Text = dgvDatos[0, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();
            txtNombre.Text = dgvDatos[1, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();
            txtApellido.Text = dgvDatos[2, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();
            txtCedula.Text = dgvDatos[3, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();
            txtTelefono.Text = dgvDatos[4, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();
            txtEmail.Text = dgvDatos[5, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();
            cbEspe.SelectedValue = dgvDatos[6, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();
        }

      

        private void btnretomar_Click(object sender, EventArgs e)
        {

        }

        private void lblespe_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                //Agrego registro nuevo
                EscribirDatos("Insert into Doctores (nom_doc, ape_doc, ced_doc, tel_doc, eml_doc, id_esp) Values ('" + txtNombre.Text.Trim() + "' , '" + txtApellido.Text.Trim() + "','" + txtCedula.Text.Trim() + "','" + txtTelefono.Text.Trim() + "','" + txtEmail.Text.Trim() + "','" + cbEspe.SelectedValue + "')");
                MessageBox.Show("Nuevo registro guardado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                //Modificar un registro existente
                EscribirDatos("Update Doctores Set nom_doc = '" + txtNombre.Text.Trim() + "', ape_doc = '" + txtApellido.Text.Trim() + "', ced_doc =  '" + txtCedula.Text.Trim() + "', tel_doc =  '" + txtTelefono.Text.Trim() + "', eml_doc =  '" + txtEmail.Text.Trim() + "', id_esp =  '" + cbEspe.SelectedValue + "' where id_doc = '" + txtId.Text + "'");
                MessageBox.Show("Se actualizó el registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }

            RefrescarTabla(); //Invoco función
            LimpiarObjetos();
        }

        private void btnBorrar_Click_1(object sender, EventArgs e)
        {
            EscribirDatos("Delete from Doctores where IdDoctor= '" + txtId.Text + "'");
            MessageBox.Show("Registro borrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            LimpiarObjetos();
            RefrescarTabla();
        }

        private void gpbFecha_Enter(object sender, EventArgs e)
        {



        }
    }
}
