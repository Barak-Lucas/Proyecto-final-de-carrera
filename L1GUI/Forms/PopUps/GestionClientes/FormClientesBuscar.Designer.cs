namespace L1GUI.Forms
{
    partial class FormClientesBuscar
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
            btnNuevoPropietario = new Button();
            label9 = new Label();
            lblContratos = new Label();
            dgvClientes = new DataGridView();
            txtBuscarDNI = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // btnNuevoPropietario
            // 
            btnNuevoPropietario.BackColor = Color.DarkGoldenrod;
            btnNuevoPropietario.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnNuevoPropietario.ForeColor = SystemColors.ButtonHighlight;
            btnNuevoPropietario.Location = new Point(332, 399);
            btnNuevoPropietario.Name = "btnNuevoPropietario";
            btnNuevoPropietario.Size = new Size(140, 37);
            btnNuevoPropietario.TabIndex = 47;
            btnNuevoPropietario.Text = "Nuevo cliente";
            btnNuevoPropietario.UseVisualStyleBackColor = false;
            btnNuevoPropietario.Click += btnNuevoPropietario_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Tan;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label9.Location = new Point(15, 404);
            label9.Name = "label9";
            label9.Size = new Size(130, 23);
            label9.TabIndex = 46;
            label9.Text = "Buscar por DNI:";
            // 
            // lblContratos
            // 
            lblContratos.BackColor = Color.Tan;
            lblContratos.Enabled = false;
            lblContratos.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContratos.Location = new Point(-9, 374);
            lblContratos.Name = "lblContratos";
            lblContratos.Size = new Size(793, 79);
            lblContratos.TabIndex = 44;
            lblContratos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(-2, -4);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new Size(786, 385);
            dgvClientes.TabIndex = 43;
            dgvClientes.CellDoubleClick += dgvClientes_CellDoubleClick;
            // 
            // txtBuscarDNI
            // 
            txtBuscarDNI.Location = new Point(151, 404);
            txtBuscarDNI.Name = "txtBuscarDNI";
            txtBuscarDNI.Size = new Size(125, 27);
            txtBuscarDNI.TabIndex = 48;
            txtBuscarDNI.TextChanged += txtBuscarDNI_TextChanged;
            // 
            // FormClientesBuscar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(txtBuscarDNI);
            Controls.Add(btnNuevoPropietario);
            Controls.Add(label9);
            Controls.Add(lblContratos);
            Controls.Add(dgvClientes);
            Name = "FormClientesBuscar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormClientesBuscar";
            Load += FormClientesBuscar_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNuevoPropietario;
        private Label label9;
        private Label lblContratos;
        private DataGridView dgvClientes;
        private TextBox txtBuscarDNI;
    }
}