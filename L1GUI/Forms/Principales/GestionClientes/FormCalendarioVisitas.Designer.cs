namespace L1GUI.Forms
{
    partial class FormCalendarioVisitas
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
            cnPropiedad = new ControlesDeUsuario.CajaNumerica();
            btnModif = new Button();
            btnCancelarVisita = new Button();
            btnBuscarPropiedad = new Button();
            label7 = new Label();
            label1 = new Label();
            dtPicker = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            btnAlta = new Button();
            cnVisitante = new ControlesDeUsuario.CajaNumerica();
            rbAntigua = new RadioButton();
            rbCercana = new RadioButton();
            dgvVisitas = new DataGridView();
            dtPickerH = new DateTimePicker();
            btnCliente = new Button();
            btnHistorial = new Button();
            label6 = new Label();
            btnVisitaRealizada = new Button();
            lblProximaVisita = new Label();
            label2 = new Label();
            lblPropiedad = new Label();
            lblVisitante = new Label();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvVisitas).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // cnPropiedad
            // 
            cnPropiedad.Enabled = false;
            cnPropiedad.Location = new Point(144, 60);
            cnPropiedad.MaxLength = 32767;
            cnPropiedad.Name = "cnPropiedad";
            cnPropiedad.Size = new Size(140, 30);
            cnPropiedad.TabIndex = 1;
            // 
            // btnModif
            // 
            btnModif.BackColor = Color.SteelBlue;
            btnModif.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnModif.ForeColor = SystemColors.ButtonHighlight;
            btnModif.Location = new Point(1079, 499);
            btnModif.Name = "btnModif";
            btnModif.Size = new Size(140, 42);
            btnModif.TabIndex = 12;
            btnModif.Text = "Modificar";
            btnModif.UseVisualStyleBackColor = false;
            btnModif.Click += btnModif_Click;
            // 
            // btnCancelarVisita
            // 
            btnCancelarVisita.BackColor = Color.Red;
            btnCancelarVisita.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnCancelarVisita.ForeColor = SystemColors.ButtonHighlight;
            btnCancelarVisita.Location = new Point(1079, 575);
            btnCancelarVisita.Name = "btnCancelarVisita";
            btnCancelarVisita.Size = new Size(140, 42);
            btnCancelarVisita.TabIndex = 13;
            btnCancelarVisita.Text = "Cancelar visita";
            btnCancelarVisita.UseVisualStyleBackColor = false;
            btnCancelarVisita.Click += btnCancelarVisita_Click;
            // 
            // btnBuscarPropiedad
            // 
            btnBuscarPropiedad.BackColor = Color.SteelBlue;
            btnBuscarPropiedad.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnBuscarPropiedad.ForeColor = SystemColors.ButtonHighlight;
            btnBuscarPropiedad.Location = new Point(290, 57);
            btnBuscarPropiedad.Name = "btnBuscarPropiedad";
            btnBuscarPropiedad.Size = new Size(107, 33);
            btnBuscarPropiedad.TabIndex = 2;
            btnBuscarPropiedad.Text = "Buscar";
            btnBuscarPropiedad.UseVisualStyleBackColor = false;
            btnBuscarPropiedad.Click += btnBuscarPropiedad_Click;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 9);
            label7.Name = "label7";
            label7.Size = new Size(1238, 41);
            label7.TabIndex = 24;
            label7.Text = "VISITAS";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label1.Location = new Point(46, 60);
            label1.Name = "label1";
            label1.Size = new Size(92, 23);
            label1.TabIndex = 21;
            label1.Text = "Propiedad:";
            // 
            // dtPicker
            // 
            dtPicker.Format = DateTimePickerFormat.Short;
            dtPicker.Location = new Point(144, 156);
            dtPicker.Name = "dtPicker";
            dtPicker.Size = new Size(120, 27);
            dtPicker.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.Location = new Point(71, 222);
            label3.Name = "label3";
            label3.Size = new Size(67, 23);
            label3.TabIndex = 33;
            label3.Text = "Cliente:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label4.Location = new Point(25, 156);
            label4.Name = "label4";
            label4.Size = new Size(113, 23);
            label4.TabIndex = 34;
            label4.Text = "Fecha y hora:";
            // 
            // btnAlta
            // 
            btnAlta.BackColor = Color.SteelBlue;
            btnAlta.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnAlta.ForeColor = SystemColors.ButtonHighlight;
            btnAlta.Location = new Point(71, 350);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(140, 42);
            btnAlta.TabIndex = 9;
            btnAlta.Text = "Nueva visita";
            btnAlta.UseVisualStyleBackColor = false;
            btnAlta.Click += btnAlta_Click;
            // 
            // cnVisitante
            // 
            cnVisitante.Enabled = false;
            cnVisitante.Location = new Point(144, 222);
            cnVisitante.MaxLength = 32767;
            cnVisitante.Name = "cnVisitante";
            cnVisitante.Size = new Size(140, 30);
            cnVisitante.TabIndex = 5;
            // 
            // rbAntigua
            // 
            rbAntigua.AutoSize = true;
            rbAntigua.Location = new Point(743, 499);
            rbAntigua.Name = "rbAntigua";
            rbAntigua.Size = new Size(143, 24);
            rbAntigua.TabIndex = 42;
            rbAntigua.TabStop = true;
            rbAntigua.Text = "Fecha más lejana";
            rbAntigua.UseVisualStyleBackColor = true;
            rbAntigua.CheckedChanged += rbAntigua_CheckedChanged;
            // 
            // rbCercana
            // 
            rbCercana.AutoSize = true;
            rbCercana.Location = new Point(567, 499);
            rbCercana.Name = "rbCercana";
            rbCercana.Size = new Size(154, 24);
            rbCercana.TabIndex = 41;
            rbCercana.TabStop = true;
            rbCercana.Text = "Fecha más cercana";
            rbCercana.UseVisualStyleBackColor = true;
            rbCercana.CheckedChanged += rbCercana_CheckedChanged;
            // 
            // dgvVisitas
            // 
            dgvVisitas.AllowUserToAddRows = false;
            dgvVisitas.AllowUserToDeleteRows = false;
            dgvVisitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVisitas.Location = new Point(567, 143);
            dgvVisitas.Name = "dgvVisitas";
            dgvVisitas.ReadOnly = true;
            dgvVisitas.RowHeadersWidth = 51;
            dgvVisitas.Size = new Size(652, 346);
            dgvVisitas.TabIndex = 46;
            // 
            // dtPickerH
            // 
            dtPickerH.Format = DateTimePickerFormat.Time;
            dtPickerH.Location = new Point(290, 156);
            dtPickerH.Name = "dtPickerH";
            dtPickerH.Size = new Size(107, 27);
            dtPickerH.TabIndex = 4;
            // 
            // btnCliente
            // 
            btnCliente.BackColor = Color.SteelBlue;
            btnCliente.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnCliente.ForeColor = SystemColors.ButtonHighlight;
            btnCliente.Location = new Point(290, 222);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(107, 33);
            btnCliente.TabIndex = 47;
            btnCliente.Text = "Buscar";
            btnCliente.UseVisualStyleBackColor = false;
            btnCliente.Click += btnCliente_Click;
            // 
            // btnHistorial
            // 
            btnHistorial.BackColor = Color.SteelBlue;
            btnHistorial.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnHistorial.ForeColor = SystemColors.ButtonHighlight;
            btnHistorial.Location = new Point(257, 350);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(140, 42);
            btnHistorial.TabIndex = 48;
            btnHistorial.Text = "Historial";
            btnHistorial.UseVisualStyleBackColor = false;
            btnHistorial.Click += btnHistorial_Click;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label6.Location = new Point(567, 117);
            label6.Name = "label6";
            label6.Size = new Size(652, 23);
            label6.TabIndex = 50;
            label6.Text = "VISITAS PENDIENTES";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnVisitaRealizada
            // 
            btnVisitaRealizada.BackColor = Color.SteelBlue;
            btnVisitaRealizada.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnVisitaRealizada.ForeColor = SystemColors.ButtonHighlight;
            btnVisitaRealizada.Location = new Point(918, 499);
            btnVisitaRealizada.Name = "btnVisitaRealizada";
            btnVisitaRealizada.Size = new Size(140, 42);
            btnVisitaRealizada.TabIndex = 53;
            btnVisitaRealizada.Text = "Visita realizada";
            btnVisitaRealizada.UseVisualStyleBackColor = false;
            btnVisitaRealizada.Click += btnVisitaRealizada_Click;
            // 
            // lblProximaVisita
            // 
            lblProximaVisita.AutoSize = true;
            lblProximaVisita.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblProximaVisita.Location = new Point(144, 633);
            lblProximaVisita.Name = "lblProximaVisita";
            lblProximaVisita.Size = new Size(173, 23);
            lblProximaVisita.TabIndex = 54;
            lblProximaVisita.Text = "Sin visitas pendientes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.Location = new Point(26, 632);
            label2.Name = "label2";
            label2.Size = new Size(121, 23);
            label2.TabIndex = 55;
            label2.Text = "Próxima visita:";
            // 
            // lblPropiedad
            // 
            lblPropiedad.AutoSize = true;
            lblPropiedad.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPropiedad.Location = new Point(143, 101);
            lblPropiedad.Name = "lblPropiedad";
            lblPropiedad.Size = new Size(0, 23);
            lblPropiedad.TabIndex = 52;
            // 
            // lblVisitante
            // 
            lblVisitante.AutoSize = true;
            lblVisitante.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVisitante.Location = new Point(143, 258);
            lblVisitante.Name = "lblVisitante";
            lblVisitante.Size = new Size(0, 23);
            lblVisitante.TabIndex = 51;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnHistorial);
            groupBox1.Controls.Add(lblVisitante);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lblPropiedad);
            groupBox1.Controls.Add(dtPicker);
            groupBox1.Controls.Add(btnBuscarPropiedad);
            groupBox1.Controls.Add(cnPropiedad);
            groupBox1.Controls.Add(cnVisitante);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnAlta);
            groupBox1.Controls.Add(btnCliente);
            groupBox1.Controls.Add(dtPickerH);
            groupBox1.Location = new Point(26, 131);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(490, 410);
            groupBox1.TabIndex = 56;
            groupBox1.TabStop = false;
            // 
            // FormCalendarioVisitas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(label2);
            Controls.Add(lblProximaVisita);
            Controls.Add(btnVisitaRealizada);
            Controls.Add(label6);
            Controls.Add(rbAntigua);
            Controls.Add(rbCercana);
            Controls.Add(btnModif);
            Controls.Add(btnCancelarVisita);
            Controls.Add(label7);
            Controls.Add(dgvVisitas);
            Controls.Add(groupBox1);
            Name = "FormCalendarioVisitas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCalendarioVisitas";
            Load += FormCalendarioVisitas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVisitas).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ControlesDeUsuario.CajaNumerica cnPropiedad;
        private Button btnModif;
        private Button btnCancelarVisita;
        private Button btnBuscarPropiedad;
        private Label label7;
        private Label label1;
        private TextBox txtNombre;
        private DateTimePicker dtPicker;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private Button btnAlta;
        private ControlesDeUsuario.CajaNumerica cnVisitante;
        private RadioButton rbAntigua;
        private RadioButton rbCercana;
        private Button btnBuscarCliente;
        private DataGridView dgvVisitas;
        private DateTimePicker dtPickerH;
        private Button btnCliente;
        private Button btnHistorial;
        private Label label6;
        private Button btnVisitaRealizada;
        private Label lblProximaVisita;
        private Label label2;
        private Label lblPropiedad;
        private Label lblVisitante;
        private GroupBox groupBox1;
    }
}