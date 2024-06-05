using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using Guna.UI2.WinForms;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath;
using System.Security.Cryptography;
using System.Web.Caching;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Net.NetworkInformation;
using System.Threading;
using static Guna.UI2.Native.WinApi;
using System.Web.Routing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;
using System.Security.AccessControl;
using System.Web.UI.WebControls;
using System.Windows.Forms.DataVisualization.Charting;

namespace NANAS_AMAS
{
    public partial class FormEmpleador : Form
    {
        private FormMotivo motivo;
        private entEmpleador empleador;
        private string mensajeMotivo, motivoEnc;
        List<entEmpleador> empleadorEncontrado = new List<entEmpleador>();

        public FormEmpleador()
        {
            InitializeComponent();
            ListarEmpleador();
            initComboBox();
            empleador = new entEmpleador();
            motivo = new FormMotivo(this);
            motivo.FormClosed += new FormClosedEventHandler(Motivo_FormClosed); 
        }

        public void ListarEmpleador()
        {
            dgvEmpleadores.DataSource = logEmpleador.Instancia.ListarEmpleadores();
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnEditar.Visible = false;
            btnAgregar.Enabled = true;
            cbProvincia.Enabled = false;
            cbDistrito.Enabled = false;
        }

        private bool restriccionesDni()
        {
            if (string.IsNullOrWhiteSpace(txtDni.Text) || txtDni.Text.Length != 8)
            {
                MostrarMensajeAdvertencia("Debe ingresar un DNI válido");
                return true;
            }
                return false;
        }

        public void BuscarEmpleado()
        {
            string dniEmpleador = txtDni.Text.Trim();  
            empleadorEncontrado = logEmpleador.Instancia.ListarEmpleadorPorDni(dniEmpleador);                    
        }
        
        

        private bool Restricciones()
        {
            if (string.IsNullOrWhiteSpace(txtDni.Text) || txtDni.Text.Length != 8)
            {
                MostrarMensajeAdvertencia("Ingrese un DNI válido");
                return true;
            }
            if (string.IsNullOrWhiteSpace(txtNombres.Text))
            {
                MostrarMensajeAdvertencia("Debe ingresar el NOMBRE.");
                return true;
            }
            if (string.IsNullOrWhiteSpace(txtApellidoP.Text))
            {
                MostrarMensajeAdvertencia("Debe ingresar el APELLIDO PATERNO.");
                return true;
            }
            if (string.IsNullOrWhiteSpace(txtApellidoM.Text))
            {
                MostrarMensajeAdvertencia("Debe ingresar el APELLIDO MATERNO.");
                return true;
            }
            if (string.IsNullOrWhiteSpace(txtCelular1.Text) || txtCelular1.Text.Length != 9)
            {
                MostrarMensajeAdvertencia("Debe ingresar un NÚMERO DE CELULAR");
                return true;
            }
            else if (!string.IsNullOrWhiteSpace(txtCelular2.Text) && txtCelular2.Text.Length != 9)
            {
                MostrarMensajeAdvertencia("Debe ingresar un número de 9 dígitos en el celular de WHATSAPP");
                return true;
            }
            if (cboModoContacto.SelectedIndex == -1)
            {
                MostrarMensajeAdvertencia("Debe seleccionar una opción  de MODO DE CONTACTO.");
                return true;

            }
            if (cbDepartamento.SelectedIndex == -1)
            {
                MostrarMensajeAdvertencia("Debe seleccionar una opción  de DEPARTAMENTO.");
                return true;
            }

            if (cbProvincia.SelectedIndex == -1)
            {
                MostrarMensajeAdvertencia("Debe seleccionar una opción  de PROVINCIA.");
                return true;
            }

            if (cbDistrito.SelectedIndex == -1)
            {
                MostrarMensajeAdvertencia("Debe seleccionar una opción  de DISTRITO.");
                return true;
            }

            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MostrarMensajeAdvertencia("Debe ingresar la DIRECCIÓN.");
                return true;
            }
            if (string.IsNullOrWhiteSpace(txtReferencia.Text))
            {
                MostrarMensajeAdvertencia("Debe ingresar la REFERENCIA.");
                return true;
            }

            return false;
        }

        private void MostrarMensajeAdvertencia(string mensaje)
        {
            MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Restricciones())
            {
                return;
            }
            try
            {
                entEmpleador empleador = new entEmpleador();
                empleador.dni = txtDni.Text.Trim();
                empleador.nombre = txtNombres.Text.Trim();
                empleador.apellidoPaterno = txtApellidoP.Text.Trim();
                empleador.apellidoMaterno = txtApellidoM.Text.Trim();
                empleador.celular1 = txtCelular1.Text.Trim();
                empleador.celular2 = txtCelular2.Text.Trim();
                empleador.modo_contacto = cboModoContacto.Text.Trim();
                empleador.direccion = txtDireccion.Text.Trim();
                empleador.distrito = cbDistrito.Text.Trim();
                empleador.provincia = cbProvincia.Text.Trim();
                empleador.departamento = cbDepartamento.Text.Trim();
                empleador.ref_domicilio = txtReferencia.Text.Trim();
                empleador.transporte_publico = txtTransPublico.Text.Trim();
                empleador.lista_excluidos = checkBox1.Checked;
                if (checkBox1.Checked == true)
                {
                    empleador.motivo_excluido = mensajeMotivo;

                }
                if (checkBox1.Checked == false)
                {
                    empleador.motivo_excluido = "";
                }

                empleador.usuario_id = 1;

                logEmpleador.Instancia.InsertarEmpleador(empleador);

                MessageBox.Show("Empleador agregado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarCampos();
                ListarEmpleador();
                motivo.limpiarMotivo();
                ocultarEditar();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar el empleador: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LimpiarCampos()
        {
            txtNombres.Clear();
            txtApellidoP.Clear();
            txtApellidoM.Clear();
            txtDni.Clear();
            txtDireccion.Clear();
            txtCelular1.Clear();
            txtCelular2.Clear();
            cbDistrito.SelectedIndex = -1;
            cbProvincia.SelectedIndex = -1;
            cbDepartamento.SelectedIndex = -1;            
            cboModoContacto.SelectedIndex = -1;
            txtReferencia.Clear();
            txtTransPublico.Clear();
            cbDistrito.Enabled = false;
            cbProvincia.Enabled = false;
        }


        private void btnEliminar_Click2(object sender, EventArgs e, bool limpiar)
        {
            try
            {
                entEmpleador empleador = new entEmpleador();
                empleador.dni = txtDni.Text.Trim();
                logEmpleador.Instancia.EliminarEmpleador(empleador);                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            if (limpiar)
            {
                LimpiarCampos();
                checkBox1.Checked = false;
                motivo.limpiarMotivo();
            }
            ListarEmpleador();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este elemento?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                btnEliminar_Click2(sender, e, true);
                MessageBox.Show("Empleador eliminado Correctamente.");
            }
            else
            {
                MessageBox.Show("Eliminación cancelada");
            }
        }

        private void txtCelular2_TextChanged(object sender, EventArgs e)
        {
            string texto = txtCelular2.Text;
            string textoNumerico = string.Empty;

            foreach (char c in texto)
            {
                if (char.IsDigit(c))
                {
                    textoNumerico += c;
                }
            }

            if (textoNumerico.Length > 9)
            {
                textoNumerico = textoNumerico.Substring(0, 9);
            }

            txtCelular2.Text = textoNumerico;
            txtCelular2.SelectionStart = txtCelular2.Text.Length;
        }

        private void txtNombres_TextChanged(object sender, EventArgs e)
        {
             int cursorPosition = txtNombres.SelectionStart;

             string upperText = txtNombres.Text.ToUpper();

             foreach (char c in upperText)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                {
                    //MessageBox.Show("El nombre solo puede contener caracteres alfabéticos y espacios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNombres.Text = string.Empty;
                    return;
                }
            }

             txtNombres.Text = upperText;

             txtNombres.SelectionStart = cursorPosition;
        }

        private void txtApellidoP_TextChanged(object sender, EventArgs e)
        {
            int cursorPosition = txtApellidoP.SelectionStart;

            string upperText = txtApellidoP.Text.ToUpper();

            foreach (char c in upperText)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                {
                    //MessageBox.Show("El apellido paterno solo puede contener caracteres alfabéticos y espacios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtApellidoP.Text = string.Empty;
                    return;
                }
            }

            
            txtApellidoP.Text = upperText;

            txtApellidoP.SelectionStart = cursorPosition;
        }


        private void txtApellidoM_TextChanged(object sender, EventArgs e)
        {
            int cursorPosition = txtApellidoM.SelectionStart;

             string upperText = txtApellidoM.Text.ToUpper();

             foreach (char c in upperText)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                {
                    //MessageBox.Show("El apellido materno solo puede contener caracteres alfabéticos y espacios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtApellidoM.Text = string.Empty;
                    return;
                }
            }

             txtApellidoM.Text = upperText;

