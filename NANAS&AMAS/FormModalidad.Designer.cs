namespace NANAS_AMAS
{
    partial class FormModalidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModalidad));
            this.clbModalidad = new System.Windows.Forms.CheckedListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDias = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.clbDias = new System.Windows.Forms.CheckedListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // clbModalidad
            // 
            this.clbModalidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbModalidad.CheckOnClick = true;
            this.clbModalidad.ColumnWidth = 419;
            this.clbModalidad.Dock = System.Windows.Forms.DockStyle.Top;
            this.clbModalidad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbModalidad.FormattingEnabled = true;
            this.clbModalidad.HorizontalScrollbar = true;
            this.clbModalidad.Items.AddRange(new object[] {
            "CAMA AFUERA",
            "CAMA DENTRO",
            "MEDIO TIEMPO MAÑANA",
            "MEDIO TIEMPO TARDE",
            "POR DIAS",
            "TURNO NOCHE"});
            this.clbModalidad.Location = new System.Drawing.Point(0, 96);
            this.clbModalidad.Name = "clbModalidad";
            this.clbModalidad.Size = new System.Drawing.Size(768, 204);
            this.clbModalidad.Sorted = true;
            this.clbModalidad.TabIndex = 28;
            this.clbModalidad.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbPuestos_ItemCheck);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(208)))), ((int)(((byte)(244)))));
            this.panel1.Controls.Add(this.btnDias);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 42);
            this.panel1.TabIndex = 25;
            // 
            // btnDias
            // 
            this.btnDias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDias.BackColor = System.Drawing.Color.Transparent;
            this.btnDias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDias.Image = ((System.Drawing.Image)(resources.GetObject("btnDias.Image")));
            this.btnDias.Location = new System.Drawing.Point(663, 3);
            this.btnDias.Name = "btnDias";
            this.btnDias.Size = new System.Drawing.Size(48, 36);
            this.btnDias.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDias.TabIndex = 10;
            this.btnDias.TabStop = false;
            this.btnDias.Click += new System.EventHandler(this.btnDias_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(717, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 38);
            this.label1.TabIndex = 24;
            this.label1.Text = "MODALIDAD";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(768, 54);
            this.panel2.TabIndex = 27;
            // 
            // clbDias
            // 
            this.clbDias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbDias.CheckOnClick = true;
            this.clbDias.ColumnWidth = 419;
            this.clbDias.Dock = System.Windows.Forms.DockStyle.Top;
            this.clbDias.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbDias.FormattingEnabled = true;
            this.clbDias.HorizontalScrollbar = true;
            this.clbDias.Items.AddRange(new object[] {
            "LUNES",
            "MARTES",
            "MIERCOLES",
            "JUEVES",
            "VIERNES",
            "SABADO",
            "DOMINGO"});
            this.clbDias.Location = new System.Drawing.Point(0, 300);
            this.clbDias.Name = "clbDias";
            this.clbDias.Size = new System.Drawing.Size(768, 204);
            this.clbDias.TabIndex = 29;
            // 
            // FormModalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(768, 335);
            this.Controls.Add(this.clbDias);
            this.Controls.Add(this.clbModalidad);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormModalidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormModalidad";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnDias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.CheckedListBox clbModalidad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.CheckedListBox clbDias;
        public System.Windows.Forms.PictureBox btnDias;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}