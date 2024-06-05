using System;
using System.Windows.Forms;

namespace NANAS_AMAS
{
    public partial class FormPuestoPedido : Form
    {
        private bool _seleccionado = false;
        public event EventHandler<SelectEventArgs> seleccion;
        public FormPuestoPedido()
        {
            InitializeComponent();
            clbPuestosPedidos.ItemCheck += clbPuestosPedidos_ItemCheck;
        }

        private void clbPuestosPedidos_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Verifica si ya hay una opción seleccionada
            if (clbPuestosPedidos.CheckedItems.Count > 0 && e.NewValue == CheckState.Checked)
            {
                MessageBox.Show("Solo se puede seleccionar una opción.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.NewValue = CheckState.Unchecked; // Cancela la selección de la segunda casilla
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (!_seleccionado)
            {
                for (int i = 0; i < clbPuestosPedidos.Items.Count; i++)
                {
                    clbPuestosPedidos.SetItemChecked(i, false);
                }
            }
            this.Visible = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (clbPuestosPedidos.CheckedItems.Count == 1)
            {
                string puesto = clbPuestosPedidos.CheckedItems[0].ToString();

                seleccion?.Invoke(this, new SelectEventArgs { select = puesto });

                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una opción antes de aceptar.", "Selección incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
