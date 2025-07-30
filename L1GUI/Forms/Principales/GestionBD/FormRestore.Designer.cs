namespace L1GUI.Forms.Principales
{
    partial class FormRestore
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
            btnSalir = new Button();
            btnRealizar = new Button();
            label1 = new Label();
            tvBackups = new TreeView();
            SuspendLayout();
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 9);
            label7.Name = "label7";
            label7.Size = new Size(538, 41);
            label7.TabIndex = 141;
            label7.Text = "Restore";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.SteelBlue;
            btnSalir.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnSalir.ForeColor = SystemColors.ButtonHighlight;
            btnSalir.Location = new Point(438, 455);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 57);
            btnSalir.TabIndex = 140;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnRealizar
            // 
            btnRealizar.BackColor = Color.SteelBlue;
            btnRealizar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnRealizar.ForeColor = SystemColors.ButtonHighlight;
            btnRealizar.Location = new Point(12, 455);
            btnRealizar.Name = "btnRealizar";
            btnRealizar.Size = new Size(112, 57);
            btnRealizar.TabIndex = 139;
            btnRealizar.Text = "Realizar restore";
            btnRealizar.UseVisualStyleBackColor = false;
            btnRealizar.Click += btnRealizar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 75);
            label1.Name = "label1";
            label1.Size = new Size(296, 20);
            label1.TabIndex = 142;
            label1.Text = "Backups disponibles para realizar el restore";
            // 
            // tvBackups
            // 
            tvBackups.Location = new Point(12, 98);
            tvBackups.Name = "tvBackups";
            tvBackups.Size = new Size(538, 308);
            tvBackups.TabIndex = 143;
            tvBackups.AfterSelect += tvBackups_AfterSelect;
            // 
            // FormRestore
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 533);
            Controls.Add(tvBackups);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(btnSalir);
            Controls.Add(btnRealizar);
            Name = "FormRestore";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRestore";
            Load += FormRestore_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Button btnSalir;
        private Button btnRealizar;
        private Label label1;
        private TreeView tvBackups;
    }
}