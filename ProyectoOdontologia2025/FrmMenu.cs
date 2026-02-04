using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoOdontologia2025
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void seguroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManSegu01 manSeguro = new FrmManSegu01();
            manSeguro.Show();
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManPaci02 manPaci = new FrmManPaci02();
            manPaci.Show();
        }

        private void doctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManDoct03 manDoc = new FrmManDoct03();
            manDoc.Show();
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManEmpl04 manEmp = new FrmManEmpl04();
            manEmp.Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManUsua05 manUsu = new FrmManUsua05();
            manUsu.Show();
        }

        private void pacientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConPaci01 conPaci = new FrmConPaci01();
            conPaci.Show();
        }

        private void consultasMédicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConCmed02 conMed = new FrmConCmed02();
            conMed.Show();
        }

        private void diagnósticosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConDiag03 conDiag = new FrmConDiag03();
            conDiag.Show();
            
        }

        private void segurosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConSegu04 conSegu = new FrmConSegu04();
            conSegu.Show();
        }

        private void citasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConCita05 conCita = new FrmConCita05();
            conCita.Show();
        }

        private void doctoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConDoct06 menu = new FrmConDoct06();
            menu.Show();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConEmpl07 menu = new FrmConEmpl07();
            menu.Show();
        }

        private void evaluacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConEval08 menu = new FrmConEval08();
            menu.Show();
        }

        private void cotizacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConCoti09 menu = new FrmConCoti09();
            menu.Show();
        }

        private void pagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConPago10 menu = new FrmConPago10();
            menu.Show();
        }

        private void registrarConsultasMédicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProReCM01 menu = new FrmProReCM01();
            menu.Show();
        }

        private void diagnósticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProDiag02 menu = new FrmProDiag02();
            menu.Show();
        }

        private void registroDeCitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProReCi03 menu = new FrmProReCi03();
            menu.Show();
        }

        private void evaluacionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmProEval04 menu = new FrmProEval04();
            menu.Show();
        }

        private void cotizacionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmProCoti05 menu = new FrmProCoti05();
            menu.Show();
        }

        private void registrarPagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProRePa06 menu = new FrmProRePa06();
            menu.Show();
        }

        private void pacientesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmRepPaci01 menu = new FrmRepPaci01();
            menu.Show();
        }

        private void diagnósticosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmRepDiag02 menu = new FrmRepDiag02();
            menu.Show();
        }

        private void citasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmRepCita03 menu = new FrmRepCita03();
            menu.Show();
        }

        private void cotizaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRepCoti04 menu = new FrmRepCoti04();
            menu.Show();
        }

        private void pagosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmRepPago05 menu = new FrmRepPago05(); 
            menu.Show();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void FrmMenu_Activated(object sender, EventArgs e)
        {

        }

        private void lblMenu_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void citasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmManCita06 menu = new FrmManCita06();
            menu.Show();
        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManProve07 menu = new FrmManProve07();
            menu.Show();
        }

        private void tratamientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManTrata08 menu = new FrmManTrata08();
            menu.Show();
        }

        private void materialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManMate09 menu = new FrmManMate09();
            menu.Show();
        }
    }
}
