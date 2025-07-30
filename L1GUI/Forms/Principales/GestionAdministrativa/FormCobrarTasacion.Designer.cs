namespace L1GUI.Forms
{
    partial class FormCobrarTasacion
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
            btnHistorial = new Button();
            dgvTasaciones = new DataGridView();
            rbLejana = new RadioButton();
            rbCercana = new RadioButton();
            button1 = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTasaciones).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 19);
            label7.Name = "label7";
            label7.Size = new Size(877, 41);
            label7.TabIndex = 62;
            label7.Text = "COBRO DE TASACIONES";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnHistorial
            // 
            btnHistorial.BackColor = Color.SteelBlue;
            btnHistorial.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnHistorial.ForeColor = SystemColors.ButtonHighlight;
            btnHistorial.Location = new Point(765, 463);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(124, 42);
            btnHistorial.TabIndex = 10;
            btnHistorial.Text = "Reimprimir";
            btnHistorial.UseVisualStyleBackColor = false;
            btnHistorial.Click += btnHistorial_Click;
            // 
            // dgvTasaciones
            // 
            dgvTasaciones.AllowUserToAddRows = false;
            dgvTasaciones.AllowUserToDeleteRows = false;
            dgvTasaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTasaciones.Location = new Point(12, 148);
            dgvTasaciones.Name = "dgvTasaciones";
            dgvTasaciones.ReadOnly = true;
            dgvTasaciones.RowHeadersWidth = 51;
            dgvTasaciones.Size = new Size(877, 309);
            dgvTasaciones.TabIndex = 83;
            // 
            // rbLejana
            // 
            rbLejana.AutoSize = true;
            rbLejana.Location = new Point(249, 472);
            rbLejana.Name = "rbLejana";
            rbLejana.Size = new Size(143, 24);
            rbLejana.TabIndex = 13;
            rbLejana.TabStop = true;
            rbLejana.Text = "Fecha más lejana";
            rbLejana.UseVisualStyleBackColor = true;
            rbLejana.CheckedChanged += rbLejana_CheckedChanged;
            // 
            // rbCercana
            // 
            rbCercana.AutoSize = true;
            rbCercana.Location = new Point(33, 472);
            rbCercana.Name = "rbCercana";
            rbCercana.Size = new Size(154, 24);
            rbCercana.TabIndex = 12;
            rbCercana.TabStop = true;
            rbCercana.Text = "Fecha más cercana";
            rbCercana.UseVisualStyleBackColor = true;
            rbCercana.CheckedChanged += rbCercana_CheckedChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(548, 462);
            button1.Name = "button1";
            button1.Size = new Size(124, 42);
            button1.TabIndex = 8;
            button1.Text = "Cobrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnCobrar_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.Location = new Point(12, 122);
            label2.Name = "label2";
            label2.Size = new Size(877, 23);
            label2.TabIndex = 95;
            label2.Text = "TASACIONES PENDIENTES DE COBRO";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormCobrarTasacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 601);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(btnHistorial);
            Controls.Add(dgvTasaciones);
            Controls.Add(rbLejana);
            Controls.Add(rbCercana);
            Controls.Add(label7);
            Name = "FormCobrarTasacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro de tasaciones";
            Load += FormTasaciones_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTasaciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckBox cnRecordatorio;
        private Label label7;
        private Button btnHistorial;
        private DataGridView dgvTasaciones;
        private RadioButton rbLejana;
        private RadioButton rbCercana;
        private Button button1;
        private Label label2;
    }
}