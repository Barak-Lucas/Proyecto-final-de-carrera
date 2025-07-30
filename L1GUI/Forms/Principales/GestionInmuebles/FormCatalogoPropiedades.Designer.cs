namespace L1GUI.Forms
{
    partial class FormCatalogoPropiedades
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
            pictureBox = new PictureBox();
            btnBuscar = new Button();
            label12 = new Label();
            label2 = new Label();
            label3 = new Label();
            cmbTipo = new ComboBox();
            label7 = new Label();
            label10 = new Label();
            cmbOrientacion = new ComboBox();
            btnDetalles = new Button();
            cmbLocalidad = new ComboBox();
            btnAgregarInteraccion = new Button();
            cnHasta = new ControlesDeUsuario.CajaNumerica();
            label5 = new Label();
            txtDescripCorta = new TextBox();
            txtValor = new TextBox();
            txtDomicilio = new TextBox();
            btnCambiarPortada = new Button();
            nudAmbientes = new NumericUpDown();
            cnDesde = new ControlesDeUsuario.CajaNumerica();
            label4 = new Label();
            label1 = new Label();
            btnBuscarID = new Button();
            btnReiniciar = new Button();
            lblVendida = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPropiedades).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAmbientes).BeginInit();
            SuspendLayout();
            // 
            // dgvPropiedades
            // 
            dgvPropiedades.AllowUserToAddRows = false;
            dgvPropiedades.AllowUserToDeleteRows = false;
            dgvPropiedades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPropiedades.Location = new Point(17, 68);
            dgvPropiedades.Name = "dgvPropiedades";
            dgvPropiedades.ReadOnly = true;
            dgvPropiedades.RowHeadersWidth = 51;
            dgvPropiedades.Size = new Size(620, 267);
            dgvPropiedades.TabIndex = 0;
            dgvPropiedades.CellClick += dgvPropiedades_CellClick;

            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(710, 68);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(540, 363);
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.SteelBlue;
            btnBuscar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = SystemColors.ButtonFace;
            btnBuscar.Location = new Point(337, 597);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(91, 42);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "Aplicar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label12.Location = new Point(27, 479);
            label12.Name = "label12";
            label12.Size = new Size(86, 23);
            label12.TabIndex = 70;
            label12.Text = "Localidad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.Location = new Point(18, 534);
            label2.Name = "label2";
            label2.Size = new Size(95, 23);
            label2.TabIndex = 61;
            label2.Text = "Ambientes:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.Location = new Point(66, 358);
            label3.Name = "label3";
            label3.Size = new Size(47, 23);
            label3.TabIndex = 59;
            label3.Text = "Tipo:";
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(119, 358);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(257, 28);
            cmbTipo.TabIndex = 1;
            cmbTipo.Text = "Seleccione";
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 9);
            label7.Name = "label7";
            label7.Size = new Size(1238, 41);
            label7.TabIndex = 79;
            label7.Text = "CATÁLOGO";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label10.Location = new Point(10, 418);
            label10.Name = "label10";
            label10.Size = new Size(103, 23);
            label10.TabIndex = 81;
            label10.Text = "Orientación:";
            // 
            // cmbOrientacion
            // 
            cmbOrientacion.FormattingEnabled = true;
            cmbOrientacion.Location = new Point(119, 418);
            cmbOrientacion.Name = "cmbOrientacion";
            cmbOrientacion.Size = new Size(257, 28);
            cmbOrientacion.TabIndex = 2;
            cmbOrientacion.Text = "Seleccione";
            // 
            // btnDetalles
            // 
            btnDetalles.BackColor = Color.SteelBlue;
            btnDetalles.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDetalles.ForeColor = SystemColors.ButtonHighlight;
            btnDetalles.Location = new Point(894, 597);
            btnDetalles.Name = "btnDetalles";
            btnDetalles.Size = new Size(149, 42);
            btnDetalles.TabIndex = 10;
            btnDetalles.Text = "Más detalles";
            btnDetalles.UseVisualStyleBackColor = false;
            btnDetalles.Click += btnDetalles_Click;
            // 
            // cmbLocalidad
            // 
            cmbLocalidad.FormattingEnabled = true;
            cmbLocalidad.Location = new Point(119, 474);
            cmbLocalidad.Name = "cmbLocalidad";
            cmbLocalidad.Size = new Size(257, 28);
            cmbLocalidad.TabIndex = 3;
            cmbLocalidad.Text = "Seleccione";
            // 
            // btnAgregarInteraccion
            // 
            btnAgregarInteraccion.BackColor = Color.SteelBlue;
            btnAgregarInteraccion.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarInteraccion.ForeColor = SystemColors.ButtonFace;
            btnAgregarInteraccion.Location = new Point(1069, 597);
            btnAgregarInteraccion.Name = "btnAgregarInteraccion";
            btnAgregarInteraccion.Size = new Size(181, 42);
            btnAgregarInteraccion.TabIndex = 11;
            btnAgregarInteraccion.Text = "Agregar interacción";
            btnAgregarInteraccion.UseVisualStyleBackColor = false;
            btnAgregarInteraccion.Click += btnAgregarInteraccion_Click;
            // 
            // cnHasta
            // 
            cnHasta.Location = new Point(228, 607);
            cnHasta.MaxLength = 32767;
            cnHasta.Name = "cnHasta";
            cnHasta.Size = new Size(88, 28);
            cnHasta.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Enabled = false;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ActiveBorder;
            label5.Location = new Point(228, 581);
            label5.Name = "label5";
            label5.Size = new Size(54, 23);
            label5.TabIndex = 90;
            label5.Text = "Hasta";
            // 
            // txtDescripCorta
            // 
            txtDescripCorta.Enabled = false;
            txtDescripCorta.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtDescripCorta.Location = new Point(710, 429);
            txtDescripCorta.Multiline = true;
            txtDescripCorta.Name = "txtDescripCorta";
            txtDescripCorta.Size = new Size(540, 76);
            txtDescripCorta.TabIndex = 91;
            // 
            // txtValor
            // 
            txtValor.Enabled = false;
            txtValor.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtValor.Location = new Point(710, 504);
            txtValor.Multiline = true;
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(267, 57);
            txtValor.TabIndex = 92;
            txtValor.TextAlign = HorizontalAlignment.Center;
            // 
            // txtDomicilio
            // 
            txtDomicilio.Enabled = false;
            txtDomicilio.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtDomicilio.Location = new Point(976, 504);
            txtDomicilio.Multiline = true;
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(274, 57);
            txtDomicilio.TabIndex = 93;
            txtDomicilio.TextAlign = HorizontalAlignment.Center;
            // 
            // btnCambiarPortada
            // 
            btnCambiarPortada.BackColor = Color.SteelBlue;
            btnCambiarPortada.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCambiarPortada.ForeColor = SystemColors.ButtonHighlight;
            btnCambiarPortada.Location = new Point(710, 597);
            btnCambiarPortada.Name = "btnCambiarPortada";
            btnCambiarPortada.Size = new Size(149, 42);
            btnCambiarPortada.TabIndex = 9;
            btnCambiarPortada.Text = "Cambiar portada";
            btnCambiarPortada.UseVisualStyleBackColor = false;
            btnCambiarPortada.Click += btnCambiarPortada_Click;
            // 
            // nudAmbientes
            // 
            nudAmbientes.Location = new Point(119, 534);
            nudAmbientes.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudAmbientes.Name = "nudAmbientes";
            nudAmbientes.Size = new Size(120, 27);
            nudAmbientes.TabIndex = 4;
            nudAmbientes.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudAmbientes.Enter += nudAmbientes_Enter;
            // 
            // cnDesde
            // 
            cnDesde.Location = new Point(119, 607);
            cnDesde.MaxLength = 32767;
            cnDesde.Name = "cnDesde";
            cnDesde.Size = new Size(88, 28);
            cnDesde.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Enabled = false;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ActiveBorder;
            label4.Location = new Point(119, 581);
            label4.Name = "label4";
            label4.Size = new Size(62, 23);
            label4.TabIndex = 89;
            label4.Text = "Desde ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label1.Location = new Point(52, 607);
            label1.Name = "label1";
            label1.Size = new Size(61, 23);
            label1.TabIndex = 96;
            label1.Text = "Precio:";
            // 
            // btnBuscarID
            // 
            btnBuscarID.BackColor = Color.SteelBlue;
            btnBuscarID.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarID.ForeColor = SystemColors.ButtonHighlight;
            btnBuscarID.Location = new Point(488, 349);
            btnBuscarID.Name = "btnBuscarID";
            btnBuscarID.Size = new Size(149, 42);
            btnBuscarID.TabIndex = 8;
            btnBuscarID.Text = "Buscar por ID";
            btnBuscarID.UseVisualStyleBackColor = false;
            btnBuscarID.Click += btnBuscarID_Click;
            // 
            // btnReiniciar
            // 
            btnReiniciar.BackColor = Color.SteelBlue;
            btnReiniciar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReiniciar.ForeColor = SystemColors.ButtonHighlight;
            btnReiniciar.Location = new Point(444, 597);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(91, 42);
            btnReiniciar.TabIndex = 97;
            btnReiniciar.Text = "Reiniciar ";
            btnReiniciar.UseVisualStyleBackColor = false;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // lblVendida
            // 
            lblVendida.BackColor = Color.Transparent;
            lblVendida.Font = new Font("Times New Roman", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVendida.ForeColor = Color.Red;
            lblVendida.Location = new Point(710, 228);
            lblVendida.Name = "lblVendida";
            lblVendida.Size = new Size(540, 81);
            lblVendida.TabIndex = 98;
            lblVendida.Text = "VENDIDA";
            lblVendida.TextAlign = ContentAlignment.MiddleCenter;
            lblVendida.Visible = false;
            // 
            // FormCatalogoPropiedades
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(lblVendida);
            Controls.Add(btnReiniciar);
            Controls.Add(btnBuscarID);
            Controls.Add(label1);
            Controls.Add(nudAmbientes);
            Controls.Add(btnCambiarPortada);
            Controls.Add(txtDomicilio);
            Controls.Add(txtValor);
            Controls.Add(txtDescripCorta);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(cnHasta);
            Controls.Add(cnDesde);
            Controls.Add(btnAgregarInteraccion);
            Controls.Add(cmbLocalidad);
            Controls.Add(label10);
            Controls.Add(cmbOrientacion);
            Controls.Add(label7);
            Controls.Add(label12);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(cmbTipo);
            Controls.Add(btnBuscar);
            Controls.Add(btnDetalles);
            Controls.Add(pictureBox);
            Controls.Add(dgvPropiedades);
            Name = "FormCatalogoPropiedades";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCatalogoPropiedades";
            Load += FormCatalogoPropiedades_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPropiedades).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAmbientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPropiedades;
        private PictureBox pictureBox;
        private Button btnBuscar;
        private Label label12;
        private Label label2;
        private Label label3;
        private ComboBox cmbTipo;
        private Label label7;
        private Label label10;
        private ComboBox cmbOrientacion;
        private Button btnDetalles;
        private ComboBox cmbLocalidad;
        private Button btnAgregarInteraccion;
        private ControlesDeUsuario.CajaNumerica cnHasta;
        private Label label5;
        private TextBox txtDescripCorta;
        private TextBox txtValor;
        private TextBox txtDomicilio;
        private Button btnCambiarPortada;
        private NumericUpDown nudAmbientes;
        private ControlesDeUsuario.CajaNumerica cnDesde;
        private Label label4;
        private Label label1;
        private Button btnBuscarID;
        private Button btnReiniciar;
        private Label lblVendida;
    }
}