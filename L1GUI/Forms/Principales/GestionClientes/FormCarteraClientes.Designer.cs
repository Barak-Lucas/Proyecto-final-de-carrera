namespace L1GUI.Forms
{
    partial class FormCarteraClientes
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
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtTelefono = new TextBox();
            txtEmail = new TextBox();
            txtDomicilio = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lbltel = new Label();
            label5 = new Label();
            label6 = new Label();
            dgvClientes = new DataGridView();
            label7 = new Label();
            btnAlta = new Button();
            btnBaja = new Button();
            btnModif = new Button();
            cnDNI = new ControlesDeUsuario.CajaNumerica();
            lblClientesCartera = new Label();
            label9 = new Label();
            label1 = new Label();
            label11 = new Label();
            txtBuscarDNI = new TextBox();
            txtBuscarID = new TextBox();
            cbPropietario = new CheckBox();
            rbPropietarios = new RadioButton();
            rbTodos = new RadioButton();
            rbNoProp = new RadioButton();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtNombre.Location = new Point(102, 41);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(314, 30);
            txtNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtApellido.Location = new Point(102, 104);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(314, 30);
            txtApellido.TabIndex = 3;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtTelefono.Location = new Point(102, 221);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(314, 30);
            txtTelefono.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtEmail.Location = new Point(102, 277);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(314, 30);
            txtEmail.TabIndex = 6;
            // 
            // txtDomicilio
            // 
            txtDomicilio.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtDomicilio.Location = new Point(102, 340);
            txtDomicilio.Multiline = true;
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(314, 33);
            txtDomicilio.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.Location = new Point(19, 41);
            label2.Name = "label2";
            label2.Size = new Size(77, 23);
            label2.TabIndex = 8;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.Location = new Point(24, 104);
            label3.Name = "label3";
            label3.Size = new Size(76, 23);
            label3.TabIndex = 9;
            label3.Text = "Apellido:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label4.Location = new Point(52, 162);
            label4.Name = "label4";
            label4.Size = new Size(44, 23);
            label4.TabIndex = 10;
            label4.Text = "DNI:";
            // 
            // lbltel
            // 
            lbltel.AutoSize = true;
            lbltel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lbltel.Location = new Point(17, 221);
            lbltel.Name = "lbltel";
            lbltel.Size = new Size(79, 23);
            lbltel.TabIndex = 11;
            lbltel.Text = "Teléfono:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label5.Location = new Point(34, 277);
            label5.Name = "label5";
            label5.Size = new Size(62, 23);
            label5.TabIndex = 12;
            label5.Text = "E-mail:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label6.Location = new Point(11, 340);
            label6.Name = "label6";
            label6.Size = new Size(85, 23);
            label6.TabIndex = 13;
            label6.Text = "Domicilio:";
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(522, 118);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new Size(728, 359);
            dgvClientes.TabIndex = 10;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 9);
            label7.Name = "label7";
            label7.Size = new Size(1238, 41);
            label7.TabIndex = 15;
            label7.Text = "CLIENTES";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAlta
            // 
            btnAlta.BackColor = Color.SteelBlue;
            btnAlta.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnAlta.ForeColor = SystemColors.ButtonHighlight;
            btnAlta.Location = new Point(292, 399);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(124, 42);
            btnAlta.TabIndex = 9;
            btnAlta.Text = "Alta";
            btnAlta.UseVisualStyleBackColor = false;
            btnAlta.Click += btnAlta_Click;
            // 
            // btnBaja
            // 
            btnBaja.BackColor = Color.Red;
            btnBaja.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnBaja.ForeColor = SystemColors.ButtonHighlight;
            btnBaja.Location = new Point(1126, 491);
            btnBaja.Name = "btnBaja";
            btnBaja.Size = new Size(124, 42);
            btnBaja.TabIndex = 12;
            btnBaja.Text = "Baja";
            btnBaja.UseVisualStyleBackColor = false;
            btnBaja.Click += btnBaja_Click;
            // 
            // btnModif
            // 
            btnModif.BackColor = Color.SteelBlue;
            btnModif.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnModif.ForeColor = SystemColors.ButtonHighlight;
            btnModif.Location = new Point(967, 491);
            btnModif.Name = "btnModif";
            btnModif.Size = new Size(124, 42);
            btnModif.TabIndex = 10;
            btnModif.Text = "Modificar";
            btnModif.UseVisualStyleBackColor = false;
            btnModif.Click += btnModif_Click;
            // 
            // cnDNI
            // 
            cnDNI.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cnDNI.Location = new Point(102, 162);
            cnDNI.Margin = new Padding(4, 3, 4, 3);
            cnDNI.MaxLength = 32767;
            cnDNI.Name = "cnDNI";
            cnDNI.Size = new Size(314, 30);
            cnDNI.TabIndex = 4;
            // 
            // lblClientesCartera
            // 
            lblClientesCartera.AutoSize = true;
            lblClientesCartera.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblClientesCartera.Location = new Point(1194, 90);
            lblClientesCartera.Name = "lblClientesCartera";
            lblClientesCartera.Size = new Size(19, 23);
            lblClientesCartera.TabIndex = 16;
            lblClientesCartera.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label9.Location = new Point(521, 89);
            label9.Name = "label9";
            label9.Size = new Size(130, 23);
            label9.TabIndex = 40;
            label9.Text = "Buscar por DNI:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label1.Location = new Point(850, 89);
            label1.Name = "label1";
            label1.Size = new Size(61, 23);
            label1.TabIndex = 44;
            label1.Text = "Por ID:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label11.Location = new Point(1041, 89);
            label11.Name = "label11";
            label11.Size = new Size(156, 23);
            label11.TabIndex = 53;
            label11.Text = "Clientes en cartera:";
            // 
            // txtBuscarDNI
            // 
            txtBuscarDNI.Font = new Font("Segoe UI", 9F);
            txtBuscarDNI.Location = new Point(657, 89);
            txtBuscarDNI.Multiline = true;
            txtBuscarDNI.Name = "txtBuscarDNI";
            txtBuscarDNI.Size = new Size(170, 23);
            txtBuscarDNI.TabIndex = 54;
            txtBuscarDNI.TextChanged += txtBuscarDNI_TextChanged;
            // 
            // txtBuscarID
            // 
            txtBuscarID.Font = new Font("Segoe UI", 9F);
            txtBuscarID.Location = new Point(917, 89);
            txtBuscarID.Multiline = true;
            txtBuscarID.Name = "txtBuscarID";
            txtBuscarID.Size = new Size(72, 23);
            txtBuscarID.TabIndex = 55;
            txtBuscarID.TextChanged += txtBuscarID_TextChanged;
            // 
            // cbPropietario
            // 
            cbPropietario.AutoSize = true;
            cbPropietario.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbPropietario.Location = new Point(102, 408);
            cbPropietario.Name = "cbPropietario";
            cbPropietario.Size = new Size(137, 27);
            cbPropietario.TabIndex = 8;
            cbPropietario.Text = "Es propietario";
            cbPropietario.UseVisualStyleBackColor = true;
            // 
            // rbPropietarios
            // 
            rbPropietarios.AutoSize = true;
            rbPropietarios.Location = new Point(700, 501);
            rbPropietarios.Name = "rbPropietarios";
            rbPropietarios.Size = new Size(110, 24);
            rbPropietarios.TabIndex = 57;
            rbPropietarios.TabStop = true;
            rbPropietarios.Text = "Propietarios";
            rbPropietarios.UseVisualStyleBackColor = true;
            rbPropietarios.CheckedChanged += rbPropietarios_CheckedChanged;
            // 
            // rbTodos
            // 
            rbTodos.AutoSize = true;
            rbTodos.Location = new Point(850, 501);
            rbTodos.Name = "rbTodos";
            rbTodos.Size = new Size(70, 24);
            rbTodos.TabIndex = 59;
            rbTodos.TabStop = true;
            rbTodos.Text = "Todos";
            rbTodos.UseVisualStyleBackColor = true;
            rbTodos.CheckedChanged += rbTodos_CheckedChanged;
            // 
            // rbNoProp
            // 
            rbNoProp.AutoSize = true;
            rbNoProp.Location = new Point(531, 501);
            rbNoProp.Name = "rbNoProp";
            rbNoProp.Size = new Size(135, 24);
            rbNoProp.TabIndex = 60;
            rbNoProp.TabStop = true;
            rbNoProp.Text = "No propietarios";
            rbNoProp.UseVisualStyleBackColor = true;
            rbNoProp.CheckedChanged += rbNoProp_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(cbPropietario);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtDomicilio);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lbltel);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cnDNI);
            groupBox1.Controls.Add(btnAlta);
            groupBox1.Location = new Point(12, 75);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(444, 479);
            groupBox1.TabIndex = 61;
            groupBox1.TabStop = false;
            // 
            // FormCarteraClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(rbNoProp);
            Controls.Add(rbTodos);
            Controls.Add(rbPropietarios);
            Controls.Add(txtBuscarID);
            Controls.Add(txtBuscarDNI);
            Controls.Add(label11);
            Controls.Add(label1);
            Controls.Add(label9);
            Controls.Add(lblClientesCartera);
            Controls.Add(btnModif);
            Controls.Add(btnBaja);
            Controls.Add(label7);
            Controls.Add(dgvClientes);
            Controls.Add(groupBox1);
            Name = "FormCarteraClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            FormClosed += FormCarteraClientes_FormClosed;
            Load += FormCarteraClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtTelefono;
        private TextBox txtEmail;
        private TextBox txtDomicilio;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lbltel;
        private Label label5;
        private Label label6;
        private DataGridView dgvClientes;
        private Label label7;
        private Button btnAlta;
        private Button btnBaja;
        private Button btnModif;
        private ControlesDeUsuario.CajaNumerica cnDNI;
        private Label lblClientesCartera;
        private Label label9;
        private Label label1;
        private Label lblVisitaProgramada;
        private Label label8;
        private Label label11;
        private TextBox txtBuscarDNI;
        private TextBox txtBuscarID;
        private CheckBox cbPropietario;
        private RadioButton rbPropietarios;
        private RadioButton radioButton1;
        private RadioButton rbTodos;
        private RadioButton rbNoProp;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Button button1;
    }
}