namespace L1GUI.Forms
{
    partial class FormContratosRenovar
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
            label12 = new Label();
            dtPicker = new DateTimePicker();
            btnCancelar = new Button();
            btnRenovarContrato = new Button();
            lblInfoPropiedad = new Label();
            lblPropietario = new Label();
            label11 = new Label();
            lblPrecio = new Label();
            SuspendLayout();
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 9);
            label7.Name = "label7";
            label7.Size = new Size(436, 41);
            label7.TabIndex = 75;
            label7.Text = "RENOVANDO CONTRATO ";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label12.Location = new Point(62, 281);
            label12.Name = "label12";
            label12.Size = new Size(122, 23);
            label12.TabIndex = 113;
            label12.Text = "Diferir inicio:";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtPicker
            // 
            dtPicker.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            dtPicker.Location = new Point(190, 281);
            dtPicker.Name = "dtPicker";
            dtPicker.Size = new Size(178, 30);
            dtPicker.TabIndex = 112;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.SteelBlue;
            btnCancelar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnCancelar.ForeColor = SystemColors.ButtonHighlight;
            btnCancelar.Location = new Point(252, 350);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 42);
            btnCancelar.TabIndex = 109;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnRenovarContrato
            // 
            btnRenovarContrato.BackColor = Color.SteelBlue;
            btnRenovarContrato.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnRenovarContrato.ForeColor = SystemColors.ButtonHighlight;
            btnRenovarContrato.Location = new Point(58, 350);
            btnRenovarContrato.Name = "btnRenovarContrato";
            btnRenovarContrato.Size = new Size(158, 42);
            btnRenovarContrato.TabIndex = 108;
            btnRenovarContrato.Text = "Renovar contrato";
            btnRenovarContrato.UseVisualStyleBackColor = false;
            btnRenovarContrato.Click += btnRenovarContrato_Click;
            // 
            // lblInfoPropiedad
            // 
            lblInfoPropiedad.AutoSize = true;
            lblInfoPropiedad.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblInfoPropiedad.Location = new Point(11, 98);
            lblInfoPropiedad.Name = "lblInfoPropiedad";
            lblInfoPropiedad.Size = new Size(92, 23);
            lblInfoPropiedad.TabIndex = 114;
            lblInfoPropiedad.Text = "Propiedad:";
            // 
            // lblPropietario
            // 
            lblPropietario.AutoSize = true;
            lblPropietario.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblPropietario.Location = new Point(12, 148);
            lblPropietario.Name = "lblPropietario";
            lblPropietario.Size = new Size(98, 23);
            lblPropietario.TabIndex = 115;
            lblPropietario.Text = "Propietario:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label11.Location = new Point(11, 200);
            label11.Name = "label11";
            label11.Size = new Size(171, 23);
            label11.TabIndex = 111;
            label11.Text = "Precio de venta USD:";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblPrecio.Location = new Point(188, 200);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(0, 23);
            lblPrecio.TabIndex = 116;
            // 
            // FormContratosRenovar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 414);
            Controls.Add(lblPrecio);
            Controls.Add(lblPropietario);
            Controls.Add(lblInfoPropiedad);
            Controls.Add(label12);
            Controls.Add(dtPicker);
            Controls.Add(label11);
            Controls.Add(btnCancelar);
            Controls.Add(btnRenovarContrato);
            Controls.Add(label7);
            Name = "FormContratosRenovar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormContratosRenovar";
            Load += FormContratosRenovar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label12;
        private DateTimePicker dtPicker;
        private Button btnCancelar;
        private Button btnRenovarContrato;
        private Label lblInfoPropiedad;
        private Label lblPropietario;
        private Label label11;
        private Label lblPrecio;
    }
}