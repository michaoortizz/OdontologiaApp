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
    public partial class FrmManMate09 : Form
    {

        //defino variables globales 
        SqlCommand comando = new SqlCommand();
        SqlConnection conexion = new SqlConnection("Data Source=localhost; initial catalog=OdontologiaBD; trusted_connection=yes");

        public FrmManMate09()
        {
            InitializeComponent();
        }

        private void FrmManMate09_Load(object sender, EventArgs e)
        {
            //Invocar procedimiento para visualizar datos
            RefrescarTabla();

            //Para mostrar la fecha
            lblfecha2.Text = DateTime.Now.ToShortDateString();

        }

        private void FrmManMate09_Activated(object sender, EventArgs e)
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
                SqlDataAdapter Adaptador = new SqlDataAdapter("Select * from Materiales ", conexion);
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
            txtId.Clear();
            txtNombre.Clear();
            mtbCant.Clear();
            mtbCosto.Clear();
            txtTipo.Clear();
            txtProve.Clear();
            txtNombre.Focus();
        }

        private void hora_Tick(object sender, EventArgs e)
        {
            // Para que se muestre la hora
            lblhora2.Text = DateTime.Now.ToLongTimeString();
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Paso los datos del datagridview a los textbox
            txtId.Text = dgvDatos[0, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();
            txtNombre.Text = dgvDatos[1, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();
            mtbCant.Text = dgvDatos[2, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();
            mtbCosto.Text = dgvDatos[3, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();
            txtTipo.Text = dgvDatos[4, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();
            txtProve.Text = dgvDatos[5, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                //Agrego registro nuevo
                EscribirDatos("Insert into Materiales (Nombre, Cantidad, Costo, Tipo, IdProveedor) Values ('" + txtNombre.Text.Trim() + "' , '" + mtbCant.Text.Trim() + "', '" + mtbCosto.Text.Trim() + "', '" + txtTipo.Text.Trim() + "', '" + txtProve.Text.Trim() + "')");
                MessageBox.Show("Nuevo registro guardado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                //Modificar un registro existente
                EscribirDatos("Update Materiales Set Nombre = '" + txtNombre.Text.Trim() + "', Cantidad = '" + mtbCant.Text.Trim() + "', Costo =  '" + mtbCosto.Text.Trim() + "', Tipo = '" + txtTipo.Text.Trim() + "', IdProveedor = '" + txtProve.Text.Trim() + "' where IdMaterial = '" + txtId.Text + "'");
                MessageBox.Show("Se actualizó el registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }

            RefrescarTabla(); //Invoco función
            LimpiarObjetos();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            EscribirDatos("Delete from Materiales where IdMaterial= '" + txtId.Text + "'");
            MessageBox.Show("Registro borrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            LimpiarObjetos();
            RefrescarTabla();
        }
    }
}
