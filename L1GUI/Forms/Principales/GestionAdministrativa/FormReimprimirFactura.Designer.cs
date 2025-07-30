namespace L1GUI.Forms.PopUps
{
    partial class FormReimprimirFactura
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
            rbAntigua = new RadioButton();
            rbReciente = new RadioButton();
            btnEliminar = new Button();
            lblVisitas = new Label();
            dgvTasaciones = new DataGridView();
            rbCobradas = new RadioButton();
            rbCanceladas = new RadioButton();
            rbValorInmuebleASC = new RadioButton();
            rbValorInmuebleDESC = new RadioButton();
            btnReimprimir = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTasaciones).BeginInit();
            SuspendLayout();
            // 
            // rbAntigua
            // 
            rbAntigua.AutoSize = true;
            rbAntigua.BackColor = SystemColors.ActiveCaption;
            rbAntigua.Location = new Point(245, 505);
            rbAntigua.Name = "rbAntigua";
            rbAntigua.Size = new Size(117, 24);
            rbAntigua.TabIndex = 60;
            rbAntigua.TabStop = true;
            rbAntigua.Text = "Más antiguas";
            rbAntigua.UseVisualStyleBackColor = false;
            rbAntigua.CheckedChanged += rbAntigua_CheckedChanged;
            // 
            // rbReciente
            // 
            rbReciente.AutoSize = true;
            rbReciente.BackColor = SystemColors.ActiveCaption;
            rbReciente.Location = new Point(12, 505);
            rbReciente.Name = "rbReciente";
            rbReciente.Size = new Size(120, 24);
            rbReciente.TabIndex = 59;
            rbReciente.TabStop = true;
            rbReciente.Text = "Más recientes";
            rbReciente.UseVisualStyleBackColor = false;
            rbReciente.CheckedChanged += rbReciente_CheckedChanged;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.SteelBlue;
            btnEliminar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnEliminar.ForeColor = SystemColors.ButtonHighlight;
            btnEliminar.Location = new Point(742, 455);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(118, 42);
            btnEliminar.TabIndex = 58;
            btnEliminar.Text = "Eliminar ";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lblVisitas
            // 
            lblVisitas.BackColor = SystemColors.ActiveCaption;
            lblVisitas.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVisitas.Location = new Point(-1, 430);
            lblVisitas.Name = "lblVisitas";
            lblVisitas.Size = new Size(1091, 178);
            lblVisitas.TabIndex = 57;
            lblVisitas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvTasaciones
            // 
            dgvTasaciones.AllowUserToAddRows = false;
            dgvTasaciones.AllowUserToDeleteRows = false;
            dgvTasaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTasaciones.Location = new Point(-1, 0);
            dgvTasaciones.Name = "dgvTasaciones";
            dgvTasaciones.ReadOnly = true;
            dgvTasaciones.RowHeadersWidth = 51;
            dgvTasaciones.Size = new Size(1091, 439);
            dgvTasaciones.TabIndex = 56;
            // 
            // rbCobradas
            // 
            rbCobradas.AutoSize = true;
            rbCobradas.BackColor = SystemColors.ActiveCaption;
            rbCobradas.Location = new Point(245, 555);
            rbCobradas.Name = "rbCobradas";
            rbCobradas.Size = new Size(93, 24);
            rbCobradas.TabIndex = 62;
            rbCobradas.TabStop = true;
            rbCobradas.Text = "Cobradas";
            rbCobradas.UseVisualStyleBackColor = false;
            rbCobradas.CheckedChanged += rbCobradas_CheckedChanged;
            // 
            // rbCanceladas
            // 
            rbCanceladas.AutoSize = true;
            rbCanceladas.BackColor = SystemColors.ActiveCaption;
            rbCanceladas.Location = new Point(12, 555);
            rbCanceladas.Name = "rbCanceladas";
            rbCanceladas.Size = new Size(105, 24);
            rbCanceladas.TabIndex = 63;
            rbCanceladas.TabStop = true;
            rbCanceladas.Text = "Canceladas";
            rbCanceladas.UseVisualStyleBackColor = false;
            rbCanceladas.CheckedChanged += rbCanceladas_CheckedChanged;
            // 
            // rbValorInmuebleASC
            // 
            rbValorInmuebleASC.AutoSize = true;
            rbValorInmuebleASC.BackColor = SystemColors.ActiveCaption;
            rbValorInmuebleASC.Location = new Point(12, 455);
            rbValorInmuebleASC.Name = "rbValorInmuebleASC";
            rbValorInmuebleASC.Size = new Size(143, 24);
            rbValorInmuebleASC.TabIndex = 65;
            rbValorInmuebleASC.TabStop = true;
            rbValorInmuebleASC.Text = "Valor ascendente";
            rbValorInmuebleASC.UseVisualStyleBackColor = false;
            rbValorInmuebleASC.CheckedChanged += rbValorInmuebleASC_CheckedChanged;
            // 
            // rbValorInmuebleDESC
            // 
            rbValorInmuebleDESC.AutoSize = true;
            rbValorInmuebleDESC.BackColor = SystemColors.ActiveCaption;
            rbValorInmuebleDESC.Location = new Point(245, 455);
            rbValorInmuebleDESC.Name = "rbValorInmuebleDESC";
            rbValorInmuebleDESC.Size = new Size(152, 24);
            rbValorInmuebleDESC.TabIndex = 66;
            rbValorInmuebleDESC.TabStop = true;
            rbValorInmuebleDESC.Text = "Valor descendente";
            rbValorInmuebleDESC.UseVisualStyleBackColor = false;
            rbValorInmuebleDESC.CheckedChanged += rbValorInmuebleDESC_CheckedChanged;
            // 
            // btnReimprimir
            // 
            btnReimprimir.BackColor = Color.SteelBlue;
            btnReimprimir.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnReimprimir.ForeColor = SystemColors.ButtonHighlight;
            btnReimprimir.Location = new Point(541, 455);
            btnReimprimir.Name = "btnReimprimir";
            btnReimprimir.Size = new Size(118, 42);
            btnReimprimir.TabIndex = 67;
            btnReimprimir.Text = "Reimprimir";
            btnReimprimir.UseVisualStyleBackColor = false;
            btnReimprimir.Click += btnReimprimir_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(921, 455);
            button1.Name = "button1";
            button1.Size = new Size(158, 42);
            button1.TabIndex = 61;
            button1.Text = "Limpiar historial";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnLimpiarHistorial_Click;
            // 
            // FormReimprimirFactura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 602);
            Controls.Add(btnReimprimir);
            Controls.Add(rbValorInmuebleDESC);
            Controls.Add(rbValorInmuebleASC);
            Controls.Add(rbCanceladas);
            Controls.Add(rbCobradas);
            Controls.Add(button1);
            Controls.Add(rbAntigua);
            Controls.Add(rbReciente);
            Controls.Add(btnEliminar);
            Controls.Add(lblVisitas);
            Controls.Add(dgvTasaciones);
            Name = "FormReimprimirFactura";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Histórico de tasaciones";
            Load += FormHistorialTasaciones_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTasaciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RadioButton rbAntigua;
        private RadioButton rbReciente;
        private Button btnEliminar;
        private Label lblVisitas;
        private DataGridView dgvTasaciones;
        private RadioButton rbCobradas;
        private RadioButton rbCanceladas;
        private RadioButton rbValorInmuebleASC;
        private RadioButton rbValorInmuebleDESC;
        private Button btnReimprimir;
        private Button button1;
    }
}