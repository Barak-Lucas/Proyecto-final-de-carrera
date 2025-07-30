namespace L1GUI.Forms.Principales
{
    partial class FormAbmUsuario
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
            btnEliminar = new Button();
            btnModif = new Button();
            label7 = new Label();
            btnAlta = new Button();
            label1 = new Label();
            txtContraseña2 = new TextBox();
            txtContraseña1 = new TextBox();
            label6 = new Label();
            label8 = new Label();
            btnBloquear = new Button();
            btnDesbloquear = new Button();
            dgvUsuarios = new DataGridView();
            cmbRol = new ComboBox();
            label9 = new Label();
            label11 = new Label();
            label12 = new Label();
            label15 = new Label();
            label14 = new Label();
            label16 = new Label();
            groupBox1 = new GroupBox();
            txtNombreUsuario = new TextBox();
            btnReactivar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnEliminar.ForeColor = SystemColors.ButtonHighlight;
            btnEliminar.Location = new Point(1131, 543);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(119, 37);
            btnEliminar.TabIndex = 16;
            btnEliminar.Text = "Baja";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnBaja_Click;
            // 
            // btnModif
            // 
            btnModif.BackColor = Color.SteelBlue;
            btnModif.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnModif.ForeColor = SystemColors.ButtonHighlight;
            btnModif.Location = new Point(589, 465);
            btnModif.Name = "btnModif";
            btnModif.Size = new Size(119, 37);
            btnModif.TabIndex = 12;
            btnModif.Text = "Modificar";
            btnModif.UseVisualStyleBackColor = false;
            btnModif.Click += btnModif_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(31, 52);
            label7.Name = "label7";
            label7.Size = new Size(162, 23);
            label7.TabIndex = 52;
            label7.Text = "Nombre de usuario:";
            // 
            // btnAlta
            // 
            btnAlta.BackColor = Color.SteelBlue;
            btnAlta.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnAlta.ForeColor = SystemColors.ButtonHighlight;
            btnAlta.Location = new Point(342, 359);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(119, 37);
            btnAlta.TabIndex = 5;
            btnAlta.Text = "Alta";
            btnAlta.UseVisualStyleBackColor = false;
            btnAlta.Click += btnAlta_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(36, 189);
            label1.Name = "label1";
            label1.Size = new Size(157, 23);
            label1.TabIndex = 56;
            label1.Text = "Repetir contraseña:";
            // 
            // txtContraseña2
            // 
            txtContraseña2.Location = new Point(199, 189);
            txtContraseña2.Multiline = true;
            txtContraseña2.Name = "txtContraseña2";
            txtContraseña2.Size = new Size(262, 24);
            txtContraseña2.TabIndex = 3;
            // 
            // txtContraseña1
            // 
            txtContraseña1.Location = new Point(199, 123);
            txtContraseña1.Multiline = true;
            txtContraseña1.Name = "txtContraseña1";
            txtContraseña1.Size = new Size(262, 24);
            txtContraseña1.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(92, 124);
            label6.Name = "label6";
            label6.Size = new Size(101, 23);
            label6.TabIndex = 65;
            label6.Text = "Contraseña:";
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(14, 80);
            label8.Name = "label8";
            label8.Size = new Size(551, 23);
            label8.TabIndex = 67;
            label8.Text = "Alta de usuario";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBloquear
            // 
            btnBloquear.BackColor = Color.SteelBlue;
            btnBloquear.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnBloquear.ForeColor = SystemColors.ButtonHighlight;
            btnBloquear.Location = new Point(969, 465);
            btnBloquear.Name = "btnBloquear";
            btnBloquear.Size = new Size(119, 37);
            btnBloquear.TabIndex = 14;
            btnBloquear.Text = "Bloquear";
            btnBloquear.UseVisualStyleBackColor = false;
            btnBloquear.Click += btnBloquear_Click;
            // 
            // btnDesbloquear
            // 
            btnDesbloquear.BackColor = Color.SteelBlue;
            btnDesbloquear.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnDesbloquear.ForeColor = SystemColors.ButtonHighlight;
            btnDesbloquear.Location = new Point(788, 465);
            btnDesbloquear.Name = "btnDesbloquear";
            btnDesbloquear.Size = new Size(119, 37);
            btnDesbloquear.TabIndex = 13;
            btnDesbloquear.Text = "Desbloquear";
            btnDesbloquear.UseVisualStyleBackColor = false;
            btnDesbloquear.Click += btnDesbloquear_Click;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(589, 111);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.Size = new Size(661, 325);
            dgvUsuarios.TabIndex = 71;
            // 
            // cmbRol
            // 
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(199, 258);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(262, 28);
            cmbRol.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(155, 258);
            label9.Name = "label9";
            label9.Size = new Size(38, 23);
            label9.TabIndex = 73;
            label9.Text = "Rol:";
            // 
            // label11
            // 
            label11.BackColor = Color.White;
            label11.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            label11.Location = new Point(12, 9);
            label11.Name = "label11";
            label11.Size = new Size(1238, 41);
            label11.TabIndex = 76;
            label11.Text = "ALTA DE USUARIOS";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(589, 85);
            label12.Name = "label12";
            label12.Size = new Size(621, 23);
            label12.TabIndex = 77;
            label12.Text = "Usuarios";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label15.ForeColor = Color.Red;
            label15.Location = new Point(467, 52);
            label15.Name = "label15";
            label15.Size = new Size(17, 23);
            label15.TabIndex = 82;
            label15.Text = "*";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label14.ForeColor = Color.Red;
            label14.Location = new Point(467, 124);
            label14.Name = "label14";
            label14.Size = new Size(17, 23);
            label14.TabIndex = 84;
            label14.Text = "*";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label16.ForeColor = Color.Red;
            label16.Location = new Point(467, 190);
            label16.Name = "label16";
            label16.Size = new Size(17, 23);
            label16.TabIndex = 85;
            label16.Text = "*";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNombreUsuario);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(txtContraseña1);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btnAlta);
            groupBox1.Controls.Add(cmbRol);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtContraseña2);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 106);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(553, 440);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(199, 51);
            txtNombreUsuario.Multiline = true;
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(262, 24);
            txtNombreUsuario.TabIndex = 1;
            // 
            // btnReactivar
            // 
            btnReactivar.BackColor = Color.SteelBlue;
            btnReactivar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnReactivar.ForeColor = SystemColors.ButtonHighlight;
            btnReactivar.Location = new Point(1131, 465);
            btnReactivar.Name = "btnReactivar";
            btnReactivar.Size = new Size(119, 37);
            btnReactivar.TabIndex = 15;
            btnReactivar.Text = "Reactivar";
            btnReactivar.UseVisualStyleBackColor = false;
            btnReactivar.Click += btnReactivar_Click;
            // 
            // FormAbmUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(btnReactivar);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(dgvUsuarios);
            Controls.Add(btnDesbloquear);
            Controls.Add(btnBloquear);
            Controls.Add(label8);
            Controls.Add(btnEliminar);
            Controls.Add(btnModif);
            Controls.Add(groupBox1);
            Name = "FormAbmUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAbmUsuario";
            Load += FormAbmUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnEliminar;
        private Button btnModif;
        private Label label7;
        private TextBox txtNombre;
        private Button btnAlta;
        private Label label1;
        private TextBox txtContraseña2;
        private TextBox txtContraseña1;
        private Label label6;
        private Label label8;
        private Button btnBloquear;
        private Button btnDesbloquear;
        private DataGridView dgvUsuarios;
        private ComboBox cmbRol;
        private Label label9;
        private Label label11;
        private Label label12;
        private Label label15;
        private Label label14;
        private Label label16;
        private GroupBox groupBox1;
        private Button btnReactivar;
        private TextBox txtNombreUsuario;
    }
}