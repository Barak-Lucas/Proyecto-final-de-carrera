namespace L1GUI.Forms
{
    partial class FormHistorialVisitas
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
            lblVisitas = new Label();
            dgvVisitas = new DataGridView();
            txtComentarios = new TextBox();
            btnEliminar = new Button();
            rbAntigua = new RadioButton();
            rbCercana = new RadioButton();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvVisitas).BeginInit();
            SuspendLayout();
            // 
            // lblVisitas
            // 
            lblVisitas.BackColor = SystemColors.ActiveCaption;
            lblVisitas.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVisitas.Location = new Point(-6, 383);
            lblVisitas.Name = "lblVisitas";
            lblVisitas.Size = new Size(1020, 76);
            lblVisitas.TabIndex = 5;
            lblVisitas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvVisitas
            // 
            dgvVisitas.AllowUserToAddRows = false;
            dgvVisitas.AllowUserToDeleteRows = false;
            dgvVisitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVisitas.Location = new Point(-6, -1);
            dgvVisitas.Name = "dgvVisitas";
            dgvVisitas.ReadOnly = true;
            dgvVisitas.RowHeadersWidth = 51;
            dgvVisitas.Size = new Size(618, 391);
            dgvVisitas.TabIndex = 4;
            dgvVisitas.CellClick += dgvVisitas_CellClick;
            // 
            // txtComentarios
            // 
            txtComentarios.Enabled = false;
            txtComentarios.Location = new Point(611, 43);
            txtComentarios.Multiline = true;
            txtComentarios.Name = "txtComentarios";
            txtComentarios.ReadOnly = true;
            txtComentarios.ScrollBars = ScrollBars.Both;
            txtComentarios.Size = new Size(403, 347);
            txtComentarios.TabIndex = 50;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.SteelBlue;
            btnEliminar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnEliminar.ForeColor = SystemColors.ButtonHighlight;
            btnEliminar.Location = new Point(428, 396);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(184, 42);
            btnEliminar.TabIndex = 51;
            btnEliminar.Text = "Eliminar del historial";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // rbAntigua
            // 
            rbAntigua.AutoSize = true;
            rbAntigua.BackColor = SystemColors.ActiveCaption;
            rbAntigua.Location = new Point(216, 396);
            rbAntigua.Name = "rbAntigua";
            rbAntigua.Size = new Size(117, 24);
            rbAntigua.TabIndex = 53;
            rbAntigua.TabStop = true;
            rbAntigua.Text = "Más antiguas";
            rbAntigua.UseVisualStyleBackColor = false;
            rbAntigua.CheckedChanged += rbAntigua_CheckedChanged;
            // 
            // rbCercana
            // 
            rbCercana.AutoSize = true;
            rbCercana.BackColor = SystemColors.ActiveCaption;
            rbCercana.Location = new Point(21, 396);
            rbCercana.Name = "rbCercana";
            rbCercana.Size = new Size(120, 24);
            rbCercana.TabIndex = 52;
            rbCercana.TabStop = true;
            rbCercana.Text = "Más recientes";
            rbCercana.UseVisualStyleBackColor = false;
            rbCercana.CheckedChanged += rbCercana_CheckedChanged;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label1.Location = new Point(618, 17);
            label1.Name = "label1";
            label1.Size = new Size(381, 23);
            label1.TabIndex = 54;
            label1.Text = "Comentarios";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormHistorialVisitas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 453);
            Controls.Add(label1);
            Controls.Add(rbAntigua);
            Controls.Add(rbCercana);
            Controls.Add(btnEliminar);
            Controls.Add(lblVisitas);
            Controls.Add(dgvVisitas);
            Controls.Add(txtComentarios);
            Name = "FormHistorialVisitas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormHistorialVisitas";
            Load += FormHistorialVisitas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVisitas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblVisitas;
        private DataGridView dgvVisitas;
        private TextBox txtComentarios;
        private Button btnEliminar;
        private RadioButton rbAntigua;
        private RadioButton rbCercana;
        private Label label1;
    }
}