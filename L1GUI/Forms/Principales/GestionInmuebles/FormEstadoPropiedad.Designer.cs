namespace L1GUI.Forms
{
    partial class FormEstadoPropiedad
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
            dgvPropiedades = new DataGridView();
            label14 = new Label();
            cmbUbicacionLlaves = new ComboBox();
            label3 = new Label();
            label7 = new Label();
            label1 = new Label();
            cmbEstadoProp = new ComboBox();
            label2 = new Label();
            txtBuscarDomic = new TextBox();
            label4 = new Label();
            label6 = new Label();
            cnContrato = new ControlesDeUsuario.CajaNumerica();
            lblVence = new Label();
            btnAplicarCambios = new Button();
            pictureBox1 = new PictureBox();
            txtBuscarID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvPropiedades).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvPropiedades
            // 
            dgvPropiedades.AllowUserToAddRows = false;
            dgvPropiedades.AllowUserToDeleteRows = false;
            dgvPropiedades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPropiedades.Location = new Point(499, 185);
            dgvPropiedades.Name = "dgvPropiedades";
            dgvPropiedades.ReadOnly = true;
            dgvPropiedades.RowHeadersWidth = 51;
            dgvPropiedades.Size = new Size(751, 295);
            dgvPropiedades.TabIndex = 93;
            dgvPropiedades.CellClick += dgvPropiedades_CellClick;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label14.Location = new Point(-220, 330);
            label14.Name = "label14";
            label14.Size = new Size(98, 23);
            label14.TabIndex = 92;
            label14.Text = "Propietario:";
            // 
            // cmbUbicacionLlaves
            // 
            cmbUbicacionLlaves.FormattingEnabled = true;
            cmbUbicacionLlaves.Location = new Point(204, 310);
            cmbUbicacionLlaves.Name = "cmbUbicacionLlaves";
            cmbUbicacionLlaves.Size = new Size(244, 28);
            cmbUbicacionLlaves.TabIndex = 95;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.Location = new Point(13, 311);
            label3.Name = "label3";
            label3.Size = new Size(185, 23);
            label3.TabIndex = 96;
            label3.Text = "Ubicación de las llaves:";
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 9);
            label7.Name = "label7";
            label7.Size = new Size(1238, 41);
            label7.TabIndex = 97;
            label7.Text = "ESTADO DE LA PROPIEDAD";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label1.Location = new Point(8, 185);
            label1.Name = "label1";
            label1.Size = new Size(190, 23);
            label1.TabIndex = 100;
            label1.Text = "Estado de la propiedad:";
            // 
            // cmbEstadoProp
            // 
            cmbEstadoProp.FormattingEnabled = true;
            cmbEstadoProp.Location = new Point(204, 185);
            cmbEstadoProp.Name = "cmbEstadoProp";
            cmbEstadoProp.Size = new Size(244, 28);
            cmbEstadoProp.TabIndex = 101;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.Location = new Point(986, 153);
            label2.Name = "label2";
            label2.Size = new Size(117, 23);
            label2.TabIndex = 102;
            label2.Text = "Buscar por ID:";
            // 
            // txtBuscarDomic
            // 
            txtBuscarDomic.Location = new Point(672, 152);
            txtBuscarDomic.Name = "txtBuscarDomic";
            txtBuscarDomic.Size = new Size(241, 27);
            txtBuscarDomic.TabIndex = 103;
            txtBuscarDomic.TextChanged += txtBuscarDomic_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label4.Location = new Point(497, 154);
            label4.Name = "label4";
            label4.Size = new Size(169, 23);
            label4.TabIndex = 105;
            label4.Text = "Buscar por domicilio:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label6.Location = new Point(37, 453);
            label6.Name = "label6";
            label6.Size = new Size(161, 23);
            label6.TabIndex = 110;
            label6.Text = "Contrato vinculado:";
            // 
            // cnContrato
            // 
            cnContrato.Enabled = false;
            cnContrato.Location = new Point(204, 453);
            cnContrato.MaxLength = 32767;
            cnContrato.Name = "cnContrato";
            cnContrato.Size = new Size(78, 27);
            cnContrato.TabIndex = 111;
            // 
            // lblVence
            // 
            lblVence.AutoSize = true;
            lblVence.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblVence.Location = new Point(288, 453);
            lblVence.Name = "lblVence";
            lblVence.Size = new Size(60, 23);
            lblVence.TabIndex = 112;
            lblVence.Text = "Vence:";
            // 
            // btnAplicarCambios
            // 
            btnAplicarCambios.BackColor = Color.SteelBlue;
            btnAplicarCambios.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnAplicarCambios.ForeColor = SystemColors.ButtonHighlight;
            btnAplicarCambios.Location = new Point(204, 563);
            btnAplicarCambios.Name = "btnAplicarCambios";
            btnAplicarCambios.Size = new Size(187, 47);
            btnAplicarCambios.TabIndex = 113;
            btnAplicarCambios.Text = "Aplicar cambios";
            btnAplicarCambios.UseVisualStyleBackColor = false;
            btnAplicarCambios.Click += btnAplicarCambios_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(938, 486);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(312, 175);
            pictureBox1.TabIndex = 114;
            pictureBox1.TabStop = false;
            // 
            // txtBuscarID
            // 
            txtBuscarID.Location = new Point(1109, 152);
            txtBuscarID.Name = "txtBuscarID";
            txtBuscarID.Size = new Size(104, 27);
            txtBuscarID.TabIndex = 115;
            txtBuscarID.TextChanged += txtBuscarID_TextChanged;
            // 
            // FormEstadoPropiedad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(txtBuscarID);
            Controls.Add(pictureBox1);
            Controls.Add(btnAplicarCambios);
            Controls.Add(lblVence);
            Controls.Add(cnContrato);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(txtBuscarDomic);
            Controls.Add(label2);
            Controls.Add(cmbEstadoProp);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(cmbUbicacionLlaves);
            Controls.Add(dgvPropiedades);
            Controls.Add(label14);
            Name = "FormEstadoPropiedad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GestionarPropiedad";
            Load += FormGestionarPropiedad_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPropiedades).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRefrescar;
        private DataGridView dgvPropiedades;
        private Label label14;
        private ComboBox cmbUbicacionLlaves;
        private Label label3;
        private Label label7;
        private Label label1;
        private ComboBox cmbEstadoProp;
        private Label label2;
        private TextBox txtBuscarDomic;
        private Label label4;
        private Label label6;
        private TextBox textBox3;
        private ControlesDeUsuario.CajaNumerica cnContrato;
        private Label lblVence;
        private Button btnAplicarCambios;
        private PictureBox pictureBox1;
        private TextBox txtBuscarID;
    }
}