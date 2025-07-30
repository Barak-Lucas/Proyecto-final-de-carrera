namespace L1GUI.Forms.Principales
{
    partial class FormHistorialInteracciones
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
            btnAlta = new Button();
            cnPropiedadID = new ControlesDeUsuario.CajaNumerica();
            label2 = new Label();
            dgvInteracciones = new DataGridView();
            label7 = new Label();
            txtDetallesDGV = new TextBox();
            txtNombreApellido = new TextBox();
            txtContacto = new TextBox();
            label1 = new Label();
            btnBuscar = new Button();
            label3 = new Label();
            btnModificar = new Button();
            txtDetalles = new TextBox();
            label4 = new Label();
            btnEliminar = new Button();
            label5 = new Label();
            dtPicker = new DateTimePicker();
            label6 = new Label();
            txtDomicilio = new TextBox();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvInteracciones).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAlta
            // 
            btnAlta.BackColor = Color.SteelBlue;
            btnAlta.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnAlta.ForeColor = SystemColors.ButtonHighlight;
            btnAlta.Location = new Point(262, 509);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(166, 47);
            btnAlta.TabIndex = 133;
            btnAlta.Text = "Nueva interacción";
            btnAlta.UseVisualStyleBackColor = false;
            btnAlta.Click += btnAlta_Click;
            // 
            // cnPropiedadID
            // 
            cnPropiedadID.Enabled = false;
            cnPropiedadID.Location = new Point(165, 43);
            cnPropiedadID.MaxLength = 0;
            cnPropiedadID.Name = "cnPropiedadID";
            cnPropiedadID.Size = new Size(91, 30);
            cnPropiedadID.TabIndex = 125;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.Location = new Point(45, 43);
            label2.Name = "label2";
            label2.Size = new Size(114, 23);
            label2.TabIndex = 126;
            label2.Text = "ID propiedad:";
            // 
            // dgvInteracciones
            // 
            dgvInteracciones.AllowUserToAddRows = false;
            dgvInteracciones.AllowUserToDeleteRows = false;
            dgvInteracciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInteracciones.Location = new Point(651, 95);
            dgvInteracciones.Name = "dgvInteracciones";
            dgvInteracciones.ReadOnly = true;
            dgvInteracciones.RowHeadersWidth = 51;
            dgvInteracciones.Size = new Size(599, 349);
            dgvInteracciones.TabIndex = 127;
            dgvInteracciones.CellClick += dgvInteracciones_CellClick;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(17, 9);
            label7.Name = "label7";
            label7.Size = new Size(1193, 41);
            label7.TabIndex = 136;
            label7.Text = "INTERACCIONES";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDetallesDGV
            // 
            txtDetallesDGV.Enabled = false;
            txtDetallesDGV.Location = new Point(651, 441);
            txtDetallesDGV.Multiline = true;
            txtDetallesDGV.Name = "txtDetallesDGV";
            txtDetallesDGV.ReadOnly = true;
            txtDetallesDGV.Size = new Size(599, 129);
            txtDetallesDGV.TabIndex = 137;
            // 
            // txtNombreApellido
            // 
            txtNombreApellido.Location = new Point(165, 161);
            txtNombreApellido.Multiline = true;
            txtNombreApellido.Name = "txtNombreApellido";
            txtNombreApellido.Size = new Size(263, 31);
            txtNombreApellido.TabIndex = 138;
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(165, 218);
            txtContacto.Multiline = true;
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(263, 31);
            txtContacto.TabIndex = 139;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label1.Location = new Point(13, 162);
            label1.Name = "label1";
            label1.Size = new Size(146, 23);
            label1.TabIndex = 140;
            label1.Text = "Nombre/Apellido:";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.SteelBlue;
            btnBuscar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnBuscar.ForeColor = SystemColors.ButtonHighlight;
            btnBuscar.Location = new Point(262, 39);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(98, 40);
            btnBuscar.TabIndex = 141;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.Location = new Point(75, 219);
            label3.Name = "label3";
            label3.Size = new Size(84, 23);
            label3.TabIndex = 142;
            label3.Text = "Contacto:";
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.SteelBlue;
            btnModificar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnModificar.ForeColor = SystemColors.ButtonHighlight;
            btnModificar.Location = new Point(651, 603);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(166, 47);
            btnModificar.TabIndex = 143;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // txtDetalles
            // 
            txtDetalles.Location = new Point(45, 376);
            txtDetalles.Multiline = true;
            txtDetalles.Name = "txtDetalles";
            txtDetalles.Size = new Size(383, 122);
            txtDetalles.TabIndex = 144;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label4.Location = new Point(45, 341);
            label4.Name = "label4";
            label4.Size = new Size(383, 23);
            label4.TabIndex = 145;
            label4.Text = "Detalles de la interacción";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnEliminar.ForeColor = SystemColors.ButtonHighlight;
            btnEliminar.Location = new Point(1084, 603);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(166, 47);
            btnEliminar.TabIndex = 146;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label5.Location = new Point(100, 280);
            label5.Name = "label5";
            label5.Size = new Size(59, 23);
            label5.TabIndex = 148;
            label5.Text = "Fecha:";
            // 
            // dtPicker
            // 
            dtPicker.Format = DateTimePickerFormat.Short;
            dtPicker.Location = new Point(165, 280);
            dtPicker.Name = "dtPicker";
            dtPicker.Size = new Size(263, 27);
            dtPicker.TabIndex = 147;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label6.Location = new Point(74, 104);
            label6.Name = "label6";
            label6.Size = new Size(85, 23);
            label6.TabIndex = 150;
            label6.Text = "Domicilio:";
            // 
            // txtDomicilio
            // 
            txtDomicilio.Enabled = false;
            txtDomicilio.Location = new Point(165, 103);
            txtDomicilio.Multiline = true;
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(263, 31);
            txtDomicilio.TabIndex = 149;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btnAlta);
            groupBox1.Controls.Add(txtDomicilio);
            groupBox1.Controls.Add(txtDetalles);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dtPicker);
            groupBox1.Controls.Add(cnPropiedadID);
            groupBox1.Controls.Add(txtNombreApellido);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtContacto);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(31, 80);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(496, 581);
            groupBox1.TabIndex = 151;
            groupBox1.TabStop = false;
            // 
            // FormHistorialInteracciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(txtDetallesDGV);
            Controls.Add(label7);
            Controls.Add(dgvInteracciones);
            Controls.Add(groupBox1);
            Name = "FormHistorialInteracciones";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormHistorialInteracciones";
            Load += FormHistorialInteracciones_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInteracciones).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAlta;
        private ControlesDeUsuario.CajaNumerica cnPropiedadID;
        private Label label2;
        private DataGridView dgvInteracciones;
        private Label label7;
        private TextBox txtDetallesDGV;
        private TextBox txtNombreApellido;
        private TextBox txtContacto;
        private Label label1;
        private Button btnBuscar;
        private Label label3;
        private Button btnModificar;
        private TextBox txtDetalles;
        private Label label4;
        private Button btnEliminar;
        private Label label5;
        private DateTimePicker dtPicker;
        private Label label6;
        private TextBox txtDomicilio;
        private GroupBox groupBox1;
    }
}