using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;  //Para trabajar con SQL
using System.Threading;
using System.Globalization;
using System.Windows.Input;

namespace ProyectoOdontologia2025
{
    public partial class FrmManPaci02 : Form
    {
        //defino variables globales 
        SqlCommand comando = new SqlCommand();
        SqlConnection conexion = new SqlConnection("Data Source=localhost; initial catalog=OdontologiaBD; trusted_connection=yes");

        public FrmManPaci02()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void FrmManPaci02_Load(object sender, EventArgs e)
        {
            //Para mostrar la fecha
            lblfecha2.Text = DateTime.Now.ToShortDateString();


            //Invocar procedimiento para visualizar datos
            RefrescarTabla();
        }

        //Creo procedimiento para visualizar los datos en el data grid view
        private void RefrescarTabla()
        {
            dgvpacientes.DataSource = null;
            try
            {
                conexion.Open(); //Abro la conexión
                DataTable datos = new DataTable();
                SqlDataAdapter Adaptador = new SqlDataAdapter("Select * from Pacientes ", conexion);
                Adaptador.Fill(datos);
                BindingSource fuenteDatos = new BindingSource();
                fuenteDatos.DataSource = datos;
                dgvpacientes.DataSource = fuenteDatos;

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
            //Permite ejectuar las instrucciones recibidas en Parametro en la base de datos
            comando.CommandText = Parametro;
            conexion.Open();
            comando.Transaction = conexion.BeginTransaction();
            comando.ExecuteNonQuery();
            comando.Transaction.Commit();
            conexion.Close();
        }

        private void LimpiarObjetos()
        {
            mtbCed.Text = "";
            txtNombre.Clear();
            txtApellido.Clear();
            mtbFecha.Clear();
            txtTipo.Clear();
            mtbTel.Clear();
            txtCondi.Clear();
            txtCorreo.Clear();
            txtSeguro.Clear();
            txtNombre.Focus();
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmManPaci02_Activated(object sender, EventArgs e)
        {
            comando.Connection = conexion;
        }

        private void Fecha_Tick(object sender, EventArgs e)
        {
            //Para que se muestre la hora
            lblhora2.Text = DateTime.Now.ToLongTimeString();

        }



        private void dgvpacientes_Click(object sender, EventArgs e)
        {
            mtbCed.Text = dgvpacientes[0, dgvpacientes.SelectedCells[0].RowIndex].Value.ToString();
            txtNombre.Text = dgvpacientes[1, dgvpacientes.SelectedCells[0].RowIndex].Value.ToString();
            txtApellido.Text = dgvpacientes[2, dgvpacientes.SelectedCells[0].RowIndex].Value.ToString();
            mtbFecha.Text = dgvpacientes[3, dgvpacientes.SelectedCells[0].RowIndex].Value.ToString();
            txtTipo.Text = dgvpacientes[4, dgvpacientes.SelectedCells[0].RowIndex].Value.ToString();
            mtbTel.Text = dgvpacientes[5, dgvpacientes.SelectedCells[0].RowIndex].Value.ToString();
            txtCondi.Text = dgvpacientes[6, dgvpacientes.SelectedCells[0].RowIndex].Value.ToString();
            txtCorreo.Text = dgvpacientes[7, dgvpacientes.SelectedCells[0].RowIndex].Value.ToString();
            txtSeguro.Text = dgvpacientes[8, dgvpacientes.SelectedCells[0].RowIndex].Value.ToString();


        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT 1 FROM Pacientes WHERE Cedula = '" + mtbCed.Text.Trim() + "'", conexion);
            SqlDataReader reader = cmd.ExecuteReader();
            bool existe = reader.Read();
            reader.Close();
            conexion.Close();

            if (existe)
            {
                EscribirDatos("UPDATE Pacientes SET Nombre = '" + txtNombre.Text.Trim() +
                              "', Apellido = '" + txtApellido.Text.Trim() +
                              "', FechaNac = '" + mtbFecha.Text.Trim() +
                              "', TipoPaciente = '" + txtTipo.Text.Trim() +
                              "', Telefono = '" + mtbTel.Text.Trim() +
                              "', CondicionSalud = '" + txtCondi.Text.Trim() +
                              "', Correo = '" + txtCorreo.Text.Trim() +
                              "', IdSeguro = '" + txtSeguro.Text.Trim() +
                              "' WHERE Cedula = '" + mtbCed.Text.Trim() + "'");
                MessageBox.Show("Registro actualizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

            }
            {
                EscribirDatos("INSERT INTO Pacientes (Cedula, Nombre, Apellido, FechaNac, TipoPaciente, Telefono, CondicionSalud, Correo, IdSeguro) VALUES ('" +
                              mtbCed.Text.Trim() + "', '" +
                              txtNombre.Text.Trim() + "', '" +
                              txtApellido.Text.Trim() + "', '" +
                              mtbFecha.Text.Trim() + "', '" +
                              txtTipo.Text.Trim() + "', '" +
                              mtbTel.Text.Trim() + "', '" +
                              txtCondi.Text.Trim() + "', '" +
                              txtCorreo.Text.Trim() + "', '" +
                              txtSeguro.Text.Trim() + "')");
                MessageBox.Show("Nuevo registro guardado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            conexion.Close();

            RefrescarTabla(); //Invoco función
            LimpiarObjetos();
        }

        private void btnBorrar_Click_1(object sender, EventArgs e)
        {
            EscribirDatos("Delete from Pacientes where Cedula = '" + mtbCed.Text + "'");
            MessageBox.Show("Se borró el registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarObjetos();
            RefrescarTabla();
        }
    }
}
