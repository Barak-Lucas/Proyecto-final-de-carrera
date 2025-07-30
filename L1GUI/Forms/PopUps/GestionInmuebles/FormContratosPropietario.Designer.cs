namespace L1GUI.Forms
{
    partial class FormContratosPropietario
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
            dgvContratos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvContratos).BeginInit();
            SuspendLayout();
            // 
            // lblContratos
            // 
            lblContratos.BackColor = SystemColors.ActiveCaption;
            lblContratos.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContratos.Location = new Point(-3, 378);
            lblContratos.Name = "lblContratos";
            lblContratos.Size = new Size(786, 76);
            lblContratos.TabIndex = 3;
            lblContratos.Text = "contratos";
            lblContratos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvContratos
            // 
            dgvContratos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContratos.Location = new Point(-3, -4);
            dgvContratos.Name = "dgvContratos";
            dgvContratos.RowHeadersWidth = 51;
            dgvContratos.Size = new Size(786, 389);
            dgvContratos.TabIndex = 2;
            // 
            // FormContratosPropietario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(lblContratos);
            Controls.Add(dgvContratos);
            Name = "FormContratosPropietario";
            Text = "FormContratosPropietario";
            Load += FormContratosPropietario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvContratos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblContratos;
        private DataGridView dgvContratos;
    }
}