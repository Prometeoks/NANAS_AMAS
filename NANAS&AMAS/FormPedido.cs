using System;
using System.Linq;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogica;

namespace NANAS_AMAS
{
    public partial class FormPedido : Form
    {

        private string funcionesTexto;
        private string rutinasTexto;
        private string observacionesTexto;
        private string puestoSeleccionado;
        private string modalidadSeleccionada;

        FormModalidadPedido modalidad = new FormModalidadPedido();
        FormPuestoPedido puestos = new FormPuestoPedido();
        FormFunciones funciones = new FormFunciones();
        FormRutinas rutinas = new FormRutinas();
        FormObservaciones observaciones = new FormObservaciones();


        public FormPedido()
        {
            InitializeComponent();
            ListarPedido();
            initComboBox();

            cboEstado.SelectedItem = "EN PROCESO";

            funciones.TextSubmitted += (s, e) => { funcionesTexto = e.Text; };
            rutinas.TextSubmitted += (s, e) => { rutinasTexto = e.Text; };
            observaciones.TextSubmitted += (s, e) => { observacionesTexto = e.Text; };

            modalidad.seleccion += (s, e) => { modalidadSeleccionada = e.select; };
            puestos.seleccion += (s, e) => { puestoSeleccionado = e.select; };

        }

        public void initComboBox()
        {
           
            cboEstado.Items.AddRange(new string[]
            {
                "EN PROCESO","COLOCADO", "ANULADO"
            });
        }

