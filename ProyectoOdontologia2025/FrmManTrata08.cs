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
    public partial class FrmManTrata08 : Form
    {
        //defino variables globales 
        SqlCommand comando = new SqlCommand();
        SqlConnection conexion = new SqlConnection("Data Source=MIAPC; initial catalog=Sistema_Odontologia; trusted_connection=yes");


        public FrmManTrata08()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmManTrata08_Load(object sender, EventArgs e)
        {
            //Invocar procedimiento para visualizar datos
            RefrescarTabla();

            //Para mostrar la fecha
            lblfecha2.Text = DateTime.Now.ToShortDateString();

        }

        private void RefrescarTabla()
        {
            dgvDatos.DataSource = null;
            try
            {
                conexion.Open(); //Abro la conexión
                DataTable datos = new DataTable();
                SqlDataAdapter Adaptador = new SqlDataAdapter("Select * from Tratamiento ", conexion);
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
            txtId.Text = "";
            txtNombre.Clear();
            txtDesc.Clear();
            txtCosto.Clear();
            txtDurac.Clear();
            mtbCed.Clear();
            txtDoc.Clear();
            txtCita.Clear();
            txtNombre.Focus();
        }

        private void FrmManTrata08_Activated(object sender, EventArgs e)
        {
            comando.Connection = conexion;
        }

        private void hora_Tick(object sender, EventArgs e)
        {
            //Para que se muestre la hora
            lblhora2.Text = DateTime.Now.ToLongTimeString();
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Paso los datos del datagridview a los textbox
            txtId.Text = dgvDatos[0, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();
            txtNombre.Text = dgvDatos[1, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();
            txtDesc.Text = dgvDatos[2, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();
            txtCosto.Text = dgvDatos[3, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();
            txtDurac.Text = dgvDatos[4, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();
            txtDoc.Text = dgvDatos[5, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();
            mtbCed.Text = dgvDatos[6, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();
            txtCita.Text = dgvDatos[7, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                //Agrego registro nuevo
                EscribirDatos("Insert into Tratamiento (Nombre, Descripcion, Costo, Duracion, IdDoctor, Cedula, IdCita) Values ('" + txtNombre.Text.Trim() + "' , '" + txtDesc.Text.Trim() + "', '" + txtCosto.Text.Replace(",", ".") + "', '" + txtDurac.Text.Trim() + "', '" + txtDoc.Text.Trim() + "', '" + mtbCed.Text.Trim() + "', '" + txtCita.Text.Trim() + "')");
                MessageBox.Show("Nuevo registro guardado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                //Modificar un registro existente
                EscribirDatos("Update Tratamiento Set Nombre = '" + txtNombre.Text.Trim() + "', Descripcion = '" + txtDesc.Text.Trim() + "', Costo =  '" + txtCosto.Text.Replace(",", ".") + "', Duracion = '" + txtDurac.Text.Trim() + "', IdDoctor = '" + txtDoc.Text.Trim() + "', Cedula =  '" + mtbCed.Text.Trim() + "', IdCita = '" + txtCita.Text.Trim() + "' where IdTratamiento = '" + txtId.Text + "'");
                MessageBox.Show("Se actualizó el registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }

            RefrescarTabla(); //Invoco función
            LimpiarObjetos();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            EscribirDatos("Delete from Tratamiento where IdTratamiento= '" + txtId.Text + "'");
            MessageBox.Show("Registro borrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            LimpiarObjetos();
            RefrescarTabla();
        }
    }
}
