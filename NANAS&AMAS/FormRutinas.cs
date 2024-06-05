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
    public partial class FormRutinas : Form
    {
        public event EventHandler<TextEventArgs> TextSubmitted;
        private bool aceptado;

        public FormRutinas()
        {
            InitializeComponent();
            aceptado = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (!aceptado)
            {
                txtRutina.Clear();
            }
            this.Visible = false;
        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRutina.Text))
            {
                MessageBox.Show("Por favor, ingresa alguna descripción antes de aceptar.", "Campo Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                TextSubmitted?.Invoke(this, new TextEventArgs { Text = txtRutina.Text });
                aceptado = true;
                this.Visible = false;
            }
        }

        public void Abrir()
        {
            this.Visible = true;
        }
    }


}
