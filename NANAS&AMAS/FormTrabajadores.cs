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
using static TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath;
using Google.Protobuf.WellKnownTypes;

namespace NANAS_AMAS
{
    public partial class FormTrabajadores : Form
    {
        FormPuesto puestos = new FormPuesto();
        FormModalidad modalidad = new FormModalidad();
        public FormTrabajadores()
        {
            InitializeComponent();
            ListarTrabajadores();
            txtNombresApellidos.Enabled = false;
            dtpHoraI.Value=dtpHoraI.Value.Date;
            dtpHoraI.ShowUpDown=true;
            dtpHoraS.Value = dtpHoraS.Value.Date;
            dtpHoraS.ShowUpDown = true;
            txtDni.MaxLength = 8;
            InitializeComboBoxes();
            cbFolders.Enabled = false;
            
            txtCodTrabajador.MaxLength = 2;
            //cbCitas.SelectedIndex = -1;

        }
        public void BuscarDni()
        {
            bool band = false;
            List<entCitas> citas = new List<entCitas>();
            citas = logCitas.Instancia.ListarCitas();

            for (int i = 0; i < citas.LongCount(); i++)
            {
                if (citas[i].dni == txtDni.Text)
                {
                    txtNombresApellidos.Text = citas[i].nombres +" "+ citas[i].apellidoPaterno+" "+citas[i].apellidoMaterno;
                    band = true;
                    cbCitas.DataSource = logCitas.Instancia.BuscarCitaDni(citas[i].dni);
                    cbCitas.DisplayMember = "codFecha";
                    cbCitas.ValueMember = "codCitas";
                    lblDni.Text= txtDni.Text;
                    break;
                }
            
            }
            if (!band)
            {
                MessageBox.Show("EL DNI NO SE ENCUENTRA EN CITAS", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }
        public bool Restricciones()
        {
            DateTime limiteHoraInicio = DateTime.Today.AddHours(7); // 7 AM
            DateTime limiteHoraFin = DateTime.Today.AddHours(21);   // 9 PM
            bool band = false;
            TimeSpan diferencia = dtpHoraS.Value - dtpHoraI.Value;
            double horas = diferencia.TotalHours;
            //if (txtDni.Text.Length != 8)
            //{
            //    MessageBox.Show("INGRESAR DNI DE 8 DIGITOS", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    band = true;
            //}
            //else if (cbGradoI.Text == "" || cbEvaluacionP.Text == "" || cbUbicacionA.Text == "")
            //{
            //    MessageBox.Show("LLENAR TODOS LOS CAMPOS", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    band = true;
            //}
            //else if (cbEvaluacionP.Text=="NO APTO"|| cbEvaluacionP.Text == "APTO CONDICIONAL")
            //{
            //    if (txtMotivo.Text == "")
            //    {
            //        MessageBox.Show("LLENAR TODOS LOS CAMPOS", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        band = true;
            //    }
            //}

            if (horas<4)
            {
                MessageBox.Show("EL MINIMO DE HORAS ES DE 4 HORAS");
                band = true;
            }
            if ((dtpHoraI.Value.TimeOfDay < limiteHoraInicio.TimeOfDay)|| (dtpHoraS.Value.TimeOfDay > limiteHoraFin.TimeOfDay))
            {
                MessageBox.Show("INGRESAR HORAS ENTRE LAS 7:00 AM Y 20:00 PM");
                band = true;

            }
            return band;
        }
        private void InitializeComboBoxes()
        {
            cbGradoI.Items.AddRange(new string[]
            {
              "SECUNDARIA INCOMPLETA","SECUNDARIA COMPLETA","SUPERIOR TECNICO ESTUDIANTE", "SUPERIOR TECNICO TRUNCO", "SUPERIOR TECNICO COMPLETO", "UNIVERSITARIO ESTUDIANTE", "UNIVERSITARIO TRUNCO","UNIVERSITARIO COMPLETO"
            });
            cbEvaluacionP.Items.AddRange(new string[]
            {
              "APTO","APTO CONDICIONAL","NO APTO"
            });
            cbUbicacionA.Items.AddRange(new string[]
            {
              "FOLDERS","LABORANDO POR SU CUENTA","NO DISPONIBLE", "APTO CONDICIONAL", "NO APTO"
            });

            cbCitas.DataSource = logCitas.Instancia.ListarCitas();
            cbCitas.DisplayMember = "codFecha";
            cbCitas.ValueMember = "codCitas";

        }




        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Restricciones())
            {
                return;
            }

            try
            {

                foreach (var item in puestos.clbPuestos.CheckedItems)
                {
                    entTrabajadorInsertar worker = new entTrabajadorInsertar();
                    worker.dni = txtDni.Text.Trim();
                    worker.cTrabajador="NYA"+txtCodTrabajador.Text+txtDni.Text;
                    if (txtNivel.Text != "") 
                    {
                        worker.gradoInstruccion = cbGradoI.Text + " - " + txtNivel.Text;
                    }
                    else
                    {
                        worker.gradoInstruccion = cbGradoI.Text;
                    }
                    
                    worker.puesto = item.ToString();
                    worker.evaluacionPsicologica = cbEvaluacionP.Text;

                    if (cbFolders.Text != "")
                    {
                        worker.ubicacionArchivo = cbUbicacionA.Text + " - " + cbFolders.Text;
                    }
                    else
                    {
                        worker.ubicacionArchivo = cbUbicacionA.Text;
                    }

                    worker.horaInicio = TimeSpan.Parse(dtpHoraI.Text.Trim());
                    worker.horaCierre = TimeSpan.Parse(dtpHoraS.Text.Trim());
                    worker.salario = int.Parse(txtPrestacionesS.Text);
                    worker.fechaRegistro = DateTime.Parse(dtpFechaR.Text.Trim());
                    worker.mes = dtpFechaR.Value.Month;
                    worker.año = dtpFechaR.Value.Year;
                    worker.razon = txtMotivo.Text;
                    worker.userId = 1;
                    worker.codCitas = int.Parse(cbCitas.SelectedValue.ToString());
                    logTrabajador.Instancia.InsertaTrabajador(worker);
                }

                
                List<entTrabajadorDni> lista = logTrabajador.Instancia.BuscarTrabajadorDni(txtDni.Text);
                entTrabajadorModalidad worker2 = new entTrabajadorModalidad();
                for (int i = 0; i < lista.Count; i++)
                {
                    
                    
                    foreach (var item2 in modalidad.clbModalidad.CheckedItems)
                    {
                        
                        if (item2.ToString() == "CAMA AFUERA")
                        {
                            worker2.camaAfuera = true;
                        }
                        else if (item2.ToString() == "CAMA DENTRO")
                        {
                            worker2.camaDentro = true;
                        }
                        else if (item2.ToString() == "MEDIO TIEMPO MAÑANA")
                        {
                            worker2.medioTiempoM = true;
                        }
                        else if (item2.ToString() == "MEDIO TIEMPO TARDE")
                        {
                            worker2.medioTiempoT = true;
                        }
                        else if (item2.ToString() == "TURNO NOCHE")
                        {
                            
                            worker2.turnoNoche = true;
                        }
                        if (item2.ToString() == "POR DIAS")
                        {
                            string dias = "";
                            foreach (var item3 in modalidad.clbDias.CheckedItems)
                            {
                                dias= dias+","+ item3.ToString();

                            }
                            worker2.porDias = dias.Remove(0, 1); 

                        }

                    }
                    worker2.codTrabajador = lista[i].idTrabajador;
                    logTrabajador.Instancia.InsertaModalidad(worker2);
                }

             

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            // Bool modalidad
           

            Limpiarcasillas();
            ListarTrabajadores();
        }

        public void ListarTrabajadores()
        {
            dgvTrabajadores.DataSource = logTrabajador.Instancia.ListarTrabajadores();
            //dgvTrabajadores.DataSource = logTtrabajador.Instancia.BuscarTrabajadorPuesto("");
        }
        public void Limpiarcasillas()
        {
            txtCodTrabajador.Text = "";
            lblDni.Text = "";
            txtDni.Text = "";
            cbGradoI.Text = "";
            cbEvaluacionP.Text = "";
            cbUbicacionA.Text = "";
            dtpHoraI.Value = dtpHoraI.Value.Date;
            dtpHoraS.Value = dtpHoraS.Value.Date;
            dtpFechaR.Value = DateTime.Now; ;
            txtNombresApellidos.Text = "";
            txtNivel.Text = "";
            cbCitas.DataSource=logCitas.Instancia.ListarCitas();
            cbCitas.DisplayMember = "codFecha";
            cbCitas.ValueMember = "codCitas";
            txtMotivo.Text = "";
            cbFolders.Text = "";
            for (int i = 0; i < puestos.clbPuestos.Items.Count; i++)
            {
                puestos.clbPuestos.SetItemChecked(i, false);
            }
            for (int i = 0; i < modalidad.clbModalidad.Items.Count; i++)
            {
                puestos.clbPuestos.SetItemChecked(i, false);
            }
            for (int i = 0; i < modalidad.clbDias.Items.Count; i++)
            {
                puestos.clbPuestos.SetItemChecked(i, false);
            }

        }
       

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (Restricciones())
            {
                return;
            }
            try
            {
                btnEliminar_Click2(null, EventArgs.Empty,false);
                btnAgregar_Click(null, EventArgs.Empty);
             
               
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            Limpiarcasillas();
            ListarTrabajadores();

        }

        private void btnEliminar_Click2(object sender, EventArgs e, bool limpiar)
        {
            try
            {
                entTrabajador trabajador = new entTrabajador();
                trabajador.dni = txtDni.Text.Trim();
                logTrabajador.Instancia.EliminarTrabajador(trabajador);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            if (limpiar)
            {
                Limpiarcasillas();
            }
            ListarTrabajadores();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            btnEliminar_Click2(sender, e, true);
        }
        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si no es un número ni la tecla de retroceso, ignorar la pulsación de tecla
                e.Handled = true;
            }
        }
        string caracteresPermitidos = "abcdefghijklmnñopqrstuvwxyzáéíóúABCDEFGHIJKLMNÑOPQRSTUVWXYZÁÉÍÓÚ";

    

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            if (txtDni.Text.Length == 8)
            {
                BuscarDni();
            }
            if (txtDni.Text=="")
            {
                cbCitas.DataSource = logCitas.Instancia.ListarCitas();
                cbCitas.DisplayMember = "codFecha";
                cbCitas.ValueMember = "codCitas";
                txtNombresApellidos.Text = "";
            }
           
        }

