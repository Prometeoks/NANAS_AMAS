namespace NANAS_AMAS
{
    partial class FormTrabajadores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblCitas = new System.Windows.Forms.Label();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.txtPrestacionesS = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCodTrabajador = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnModalidad = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cbCitas = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbFolders = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpHoraS = new System.Windows.Forms.DateTimePicker();
            this.cbUbicacionA = new System.Windows.Forms.ComboBox();
            this.cbEvaluacionP = new System.Windows.Forms.ComboBox();
            this.btnPuesto = new System.Windows.Forms.Button();
            this.cbGradoI = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.dtpHoraI = new System.Windows.Forms.DateTimePicker();
            this.txtMotivo = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtpFechaR = new System.Windows.Forms.DateTimePicker();
            this.txtNombresApellidos = new Guna.UI2.WinForms.Guna2TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Motivo = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NIVEL = new System.Windows.Forms.Label();
            this.txtDni = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dgvTrabajadores = new System.Windows.Forms.DataGridView();
            this.ColumnCTrabajador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumDNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCodCitas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModalidad = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnPuesto = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnGradoI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEvaluacionPsi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUbicacionArchivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHoraCierre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSalario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRaazon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUsuarioId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNivel = new Guna.UI2.WinForms.Guna2TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.gbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrabajadores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCitas
            // 
            this.lblCitas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCitas.AutoSize = true;
            this.lblCitas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCitas.Location = new System.Drawing.Point(756, 30);
            this.lblCitas.Name = "lblCitas";
            this.lblCitas.Size = new System.Drawing.Size(191, 28);
            this.lblCitas.TabIndex = 0;
            this.lblCitas.Text = "TRABAJADORES";
            // 
            // gbDatos
            // 
            this.gbDatos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbDatos.Controls.Add(this.txtNivel);
            this.gbDatos.Controls.Add(this.label15);
            this.gbDatos.Controls.Add(this.txtPrestacionesS);
            this.gbDatos.Controls.Add(this.lblDni);
            this.gbDatos.Controls.Add(this.label13);
            this.gbDatos.Controls.Add(this.label12);
            this.gbDatos.Controls.Add(this.txtCodTrabajador);
            this.gbDatos.Controls.Add(this.btnModalidad);
            this.gbDatos.Controls.Add(this.label11);
            this.gbDatos.Controls.Add(this.cbCitas);
            this.gbDatos.Controls.Add(this.label10);
            this.gbDatos.Controls.Add(this.cbFolders);
            this.gbDatos.Controls.Add(this.label3);
            this.gbDatos.Controls.Add(this.dtpHoraS);
            this.gbDatos.Controls.Add(this.cbUbicacionA);
            this.gbDatos.Controls.Add(this.cbEvaluacionP);
            this.gbDatos.Controls.Add(this.btnPuesto);
            this.gbDatos.Controls.Add(this.cbGradoI);
            this.gbDatos.Controls.Add(this.label2);
            this.gbDatos.Controls.Add(this.label1);
            this.gbDatos.Controls.Add(this.lblcodigo);
            this.gbDatos.Controls.Add(this.dtpHoraI);
            this.gbDatos.Controls.Add(this.txtMotivo);
            this.gbDatos.Controls.Add(this.dtpFechaR);
            this.gbDatos.Controls.Add(this.txtNombresApellidos);
            this.gbDatos.Controls.Add(this.label14);
            this.gbDatos.Controls.Add(this.Motivo);
            this.gbDatos.Controls.Add(this.label9);
            this.gbDatos.Controls.Add(this.label8);
            this.gbDatos.Controls.Add(this.label7);
            this.gbDatos.Controls.Add(this.label6);
            this.gbDatos.Controls.Add(this.label5);
            this.gbDatos.Controls.Add(this.NIVEL);
            this.gbDatos.Controls.Add(this.txtDni);
            this.gbDatos.Location = new System.Drawing.Point(12, 66);
            this.gbDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDatos.Size = new System.Drawing.Size(1354, 612);
            this.gbDatos.TabIndex = 17;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "DATOS";
            // 
            // txtPrestacionesS
            // 
            this.txtPrestacionesS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPrestacionesS.BackColor = System.Drawing.Color.White;
            this.txtPrestacionesS.BorderRadius = 10;
            this.txtPrestacionesS.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrestacionesS.DefaultText = "";
            this.txtPrestacionesS.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrestacionesS.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrestacionesS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrestacionesS.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrestacionesS.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrestacionesS.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrestacionesS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPrestacionesS.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrestacionesS.Location = new System.Drawing.Point(1013, 355);
            this.txtPrestacionesS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrestacionesS.Name = "txtPrestacionesS";
            this.txtPrestacionesS.PasswordChar = '\0';
            this.txtPrestacionesS.PlaceholderText = "";
            this.txtPrestacionesS.SelectedText = "";
            this.txtPrestacionesS.Size = new System.Drawing.Size(298, 36);
            this.txtPrestacionesS.TabIndex = 70;
            this.txtPrestacionesS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // lblDni
            // 
            this.lblDni.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(431, 171);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(0, 28);
            this.lblDni.TabIndex = 69;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(310, 171);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 28);
            this.label13.TabIndex = 68;
            this.label13.Text = "NYA";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(62, 174);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(157, 20);
            this.label12.TabIndex = 67;
            this.label12.Text = "COD TRABAJADOR";
            // 
            // txtCodTrabajador
            // 
            this.txtCodTrabajador.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCodTrabajador.BackColor = System.Drawing.Color.White;
            this.txtCodTrabajador.BorderRadius = 10;
            this.txtCodTrabajador.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodTrabajador.DefaultText = "";
            this.txtCodTrabajador.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCodTrabajador.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCodTrabajador.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCodTrabajador.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCodTrabajador.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCodTrabajador.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCodTrabajador.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCodTrabajador.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCodTrabajador.Location = new System.Drawing.Point(378, 167);
            this.txtCodTrabajador.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodTrabajador.Name = "txtCodTrabajador";
            this.txtCodTrabajador.PasswordChar = '\0';
            this.txtCodTrabajador.PlaceholderText = "";
            this.txtCodTrabajador.SelectedText = "";
            this.txtCodTrabajador.Size = new System.Drawing.Size(53, 36);
            this.txtCodTrabajador.TabIndex = 66;
            this.txtCodTrabajador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // btnModalidad
            // 
            this.btnModalidad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnModalidad.Location = new System.Drawing.Point(315, 491);
            this.btnModalidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModalidad.Name = "btnModalidad";
            this.btnModalidad.Size = new System.Drawing.Size(172, 45);
            this.btnModalidad.TabIndex = 64;
            this.btnModalidad.Text = "SELECCIONAR";
            this.btnModalidad.UseVisualStyleBackColor = true;
            this.btnModalidad.Click += new System.EventHandler(this.btnModalidad_Click);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(62, 502);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 20);
            this.label11.TabIndex = 65;
            this.label11.Text = "MODALIDAD";
            // 
            // cbCitas
            // 
            this.cbCitas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbCitas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCitas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCitas.FormattingEnabled = true;
            this.cbCitas.Location = new System.Drawing.Point(316, 230);
            this.cbCitas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCitas.Name = "cbCitas";
            this.cbCitas.Size = new System.Drawing.Size(298, 28);
            this.cbCitas.TabIndex = 62;
            this.cbCitas.SelectedIndexChanged += new System.EventHandler(this.cbCitas_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(62, 230);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 20);
            this.label10.TabIndex = 63;
            this.label10.Text = "COD CITAS";
            // 
            // cbFolders
            // 
            this.cbFolders.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbFolders.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbFolders.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbFolders.FormattingEnabled = true;
            this.cbFolders.Location = new System.Drawing.Point(1012, 114);
            this.cbFolders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFolders.Name = "cbFolders";
            this.cbFolders.Size = new System.Drawing.Size(298, 28);
            this.cbFolders.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(755, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 61;
            this.label3.Text = "FOLDERS";
            // 
            // dtpHoraS
            // 
            this.dtpHoraS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpHoraS.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraS.Location = new System.Drawing.Point(1012, 233);
            this.dtpHoraS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpHoraS.Name = "dtpHoraS";
            this.dtpHoraS.Size = new System.Drawing.Size(298, 26);
            this.dtpHoraS.TabIndex = 9;
            // 
            // cbUbicacionA
            // 
            this.cbUbicacionA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbUbicacionA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbUbicacionA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbUbicacionA.FormattingEnabled = true;
            this.cbUbicacionA.Location = new System.Drawing.Point(1012, 51);
            this.cbUbicacionA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbUbicacionA.Name = "cbUbicacionA";
            this.cbUbicacionA.Size = new System.Drawing.Size(298, 28);
            this.cbUbicacionA.TabIndex = 6;
            this.cbUbicacionA.SelectedIndexChanged += new System.EventHandler(this.cbUbicacionA_SelectedIndexChanged);
            this.cbUbicacionA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbUbicacionA_KeyPress);
            // 
            // cbEvaluacionP
            // 
            this.cbEvaluacionP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbEvaluacionP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbEvaluacionP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbEvaluacionP.FormattingEnabled = true;
            this.cbEvaluacionP.Location = new System.Drawing.Point(315, 564);
            this.cbEvaluacionP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEvaluacionP.Name = "cbEvaluacionP";
            this.cbEvaluacionP.Size = new System.Drawing.Size(298, 28);
            this.cbEvaluacionP.TabIndex = 5;
            this.cbEvaluacionP.SelectedIndexChanged += new System.EventHandler(this.cbEvaluacionP_SelectedIndexChanged);
            this.cbEvaluacionP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbEvaluacionP_KeyPress);
            // 
            // btnPuesto
            // 
            this.btnPuesto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPuesto.Location = new System.Drawing.Point(315, 414);
            this.btnPuesto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPuesto.Name = "btnPuesto";
            this.btnPuesto.Size = new System.Drawing.Size(172, 45);
            this.btnPuesto.TabIndex = 3;
            this.btnPuesto.Text = "SELECCIONAR";
            this.btnPuesto.UseVisualStyleBackColor = true;
            this.btnPuesto.Click += new System.EventHandler(this.btnPuesto_Click);
            // 
            // cbGradoI
            // 
            this.cbGradoI.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbGradoI.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbGradoI.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbGradoI.FormattingEnabled = true;
            this.cbGradoI.Location = new System.Drawing.Point(316, 304);
            this.cbGradoI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbGradoI.Name = "cbGradoI";
            this.cbGradoI.Size = new System.Drawing.Size(298, 28);
            this.cbGradoI.TabIndex = 1;
            this.cbGradoI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbGradoI_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(755, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 20);
            this.label2.TabIndex = 52;
            this.label2.Text = "FECHA DE INSCRIPCION";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(755, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 51;
            this.label1.Text = "HORA DE SALIDA";
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(1288, 536);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(0, 20);
            this.lblcodigo.TabIndex = 47;
            this.lblcodigo.Visible = false;
            // 
            // dtpHoraI
            // 
            this.dtpHoraI.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpHoraI.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraI.Location = new System.Drawing.Point(1012, 185);
            this.dtpHoraI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpHoraI.Name = "dtpHoraI";
            this.dtpHoraI.Size = new System.Drawing.Size(298, 26);
            this.dtpHoraI.TabIndex = 8;
            // 
            // txtMotivo
            // 
            this.txtMotivo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMotivo.BackColor = System.Drawing.Color.White;
            this.txtMotivo.BorderRadius = 10;
            this.txtMotivo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMotivo.DefaultText = "";
            this.txtMotivo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMotivo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMotivo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMotivo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMotivo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMotivo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMotivo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMotivo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMotivo.Location = new System.Drawing.Point(1013, 432);
            this.txtMotivo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.PasswordChar = '\0';
            this.txtMotivo.PlaceholderText = "";
            this.txtMotivo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMotivo.SelectedText = "";
            this.txtMotivo.Size = new System.Drawing.Size(298, 117);
            this.txtMotivo.TabIndex = 11;
            this.txtMotivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMotivo_KeyPress);
            // 
            // dtpFechaR
            // 
            this.dtpFechaR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpFechaR.Location = new System.Drawing.Point(1013, 291);
            this.dtpFechaR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaR.Name = "dtpFechaR";
            this.dtpFechaR.Size = new System.Drawing.Size(298, 26);
            this.dtpFechaR.TabIndex = 10;
            // 
            // txtNombresApellidos
            // 
            this.txtNombresApellidos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNombresApellidos.BackColor = System.Drawing.Color.White;
            this.txtNombresApellidos.BorderRadius = 10;
            this.txtNombresApellidos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombresApellidos.DefaultText = "";
            this.txtNombresApellidos.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombresApellidos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombresApellidos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombresApellidos.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombresApellidos.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombresApellidos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombresApellidos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNombresApellidos.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombresApellidos.Location = new System.Drawing.Point(65, 100);
            this.txtNombresApellidos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombresApellidos.Name = "txtNombresApellidos";
            this.txtNombresApellidos.PasswordChar = '\0';
            this.txtNombresApellidos.PlaceholderText = "";
            this.txtNombresApellidos.SelectedText = "";
            this.txtNombresApellidos.Size = new System.Drawing.Size(549, 36);
            this.txtNombresApellidos.TabIndex = 18;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(68, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 20);
            this.label14.TabIndex = 44;
            this.label14.Text = "DNI";
            // 
            // Motivo
            // 
            this.Motivo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Motivo.AutoSize = true;
            this.Motivo.Location = new System.Drawing.Point(759, 443);
            this.Motivo.Name = "Motivo";
            this.Motivo.Size = new System.Drawing.Size(71, 20);
            this.Motivo.TabIndex = 43;
            this.Motivo.Text = "MOTIVO";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(62, 426);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 20);
            this.label9.TabIndex = 37;
            this.label9.Text = "PUESTO";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(62, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(210, 20);
            this.label8.TabIndex = 34;
            this.label8.Text = "GRADO DE INSTRUCCION";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(755, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "HORA DE INGRESO";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(755, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "UBICACION ARCHIVOS";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 568);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "EVALUACION PSICOLOGICA";
            // 
            // NIVEL
            // 
            this.NIVEL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NIVEL.AutoSize = true;
            this.NIVEL.Location = new System.Drawing.Point(61, 370);
            this.NIVEL.Name = "NIVEL";
            this.NIVEL.Size = new System.Drawing.Size(56, 20);
            this.NIVEL.TabIndex = 27;
            this.NIVEL.Text = "NIVEL";
            // 
            // txtDni
            // 
            this.txtDni.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDni.BackColor = System.Drawing.Color.White;
            this.txtDni.BorderRadius = 10;
            this.txtDni.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDni.DefaultText = "";
            this.txtDni.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDni.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDni.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDni.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDni.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDni.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDni.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDni.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDni.Location = new System.Drawing.Point(316, 45);
            this.txtDni.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDni.Name = "txtDni";
            this.txtDni.PasswordChar = '\0';
            this.txtDni.PlaceholderText = "";
            this.txtDni.SelectedText = "";
            this.txtDni.Size = new System.Drawing.Size(298, 36);
            this.txtDni.TabIndex = 0;
            this.txtDni.TextChanged += new System.EventHandler(this.txtDni_TextChanged);
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAgregar.Location = new System.Drawing.Point(1411, 153);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(172, 82);
            this.btnAgregar.TabIndex = 18;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEliminar.Location = new System.Drawing.Point(1411, 373);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(172, 84);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSalir.Location = new System.Drawing.Point(1411, 474);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(172, 84);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnModificar.Location = new System.Drawing.Point(1411, 266);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(172, 82);
            this.btnModificar.TabIndex = 21;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dgvTrabajadores
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(193)))), ((int)(((byte)(231)))));
            this.dgvTrabajadores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvTrabajadores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvTrabajadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTrabajadores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTrabajadores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvTrabajadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrabajadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCTrabajador,
            this.ColumDNI,
            this.ColumnCodCitas,
            this.ColumnModalidad,
            this.ColumnPuesto,
            this.ColumnGradoI,
            this.ColumnEvaluacionPsi,
            this.ColumnUbicacionArchivo,
            this.ColumnHoraInicio,
            this.ColumnHoraCierre,
            this.ColumnFechaRegistro,
            this.ColumnMes,
            this.ColumnSalario,
            this.ColumnAño,
            this.ColumnRaazon,
            this.ColumnUsuarioId,
            this.ColumnID});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(226)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTrabajadores.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvTrabajadores.EnableHeadersVisualStyles = false;
            this.dgvTrabajadores.Location = new System.Drawing.Point(12, 708);
            this.dgvTrabajadores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTrabajadores.Name = "dgvTrabajadores";
            this.dgvTrabajadores.RowHeadersWidth = 62;
            this.dgvTrabajadores.RowTemplate.Height = 28;
            this.dgvTrabajadores.Size = new System.Drawing.Size(1590, 69);
            this.dgvTrabajadores.TabIndex = 24;
            this.dgvTrabajadores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrabajadores_CellContentClick);
            this.dgvTrabajadores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrabajadores_CellDoubleClick);
            // 
            // ColumnCTrabajador
            // 
            this.ColumnCTrabajador.DataPropertyName = "cTrabajador";
            this.ColumnCTrabajador.HeaderText = "COD TRABAJADORES";
            this.ColumnCTrabajador.MinimumWidth = 8;
            this.ColumnCTrabajador.Name = "ColumnCTrabajador";
            this.ColumnCTrabajador.Width = 197;
            // 
            // ColumDNI
            // 
            this.ColumDNI.DataPropertyName = "dni";
            this.ColumDNI.HeaderText = "DNI";
            this.ColumDNI.MinimumWidth = 8;
            this.ColumDNI.Name = "ColumDNI";
            this.ColumDNI.Width = 73;
            // 
            // ColumnCodCitas
            // 
            this.ColumnCodCitas.DataPropertyName = "codCitas";
            this.ColumnCodCitas.HeaderText = "COD CITAS";
            this.ColumnCodCitas.MinimumWidth = 8;
            this.ColumnCodCitas.Name = "ColumnCodCitas";
            this.ColumnCodCitas.Width = 121;
            // 
            // ColumnModalidad
            // 
            this.ColumnModalidad.HeaderText = "MODALIDAD";
            this.ColumnModalidad.MinimumWidth = 8;
            this.ColumnModalidad.Name = "ColumnModalidad";
            this.ColumnModalidad.Text = "VER";
            this.ColumnModalidad.UseColumnTextForButtonValue = true;
            this.ColumnModalidad.Width = 112;
            // 
            // ColumnPuesto
            // 
            this.ColumnPuesto.HeaderText = "PUESTO";
            this.ColumnPuesto.MinimumWidth = 8;
            this.ColumnPuesto.Name = "ColumnPuesto";
            this.ColumnPuesto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnPuesto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnPuesto.Text = "VER";
            this.ColumnPuesto.UseColumnTextForButtonValue = true;
            this.ColumnPuesto.Width = 110;
            // 
            // ColumnGradoI
            // 
            this.ColumnGradoI.DataPropertyName = "gradoInstruccion";
            this.ColumnGradoI.HeaderText = "GRADO DE INSTRUCCION";
            this.ColumnGradoI.MinimumWidth = 8;
            this.ColumnGradoI.Name = "ColumnGradoI";
            this.ColumnGradoI.Width = 225;
            // 
            // ColumnEvaluacionPsi
            // 
            this.ColumnEvaluacionPsi.DataPropertyName = "evaluacionPsicologica";
            this.ColumnEvaluacionPsi.HeaderText = "EVALUACION PSICOLOGICA";
            this.ColumnEvaluacionPsi.MinimumWidth = 8;
            this.ColumnEvaluacionPsi.Name = "ColumnEvaluacionPsi";
            this.ColumnEvaluacionPsi.Width = 240;
            // 
            // ColumnUbicacionArchivo
            // 
            this.ColumnUbicacionArchivo.DataPropertyName = "ubicacionArchivo";
            this.ColumnUbicacionArchivo.HeaderText = "UBICACION DE ARCHIVO";
            this.ColumnUbicacionArchivo.MinimumWidth = 8;
            this.ColumnUbicacionArchivo.Name = "ColumnUbicacionArchivo";
            this.ColumnUbicacionArchivo.Width = 152;
            // 
            // ColumnHoraInicio
            // 
            this.ColumnHoraInicio.DataPropertyName = "horaInicio";
            this.ColumnHoraInicio.HeaderText = "HORA DE INGRESO";
            this.ColumnHoraInicio.MinimumWidth = 8;
            this.ColumnHoraInicio.Name = "ColumnHoraInicio";
            this.ColumnHoraInicio.Width = 181;
            // 
            // ColumnHoraCierre
            // 
            this.ColumnHoraCierre.DataPropertyName = "horaCierre";
            this.ColumnHoraCierre.HeaderText = "HORA DE SALIDA";
            this.ColumnHoraCierre.MinimumWidth = 8;
            this.ColumnHoraCierre.Name = "ColumnHoraCierre";
            this.ColumnHoraCierre.Width = 167;
            // 
            // ColumnFechaRegistro
            // 
            this.ColumnFechaRegistro.DataPropertyName = "fechaRegistro";
            this.ColumnFechaRegistro.HeaderText = "FECHA DE REGISTRO";
            this.ColumnFechaRegistro.MinimumWidth = 8;
            this.ColumnFechaRegistro.Name = "ColumnFechaRegistro";
            this.ColumnFechaRegistro.Width = 198;
            // 
            // ColumnMes
            // 
            this.ColumnMes.DataPropertyName = "mes";
            this.ColumnMes.HeaderText = "MES";
            this.ColumnMes.MinimumWidth = 8;
            this.ColumnMes.Name = "ColumnMes";
            this.ColumnMes.Width = 80;
            // 
            // ColumnSalario
            // 
            this.ColumnSalario.DataPropertyName = "salario";
            this.ColumnSalario.HeaderText = "SALARIO";
            this.ColumnSalario.MinimumWidth = 8;
            this.ColumnSalario.Name = "ColumnSalario";
            this.ColumnSalario.Width = 116;
            // 
            // ColumnAño
            // 
            this.ColumnAño.DataPropertyName = "año";
            this.ColumnAño.HeaderText = "AÑO";
            this.ColumnAño.MinimumWidth = 8;
            this.ColumnAño.Name = "ColumnAño";
            this.ColumnAño.Width = 79;
            // 
            // ColumnRaazon
            // 
            this.ColumnRaazon.DataPropertyName = "razon";
            this.ColumnRaazon.HeaderText = "RAZON";
            this.ColumnRaazon.MinimumWidth = 8;
            this.ColumnRaazon.Name = "ColumnRaazon";
            this.ColumnRaazon.Width = 101;
            // 
            // ColumnUsuarioId
            // 
            this.ColumnUsuarioId.DataPropertyName = "userId";
            this.ColumnUsuarioId.HeaderText = "USUARIO ID";
            this.ColumnUsuarioId.MinimumWidth = 8;
            this.ColumnUsuarioId.Name = "ColumnUsuarioId";
            this.ColumnUsuarioId.Visible = false;
            this.ColumnUsuarioId.Width = 130;
            // 
            // ColumnID
            // 
            this.ColumnID.DataPropertyName = "idtrabajador";
            this.ColumnID.HeaderText = "IDTRABAJADOR";
            this.ColumnID.MinimumWidth = 8;
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.Visible = false;
            this.ColumnID.Width = 171;
            // 
            // txtNivel
            // 
            this.txtNivel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNivel.BackColor = System.Drawing.Color.White;
            this.txtNivel.BorderRadius = 10;
            this.txtNivel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNivel.DefaultText = "";
            this.txtNivel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNivel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNivel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNivel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNivel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNivel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNivel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNivel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNivel.Location = new System.Drawing.Point(315, 355);
            this.txtNivel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNivel.Name = "txtNivel";
            this.txtNivel.PasswordChar = '\0';
            this.txtNivel.PlaceholderText = "";
            this.txtNivel.SelectedText = "";
            this.txtNivel.Size = new System.Drawing.Size(298, 36);
            this.txtNivel.TabIndex = 72;
            this.txtNivel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNivel_KeyPress);
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(754, 371);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(239, 20);
            this.label15.TabIndex = 71;
            this.label15.Text = "PRESTACIONES SALARIALES";
            // 
            // FormTrabajadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1614, 802);
            this.Controls.Add(this.dgvTrabajadores);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.lblCitas);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormTrabajadores";
            this.Text = "FormCitas";
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrabajadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCitas;
        private System.Windows.Forms.GroupBox gbDatos;
        private Guna.UI2.WinForms.Guna2TextBox txtMotivo;
        private System.Windows.Forms.DateTimePicker dtpFechaR;
        private Guna.UI2.WinForms.Guna2TextBox txtNombresApellidos;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label Motivo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label NIVEL;
        private Guna.UI2.WinForms.Guna2TextBox txtDni;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DateTimePicker dtpHoraI;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbUbicacionA;
        private System.Windows.Forms.ComboBox cbEvaluacionP;
        private System.Windows.Forms.Button btnPuesto;
        private System.Windows.Forms.ComboBox cbGradoI;
        private System.Windows.Forms.DateTimePicker dtpHoraS;
        private System.Windows.Forms.ComboBox cbFolders;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCitas;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnModalidad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2TextBox txtCodTrabajador;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvTrabajadores;
        private Guna.UI2.WinForms.Guna2TextBox txtPrestacionesS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCTrabajador;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumDNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodCitas;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnModalidad;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnPuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGradoI;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEvaluacionPsi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUbicacionArchivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHoraCierre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSalario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAño;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRaazon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUsuarioId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private Guna.UI2.WinForms.Guna2TextBox txtNivel;
        private System.Windows.Forms.Label label15;
    }
}