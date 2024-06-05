using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;
using CapaEntidad;
using System.Timers;
using System.Data.SqlClient;
using System.Net;
using System.Windows.Forms.DataVisualization.Charting;
namespace NANAS_AMAS
{
    public partial class FormCitas : Form
    {
        public FormCitas()
        {
            InitializeComponent();
            ListarCitas();
            dtpHora.Value=dtpHora.Value.Date;
            dtpHora.ShowUpDown=true;
            txtDni.MaxLength = 8;
            txtCelular.MaxLength = 9;
            txtCelular2.MaxLength = 9;

            InitializeComboBoxes();


        }
        public bool Restricciones()
        {
            bool band=false;
            if (txtDni.Text.Length != 8)
            {
                MessageBox.Show("INGRESAR DNI DE 8 DIGITOS", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                band = true;
            }
            else if (txtNombres.Text == "" || txtApellidoP.Text == "" || txtApellidoM.Text == "" || txtCelular.Text == "" || cbReferenciaLl.Text == "" || cbDistrito.Text == "" || cbProvincia.Text == "" || cbDepartamento.Text == "" || txtDireccion.Text == "" || txtDni.Text == "")
            {
                MessageBox.Show("LLENAR TODOS LOS CAMPOS", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                band = true;
            }
            else if (CalcularEdad(dtpFechaN.Value, DateTime.Today) < 18 || (CalcularEdad(dtpFechaN.Value, DateTime.Today) > 55))
            {
                MessageBox.Show("SOLO SE PERMITEN MAYORES DE 18 Y MENOR DE 55", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                band = true;
            }
            else if (21 < dtpHora.Value.Hour || dtpHora.Value.Hour < 7)
            {
                MessageBox.Show("INGRESAR HORAS ENTRE LAS 7:00 AM Y 20:00 PM");
                band = true;
            }


            return band;
        }
        private void InitializeComboBoxes()
        {
            // Inicializar ComboBox de Región
            cbDepartamento.Items.AddRange(new string[]
            {
                "AMAZONAS", "ÁNCASH", "APURÍMAC", "AREQUIPA", "AYACUCHO", "CAJAMARCA", "CALLAO", "CUSCO",
                "HUANCAVELICA", "HUÁNUCO", "ICA", "JUNÍN", "LA LIBERTAD", "LAMBAYEQUE", "LIMA", "LORETO",
                "MADRE DE DIOS", "MOQUEGUA", "PASCO", "PIURA", "PUNO", "SAN MARTÍN", "TACNA", "TUMBES", "UCAYALI"
            });
            cbReferenciaLl.Items.AddRange(new string[]
            {
               "INSTAGRAM", "FACEBOOK", "PERIODICO", "TIKTOK", "REFERENCIA DE UN AMIGO O FAMILIAR"
            });


        }
        private void cbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbProvincia.Items.Clear();
            string selectedDepartamento = cbDepartamento.SelectedItem.ToString();
            switch (selectedDepartamento)
            {
                case "LA LIBERTAD":
                    
                    cbProvincia.Items.AddRange(new string[]
                    {
                        "TRUJILLO", "ASCOPE", "BOLIVAR", "CHEPEN", "JULCAN", "OTUZCO", "PACASMAYO", "PATAZ",
                        "SANCHEZ CARRION", "SANTIAGO DE CHUCO", "GRAN CHIMU", "VIRÚ"
                    });
                    break;
                default:
                    cbProvincia.Text = "";
                    cbProvincia.Items.Clear();
                    break;
            }
         
        }

        private void cbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbDistrito.Items.Clear();
            string selectedProvince = cbProvincia.SelectedItem.ToString();
            switch (selectedProvince)
            {
                case "TRUJILLO":
                    cbDistrito.Text = "";
                    cbDistrito.Items.Clear();
                    cbDistrito.Items.AddRange(new string[]
                    {
                        "TRUJILLO", "EL PORVENIR", "LA ESPERANZA", "FLORENCIA DE MORA", "LAREDO",
                        "VICTOR LARCO", "ALTO TRUJILLO", "MOCHE", "HUANCHACO", "SALAVERRY", "SIMBAL", "POROTO"
                    });
                    break;
                case "ASCOPE":
                    cbDistrito.Text = "";
                    cbDistrito.Items.Clear();
                    cbDistrito.Items.AddRange(new string[]
                    {
                        "ASCOPE", "CHICAMA", "MAGDALENA DE CAO", "SANTIAGO DE CAO", "PAIJÁN", "RAZURI", "CASA GRANDE"
                    });
                    break;
                case "BOLIVAR":
                    cbDistrito.Text = "";
                    cbDistrito.Items.Clear();
                    cbDistrito.Items.AddRange(new string[]
                    {
                         "BOLÍVAR", "BAMBAMARCA", "CONDORMARCA", "LONGOTEA", "UCHUMARCA", "UCUNCHA"
                    });
                    break;
                case "CHEPEN":
                    cbDistrito.Text = "";
                    cbDistrito.Items.Clear();
                    cbDistrito.Items.AddRange(new string[]
                    {
                         "CHEPÉN", "PACANGA", "PUEBLO NUEVO"
                    });
                    break;
                case "JULCAN":
                    cbDistrito.Text = "";
                    cbDistrito.Items.Clear();
                    cbDistrito.Items.AddRange(new string[]
                    {
                         "JULCÁN", "CALAMARCA", "CARABAMBA", "HUASO"
                    });
                    break;
                case "OTUZCO":
                    cbDistrito.Text = "";
                    cbDistrito.Items.Clear();
                    cbDistrito.Items.AddRange(new string[]
                    {
                            "OTUZCO", "AGALLPAMPA", "CHARAT", "HUARANCHAL", "LA CUESTA", "MACHE", "PARANDAY",
                            "SALPO", "SINSICAP", "USQUIL"
                    });
                    break;
                case "PACASMAYO":
                    cbDistrito.Text = "";
                    cbDistrito.Items.Clear();
                    cbDistrito.Items.AddRange(new string[]
                    {
                        "SAN PEDRO DE LLOC", "GUADALUPE", "JEQUETEPEQUE", "PACASMAYO", "SAN JOSÉ"
                    });
                    break;
                case "PATAZ":
                    cbDistrito.Text = "";
                    cbDistrito.Items.Clear();
                    cbDistrito.Items.AddRange(new string[]
                    {
                        "TAYABAMBA", "BULDIBUYO", "CHILLIA", "HUANCASPATA", "HUAYLILLAS", "HUAYO", "ONGÓN",
                        "PARCOY", "PATAZ", "PIAS", "CHALLAS", "TAURIJA", "URPAY"
                    });
                    break;
                case "SANCHEZ CARRION":
                    cbDistrito.Text = "";
                    cbDistrito.Items.Clear();
                    cbDistrito.Items.AddRange(new string[]
                    {
                        "HUAMACHUCO", "CHUGAY", "COCHORCO", "CURGOS", "MARCABAL", "SANAGORÁN", "SARÍN", "SARTIMBAMBA"
                    });
                    break;
                case "SANTIAGO DE CHUCO":
                    cbDistrito.Text = "";
                    cbDistrito.Items.Clear();
                    cbDistrito.Items.AddRange(new string[]
                    {
                        "SANTIAGO DE CHUCO", "ANGASMARCA", "CACHICADÁN", "MOLLEBAMBA", "MOLLEPATA", "QUIRUVILCA",
                        "SANTA CRUZ DE CHUCA", "SITABAMBA"
                    });
                    break;
                case "GRAN CHIMU":
                    cbDistrito.Text = "";
                    cbDistrito.Items.Clear();
                    cbDistrito.Items.AddRange(new string[]
                    {
                         "CASCAS", "LUCMA", "MARMOT", "SAYAPULLO"
                    });
                    break;
                case "VIRÚ":
                    cbDistrito.Text = "";
                    cbDistrito.Items.Clear();
                    cbDistrito.Items.AddRange(new string[]
                    {
                        "VIRÚ", "CHAO", "GUADALUPITO"
                    });
                    break;
                default:
                    cbDistrito.Text = "";
                    cbDistrito.Items.Clear();
                    break;
            }
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool BuscarDni()
        {
            List<entCitas> citas = new List<entCitas>();
            citas = logCitas.Instancia.ListarCitas();

            for (int i = 0; i < citas.LongCount(); i++)
            {
                if (citas[i].dni == txtDni.Text)
                {


                    DialogResult result = MessageBox.Show("El DNI ya esta registrado! ¿Desea registar de todas maneras?", "Confirmación", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        return false;
                    }
                    else if (result == DialogResult.No)
                    {
                        return true;
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        return true;
                    }

                    
                }

            }
            return false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (BuscarDni())
            {
                Limpiarcasillas();
                return;
            }
            if (Restricciones())
            {
                return;
            }
            try
            {
                entCitas citas = new entCitas();
                citas.nombres = txtNombres.Text.Trim();
                citas.apellidoPaterno = txtApellidoP.Text.Trim();
                citas.apellidoMaterno = txtApellidoM.Text.Trim();
                citas.fechaNacimiento = Convert.ToDateTime(dtpFechaN.Text.Trim());
                if (txtCelular2.Text != "")
                {
                    citas.celular=(txtCelular.Text+ " - W: "+ txtCelular2.Text);
                }
                else {
                    citas.celular = txtCelular.Text.Trim();
                }
                citas.fechaEntrevista = Convert.ToDateTime(dtpFechaE.Text.Trim());
                citas.horaEntrevista = TimeSpan.Parse(dtpHora.Text.Trim());
                citas.edad = CalcularEdad(citas.fechaNacimiento, DateTime.Today); 
                citas.refLlegada = cbReferenciaLl.Text.Trim();
                citas.rangoEdad = ClasificarEdad(citas.edad);
                citas.mes = citas.fechaEntrevista.Month;
                citas.año = citas.fechaEntrevista.Year;
                citas.distrito = cbDistrito.Text.Trim();
                citas.provincia = cbProvincia.Text.Trim();
                citas.departamento = cbDepartamento.Text.Trim();
                citas.direccion = txtDireccion.Text.Trim();
                citas.refDomicilio = txtReferenciaD.Text.Trim();
                citas.UserId = 1;
                citas.dni = txtDni.Text.Trim();
                logCitas.Instancia.InsertaCitas(citas);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            Limpiarcasillas();
            ListarCitas();
        }
        public void ListarCitas()
        {
            dgvCitas.DataSource = logCitas.Instancia.ListarCitas();
        }
        public void Limpiarcasillas()
        {
            txtNombres.Text = "";
            txtApellidoP.Text = "";
            txtApellidoM.Text = "";
            dtpFechaN.Value = DateTime.Now;
            txtCelular.Text = "";
            dtpFechaE.Value = DateTime.Now;
            dtpHora.Value = dtpHora.Value.Date;
            cbReferenciaLl.Text = "" ;
            cbDistrito.Text = "";
            cbProvincia.Text = "";
            cbDepartamento.Text = "";
            txtDireccion.Text = "";
            txtReferenciaD.Text = "";
            txtDni.Text = "";
        }
        static int CalcularEdad(DateTime fechaDeNacimiento, DateTime fechaActual)
        {
          
            int edad = fechaActual.Year - fechaDeNacimiento.Year;

            
            if (fechaDeNacimiento.Month > fechaActual.Month || (fechaDeNacimiento.Month == fechaActual.Month && fechaDeNacimiento.Day > fechaActual.Day))
            {
                edad--;
            }

            return edad;
        }
        static string ClasificarEdad(int edad)
        {
            if (edad <= 25)
            {
                return "18/25";
            }
            else if (edad <= 35)
            {
                return "26/35";
            }
            else if (edad <= 45)
            {
                return "36/45";
            }
            else if (edad <= 55)
            {
                return "46/55";
            }
            else
            {
                return ">=56";
            }
        }

        private void dgvCitas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvCitas.Rows[e.RowIndex];
            lblcodigo.Text= filaActual.Cells[0].Value.ToString();
            txtDni.Text = filaActual.Cells[19].Value.ToString();
            txtNombres.Text = filaActual.Cells[1].Value.ToString();
            txtApellidoP.Text = filaActual.Cells[2].Value.ToString();
            txtApellidoM.Text = filaActual.Cells[3].Value.ToString();
            dtpFechaN.Value = DateTime.Parse(filaActual.Cells[4].Value.ToString());

           
            string[] partes = filaActual.Cells[5].Value.ToString().Split(new string[] { " - W: " }, StringSplitOptions.None);
         
            if (partes.Length >= 1)
            {
                txtCelular.Text = partes[0].Trim();            
                if (partes.Length >= 2)
                {
                     txtCelular2.Text = partes[1].Trim();
                }
            }
            dtpFechaE.Value = DateTime.Parse(filaActual.Cells[6].Value.ToString());
            dtpHora.Value = DateTime.Parse(filaActual.Cells[7].Value.ToString());
            cbReferenciaLl.Text = filaActual.Cells[9].Value.ToString();
            //MessageBox.Show("valor: " + filaActual.Cells[15].Value.ToString());
            cbDistrito.Text = filaActual.Cells[13].Value.ToString();
            cbProvincia.Text = filaActual.Cells[14].Value.ToString();
            cbDepartamento.Text = filaActual.Cells[15].Value.ToString();
            txtDireccion.Text = filaActual.Cells[16].Value.ToString();
            txtReferenciaD.Text = filaActual.Cells[17].Value.ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (Restricciones())
            {
                return;
            }
            try
            {
                entCitas citas = new entCitas();
                citas.codCitas = int.Parse(lblcodigo.Text.Trim());
                citas.nombres = txtNombres.Text.Trim();
                citas.apellidoPaterno = txtApellidoP.Text.Trim();
                citas.apellidoMaterno = txtApellidoM.Text.Trim();
                citas.fechaNacimiento = Convert.ToDateTime(dtpFechaN.Text.Trim());
                citas.celular = txtCelular.Text.Trim();
                citas.fechaEntrevista = Convert.ToDateTime(dtpFechaE.Text.Trim());
                citas.horaEntrevista = TimeSpan.Parse(dtpHora.Text.Trim());
                citas.edad = CalcularEdad(citas.fechaNacimiento, DateTime.Today);
                citas.refLlegada = cbReferenciaLl.Text.Trim();
                citas.rangoEdad = ClasificarEdad(citas.edad);
                citas.mes = citas.fechaEntrevista.Month;
                citas.año = citas.fechaEntrevista.Year;
                citas.distrito = cbDistrito.Text.Trim();
                citas.provincia = cbProvincia.Text.Trim();
                citas.departamento = cbDepartamento.Text.Trim();
                citas.direccion = txtDireccion.Text.Trim();
                citas.refDomicilio = txtReferenciaD.Text.Trim();
                citas.UserId = 1;
                citas.dni = txtDni.Text.Trim();

                logCitas.Instancia.EditarCita(citas);
                ListarCitas();
               
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            Limpiarcasillas();
            ListarCitas();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                entCitas citas = new entCitas();

                citas.codCitas = int.Parse(lblcodigo.Text.Trim());
                logCitas.Instancia.EliminarCita(citas);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            Limpiarcasillas();
            ListarCitas();
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && caracteresPermitidos.IndexOf(e.KeyChar) == -1)
            {
                
                e.Handled = true;
            }
            else
            {
                
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                
                e.Handled = true;
            }
        }
        public string caracteresPermitidos = "abcdefghijklmnñopqrstuvwxyzáéíóúABCDEFGHIJKLMNÑOPQRSTUVWXYZÁÉÍÓÚ ";

        private void txtApellidoP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && caracteresPermitidos.IndexOf(e.KeyChar) == -1)
            {
                
                e.Handled = true;
            }
            else
            {
                
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void txtApellidoM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && caracteresPermitidos.IndexOf(e.KeyChar) == -1)
            {
               
                e.Handled = true;
            }
            else
            {
                
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void txtReferenciaD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                
                e.Handled = true;
            }
        }
        private void txtCelular2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                
                e.Handled = true;
            }
        }

        private void cbReferenciaLl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbReferenciaLl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && caracteresPermitidos.IndexOf(e.KeyChar) == -1)
            {
                
                e.Handled = true;
            }
            else
            {
                
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void cbDepartamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && caracteresPermitidos.IndexOf(e.KeyChar) == -1)
            {
               
                e.Handled = true;
            }
            else
            {
               
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void cbProvincia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && caracteresPermitidos.IndexOf(e.KeyChar) == -1)
            {
                
                e.Handled = true;
            }
            else
            {
               
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void cbDistrito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && caracteresPermitidos.IndexOf(e.KeyChar) == -1)
            {
               
                e.Handled = true;
            }
            else
            {
                
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Limpiarcasillas();
        }
    }
}