        private void cbGradoI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && caracteresPermitidos.IndexOf(e.KeyChar) == -1)
            {
                // Cancelar el evento para evitar que se ingrese el carácter especial
                e.Handled = true;
            }
            else
            {
                // Convertir el carácter a mayúsculas
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void cbEvaluacionP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && caracteresPermitidos.IndexOf(e.KeyChar) == -1)
            {
                // Cancelar el evento para evitar que se ingrese el carácter especial
                e.Handled = true;
            }
            else
            {
                // Convertir el carácter a mayúsculas
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void cbUbicacionA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && caracteresPermitidos.IndexOf(e.KeyChar) == -1)
            {
                // Cancelar el evento para evitar que se ingrese el carácter especial
                e.Handled = true;
            }
            else
            {
                // Convertir el carácter a mayúsculas
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void btnPuesto_Click(object sender, EventArgs e)
        {
            
            puestos.Show();
        }


        private void cbUbicacionA_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedUbication = cbUbicacionA.SelectedItem.ToString();
            switch (selectedUbication)
            {
                case"FOLDERS":
                    cbFolders.Enabled = true;
                    cbFolders.Items.AddRange(new string[]
                     {
                            "NANAS/NIÑERAS(ROSADO BEBE)",
                            "NANAS/APOYO(FUCSIA)",
                            "ASESORA DE HOGAR(AMARILLO)",
                            "ENFERMERAS/CUIDADORAS",
                            "CAMA DENTRO",
                            "LIMPIEZA"
                     });
                    break;
                default :
                    cbFolders.Text = "";
                    cbFolders.Enabled = false;
                break;
            }

          
        }

        private void cbEvaluacionP_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedEvaluacionPsi = cbEvaluacionP.SelectedItem.ToString();
            switch (selectedEvaluacionPsi)
            {
                case "NO APTO":
                    cbFolders.Text = "";
                    dtpHoraI.Value = dtpHoraS.Value.Date;
                    dtpHoraS.Value = dtpHoraS.Value.Date;
                    cbGradoI.Text = "";
                    btnPuesto.Enabled = false;
                    cbGradoI.Enabled = false;
                    cbFolders.Enabled = false;
                    cbUbicacionA.Text="NO APTO";
                    cbUbicacionA.Enabled = false;
                    dtpHoraI.Enabled = false;
                    dtpHoraS.Enabled = false;
                    cbFolders.Items.AddRange(new string[]
                     {
                            "NANAS/NIÑERAS(ROSADO BEBE)",
                            "NANAS/APOYO(ROSADO)",
                            "ASESORA DE HOGAR(AMARILLO)",
                            "ENFERMERAS/CUIDADORAS",
                            "CAMA DENTRO",
                            "LIMPIEZA"
                     });
                    break;
                default:
                    //Limpiarcasillas();
                    cbGradoI.Enabled = true;
                    btnPuesto.Enabled = true;
                    cbUbicacionA.Enabled = true;
                    dtpHoraI.Enabled = true;
                    dtpHoraS.Enabled = true;
                    break;
            }
        }

        private void txtMotivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void dgvTrabajadores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            DataGridViewRow filaActual = dgvTrabajadores.Rows[e.RowIndex];

            //MessageBox.Show("" + filaActual.Cells[14].Value.ToString());
            //cbCitas.SelectedItem = int.Parse(filaActual.Cells[14].Value.ToString());
            txtCodTrabajador.Text = filaActual.Cells[3].Value.ToString().Substring(3, 2);
            txtDni.Text = filaActual.Cells[4].Value.ToString();
            //cbGradoI.Text = filaActual.Cells[5].Value.ToString();
            string texto2 = filaActual.Cells[5].Value.ToString();
            string[] partes2 = texto2.Split('-');
            if (partes2.Length >= 2)
            {
                cbGradoI.Text = partes2[0].Trim();
                txtNivel.Text = partes2[1].Trim();
            }
            else
            {
                cbGradoI.Text = filaActual.Cells[5].Value.ToString().Trim();
                txtNivel.Text = "";
            }

            cbEvaluacionP.Text = filaActual.Cells[6].Value.ToString();

            string texto = filaActual.Cells[7].Value.ToString();
            string[] partes = texto.Split('-');
            if (partes.Length >= 2)
            {
                cbUbicacionA.Text = partes[0].Trim();
                cbFolders.Text = partes[1].Trim();
                cbFolders.Enabled = Enabled;
            }
            else
            {
                cbUbicacionA.Text = filaActual.Cells[7].Value.ToString().Trim();
                cbFolders.Text = "";
                cbFolders.Enabled = false;
            }

            dtpHoraI.Value = DateTime.Parse(filaActual.Cells[8].Value.ToString());
            dtpHoraS.Value = DateTime.Parse(filaActual.Cells[9].Value.ToString());
            txtPrestacionesS.Text= filaActual.Cells[10].Value.ToString();

            dtpFechaR.Value = DateTime.Parse(filaActual.Cells[11].Value.ToString());
            txtMotivo.Text = filaActual.Cells[14].Value.ToString();



            for (int i = 0; i < puestos.clbPuestos.Items.Count; i++)
            {
                puestos.clbPuestos.SetItemChecked(i, false);
            }
            List<entTrabajadorPuesto> lista = logTrabajador.Instancia.BuscarTrabajadorPuesto(txtDni.Text);
            for (int i = 0; i < lista.Count; i++)
            {
                //MessageBox.Show("puesto " + i+1 + ": "+ lista[i].puesto);
                int index = puestos.clbPuestos.FindStringExact(lista[i].puesto);
                if (index != -1)

                {
                    //MessageBox.Show("index:  " + index);
                    puestos.clbPuestos.SetItemChecked(index, true);
                }

            }


            for (int i = 0; i < modalidad.clbModalidad.Items.Count; i++)
            {
                modalidad.clbModalidad.SetItemChecked(i, false);
            }
            for (int i = 0; i < modalidad.clbDias.Items.Count; i++)
            {
                modalidad.clbDias.SetItemChecked(i, false);
            }


            List<entTrabajadorDni> lista1 = logTrabajador.Instancia.BuscarTrabajadorDni(txtDni.Text);
            List<entTrabajadorModalidad> lista2 = logTrabajador.Instancia.BuscarTrabajadorModalidad(lista1[0].idTrabajador);

            int t = 0;
            if (lista2[t].camaAfuera)
            {
                int index = modalidad.clbModalidad.FindStringExact("CAMA AFUERA");
                if (index != -1)
                {
                    modalidad.clbModalidad.SetItemChecked(index, true);
                }
            }
            if (lista2[t].camaDentro)
            {
                int index = modalidad.clbModalidad.FindStringExact("CAMA DENTRO");
                if (index != -1)
                {
                    modalidad.clbModalidad.SetItemChecked(index, true);
                }
            }
            if (lista2[t].medioTiempoM)
            {
                int index = modalidad.clbModalidad.FindStringExact("MEDIO TIEMPO MAÑANA");
                if (index != -1)
                {
                    modalidad.clbModalidad.SetItemChecked(index, true);
                }
            }
            if (lista2[t].medioTiempoT)
            {
                int index = modalidad.clbModalidad.FindStringExact("MEDIO TIEMPO TARDE");
                if (index != -1)
                {
                    modalidad.clbModalidad.SetItemChecked(index, true);
                }
            }
            if (lista2[t].turnoNoche)
            {
                int index = modalidad.clbModalidad.FindStringExact("TURNO NOCHE");
                if (index != -1)
                {
                    modalidad.clbModalidad.SetItemChecked(index, true);
                }
            }
            if (lista2[t].porDias != "0")
            {
                int index = modalidad.clbModalidad.FindStringExact("POR DIAS");
                if (index != -1)
                {
                    modalidad.clbModalidad.SetItemChecked(index, true);

                    string[] puestosArray = lista2[t].porDias.ToString().Split(',');


                    for (int k = 0; k < puestosArray.Length; k++)
                    {
                        int index2 = modalidad.clbDias.FindStringExact(puestosArray[k].Trim());
                        if (index2 != -1)
                        {
                            modalidad.clbDias.SetItemChecked(index2, true);
                        }
                    }
                }
            }
        }

        private void dgvTrabajadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (dgvTrabajadores.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                
                if (dgvTrabajadores.Columns[e.ColumnIndex].Name == "ColumnPuesto")
                {
                    
                    string value = dgvTrabajadores.Rows[e.RowIndex].Cells["ColumDNI"].Value.ToString();
                    FormPuesto puestoPer = new FormPuesto();
                    
                    List<entTrabajadorPuesto> lista = logTrabajador.Instancia.BuscarTrabajadorPuesto(value);
                    for (int i = 0; i < lista.Count; i++)
                    {
                        int index = puestoPer.clbPuestos.FindStringExact(lista[i].puesto);
                        if (index != -1)
                        {
                            puestoPer.clbPuestos.SetItemChecked(index, true);
                        }

                    }
                    puestoPer.clbPuestos.Enabled = false;
                    puestoPer.Show();

                }
                else if (dgvTrabajadores.Columns[e.ColumnIndex].Name == "ColumnModalidad")
                {
                    
                    string value = dgvTrabajadores.Rows[e.RowIndex].Cells["ColumDNI"].Value.ToString();
                    FormModalidad modalidad = new FormModalidad();
                    List<entTrabajadorDni> lista1 = logTrabajador.Instancia.BuscarTrabajadorDni(value);
                    List<entTrabajadorModalidad> lista2 = logTrabajador.Instancia.BuscarTrabajadorModalidad(lista1[0].idTrabajador);
                    
                        int i = 0;
                        //MessageBox.Show("S:"+lista2[i].camaAfuera);
                        if (lista2[i].camaAfuera)
                        {
                            int index = modalidad.clbModalidad.FindStringExact("CAMA AFUERA");
                            if (index != -1)
                            {
                                modalidad.clbModalidad.SetItemChecked(index, true);
                            }
                        }
                        if (lista2[i].camaDentro)
                        {
                            int index = modalidad.clbModalidad.FindStringExact("CAMA DENTRO");
                            if (index != -1)
                            {
                                modalidad.clbModalidad.SetItemChecked(index, true);
                            }
                        }
                        if (lista2[i].medioTiempoM)
                        {
                            int index = modalidad.clbModalidad.FindStringExact("MEDIO TIEMPO MAÑANA");
                            if (index != -1)
                            {
                                modalidad.clbModalidad.SetItemChecked(index, true);
                            }
                        }
                        if (lista2[i].medioTiempoT)
                        {
                            int index = modalidad.clbModalidad.FindStringExact("MEDIO TIEMPO TARDE");
                            if (index != -1)
                            {
                                modalidad.clbModalidad.SetItemChecked(index, true);
                            }
                        }
                        if (lista2[i].turnoNoche)
                        {
                            int index = modalidad.clbModalidad.FindStringExact("TURNO NOCHE");
                            if (index != -1)
                            {
                                modalidad.clbModalidad.SetItemChecked(index, true);
                            }
                        }
                        if (lista2[i].porDias !="0")
                        {
                            int index = modalidad.clbModalidad.FindStringExact("POR DIAS");
                            if (index != -1)
                            {
                                modalidad.clbModalidad.SetItemChecked(index, true);

                                string[] puestosArray = lista2[i].porDias.ToString().Split(',');
                                

                                for (int t = 0; t < puestosArray.Length; t++)
                                {
                                    int index2 = modalidad.clbDias.FindStringExact(puestosArray[t].Trim());
                                    if (index2 != -1)
                                    {
                                         modalidad.clbDias.SetItemChecked(index2, true);
                                    }
                                }
                                
                            }
                            modalidad.clbDias.Visible = false;
                            modalidad.clbModalidad.Visible = true;
                            modalidad.verFom = true;
                            modalidad.btnDias.Visible = true;
                        }
                       
                        modalidad.clbDias.Enabled = false;
                        modalidad.clbModalidad.Enabled = false;
                        

                        modalidad.Show();


                }

            }
        }

        private void btnModalidad_Click(object sender, EventArgs e)
        {
            modalidad.clbDias.Visible = false;
            modalidad.clbModalidad.Visible = true;
            modalidad.Show();
        }

        private void cbCitas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cbCitas. != null)
            //{
            //    int selectedCitas = int.Parse(cbCitas.SelectedValue.ToString());
            //    MessageBox.Show("p: " + cbCitas.SelectedValue.ToString());
            //}


            //string selectedEvaluacionPsi = cbCitas.SelectedItem.ToString();
            //switch (selectedEvaluacionPsi)
            //{
              
            //    default:
            //        int selectedCitas = int.Parse(cbCitas.SelectedValue.ToString());

            //        break;
            //}

        }

        private void txtNivel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {

                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }
    }
}
