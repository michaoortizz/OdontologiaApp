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
    public partial class FrmManCita06 : Form
    {
        //defino variables globales 
        SqlCommand comando = new SqlCommand();
        SqlConnection conexion = new SqlConnection("Data Source=localhost; initial catalog=OdontologiaBD; trusted_connection=yes");

        public FrmManCita06()
        {
            InitializeComponent();
        }

        private void gpbInfo_Enter(object sender, EventArgs e)
        {

        }
        private void FrmManCita06_Load(object sender, EventArgs e)
        {
            //Para mostrar la fecha
            lblfecha2.Text = DateTime.Now.ToShortDateString();


            //Invocar procedimiento para visualizar datos
            RefrescarTabla();
        }

        private void RefrescarTabla()
        {
            dgvDatos.DataSource = null;
            try
            {
                conexion.Open(); //Abro la conexión
                DataTable datos = new DataTable();
                SqlDataAdapter Adaptador = new SqlDataAdapter("Select * from Citas ", conexion);
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
            mtbCed.Text = "";
            txtCita.Clear();
            mtbFecha.Clear();
            mtbFecha.Clear();
            txtDoc.Clear();
            txtEmp.Clear();
        }

        private void FrmManCita06_Activated(object sender, EventArgs e)
        {
            comando.Connection = conexion;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Para que se muestre la hora
            lblhora2.Text = DateTime.Now.ToLongTimeString();
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCita.Text = dgvDatos[0, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();
            mtbCed.Text = dgvDatos[1, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();
            mtbFecha.Text = dgvDatos[2, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();
            txtDoc.Text = dgvDatos[3, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();
            txtEmp.Text = dgvDatos[4, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtCita.Text))
            {
                //Agrego registro nuevo
                EscribirDatos("Insert into Citas (Cedula, Fecha, IdDoctor, IdEmpleado) Values ('" + mtbCed.Text.Trim() + "' , '" + mtbFecha.Text.Trim() + "', '" + txtDoc.Text.Trim() + "', '" + txtEmp.Text.Trim() + "')");
                MessageBox.Show("Nuevo registro guardado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                //Modificar un registro existente
                EscribirDatos("Update Citas Set Cedula = '" + mtbCed.Text.Trim() + "', Fecha = '" + mtbFecha.Text.Trim() + "', IdDoctor =  '" + txtDoc.Text.Trim() + "', IdEmpleado = '" + txtEmp.Text.Trim() + "' where IdCita = '" + txtCita.Text + "'");
                MessageBox.Show("Se actualizó el registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }

            RefrescarTabla(); //Invoco función
            LimpiarObjetos();
        }

        private void lblfecha2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            EscribirDatos("Delete from Citas where IdCita= '" + txtCita.Text + "'");
            MessageBox.Show("Registro borrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            LimpiarObjetos();
            RefrescarTabla();
        }
    }
    }
