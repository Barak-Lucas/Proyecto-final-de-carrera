namespace L1GUI.Forms
{
    partial class FormContratos
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
            dgvContratos = new DataGridView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnBuscarProp = new Button();
            cnPropietario = new ControlesDeUsuario.CajaNumerica();
            label14 = new Label();
            btnRenovar = new Button();
            btnBaja = new Button();
            btnCrearContrato = new Button();
            label7 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            cnDNI = new ControlesDeUsuario.CajaNumerica();
            label4 = new Label();
            label5 = new Label();
            txtApellido = new TextBox();
            txtNombreConyugue = new TextBox();
            label6 = new Label();
            btnBuscarPropiedad = new Button();
            cnPropiedad = new ControlesDeUsuario.CajaNumerica();
            label8 = new Label();
            rbVigente = new RadioButton();
            rbaRenovar = new RadioButton();
            rbCancelado = new RadioButton();
            label9 = new Label();
            txtDomicilio = new TextBox();
            txtDomicilioVenta = new TextBox();
            label10 = new Label();
            cnPrecio = new ControlesDeUsuario.CajaNumerica();
            label11 = new Label();
            dtPicker = new DateTimePicker();
            rbTodos = new RadioButton();
            label12 = new Label();
            cnDNIconyugue = new ControlesDeUsuario.CajaNumerica();
            label13 = new Label();
            txtEmail = new TextBox();
            btnReimprimir = new Button();
            btnCancelar = new Button();
            label17 = new Label();
            txtBuscarID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvContratos).BeginInit();
            SuspendLayout();
            // 
            // dgvContratos
            // 
            dgvContratos.AllowUserToAddRows = false;
            dgvContratos.AllowUserToDeleteRows = false;
            dgvContratos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContratos.Location = new Point(611, 131);
            dgvContratos.Name = "dgvContratos";
            dgvContratos.ReadOnly = true;
            dgvContratos.RowHeadersWidth = 51;
            dgvContratos.Size = new Size(639, 317);
            dgvContratos.TabIndex = 0;
            // 
            // btnBuscarProp
            // 
            btnBuscarProp.BackColor = Color.SteelBlue;
            btnBuscarProp.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnBuscarProp.ForeColor = SystemColors.ButtonHighlight;
            btnBuscarProp.Location = new Point(278, 106);
            btnBuscarProp.Name = "btnBuscarProp";
            btnBuscarProp.Size = new Size(99, 33);
            btnBuscarProp.TabIndex = 68;
            btnBuscarProp.Text = "Buscar";
            btnBuscarProp.UseVisualStyleBackColor = false;
            btnBuscarProp.Click += btnBuscarProp_Click;
            // 
            // cnPropietario
            // 
            cnPropietario.Enabled = false;
            cnPropietario.Location = new Point(120, 106);
            cnPropietario.MaxLength = 32767;
            cnPropietario.Name = "cnPropietario";
            cnPropietario.Size = new Size(141, 30);
            cnPropietario.TabIndex = 66;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label14.Location = new Point(16, 106);
            label14.Name = "label14";
            label14.Size = new Size(98, 23);
            label14.TabIndex = 67;
            label14.Text = "Propietario:";
            // 
            // btnRenovar
            // 
            btnRenovar.BackColor = Color.SteelBlue;
            btnRenovar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnRenovar.ForeColor = SystemColors.ButtonHighlight;
            btnRenovar.Location = new Point(994, 454);
            btnRenovar.Name = "btnRenovar";
            btnRenovar.Size = new Size(112, 42);
            btnRenovar.TabIndex = 63;
            btnRenovar.Text = "Renovar";
            btnRenovar.UseVisualStyleBackColor = false;
            btnRenovar.Click += btnRenovar_Click;
            // 
            // btnBaja
            // 
            btnBaja.BackColor = Color.Red;
            btnBaja.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnBaja.ForeColor = SystemColors.ButtonHighlight;
            btnBaja.Location = new Point(1138, 523);
            btnBaja.Name = "btnBaja";
            btnBaja.Size = new Size(112, 42);
            btnBaja.TabIndex = 62;
            btnBaja.Text = "Eliminar";
            btnBaja.UseVisualStyleBackColor = false;
            btnBaja.Click += btnBaja_Click;
            // 
            // btnCrearContrato
            // 
            btnCrearContrato.BackColor = Color.SteelBlue;
            btnCrearContrato.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnCrearContrato.ForeColor = SystemColors.ButtonHighlight;
            btnCrearContrato.Location = new Point(731, 616);
            btnCrearContrato.Name = "btnCrearContrato";
            btnCrearContrato.Size = new Size(158, 42);
            btnCrearContrato.TabIndex = 61;
            btnCrearContrato.Text = "Crear contrato";
            btnCrearContrato.UseVisualStyleBackColor = false;
            btnCrearContrato.Click += btnCrearContrato_Click;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 9);
            label7.Name = "label7";
            label7.Size = new Size(1238, 41);
            label7.TabIndex = 74;
            label7.Text = "CONTRATOS";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.Location = new Point(13, 576);
            label2.Name = "label2";
            label2.Size = new Size(158, 23);
            label2.TabIndex = 78;
            label2.Text = "Nombre cónyugue:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.Location = new Point(37, 155);
            label3.Name = "label3";
            label3.Size = new Size(77, 23);
            label3.TabIndex = 80;
            label3.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Enabled = false;
            txtNombre.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtNombre.Location = new Point(120, 155);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(314, 30);
            txtNombre.TabIndex = 79;
            // 
            // cnDNI
            // 
            cnDNI.Enabled = false;
            cnDNI.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            cnDNI.Location = new Point(120, 266);
            cnDNI.Margin = new Padding(4, 3, 4, 3);
            cnDNI.MaxLength = 32767;
            cnDNI.Name = "cnDNI";
            cnDNI.Size = new Size(313, 30);
            cnDNI.TabIndex = 82;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label4.Location = new Point(70, 266);
            label4.Name = "label4";
            label4.Size = new Size(44, 23);
            label4.TabIndex = 84;
            label4.Text = "DNI:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label5.Location = new Point(42, 210);
            label5.Name = "label5";
            label5.Size = new Size(76, 23);
            label5.TabIndex = 83;
            label5.Text = "Apellido:";
            // 
            // txtApellido
            // 
            txtApellido.Enabled = false;
            txtApellido.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtApellido.Location = new Point(120, 210);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(314, 30);
            txtApellido.TabIndex = 81;
            // 
            // txtNombreConyugue
            // 
            txtNombreConyugue.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtNombreConyugue.Location = new Point(177, 573);
            txtNombreConyugue.Name = "txtNombreConyugue";
            txtNombreConyugue.Size = new Size(314, 30);
            txtNombreConyugue.TabIndex = 86;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label6.Location = new Point(46, 626);
            label6.Name = "label6";
            label6.Size = new Size(125, 23);
            label6.TabIndex = 87;
            label6.Text = "DNI cónyugue:";
            // 
            // btnBuscarPropiedad
            // 
            btnBuscarPropiedad.BackColor = Color.SteelBlue;
            btnBuscarPropiedad.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnBuscarPropiedad.ForeColor = SystemColors.ButtonHighlight;
            btnBuscarPropiedad.Location = new Point(335, 413);
            btnBuscarPropiedad.Name = "btnBuscarPropiedad";
            btnBuscarPropiedad.Size = new Size(99, 33);
            btnBuscarPropiedad.TabIndex = 91;
            btnBuscarPropiedad.Text = "Buscar";
            btnBuscarPropiedad.UseVisualStyleBackColor = false;
            btnBuscarPropiedad.Click += btnBuscarPropiedad_Click;
            // 
            // cnPropiedad
            // 
            cnPropiedad.Enabled = false;
            cnPropiedad.Location = new Point(177, 418);
            cnPropiedad.MaxLength = 32767;
            cnPropiedad.Name = "cnPropiedad";
            cnPropiedad.Size = new Size(141, 30);
            cnPropiedad.TabIndex = 89;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label8.Location = new Point(73, 418);
            label8.Name = "label8";
            label8.Size = new Size(88, 23);
            label8.TabIndex = 90;
            label8.Text = "Propiedad";
            // 
            // rbVigente
            // 
            rbVigente.AutoSize = true;
            rbVigente.Location = new Point(687, 462);
            rbVigente.Name = "rbVigente";
            rbVigente.Size = new Size(81, 24);
            rbVigente.TabIndex = 92;
            rbVigente.TabStop = true;
            rbVigente.Text = "Vigente";
            rbVigente.UseVisualStyleBackColor = true;
            rbVigente.CheckedChanged += rbVigente_CheckedChanged;
            // 
            // rbaRenovar
            // 
            rbaRenovar.AutoSize = true;
            rbaRenovar.Location = new Point(774, 462);
            rbaRenovar.Name = "rbaRenovar";
            rbaRenovar.Size = new Size(84, 24);
            rbaRenovar.TabIndex = 93;
            rbaRenovar.TabStop = true;
            rbaRenovar.Text = "Renovar";
            rbaRenovar.UseVisualStyleBackColor = true;
            rbaRenovar.CheckedChanged += rbaRenovar_CheckedChanged;
            // 
            // rbCancelado
            // 
            rbCancelado.AutoSize = true;
            rbCancelado.Location = new Point(864, 462);
            rbCancelado.Name = "rbCancelado";
            rbCancelado.Size = new Size(100, 24);
            rbCancelado.TabIndex = 95;
            rbCancelado.TabStop = true;
            rbCancelado.Text = "Cancelado";
            rbCancelado.UseVisualStyleBackColor = true;
            rbCancelado.CheckedChanged += rbCancelado_CheckedChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label9.Location = new Point(29, 320);
            label9.Name = "label9";
            label9.Size = new Size(85, 23);
            label9.TabIndex = 97;
            label9.Text = "Domicilio:";
            // 
            // txtDomicilio
            // 
            txtDomicilio.Enabled = false;
            txtDomicilio.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtDomicilio.Location = new Point(120, 320);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(314, 30);
            txtDomicilio.TabIndex = 96;
            // 
            // txtDomicilioVenta
            // 
            txtDomicilioVenta.Enabled = false;
            txtDomicilioVenta.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtDomicilioVenta.Location = new Point(177, 472);
            txtDomicilioVenta.Name = "txtDomicilioVenta";
            txtDomicilioVenta.Size = new Size(314, 30);
            txtDomicilioVenta.TabIndex = 99;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label10.Location = new Point(14, 472);
            label10.Name = "label10";
            label10.Size = new Size(157, 23);
            label10.TabIndex = 98;
            label10.Text = "Domicilio de venta:";
            // 
            // cnPrecio
            // 
            cnPrecio.Enabled = false;
            cnPrecio.Location = new Point(177, 523);
            cnPrecio.MaxLength = 32767;
            cnPrecio.Name = "cnPrecio";
            cnPrecio.Size = new Size(314, 30);
            cnPrecio.TabIndex = 100;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label11.Location = new Point(0, 523);
            label11.Name = "label11";
            label11.Size = new Size(171, 23);
            label11.TabIndex = 101;
            label11.Text = "Precio de venta USD:";
            // 
            // dtPicker
            // 
            dtPicker.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            dtPicker.Location = new Point(527, 624);
            dtPicker.Name = "dtPicker";
            dtPicker.Size = new Size(178, 30);
            dtPicker.TabIndex = 104;
            // 
            // rbTodos
            // 
            rbTodos.AutoSize = true;
            rbTodos.Location = new Point(611, 462);
            rbTodos.Name = "rbTodos";
            rbTodos.Size = new Size(70, 24);
            rbTodos.TabIndex = 106;
            rbTodos.TabStop = true;
            rbTodos.Text = "Todos";
            rbTodos.UseVisualStyleBackColor = true;
            rbTodos.CheckedChanged += rbTodos_CheckedChanged;
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label12.Location = new Point(527, 593);
            label12.Name = "label12";
            label12.Size = new Size(178, 23);
            label12.TabIndex = 107;
            label12.Text = "Diferir inicio";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cnDNIconyugue
            // 
            cnDNIconyugue.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            cnDNIconyugue.Location = new Point(177, 626);
            cnDNIconyugue.Margin = new Padding(4, 3, 4, 3);
            cnDNIconyugue.MaxLength = 32767;
            cnDNIconyugue.Name = "cnDNIconyugue";
            cnDNIconyugue.Size = new Size(314, 30);
            cnDNIconyugue.TabIndex = 108;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label13.Location = new Point(59, 366);
            label13.Name = "label13";
            label13.Size = new Size(55, 23);
            label13.TabIndex = 110;
            label13.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Enabled = false;
            txtEmail.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtEmail.Location = new Point(120, 366);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(314, 30);
            txtEmail.TabIndex = 109;
            // 
            // btnReimprimir
            // 
            btnReimprimir.BackColor = Color.SteelBlue;
            btnReimprimir.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnReimprimir.ForeColor = SystemColors.ButtonHighlight;
            btnReimprimir.Location = new Point(1138, 454);
            btnReimprimir.Name = "btnReimprimir";
            btnReimprimir.Size = new Size(112, 42);
            btnReimprimir.TabIndex = 114;
            btnReimprimir.Text = "Reimprimir";
            btnReimprimir.UseVisualStyleBackColor = false;
            btnReimprimir.Click += btnReimprimir_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnCancelar.ForeColor = SystemColors.ButtonHighlight;
            btnCancelar.Location = new Point(994, 523);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 42);
            btnCancelar.TabIndex = 115;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label17.Location = new Point(616, 98);
            label17.Name = "label17";
            label17.Size = new Size(242, 23);
            label17.TabIndex = 121;
            label17.Text = "Buscar por ID de la propiedad:";
            // 
            // txtBuscarID
            // 
            txtBuscarID.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtBuscarID.Location = new Point(864, 95);
            txtBuscarID.Name = "txtBuscarID";
            txtBuscarID.Size = new Size(64, 30);
            txtBuscarID.TabIndex = 123;
            txtBuscarID.TextChanged += txtBuscarID_TextChanged;
            // 
            // FormContratos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(txtBuscarID);
            Controls.Add(label17);
            Controls.Add(btnCancelar);
            Controls.Add(btnReimprimir);
            Controls.Add(label13);
            Controls.Add(txtEmail);
            Controls.Add(cnDNIconyugue);
            Controls.Add(label12);
            Controls.Add(rbTodos);
            Controls.Add(dtPicker);
            Controls.Add(cnPrecio);
            Controls.Add(label11);
            Controls.Add(txtDomicilioVenta);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txtDomicilio);
            Controls.Add(rbCancelado);
            Controls.Add(rbaRenovar);
            Controls.Add(rbVigente);
            Controls.Add(btnBuscarPropiedad);
            Controls.Add(cnPropiedad);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(txtNombreConyugue);
            Controls.Add(cnDNI);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(txtApellido);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(btnBuscarProp);
            Controls.Add(cnPropietario);
            Controls.Add(label14);
            Controls.Add(btnRenovar);
            Controls.Add(btnBaja);
            Controls.Add(btnCrearContrato);
            Controls.Add(dgvContratos);
            Name = "FormContratos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormContratos";
            FormClosed += FormContratos_FormClosed;
            Load += FormContratos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvContratos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvContratos;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnBuscarProp;
        private ControlesDeUsuario.CajaNumerica cnPropietario;
        private Label label14;
        private Button btnRenovar;
        private Button btnBaja;
        private Button btnCrearContrato;
        private Label label7;
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private ControlesDeUsuario.CajaNumerica cnDNI;
        private Label label4;
        private Label label5;
        private TextBox txtApellido;
        private TextBox txtNombreConyugue;
        private Label label6;
        private Button btnBuscarPropiedad;
        private ControlesDeUsuario.CajaNumerica cnPropiedad;
        private Label label8;
        private RadioButton rbVigente;
        private RadioButton rbaRenovar;
        private RadioButton rbCancelado;
        private Label label9;
        private TextBox txtDomicilio;
        private TextBox txtDomicilioVenta;
        private Label label10;
        private ControlesDeUsuario.CajaNumerica cnPrecio;
        private Label label11;
        private DateTimePicker dtPicker;
        private RadioButton rbTodos;
        private Label label12;
        private ControlesDeUsuario.CajaNumerica cnDNIconyugue;
        private Label label13;
        private TextBox txtEmail;
        private Button btnReimprimir;
        private Button btnCancelar;
        private Label label17;
        private TextBox txtBuscarID;
    }
}