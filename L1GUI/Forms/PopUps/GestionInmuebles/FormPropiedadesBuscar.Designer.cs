namespace L1GUI.Forms
{
    partial class FormPropiedadesBuscar
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
            lblPropiedades = new Label();
            dgvPropiedades = new DataGridView();
            btnNuevaPropiedad = new Button();
            label9 = new Label();
            label1 = new Label();
            txtBuscarDomicilio = new TextBox();
            txtBuscarID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvPropiedades).BeginInit();
            SuspendLayout();
            // 
            // lblPropiedades
            // 
            lblPropiedades.BackColor = Color.LightSalmon;
            lblPropiedades.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPropiedades.Location = new Point(-6, 377);
            lblPropiedades.Name = "lblPropiedades";
            lblPropiedades.Size = new Size(793, 76);
            lblPropiedades.TabIndex = 3;
            lblPropiedades.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvPropiedades
            // 
            dgvPropiedades.AllowUserToAddRows = false;
            dgvPropiedades.AllowUserToDeleteRows = false;
            dgvPropiedades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPropiedades.Location = new Point(-6, -4);
            dgvPropiedades.Name = "dgvPropiedades";
            dgvPropiedades.ReadOnly = true;
            dgvPropiedades.RowHeadersWidth = 51;
            dgvPropiedades.Size = new Size(793, 386);
            dgvPropiedades.TabIndex = 2;
            dgvPropiedades.CellDoubleClick += dgvPropiedades_CellDoubleClick;
            // 
            // btnNuevaPropiedad
            // 
            btnNuevaPropiedad.BackColor = SystemColors.ControlDark;
            btnNuevaPropiedad.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnNuevaPropiedad.ForeColor = SystemColors.ButtonHighlight;
            btnNuevaPropiedad.Location = new Point(601, 404);
            btnNuevaPropiedad.Name = "btnNuevaPropiedad";
            btnNuevaPropiedad.Size = new Size(169, 37);
            btnNuevaPropiedad.TabIndex = 46;
            btnNuevaPropiedad.Text = "Nueva propiedad";
            btnNuevaPropiedad.UseVisualStyleBackColor = false;
            btnNuevaPropiedad.Click += btnNuevaPropiedad_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.LightSalmon;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label9.Location = new Point(12, 412);
            label9.Name = "label9";
            label9.Size = new Size(117, 23);
            label9.TabIndex = 45;
            label9.Text = "Buscar por ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightSalmon;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label1.Location = new Point(278, 411);
            label1.Name = "label1";
            label1.Size = new Size(85, 23);
            label1.TabIndex = 48;
            label1.Text = "Domicilio:";
            // 
            // txtBuscarDomicilio
            // 
            txtBuscarDomicilio.Location = new Point(369, 410);
            txtBuscarDomicilio.Multiline = true;
            txtBuscarDomicilio.Name = "txtBuscarDomicilio";
            txtBuscarDomicilio.Size = new Size(180, 30);
            txtBuscarDomicilio.TabIndex = 49;
            txtBuscarDomicilio.TextChanged += txtBuscarDomicilio_TextChanged;
            // 
            // txtBuscarDNI
            // 
            txtBuscarID.Location = new Point(135, 411);
            txtBuscarID.Multiline = true;
            txtBuscarID.Name = "txtBuscarDNI";
            txtBuscarID.Size = new Size(111, 30);
            txtBuscarID.TabIndex = 50;
            txtBuscarID.TextChanged += txtBuscarID_TextChanged;
            // 
            // FormPropiedadesBuscar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(txtBuscarID);
            Controls.Add(txtBuscarDomicilio);
            Controls.Add(label1);
            Controls.Add(btnNuevaPropiedad);
            Controls.Add(label9);
            Controls.Add(lblPropiedades);
            Controls.Add(dgvPropiedades);
            Name = "FormPropiedadesBuscar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPopiedadBuscar";
            Load += FormPopiedadBuscar_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPropiedades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPropiedades;
        private DataGridView dgvPropiedades;
        private Button btnNuevaPropiedad;
        private ControlesDeUsuario.CajaNumerica cnBuscarDNI;
        private Label label9;
        private Label label1;
        private TextBox txtBuscarDomicilio;
        private TextBox txtBuscarID;
    }
}