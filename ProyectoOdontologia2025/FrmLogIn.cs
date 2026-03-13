using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoOdontologia2025
{
    public partial class FrmLogIn : Form
    {
        //defino variables globales 
        SqlConnection conexion = new SqlConnection("Data Source=132.145.163.113,1433;Initial Catalog=OdontologiaBD;User ID=sa;Password=Admin123@Strong");


        public FrmLogIn()
        {
            InitializeComponent();
        }

        private void gpbInfo_Enter(object sender, EventArgs e)
        {

        }

        private object LeerDato(string usuario, string contra)
        {
            try
            {
                // Usamos parámetros 
                string query = "SELECT nmb_usr FROM Usuarios WHERE RTRIM(nom_usr) = RTRIM(@user) AND RTRIM(pas_usr) = RTRIM(@pass)";

                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@user", usuario);
                    cmd.Parameters.AddWithValue("@pass", contra);

                    if (conexion.State != ConnectionState.Open) conexion.Open();
                    object resultado = cmd.ExecuteScalar();
                    conexion.Close();

                    return resultado;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message);
                if (conexion.State == ConnectionState.Open) conexion.Close();
                return null;
            }
        }
        
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            // Validar campos obligatorios
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("Debe ingresar el usuario", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCon.Text))
            {
                MessageBox.Show("Debe ingresar la contraseña", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCon.Focus();
                return;
            }

            object resultado = LeerDato(txtUsuario.Text.Trim(), txtCon.Text.Trim());
            
            if (resultado != null)
            {
                string nombreUsuario = resultado.ToString();
                frmInicio menuPrincipal = new frmInicio(nombreUsuario);

                menuPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nombre o contraseña incorrectos", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmLogIn_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();

            txtCon.PasswordChar = '*';
            btnSlash.Visible = true;
            btnOpen.Visible = false;
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCon.Focus(); // pasa al siguiente campo
                e.SuppressKeyPress = true; // evita el sonido "ding"
            }
        }

        private void txtCon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnIniciar.PerformClick(); // ejecuta el botón
                e.SuppressKeyPress = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnSlash.Visible = false;
            btnOpen.Visible = true;
            txtCon.PasswordChar = '\0';
        }

        private void btnOpen_Click_1(object sender, EventArgs e)
        {
            btnSlash.Visible = true;
            btnOpen.Visible = false;
            txtCon.PasswordChar = '*';
        }

        private void txtCon_TextChanged(object sender, EventArgs e)
        {
            btnSlash.Visible = true;
        }
    }
}

