using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;

namespace NANAS_AMAS
{
    public partial class FormMotivo : Form
    {
        private FormEmpleador empleador;
        public string motivo;

        public FormMotivo(FormEmpleador formEmpleador)
        {
            InitializeComponent();
            this.empleador = formEmpleador;
        }

        public void CargarMotivo(string motivo)
        {

            empleador.saveMotivo(txtMotivo.Text = "" + motivo);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (txtMotivo != null)
            {
                DialogResult result = MessageBox.Show("Tiene cambios no guardados", "Desea continuar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    this.Close();
                    empleador.ocultarEditar();
                }
                else
                {
                    return;
                }
            }
            else
            {
                this.Close();
                empleador.ocultarEditar();
            }            
        }
        public void leerMotivo()
        {
            motivo = txtMotivo.Text;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMotivo.Text))
            {
                MessageBox.Show("Debe ingresar al menos un motivo para poder guardar los cambios");
                empleador.ocultarEditar();
            }
            else
            {
                //Almacenar el contenido del TextBox en una variable
                motivo = txtMotivo.Text;
                empleador.ActualizarMotivo(motivo);

                //Minimizar el formulario
                //this.WindowState = FormWindowState.Minimized;
                this.Visible = false;
                empleador.mostrarEditar();
            }            
        }
        public void limpiarMotivo()
        {
            txtMotivo.Clear();
        }
    }
}
