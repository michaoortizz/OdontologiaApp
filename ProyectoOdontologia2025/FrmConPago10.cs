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
    public partial class FrmConPago10 : Form
    {
        //defino variables globales 
        SqlCommand comando = new SqlCommand();
        SqlConnection conexion = new SqlConnection("Data Source=MIAPC; initial catalog=Sistema_Odontologia; trusted_connection=yes");

        public FrmConPago10()
        {
            InitializeComponent();
        }

        private void FrmConPago10_Load(object sender, EventArgs e)
        {
            //Invocar procedimiento para visualizar datos
            RefrescarTabla("Select * from Pagos");

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

        private void FrmConPago10_Activated(object sender, EventArgs e)
        {
            comando.Connection = conexion;
        }

        private void Fecha_Tick(object sender, EventArgs e)
        {
            //Para que se muestre la hora
            lblhora2.Text = DateTime.Now.ToLongTimeString();
        }

        private void rdbformap_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtBusqueda_TextChanged_1(object sender, EventArgs e)
        {
            if (rdbId.Checked == true)
            {
                RefrescarTabla("Select * from Pagos Where IdPago like '%" + txtBusqueda.Text + "%'");
            }

            if (rdbCot.Checked == true)
            {
                RefrescarTabla("Select * from Pagos Where IdCotizacion like '%" + txtBusqueda.Text + "%'");
            }

            if (rdbFormaPago.Checked == true)
            {
                RefrescarTabla("Select * from Pagos Where FormaPago like '%" + txtBusqueda.Text + "%'");
            }

            if (rdbFechaPag.Checked == true)
            {
                RefrescarTabla("Select * from Pagos Where Fecha like '%" + txtBusqueda.Text + "%'");
            }

            if (rdbMonto.Checked == true)
            {
                RefrescarTabla("Select * from Pagos Where MontoPago like '%" + txtBusqueda.Text + "%'");
            }

            if (rdbEmp.Checked == true)
            {
                RefrescarTabla("Select * from Pagos Where IdEmpleado like '%" + txtBusqueda.Text + "%'");
            }

            if (rdbCed.Checked == true)
            {
                RefrescarTabla("Select * from Pagos Where Cedula like '%" + txtBusqueda.Text + "%'");
            }
        }
    }
}
