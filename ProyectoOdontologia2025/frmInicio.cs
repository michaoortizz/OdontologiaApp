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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

        private void customizeDesign()
        {
            panelSubMenuMante.Visible = false;
            panelSubMenuConsultas.Visible = false;
            panelSubMenuProcesos.Visible = false;
            panelSubMenuReportes.Visible = false;
            panelSubMenuUtilitarios.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelSubMenuMante.Visible == true)
            {
                panelSubMenuMante.Visible = false;
            }
            if (panelSubMenuConsultas.Visible == true)
            {
                panelSubMenuConsultas.Visible = false;
            }
            if (panelSubMenuProcesos.Visible == true)
            {
                panelSubMenuProcesos.Visible = false;
            }
            if (panelSubMenuReportes.Visible == true)
            {
                panelSubMenuReportes.Visible = false;
            }
            if (panelSubMenuUtilitarios.Visible == true)
            {
                panelSubMenuUtilitarios.Visible = false;
            }
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnMan_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuMante);

        }

        private void btnCon_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuConsultas);
        }

        private void btnProcesos_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuProcesos);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuReportes);
        }

        private void btnUti_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuUtilitarios);
        }

        private void btnManSeg_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmManSegu01());
            hideSubMenu();
        }

        private void btnManPan_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmManPaci02());
            hideSubMenu();
        }

        private void btnManDoc_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmManDoct03());
            hideSubMenu();
        }

        private void btnManEmp_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmManEmpl04());
            hideSubMenu();
        }

        private void btnManUsu_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmManUsua05());
            hideSubMenu();
        }

        private void btnConPac_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmConPaci01());
            hideSubMenu();
        }

        private void btnManCita_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmManCita06());
            hideSubMenu();
        }

        private void btnManProv_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmManProve07());
            hideSubMenu();
        }

        private void btnManTrata_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmManTrata08());
            hideSubMenu();
        }

        private void btnManMate_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmManMate09());
            hideSubMenu();
        }

        private void btnConCMed_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmConCmed02());
            hideSubMenu();
        }

        private void btnConDiag_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmConDiag03());
            hideSubMenu();
        }

        private void btnConSegu_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmConSegu04());
            hideSubMenu();
        }

        private void btnConCitas_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmConCita05());
            hideSubMenu();
        }

        private void btnConDoc_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmConDoct06());
            hideSubMenu();
        }

        private void btnConEmp_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmConEmpl07());
            hideSubMenu();
        }

        private void btnConEva_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmConEval08());
            hideSubMenu();
        }

        private void btnConCoti_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmConCoti09());
            hideSubMenu();
        }

        private void btnConPagos_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmConPago10());
            hideSubMenu();
        }

        private void btnProRegCMed_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmProReCM01());
            hideSubMenu();
        }

        private void btnProDiag_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmProDiag02());
            hideSubMenu();
        }

        private void btnProRegCitas_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmProReCi03());
            hideSubMenu();
        }

        private void btnProEva_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmProEval04());
            hideSubMenu();
        }

        private void btnProCoti_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmProCoti05());
            hideSubMenu();
        }

        private void btnProRegPago_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmProRePa06());
            hideSubMenu();
        }

        private void btnRepPac_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmRepPaci01());
            hideSubMenu();
        }

        private void btnRepDiag_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmRepDiag02());
            hideSubMenu();
        }

        private void btnRepCitas_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmRepCita03());
            hideSubMenu();
        }

        private void btnRepCoti_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmRepCoti04());
            hideSubMenu();
        }

        private void btnRepPagos_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmRepPago05());
            hideSubMenu();

        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
               activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
