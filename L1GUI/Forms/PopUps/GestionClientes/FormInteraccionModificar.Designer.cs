namespace L1GUI.Forms.PopUps
{
    partial class FormInteraccionModificar
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
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            txtContacto = new TextBox();
            txtNombreApellido = new TextBox();
            txtDetalle = new TextBox();
            label7 = new Label();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label4.Location = new Point(83, 211);
            label4.Name = "label4";
            label4.Size = new Size(383, 23);
            label4.TabIndex = 151;
            label4.Text = "Detalles de la interacción";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.Location = new Point(113, 150);
            label3.Name = "label3";
            label3.Size = new Size(84, 23);
            label3.TabIndex = 150;
            label3.Text = "Contacto:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label1.Location = new Point(51, 93);
            label1.Name = "label1";
            label1.Size = new Size(146, 23);
            label1.TabIndex = 149;
            label1.Text = "Nombre/Apellido:";
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(203, 149);
            txtContacto.Multiline = true;
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(263, 31);
            txtContacto.TabIndex = 2;
            // 
            // txtNombreApellido
            // 
            txtNombreApellido.Location = new Point(203, 92);
            txtNombreApellido.Multiline = true;
            txtNombreApellido.Name = "txtNombreApellido";
            txtNombreApellido.Size = new Size(263, 31);
            txtNombreApellido.TabIndex = 1;
            // 
            // txtDetalle
            // 
            txtDetalle.Location = new Point(83, 237);
            txtDetalle.Multiline = true;
            txtDetalle.Name = "txtDetalle";
            txtDetalle.Size = new Size(383, 129);
            txtDetalle.TabIndex = 3;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 9);
            label7.Name = "label7";
            label7.Size = new Size(512, 41);
            label7.TabIndex = 152;
            label7.Text = "MODIFICANDO INTERACCION";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.SteelBlue;
            btnConfirmar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnConfirmar.ForeColor = SystemColors.ButtonHighlight;
            btnConfirmar.Location = new Point(83, 385);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(116, 43);
            btnConfirmar.TabIndex = 4;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.SteelBlue;
            btnCancelar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnCancelar.ForeColor = SystemColors.ButtonHighlight;
            btnCancelar.Location = new Point(350, 385);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(116, 43);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormInteraccionModificar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 453);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtContacto);
            Controls.Add(txtNombreApellido);
            Controls.Add(txtDetalle);
            Name = "FormInteraccionModificar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormInteraccionModificar";
            Load += FormInteraccionModificar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label1;
        private TextBox txtContacto;
        private TextBox txtNombreApellido;
        private TextBox txtDetalle;
        private Label label7;
        private Button btnConfirmar;
        private Button btnCancelar;
    }
}