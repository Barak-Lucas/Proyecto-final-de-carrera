namespace L1GUI.Forms
{
    partial class FormPropietariosBuscar
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
            lblContratos = new Label();
            dgvPropietarios = new DataGridView();
            label9 = new Label();
            btnNuevoPropietario = new Button();
            txtBuscarDNI = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvPropietarios).BeginInit();
            SuspendLayout();
            // 
            // lblContratos
            // 
            lblContratos.BackColor = SystemColors.ActiveCaption;
            lblContratos.Enabled = false;
            lblContratos.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContratos.Location = new Point(-6, 376);
            lblContratos.Name = "lblContratos";
            lblContratos.Size = new Size(793, 79);
            lblContratos.TabIndex = 5;
            lblContratos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvPropietarios
            // 
            dgvPropietarios.AllowUserToAddRows = false;
            dgvPropietarios.AllowUserToDeleteRows = false;
            dgvPropietarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPropietarios.Location = new Point(1, -2);
            dgvPropietarios.Name = "dgvPropietarios";
            dgvPropietarios.ReadOnly = true;
            dgvPropietarios.RowHeadersWidth = 51;
            dgvPropietarios.Size = new Size(786, 384);
            dgvPropietarios.TabIndex = 4;
            dgvPropietarios.CellDoubleClick += dgvPropietarios_CellDoubleClick;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ActiveCaption;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label9.Location = new Point(18, 406);
            label9.Name = "label9";
            label9.Size = new Size(130, 23);
            label9.TabIndex = 41;
            label9.Text = "Buscar por DNI:";
            // 
            // btnNuevoPropietario
            // 
            btnNuevoPropietario.BackColor = Color.SteelBlue;
            btnNuevoPropietario.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnNuevoPropietario.ForeColor = SystemColors.ButtonHighlight;
            btnNuevoPropietario.Location = new Point(335, 401);
            btnNuevoPropietario.Name = "btnNuevoPropietario";
            btnNuevoPropietario.Size = new Size(176, 37);
            btnNuevoPropietario.TabIndex = 42;
            btnNuevoPropietario.Text = "Nuevo propietario";
            btnNuevoPropietario.UseVisualStyleBackColor = false;
            btnNuevoPropietario.Click += btnNuevoPropietario_Click;
            // 
            // txtBuscarDNI
            // 
            txtBuscarDNI.Location = new Point(154, 405);
            txtBuscarDNI.Name = "txtBuscarDNI";
            txtBuscarDNI.Size = new Size(125, 27);
            txtBuscarDNI.TabIndex = 43;
            txtBuscarDNI.TextChanged += txtBuscarDNI_TextChanged;
            // 
            // FormPropietariosBuscar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 457);
            Controls.Add(txtBuscarDNI);
            Controls.Add(btnNuevoPropietario);
            Controls.Add(label9);
            Controls.Add(lblContratos);
            Controls.Add(dgvPropietarios);
            Name = "FormPropietariosBuscar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPropietariosBuscar";
            Load += FormPropietariosBuscar_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPropietarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblContratos;
        private DataGridView dgvPropietarios;
        private Label label9;
        private Button btnNuevoPropietario;
        private TextBox txtBuscarDNI;
    }
}