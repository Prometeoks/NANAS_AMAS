using System;
using System.Windows.Forms;

namespace NANAS_AMAS
{
    public partial class FormFunciones : Form
    {
        public event EventHandler<TextEventArgs> TextSubmitted;
        private bool aceptado;

        public FormFunciones()
        {
            InitializeComponent();
            aceptado = false;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (!aceptado)
            {
                txtFunciones.Clear();
            }
            this.Visible = false;
        }
        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFunciones.Text))
            {
                MessageBox.Show("Por favor, ingresa alguna descripción antes de aceptar.", "Campo Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                TextSubmitted?.Invoke(this, new TextEventArgs { Text = txtFunciones.Text });
                aceptado = true;
                this.Visible = false;
            }
        }

        public void Abrir()
        {
            aceptado = false;
            this.Visible = true;
        }
    }

}
