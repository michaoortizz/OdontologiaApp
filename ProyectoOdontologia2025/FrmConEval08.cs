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

    public partial class FrmConEval08 : Form
    {

        //defino variables globales 
        SqlCommand comando = new SqlCommand();
        SqlConnection conexion = new SqlConnection("Data Source=localhost; initial catalog=OdontologiaBD; trusted_connection=yes");

        public FrmConEval08()
        {
            InitializeComponent();
        }

        private void FrmConEval08_Load(object sender, EventArgs e)
        {
            //Para mostrar la fecha
            lblfecha2.Text = DateTime.Now.ToShortDateString();

            //Invocar procedimiento para visualizar datos
            RefrescarTabla("Select * from Evaluaciones");
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
                RefrescarTabla("Select * from Evaluaciones Where IdEvaluacion like '%" + txtBusqueda.Text + "%'");
            }

            if (rdbDoc.Checked == true)
            {
                RefrescarTabla("Select * from Evaluaciones Where IdDoctor like '%" + txtBusqueda.Text + "%'");
            }

            if (rdbFecha.Checked == true)
            {
                RefrescarTabla("Select * from Evaluaciones Where FechaEvaluacion like '%" + txtBusqueda.Text + "%'");
            }

            if (rdbCed.Checked == true)
            {
                RefrescarTabla("Select * from Evaluaciones Where Cedula like '%" + txtBusqueda.Text + "%'");
            }

            if (rdbDesc.Checked == true)
            {
                RefrescarTabla("Select * from Evaluaciones Where Descripcion like '%" + txtBusqueda.Text + "%'");
            }

            if (rdbCuad.Checked == true)
            {
                RefrescarTabla("Select * from Evaluaciones Where Cuadrante like '%" + txtBusqueda.Text + "%'");
            }

            if (rdbObs.Checked == true)
            {
                RefrescarTabla("Select * from Evaluaciones Where Observacion like '%" + txtBusqueda.Text + "%'");
            }
        }
    }
}
