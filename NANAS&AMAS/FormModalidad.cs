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
    public partial class FormModalidad : Form
    {
        public bool verFom = false;
        public FormModalidad()
        {
            InitializeComponent();
            clbDias.Visible = false;
            btnDias.Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            clbDias.Visible = false;
            clbModalidad.Visible = true;

        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {

        }

        private void clbPuestos_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int index = e.Index;

            if (clbModalidad.Items[index].ToString() == "POR DIAS" && clbModalidad.GetItemChecked(index) == false)
            {
                clbModalidad.Visible = false;
                clbDias.Visible = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!clbDias.Visible)
            {
                this.Visible = false;
                return;
            }
            clbDias.Visible = false;
            clbModalidad.Visible = true;
            if (verFom)
            {
                btnDias.Visible = true;
            }

        }

        private void btnDias_Click(object sender, EventArgs e)
        {
            clbDias.Visible = true;
            clbModalidad.Visible = false;
            btnDias.Visible = false;
        }
    }
}
