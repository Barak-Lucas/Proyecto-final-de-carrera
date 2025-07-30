namespace L1GUI.Forms.Principales
{
    partial class FormBitacora
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
            dgvBitacora = new DataGridView();
            rbSoloBackups = new RadioButton();
            rbSoloRestore = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            lblUsuario = new Label();
            lblID = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBitacora).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 9);
            label7.Name = "label7";
            label7.Size = new Size(538, 41);
            label7.TabIndex = 144;
            label7.Text = "Bitácora";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.SteelBlue;
            btnSalir.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnSalir.ForeColor = SystemColors.ButtonHighlight;
            btnSalir.Location = new Point(373, 19);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(103, 40);
            btnSalir.TabIndex = 143;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // dgvBitacora
            // 
            dgvBitacora.AllowUserToAddRows = false;
            dgvBitacora.AllowUserToDeleteRows = false;
            dgvBitacora.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBitacora.Location = new Point(12, 53);
            dgvBitacora.Name = "dgvBitacora";
            dgvBitacora.ReadOnly = true;
            dgvBitacora.RowHeadersWidth = 51;
            dgvBitacora.Size = new Size(538, 289);
            dgvBitacora.TabIndex = 142;
            dgvBitacora.CellClick += dgvBitacora_CellClick;
            // 
            // rbSoloBackups
            // 
            rbSoloBackups.AutoSize = true;
            rbSoloBackups.Location = new Point(37, 28);
            rbSoloBackups.Name = "rbSoloBackups";
            rbSoloBackups.Size = new Size(118, 24);
            rbSoloBackups.TabIndex = 145;
            rbSoloBackups.TabStop = true;
            rbSoloBackups.Text = "Solo backups";
            rbSoloBackups.UseVisualStyleBackColor = true;
            rbSoloBackups.CheckedChanged += rbSoloBackups_CheckedChanged;
            // 
            // rbSoloRestore
            // 
            rbSoloRestore.AutoSize = true;
            rbSoloRestore.Location = new Point(207, 28);
            rbSoloRestore.Name = "rbSoloRestore";
            rbSoloRestore.Size = new Size(116, 24);
            rbSoloRestore.TabIndex = 146;
            rbSoloRestore.TabStop = true;
            rbSoloRestore.Text = "Solo restores";
            rbSoloRestore.UseVisualStyleBackColor = true;
            rbSoloRestore.CheckedChanged += rbSoloRestore_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbSoloBackups);
            groupBox1.Controls.Add(rbSoloRestore);
            groupBox1.Controls.Add(btnSalir);
            groupBox1.Location = new Point(12, 437);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(538, 71);
            groupBox1.TabIndex = 147;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblUsuario);
            groupBox2.Controls.Add(lblID);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(12, 348);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(538, 95);
            groupBox2.TabIndex = 148;
            groupBox2.TabStop = false;

            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(105, 57);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(0, 20);
            lblUsuario.TabIndex = 3;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(105, 23);
            lblID.Name = "lblID";
            lblID.Size = new Size(0, 20);
            lblID.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 57);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 1;
            label2.Text = "Usuario:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 23);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // FormBitacora
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 533);
            Controls.Add(groupBox2);
            Controls.Add(label7);
            Controls.Add(dgvBitacora);
            Controls.Add(groupBox1);
            Name = "FormBitacora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bitacora";
            Load += FormBitacora_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBitacora).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label7;
        private Button btnSalir;
        private DataGridView dgvBitacora;
        private RadioButton rbSoloBackups;
        private RadioButton rbSoloRestore;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label lblUsuario;
        private Label lblID;
        private Label label2;
        private Label label1;
    }
}