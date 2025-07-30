namespace L1GUI.Forms.PopUps
{
    partial class FormUsuarioModif
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
            lblModificando = new Label();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            txtNombreUsuario = new TextBox();
            label15 = new Label();
            txtContraseña1 = new TextBox();
            label16 = new Label();
            label14 = new Label();
            label6 = new Label();
            txtContraseña2 = new TextBox();
            label7 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblModificando
            // 
            lblModificando.BackColor = Color.White;
            lblModificando.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            lblModificando.Location = new Point(12, 9);
            lblModificando.Name = "lblModificando";
            lblModificando.Size = new Size(574, 41);
            lblModificando.TabIndex = 95;
            lblModificando.Text = "MODIFICANDO USUARIO ";
            lblModificando.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.SteelBlue;
            btnConfirmar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnConfirmar.ForeColor = SystemColors.ButtonHighlight;
            btnConfirmar.Location = new Point(199, 335);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(119, 37);
            btnConfirmar.TabIndex = 4;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.SteelBlue;
            btnCancelar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnCancelar.ForeColor = SystemColors.ButtonHighlight;
            btnCancelar.Location = new Point(342, 335);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(119, 37);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(199, 111);
            txtNombreUsuario.Multiline = true;
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(262, 24);
            txtNombreUsuario.TabIndex = 1;
            txtNombreUsuario.Enter += txtNombreUsuario_Enter;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label15.ForeColor = Color.Red;
            label15.Location = new Point(467, 112);
            label15.Name = "label15";
            label15.Size = new Size(17, 23);
            label15.TabIndex = 102;
            label15.Text = "*";
            // 
            // txtContraseña1
            // 
            txtContraseña1.Location = new Point(199, 183);
            txtContraseña1.Multiline = true;
            txtContraseña1.Name = "txtContraseña1";
            txtContraseña1.Size = new Size(262, 24);
            txtContraseña1.TabIndex = 2;

            txtContraseña1.Enter += txtContraseña1_Enter;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label16.ForeColor = Color.Red;
            label16.Location = new Point(467, 250);
            label16.Name = "label16";
            label16.Size = new Size(17, 23);
            label16.TabIndex = 104;
            label16.Text = "*";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label14.ForeColor = Color.Red;
            label14.Location = new Point(467, 184);
            label14.Name = "label14";
            label14.Size = new Size(17, 23);
            label14.TabIndex = 103;
            label14.Text = "*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(92, 184);
            label6.Name = "label6";
            label6.Size = new Size(101, 23);
            label6.TabIndex = 101;
            label6.Text = "Contraseña:";
            // 
            // txtContraseña2
            // 
            txtContraseña2.Location = new Point(199, 249);
            txtContraseña2.Multiline = true;
            txtContraseña2.Name = "txtContraseña2";
            txtContraseña2.Size = new Size(262, 24);
            txtContraseña2.TabIndex = 3;

            txtContraseña2.Enter += txtContraseña2_Enter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(31, 112);
            label7.Name = "label7";
            label7.Size = new Size(162, 23);
            label7.TabIndex = 99;
            label7.Text = "Nombre de usuario:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(36, 249);
            label1.Name = "label1";
            label1.Size = new Size(157, 23);
            label1.TabIndex = 100;
            label1.Text = "Repetir contraseña:";
            // 
            // FormUsuarioModif
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 453);
            Controls.Add(txtNombreUsuario);
            Controls.Add(label15);
            Controls.Add(txtContraseña1);
            Controls.Add(label16);
            Controls.Add(label14);
            Controls.Add(label6);
            Controls.Add(txtContraseña2);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(lblModificando);
            Controls.Add(btnConfirmar);
            Name = "FormUsuarioModif";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormUsuarioModif";
            Load += FormUsuarioModif_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblModificando;
        private Button btnModif;
        private Button btnConfirmar;
        private Button btnCancelar;
        private TextBox txtNombreUsuario;
        private Label label15;
        private TextBox txtContraseña1;
        private Label label16;
        private Label label14;
        private Label label6;
        private TextBox txtContraseña2;
        private Label label7;
        private Label label1;
    }
}