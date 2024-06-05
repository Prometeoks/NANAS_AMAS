namespace NANAS_AMAS
{
    partial class FormEmpleador
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmpleador));
            this.dgvEmpleadores = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cboModoContacto = new System.Windows.Forms.ComboBox();
            this.txtReferencia = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTransPublico = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtCelular2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.txtDireccion = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbDistrito = new System.Windows.Forms.ComboBox();
            this.cbProvincia = new System.Windows.Forms.ComboBox();
            this.cbDepartamento = new System.Windows.Forms.ComboBox();
            this.txtCelular1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtApellidoM = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtApellidoP = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNombres = new Guna.UI2.WinForms.Guna2TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDni = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblEmpleadores = new System.Windows.Forms.Label();
            this.columDNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columApellidoPaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columApellidoMaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columCelular1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCelular2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModContacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columDepartamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columProvincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columDistrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columRefDocimilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTransportePublico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnClienteExcluido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columMotivo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.columUsuarioId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleadores)).BeginInit();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEmpleadores
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(193)))), ((int)(((byte)(231)))));
            this.dgvEmpleadores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmpleadores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvEmpleadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEmpleadores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmpleadores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmpleadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columDNI,
            this.columNombre,
            this.columApellidoPaterno,
            this.columApellidoMaterno,
            this.columCelular1,
            this.ColumnCelular2,
            this.ColumnModContacto,
            this.columDepartamento,
            this.columProvincia,
            this.columDistrito,
            this.columDireccion,
            this.columRefDocimilio,
            this.ColumnTransportePublico,
            this.ColumnClienteExcluido,
            this.columMotivo,
            this.columUsuarioId});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(226)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmpleadores.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEmpleadores.EnableHeadersVisualStyles = false;
            this.dgvEmpleadores.Location = new System.Drawing.Point(2, 373);
            this.dgvEmpleadores.Margin = new System.Windows.Forms.Padding(2);
            this.dgvEmpleadores.Name = "dgvEmpleadores";
            this.dgvEmpleadores.RowHeadersWidth = 62;
            this.dgvEmpleadores.RowTemplate.Height = 28;
            this.dgvEmpleadores.Size = new System.Drawing.Size(1060, 46);
            this.dgvEmpleadores.TabIndex = 29;
            this.dgvEmpleadores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleadores_CellContentClick);
            this.dgvEmpleadores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleadores_CellDoubleClick);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnModificar.Location = new System.Drawing.Point(922, 140);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(115, 54);
            this.btnModificar.TabIndex = 28;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSalir.Location = new System.Drawing.Point(922, 275);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(115, 54);
            this.btnSalir.TabIndex = 27;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEliminar.Location = new System.Drawing.Point(922, 209);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(115, 54);
            this.btnEliminar.TabIndex = 26;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAgregar.Location = new System.Drawing.Point(922, 66);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(115, 54);
            this.btnAgregar.TabIndex = 25;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // gbDatos
            // 
            this.gbDatos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbDatos.Controls.Add(this.btnEditar);
            this.gbDatos.Controls.Add(this.btnBuscar);
            this.gbDatos.Controls.Add(this.cboModoContacto);
            this.gbDatos.Controls.Add(this.txtReferencia);
            this.gbDatos.Controls.Add(this.label6);
            this.gbDatos.Controls.Add(this.txtTransPublico);
            this.gbDatos.Controls.Add(this.label4);
            this.gbDatos.Controls.Add(this.checkBox1);
            this.gbDatos.Controls.Add(this.txtCelular2);
            this.gbDatos.Controls.Add(this.label15);
            this.gbDatos.Controls.Add(this.lblcodigo);
            this.gbDatos.Controls.Add(this.txtDireccion);
            this.gbDatos.Controls.Add(this.cbDistrito);
            this.gbDatos.Controls.Add(this.cbProvincia);
            this.gbDatos.Controls.Add(this.cbDepartamento);
            this.gbDatos.Controls.Add(this.txtCelular1);
            this.gbDatos.Controls.Add(this.txtApellidoM);
            this.gbDatos.Controls.Add(this.txtApellidoP);
            this.gbDatos.Controls.Add(this.txtNombres);
            this.gbDatos.Controls.Add(this.label14);
            this.gbDatos.Controls.Add(this.label13);
            this.gbDatos.Controls.Add(this.label12);
            this.gbDatos.Controls.Add(this.label11);
            this.gbDatos.Controls.Add(this.label10);
            this.gbDatos.Controls.Add(this.label9);
            this.gbDatos.Controls.Add(this.label5);
            this.gbDatos.Controls.Add(this.label3);
            this.gbDatos.Controls.Add(this.label2);
            this.gbDatos.Controls.Add(this.label1);
            this.gbDatos.Controls.Add(this.txtDni);
            this.gbDatos.Location = new System.Drawing.Point(2, 34);
            this.gbDatos.Margin = new System.Windows.Forms.Padding(2);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Padding = new System.Windows.Forms.Padding(2);
            this.gbDatos.Size = new System.Drawing.Size(903, 320);
            this.gbDatos.TabIndex = 24;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "DATOS";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(676, 275);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 58;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(415, 35);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Padding = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Size = new System.Drawing.Size(30, 32);
            this.btnBuscar.TabIndex = 57;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cboModoContacto
            // 
            this.cboModoContacto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboModoContacto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboModoContacto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboModoContacto.FormattingEnabled = true;
            this.cboModoContacto.Location = new System.Drawing.Point(211, 275);
            this.cboModoContacto.Margin = new System.Windows.Forms.Padding(2);
            this.cboModoContacto.Name = "cboModoContacto";
            this.cboModoContacto.Size = new System.Drawing.Size(200, 21);
            this.cboModoContacto.TabIndex = 56;
            this.cboModoContacto.SelectedIndexChanged += new System.EventHandler(this.cboModoContacto_SelectedIndexChanged);
            // 
            // txtReferencia
            // 
            this.txtReferencia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtReferencia.BackColor = System.Drawing.Color.White;
            this.txtReferencia.BorderRadius = 10;
            this.txtReferencia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReferencia.DefaultText = "";
            this.txtReferencia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtReferencia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtReferencia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtReferencia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtReferencia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtReferencia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtReferencia.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtReferencia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtReferencia.Location = new System.Drawing.Point(666, 184);
            this.txtReferencia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtReferencia.Multiline = true;
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.PasswordChar = '\0';
            this.txtReferencia.PlaceholderText = "";
            this.txtReferencia.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReferencia.SelectedText = "";
            this.txtReferencia.Size = new System.Drawing.Size(199, 45);
            this.txtReferencia.TabIndex = 55;
            this.txtReferencia.TextChanged += new System.EventHandler(this.txtReferencia_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 282);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "MODO DE CONTACTO";
            // 
            // txtTransPublico
            // 
            this.txtTransPublico.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTransPublico.BackColor = System.Drawing.Color.White;
            this.txtTransPublico.BorderRadius = 10;
            this.txtTransPublico.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTransPublico.DefaultText = "";
            this.txtTransPublico.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTransPublico.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTransPublico.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTransPublico.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTransPublico.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTransPublico.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTransPublico.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTransPublico.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTransPublico.Location = new System.Drawing.Point(666, 241);
            this.txtTransPublico.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTransPublico.Name = "txtTransPublico";
            this.txtTransPublico.PasswordChar = '\0';
            this.txtTransPublico.PlaceholderText = "";
            this.txtTransPublico.SelectedText = "";
            this.txtTransPublico.Size = new System.Drawing.Size(199, 24);
            this.txtTransPublico.TabIndex = 51;
            this.txtTransPublico.TextChanged += new System.EventHandler(this.txtTransPublico_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(501, 252);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "TRANSPORTE PUBLICO";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(503, 278);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(144, 17);
            this.checkBox1.TabIndex = 50;
            this.checkBox1.Text = "CLIENTE EXCLUIDO";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkBox1_MouseClick);
            // 
            // txtCelular2
            // 
            this.txtCelular2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCelular2.BackColor = System.Drawing.Color.White;
            this.txtCelular2.BorderRadius = 10;
            this.txtCelular2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCelular2.DefaultText = "";
            this.txtCelular2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCelular2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCelular2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCelular2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCelular2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCelular2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCelular2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCelular2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCelular2.Location = new System.Drawing.Point(211, 230);
            this.txtCelular2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCelular2.Name = "txtCelular2";
            this.txtCelular2.PasswordChar = '\0';
            this.txtCelular2.PlaceholderText = "";
            this.txtCelular2.SelectedText = "";
            this.txtCelular2.Size = new System.Drawing.Size(199, 24);
            this.txtCelular2.TabIndex = 48;
            this.txtCelular2.TextChanged += new System.EventHandler(this.txtCelular2_TextChanged);
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Image = ((System.Drawing.Image)(resources.GetObject("label15.Image")));
            this.label15.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label15.Location = new System.Drawing.Point(40, 240);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.label15.Size = new System.Drawing.Size(85, 21);
            this.label15.TabIndex = 49;
            this.label15.Text = "NÚMERO          ";
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(859, 349);
            this.lblcodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(0, 13);
            this.lblcodigo.TabIndex = 47;
            this.lblcodigo.Visible = false;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDireccion.BackColor = System.Drawing.Color.White;
            this.txtDireccion.BorderRadius = 10;
            this.txtDireccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDireccion.DefaultText = "";
            this.txtDireccion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDireccion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDireccion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDireccion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDireccion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDireccion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDireccion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDireccion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDireccion.Location = new System.Drawing.Point(666, 154);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PasswordChar = '\0';
            this.txtDireccion.PlaceholderText = "";
            this.txtDireccion.SelectedText = "";
            this.txtDireccion.Size = new System.Drawing.Size(199, 24);
            this.txtDireccion.TabIndex = 39;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // cbDistrito
            // 
            this.cbDistrito.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbDistrito.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbDistrito.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbDistrito.FormattingEnabled = true;
            this.cbDistrito.Location = new System.Drawing.Point(666, 118);
            this.cbDistrito.Margin = new System.Windows.Forms.Padding(2);
            this.cbDistrito.Name = "cbDistrito";
            this.cbDistrito.Size = new System.Drawing.Size(200, 21);
            this.cbDistrito.TabIndex = 36;
            this.cbDistrito.SelectedIndexChanged += new System.EventHandler(this.cbDistrito_SelectedIndexChanged);
            // 
            // cbProvincia
            // 
            this.cbProvincia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbProvincia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbProvincia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbProvincia.FormattingEnabled = true;
            this.cbProvincia.Location = new System.Drawing.Point(666, 83);
            this.cbProvincia.Margin = new System.Windows.Forms.Padding(2);
            this.cbProvincia.Name = "cbProvincia";
            this.cbProvincia.Size = new System.Drawing.Size(200, 21);
            this.cbProvincia.TabIndex = 35;
            this.cbProvincia.SelectedIndexChanged += new System.EventHandler(this.cbProvincia_SelectedIndexChanged);
            // 
            // cbDepartamento
            // 
            this.cbDepartamento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbDepartamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbDepartamento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbDepartamento.FormattingEnabled = true;
            this.cbDepartamento.Location = new System.Drawing.Point(666, 43);
            this.cbDepartamento.Margin = new System.Windows.Forms.Padding(2);
            this.cbDepartamento.Name = "cbDepartamento";
            this.cbDepartamento.Size = new System.Drawing.Size(200, 21);
            this.cbDepartamento.TabIndex = 32;
            this.cbDepartamento.SelectedIndexChanged += new System.EventHandler(this.cbDepartamento_SelectedIndexChanged);
            // 
            // txtCelular1
            // 
            this.txtCelular1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCelular1.BackColor = System.Drawing.Color.White;
            this.txtCelular1.BorderRadius = 10;
            this.txtCelular1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCelular1.DefaultText = "";
            this.txtCelular1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCelular1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCelular1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCelular1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCelular1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCelular1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCelular1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCelular1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCelular1.Location = new System.Drawing.Point(211, 194);
            this.txtCelular1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCelular1.Name = "txtCelular1";
            this.txtCelular1.PasswordChar = '\0';
            this.txtCelular1.PlaceholderText = "";
            this.txtCelular1.SelectedText = "";
            this.txtCelular1.Size = new System.Drawing.Size(199, 24);
            this.txtCelular1.TabIndex = 24;
            this.txtCelular1.TextChanged += new System.EventHandler(this.txtCelular1_TextChanged);
            // 
            // txtApellidoM
            // 
            this.txtApellidoM.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtApellidoM.BackColor = System.Drawing.Color.White;
            this.txtApellidoM.BorderRadius = 10;
            this.txtApellidoM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellidoM.DefaultText = "";
            this.txtApellidoM.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtApellidoM.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtApellidoM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtApellidoM.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtApellidoM.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtApellidoM.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtApellidoM.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtApellidoM.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtApellidoM.Location = new System.Drawing.Point(211, 154);
            this.txtApellidoM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtApellidoM.Name = "txtApellidoM";
            this.txtApellidoM.PasswordChar = '\0';
            this.txtApellidoM.PlaceholderText = "";
            this.txtApellidoM.SelectedText = "";
            this.txtApellidoM.Size = new System.Drawing.Size(199, 24);
            this.txtApellidoM.TabIndex = 20;
            this.txtApellidoM.TextChanged += new System.EventHandler(this.txtApellidoM_TextChanged);
            // 
            // txtApellidoP
            // 
            this.txtApellidoP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtApellidoP.BackColor = System.Drawing.Color.White;
            this.txtApellidoP.BorderRadius = 10;
            this.txtApellidoP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellidoP.DefaultText = "";
            this.txtApellidoP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtApellidoP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtApellidoP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtApellidoP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtApellidoP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtApellidoP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtApellidoP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtApellidoP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtApellidoP.Location = new System.Drawing.Point(211, 114);
            this.txtApellidoP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtApellidoP.Name = "txtApellidoP";
            this.txtApellidoP.PasswordChar = '\0';
            this.txtApellidoP.PlaceholderText = "";
            this.txtApellidoP.SelectedText = "";
            this.txtApellidoP.Size = new System.Drawing.Size(199, 24);
            this.txtApellidoP.TabIndex = 19;
            this.txtApellidoP.TextChanged += new System.EventHandler(this.txtApellidoP_TextChanged);
            // 
            // txtNombres
            // 
            this.txtNombres.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNombres.BackColor = System.Drawing.Color.White;
            this.txtNombres.BorderRadius = 10;
            this.txtNombres.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombres.DefaultText = "";
            this.txtNombres.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombres.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombres.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombres.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombres.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombres.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombres.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNombres.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombres.Location = new System.Drawing.Point(211, 75);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.PasswordChar = '\0';
            this.txtNombres.PlaceholderText = "";
            this.txtNombres.SelectedText = "";
            this.txtNombres.Size = new System.Drawing.Size(199, 24);
            this.txtNombres.TabIndex = 18;
            this.txtNombres.TextChanged += new System.EventHandler(this.txtNombres_TextChanged);
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(40, 50);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 13);
            this.label14.TabIndex = 44;
            this.label14.Text = "DNI";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(501, 205);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(151, 13);
            this.label13.TabIndex = 43;
            this.label13.Text = "REFERENCIA DE DOMICILIO";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(501, 165);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 42;
            this.label12.Text = "DIRECCION";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(501, 124);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 41;
            this.label11.Text = "DISTRITO";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(501, 85);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "PROVINCIA";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(501, 48);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "DEPARTAMENTO";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(40, 197);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.label5.Size = new System.Drawing.Size(82, 21);
            this.label5.TabIndex = 28;
            this.label5.Text = "NÚMERO         ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "APELLIDOS MATERNO";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "APELLIDOS PATERNO";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "NOMBRES";
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
            this.txtDni.Location = new System.Drawing.Point(211, 39);
            this.txtDni.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDni.Name = "txtDni";
            this.txtDni.PasswordChar = '\0';
            this.txtDni.PlaceholderText = "";
            this.txtDni.SelectedText = "";
            this.txtDni.Size = new System.Drawing.Size(199, 24);
            this.txtDni.TabIndex = 17;
            this.txtDni.TextChanged += new System.EventHandler(this.txtDni_TextChanged);
            // 
            // lblEmpleadores
            // 
            this.lblEmpleadores.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEmpleadores.AutoSize = true;
            this.lblEmpleadores.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleadores.Location = new System.Drawing.Point(383, 9);
            this.lblEmpleadores.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmpleadores.Name = "lblEmpleadores";
            this.lblEmpleadores.Size = new System.Drawing.Size(274, 23);
            this.lblEmpleadores.TabIndex = 23;
            this.lblEmpleadores.Text = "REGISTRO DE EMPLEADORES";
            // 
            // columDNI
            // 
            this.columDNI.DataPropertyName = "dni";
            this.columDNI.HeaderText = "DNI";
            this.columDNI.MinimumWidth = 8;
            this.columDNI.Name = "columDNI";
            this.columDNI.Width = 51;
            // 
            // columNombre
            // 
            this.columNombre.DataPropertyName = "nombre";
            this.columNombre.HeaderText = "NOMBRE";
            this.columNombre.MinimumWidth = 8;
            this.columNombre.Name = "columNombre";
            this.columNombre.Width = 79;
            // 
            // columApellidoPaterno
            // 
            this.columApellidoPaterno.DataPropertyName = "apellidoPaterno";
            this.columApellidoPaterno.HeaderText = "APELLIDO PATERNO";
            this.columApellidoPaterno.MinimumWidth = 8;
            this.columApellidoPaterno.Name = "columApellidoPaterno";
            this.columApellidoPaterno.Width = 127;
            // 
            // columApellidoMaterno
            // 
            this.columApellidoMaterno.DataPropertyName = "apellidoMaterno";
            this.columApellidoMaterno.HeaderText = "APELLIDO MATERNO";
            this.columApellidoMaterno.MinimumWidth = 8;
            this.columApellidoMaterno.Name = "columApellidoMaterno";
            this.columApellidoMaterno.Width = 129;
            // 
            // columCelular1
            // 
            this.columCelular1.DataPropertyName = "celular1";
            this.columCelular1.HeaderText = "CELULAR1";
            this.columCelular1.MinimumWidth = 8;
            this.columCelular1.Name = "columCelular1";
            this.columCelular1.Width = 87;
            // 
            // ColumnCelular2
            // 
            this.ColumnCelular2.DataPropertyName = "celular2";
            this.ColumnCelular2.HeaderText = "CELULAR2";
            this.ColumnCelular2.MinimumWidth = 6;
            this.ColumnCelular2.Name = "ColumnCelular2";
            this.ColumnCelular2.Width = 87;
            // 
            // ColumnModContacto
            // 
            this.ColumnModContacto.DataPropertyName = "modo_contacto";
            this.ColumnModContacto.HeaderText = "MODO DE CONTACTO";
            this.ColumnModContacto.MinimumWidth = 6;
            this.ColumnModContacto.Name = "ColumnModContacto";
            this.ColumnModContacto.Width = 133;
            // 
            // columDepartamento
            // 
            this.columDepartamento.DataPropertyName = "departamento";
            this.columDepartamento.HeaderText = "DEPARTAMENTO";
            this.columDepartamento.MinimumWidth = 8;
            this.columDepartamento.Name = "columDepartamento";
            this.columDepartamento.Width = 122;
            // 
            // columProvincia
            // 
            this.columProvincia.DataPropertyName = "provincia";
            this.columProvincia.HeaderText = "PROVINCIA";
            this.columProvincia.MinimumWidth = 8;
            this.columProvincia.Name = "columProvincia";
            this.columProvincia.Width = 90;
            // 
            // columDistrito
            // 
            this.columDistrito.DataPropertyName = "distrito";
            this.columDistrito.HeaderText = "DISTRITO";
            this.columDistrito.MinimumWidth = 8;
            this.columDistrito.Name = "columDistrito";
            this.columDistrito.Width = 83;
            // 
            // columDireccion
            // 
            this.columDireccion.DataPropertyName = "direccion";
            this.columDireccion.HeaderText = "DIRECCION";
            this.columDireccion.MinimumWidth = 8;
            this.columDireccion.Name = "columDireccion";
            this.columDireccion.Width = 91;
            // 
            // columRefDocimilio
            // 
            this.columRefDocimilio.DataPropertyName = "ref_domicilio";
            this.columRefDocimilio.HeaderText = "REFERENCIA DOMICILIO";
            this.columRefDocimilio.MinimumWidth = 8;
            this.columRefDocimilio.Name = "columRefDocimilio";
            this.columRefDocimilio.Width = 144;
            // 
            // ColumnTransportePublico
            // 
            this.ColumnTransportePublico.DataPropertyName = "transporte_publico";
            this.ColumnTransportePublico.HeaderText = "TRANSPORTE PUBLICO";
            this.ColumnTransportePublico.MinimumWidth = 6;
            this.ColumnTransportePublico.Name = "ColumnTransportePublico";
            this.ColumnTransportePublico.Width = 142;
            // 
            // ColumnClienteExcluido
            // 
            this.ColumnClienteExcluido.DataPropertyName = "lista_excluidos";
            this.ColumnClienteExcluido.HeaderText = "CLIENTE EXCLUIDO";
            this.ColumnClienteExcluido.MinimumWidth = 6;
            this.ColumnClienteExcluido.Name = "ColumnClienteExcluido";
            this.ColumnClienteExcluido.Width = 123;
            // 
            // columMotivo
            // 
            this.columMotivo.DataPropertyName = "motivo_excluido";
            this.columMotivo.HeaderText = "MOTIVO";
            this.columMotivo.MinimumWidth = 6;
            this.columMotivo.Name = "columMotivo";
            this.columMotivo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columMotivo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.columMotivo.Text = "Ver...";
            this.columMotivo.UseColumnTextForButtonValue = true;
            this.columMotivo.Width = 74;
            // 
            // columUsuarioId
            // 
            this.columUsuarioId.DataPropertyName = "usuario_id";
            this.columUsuarioId.HeaderText = "USUARIO ID";
            this.columUsuarioId.MinimumWidth = 8;
            this.columUsuarioId.Name = "columUsuarioId";
            this.columUsuarioId.Visible = false;
            this.columUsuarioId.Width = 88;
            // 
            // FormEmpleador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 428);
            this.ControlBox = false;
            this.Controls.Add(this.dgvEmpleadores);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.lblEmpleadores);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEmpleador";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleadores)).EndInit();
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmpleadores;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox gbDatos;
        private Guna.UI2.WinForms.Guna2TextBox txtCelular2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblcodigo;
        private Guna.UI2.WinForms.Guna2TextBox txtDireccion;
        private System.Windows.Forms.ComboBox cbDistrito;
        private System.Windows.Forms.ComboBox cbProvincia;
        private System.Windows.Forms.ComboBox cbDepartamento;
        private Guna.UI2.WinForms.Guna2TextBox txtCelular1;
        private Guna.UI2.WinForms.Guna2TextBox txtApellidoM;
        private Guna.UI2.WinForms.Guna2TextBox txtApellidoP;
        private Guna.UI2.WinForms.Guna2TextBox txtNombres;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtDni;
        private System.Windows.Forms.Label lblEmpleadores;
        private Guna.UI2.WinForms.Guna2TextBox txtTransPublico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboModoContacto;
        private Guna.UI2.WinForms.Guna2TextBox txtReferencia;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridViewTextBoxColumn columDNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn columNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn columApellidoPaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn columApellidoMaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn columCelular1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCelular2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModContacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn columDepartamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn columProvincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn columDistrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn columDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn columRefDocimilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTransportePublico;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClienteExcluido;
        private System.Windows.Forms.DataGridViewButtonColumn columMotivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columUsuarioId;
    }
}