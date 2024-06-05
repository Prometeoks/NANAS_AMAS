using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CapaDatos;
//using CapaEntidad;
using CapaLogica;
//using SuperMarket_D.ALMACEN;

namespace NANAS_AMAS
{
    public partial class FormMenu : Form
    {
       
        public FormMenu()
        {
            InitializeComponent();
            
            this.WindowState = FormWindowState.Maximized;
            MenuVertical.Width = 250;

            MenuVertical.Height = 768;
            
            //dgvCitas.DataSource = logTtrabajador.Instancia.ListarTrabajadores();

        }


        private void btnSlide_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width== 250) {

                MenuVertical.Width = 78;
            }
            else { MenuVertical.Width = 250; }
        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
           
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FormCitas());
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AbrirFormInPanel(object Formhijo)
        {
            {
                if (this.panelContenedor.Controls.Count > 0)
                    this.panelContenedor.Controls.RemoveAt(0);
                Form fh = Formhijo as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.panelContenedor.Controls.Add(fh);
                this.panelContenedor.Tag = fh;
                fh.Show();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FormTrabajadores());
        }

        private void btnEmpleadores_Click_1(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FormEmpleador());
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FormPedido());
        }
    }
}
