using System;
using System.Windows.Forms;

namespace NANAS_AMAS
{
    public partial class FormModalidadPedido : Form
    {
        private bool _seleccionado = false;
        public event EventHandler<SelectEventArgs> seleccion;
        public FormModalidadPedido()
        {
            InitializeComponent();
            clbModalidadPedidos.ItemCheck += clbModalidadPedidos_ItemCheck;
        }

        private void clbModalidadPedidos_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (clbModalidadPedidos.CheckedItems.Count > 0 && e.NewValue == CheckState.Checked)
            {
                MessageBox.Show("Solo se puede seleccionar una opción.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.NewValue = CheckState.Unchecked; // Cancela la selección de la segunda casilla
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (!_seleccionado)
            {
                for (int i = 0; i < clbModalidadPedidos.Items.Count; i++)
                {
                    clbModalidadPedidos.SetItemChecked(i, false);
                }
            }
            this.Visible = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (clbModalidadPedidos.CheckedItems.Count == 1)
            {
                string modalidad = clbModalidadPedidos.CheckedItems[0].ToString();

                seleccion?.Invoke(this, new SelectEventArgs { select = modalidad });

                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una opción antes de aceptar.", "Selección incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
    public class SelectEventArgs : EventArgs
    {
        public string select { get; set; }
    }
}
