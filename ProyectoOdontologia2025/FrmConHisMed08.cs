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

    public partial class FrmConHisMed08 : Form
    {

        //defino variables globales 
        SqlCommand comando = new SqlCommand();
        SqlConnection conexion = new SqlConnection("Data Source=localhost; initial catalog=OdontologiaBD; trusted_connection=yes");

        public FrmConHisMed08()
        {
            InitializeComponent();
        }

        private void FrmConEval08_Load(object sender, EventArgs e)
        {
            //Para mostrar la fecha
            lblfecha2.Text = DateTime.Now.ToShortDateString();

            //Invocar procedimiento para visualizar datos
            RefrescarTabla("Select * from Historial_Clinico");
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

        private void FrmConEval08_Activated(object sender, EventArgs e)
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
                RefrescarTabla("Select * from Historial_Clinico Where id_hcl like '%" + txtBusqueda.Text + "%'");
            }

            if (rdbCed.Checked == true)
            {
                RefrescarTabla("Select * from Historial_Clinico Where ced_pac like '%" + txtBusqueda.Text + "%'");
            }

            if (rdbDiag.Checked == true)
            {
                RefrescarTabla("Select * from Historial_Clinico Where dig_hcl like '%" + txtBusqueda.Text + "%'");
            }

            if (rdbTra.Checked == true)
            {
                RefrescarTabla("Select * from Historial_Clinico Where trt_prev_hcl like '%" + txtBusqueda.Text + "%'");
            }

            if (rdbAle.Checked == true)
            {
                RefrescarTabla("Select * from Historial_Clinico Where alg_hcl like '%" + txtBusqueda.Text + "%'");
            }

            if (rdbMed.Checked == true)
            {
                RefrescarTabla("Select * from Historial_Clinico Where mds_hcl like '%" + txtBusqueda.Text + "%'");
            }
        }

        private void btnRtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblEnca_Click(object sender, EventArgs e)
        {

        }

        private void rdbDoc_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
