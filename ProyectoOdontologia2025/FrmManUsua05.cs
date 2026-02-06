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

namespace ProyectoOdontologia2025
{
    public partial class FrmManUsua05 : Form
    {

        //defino variables globales 
        SqlCommand comando = new SqlCommand();
        SqlConnection conexion = new SqlConnection("Data Source=localhost; initial catalog=OdontologiaBD; trusted_connection=yes");

        public FrmManUsua05()
        {
            InitializeComponent();
        }

        private void FrmManUsua05_Load(object sender, EventArgs e)
        {
            //Para mostrar la fecha
            lblfecha2.Text = DateTime.Now.ToShortDateString();

            //Invocar procedimiento para visualizar datos
            RefrescarTabla();
        }

        //Creo procedimiento para visualizar los datos en el data grid view
        private void RefrescarTabla()
        {
            dgvDatos.DataSource = null;
            try
            {
                conexion.Open(); //Abro la conexión
                DataTable datos = new DataTable();
                SqlDataAdapter Adaptador = new SqlDataAdapter("Select * from Usuarios", conexion);
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


        private void lblmantenimiento_Click(object sender, EventArgs e)
        {

        }

        private void FrmManUsua05_Activated(object sender, EventArgs e)
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
            txtUsu.Text = "";
            txtNombre.Clear();
            txtNomUsu.Clear();
            txtContra.Clear();
            txtTipo.Clear();
            txtNombre.Focus();
        }

        private void dgvusuarios_Click(object sender, EventArgs e)
        {
            //Paso los datos del datagridview a los textbox
            txtUsu.Text = dgvDatos[0, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();
            txtNombre.Text = dgvDatos[1, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();
            txtNomUsu.Text = dgvDatos[2, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();
            txtContra.Text = dgvDatos[3, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();
            txtTipo.Text = dgvDatos[4, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsu.Text))
            {
                //Agrego registro nuevo
                EscribirDatos("Insert into Usuarios (Nombre, NombreUsuario, Contrasena, TipoUsuario) Values ('" + txtNombre.Text.Trim() + "' , '" + txtNomUsu.Text.Trim() + "', '" + txtContra.Text.Trim() + "', '" + txtTipo.Text.Trim() + "')");
                MessageBox.Show("Nuevo registro guardado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                //Modificar un registro existente
                EscribirDatos("Update Usuarios Set Nombre = '" + txtNombre.Text.Trim() + "', NombreUsuario = '" + txtNomUsu.Text.Trim() + "', Contraseña =  '" + txtContra.Text.Trim() + "', TipoUsuario = '" + txtTipo.Text.Trim() + "' where IdEmpleado = '" + txtUsu.Text + "'");
                MessageBox.Show("Se actualizó el registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }

            RefrescarTabla(); //Invoco función
            LimpiarObjetos();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            EscribirDatos("Delete from Seguros where IdUsuario= '" + txtUsu.Text + "'");
            MessageBox.Show("Registro borrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            LimpiarObjetos();
            RefrescarTabla();
        }
    }
}
