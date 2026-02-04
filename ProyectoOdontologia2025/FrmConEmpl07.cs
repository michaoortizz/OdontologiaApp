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
    public partial class FrmConEmpl07 : Form
    {
        //defino variables globales 
        SqlCommand comando = new SqlCommand();
        SqlConnection conexion = new SqlConnection("Data Source=MIAPC; initial catalog=Sistema_Odontologia; trusted_connection=yes");

        public FrmConEmpl07()
        {
            InitializeComponent();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FrmConEmpl07_Load(object sender, EventArgs e)
        {
            //Invocar procedimiento para visualizar datos
            RefrescarTabla("Select * from Empleados");

            //Para mostrar la fecha
            lblfecha2.Text = DateTime.Now.ToShortDateString();
        }

        //Creo procedimiento para visualizar los datos en el data grid view
        private void RefrescarTabla(String Parametro)
        {
            dgvDatos.DataSource = null; //Con esta linea le estoy diciendo al datagridview que quite todos los registros que haya en el mismo 

            try //Si hacemos la captura de error, el programa no explota si hay un error
            {
                conexion.Open(); //Abro la conexión
                DataTable datos = new DataTable();
                SqlDataAdapter Adaptador = new SqlDataAdapter(Parametro, conexion);
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

        private void FrmConEmpl07_Activated(object sender, EventArgs e)
        {
            comando.Connection = conexion;
        }

        private void Fecha_Tick(object sender, EventArgs e)
        {
            //Para que se muestre la hora
            lblhora2.Text = DateTime.Now.ToLongTimeString();
        }


        private void txtBusqueda_TextChanged_1(object sender, EventArgs e)
        {
            if (rdbId.Checked == true)
            {
                RefrescarTabla("Select * from Empleados Where IdEmpleado like '%" + txtBusqueda.Text + "%'");
            }

            if (rdbNombre.Checked == true)
            {
                RefrescarTabla("Select * from Empleados Where Nombre like '%" + txtBusqueda.Text + "%'");
            }

            if (rdbApellido.Checked == true)
            {
                RefrescarTabla("Select * from Empleados Where Apellido like '%" + txtBusqueda.Text + "%'");
            }

            if (rdbDirec.Checked == true)
            {
                RefrescarTabla("Select * from Empleados Where Direccion like '%" + txtBusqueda.Text + "%'");
            }

            if (rdbTel.Checked == true)
            {
                RefrescarTabla("Select * from Empleados Where Telefono like '%" + txtBusqueda.Text + "%'");
            }

            if (rdbCargo.Checked == true)
            {
                RefrescarTabla("Select * from Empleados Where Cargo like '%" + txtBusqueda.Text + "%'");
            }
        }
    }
}
