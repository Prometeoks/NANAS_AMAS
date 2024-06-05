namespace NANAS_AMAS
{
    partial class FormPedido
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
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.columCodPedidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDniEmpleador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columEdadMinima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columEdadMaxima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFunciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRutina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnObservaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHoraFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCantHoras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.txtMinutosInicio = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtHoraInicio = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMinutosFin = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtHoraFin = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnRutina = new System.Windows.Forms.Button();
            this.btnFunciones = new System.Windows.Forms.Button();
            this.btnObservaciones = new System.Windows.Forms.Button();
            this.btnModalidad = new System.Windows.Forms.Button();
            this.btnPuesto = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.txtSueldo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCantiadadHoras = new Guna.UI2.WinForms.Guna2TextBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.txtEdadMaxima = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEdadMinima = new Guna.UI2.WinForms.Guna2TextBox();
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
            this.lblPedidos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPedidos
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(193)))), ((int)(((byte)(231)))));
            this.dgvPedidos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPedidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columCodPedidos,
            this.ColumnDniEmpleador,
            this.columEdadMinima,
            this.columEdadMaxima,
            this.ColumnPuesto,
            this.ColumnFunciones,
            this.ColumnRutina,
            this.ColumnObservaciones,
            this.ColumnEstado,
            this.ColumnHoraInicio,
            this.ColumnHoraFin,
            this.ColumnCantHoras,
            this.ColumnSueldo,
            this.ColumnModalidad,
            this.ColumnUserId});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(226)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPedidos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPedidos.EnableHeadersVisualStyles = false;
            this.dgvPedidos.Location = new System.Drawing.Point(9, 376);
            this.dgvPedidos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.RowHeadersWidth = 62;
            this.dgvPedidos.RowTemplate.Height = 28;
            this.dgvPedidos.Size = new System.Drawing.Size(1060, 46);
            this.dgvPedidos.TabIndex = 36;
            // 
            // columCodPedidos
            // 
            this.columCodPedidos.DataPropertyName = "codPedido";
            this.columCodPedidos.HeaderText = "COD PEDIDOS";
            this.columCodPedidos.MinimumWidth = 8;
            this.columCodPedidos.Name = "columCodPedidos";
            this.columCodPedidos.Width = 97;
            // 
            // ColumnDniEmpleador
            // 
            this.ColumnDniEmpleador.DataPropertyName = "Dni_Empleador";
            this.ColumnDniEmpleador.HeaderText = "DNI EMPLEADOR";
            this.ColumnDniEmpleador.Name = "ColumnDniEmpleador";
            this.ColumnDniEmpleador.Width = 111;
            // 
            // columEdadMinima
            // 
            this.columEdadMinima.DataPropertyName = "Edad_Minima";
            this.columEdadMinima.HeaderText = "EDAD MINIMA";
            this.columEdadMinima.MinimumWidth = 8;
            this.columEdadMinima.Name = "columEdadMinima";
            this.columEdadMinima.Width = 96;
            // 
            // columEdadMaxima
            // 
            this.columEdadMaxima.DataPropertyName = "Edad_Maxima";
            this.columEdadMaxima.HeaderText = "EDAD MAXIMA";
            this.columEdadMaxima.MinimumWidth = 8;
            this.columEdadMaxima.Name = "columEdadMaxima";
            this.columEdadMaxima.Width = 98;
            // 
            // ColumnPuesto
            // 
            this.ColumnPuesto.DataPropertyName = "puesto";
            this.ColumnPuesto.HeaderText = "PUESTO";
            this.ColumnPuesto.MinimumWidth = 6;
            this.ColumnPuesto.Name = "ColumnPuesto";
            this.ColumnPuesto.Width = 76;
            // 
            // ColumnFunciones
            // 
            this.ColumnFunciones.DataPropertyName = "funciones";
            this.ColumnFunciones.HeaderText = "FUNCIONES";
            this.ColumnFunciones.MinimumWidth = 6;
            this.ColumnFunciones.Name = "ColumnFunciones";
            this.ColumnFunciones.Width = 94;
            // 
            // ColumnRutina
            // 
            this.ColumnRutina.DataPropertyName = "rutina";
            this.ColumnRutina.HeaderText = "RUTINA";
            this.ColumnRutina.MinimumWidth = 6;
            this.ColumnRutina.Name = "ColumnRutina";
            this.ColumnRutina.Width = 73;
            // 
            // ColumnObservaciones
            // 
            this.ColumnObservaciones.DataPropertyName = "observaciones";
            this.ColumnObservaciones.HeaderText = "OBSERVACIONES";
            this.ColumnObservaciones.MinimumWidth = 6;
            this.ColumnObservaciones.Name = "ColumnObservaciones";
            this.ColumnObservaciones.Width = 123;
            // 
            // ColumnEstado
            // 
            this.ColumnEstado.DataPropertyName = "estado";
            this.ColumnEstado.HeaderText = "ESTADO";
            this.ColumnEstado.MinimumWidth = 6;
            this.ColumnEstado.Name = "ColumnEstado";
            this.ColumnEstado.Width = 76;
            // 
            // ColumnHoraInicio
            // 
            this.ColumnHoraInicio.DataPropertyName = "hora_de_Inicio";
            this.ColumnHoraInicio.HeaderText = "HORA INICIO";
            this.ColumnHoraInicio.MinimumWidth = 6;
            this.ColumnHoraInicio.Name = "ColumnHoraInicio";
            this.ColumnHoraInicio.Width = 90;
            // 
            // ColumnHoraFin
            // 
            this.ColumnHoraFin.DataPropertyName = "hora_final";
            this.ColumnHoraFin.HeaderText = "HORA FIN";
            this.ColumnHoraFin.MinimumWidth = 6;
            this.ColumnHoraFin.Name = "ColumnHoraFin";
            this.ColumnHoraFin.Width = 77;
            // 
            // ColumnCantHoras
            // 
            this.ColumnCantHoras.DataPropertyName = "Cant_Horas";
            this.ColumnCantHoras.HeaderText = "CANTIDAD HORAS";
            this.ColumnCantHoras.MinimumWidth = 6;
            this.ColumnCantHoras.Name = "ColumnCantHoras";
            this.ColumnCantHoras.Width = 117;
            // 
            // ColumnSueldo
            // 
            this.ColumnSueldo.DataPropertyName = "sueldo";
            this.ColumnSueldo.HeaderText = "SUELDO";
            this.ColumnSueldo.MinimumWidth = 6;
            this.ColumnSueldo.Name = "ColumnSueldo";
            this.ColumnSueldo.Width = 76;
            // 
            // ColumnModalidad
            // 
            this.ColumnModalidad.DataPropertyName = "modalidad";
            this.ColumnModalidad.HeaderText = "MODALIDAD";
            this.ColumnModalidad.MinimumWidth = 6;
            this.ColumnModalidad.Name = "ColumnModalidad";
            this.ColumnModalidad.Width = 96;
            // 
            // ColumnUserId
            // 
            this.ColumnUserId.DataPropertyName = "Usuario_Id";
            this.ColumnUserId.HeaderText = "USER ID";
            this.ColumnUserId.MinimumWidth = 6;
            this.ColumnUserId.Name = "ColumnUserId";
            this.ColumnUserId.Width = 70;
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnModificar.Location = new System.Drawing.Point(930, 143);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(115, 54);
            this.btnModificar.TabIndex = 35;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSalir.Location = new System.Drawing.Point(930, 278);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(115, 54);
            this.btnSalir.TabIndex = 34;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEliminar.Location = new System.Drawing.Point(930, 212);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(115, 54);
            this.btnEliminar.TabIndex = 33;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAgregar.Location = new System.Drawing.Point(930, 69);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(115, 54);
            this.btnAgregar.TabIndex = 32;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // gbDatos
            // 
            this.gbDatos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbDatos.Controls.Add(this.txtMinutosInicio);
            this.gbDatos.Controls.Add(this.txtHoraInicio);
            this.gbDatos.Controls.Add(this.txtMinutosFin);
            this.gbDatos.Controls.Add(this.txtHoraFin);
            this.gbDatos.Controls.Add(this.btnRutina);
            this.gbDatos.Controls.Add(this.btnFunciones);
            this.gbDatos.Controls.Add(this.btnObservaciones);
            this.gbDatos.Controls.Add(this.btnModalidad);
            this.gbDatos.Controls.Add(this.btnPuesto);
            this.gbDatos.Controls.Add(this.label6);
            this.gbDatos.Controls.Add(this.label4);
            this.gbDatos.Controls.Add(this.label15);
            this.gbDatos.Controls.Add(this.lblcodigo);
            this.gbDatos.Controls.Add(this.txtSueldo);
            this.gbDatos.Controls.Add(this.txtCantiadadHoras);
            this.gbDatos.Controls.Add(this.cboEstado);
            this.gbDatos.Controls.Add(this.txtEdadMaxima);
            this.gbDatos.Controls.Add(this.txtEdadMinima);
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
            this.gbDatos.Location = new System.Drawing.Point(9, 37);
            this.gbDatos.Margin = new System.Windows.Forms.Padding(2);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Padding = new System.Windows.Forms.Padding(2);
            this.gbDatos.Size = new System.Drawing.Size(903, 320);
            this.gbDatos.TabIndex = 31;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "DATOS";
            // 
            // txtMinutosInicio
            // 
            this.txtMinutosInicio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMinutosInicio.BorderRadius = 10;
            this.txtMinutosInicio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMinutosInicio.DefaultText = "";
            this.txtMinutosInicio.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMinutosInicio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMinutosInicio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMinutosInicio.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMinutosInicio.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMinutosInicio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMinutosInicio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMinutosInicio.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMinutosInicio.Location = new System.Drawing.Point(769, 152);
            this.txtMinutosInicio.Name = "txtMinutosInicio";
            this.txtMinutosInicio.PasswordChar = '\0';
            this.txtMinutosInicio.PlaceholderText = "";
            this.txtMinutosInicio.SelectedText = "";
            this.txtMinutosInicio.Size = new System.Drawing.Size(64, 24);
            this.txtMinutosInicio.TabIndex = 73;
            this.txtMinutosInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMinutosInicio.TextChanged += new System.EventHandler(this.txtMinutosInicio_TextChanged);
            // 
            // txtHoraInicio
            // 
            this.txtHoraInicio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtHoraInicio.BorderRadius = 10;
            this.txtHoraInicio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHoraInicio.DefaultText = "";
            this.txtHoraInicio.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHoraInicio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHoraInicio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoraInicio.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoraInicio.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoraInicio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtHoraInicio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtHoraInicio.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoraInicio.Location = new System.Drawing.Point(699, 152);
            this.txtHoraInicio.Name = "txtHoraInicio";
            this.txtHoraInicio.PasswordChar = '\0';
            this.txtHoraInicio.PlaceholderText = "";
            this.txtHoraInicio.SelectedText = "";
            this.txtHoraInicio.Size = new System.Drawing.Size(64, 24);
            this.txtHoraInicio.TabIndex = 72;
            this.txtHoraInicio.Tag = "";
            this.txtHoraInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHoraInicio.TextChanged += new System.EventHandler(this.txtHoraInicio_TextChanged);
            // 
            // txtMinutosFin
            // 
            this.txtMinutosFin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMinutosFin.BorderRadius = 10;
            this.txtMinutosFin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMinutosFin.DefaultText = "";
            this.txtMinutosFin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMinutosFin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMinutosFin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMinutosFin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMinutosFin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMinutosFin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMinutosFin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMinutosFin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMinutosFin.Location = new System.Drawing.Point(769, 183);
            this.txtMinutosFin.Name = "txtMinutosFin";
            this.txtMinutosFin.PasswordChar = '\0';
            this.txtMinutosFin.PlaceholderText = "";
            this.txtMinutosFin.SelectedText = "";
            this.txtMinutosFin.Size = new System.Drawing.Size(64, 24);
            this.txtMinutosFin.TabIndex = 71;
            this.txtMinutosFin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMinutosFin.TextChanged += new System.EventHandler(this.txtMinutosFin_TextChanged);
            // 
            // txtHoraFin
            // 
            this.txtHoraFin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtHoraFin.BorderRadius = 10;
            this.txtHoraFin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHoraFin.DefaultText = "";
            this.txtHoraFin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHoraFin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHoraFin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoraFin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoraFin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoraFin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtHoraFin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtHoraFin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoraFin.Location = new System.Drawing.Point(699, 183);
            this.txtHoraFin.Name = "txtHoraFin";
            this.txtHoraFin.PasswordChar = '\0';
            this.txtHoraFin.PlaceholderText = "";
            this.txtHoraFin.SelectedText = "";
            this.txtHoraFin.Size = new System.Drawing.Size(64, 24);
            this.txtHoraFin.TabIndex = 70;
            this.txtHoraFin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHoraFin.TextChanged += new System.EventHandler(this.txtHoraFin_TextChanged);
            // 
            // btnRutina
            // 
            this.btnRutina.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRutina.Location = new System.Drawing.Point(709, 42);
            this.btnRutina.Margin = new System.Windows.Forms.Padding(2);
            this.btnRutina.Name = "btnRutina";
            this.btnRutina.Size = new System.Drawing.Size(115, 29);
            this.btnRutina.TabIndex = 69;
            this.btnRutina.Text = "SELECCIONAR";
            this.btnRutina.UseVisualStyleBackColor = true;
            this.btnRutina.Click += new System.EventHandler(this.btnRutina_Click);
            // 
            // btnFunciones
            // 
            this.btnFunciones.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFunciones.Location = new System.Drawing.Point(238, 214);
            this.btnFunciones.Margin = new System.Windows.Forms.Padding(2);
            this.btnFunciones.Name = "btnFunciones";
            this.btnFunciones.Size = new System.Drawing.Size(115, 29);
            this.btnFunciones.TabIndex = 68;
            this.btnFunciones.Text = "SELECCIONAR";
            this.btnFunciones.UseVisualStyleBackColor = true;
            this.btnFunciones.Click += new System.EventHandler(this.btnFunciones_Click);
            // 
            // btnObservaciones
            // 
            this.btnObservaciones.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnObservaciones.Location = new System.Drawing.Point(709, 78);
            this.btnObservaciones.Margin = new System.Windows.Forms.Padding(2);
            this.btnObservaciones.Name = "btnObservaciones";
            this.btnObservaciones.Size = new System.Drawing.Size(115, 29);
            this.btnObservaciones.TabIndex = 67;
            this.btnObservaciones.Text = "SELECCIONAR";
            this.btnObservaciones.UseVisualStyleBackColor = true;
            this.btnObservaciones.Click += new System.EventHandler(this.btnObservaciones_Click);
            // 
            // btnModalidad
            // 
            this.btnModalidad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnModalidad.Location = new System.Drawing.Point(238, 78);
            this.btnModalidad.Margin = new System.Windows.Forms.Padding(2);
            this.btnModalidad.Name = "btnModalidad";
            this.btnModalidad.Size = new System.Drawing.Size(115, 29);
            this.btnModalidad.TabIndex = 66;
            this.btnModalidad.Text = "SELECCIONAR";
            this.btnModalidad.UseVisualStyleBackColor = true;
            this.btnModalidad.Click += new System.EventHandler(this.btnModalidad_Click);
            // 
            // btnPuesto
            // 
            this.btnPuesto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPuesto.Location = new System.Drawing.Point(238, 115);
            this.btnPuesto.Margin = new System.Windows.Forms.Padding(2);
            this.btnPuesto.Name = "btnPuesto";
            this.btnPuesto.Size = new System.Drawing.Size(115, 29);
            this.btnPuesto.TabIndex = 65;
            this.btnPuesto.Text = "SELECCIONAR";
            this.btnPuesto.UseVisualStyleBackColor = true;
            this.btnPuesto.Click += new System.EventHandler(this.btnPuesto_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(496, 86);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "OBSERVACIONES";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "MODALIDAD";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(496, 50);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 13);
            this.label15.TabIndex = 49;
            this.label15.Text = "RUTINA";
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
            // txtSueldo
            // 
            this.txtSueldo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSueldo.BorderRadius = 10;
            this.txtSueldo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSueldo.DefaultText = "";
            this.txtSueldo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSueldo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSueldo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSueldo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSueldo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSueldo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSueldo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSueldo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSueldo.Location = new System.Drawing.Point(688, 249);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.PasswordChar = '\0';
            this.txtSueldo.PlaceholderText = "";
            this.txtSueldo.SelectedText = "";
            this.txtSueldo.Size = new System.Drawing.Size(157, 24);
            this.txtSueldo.TabIndex = 40;
            this.txtSueldo.TextChanged += new System.EventHandler(this.txtSueldo_TextChanged);
            // 
            // txtCantiadadHoras
            // 
            this.txtCantiadadHoras.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCantiadadHoras.BorderRadius = 10;
            this.txtCantiadadHoras.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCantiadadHoras.DefaultText = "";
            this.txtCantiadadHoras.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCantiadadHoras.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCantiadadHoras.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCantiadadHoras.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCantiadadHoras.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCantiadadHoras.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCantiadadHoras.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCantiadadHoras.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCantiadadHoras.Location = new System.Drawing.Point(688, 216);
            this.txtCantiadadHoras.Name = "txtCantiadadHoras";
            this.txtCantiadadHoras.PasswordChar = '\0';
            this.txtCantiadadHoras.PlaceholderText = "";
            this.txtCantiadadHoras.SelectedText = "";
            this.txtCantiadadHoras.Size = new System.Drawing.Size(157, 24);
            this.txtCantiadadHoras.TabIndex = 39;
            // 
            // cboEstado
            // 
            this.cboEstado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(666, 119);
            this.cboEstado.Margin = new System.Windows.Forms.Padding(2);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(200, 21);
            this.cboEstado.TabIndex = 32;
            this.cboEstado.Click += new System.EventHandler(this.cboEstado_Click);
            // 
            // txtEdadMaxima
            // 
            this.txtEdadMaxima.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEdadMaxima.BorderRadius = 10;
            this.txtEdadMaxima.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEdadMaxima.DefaultText = "";
            this.txtEdadMaxima.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEdadMaxima.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEdadMaxima.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEdadMaxima.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEdadMaxima.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEdadMaxima.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEdadMaxima.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEdadMaxima.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEdadMaxima.Location = new System.Drawing.Point(196, 183);
            this.txtEdadMaxima.Name = "txtEdadMaxima";
            this.txtEdadMaxima.PasswordChar = '\0';
            this.txtEdadMaxima.PlaceholderText = "";
            this.txtEdadMaxima.SelectedText = "";
            this.txtEdadMaxima.Size = new System.Drawing.Size(199, 24);
            this.txtEdadMaxima.TabIndex = 19;
            // 
            // txtEdadMinima
            // 
            this.txtEdadMinima.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEdadMinima.BorderRadius = 10;
            this.txtEdadMinima.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEdadMinima.DefaultText = "";
            this.txtEdadMinima.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEdadMinima.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEdadMinima.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEdadMinima.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEdadMinima.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEdadMinima.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEdadMinima.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEdadMinima.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEdadMinima.Location = new System.Drawing.Point(196, 152);
            this.txtEdadMinima.Name = "txtEdadMinima";
            this.txtEdadMinima.PasswordChar = '\0';
            this.txtEdadMinima.PlaceholderText = "";
            this.txtEdadMinima.SelectedText = "";
            this.txtEdadMinima.Size = new System.Drawing.Size(199, 24);
            this.txtEdadMinima.TabIndex = 18;
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
            this.label13.Location = new System.Drawing.Point(496, 255);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 43;
            this.label13.Text = "SUELDO";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(496, 222);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(189, 13);
            this.label12.TabIndex = 42;
            this.label12.Text = "CANTIDAD DE HORAS SEMANALES";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(496, 189);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 41;
            this.label11.Text = "HORA FIN";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(496, 158);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "HORA INICIO";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(496, 123);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "ESTADO";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 222);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "FUNCIONES";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "PUESTO";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 189);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "EDAD MAXIMA";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 158);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "EDAD MINIMA";
            // 
            // txtDni
            // 
            this.txtDni.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.txtDni.Location = new System.Drawing.Point(196, 44);
            this.txtDni.Name = "txtDni";
            this.txtDni.PasswordChar = '\0';
            this.txtDni.PlaceholderText = "";
            this.txtDni.SelectedText = "";
            this.txtDni.Size = new System.Drawing.Size(199, 24);
            this.txtDni.TabIndex = 17;
            this.txtDni.TextChanged += new System.EventHandler(this.txtDni_TextChanged);
            // 
            // lblPedidos
            // 
            this.lblPedidos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPedidos.AutoSize = true;
            this.lblPedidos.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedidos.Location = new System.Drawing.Point(356, 13);
            this.lblPedidos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPedidos.Name = "lblPedidos";
            this.lblPedidos.Size = new System.Drawing.Size(208, 23);
            this.lblPedidos.TabIndex = 30;
            this.lblPedidos.Text = "REGISTRO DE PEDIDOS";
            // 
            // FormPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 428);
            this.ControlBox = false;
            this.Controls.Add(this.dgvPedidos);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.lblPedidos);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPedido";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblcodigo;
        private Guna.UI2.WinForms.Guna2TextBox txtSueldo;
        private Guna.UI2.WinForms.Guna2TextBox txtCantiadadHoras;
        private System.Windows.Forms.ComboBox cboEstado;
        private Guna.UI2.WinForms.Guna2TextBox txtEdadMaxima;
        private Guna.UI2.WinForms.Guna2TextBox txtEdadMinima;
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
        private System.Windows.Forms.Label lblPedidos;
        private System.Windows.Forms.Button btnModalidad;
        private System.Windows.Forms.Button btnPuesto;
        private System.Windows.Forms.Button btnRutina;
        private System.Windows.Forms.Button btnFunciones;
        private System.Windows.Forms.Button btnObservaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn columCodPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDniEmpleador;
        private System.Windows.Forms.DataGridViewTextBoxColumn columEdadMinima;
        private System.Windows.Forms.DataGridViewTextBoxColumn columEdadMaxima;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFunciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRutina;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnObservaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHoraFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCantHoras;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSueldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUserId;
        private Guna.UI2.WinForms.Guna2TextBox txtMinutosInicio;
        private Guna.UI2.WinForms.Guna2TextBox txtHoraInicio;
        private Guna.UI2.WinForms.Guna2TextBox txtMinutosFin;
        private Guna.UI2.WinForms.Guna2TextBox txtHoraFin;
    }
}