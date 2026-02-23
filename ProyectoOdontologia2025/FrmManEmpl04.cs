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
    public partial class FrmManEmpl04 : Form
    {
        //defino variables globales 
        SqlCommand comando = new SqlCommand();
        SqlConnection conexion = new SqlConnection("Data Source=localhost; initial catalog=OdontologiaBD; trusted_connection=yes");

        public FrmManEmpl04()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void FrmManEmpl04_Load(object sender, EventArgs e)
        {
            //Invocar procedimiento para visualizar datos
            RefrescarTabla();

            //Para mostrar la fecha
            lblfecha2.Text = DateTime.Now.ToShortDateString();

        }


        //Creo procedimiento para visualizar los datos en el data grid view
        private void RefrescarTabla()
        {
            dgvempleados.DataSource = null;
            try
            {
                conexion.Open(); //Abro la conexión
                DataTable datos = new DataTable();
                SqlDataAdapter Adaptador = new SqlDataAdapter("Select * from Empleados ", conexion);
                Adaptador.Fill(datos);
                BindingSource fuenteDatos = new BindingSource();
                fuenteDatos.DataSource = datos;
                dgvempleados.DataSource = fuenteDatos;

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
            txtId.Text = "";
            txtNombre.Clear();
            txtApellido.Clear();
            txtDirec.Clear();
            mtbTel.Clear();
            txtCargo.Clear();
            txtNombre.Focus();
        }

        private void FrmManEmpl04_Activated(object sender, EventArgs e)
        {
            comando.Connection = conexion;
        }

        private void fecha_Tick(object sender, EventArgs e)
        {
            //Para que se muestre la hora
            lblhora2.Text = DateTime.Now.ToLongTimeString();
        }

        private void dgvempleados_Click(object sender, EventArgs e)
        {
            //Paso los datos del datagridview a los textbox
            txtId.Text = dgvempleados[0, dgvempleados.SelectedCells[0].RowIndex].Value.ToString();
            txtNombre.Text = dgvempleados[1, dgvempleados.SelectedCells[0].RowIndex].Value.ToString();
            txtApellido.Text = dgvempleados[2, dgvempleados.SelectedCells[0].RowIndex].Value.ToString();
            txtDirec.Text = dgvempleados[3, dgvempleados.SelectedCells[0].RowIndex].Value.ToString();
            mtbTel.Text = dgvempleados[4, dgvempleados.SelectedCells[0].RowIndex].Value.ToString();
            txtCargo.Text = dgvempleados[5, dgvempleados.SelectedCells[0].RowIndex].Value.ToString();

        }


        private void dgvempleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                //Agrego registro nuevo
                EscribirDatos("Insert into Empleados (nom_emp, ape_emp, dir_emp, tel_emp, crg_emp) Values ('" + txtNombre.Text.Trim() + "' , '" + txtApellido.Text.Trim() + "', '" + txtDirec.Text.Trim() + "', '" + mtbTel.Text.Trim() + "', '" + txtCargo.Text.Trim() + "')");
                MessageBox.Show("Nuevo registro guardado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                //Modificar un registro existente
                EscribirDatos("Update Empleados Set nom_emp = '" + txtNombre.Text.Trim() + "', ape_emp = '" + txtApellido.Text.Trim() + "', dir_emp =  '" + txtDirec.Text.Trim() + "', tel_emp = '" + mtbTel.Text.Trim() + "', crg_emp = '" + txtCargo.Text.Trim() + "' where id_emp = '" + txtId.Text + "'");
                MessageBox.Show("Se actualizó el registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }

            RefrescarTabla(); //Invoco función
            LimpiarObjetos();
        }

        private void btnBorrar_Click_1(object sender, EventArgs e)
        {
            EscribirDatos("Delete from Empleados where id_emp= '" + txtId.Text + "'");
            MessageBox.Show("Registro borrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            LimpiarObjetos();
            RefrescarTabla();
        }

        private void lblhora2_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