        public void ListarPedido()
        {
            dgvPedidos.DataSource = logPedido.Instancia.ListarPedidos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (RestriccionesPedido())
            {
                return;
            }
            else { 
                try
                {
                    entPedido pedido = new entPedido();
                    pedido.codPedido = GenerarCodigoPedido();
                    pedido.dni_empleador = txtDni.Text;
                    pedido.edad_minima = txtEdadMinima.Text;
                    pedido.edad_maxima = txtEdadMaxima.Text;
                    pedido.funciones = funcionesTexto;
                    pedido.rutina = rutinasTexto;
                    pedido.observaciones = observacionesTexto;
                    pedido.estado = cboEstado.SelectedItem.ToString();
                    pedido.hora_de_inicio = ObtenerHoraCompleta(txtHoraInicio.Text, txtMinutosInicio.Text);
                    pedido.hora_final = ObtenerHoraCompleta(txtHoraFin.Text, txtMinutosFin.Text);
                    pedido.cant_horas = txtCantiadadHoras.Text;
                    pedido.cant_horas = txtCantiadadHoras.Text;
                    pedido.sueldo = float.Parse(txtSueldo.Text);
                    pedido.modalidad = modalidadSeleccionada;
                    pedido.puesto = puestoSeleccionado;
                    pedido.usuario_id = ObtenerIdUsuario();

                    logPedido.Instancia.InsertaPedido(pedido);

                    MessageBox.Show("Empleador agregado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarFormulario();
                    ListarPedido();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al agregar el pedido: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            txtDni.Text = txtDni.Text.Trim();

            if (string.IsNullOrWhiteSpace(txtDni.Text))
            {
                // MessageBox.Show("El campo DNI no puede estar vacío.");
                txtDni.Clear();
                return;
            }

            if (txtDni.Text.Length > 8)
            {
                // MessageBox.Show("El DNI debe contener como máximo 8 dígitos numéricos.");
                txtDni.Text = txtDni.Text.Substring(0, 8);
                txtDni.SelectionStart = txtDni.Text.Length; // Coloca el cursor al final del texto
                MessageBox.Show("El DNI solo puede contener números.");
                return; // Sale del método si hay más de 8 caracteres
            }

        }



        private void txtSueldo_TextChanged(object sender, EventArgs e)
        {
            // Guarda la posición del cursor
            int cursorPosition = txtSueldo.SelectionStart;

            // Elimina todos los caracteres no numéricos y no punto decimal
            string text = txtSueldo.Text;
            string cleanedText = "";
            bool decimalPointFound = false;
            int decimalPlacesCount = 0;

            foreach (char c in text)
            {
                if (char.IsDigit(c))
                {
                    cleanedText += c;
                    if (decimalPointFound)
                    {
                        decimalPlacesCount++;
                    }
                }
                else if (c == '.' && !decimalPointFound)
                {
                    cleanedText += c;
                    decimalPointFound = true;
                }
            }

            // Si hay más de dos decimales, recorta el exceso
            if (decimalPlacesCount > 2)
            {
                int decimalPointIndex = cleanedText.IndexOf('.');
                cleanedText = cleanedText.Substring(0, decimalPointIndex + 3);
            }

            // Actualiza el texto del campo y restaura la posición del cursor
            txtSueldo.Text = cleanedText;
            txtSueldo.SelectionStart = Math.Min(cursorPosition, cleanedText.Length);
        }

        private void cboEstado_Click(object sender, EventArgs e)
        {
             cboEstado.SelectedIndex = cboEstado.Items.IndexOf("EN PROCESO");

             string estadoSeleccionado = cboEstado.SelectedItem?.ToString();
            switch (estadoSeleccionado)
            {
                case "EN PROCESO":
                     break;
                case "COLOCADO":
                     break;
                case "ANULADO":
                     break;
                default:
                     break;
            }
        }

        private void btnModalidad_Click(object sender, EventArgs e)
        {
            modalidad.Show();
        }

        private void btnPuesto_Click(object sender, EventArgs e)
        {
            puestos.Show();
        }

        private void btnFunciones_Click(object sender, EventArgs e)
        {
            funciones.Show();
        }

        private void btnRutina_Click(object sender, EventArgs e)
        {
            rutinas.Show();
        }

        private void btnObservaciones_Click(object sender, EventArgs e)
        {
            observaciones.Show();
        }

        private void LimpiarFormulario()
        {
            txtDni.Clear();
            txtEdadMinima.Clear();
            txtEdadMaxima.Clear();
            funcionesTexto = "";
            rutinasTexto = "";
            observacionesTexto = "";
            cboEstado.SelectedIndex = 0;
            txtHoraInicio.Clear();
            txtMinutosInicio.Clear();
            txtHoraFin.Clear();
            txtMinutosFin.Clear();
            txtCantiadadHoras.Clear();
            txtSueldo.Clear();
        }

        private bool RestriccionesPedido()
        {
            if (string.IsNullOrWhiteSpace(txtDni.Text) || txtDni.Text.Length != 8)
            {
                if (string.IsNullOrWhiteSpace(txtDni.Text))
                {
                    MostrarMensajeAdvertencia("Debe ingresar un DNI.");
                    return true;
                }
                if (txtDni.Text.Length != 8)
                {
                    MostrarMensajeAdvertencia("El DNI debe tener 8 caracteres.");
                    return true;
                }
            }
            if (string.IsNullOrWhiteSpace(modalidadSeleccionada))
            {
                MostrarMensajeAdvertencia("Debe seleccionar una MODALIDAD.");
                return true;
            }
            if (string.IsNullOrWhiteSpace(puestoSeleccionado))
            {
                MostrarMensajeAdvertencia("Debe seleccionar un PUESTO.");
                return true;
            }
            if (string.IsNullOrWhiteSpace(txtEdadMinima.Text))
            {
                MostrarMensajeAdvertencia("Debe llenar el campo EDAD MINIMA");
                return true;
            }
            if (string.IsNullOrWhiteSpace(txtEdadMaxima.Text))
            {
                MostrarMensajeAdvertencia("Debe llenar el campo EDAD MAXIMA");
                return true;
            }
            if (string.IsNullOrWhiteSpace(funcionesTexto))
            {
                MostrarMensajeAdvertencia("Debe ingresar alguna descripcion en el campo FUNCIONES");
                return true;
            }
            if (string.IsNullOrWhiteSpace(rutinasTexto))
            {
                MostrarMensajeAdvertencia("Debe ingresar alguna descripcion en el campo RUTINAS");
                return true;

            }
            if (string.IsNullOrWhiteSpace(observacionesTexto))
            {
                MostrarMensajeAdvertencia("Debe ingresar alguna descripcion en el campo OBSERVACIONES");
                return true;
            }

            if (string.IsNullOrWhiteSpace(txtHoraInicio.Text) || string.IsNullOrWhiteSpace(txtMinutosInicio.Text))
            {
                if (string.IsNullOrWhiteSpace(txtHoraInicio.Text))
                {
                    MostrarMensajeAdvertencia("Falta completar el campo HORA en HORA INICIO.");
                    return true;
                }
                if (string.IsNullOrWhiteSpace(txtMinutosInicio.Text))
                {
                    MostrarMensajeAdvertencia("Falta completar el campo MINUTOS en HORA INICIO.");
                    return true;
                }
                else
                {
                    MostrarMensajeAdvertencia("Falta completar el ambos campos en HORA INICIO.");
                    return true;
                }
            }

            if (string.IsNullOrWhiteSpace(txtHoraFin.Text) || string.IsNullOrWhiteSpace(txtMinutosFin.Text))
            {
                if (string.IsNullOrWhiteSpace(txtHoraFin.Text))
                {
                    MostrarMensajeAdvertencia("Falta completar el campo HORA en HORA FIN.");
                    return true;
                }
                if (string.IsNullOrWhiteSpace(txtMinutosFin.Text))
                {
                    MostrarMensajeAdvertencia("Falta completar el campo MINUTOS en HORA FIN.");
                    return true;
                }
                else
                {
                    MostrarMensajeAdvertencia("Falta completar el ambos campos en HORA FIN.");
                    return true;
                }
            }

            if (string.IsNullOrWhiteSpace(txtSueldo.Text))
            {
                MostrarMensajeAdvertencia("Debe ingresar alguna descripcion para el campo SUELDO.");
                return true;
            }

            return false;
        }

        private void MostrarMensajeAdvertencia(string mensaje)
        {
            MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        private int ObtenerIdUsuario()
        {

            return 1;
        }

        private void txtHoraInicio_TextChanged(object sender, EventArgs e)
        {
            // Desconectar temporalmente el evento para evitar bucles
            txtHoraInicio.TextChanged -= txtHoraInicio_TextChanged;

            string input = txtHoraInicio.Text;

            // Verificar si el campo está vacío
            if (!string.IsNullOrWhiteSpace(input))
            {
                if (!int.TryParse(input, out int hora) || hora < 0 || hora > 23)
                {
                    MessageBox.Show("Por favor, ingrese una hora válida entre 00 y 24.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtHoraInicio.Text = "";
                }
            }

            // Volver a conectar el evento
            txtHoraInicio.TextChanged += txtHoraInicio_TextChanged;
        }

        private void txtHoraFin_TextChanged(object sender, EventArgs e)
        {
            txtHoraFin.TextChanged -= txtHoraFin_TextChanged;

            string input = txtHoraFin.Text;

            // Verificar si el campo está vacío
            if (!string.IsNullOrWhiteSpace(input))
            {
                if (!int.TryParse(input, out int hora) || hora < 0 || hora > 23)
                {
                    MessageBox.Show("Por favor, ingrese una hora válida entre 00 y 24.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtHoraFin.Text = "";
                }
            }

            txtHoraFin.TextChanged += txtHoraFin_TextChanged;
        }

        private void txtMinutosInicio_TextChanged(object sender, EventArgs e)
        {
            txtMinutosInicio.TextChanged -= txtMinutosInicio_TextChanged;

            string input = txtMinutosInicio.Text;

            // Verificar si el campo está vacío
            if (!string.IsNullOrWhiteSpace(input))
            {
                if (!int.TryParse(input, out int minuto) || minuto < 0 || minuto > 59)
                {
                    MessageBox.Show("Por favor, ingrese los minutos dentro del rango 00 y 59.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMinutosInicio.Text = "";
                }
            }

            txtMinutosInicio.TextChanged += txtMinutosInicio_TextChanged;
        }

        private void txtMinutosFin_TextChanged(object sender, EventArgs e)
        {
            txtMinutosFin.TextChanged -= txtMinutosFin_TextChanged;

            string input = txtMinutosFin.Text;

            // Verificar si el campo está vacío
            if (!string.IsNullOrWhiteSpace(input))
            {
                if (!int.TryParse(input, out int minuto) || minuto < 0 || minuto > 59)
                {
                    MessageBox.Show("Por favor, ingrese los minutos dentro del rango 00 y 59.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMinutosFin.Text = "";
                }
            }

            txtMinutosFin.TextChanged += txtMinutosFin_TextChanged;
        }
        private string GenerarCodigoPedido()
        {
            var pedidos = logPedido.Instancia.ListarPedidos();

            if (pedidos == null || pedidos.Count == 0)
            {
                return "1";
            }

            int ultimoCodigo;
            if (int.TryParse(pedidos.Last().codPedido, out ultimoCodigo))
            {
                return (ultimoCodigo + 1).ToString();
            }

            // En caso de que no se pueda parsear el código anterior, retornar 1 como fallback
            return "1";
        }

        private DateTime ObtenerHoraCompleta(string hora, string minutos)
        {
            try
            {
                string horaCompleta = $"{hora}:{minutos}";
                return DateTime.ParseExact(horaCompleta, "HH:mm", null);
            }
            catch (FormatException)
            {
                MessageBox.Show("Formato de hora no válido. Por favor, ingrese una hora válida.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return DateTime.MinValue; // Devuelve un valor por defecto en caso de error
            }
        }
    }
}
