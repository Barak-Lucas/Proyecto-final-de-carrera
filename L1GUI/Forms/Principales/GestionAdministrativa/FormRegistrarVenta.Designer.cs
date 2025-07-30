namespace L1GUI.Forms
{
    partial class FormRegistrarVenta
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
            label7 = new Label();
            cnPropiedadID = new ControlesDeUsuario.CajaNumerica();
            label2 = new Label();
            label4 = new Label();
            cnCompradorID = new ControlesDeUsuario.CajaNumerica();
            cnPrecio = new ControlesDeUsuario.CajaNumerica();
            label8 = new Label();
            btnRegistrarVenta = new Button();
            label9 = new Label();
            dgvHistorialVentas = new DataGridView();
            btnEliminarVenta = new Button();
            dtPicker = new DateTimePicker();
            label10 = new Label();
            btnBuscarPropiedad = new Button();
            btnBuscarProp = new Button();
            txtDomicilio = new TextBox();
            txtLocalidad = new TextBox();
            txtNombre = new TextBox();
            txtDNI = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtPropietario = new TextBox();
            label11 = new Label();
            txtComisionVend = new TextBox();
            txtComisionComp = new TextBox();
            label12 = new Label();
            label13 = new Label();
            btnReimprimir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvHistorialVentas).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 9);
            label7.Name = "label7";
            label7.Size = new Size(1238, 41);
            label7.TabIndex = 68;
            label7.Text = "REGISTRAR VENTA";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cnPropiedadID
            // 
            cnPropiedadID.Enabled = false;
            cnPropiedadID.Location = new Point(214, 104);
            cnPropiedadID.MaxLength = 0;
            cnPropiedadID.Name = "cnPropiedadID";
            cnPropiedadID.Size = new Size(85, 27);
            cnPropiedadID.TabIndex = 98;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.Location = new Point(94, 104);
            label2.Name = "label2";
            label2.Size = new Size(114, 23);
            label2.TabIndex = 99;
            label2.Text = "ID propiedad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label4.Location = new Point(87, 318);
            label4.Name = "label4";
            label4.Size = new Size(121, 23);
            label4.TabIndex = 104;
            label4.Text = "ID comprador:";
            // 
            // cnCompradorID
            // 
            cnCompradorID.Enabled = false;
            cnCompradorID.Location = new Point(214, 318);
            cnCompradorID.MaxLength = 0;
            cnCompradorID.Name = "cnCompradorID";
            cnCompradorID.Size = new Size(85, 27);
            cnCompradorID.TabIndex = 103;
            // 
            // cnPrecio
            // 
            cnPrecio.Location = new Point(214, 468);
            cnPrecio.MaxLength = 0;
            cnPrecio.Name = "cnPrecio";
            cnPrecio.Size = new Size(265, 30);
            cnPrecio.TabIndex = 3;
            cnPrecio.TextChanged += CajaNumericaPrecio_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label8.Location = new Point(12, 468);
            label8.Name = "label8";
            label8.Size = new Size(196, 23);
            label8.TabIndex = 111;
            label8.Text = "Precio convenido (USD):";
            // 
            // btnRegistrarVenta
            // 
            btnRegistrarVenta.BackColor = Color.SteelBlue;
            btnRegistrarVenta.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnRegistrarVenta.ForeColor = SystemColors.ButtonHighlight;
            btnRegistrarVenta.Location = new Point(547, 610);
            btnRegistrarVenta.Name = "btnRegistrarVenta";
            btnRegistrarVenta.Size = new Size(142, 42);
            btnRegistrarVenta.TabIndex = 5;
            btnRegistrarVenta.Text = "Registrar venta";
            btnRegistrarVenta.UseVisualStyleBackColor = false;
            btnRegistrarVenta.Click += btnRegistrarVenta_Click;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label9.Location = new Point(547, 78);
            label9.Name = "label9";
            label9.Size = new Size(703, 23);
            label9.TabIndex = 118;
            label9.Text = "Historial de ventas";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvHistorialVentas
            // 
            dgvHistorialVentas.AllowUserToAddRows = false;
            dgvHistorialVentas.AllowUserToDeleteRows = false;
            dgvHistorialVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorialVentas.Location = new Point(547, 104);
            dgvHistorialVentas.Name = "dgvHistorialVentas";
            dgvHistorialVentas.ReadOnly = true;
            dgvHistorialVentas.RowHeadersWidth = 51;
            dgvHistorialVentas.Size = new Size(703, 326);
            dgvHistorialVentas.TabIndex = 117;
            // 
            // btnEliminarVenta
            // 
            btnEliminarVenta.BackColor = Color.Red;
            btnEliminarVenta.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnEliminarVenta.ForeColor = SystemColors.ButtonHighlight;
            btnEliminarVenta.Location = new Point(1126, 446);
            btnEliminarVenta.Name = "btnEliminarVenta";
            btnEliminarVenta.Size = new Size(124, 42);
            btnEliminarVenta.TabIndex = 121;
            btnEliminarVenta.Text = "Eliminar";
            btnEliminarVenta.UseVisualStyleBackColor = false;
            // 
            // dtPicker
            // 
            dtPicker.Format = DateTimePickerFormat.Short;
            dtPicker.Location = new Point(214, 519);
            dtPicker.Name = "dtPicker";
            dtPicker.Size = new Size(188, 27);
            dtPicker.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label10.Location = new Point(78, 522);
            label10.Name = "label10";
            label10.Size = new Size(131, 23);
            label10.TabIndex = 124;
            label10.Text = "Fecha de venta:";
            // 
            // btnBuscarPropiedad
            // 
            btnBuscarPropiedad.BackColor = Color.SteelBlue;
            btnBuscarPropiedad.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnBuscarPropiedad.ForeColor = SystemColors.ButtonHighlight;
            btnBuscarPropiedad.Location = new Point(317, 314);
            btnBuscarPropiedad.Name = "btnBuscarPropiedad";
            btnBuscarPropiedad.Size = new Size(99, 33);
            btnBuscarPropiedad.TabIndex = 2;
            btnBuscarPropiedad.Text = "Buscar";
            btnBuscarPropiedad.UseVisualStyleBackColor = false;
            btnBuscarPropiedad.Click += btnBuscarPropiedad_Click;
            // 
            // btnBuscarProp
            // 
            btnBuscarProp.BackColor = Color.SteelBlue;
            btnBuscarProp.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnBuscarProp.ForeColor = SystemColors.ButtonHighlight;
            btnBuscarProp.Location = new Point(317, 100);
            btnBuscarProp.Name = "btnBuscarProp";
            btnBuscarProp.Size = new Size(99, 33);
            btnBuscarProp.TabIndex = 1;
            btnBuscarProp.Text = "Buscar";
            btnBuscarProp.UseVisualStyleBackColor = false;
            btnBuscarProp.Click += btnBuscarProp_Click;
            // 
            // txtDomicilio
            // 
            txtDomicilio.Enabled = false;
            txtDomicilio.Location = new Point(214, 155);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(265, 27);
            txtDomicilio.TabIndex = 131;
            // 
            // txtLocalidad
            // 
            txtLocalidad.Enabled = false;
            txtLocalidad.Location = new Point(214, 207);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(265, 27);
            txtLocalidad.TabIndex = 132;
            // 
            // txtNombre
            // 
            txtNombre.Enabled = false;
            txtNombre.Location = new Point(214, 370);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(265, 27);
            txtNombre.TabIndex = 133;
            // 
            // txtDNI
            // 
            txtDNI.Enabled = false;
            txtDNI.Location = new Point(214, 419);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(265, 27);
            txtDNI.TabIndex = 134;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label1.Location = new Point(54, 370);
            label1.Name = "label1";
            label1.Size = new Size(154, 23);
            label1.TabIndex = 135;
            label1.Text = "Nombre completo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.Location = new Point(164, 423);
            label3.Name = "label3";
            label3.Size = new Size(44, 23);
            label3.TabIndex = 136;
            label3.Text = "DNI:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label5.Location = new Point(119, 156);
            label5.Name = "label5";
            label5.Size = new Size(85, 23);
            label5.TabIndex = 137;
            label5.Text = "Domicilio:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label6.Location = new Point(123, 208);
            label6.Name = "label6";
            label6.Size = new Size(86, 23);
            label6.TabIndex = 138;
            label6.Text = "Localidad:";
            // 
            // txtPropietario
            // 
            txtPropietario.Enabled = false;
            txtPropietario.Location = new Point(214, 262);
            txtPropietario.Name = "txtPropietario";
            txtPropietario.Size = new Size(265, 27);
            txtPropietario.TabIndex = 139;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label11.Location = new Point(110, 262);
            label11.Name = "label11";
            label11.Size = new Size(98, 23);
            label11.TabIndex = 140;
            label11.Text = "Propietario:";
            // 
            // txtComisionVend
            // 
            txtComisionVend.Enabled = false;
            txtComisionVend.Location = new Point(31, 619);
            txtComisionVend.Name = "txtComisionVend";
            txtComisionVend.Size = new Size(178, 27);
            txtComisionVend.TabIndex = 141;
            // 
            // txtComisionComp
            // 
            txtComisionComp.Enabled = false;
            txtComisionComp.Location = new Point(285, 619);
            txtComisionComp.Name = "txtComisionComp";
            txtComisionComp.Size = new Size(188, 27);
            txtComisionComp.TabIndex = 142;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label12.Location = new Point(31, 593);
            label12.Name = "label12";
            label12.Size = new Size(177, 23);
            label12.TabIndex = 143;
            label12.Text = "Comision al vendedor";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label13.Location = new Point(285, 593);
            label13.Name = "label13";
            label13.Size = new Size(188, 23);
            label13.TabIndex = 144;
            label13.Text = "Comision al comprador";
            // 
            // btnReimprimir
            // 
            btnReimprimir.BackColor = Color.SteelBlue;
            btnReimprimir.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnReimprimir.ForeColor = SystemColors.ButtonHighlight;
            btnReimprimir.Location = new Point(946, 446);
            btnReimprimir.Name = "btnReimprimir";
            btnReimprimir.Size = new Size(124, 42);
            btnReimprimir.TabIndex = 145;
            btnReimprimir.Text = "Reimprimir ";
            btnReimprimir.UseVisualStyleBackColor = false;
            btnReimprimir.Click += btnReimprimir_Click;
            // 
            // FormRegistrarVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(btnReimprimir);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(txtComisionComp);
            Controls.Add(txtComisionVend);
            Controls.Add(label11);
            Controls.Add(txtPropietario);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtDNI);
            Controls.Add(txtNombre);
            Controls.Add(txtLocalidad);
            Controls.Add(txtDomicilio);
            Controls.Add(btnBuscarPropiedad);
            Controls.Add(btnBuscarProp);
            Controls.Add(label10);
            Controls.Add(dtPicker);
            Controls.Add(btnEliminarVenta);
            Controls.Add(label9);
            Controls.Add(dgvHistorialVentas);
            Controls.Add(btnRegistrarVenta);
            Controls.Add(cnPrecio);
            Controls.Add(label8);
            Controls.Add(cnCompradorID);
            Controls.Add(label4);
            Controls.Add(cnPropiedadID);
            Controls.Add(label2);
            Controls.Add(label7);
            Name = "FormRegistrarVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRegistrarVenta";
            Load += FormRegistrarVenta_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHistorialVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
            //CajaNumericaTextChanged
        }

        #endregion
        private Label label7;
        private ControlesDeUsuario.CajaNumerica cnPropiedadID;
        private Label label2;
        private Label label4;
        private ControlesDeUsuario.CajaNumerica cnCompradorID;
        private ControlesDeUsuario.CajaNumerica cnPrecio;
        private Label label8;
        private Button btnRegistrarVenta;
        private Label label9;
        private DataGridView dgvHistorialVentas;
        private Button btnEliminarVenta;
        private DateTimePicker dtPicker;
        private Label label10;
        private Button btnBuscarPropiedad;
        private Button btnBuscarProp;
        private TextBox txtDomicilio;
        private TextBox txtLocalidad;
        private TextBox txtNombre;
        private TextBox txtDNI;
        private Label label1;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox txtPropietario;
        private Label label11;
        private TextBox txtComisionVend;
        private TextBox txtComisionComp;
        private Label label12;
        private Label label13;
        private Button btnReimprimir;
    }
}