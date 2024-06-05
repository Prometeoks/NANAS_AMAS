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

    public partial class FormObservaciones : Form
    {
        public event EventHandler<TextEventArgs> TextSubmitted;
        private bool aceptado;

        public FormObservaciones()
        {
            InitializeComponent();
            aceptado = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (!aceptado)
            {
                txtObservaciones.Clear();
            }
            this.Visible = false;
            
        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtObservaciones.Text))
            {
                MessageBox.Show("Por favor, ingresa alguna descripción antes de aceptar.", "Campo Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                TextSubmitted?.Invoke(this, new TextEventArgs { Text = txtObservaciones.Text });
                aceptado = true;
                this.Visible = false;
            }

        }

        public void Abrir()
        {
            this.Visible = true;
        }
    }
    public class TextEventArgs : EventArgs
    {
        public string Text { get; set; }
    }
}
