namespace L1GUI.Forms.Principales
{
    partial class FormBackup
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
            dgvBackup = new DataGridView();
            btnRealizar = new Button();
            btnSalir = new Button();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBackup).BeginInit();
            SuspendLayout();
            // 
            // dgvBackup
            // 
            dgvBackup.AllowUserToAddRows = false;
            dgvBackup.AllowUserToDeleteRows = false;
            dgvBackup.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBackup.Location = new Point(12, 53);
            dgvBackup.Name = "dgvBackup";
            dgvBackup.ReadOnly = true;
            dgvBackup.RowHeadersWidth = 51;
            dgvBackup.Size = new Size(538, 339);
            dgvBackup.TabIndex = 0;
            // 
            // btnRealizar
            // 
            btnRealizar.BackColor = Color.SteelBlue;
            btnRealizar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnRealizar.ForeColor = SystemColors.ButtonHighlight;
            btnRealizar.Location = new Point(12, 455);
            btnRealizar.Name = "btnRealizar";
            btnRealizar.Size = new Size(112, 57);
            btnRealizar.TabIndex = 132;
            btnRealizar.Text = "Realizar backup";
            btnRealizar.UseVisualStyleBackColor = false;
            btnRealizar.Click += btnRealizar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.SteelBlue;
            btnSalir.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnSalir.ForeColor = SystemColors.ButtonHighlight;
            btnSalir.Location = new Point(438, 455);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 57);
            btnSalir.TabIndex = 136;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 9);
            label7.Name = "label7";
            label7.Size = new Size(538, 41);
            label7.TabIndex = 137;
            label7.Text = "Backup";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormBackup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 533);
            Controls.Add(label7);
            Controls.Add(btnSalir);
            Controls.Add(btnRealizar);
            Controls.Add(dgvBackup);
            Name = "FormBackup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Backup";
            Load += FormBackup_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBackup).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvBackup;
        private Button btnRealizar;
        private Button btnSalir;
        private Label label7;
    }
}