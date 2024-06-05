using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NANAS_AMAS
{
    public partial class FormPuesto : Form
    {
        public FormPuesto()
        {
            InitializeComponent();
        }
        int m,mx,my;
        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Visible=false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx=e.X; 
            my=e.Y;
        }

        private void FormPuesto_Load(object sender, EventArgs e)
        {
          
        }
    



        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X-mx,MousePosition.Y-my);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }
    }
}
