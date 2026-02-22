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
    public partial class FrmConPaci01 : Form
    {
        //defino variables globales 
        SqlCommand comando = new SqlCommand();
        SqlConnection conexion = new SqlConnection("Data Source=localhost; initial catalog=OdontologiaBD; trusted_connection=yes");

        public FrmConPaci01()
        {
            InitializeComponent();
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FrmConPaci01_Load(object sender, EventArgs e)
        {
            //Para mostrar la fecha
            lblfecha2.Text = DateTime.Now.ToShortDateString();

            //Invocar procedimiento para visualizar datos
            RefrescarTabla("Select * from Pacientes");
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

    

        private void FrmConPaci01_Activated(object sender, EventArgs e)
        {
            comando.Connection = conexion;
        }

        private void lblhora2_Click(object sender, EventArgs e)
        {

        }

        private void Fecha_Tick(object sender, EventArgs e)
        {
            //Para que se muestre la hora
            lblhora2.Text = DateTime.Now.ToLongTimeString();

        }

        private void rdbfechan_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (rdbId.Checked == true)
            {
                RefrescarTabla("Select * from Pacientes Where ced_pac like '%" + txtBusqueda.Text + "%'");
            }

            if (rdbNom.Checked == true)
            {
                RefrescarTabla("Select * from Pacientes Where nom_pac like '%" + txtBusqueda.Text + "%'");
            }

            if (rdbApellido.Checked == true)
            {
                RefrescarTabla("Select * from Pacientes Where apec_pac like '%" + txtBusqueda.Text + "%'");
            }

            if (rbdGen.Checked == true)
            {
                RefrescarTabla("Select * from Pacientes Where gen_pac like '%" + txtBusqueda.Text + "%'");
            }

            if (rdbFecha.Checked == true)
            {
                RefrescarTabla("Select * from Pacientes Where fec_nac_pac like '%" + txtBusqueda.Text + "%'");
            }

            if (rdbTipo.Checked == true)
            {
                RefrescarTabla("Select * from Pacientes Where tip_pac like '%" + txtBusqueda.Text + "%'");
            }

            if (rdbTel.Checked == true)
            {
                RefrescarTabla("Select * from Pacientes Where tel_pac like '%" + txtBusqueda.Text + "%'");
            }

            if (rdbCondicion.Checked == true)
            {
                RefrescarTabla("Select * from Pacientes Where cnd_sal_pac like '%" + txtBusqueda.Text + "%'");
            }

            if (rdbCorreo.Checked == true)
            {
                RefrescarTabla("Select * from Pacientes Where eml_pac like '%" + txtBusqueda.Text + "%'");
            }

            if (rdbSeguro.Checked == true)
            {
                RefrescarTabla("Select * from Pacientes Where id_seg like '%" + txtBusqueda.Text + "%'");
            }

        }

        private void rdbSeguro_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnRtn_Click(object sender, EventArgs e)
        {

        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }
    }
}
