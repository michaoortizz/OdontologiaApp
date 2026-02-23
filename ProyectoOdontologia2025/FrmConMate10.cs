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
    public partial class FrmConMate10 : Form
    {
        //defino variables globales 
        SqlCommand comando = new SqlCommand();
        SqlConnection conexion = new SqlConnection("Data Source=localhost; initial catalog=OdontologiaBD; trusted_connection=yes");

        public FrmConMate10()
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
                RefrescarTabla("Select * from Pagos Where id_pag like '%" + txtBusqueda.Text + "%'");
            }

            if (rdbCed.Checked == true)
            {
                RefrescarTabla("Select * from Pagos Where ced_pac like '%" + txtBusqueda.Text + "%'");
            }

            if (rdbCita.Checked == true)
            {
                RefrescarTabla("Select * from Pagos Where id_cit like '%" + txtBusqueda.Text + "%'");
            }

            if (rdbMP.Checked == true)
            {
                RefrescarTabla("Select * from Pagos Where id_mpa like '%" + txtBusqueda.Text + "%'");
            }

            if (rdbMon.Checked == true)
            {
                RefrescarTabla("Select * from Pagos Where mnt_pag like '%" + txtBusqueda.Text + "%'");
            }

            if (rdbFechaPag.Checked == true)
            {
                RefrescarTabla("Select * from Pagos Where fec_pag like '%" + txtBusqueda.Text + "%'");
            }
        }

        private void btnRtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
