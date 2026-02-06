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
using System.Diagnostics.Eventing.Reader;

namespace ProyectoOdontologia2025
{
    public partial class FrmManSegu01 : Form
    {

        //defino variables globales 
        SqlCommand comando = new SqlCommand();
        SqlConnection conexion = new SqlConnection("Data Source=localhost; initial catalog=OdontologiaBD; trusted_connection=yes");

        public FrmManSegu01()
        {
            InitializeComponent();
        }

        private void FrmManSegu01_Load(object sender, EventArgs e)
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
                SqlDataAdapter Adaptador = new SqlDataAdapter("Select * from Seguros", conexion);
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

        private void FrmManSegu01_Activated(object sender, EventArgs e)
        {
            comando.Connection = conexion;
        }


        private void btnguardar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                //Agrego registro nuevo
                EscribirDatos("Insert into Seguros (Nombre, Telefono) Values ('" + txtNom.Text.Trim() + "' , '" + mtbTel.Text.Trim() + "')");
                MessageBox.Show("Nuevo registro guardado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                //Modificar un registro existente
                EscribirDatos("Update Seguros Set Nombre = '" + txtNom.Text.Trim() + "', Telefono =  '" + mtbTel.Text.Trim() + "' where IdSeguro = '" + txtId.Text + "'");
                MessageBox.Show("Se actualizó el registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }

            RefrescarTabla(); //Invoco función
            LimpiarObjetos();

        }
        private void LimpiarObjetos()
        {
            txtId.Text = "";
            txtNom.Clear();
            mtbTel.Clear();
            txtNom.Focus();
        }

        private void fecha_Tick(object sender, EventArgs e)
        {
            //Para que se muestre la hora
            lblhora2.Text = DateTime.Now.ToLongTimeString();

        }

        private void dgvre_Click(object sender, EventArgs e)
        {
            //Paso los datos del datagridview a los textbox
            txtId.Text = dgvDatos[0, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();
            txtNom.Text = dgvDatos[1, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();
            mtbTel.Text = dgvDatos[2, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();

        }

        

        private void txtnom_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnborrar_Click_1(object sender, EventArgs e)
        {
            EscribirDatos("Delete from Seguros where IdSeguro= '" + txtId.Text + "'");
            MessageBox.Show("Registro borrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            LimpiarObjetos();
            RefrescarTabla();
        }
    }


}

