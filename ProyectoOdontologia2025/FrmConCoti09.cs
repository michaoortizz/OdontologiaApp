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
    public partial class FrmConCoti09 : Form
    {
        //defino variables globales 
        SqlCommand comando = new SqlCommand();
        SqlConnection conexion = new SqlConnection("Data Source=MIAPC; initial catalog=Sistema_Odontologia; trusted_connection=yes");

        public FrmConCoti09()
        {
            InitializeComponent();
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FrmConCoti09_Load(object sender, EventArgs e)
        {
            //Invocar procedimiento para visualizar datos
            RefrescarTabla("Select * from Cotizaciones");

            //Para mostrar la fecha
            lblfecha2.Text = DateTime.Now.ToShortDateString();
        }

        //Creo procedimiento para visualizar los datos en el data grid view
        private void RefrescarTabla(String Parametro)
        {
            dgvDatos.DataSource = null; //Con esta linea le estoy diciendo al datagridview que quite todos los registros que haya en el mismo 

            try  //Si hacemos la captura de error, el programa no explota si hay un error
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

        private void FrmConCoti09_Activated(object sender, EventArgs e)
        {
            comando.Connection = conexion;
        }

        private void Fecha_Tick(object sender, EventArgs e)
        {
            //Para que se muestre la hora
            lblhora2.Text = DateTime.Now.ToLongTimeString();
        }

        

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rdbmonto_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbemp_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbdesc_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gpbCriterio_Enter(object sender, EventArgs e)
        {

        }

        private void txtBusqueda_TextChanged_1(object sender, EventArgs e)
        {
            if (rdbId.Checked == true)
            {
                RefrescarTabla("Select * from Cotizaciones Where IdCotizacion like '%" + txtBusqueda.Text + "%'");
            }

            if (rdbDiag.Checked == true)
            {
                RefrescarTabla("Select * from Cotizaciones Where IdDiagnostico like '%" + txtBusqueda.Text + "%'");
            }

            if (rdbCedula.Checked == true)
            {
                RefrescarTabla("Select * from Cotizaciones Where Cedula like '%" + txtBusqueda.Text + "%'");
            }

            if (rdbMonto.Checked == true)
            {
                RefrescarTabla("Select * from Cotizaciones Where Monto like '%" + txtBusqueda.Text + "%'");
            }

            if (rdbEmp.Checked == true)
            {
                RefrescarTabla("Select * from Cotizaciones Where IdEmpleado like '%" + txtBusqueda.Text + "%'");
            }

            if (rdbDesc.Checked == true)
            {
                RefrescarTabla("Select * from Cotizaciones Where Descripcion like '%" + txtBusqueda.Text + "%'");
            }

            if (rdbCant.Checked == true)
            {
                RefrescarTabla("Select * from Cotizaciones Where CantidadCuota like '%" + txtBusqueda.Text + "%'");
            }

            if (rdbBalance.Checked == true)
            {
                RefrescarTabla("Select * from Cotizaciones Where Balance like '%" + txtBusqueda.Text + "%'");
            }

            if (rdbEstado.Checked == true)
            {
                RefrescarTabla("Select * from Cotizaciones Where Estado like '%" + txtBusqueda.Text + "%'");
            }
        }
    }
}
