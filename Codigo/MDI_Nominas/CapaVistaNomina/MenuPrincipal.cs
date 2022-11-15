using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaNomina
{
    public partial class MenuPrincipal : Form
    {
        Seguridad_Controlador.Controlador cnseg = new Seguridad_Controlador.Controlador();
        public MenuPrincipal()
        {
            InitializeComponent();
            customizeDesing();

            Button[] apps = { btnpuesto, btndepartamento, btnConcepto, btnNominas,btnempleado, btnasignacion,
               btnRplanilla,btnSegNomina,btnInfo};
            cnseg.deshabilitarApps(apps);

            cnseg.getAccesoApp(6001, apps[0]);
            cnseg.getAccesoApp(6002, apps[1]);
            cnseg.getAccesoApp(6003, apps[2]);
            cnseg.getAccesoApp(6004, apps[3]);
            cnseg.getAccesoApp(6005, apps[4]);
            cnseg.getAccesoApp(6006, apps[5]);
            cnseg.getAccesoApp(6007, apps[6]);

            cnseg.getAccesoApp(6101, apps[7]);
            cnseg.getAccesoApp(6102, apps[8]);
            cnseg.getAccesoApp(6103, apps[9]);

            

        }

        private void customizeDesing()
        {
            panelCatalogos.Visible = false;
            panelProcesos.Visible = false;
            panelReportes.Visible = false;
            panelSeguridad.Visible = false;
            panelAyuda.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelCatalogos.Visible == true)
                panelCatalogos.Visible = false;
            if (panelProcesos.Visible == true)
                panelProcesos.Visible = false;
            if (panelReportes.Visible == true)
                panelReportes.Visible = false;
            if (panelSeguridad.Visible == true)
                panelSeguridad.Visible = false; 
            if (panelAyuda.Visible == true)
                panelAyuda.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnCatalogos_Click(object sender, EventArgs e)
        {
            showSubMenu(panelCatalogos);
        }

        private void btnProcesos_Click(object sender, EventArgs e)
        {
            showSubMenu(panelProcesos);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            showSubMenu(panelReportes);
        }

        private void btnSeguridad_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSeguridad);
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            showSubMenu(panelAyuda);
        }

        private void btnTrabajadores_Click(object sender, EventArgs e)
        {
            PuestoNomina b = new PuestoNomina();
            b.MdiParent = this;
            b.Show();
            pictureBox1.Visible = false;
            hideSubMenu();
        }

        private void btnPuestos_Click(object sender, EventArgs e)
        {
            Departamento b = new Departamento();
            b.MdiParent = this;
            b.Show();
            pictureBox1.Visible = false;
            hideSubMenu();
        }

        private void btnDepto_Click(object sender, EventArgs e)
        {
            Concepto b = new Concepto();
            b.MdiParent = this;
            b.Show();
            pictureBox1.Visible = false;
            hideSubMenu();
        }

        private void btnContrato_Click(object sender, EventArgs e)
        {
            Nomina b = new Nomina();
            b.MdiParent = this;
            b.Show();
            pictureBox1.Visible = false;
            hideSubMenu();
        }

        private void btnPres_Click(object sender, EventArgs e)
        {

            pictureBox1.Visible = false;
            hideSubMenu();
          
        }

        private void btnAsPuestoDepto_Click(object sender, EventArgs e)
        {
            empleados b = new empleados();
            b.MdiParent = this;
            b.Show();
            pictureBox1.Visible = false;
            hideSubMenu();
        }

        private void btnAsPuestoTrab_Click(object sender, EventArgs e)
        {
            AsignacionNominas b = new AsignacionNominas();
            b.MdiParent = this;
            b.Show();
            pictureBox1.Visible = false;
            hideSubMenu();
        }
  
        private void btnRplanilla_Click(object sender, EventArgs e)
        {
            EmpleadosR b = new EmpleadosR();
            b.MdiParent = this;
            b.Show();
            pictureBox1.Visible = false;
            hideSubMenu();

        }

        private void bntRtrabajador_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnSegNomina_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