             txtApellidoM.SelectionStart = cursorPosition;
        }

        private void txtCelular1_TextChanged(object sender, EventArgs e)
        {
            string texto = txtCelular1.Text;
            string textoNumerico = string.Empty;

            foreach (char c in texto)
            {
                if (char.IsDigit(c))
                {
                    textoNumerico += c;
                }
            }

            if (textoNumerico.Length > 9)
            {
                textoNumerico = textoNumerico.Substring(0, 9);
            }

            txtCelular1.Text = textoNumerico;

            txtCelular1.SelectionStart = txtCelular1.Text.Length;
        }

        public void initComboBox()
        {
            cbDepartamento.Items.AddRange(new string[]
            {
        "AMAZONAS", "ÁNCASH", "APURÍMAC", "AREQUIPA", "AYACUCHO", "CAJAMARCA", "CALLAO", "CUSCO",
        "HUANCAVELICA", "HUÁNUCO", "ICA", "JUNÍN", "LA LIBERTAD", "LAMBAYEQUE", "LIMA", "LORETO",
        "MADRE DE DIOS", "MOQUEGUA", "PASCO", "PIURA", "PUNO", "SAN MARTÍN", "TACNA", "TUMBES", "UCAYALI"
            });
            cboModoContacto.Items.AddRange(new string[]
            {
                "FACEBOOK","TWITTER", "INSTAGRAM", "LINKEDIN", "WHATSAPP", "RECOMENDADOS", "PERIÓDICO"

            });
        }

        private void cboModoContacto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string redSocialSeleccionada = cboModoContacto.SelectedItem?.ToString();

                switch (redSocialSeleccionada)
                {
                    case "FACEBOOK":
                        break;
                    case "TWITTER":
                        break;
                    case "Instagram":
                        break;
                    case "LINKEDIN":
                        break;
                    case "WHATSAPP":
                        break;
                    default:
                    case "RECOMENDADOS":
                        break;
                    case "PERIÓDICO":
                        break;
                }
            
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            txtDireccion.Text = txtDireccion.Text.ToUpper();

            txtDireccion.SelectionStart = txtDireccion.Text.Length;
            txtDireccion.SelectionLength = 0;

            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                //MessageBox.Show("La dirección no puede estar vacía.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDireccion.Text = string.Empty;
                return;
            }
        }


        private void txtMotivo_TextChanged(object sender, EventArgs e)
        {
            txtReferencia.Text = txtReferencia.Text.ToUpper();

            txtReferencia.SelectionStart = txtReferencia.Text.Length;
            txtReferencia.SelectionLength = 0;

            if (string.IsNullOrWhiteSpace(txtReferencia.Text))
            {
                //MessageBox.Show("El motivo no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtReferencia.Text = string.Empty;
                return;
            }


        }

        private void txtTransPublico_TextChanged(object sender, EventArgs e)
        {
            txtTransPublico.Text = txtTransPublico.Text.ToUpper();

            txtTransPublico.SelectionStart = txtTransPublico.Text.Length;
            txtTransPublico.SelectionLength = 0;


        }
        private void cbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string selectedDepartamento = cbDepartamento.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedDepartamento)) return;            
            switch (selectedDepartamento)
            {
                case "AMAZONAS":
                    cbProvincia.Items.AddRange(new string[]
                    {
                "CHACHAPOYAS", "BAGUA", "BONGARA", "CONDORCANQUI", "LUYA",
                        "RODRIGUEZ DE MENDOZA",
                "UTCUBAMBA"
                    });
                    break;
                case "ÁNCASH":
                    cbProvincia.Items.AddRange(new string[]
                    {
                "HUARAZ", "AIJA", "ANTONIO RAIMONDI", "ASUNCION", "BOLOGNESI", "CARHUAZ", "CARLOS FERMIN FITZCARRALD",
                "CASMA", "CORONGO", "HUARI", "HUARMEY", "HUAYLAS", "MARISCAL LUZURIAGA", "OCROS", "PALLASCA",
                "POMABAMBA", "RECUAY", "SANTA", "SIHUAS", "YUNGAY"
                    });
                    break;
                case "APURÍMAC":
                    cbProvincia.Items.AddRange(new string[]
                    {
                "ABANCAY", "ANDAHUAYLAS", "ANTABAMBA", "AYMARAES", "COTABAMBAS", "CHINCHEROS", "GRAU"
                    });
                    break;
                case "AREQUIPA":
                    cbProvincia.Items.AddRange(new string[]
                    {
                "AREQUIPA", "CAMANÁ", "CARAVELÍ", "CASTILLA", "CAYLLOMA", "CONDESUYOS", "ISLAY", "LA UNIÓN"
                    });
                    break;
                case "AYACUCHO":
                    cbProvincia.Items.AddRange(new string[]
                    {
                "HUAMANGA", "CANGALLO", "HUANCA SANCOS", "HUANTA", "LA MAR", "LUCANAS", "PARINACOCHAS",
                "PAUCAR DEL SARA SARA", "SUCRE", "VICTOR FAJARDO", "VILCAS HUAMAN"
                    });
                    break;
                case "CAJAMARCA":
                    cbProvincia.Items.AddRange(new string[]
                    {
                "CAJAMARCA", "CAJABAMBA", "CELENDIN", "CHOTA", "CONTUMAZA", "CUTERVO", "HUALGAYOC", "JAÉN",
                "SAN IGNACIO", "SAN MARCOS", "SAN MIGUEL", "SAN PABLO", "SANTA CRUZ"
                    });
                    break;
                case "CALLAO":
                    cbProvincia.Items.AddRange(new string[]
                    {
                "CALLAO"
                    });
                    break;
                case "CUSCO":
                    cbProvincia.Items.AddRange(new string[]
                    {
                "CUSCO", "ACOMAYO", "ANTA", "CALCA", "CANAS", "CANCHIS", "CHUMBIVILCAS", "ESPINAR",
                "LA CONVENCIÓN", "PARURO", "PAUCARTAMBO", "QUISPICANCHI", "URUBAMBA"
                    });
                    break;
                case "HUANCAVELICA":
                    cbProvincia.Items.AddRange(new string[]
                    {
                "HUANCAVELICA", "ACOBAMBA", "ANGARAES", "CASTROVIRREYNA", "CHURCAMPA", "HUAYTARA"
                    });
                    break;
                case "HUÁNUCO":
                    cbProvincia.Items.AddRange(new string[]
                    {
                "HUÁNUCO", "AMBO", "DOS DE MAYO", "HUACAYBAMBA", "HUAMALIES", "LEONCIO PRADO", "MARAÑÓN",
                "PACHITEA", "PUERTO INCA", "LAURICOCHA", "YAROWILCA"
                    });
                    break;
                case "ICA":
                    cbProvincia.Items.AddRange(new string[]
                    {
                "ICA", "CHINCHA", "NASCA", "PALPA", "PISCO"
                    });
                    break;
                case "JUNÍN":
                    cbProvincia.Items.AddRange(new string[]
                    {
                "HUANCAYO", "CONCEPCIÓN", "CHANCHAMAYO", "JAUJA", "JUNÍN", "SATIPO", "TARMA", "YAULI",
                "CHUPACA"
                    });
                    break;
                case "LA LIBERTAD":
                    cbProvincia.Items.AddRange(new string[]
                    {
                "TRUJILLO", "ASCOPE", "BOLIVAR", "CHEPEN", "JULCAN", "OTUZCO", "PACASMAYO", "PATAZ",
                "SANCHEZ CARRION", "SANTIAGO DE CHUCO", "GRAN CHIMU", "VIRÚ"
                    });
                    break;
                case "LAMBAYEQUE":
                    cbProvincia.Items.AddRange(new string[]
                    {
                "CHICLAYO", "FERREÑAFE", "LAMBAYEQUE"
                    });
                    break;
                case "LIMA":
                    cbProvincia.Items.AddRange(new string[]
                    {
                "LIMA", "BARRANCA", "CAJATAMBO", "CANTA", "CAÑETE", "HUARAL", "HUAROCHIRÍ", "HUAURA",
                "OYÓN", "YAUYOS"
                    });
                    break;
                case "LORETO":
                    cbProvincia.Items.AddRange(new string[]
                    {
                "MAYNAS", "ALTO AMAZONAS", "LORETO", "MARISCAL RAMÓN CASTILLA", "REQUENA", "UCAYALI",
                "DATEM DEL MARAÑÓN"
                    });
                    break;
                case "MADRE DE DIOS":
                    cbProvincia.Items.AddRange(new string[]
                    {
                "TAMBOPATA", "MANU", "TAHUAMANU"
                    });
                    break;
                case "MOQUEGUA":
                    cbProvincia.Items.AddRange(new string[]
                    {
                "MARISCAL NIETO", "GENERAL SÁNCHEZ CERRO", "ILO"
                    });
                    break;
                case "PASCO":
                    cbProvincia.Items.AddRange(new string[]
                    {
                "PASCO", "DANIEL ALCIDES CARRIÓN", "OXAPAMPA"
                    });
                    break;
                case "PIURA":
                    cbProvincia.Items.AddRange(new string[]
                    {
                "PIURA", "AYABACA", "HUANCABAMBA", "MORROPÓN", "PAITA",
                "SULLANA", "TALARA"
            });
                    break;
                case "PUNO":
                    cbProvincia.Items.AddRange(new string[]
                    {
                "PUNO", "AZÁNGARO", "CARABAYA", "CHUCUITO", "EL COLLAO", "HUANCANÉ", "LAMPA",
                "MELGAR", "MOHO", "SAN ANTONIO DE PUTINA", "SAN ROMÁN", "SANDIA", "YUNGUYO"
                    });
                    break;
                case "SAN MARTÍN":
                    cbProvincia.Items.AddRange(new string[]
                    {
                "MOYOBAMBA", "BELLAVISTA", "EL DORADO", "HUALLAGA", "LAMAS", "MARISCAL CÁCERES", "PICOTA",
                "RIOJA", "SAN MARTÍN", "TOCACHE"
                    });
                    break;
                case "TACNA":
                    cbProvincia.Items.AddRange(new string[]
                    {
                "TACNA", "CANDARAVE", "JORGE BASADRE", "TARATA"
                    });
                    break;
                case "TUMBES":
                    cbProvincia.Items.AddRange(new string[]
                    {
                "TUMBES", "CONTRALMIRANTE VILLAR", "ZARUMILLA"
                    });
                    break;
                case "UCAYALI":
                    cbProvincia.Items.AddRange(new string[]
                    {
                "CORONEL PORTILLO", "ATALAYA", "PADRE ABAD", "PURÚS"
                    });
                    break;
                default:
                    cbProvincia.Text = "";
                    break;
            }
            cbProvincia.SelectedItem = -1;
            cbProvincia.Enabled = true;
            cbDistrito.SelectedItem = -1;
            cbDistrito.Enabled = false;
        }



        private void cbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbDistrito.Items.Clear();
            cbDistrito.Text = "";
            string selectedProvince = cbProvincia.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedProvince)) return;

            string[] distritos = GetDistritosByProvincia(selectedProvince);
            if (distritos != null)
            {
                cbDistrito.Items.AddRange(distritos);
                cbDistrito.Enabled = true;
            }
        }

        private string[] GetDistritosByProvincia(string provincia)
        {
            switch (provincia)
            {
                // Amazonas
                case "CHACHAPOYAS":
                    return new string[]
                    {
                        "Chachapoyas",
        "Asunción",
        "Balsas",
        "Cheto",
        "Chiliquín",
        "Chuquibamba",
        "Granada",
        "Huancas",
        "La Jalca",
        "La Jalca",
        "Leimebamba",
        "Levanto",
        "Magdalena",
        "Mariscal Castilla",
        "Molinopampa",
        "Montevideo",
        "Olleros",
        "Quinjalca",
        "San Francisco de Daguas",
        "San Isidro de Maino",
        "Soloco",
        "Sonche",

                    };
                case "BAGUA":
                    return new string[]
                    {
                        "Bagua Grande",
                        "Aramango",
                        "Copallin",
                        "El Parco",
                        "Imaza",
                        "La Peca",
                    };
                case "BONGARA":
                    return new string[]
                    {
                        "Jumbilla",
                        "Chisquilla",
                        "Churuja",
                        "Corosha",
                        "Cuispes",
                        "Florida",
                        "Jazán",
                        "Recta",
                        "San Carlos",
                        "Shipasbamba",
                        "Valera",
                        "Yambrasbamba",

                    };
                case "CONDORCANQUI":
                    return new string[]
                    {
                        "Nieva",
                        "El Cenepa",
                        "Río Santiago",
                    };
                case "LUYA":
                    return new string[]
                    {
                        "Lamud",
                        "Camporredondo",
                        "Cocabamba",
                        "Colcamar",
                        "Conila",
                        "Inguilpata",
                        "Longuita",
                        "Lonya Chico",
                        "Luya",
                        "Luya Viejo",
                        "María",
                        "Ocalli",
                        "Ocumal",
                        "Pisuquia",
                        "Providencia",
                        "San Cristóbal",
                        "San Francisco de Yeso",
                        "San Jerónimo",
                        "San Juan de Lopecancha",
                        "Santa Catalina",
                        "Santo Tomas",
                        "Tingo",
                        "Trita",
                    };

                case "RODRIGUEZ DE MENDOZA":
                    return new string[]
                    {
                        "San Nicolás",
                        "Chirimoto",
                        "Cochamal",
                        "Huambo",
                        "Limabamba",
                        "Longar",
                        "Mariscal Benavides",
                        "Milpuc",
                        "Omia",
                        "Santa Rosa",
                        "Totora",
                        "Vista Alegre"
                    };

                case "UTCUBAMBA":
                    return new string[]
                    {
                        "Bagua Grande",
                        "Cajaruro",
                        "Cumba",
                        "El Milagro",
                        "Jamalca",
                        "Lonya Grande",
                        "Yamon",
                    };


                // Áncash
                case "HUARAZ":
                    return new string[]
                    {
                        "Huaraz",
                        "Cochabamba",
                        "Colcabamba",
                        "Huanchay",
                        "Independencia",
                        "Jangas",
                        "La Libertad",
                        "Olleros",
                        "Pampas Grande",
                        "Pariacoto",
                        "Pira",
                        "Tarica",
                    };

                case "AIJA":
                    return new string[]
                    {
                        "Aija",
                        "Coris",
                        "Huacllan",
                        "La Merced",
                        "Succha",
                    };

                case "ANTONIO RAIMONDI":
                    return new string[]
                    {
                        "Llamellin",
                        "Aczo",
                        "Chaccho",
                        "Chingas",
                        "Mirgas",
                    };

                case "ASUNCION":
                    return new string[]
                    {
                        "Chacas",
                        "Acochaca",
                    };

                case "BOLOGNESI":
                    return new string[]
                    {
                        "Chiquian",
                        "Abelardo Pardo Lezameta",
                        "Antonio Raymondi",
                        "Aquia",
                        "Cajacay",
                        "Canis",
                        "Colquioc",
                        "Huallanca",
                        "Huasta",
                        "Huayllacayan",
                        "La Primavera",
                        "Mangas",
                        "Pacllon",
                        "San Miguel de Corpanqui",
                        "Ticllos",
                    };

                case "CARHUAZ":
                    return new string[]
                    {
                        "Carhuaz",
                        "Acopampa",
                        "Amashca",
                        "Anta",
                        "Ataquero",
                        "Marcara",
                        "Pariahuanca",
                        "San Miguel de Aco",
                    };

                case "CARLOS FERMIN FITZCARRALD":
                    return new string[]
                    {
                        "San Luis",
                        "San Nicolás",
                        "Yauya",
                    };

                case "CASMA":
                    return new string[]
                    {
                        "Casma",
                        "Buena Vista Alta",
                        "Comandante Noel",
                        "Yautan",
                    };

                case "CORONGO":
                    return new string[]
                    {
                        "Corongo",
                        "Aco",
                        "Bambas",
                        "Cusca",
                        "La Pampa",
                        "Yanac",
                        // Agrega más distritos si es necesario
                    };

                case "HUARI":
                    return new string[]
                    {
                        "Huari",
                        "Anra",
                        "Cajay",
                        "Chavin de Huantar",
                        "Huacachi",
                        "Huacchis",
        "Huachis",
        "Huantar",
        "Masin",
        "Paucas",
        "Ponto",
        "Rahuapampa",
        "Rapayan",
        "San Marcos",
        "San Pedro de Chana",
        "Uco",
                        // Agrega más distritos si es necesario
                    };

                case "HUARMEY":
                    return new string[]
                    {
        "Huarmey",
        "Cochapeti",
        "Culebras",
        "Huayan",
                        // Agrega más distritos si es necesario
                    };

                case "HUAYLAS":
                    return new string[]
                    {
        "Caraz",
        "Huallanca",
        "Huata",
        "Huaylas",
        "Mato",
        "Pamparomas",
        "Pueblo Libre",
        "Santa Cruz",
        "Santo Toribio",
        "Yuracmarca",
                        // Agrega más distritos si es necesario
                    };

                case "MARISCAL LUZURIAGA":
                    return new string[]
                    {
        "Piscobamba",
        "Casca",
        "Eleazar Guzmán Barrón",
        "Fidel Olivas Escudero",
        "Llama",
        "Llumpa",
        "Lucma",
        "Musga",
                        // Agrega más distritos si es necesario
                    };

                case "OCROS":
                    return new string[]
                    {
        "Ocros",
        "Acas",
        "Cajamarquilla",
        "Carhuapampa",
        "Cochas",
        "Congas",
        "Llipa",
        "San Cristóbal de Raján",
        "San Pedro",
        "Santiago de Chilcas",
                        // Agrega más distritos si es necesario
                    };

                case "PALLASCA":
                    return new string[]
                    {
        "Cabana",
        "Bolognesi",
        "Conchucos",
        "Huacaschuque",
        "Huandoval",
        "Lacabamba",
        "Llapo",
        "Pallasca",
        "Pampas",
        "Santa Rosa",
        "Tauca",
        "Yautan",
                        // Agrega más distritos si es necesario
                    };

                case "POMABAMBA":
                    return new string[]
                    {
        "Pomabamba",
        "Huayllan",
        "Parobamba",
        "Quinuabamba",
                        // Agrega más distritos si es necesario
                    };

                case "RECUAY":
                    return new string[]
                    {
        "Recuay",
        "Catac",
        "Cotaparaco",
        "Huayllapampa",
        "Llacllin",
        "Marca",
        "Pampas Chico",
        "Pararin",
        "Tapacocha",
        "Ticapampa",
                        // Agrega más distritos si es necesario
                    };

                case "SANTA":
                    return new string[]
                    {
        "Chimbote",
        "Cáceres del Perú",
        "Coishco",
        "Macate",
        "Moro",
        "Nepeña",
        "Samanco",
        "Santa",
        "Nuevo Chimbote",
                        // Agrega más distritos si es necesario
                    };

                case "SIHUAS":
                    return new string[]
                    {
        "Sihuas",
        "Acobamba",
        "Alfonso Ugarte",
        "Cashapampa",
        "Chingalpo",
        "Huayllabamba",
        "Quiches",
        "Ragash",
        "San Juan",
        "Sicsibamba",
                        // Agrega más distritos si es necesario
                    };

                case "YUNGAY":
                    return new string[]
                    {
        "Yungay",
        "Cascapara",
        "Mancos",
        "Matacoto",
        "Quillo",
        "Ranrahirca",
        "Shupluy",
        "Yanama",
                        // Agrega más distritos si es necesario
                    };


                // Apurímac
                case "ABANCAY":
                    return new string[]
                    {
        "Abancay",
        "Chacoche",
        "Circa",
        "Curahuasi",
        "Huanipaca",
        "Lambrama",
        "Pichirhua",
        "San Pedro de Cachora",
        "Tamburco",
                        // Agrega más distritos si es necesario
                    };

                case "ANDAHUAYLAS":
                    return new string[]
                    {
        "Andahuaylas",
        "Andarapa",
        "Chiara",
        "Huancarama",
        "Huancaray",
        "Huayana",
        "Kishuara",
        "Pacobamba",
        "Pacobamba",
        "Pampachiri",
        "Pomacocha",
        "San Antonio de Cachi",
        "San Jerónimo",
        "San Miguel de Chaccrampa",
        "Santa María de Chicmo",
        "Talavera",
        "Tumay Huaraca",
                        // Agrega más distritos si es necesario
                    };

                case "ANTABAMBA":
                    return new string[]
                    {
        "Antabamba",
        "El Oro",
        "Huaquirca",
        "Juan Espinoza Medrano",
                        // Agrega más distritos si es necesario
                    };

                case "AYMARAES":
                    return new string[]
                    {
        "Chalhuanca",
        "Capaya",
        "Caraybamba",
        "Chapimarca",
        "Colcabamba",
        "Cotaruse",
        "Ihuayllo",
        "Justo Apu Sahuaraura",
        "Lucre",
        "Pocohuanca",
        "San Juan de Chacña",
        "Sañayca",
        "Soraya",
        "Tapairihua",
        "Tintay",
                        // Agrega más distritos si es necesario
                    };

                case "COTABAMBAS":
                    return new string[]
                    {
        "Tambobamba",
        "Cotabambas",
        "Coyllurqui",
        "Haquira",
        "Mara",
                        // Agrega más distritos si es necesario
                    };

                case "CHINCHEROS":
                    return new string[]
                    {
        "Chincheros",
        "Anco_Huallo",
        "Cocharcas",
        "Huaccana",
        "Ocobamba",
        "Ongoy",
        "Uranmarca",
        "Ranracancha",
                        // Agrega más distritos si es necesario
                    };

                case "GRAU":
                    return new string[]
                    {
        "Chuquibambilla",
        "Curasco",
        "Curpahuasi",
        "Gamarra",
        "Huayllati",
        "Mamara",
        "Micaela Bastidas",
        "Pataypampa",
        "Progreso",
        "San Antonio",
        "Santa Rosa",
        "Turpay",
                        // Agrega más distritos si es necesario
                    };

                // Arequipa
                case "AREQUIPA":
                    return new string[]
                    {
        "Arequipa",
                        // Agrega más distritos si es necesario
                    };

                case "CAMANÁ":
                    return new string[]
                    {
        "Camaná",
        "José María Quimper",
        "Mariano Nicolás Valcárcel",
        "Mariscal Cáceres",
                        // Agrega más distritos si es necesario
                    };

                case "CARAVELÍ":
                    return new string[]
                    {
        "Caravelí",
        "Acarí",
        "Atico",
        "Atiquipa",
        "Bella Unión",
        "Cahuacho",
        "Chala",
        "Chaparra",
        "Huanuhuanu",
        "Jaqui",
        "Lomas",
        "Quicacha",
        "Yauca",
                        // Agrega más distritos si es necesario
                    };

                case "CASTILLA":
                    return new string[]
                    {
        "Aplao",
        "Andagua",
        "Ayo",
        "Chachas",
        "Chilcaymarca",
        "Choco",
        "Huancarqui",
        "Machaguay",
        "Orcopampa",
        "Pampacolca",
        "Tipán",
        "Uñon",
        "Viraco",
                        // Agrega más distritos si es necesario
                    };

                case "CAYLLOMA":
                    return new string[]
                    {
        "Chivay",
        "Achoma",
        "Cabanaconde",
        "Callalli",
        "Caylloma",
        "Coporaque",
        "Huambo",
        "Huanca",
        "Ichupampa",
        "Lari",
        "Lluta",
        "Maca",
        "Madrigal",
        "San Antonio de Chuca",
        "Sibayo",
        "Tapay",
        "Tisco",
        "Tuti",
        "Yanque",
        "Majes",
                        // Agrega más distritos si es necesario
                    };

                case "CONDESUYOS":
                    return new string[]
                    {
        "Chuquibamba",
        "Andaray",
        "Cayarani",
        "Chichas",
        "Iray",
        "Rio Grande",
        "Salamanca",
        "Yanaquihua",
                        // Agrega más distritos si es necesario
                    };

                case "ISLAY":
                    return new string[]
                    {
        "Mollendo",
        "Cocachacra",
        "Dean Valdivia",
        "Islay",
        "Mejía",
                        // Agrega más distritos si es necesario
                    };

                case "LA UNIÓN":
                    return new string[]
                    {
        "Cotahuasi",
        "Alca",
        "Charcana",
        "Huaynacotas",
        "Pampamarca",
        "Puyca",
        "Quechualla",
        "Sayla",
        "Tauria",
        "Tomepampa",
        "Toro",
                        // Agrega más distritos si es necesario
                    };


                // Ayacucho
                case "HUAMANGA":
                    return new string[]
                    {
        "Ayacucho", "Carmen Alto", "San Juan Bautista", "Santiago de Pischa", "Socos",
                        // Agrega más distritos si es necesario
                    };

                case "CANGALLO":
                    return new string[]
                    {
        "Cangallo", "Chuschi", "Los Morochucos", "María Parado de Bellido"
                        // Agrega más distritos si es necesario
                    };


                case "HUANTA":
                    return new string[]
                    {
        "Huanta","Anco",
"Ayahuanco", "Huamanguilla", "Iguain", "Luricocha", "Santillana", "Sivia",
                        // Agrega más distritos si es necesario
                    };

                case "LA MAR":
                    return new string[]
                    {
        "San Miguel","Ayna",
"Chungui",
"Tambo",
"Samugari",
                        // Agrega más distritos si es necesario
                    };

                case "LUCANAS":
                    return new string[]
                    {
        "Puquio","Aucara",
"Cabana",
"Carmen Salcedo",
"Chaviña",
"Chipao",
                        // Agrega más distritos si es necesario
                    };

                case "PARINACOCHAS":
                    return new string[]
                    {
        "Coracora","Chumpi",
"Coronel Castañeda",
"Pacapausa",
                        // Agrega más distritos si es necesario
                    };

                case "PAUCAR DEL SARA SARA":
                    return new string[]
                    {
        "Pausa","Colta",
"Oyolo",
"Pararca",
"San Javier de Alpabamba",
                        // Agrega más distritos si es necesario
                    };

                case "SUCRE":
                    return new string[]
                    {
        "Querobamba","Querobamba",
"Belmonte",
"Challhuahuacho",
"Chaviña",
"Huacaña",
                        // Agrega más distritos si es necesario
                    };

                case "VICTOR FAJARDO":
                    return new string[]
                    {
        "Huancapi","Huancaraylla",
"Hualla",
"Sánchez Carrión",
                        // Agrega más distritos si es necesario
                    };

                case "VILCAS HUAMAN":
                    return new string[]
                    {
        "Vilcas Huamán","Accomarca",
"Carhuanca",
"Concepción",
                        // Agrega más distritos si es necesario
                    };

                // Cajamarca
                case "CAJAMARCA":
                    return new string[]
                    {
                        "Cajamarca", "Asunción", "Chetilla", "Cospan", "Encañada", "Jesús", "Llacanora", "Los Baños del Inca", "Magdalena", "Matara", "Namora", "San Juan", "Utco"
                    };
                case "CAJABAMBA":
                    return new string[]
                    {
                         "Jaén", "Bellavista", "Chontali", "Colasay", "Huabal", "Las Pirias", "Pomahuaca", "Pucará", "Sallique", "San Felipe", "San José del Alto", "Santa Rosa", "Santo Domingo de la Capilla", "Shumba", "Yambrasbamba"
                    };
                case "CELENDIN":
                    return new string[]
                    {
                        "Celendín", "Chumuch", "Cortegana", "Huasmin", "Jorge Chávez", "José Gálvez", "Miguel Iglesias", "Oxamarca", "Sorochuco", "Sucre", "Utco", "La Libertad de Pallán"
                    };
                case "CHOTA":
                    return new string[]
                    {
"Chota", "Anguía", "Chadin", "Chiguirip", "Chimban", "Cochabamba", "Conchan", "Huambos", "Lajas", "Llama", "Miracosta", "Paccha", "Pion", "Querocoto", "San Juan de Licupis", "Tacabamba", "Tocmoche"
                    };
                case "CONTUMAZA":
                    return new string[]
                    {
"Contumazá", "Chilete", "Cupisnique", "Guzmango", "San Benito", "Santa Cruz de Toledo", "Tantarica", "Yonán"
                    };
                case "CUTERVO":
                    return new string[]
                    {
"Cutervo", "Callayuc", "Choros", "Cujillo", "La Ramada", "Pimpingos", "Querocotillo", "San Andrés de Cutervo", "San Juan de Cutervo", "San Luis de Lucma", "Santa Cruz", "Santo Domingo de la Capilla", "Santo Tomás", "Socota", "Toribio Casanova"
                    };
                case "HUALGAYOC":
                    return new string[]
                    {
                        "Bambamarca", "Chugur", "Hualgayoc"
                    };
                case "JAÉN":
                    return new string[]
                    {
                        "Jaén", "Bellavista", "Chontali", "Colasay", "Huabal", "Las Pirias", "Pomahuaca", "Pucará", "Sallique", "San Felipe", "San José del Alto", "Santa Rosa", "Santo Domingo de la Capilla", "Shumba", "Yambrasbamba"

                    };
                case "SAN IGNACIO":
                    return new string[]
                    {
                         "San Ignacio", "Chirinos", "Huarango", "La Coipa", "Namballe", "San José de Lourdes", "Tabaconas"
                    };
                case "SAN MARCOS":
                    return new string[]
                    {
"San Marcos", "Chancay", "Eduardo Villanueva", "Gregorio Pita", "Ichocán", "José Manuel Quiroz", "José Sabogal", "Pedro Gálvez"                    };
                case "SAN MIGUEL":
                    return new string[]
                    {
                        "Bolívar", "Calquis", "Catilluc", "El Prado", "La Florida", "Llapa", "Nanchoc", "Niepos", "San Gregorio", "San Miguel"
                    };
                case "SAN PABLO":
                    return new string[]
                    {
                         "San Pablo", "San Bernardino", "San Luis", "Tumbaden"
                    };
                case "SANTA CRUZ":
                    return new string[]
                    {
                        "Santa Cruz", "Andabamba", "Catache", "Chancaybaños", "La Esperanza", "Ninabamba", "Pulan", "Saucepampa", "Sexi", "Uticyacu", "Yauyucán"

                    };

                // Callao
                case "CALLAO":
                    return new string[]
                    {
                        "Bellavista", "Carmen de la Legua Reynoso", "La Perla", "La Punta", "Ventanilla"
                    };

                // Cusco
                case "CUSCO":
                    return new string[]
                    {
"Cusco", "Ccorca", "Poroy", "San Jerónimo", "San Sebastián", "Santiago", "Saylla", "Wanchaq"                    };
                case "ACOMAYO":
                    return new string[]
                    {
                        "Acomayo", "Acopia", "Acos", "Mosoc Llacta", "Pomacanchi", "Rondocan", "Sangarará"
                    };
                case "ANTA":
                    return new string[]
                    {
                        "Anta", "Ancahuasi", "Cachimayo", "Chinchaypujio", "Huarocondo", "Limatambo", "Mollepata", "Pucyura", "Zurite"
                    };
                case "CALCA":
                    return new string[]
                    {
                        "Calca", "Coya", "Lamay", "Lares", "Pisac", "San Salvador", "Taray", "Yanatile"
                    };
                case "CANAS":
                    return new string[]
                    {
                        "Yanaoca", "Checca", "Kunturkanki", "Langui", "Layo", "Pampamarca", "Quehue", "Túpac Amaru"
                    };
                case "CANCHIS":
                    return new string[]
                    {
                        "Sicuani", "Checacupe", "Combapata", "Marangani", "Pitumarca", "San Pablo", "San Pedro", "Tinta"
                    };
                case "CHUMBIVILCAS":
                    return new string[]
                    {
                        "Santo Tomás", "Capacmarca", "Chamaca", "Colquemarca", "Livitaca", "Llusco", "Quiñota", "Velille"
                    };
                case "ESPINAR":
                    return new string[]
                    {
                        "Yauri", "Condoroma", "Coporaque", "Ocoruro", "Pallpata", "Pichigua", "Suykutambo"
                    };
                case "LA CONVENCIÓN":
                    return new string[]
                    {
                        "Quillabamba", "Echarate", "Huayopata", "Maranura", "Ocobamba", "Santa Ana", "Santa Teresa", "Vilcabamba"
                    };
                case "PARURO":
                    return new string[]
                    {
                        "Paruro", "Accha", "Ccapi", "Colcha", "Huanoquite", "Omacha", "Paccaritambo", "Pillpinto", "Yaurisque"
                    };
                case "PAUCARTAMBO":
                    return new string[]
                    {
                        "Paucartambo", "Caicay", "Challabamba", "Colquepata", "Huancarani", "Kosñipata"
                    };
                case "QUISPICANCHI":
                    return new string[]
                    {
                        "Urcos", "Andahuaylillas", "Camanti", "Ccarhuayo", "Ccatca", "Cusipata", "Huaro", "Lucre", "Marcapata", "Ocongate", "Oropesa", "Quiquijana"
                    };
                case "URUBAMBA":
                    return new string[]
                    {
                        "Urubamba", "Chinchero", "Huayllabamba", "Machupicchu", "Maras", "Ollantaytambo", "Yucay"
                    };

                // Huancavelica
                case "HUANCAVELICA":
                    return new string[]
                    {
                        "Huancavelica", "Acobambilla", "Acoria", "Conayca", "Cuenca", "Huachocolpa", "Huayllahuara", "Izcuchaca", "Laria", "Manta", "Mariscal Cáceres", "Moya", "Nuevo Occoro", "Palca", "Pilchaca", "Vilca", "Yauli"

                    };
                case "ACOBAMBA":
                    return new string[]
                    {
                        "Acobamba", "Andabamba", "Anta", "Caja", "Marcas", "Paucara", "Pomacocha", "Rosario"
                    };
                case "ANGARAES":
                    return new string[]
                    {
                        "Lircay", "Anchonga", "Callanmarca", "Ccochaccasa", "Chincho", "Congalla", "Huanca Huanca", "Huayllay Grande", "Julcamarca", "San Antonio de Antaparco", "Santo Tomas de Pata"
                    };
                case "CASTROVIRREYNA":
                    return new string[]
                    {
                        "Castrovirreyna", "Arma", "Aurahua", "Capillas", "Chupamarca", "Cocas", "Huachos", "Huamatambo", "Mollepampa", "San Juan", "Santa Ana", "Tantara", "Ticrapo"
                    };
                case "CHURCAMPA":
                    return new string[]
                    {
                        "Churcampa", "Anco", "Chinchihuasi", "El Carmen", "La Merced", "Locroja", "Paucarbamba", "San Miguel de Mayocc", "San Pedro de Coris"
                    };
                case "HUAYTARA":
                    return new string[]
                    {
                        "Huaytará", "Ayavi", "Córdova", "Huayacundo Arma", "Laramarca", "Ocoyo", "Pilpichaca", "Querco", "Quito-Arma", "San Antonio de Cusicancha", "San Francisco de Sangayaico", "San Isidro", "Santiago de Chocorvos", "Santiago de Quirahuara", "Santo Domingo de Capillas", "Tambo"
                    };

                // Huánuco
                case "HUÁNUCO":
                    return new string[]
                    {
"Huánuco", "Amarilis", "Chinchao", "Churubamba", "Margos", "Quisqui", "San Francisco de Cayrán", "San Pedro de Chaulán", "Santa María del Valle", "Yarumayo"                    };
                case "AMBO":
                    return new string[]
                    {
"Ambo", "Cayna", "Colpas", "Conchamarca", "Huacar", "San Francisco", "San Rafael", "Tomay Kichwa"                    };
                case "DOS DE MAYO":
                    return new string[]
                    {
                         "La Unión", "Chuquis", "Marías", "Pachas", "Quivilla", "Ripán", "Shunqui", "Sillapata", "Yanas"
                    };
                case "HUACAYBAMBA":
                    return new string[]
                    {
                        "Huacaybamba", "Canchabamba", "Cochabamba", "Pinra"
                    };
                case "HUAMALIES":
                    return new string[]
                    {
                        "Llata", "Arancay", "Chavín de Pariarca", "Jacas Grande", "Jircán", "Miraflores", "Monzón", "Punchao", "Puños", "Singa", "Tantamayo"
                    };
                case "LEONCIO PRADO":
                    return new string[]
                    {
                         "Tingo María", "Rupa-Rupa", "Daniel Alomía Robles", "Hermílio Valdizán", "José Crespo y Castillo", "Luyando", "Mariano Dámaso Beraún", "Pucayacu", "Yuyapichis"
                    };
                case "MARAÑÓN":
                    return new string[]
                    {
                        "Huacrachuco", "Cholon", "San Buenaventura", "La Morada", "Santa Rosa de Alto Yanajanca", "Panao", "Chaglla", "Molino", "Umari"
                    };
                case "PACHITEA":
                    return new string[]
                    {
                        "Panao", "Chaglla", "Molino", "Umari"
                    };
                case "PUERTO INCA":
                    return new string[]
                    {
                        "Puerto Inca", "Codo del Pozuzo", "Honoria", "Tournavista", "Yuyapichis"
                    };
                case "LAURICOCHA":
                    return new string[]
                    {
                        "Jesús", "Baños", "Jivia", "Queropalca", "Rondos", "San Francisco de Asís", "San Miguel de Cauri", "Hermilio Valdizán"
                    };
                case "YAROWILCA":
                    return new string[]
                    {
                        "Chavinillo", "Cahuac", "Chacabamba", "Chupán", "Jacas Chico", "Obas", "Pampamarca", "Choras"
                    };

                // Ica
                case "ICA":
                    return new string[]
                    {
                        "Ica", "La Tinguiña", "Los Aquijes", "Ocucaje", "Pachacutec", "Parcona", "Pueblo Nuevo", "Salas", "San José de Los Molinos", "San Juan Bautista", "Santiago", "Subtanjalla", "Tate", "Yauca del Rosario"
                    };
                case "CHINCHA":
                    return new string[]
                    {
                         "Chincha Alta", "Alto Larán", "Chavín", "Chincha Baja", "El Carmen", "Grocio Prado", "Pueblo Nuevo", "San Juan de Yanac", "San Pedro de Huacarpana", "Sunampe", "Tambo de Mora"
                    };
                case "NASCA":
                    return new string[]
                    {
                        "Nasca", "Changuillo", "El Ingenio", "Marcona", "Vista Alegre"
                    };
                case "PALPA":
                    return new string[]
                    {
                       "Palpa", "Llipata", "Río Grande", "Santa Cruz", "Tibillo"
                    };
                case "PISCO":
                    return new string[]
                    {
                        "Pisco", "Huancano", "Humay", "Independencia", "Paracas", "San Andrés", "San Clemente", "Túpac Amaru Inca"
                    };

                // Junín
                case "JUNÍN":
                    return new string[]
                    {
                        "Junín", "Carhuamayo", "Ondores", "Ulcumayo"
                    };
                case "HUANCAYO":
                    return new string[]
                    {
                        "Huancayo", "Carhuacallanga", "Chacapampa", "Chicche", "Chilca", "Chongos Alto", "Chupuro", "Colca", "Cullhuas", "El Tambo", "Huacrapuquio", "Hualhuas", "Huancán", "Huasicancha", "Huayucachi", "Ingenio", "Pariahuanca", "Pilcomayo", "Pucará", "Quichuay", "Quilcas", "San Agustín de Cajas", "San Jerónimo de Tunán", "Saño", "Sapallanga", "Sicaya", "Santo Domingo de Acobamba", "Viques"
                    };
                case "CONCEPCIÓN":
                    return new string[]
                    {
                        "Concepción", "Aco", "Andamarca", "Chambara", "Cochas", "Comas", "Heroinas Toledo", "Manzanares", "Mariscal Castilla", "Matahuasi", "Mito", "Nueve de Julio", "Orcotuna", "San José de Quero", "Santa Rosa de Ocopa"
                    };
                case "CHANCHAMAYO":
                    return new string[]
                    {
                        "Chanchamayo", "Perene", "Pichanaqui", "San Luis de Shuaro", "San Ramón", "Vitoc"
                    };
                case "JAUJA":
                    return new string[]
                    {
                        "Jauja", "Acolla", "Apata", "Ataura", "Canchayllo", "Curicaca", "El Mantaro", "Huamali", "Huaripampa", "Huertas", "Janjaillo", "Julcán", "Leonor Ordóñez", "Llocllapampa", "Marco", "Masma", "Masma Chicche", "Molinos", "Monobamba", "Muqui", "Muquiyauyo", "Paca", "Paccha", "Pancán", "Parco", "Pomacancha", "Ricrán", "San Lorenzo", "San Pedro de Chunan", "Sausa", "Sincos", "Tunanmarca", "Yauli", "Yauyos"
                    };
                case "SATIPO":
                    return new string[]
                    {
                        "Satipo", "Coviriali", "Llaylla", "Mazamari", "Pampa Hermosa", "Pangoa", "Río Negro", "Río Tambo"
                    };
                case "TARMA":
                    return new string[]
                    {
                        "Tarma", "Acobamba", "Huaricolca", "Huasahuasi", "La Unión", "Palca", "Palcamayo", "San Pedro de Cajas", "Tapo"
                    };
                case "YAULI":
                    return new string[]
                    {
                       "La Oroya", "Chacapalpa", "Huay-Huay", "Marcapomacocha", "Morococha", "Paccha", "Santa Bárbara de Carhuacayan", "Santa Rosa de Sacco", "Suitucancha", "Yauli"

                    };
                case "CHUPACA":
                    return new string[]
                    {
                       "Chupaca", "Ahuac", "Chongos Bajo", "Huachac", "Huamancaca Chico", "San Juan de Iscos", "San Juan de Jarpa", "Tres de Diciembre", "Yanacancha"
                    };

                // La Libertad
                case "TRUJILLO":
                    return new string[]
                    {
                        "Trujillo", "El Porvenir", "Florencia de Mora", "Huanchaco", "La Esperanza", "Laredo", "Moche", "Poroto", "Salaverry", "Simbal", "Víctor Larco Herrera"
                    };
                case "ASCOPE":
                    return new string[]
                    {
                         "Ascope", "Casa Grande", "Chicama", "Chocope", "Magdalena de Cao", "Paiján", "Razuri", "Santiago de Cao"
                    };
                case "BOLIVAR":
                    return new string[]
                    {
                         "Bolívar", "Bambamarca", "Condormarca", "Longotea", "Uchumarca", "Ucuncha"
                    };
                case "CHEPEN":
                    return new string[]
                    {
                        "Chepén", "Pacanga", "Pueblo Nuevo"
                    };
                case "JULCAN":
                    return new string[]
                    {
                        "Julcán", "Calamarca", "Carabamba", "Huaso"
                    };
                case "OTUZCO":
                    return new string[]
                    {
                        "Otuzco", "Agallpampa", "Charat", "Huaranchal", "La Cuesta", "Mache", "Paranday", "Salpo", "Sinsicap", "Usquil"
                    };
                case "PACASMAYO":
                    return new string[]
                    {
                        "San Pedro de Lloc", "Guadalupe", "Jequetepeque", "Pacasmayo", "San José"
                    };
                case "PATAZ":
                    return new string[]
                    {
                        "Tayabamba", "Buldibuyo", "Chillia", "Huancaspata", "Huayo", "Ongón", "Parcoy", "Pataz", "Pias", "Santiago de Challas", "Taurija", "Urpay"
                    };
                case "SANCHEZ CARRION":
                    return new string[]
                    {
                        "Huamachuco", "Cochorco", "Curgos", "Chugay", "Marcabal", "Sanagorán", "Sarin", "Sartimbamba"
                    };
                case "SANTIAGO DE CHUCO":
                    return new string[]
                    {
                         "Santiago de Chuco", "Angasmarca", "Cachicadán", "Mollebamba", "Mollepata", "Quiruvilca", "Santa Cruz de Chuca", "Sitabamba"
                    };
                case "GRAN CHIMU":
                    return new string[]
                    {
                        "Cascas", "Lucma", "Marmot", "Sayapullo"
                    };
                case "VIRÚ":
                    return new string[]
                    {
                        "Virú", "Chao", "Guadalupito"
                    };
                // Lambayeque
                case "LAMBAYEQUE":
                    return new string[]
                    {
                        "Lambayeque", "Chochope", "Illimo", "Jayanca", "Mochumí", "Morrope", "Motupe", "Olmos", "Pacora", "Salas", "San José", "Túcume"
                    };
                case "CHICLAYO":
                    return new string[]
                    {
                        "Chiclayo", "Chongoyape", "Eten", "Eten Puerto", "José Leonardo Ortiz", "La Victoria", "Lagunas", "Monsefú", "Nueva Arica", "Oyotún", "Patapo", "Picsi", "Pimentel", "Pomalca", "Pucalá", "Reque", "Santa Rosa", "Tumán"
                    };
                case "FERREÑAFE":
                    return new string[]
                    {
                         "Ferreñafe", "Cañaris", "Incahuasi", "Manuel Antonio Mesones Muro", "Pitipo", "Pueblo Nuevo"
                    };

                // Lima
                case "LIMA":
                    return new string[]
                    {
                        "Ancón", "Ate", "Barranco", "Breña", "Carabayllo", "Chaclacayo", "Chorrillos", "Cieneguilla", "Comas", "El Agustino", "Independencia", "Jesús María", "La Molina", "La Victoria", "Lince", "Los Olivos", "Lurigancho", "Lurín", "Magdalena del Mar", "Miraflores", "Pachacámac", "Pucusana", "Pueblo Libre", "Puente Piedra", "Punta Hermosa", "Punta Negra", "Rímac", "San Bartolo", "San Borja", "San Isidro", "San Juan de Lurigancho", "San Juan de Miraflores", "San Luis", "San Martín de Porres", "San Miguel", "Santa Anita", "Santa María del Mar", "Santa Rosa", "Santiago de Surco", "Surquillo", "Villa El Salvador", "Villa María del Triunfo"
                    };
                case "BARRANCA":
                    return new string[]
                    {
                        "Barranca", "Paramonga", "Pativilca", "Supe", "Supe Puerto"
                    };
                case "CAJATAMBO":
                    return new string[]
                    {
                         "Cajatambo", "Copa", "Gorgor", "Huancapón", "Manás"
                    };
                case "CANTA":
                    return new string[]
                    {
                        "Canta", "Arahuay", "Huamantanga", "Huaros", "Lachaqui", "San Buenaventura", "Santa Rosa de Quives"
                    };
                case "CAÑETE":
                    return new string[]
                    {
                         "San Vicente de Cañete", "Asia", "Calango", "Cerro Azul", "Chilca", "Coayllo", "Imperial", "Lunahuaná", "Mala", "Nuevo Imperial", "Pacarán", "Quilmaná", "San Antonio", "San Luis", "Santa Cruz de Flores", "Zúñiga"
                    };
                case "HUARAL":
                    return new string[]
                    {
                        "Huaral", "Atavillos Alto", "Atavillos Bajo", "Aucallama", "Chancay", "Ihuarí", "Lampian", "Pacaraos", "San Miguel de Acos", "Santa Cruz de Andamarca", "Sumbilca", "Veintisiete de Noviembre"
                    };
                case "HUAROCHIRÍ":
                    return new string[]
                    {
                        "Matucana", "Antioquía", "Callahuanca", "Carampoma", "Chicla", "Cuenca", "Huachupampa", "Huanza", "Huarochirí", "Lahuaytambo", "Langa", "Laraos", "Mariatana", "Ricardo Palma", "San Andrés de Tupicocha", "San Antonio", "San Bartolomé", "San Damian", "San Juan de Iris", "San Juan de Tantaranche", "San Lorenzo de Quinti", "San Mateo", "San Mateo de Otao", "San Pedro de Casta", "San Pedro de Huancayre", "Sangallaya", "Santa Cruz de Cocachacra", "Santa Eulalia", "Santiago de Anchucaya", "Santiago de Tuna", "Santo Domingo de los Olleros", "Surco"
                    };
                case "HUAURA":
                    return new string[]
                    {
                       "Huacho", "Ámbar", "Caleta de Carquín", "Checras", "Hualmay", "Huaura", "Leoncio Prado", "Paccho", "Santa Leonor", "Santa María", "Sayán", "Vegueta"
                    };
                case "OYÓN":
                    return new string[]
                    {
                        "Oyón", "Andajes", "Caujul", "Cochamarca", "Naván", "Pachangara"
                    };
                case "YAUYOS":
                    return new string[]
                    {
                        "Yauyos", "Alis", "Ayauca", "Ayaviri", "Azángaro", "Cacra", "Carania", "Catahuasi", "Chocos", "Cochas", "Colonia", "Hongos", "Huampara", "Huancaya", "Huangáscar", "Huantán", "Huañec", "Laraos", "Lincha", "Madean", "Miraflores", "Omas", "Putinza", "Quinches", "Quinocay", "San Joaquín", "San Pedro de Pilas", "Tanta", "Tauripampa", "Tomas", "Tupe", "Viñac", "Vitis"
                    };

                // Loreto
                case "LORETO":
                    return new string[]
                    {
                        "Nauta", "Parinari", "Tigre", "Trompeteros", "Urarinas"
                    };
                case "MAYNAS":
                    return new string[]
                    {
                        "Iquitos", "Alto Nanay", "Fernando Lores", "Indiana", "Las Amazonas", "Mazan", "Napo", "Punchana", "Putumayo", "Torres Causana", "Belén", "San Juan Bautista"


                    };
                case "ALTO AMAZONAS":
                    return new string[]
                    {
                         "Yurimaguas", "Balsapuerto", "Jeberos", "Lagunas", "Santa Cruz", "Teniente César López Rojas"
                    };

                case "MARISCAL RAMÓN CASTILLA":
                    return new string[]
                    {
                        "Ramón Castilla", "Pebas", "Yavari", "San Pablo"
                    };
                case "REQUENA":
                    return new string[]
                    {
                        "Requena", "Alto Tapiche", "Capelo", "Emilio San Martín", "Maquia", "Puinahua", "Saquena", "Soplin", "Tapiche", "Jenaro Herrera", "Yaquerana"
                    };
                case "UCAYALI":
                    return new string[]
                    {
                        "Contamana", "Inahuaya", "Padre Márquez", "Pampa Hermosa", "Sarayacu", "Vargas Guerra"


                    };
                case "DATEM DEL MARAÑÓN":
                    return new string[]
                    {
                       "Barranca", "Cahuapanas", "Manseriche", "Morona", "Pastaza", "Andoas"
                    };
                case "PUTU MAYO":
                    return new string[]
                    {
                        "Putumayo", "Rosa Panduro", "Teniente Manuel Clavero", "Yaguas"
                    };

                // Madre de Dios
                case "TAMBOPATA":
                    return new string[]
                    {
                        "Tambopata", "Inambari", "Las Piedras", "Laberinto"
                    };
                case "MANU":
                    return new string[]
                    {
                       "Manu", "Fitzcarrald", "Madre de Dios", "Huepetuhe"
                    };
                case "TAHUAMANU":
                    return new string[]
                    {
                        "Iñapari", "Iberia", "Tahuamanu"
                    };

                // Moquegua
                case "MOQUEGUA":
                    return new string[]
                    {
                        "Moquegua",
"Carumas",
"Cuchumbaya",
"Samegua",
"San Cristóbal",
"Torata"
                    };
                case "MARISCAL NIETO":
                    return new string[]
                    {
                       "Moquegua", "Carumas", "Cuchumbaya", "Samegua", "San Cristóbal", "Torata"
                    };
                case "GENERAL SÁNCHEZ CERRO":
                    return new string[]
                    {
                         "Omate", "Chojata", "Coalaque", "Ichuña", "La Capilla", "Lloque", "Matalaque", "Puquina", "Quinistaquillas", "Ubinas", "Yunga"
                    };
                case "ILO":
                    return new string[]
                    {
                        "Ilo", "El Algarrobal", "Pacocha"
                    };

                // Pasco
                case "PASCO":
                    return new string[]
                    {
                        "Chaupimarca", "Huachón", "Huariaca", "Huayllay", "Ninacaca", "Pallanchacra", "Paucartambo", "San Francisco de Asís de Yarusyacán", "Simón Bolívar", "Ticlacayán", "Tinyahuarco", "Vicco", "Yanacancha"
                    };
                case "DANIEL ALCIDES CARRIÓN":
                    return new string[]
                    {
                        "Yanahuanca", "Chacayán", "Goyllarisquizga", "Paucar", "San Pedro de Pillao", "Santa Ana de Tusi", "Tapuc"
                    };
                case "OXAPAMPA":
                    return new string[]
                    {
                        "Oxapampa", "Chontabamba", "Huancabamba", "Palcazu", "Pozuzo", "Puerto Bermúdez", "Villa Rica"
                    };
                // Piura
                case "PIURA":
                    return new string[]
                    {
                        "Piura", "Castilla", "Catacaos", "Cura Mori", "El Tallán", "La Arena", "La Unión", "Las Lomas", "Tambo Grande"
                    };
                case "AYABACA":
                    return new string[]
                    {
                       "Ayabaca", "Frias", "Jilili", "Lagunas", "Montero", "Pacaipampa", "Paimas", "Sapillica", "Sicchez", "Suyo"
                    };
                case "HUANCABAMBA":
                    return new string[]
                    {
                        "Huancabamba", "Canchaque", "El Carmen de la Frontera", "Huarmaca", "Lalaquiz", "San Miguel de El Faique", "Sondor", "Sondorillo"
                    };
                case "MORROPÓN":
                    return new string[]
                    {
                        "Chulucanas", "Buenos Aires", "Chalaco", "La Matanza", "Morropón", "Salitral", "San Juan de Bigote", "Santa Catalina de Mossa", "Santo Domingo", "Yamango"
                    };
                case "PAITA":
                    return new string[]
                    {
                        "Amotape", "Arenal", "Colán", "La Huaca", "Tamarindo", "Vichayal"
                    };
                case "SULLANA":
                    return new string[]
                    {
                         "Sullana", "Bellavista", "Ignacio Escudero", "Lancones", "Marcavelica", "Miguel Checa", "Querecotillo", "Salitral"
                    };
                case "TALARA":
                    return new string[]
                    {
                        "Talara", "El Alto", "La Brea", "Las Salinas"                    };
                case "SECHURA":
                    return new string[]
                    {
                        "Sechura", "Bellavista de la Unión", "Bernal", "Cristo Nos Valga", "Rinconada Llicuar", "Vice"
                    };

                // Puno
                case "PUNO":
                    return new string[]
                    {
                        "Puno", "Acora", "Amantani", "Atuncolla", "Capachica", "Chucuito", "Coata", "Huata", "Mañazo", "Paucarcolla", "Pichacani", "Plateria", "San Antonio", "Tiquillaca", "Vilque"
                    };
                case "AZÁNGARO":
                    return new string[]
                    {
                         "Azángaro", "Achaya", "Arapa", "Asillo", "Caminaca", "Chupa", "José Domingo Choquehuanca", "Muñani", "Potoni", "Saman", "San Anton", "San José", "San Juan de Salinas", "Santiago de Pupuja", "Tirapata"

                    };
                case "CARABAYA":
                    return new string[]
                    {
                        "Macusani", "Ajoyani", "Ayapata", "Coasa", "Corani", "Crucero", "Ituata", "Ollachea", "San Gaban", "Usicayos"
                    };
                case "CHUCUITO":
                    return new string[]
                    {
                        "Juli", "Desaguadero", "Huacullani", "Kelluyo", "Pisacoma", "Pomata", "Zepita"
                    };
                case "EL COLLAO":
                    return new string[]
                    {
                        "Ilave", "Capazo", "Pilcuyo", "Santa Rosa", "Conduriri"
                    };
                case "HUANCANÉ":
                    return new string[]
                    {
                        "Huancané", "Cojata", "Huatasani", "Inchupalla", "Pusi", "Rosaspata", "Taraco", "Vilque Chico"
                    };
                case "LAMPA":
                    return new string[]
                    {
                        "Lampa", "Cabanilla", "Calapuja", "Nicasio", "Ocuviri", "Palca", "Paratía", "Pucará", "Santa Lucia", "Vilavila"
                    };
                case "MELGAR":
                    return new string[]
                    {
                        "Ayaviri", "Antauta", "Cupi", "Llalli", "Macari", "Nuñoa", "Orurillo", "Santa Rosa", "Umachiri"
                    };
                case "MOHO":
                    return new string[]
                    {
                        "Moho", "Conima", "Huayrapata", "Tilali"
                    };
                case "SAN ANTONIO DE PUTINA":
                    return new string[]
                    {
                        "Putina", "Ananea", "Pedro Vilca Apaza", "Quilcapuncu", "Sina"
                    };
                case "SAN ROMÁN":
                    return new string[]
                    {
                        "Juliaca", "Cabana", "Cabanillas", "Caracoto"
                    };
                case "SANDIA":
                    return new string[]
                    {
                        "Sandia", "Cuyocuyo", "Limbani", "Patambuco", "Phara", "Quiaca", "San Juan del Oro", "Yanahuaya"
                    };
                case "YUNGUYO":
                    return new string[]
                    {
                        // Lista de distritos de Yunguyo
                    };

                // San Martín
                case "SAN MARTÍN":
                    return new string[]
                    {
                        "Tarapoto", "Alberto Leveau", "Cacatachi", "Chazuta", "Chipurana", "El Porvenir", "Huimbayoc", "Juan Guerra", "La Banda de Shilcayo", "Morales", "Papaplaya", "San Antonio", "Sauce", "Shapaja"
                    };
                case "MOYOBAMBA":
                    return new string[]
                    {
                        "Moyobamba", "Calzada", "Habana", "Jepelacio", "Soritor", "Yantaló" 
                    };
                case "BELLAVISTA":
                    return new string[]
                    {
                        "Bellavista", "Alto Biavo", "Bajo Biavo", "Huallaga", "San Pablo", "San Rafael"
                    };
                case "EL DORADO":
                    return new string[]
                    {
                        "San José de Sisa", "Agua Blanca", "San Martín", "Santa Rosa", "Shatoja"
                    };
                case "HUALLAGA":
                    return new string[]
                    {
                        "Alto Saposoa", "Saposoa", "Piscoyacu", "Eslabón", "Sacanche", "Tingo de Saposoa"
                    };
                case "LAMAS":
                    return new string[]
                    {
                        "Lamas", "Alonso de Alvarado", "Barranquita", "Caynarachi", "Cuñumbuqui", "Pinto Recodo", "Rumisapa", "San Roque de Cumbaza", "Shanao", "Tabalosos", "Zapatero"
                    };
                case "MARISCAL CÁCERES":
                    return new string[]
                    {
                        "Juanjuí", "Campanilla", "Huicungo", "Pachiza", "Pajarillo"
                    };
                case "PICOTA":
                    return new string[]
                    {
                        "Picota", "Buenos Aires", "Caspizapa", "Pilluana", "Pucacaca", "San Cristóbal", "San Hilarión", "Shamboyacu", "Tingo de Ponasa", "Tres Unidos"
                    };
                case "RIOJA":
                    return new string[]
                    {
                        "Rioja", "Awajún", "Elias Soplin", "Nueva Cajamarca", "Pardo Miguel", "Posic", "San Fernando", "Yorongos", "Yuracyacu"
                    };

                case "TOCACHE":
                    return new string[]
                    {
                        "Tocache", "Nuevo", "Progreso", "Pólvora", "Santa", "Lucía1​", "Shunté", "Uchiza"
                    };

                // Tacna
                case "TACNA":
                    return new string[]
                    {
                        "Tacna", "Alto de la Alianza", "Palca", "Calana", "Ciudad", "Nueva", "Coronel Gregorio Albarracín Lanchipa", "Inclán", "La Yarada-Los Palos", "Pachía", "Pocollay", "Sama"
                    };
                case "CANDARAVE":
                    return new string[]
                    {
                        "Candarave", "Cairani", "Camilaca", "Curibaya", "Huanuara", "Quilahuani"
                    };
                case "JORGE BASADRE":
                    return new string[]
                    {
                        "Ilabaya", "Ite", "Locumba"

                    };
                case "TARATA":
                    return new string[]
                    {
                        "Tarata", "Estique", "Estique Pampa", "Héroes", "Albarracín", "Sitajara", "Susapaya", "Tarucachi", "Ticaco"
                    };

                // Tumbes
                case "TUMBES":
                    return new string[]
                    {
                        "Tumbes", "Corrales", "La Cruz", "Pampas de Hospital", "San Jacinto", "San Juan de la Virgen"
                    };
                case "CONTRALMIRANTE VILLAR":
                    return new string[]
                    {
                        "Canoas de Punta Sal", "Casitas", "Zorritos"
                    };
                case "ZARUMILLA":
                    return new string[]
                    {
                        "Zarumilla", "Aguas Verdes", "Papayal", "Matapalo"
                    };

                // Ucayali
                case "CORONEL PORTILLO":
                    return new string[]
                    {
                        "Callaría", "Masisea", "Iparía", "Tahuanía", "Raimondi", "Yurúa", "Purús"
                    };
                case "ATALAYA":
                    return new string[]
                    {
                        "Raimonti", "Sepahua", "Tahuania", "Yuruá"
                    };
                case "PADRE ABAD":
                    return new string[]
                    {
                        "Padre Abad", "Huipoca2​", "Boquerón", "Irázola", "Curimaná", "Alexander", "von Humboldt", "Neshuya"
                    };
                case "PURÚS":
                    return new string[]
                    {
                        "cashinahuas", "sharanahuas", "culinas", "mastanahuas", "ashánincas", "amahuacas", "yines"
                    };

                default:
                    return null;
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
                return; // Sale del método si hay más de 8 caracteres
            }

            if (!txtDni.Text.All(char.IsDigit))
            {
                //MessageBox.Show("El DNI solo puede contener números.");
                txtDni.Clear();
                return; 
            }
            if (txtDni.Text.Length == 8)
            {
                //if (restriccionesDni())
                //{
                //    return;
                //}
                //BuscarEmpleado();
                //if (empleadorEncontrado.Count > 0)
                //{
                //    MessageBox.Show("Actualmente hay un empleador registrado con ese DNI");
                //    dgvEmpleadores.DataSource = empleadorEncontrado;
                //    LimpiarCampos();
                //}
            }
        }

        private void txtReferencia_TextChanged(object sender, EventArgs e)
        {
            txtReferencia.Text = txtReferencia.Text.ToUpper();

            txtReferencia.SelectionStart = txtReferencia.Text.Length;
            txtReferencia.SelectionLength = 0;

            if (string.IsNullOrWhiteSpace(txtReferencia.Text))
            {
                //MessageBox.Show("El motivo no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtReferencia.Text = string.Empty;
                return;
            }
        }

        private void checkBox1_MouseClick(object sender, MouseEventArgs e)
        {
            //if(checkBox1.Checked == true)
            //{
            //    FormMotivo motivo = new FormMotivo(this);
            //    motivo.FormClosed += new FormClosedEventHandler(Motivo_FormClosed);
            //    motivo.Show();
            //}

            if (checkBox1.Checked == true)
            {

                if (motivo == null || motivo.IsDisposed)
                {
                    motivo = new FormMotivo(this);
                    motivo.FormClosed += new FormClosedEventHandler(Motivo_FormClosed);
                }
                motivo.Show();
                motivo.BringToFront();
            }
            else
            {
                if (motivo != null)
                {
                    motivo.Hide();
                    motivo.limpiarMotivo();
                    ocultarEditar();

                }
            }

        }
        private void Motivo_FormClosed(object sender, FormClosedEventArgs e)
        {
            checkBox1.Checked = false;
        }


        private void cbDistrito_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnModificar_Click2(object sender, EventArgs e, bool limpiar)
        {
            try
            {
                entEmpleador empleador = new entEmpleador();
               
                empleador.nombre = txtNombres.Text.Trim();
                empleador.apellidoPaterno = txtApellidoP.Text.Trim();
                empleador.apellidoMaterno = txtApellidoM.Text.Trim();
                empleador.celular1 = txtCelular1.Text.Trim();
                empleador.celular2 = txtCelular2.Text.Trim();
                empleador.modo_contacto = cboModoContacto.Text.Trim();
                empleador.direccion = txtDireccion.Text.Trim();
                empleador.distrito = cbDistrito.Text.Trim();
                empleador.provincia = cbProvincia.Text.Trim();
                empleador.departamento = cbDepartamento.Text.Trim();               
                empleador.lista_excluidos = checkBox1.Checked;
                empleador.motivo_excluido = motivoEnc;
                if (checkBox1.Checked == true)
                {
                    empleador.motivo_excluido = motivoEnc;

                }
                if (checkBox1.Checked == false)
                {
                    empleador.motivo_excluido = "";
                }
                empleador.ref_domicilio = txtReferencia.Text.Trim();
                empleador.transporte_publico = txtTransPublico.Text.Trim();
                empleador.usuario_id = 1;
                empleador.dni = txtDni.Text.Trim();


                MessageBox.Show(motivoEnc);
                logEmpleador.Instancia.EditarEmpleador(empleador);
                MessageBox.Show("Cambios guardados exitosamente");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            if (limpiar)
            {
                LimpiarCampos();
                btnAgregar.Enabled = false;
                checkBox1.Checked = false;
                motivo.limpiarMotivo();
            }
            ListarEmpleador();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            //DialogResult result = MessageBox.Show("¿Está seguro que quiere guardar los cambios?", "Estoy seguro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //if (result == DialogResult.Yes)
            //{
            //    //Accion de guardado
            //    //btnModificar_Click2(sender, e, true);
            //    btnEliminar_Click2(null, EventArgs.Empty, false);
            //    btnAgregar_Click(null, EventArgs.Empty);
            //    MessageBox.Show("Se a modificado Exitosamente");
            //}
            //else
            //{
            //    MessageBox.Show("Se a cancelado los cambios");
            //}
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (restriccionesDni())
            {
                return;
            }
            BuscarEmpleado();
            if (empleadorEncontrado.Count > 0)
            {
                dgvEmpleadores.DataSource = empleadorEncontrado;
                btnAgregar.Enabled = false;
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("No se a encontrado ningún Empleador registrado con ese DNI");
            }
        }
        public void ActualizarMotivo(string motivo)
        {
            mensajeMotivo = motivo;

            //empleador.motivo_excluido = motivo;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            motivo.Show();


            //if (motivo == null || motivo.IsDisposed)
            //{
            //    motivo = new FormMotivo(this);
            //    motivo.FormClosed += new FormClosedEventHandler(Motivo_FormClosed);
            //}
            //motivo.CargarMotivo(empleador.motivo_excluido);
            //motivo.Show();
            //motivo.BringToFront();

        }                     

        public void mostrarEditar()
        {
            btnEditar.Visible = true;        
        }
        public void ocultarEditar()
        {
            btnEditar.Visible = false;
        }

        public void saveMotivo(string saveMotivo)
        {
            motivoEnc = saveMotivo;
        }

        private void dgvEmpleadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEmpleadores.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (dgvEmpleadores.Columns[e.ColumnIndex].Name == "columMotivo")
                {
                    string value = dgvEmpleadores.Rows[e.RowIndex].Cells["ColumDNI"].Value.ToString();
                    

                    entEmpleadorMotivo motivoEntidad = new entEmpleadorMotivo();
                    motivoEntidad = logEmpleador.Instancia.ListarEmpleadorMotivo(value);                  
                    
                    motivoEnc = motivoEntidad.motivo.ToString();
                    motivo.CargarMotivo(motivoEnc);

                    MessageBox.Show("" + motivoEnc);

                    //motivo.Show();
                    btnAgregar.Enabled = false;
                }
            }
        }


        private void dgvEmpleadores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que la fila y columna seleccionadas sean válidas
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow filaActual = dgvEmpleadores.Rows[e.RowIndex];

                txtDni.Text = filaActual.Cells["columDNI"].Value.ToString();
                txtNombres.Text = filaActual.Cells["columNombre"].Value.ToString();
                txtApellidoP.Text = filaActual.Cells["columApellidoPaterno"].Value.ToString();
                txtApellidoM.Text = filaActual.Cells["columApellidoMaterno"].Value.ToString();
                txtCelular1.Text = filaActual.Cells["columCelular1"].Value.ToString();
                txtCelular2.Text = filaActual.Cells["ColumnCelular2"].Value.ToString();
                cboModoContacto.SelectedItem = filaActual.Cells["ColumnModContacto"].Value.ToString();
                cbDepartamento.SelectedItem = filaActual.Cells["columDepartamento"].Value.ToString();
                cbProvincia.SelectedItem = filaActual.Cells["columProvincia"].Value.ToString();
                cbDistrito.SelectedItem = filaActual.Cells["columDistrito"].Value.ToString();
                txtDireccion.Text = filaActual.Cells["columDireccion"].Value.ToString();
                txtReferencia.Text = filaActual.Cells["columRefDocimilio"].Value.ToString();
                txtTransPublico.Text = filaActual.Cells["ColumnTransportePublico"].Value.ToString();


                entEmpleadorMotivo motivoCargado = logEmpleador.Instancia.ListarEmpleadorMotivo(txtDni.Text);

                if (motivoCargado != null)
                {
                    motivo.CargarMotivo(motivoCargado.motivo);
                    checkBox1.Checked = true;
                    mostrarEditar();
                    btnModificar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnAgregar.Enabled = false;
                }else { 
                    checkBox1.Checked= false;
                    ocultarEditar();
                }
            }
        }
    }




    /*
    public void ModificarEmpleador(entEmpleador empleador)
    {
        var existingEmpleador = empleadores.FirstOrDefault(e => e.dni == empleador.dni);
        if (existingEmpleador != null)
        {
            existingEmpleador.nombre = empleador.nombre;
            existingEmpleador.apellidoPaterno = empleador.apellidoPaterno;
            existingEmpleador.apellidoMaterno = empleador.apellidoMaterno;
            existingEmpleador.direccion = empleador.direccion;
            existingEmpleador.celular1 = empleador.celular1;
            existingEmpleador.celular2 = empleador.celular2;
            existingEmpleador.departamento = empleador.departamento;
            existingEmpleador.provincia = empleador.provincia;
            existingEmpleador.distrito = empleador.distrito;
        }
    }*/




}


