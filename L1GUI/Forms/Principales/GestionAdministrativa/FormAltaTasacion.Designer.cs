namespace L1GUI.Forms.Principales.GestionAdministrativa
{
    partial class FormAltaTasacion
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
            cmbTipo = new ComboBox();
            label6 = new Label();
            label1 = new Label();
            txtNombre = new TextBox();
            cmbLocalidad = new ComboBox();
            label5 = new Label();
            btnBuscarCliente = new Button();
            cnPropietario = new ControlesDeUsuario.CajaNumerica();
            label3 = new Label();
            txtDomicilio = new TextBox();
            label11 = new Label();
            dtPickerH = new DateTimePicker();
            btnAlta = new Button();
            label4 = new Label();
            dtPicker = new DateTimePicker();
            dgvTasaciones = new DataGridView();
            btnModif = new Button();
            btnCancelar = new Button();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTasaciones).BeginInit();
            SuspendLayout();
            // 
            // cmbTipo
            // 
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(156, 381);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(312, 28);
            cmbTipo.TabIndex = 100;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label6.Location = new Point(103, 381);
            label6.Name = "label6";
            label6.Size = new Size(47, 23);
            label6.TabIndex = 111;
            label6.Text = "Tipo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label1.Location = new Point(73, 211);
            label1.Name = "label1";
            label1.Size = new Size(77, 23);
            label1.TabIndex = 110;
            label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(156, 211);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(312, 31);
            txtNombre.TabIndex = 109;
            // 
            // cmbLocalidad
            // 
            cmbLocalidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLocalidad.FormattingEnabled = true;
            cmbLocalidad.Location = new Point(156, 325);
            cmbLocalidad.Name = "cmbLocalidad";
            cmbLocalidad.Size = new Size(312, 28);
            cmbLocalidad.TabIndex = 99;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label5.Location = new Point(64, 326);
            label5.Name = "label5";
            label5.Size = new Size(86, 23);
            label5.TabIndex = 108;
            label5.Text = "Localidad:";
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.BackColor = Color.SteelBlue;
            btnBuscarCliente.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnBuscarCliente.ForeColor = SystemColors.ButtonHighlight;
            btnBuscarCliente.Location = new Point(355, 151);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(113, 33);
            btnBuscarCliente.TabIndex = 97;
            btnBuscarCliente.Text = "Buscar";
            btnBuscarCliente.UseVisualStyleBackColor = false;
            btnBuscarCliente.Click += btnBuscarCliente_Click_1;
            // 
            // cnPropietario
            // 
            cnPropietario.Enabled = false;
            cnPropietario.Location = new Point(156, 154);
            cnPropietario.MaxLength = 0;
            cnPropietario.Name = "cnPropietario";
            cnPropietario.Size = new Size(168, 30);
            cnPropietario.TabIndex = 106;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.Location = new Point(52, 151);
            label3.Name = "label3";
            label3.Size = new Size(98, 23);
            label3.TabIndex = 107;
            label3.Text = "Propietario:";
            // 
            // txtDomicilio
            // 
            txtDomicilio.Location = new Point(156, 262);
            txtDomicilio.Multiline = true;
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(312, 31);
            txtDomicilio.TabIndex = 98;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label11.Location = new Point(8, 263);
            label11.Name = "label11";
            label11.Size = new Size(142, 23);
            label11.TabIndex = 105;
            label11.Text = "Domicilio a tasar:";
            // 
            // dtPickerH
            // 
            dtPickerH.Format = DateTimePickerFormat.Time;
            dtPickerH.Location = new Point(282, 446);
            dtPickerH.Name = "dtPickerH";
            dtPickerH.Size = new Size(99, 27);
            dtPickerH.TabIndex = 102;
            // 
            // btnAlta
            // 
            btnAlta.BackColor = Color.SteelBlue;
            btnAlta.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnAlta.ForeColor = SystemColors.ButtonHighlight;
            btnAlta.Location = new Point(152, 524);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(124, 42);
            btnAlta.TabIndex = 103;
            btnAlta.Text = "Alta";
            btnAlta.UseVisualStyleBackColor = false;
            btnAlta.Click += btnAlta_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label4.Location = new Point(37, 446);
            label4.Name = "label4";
            label4.Size = new Size(113, 23);
            label4.TabIndex = 104;
            label4.Text = "Fecha y hora:";
            // 
            // dtPicker
            // 
            dtPicker.Format = DateTimePickerFormat.Short;
            dtPicker.Location = new Point(156, 446);
            dtPicker.Name = "dtPicker";
            dtPicker.Size = new Size(120, 27);
            dtPicker.TabIndex = 101;
            // 
            // dgvTasaciones
            // 
            dgvTasaciones.AllowUserToAddRows = false;
            dgvTasaciones.AllowUserToDeleteRows = false;
            dgvTasaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTasaciones.Location = new Point(542, 154);
            dgvTasaciones.Name = "dgvTasaciones";
            dgvTasaciones.ReadOnly = true;
            dgvTasaciones.RowHeadersWidth = 51;
            dgvTasaciones.Size = new Size(629, 309);
            dgvTasaciones.TabIndex = 112;
            // 
            // btnModif
            // 
            btnModif.BackColor = Color.SteelBlue;
            btnModif.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnModif.ForeColor = SystemColors.ButtonHighlight;
            btnModif.Location = new Point(851, 480);
            btnModif.Name = "btnModif";
            btnModif.Size = new Size(124, 42);
            btnModif.TabIndex = 113;
            btnModif.Text = "Modificar";
            btnModif.UseVisualStyleBackColor = false;
            btnModif.Click += btnModif_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnCancelar.ForeColor = SystemColors.ButtonHighlight;
            btnCancelar.Location = new Point(1047, 480);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(124, 42);
            btnCancelar.TabIndex = 114;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 9);
            label7.Name = "label7";
            label7.Size = new Size(1159, 41);
            label7.TabIndex = 115;
            label7.Text = "ALTA DE TASACIONES";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormAltaTasacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1183, 596);
            Controls.Add(label7);
            Controls.Add(btnModif);
            Controls.Add(btnCancelar);
            Controls.Add(dgvTasaciones);
            Controls.Add(cmbTipo);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Controls.Add(cmbLocalidad);
            Controls.Add(label5);
            Controls.Add(btnBuscarCliente);
            Controls.Add(cnPropietario);
            Controls.Add(label3);
            Controls.Add(txtDomicilio);
            Controls.Add(label11);
            Controls.Add(dtPickerH);
            Controls.Add(btnAlta);
            Controls.Add(label4);
            Controls.Add(dtPicker);
            Name = "FormAltaTasacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAltaTasacion";
            Load += FormAltaTasacion_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTasaciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbTipo;
        private Label label6;
        private Label label1;
        private TextBox txtNombre;
        private ComboBox cmbLocalidad;
        private Label label5;
        private Button btnBuscarCliente;
        private ControlesDeUsuario.CajaNumerica cnPropietario;
        private Label label3;
        private TextBox txtDomicilio;
        private Label label11;
        private DateTimePicker dtPickerH;
        private Button btnAlta;
        private Label label4;
        private DateTimePicker dtPicker;
        private DataGridView dgvTasaciones;
        private Button btnModif;
        private Button btnCancelar;
        private Label label7;
    }
}