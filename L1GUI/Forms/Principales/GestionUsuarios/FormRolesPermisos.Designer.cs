namespace L1GUI.Forms.Principales
{
    partial class FormRolesPermisos
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
            btnAltaRol = new Button();
            txtIdUsuario = new TextBox();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            txtNombreUsuario = new TextBox();
            txtContraseña = new TextBox();
            cbBloqueado = new CheckBox();
            cbActivo = new CheckBox();
            cbDescifrarCifrar = new CheckBox();
            label4 = new Label();
            label5 = new Label();
            txtNombreRolAlta = new TextBox();
            label7 = new Label();
            btnModifRol = new Button();
            btnEliminarRol = new Button();
            btnDesasociarPermisoArol = new Button();
            btnAsociarPermisoArol = new Button();
            label13 = new Label();
            label17 = new Label();
            btnDesasiociarRolUsuario = new Button();
            cmbMenu = new ComboBox();
            btnAltaPermiso = new Button();
            AsociarRolUsuario = new Button();
            btnAsociarPermisoUsuario = new Button();
            btnDesasociarPermisoUsuario = new Button();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            cmbListaRoles = new ComboBox();
            label10 = new Label();
            txtIdRol = new TextBox();
            label6 = new Label();
            txtIdPermiso = new TextBox();
            label8 = new Label();
            label11 = new Label();
            txtNombrePermiso = new TextBox();
            label9 = new Label();
            tvPermisos = new TreeView();
            tvRoles = new TreeView();
            tvPermisosPorRol = new TreeView();
            tvRolesYPermisosUsuario = new TreeView();
            tvUsuario = new TreeView();
            label12 = new Label();
            cmbItem = new ComboBox();
            label14 = new Label();
            btnEliminarPermiso = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // btnAltaRol
            // 
            btnAltaRol.BackColor = Color.SteelBlue;
            btnAltaRol.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnAltaRol.ForeColor = SystemColors.ButtonHighlight;
            btnAltaRol.Location = new Point(543, 108);
            btnAltaRol.Name = "btnAltaRol";
            btnAltaRol.Size = new Size(99, 33);
            btnAltaRol.TabIndex = 45;
            btnAltaRol.Text = "Alta";
            btnAltaRol.UseVisualStyleBackColor = false;
            btnAltaRol.Click += btnAltaRol_Click;
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Enabled = false;
            txtIdUsuario.Location = new Point(132, 46);
            txtIdUsuario.Multiline = true;
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(68, 24);
            txtIdUsuario.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(23, 46);
            label3.Name = "label3";
            label3.Size = new Size(31, 23);
            label3.TabIndex = 30;
            label3.Text = "ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 91);
            label1.Name = "label1";
            label1.Size = new Size(77, 23);
            label1.TabIndex = 31;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 133);
            label2.Name = "label2";
            label2.Size = new Size(101, 23);
            label2.TabIndex = 32;
            label2.Text = "Contraseña:";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Enabled = false;
            txtNombreUsuario.Location = new Point(132, 90);
            txtNombreUsuario.Multiline = true;
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(179, 24);
            txtNombreUsuario.TabIndex = 34;
            // 
            // txtContraseña
            // 
            txtContraseña.Enabled = false;
            txtContraseña.Location = new Point(132, 133);
            txtContraseña.Multiline = true;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(179, 24);
            txtContraseña.TabIndex = 35;
            // 
            // cbBloqueado
            // 
            cbBloqueado.AutoSize = true;
            cbBloqueado.Enabled = false;
            cbBloqueado.Location = new Point(329, 46);
            cbBloqueado.Name = "cbBloqueado";
            cbBloqueado.Size = new Size(104, 24);
            cbBloqueado.TabIndex = 36;
            cbBloqueado.Text = "Bloqueado";
            cbBloqueado.UseVisualStyleBackColor = true;
            // 
            // cbActivo
            // 
            cbActivo.AutoSize = true;
            cbActivo.Enabled = false;
            cbActivo.Location = new Point(329, 90);
            cbActivo.Name = "cbActivo";
            cbActivo.Size = new Size(73, 24);
            cbActivo.TabIndex = 37;
            cbActivo.Text = "Activo";
            cbActivo.UseVisualStyleBackColor = true;
            // 
            // cbDescifrarCifrar
            // 
            cbDescifrarCifrar.AutoSize = true;
            cbDescifrarCifrar.Location = new Point(329, 133);
            cbDescifrarCifrar.Name = "cbDescifrarCifrar";
            cbDescifrarCifrar.Size = new Size(168, 24);
            cbDescifrarCifrar.TabIndex = 38;
            cbDescifrarCifrar.Text = "Descifrar/cifrar clave";
            cbDescifrarCifrar.UseVisualStyleBackColor = true;
            cbDescifrarCifrar.CheckedChanged += cbDescifrarCifrar_CheckedChanged;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 15);
            label4.Name = "label4";
            label4.Size = new Size(496, 23);
            label4.TabIndex = 39;
            label4.Text = "Usuario";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 15);
            label5.Name = "label5";
            label5.Size = new Size(364, 23);
            label5.TabIndex = 43;
            label5.Text = "Rol";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNombreRolAlta
            // 
            txtNombreRolAlta.Location = new Point(723, 46);
            txtNombreRolAlta.Name = "txtNombreRolAlta";
            txtNombreRolAlta.Size = new Size(149, 27);
            txtNombreRolAlta.TabIndex = 44;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(640, 47);
            label7.Name = "label7";
            label7.Size = new Size(77, 23);
            label7.TabIndex = 45;
            label7.Text = "Nombre:";
            // 
            // btnModifRol
            // 
            btnModifRol.BackColor = Color.SteelBlue;
            btnModifRol.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnModifRol.ForeColor = SystemColors.ButtonHighlight;
            btnModifRol.Location = new Point(662, 108);
            btnModifRol.Name = "btnModifRol";
            btnModifRol.Size = new Size(99, 33);
            btnModifRol.TabIndex = 46;
            btnModifRol.Text = "Modificar";
            btnModifRol.UseVisualStyleBackColor = false;
            btnModifRol.Click += btnModifRol_Click;
            // 
            // btnEliminarRol
            // 
            btnEliminarRol.BackColor = Color.Red;
            btnEliminarRol.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnEliminarRol.ForeColor = SystemColors.ButtonHighlight;
            btnEliminarRol.Location = new Point(773, 108);
            btnEliminarRol.Name = "btnEliminarRol";
            btnEliminarRol.Size = new Size(99, 33);
            btnEliminarRol.TabIndex = 47;
            btnEliminarRol.Text = "Eliminar";
            btnEliminarRol.UseVisualStyleBackColor = false;
            btnEliminarRol.Click += btnEliminarRol_Click;
            // 
            // btnDesasociarPermisoArol
            // 
            btnDesasociarPermisoArol.BackColor = Color.SteelBlue;
            btnDesasociarPermisoArol.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnDesasociarPermisoArol.ForeColor = SystemColors.ButtonHighlight;
            btnDesasociarPermisoArol.Location = new Point(299, 251);
            btnDesasociarPermisoArol.Name = "btnDesasociarPermisoArol";
            btnDesasociarPermisoArol.Size = new Size(129, 54);
            btnDesasociarPermisoArol.TabIndex = 73;
            btnDesasociarPermisoArol.Text = "Desasociar permiso a rol";
            btnDesasociarPermisoArol.UseVisualStyleBackColor = false;
            btnDesasociarPermisoArol.Click += btnDesasociarPermisoArol_Click;
            // 
            // btnAsociarPermisoArol
            // 
            btnAsociarPermisoArol.BackColor = Color.SteelBlue;
            btnAsociarPermisoArol.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnAsociarPermisoArol.ForeColor = SystemColors.ButtonHighlight;
            btnAsociarPermisoArol.Location = new Point(41, 251);
            btnAsociarPermisoArol.Name = "btnAsociarPermisoArol";
            btnAsociarPermisoArol.Size = new Size(129, 54);
            btnAsociarPermisoArol.TabIndex = 72;
            btnAsociarPermisoArol.Text = "Asociar permiso a rol";
            btnAsociarPermisoArol.UseVisualStyleBackColor = false;
            btnAsociarPermisoArol.Click += btnAsociarPermisoArol_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(914, 95);
            label13.Name = "label13";
            label13.Size = new Size(58, 23);
            label13.TabIndex = 69;
            label13.Text = "Menu:";
            // 
            // label17
            // 
            label17.BackColor = Color.Transparent;
            label17.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.Location = new Point(914, 10);
            label17.Name = "label17";
            label17.Size = new Size(422, 23);
            label17.TabIndex = 61;
            label17.Text = "Permiso";
            label17.TextAlign = ContentAlignment.BottomCenter;
            // 
            // btnDesasiociarRolUsuario
            // 
            btnDesasiociarRolUsuario.BackColor = Color.SteelBlue;
            btnDesasiociarRolUsuario.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnDesasiociarRolUsuario.ForeColor = SystemColors.ButtonHighlight;
            btnDesasiociarRolUsuario.Location = new Point(730, 245);
            btnDesasiociarRolUsuario.Name = "btnDesasiociarRolUsuario";
            btnDesasiociarRolUsuario.Size = new Size(142, 54);
            btnDesasiociarRolUsuario.TabIndex = 50;
            btnDesasiociarRolUsuario.Text = "Desasociar rol a usuario";
            btnDesasiociarRolUsuario.UseVisualStyleBackColor = false;
            btnDesasiociarRolUsuario.Click += btnDesasiociarRolUsuario_Click;
            // 
            // cmbMenu
            // 
            cmbMenu.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMenu.FormattingEnabled = true;
            cmbMenu.Location = new Point(978, 94);
            cmbMenu.Name = "cmbMenu";
            cmbMenu.Size = new Size(237, 28);
            cmbMenu.TabIndex = 80;
            cmbMenu.SelectedIndexChanged += cmbMenu_SelectedIndexChanged;
            // 
            // btnAltaPermiso
            // 
            btnAltaPermiso.BackColor = Color.SteelBlue;
            btnAltaPermiso.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnAltaPermiso.ForeColor = SystemColors.ButtonHighlight;
            btnAltaPermiso.Location = new Point(1237, 95);
            btnAltaPermiso.Name = "btnAltaPermiso";
            btnAltaPermiso.Size = new Size(99, 33);
            btnAltaPermiso.TabIndex = 81;
            btnAltaPermiso.Text = "Alta";
            btnAltaPermiso.UseVisualStyleBackColor = false;
            btnAltaPermiso.Click += btnAltaPermiso_Click;
            // 
            // AsociarRolUsuario
            // 
            AsociarRolUsuario.BackColor = Color.SteelBlue;
            AsociarRolUsuario.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            AsociarRolUsuario.ForeColor = SystemColors.ButtonHighlight;
            AsociarRolUsuario.Location = new Point(543, 245);
            AsociarRolUsuario.Name = "AsociarRolUsuario";
            AsociarRolUsuario.Size = new Size(142, 54);
            AsociarRolUsuario.TabIndex = 49;
            AsociarRolUsuario.Text = "Asociar rol a usuario";
            AsociarRolUsuario.UseVisualStyleBackColor = false;
            AsociarRolUsuario.Click += AsociarRolUsuario_Click;
            // 
            // btnAsociarPermisoUsuario
            // 
            btnAsociarPermisoUsuario.BackColor = Color.SteelBlue;
            btnAsociarPermisoUsuario.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnAsociarPermisoUsuario.ForeColor = SystemColors.ButtonHighlight;
            btnAsociarPermisoUsuario.Location = new Point(23, 245);
            btnAsociarPermisoUsuario.Name = "btnAsociarPermisoUsuario";
            btnAsociarPermisoUsuario.Size = new Size(142, 54);
            btnAsociarPermisoUsuario.TabIndex = 3;
            btnAsociarPermisoUsuario.Text = "Asociar permiso a usuario";
            btnAsociarPermisoUsuario.UseVisualStyleBackColor = false;
            btnAsociarPermisoUsuario.Click += btnAsociarPermisoUsuario_Click;
            // 
            // btnDesasociarPermisoUsuario
            // 
            btnDesasociarPermisoUsuario.BackColor = Color.SteelBlue;
            btnDesasociarPermisoUsuario.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnDesasociarPermisoUsuario.ForeColor = SystemColors.ButtonHighlight;
            btnDesasociarPermisoUsuario.Location = new Point(355, 245);
            btnDesasociarPermisoUsuario.Name = "btnDesasociarPermisoUsuario";
            btnDesasociarPermisoUsuario.Size = new Size(142, 54);
            btnDesasociarPermisoUsuario.TabIndex = 4;
            btnDesasociarPermisoUsuario.Text = "Desasociar permiso a usuario";
            btnDesasociarPermisoUsuario.UseVisualStyleBackColor = false;
            btnDesasociarPermisoUsuario.Click += btnDesasociarPermisoUsuario_Click;
            // 
            // label22
            // 
            label22.BackColor = Color.Transparent;
            label22.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label22.Location = new Point(559, 349);
            label22.Name = "label22";
            label22.Size = new Size(242, 23);
            label22.TabIndex = 95;
            label22.Text = "Roles";
            label22.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            label23.BackColor = Color.Transparent;
            label23.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label23.Location = new Point(287, 349);
            label23.Name = "label23";
            label23.Size = new Size(247, 23);
            label23.TabIndex = 96;
            label23.Text = "Permisos";
            label23.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            label24.BackColor = Color.Transparent;
            label24.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label24.Location = new Point(837, 349);
            label24.Name = "label24";
            label24.Size = new Size(242, 23);
            label24.TabIndex = 97;
            label24.Text = "Permisos por rol";
            label24.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            label25.BackColor = Color.Transparent;
            label25.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label25.Location = new Point(1108, 349);
            label25.Name = "label25";
            label25.Size = new Size(242, 23);
            label25.TabIndex = 98;
            label25.Text = "Roles y permisos del usuario";
            label25.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbListaRoles
            // 
            cmbListaRoles.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbListaRoles.FormattingEnabled = true;
            cmbListaRoles.Location = new Point(662, 176);
            cmbListaRoles.Name = "cmbListaRoles";
            cmbListaRoles.Size = new Size(210, 28);
            cmbListaRoles.TabIndex = 48;
            cmbListaRoles.SelectedIndexChanged += cmbListaRoles_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(543, 177);
            label10.Name = "label10";
            label10.Size = new Size(113, 23);
            label10.TabIndex = 51;
            label10.Text = "Lista de roles:";
            // 
            // txtIdRol
            // 
            txtIdRol.Enabled = false;
            txtIdRol.Location = new Point(566, 46);
            txtIdRol.Multiline = true;
            txtIdRol.Name = "txtIdRol";
            txtIdRol.Size = new Size(68, 24);
            txtIdRol.TabIndex = 103;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(531, 46);
            label6.Name = "label6";
            label6.Size = new Size(31, 23);
            label6.TabIndex = 104;
            label6.Text = "ID:";
            // 
            // txtIdPermiso
            // 
            txtIdPermiso.Enabled = false;
            txtIdPermiso.Location = new Point(949, 44);
            txtIdPermiso.Multiline = true;
            txtIdPermiso.Name = "txtIdPermiso";
            txtIdPermiso.Size = new Size(68, 24);
            txtIdPermiso.TabIndex = 107;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(914, 44);
            label8.Name = "label8";
            label8.Size = new Size(31, 23);
            label8.TabIndex = 108;
            label8.Text = "ID:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(1023, 45);
            label11.Name = "label11";
            label11.Size = new Size(77, 23);
            label11.TabIndex = 106;
            label11.Text = "Nombre:";
            // 
            // txtNombrePermiso
            // 
            txtNombrePermiso.Enabled = false;
            txtNombrePermiso.Location = new Point(1106, 44);
            txtNombrePermiso.Name = "txtNombrePermiso";
            txtNombrePermiso.Size = new Size(206, 27);
            txtNombrePermiso.TabIndex = 105;
            // 
            // label9
            // 
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(12, 349);
            label9.Name = "label9";
            label9.Size = new Size(249, 23);
            label9.TabIndex = 114;
            label9.Text = "Usuarios";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tvPermisos
            // 
            tvPermisos.Location = new Point(287, 375);
            tvPermisos.Name = "tvPermisos";
            tvPermisos.Size = new Size(247, 286);
            tvPermisos.TabIndex = 115;
            tvPermisos.AfterSelect += tvPermisos_AfterSelect;
            // 
            // tvRoles
            // 
            tvRoles.Location = new Point(559, 375);
            tvRoles.Name = "tvRoles";
            tvRoles.Size = new Size(247, 286);
            tvRoles.TabIndex = 116;
            tvRoles.AfterSelect += tvRoles_AfterSelect;
            // 
            // tvPermisosPorRol
            // 
            tvPermisosPorRol.Location = new Point(832, 375);
            tvPermisosPorRol.Name = "tvPermisosPorRol";
            tvPermisosPorRol.Size = new Size(247, 286);
            tvPermisosPorRol.TabIndex = 117;
            tvPermisosPorRol.AfterSelect += tvPermisosPorRol_AfterSelect;
            // 
            // tvRolesYPermisosUsuario
            // 
            tvRolesYPermisosUsuario.Location = new Point(1108, 375);
            tvRolesYPermisosUsuario.Name = "tvRolesYPermisosUsuario";
            tvRolesYPermisosUsuario.Size = new Size(247, 286);
            tvRolesYPermisosUsuario.TabIndex = 118;
            // 
            // tvUsuario
            // 
            tvUsuario.Location = new Point(14, 375);
            tvUsuario.Name = "tvUsuario";
            tvUsuario.Size = new Size(247, 286);
            tvUsuario.TabIndex = 119;
            tvUsuario.AfterSelect += tvUsuario_AfterSelect;
            // 
            // label12
            // 
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(12, 190);
            label12.Name = "label12";
            label12.Size = new Size(496, 23);
            label12.TabIndex = 121;
            label12.Text = "Permisos/Roles a usuario";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbItem
            // 
            cmbItem.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbItem.FormattingEnabled = true;
            cmbItem.Location = new Point(978, 159);
            cmbItem.Name = "cmbItem";
            cmbItem.Size = new Size(237, 28);
            cmbItem.TabIndex = 74;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(923, 160);
            label14.Name = "label14";
            label14.Size = new Size(49, 23);
            label14.TabIndex = 75;
            label14.Text = "Item:";
            // 
            // btnEliminarPermiso
            // 
            btnEliminarPermiso.BackColor = Color.Red;
            btnEliminarPermiso.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnEliminarPermiso.ForeColor = SystemColors.ButtonHighlight;
            btnEliminarPermiso.Location = new Point(1237, 156);
            btnEliminarPermiso.Name = "btnEliminarPermiso";
            btnEliminarPermiso.Size = new Size(99, 33);
            btnEliminarPermiso.TabIndex = 122;
            btnEliminarPermiso.Text = "Eliminar";
            btnEliminarPermiso.UseVisualStyleBackColor = false;
            btnEliminarPermiso.Click += btnEliminarPermiso_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(9, -6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(506, 181);
            groupBox1.TabIndex = 123;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(9, 177);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(506, 133);
            groupBox2.TabIndex = 124;
            groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label5);
            groupBox3.Location = new Point(521, -6);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(381, 316);
            groupBox3.TabIndex = 125;
            groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnAsociarPermisoArol);
            groupBox4.Controls.Add(btnDesasociarPermisoArol);
            groupBox4.Location = new Point(908, -6);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(453, 316);
            groupBox4.TabIndex = 126;
            groupBox4.TabStop = false;
            // 
            // FormRolesPermisos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1373, 673);
            Controls.Add(btnEliminarPermiso);
            Controls.Add(label12);
            Controls.Add(tvUsuario);
            Controls.Add(tvRolesYPermisosUsuario);
            Controls.Add(tvPermisosPorRol);
            Controls.Add(tvRoles);
            Controls.Add(tvPermisos);
            Controls.Add(label9);
            Controls.Add(txtIdPermiso);
            Controls.Add(label8);
            Controls.Add(label11);
            Controls.Add(txtNombrePermiso);
            Controls.Add(txtIdRol);
            Controls.Add(label6);
            Controls.Add(label25);
            Controls.Add(label24);
            Controls.Add(label23);
            Controls.Add(label22);
            Controls.Add(btnDesasociarPermisoUsuario);
            Controls.Add(btnAsociarPermisoUsuario);
            Controls.Add(AsociarRolUsuario);
            Controls.Add(btnAltaPermiso);
            Controls.Add(cmbMenu);
            Controls.Add(btnDesasiociarRolUsuario);
            Controls.Add(label14);
            Controls.Add(cmbItem);
            Controls.Add(label13);
            Controls.Add(label17);
            Controls.Add(label10);
            Controls.Add(btnEliminarRol);
            Controls.Add(btnModifRol);
            Controls.Add(label7);
            Controls.Add(txtNombreRolAlta);
            Controls.Add(cbDescifrarCifrar);
            Controls.Add(cbActivo);
            Controls.Add(cbBloqueado);
            Controls.Add(txtContraseña);
            Controls.Add(txtNombreUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAltaRol);
            Controls.Add(txtIdUsuario);
            Controls.Add(label3);
            Controls.Add(cmbListaRoles);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox4);
            Name = "FormRolesPermisos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRolesPermisos";
            Load += FormRolesPermisos_Load;
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAltaRol;
        private TextBox txtIdUsuario;
        private Label label3;
        private Label label1;
        private Label label2;
        private TextBox txtNombreUsuario;
        private TextBox txtContraseña;
        private CheckBox cbBloqueado;
        private CheckBox cbActivo;
        private CheckBox cbDescifrarCifrar;
        private Label label4;
        private Label label5;
        private TextBox txtNombreRolAlta;
        private Label label7;
        private Button btnModifRol;
        private Button btnEliminarRol;
        private Button btnDesasociarPermisoArol;
        private Button btnAsociarPermisoArol;
        private Label label13;
        private Label label17;
        private Button AsociarRolUsuario;
        private Button btnDesasiociarRolUsuario;
        private ComboBox cmbMenu;
        private Button button6;
        private Button btnAltaPermiso;
        private Button btnAsociarPermisoUsuario;
        private Button btnDesasociarPermisoUsuario;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label25;
        private ComboBox cmbListaRoles;
        private Label label10;
        private TextBox txtIdRol;
        private Label label6;
        private TextBox txtIdPermiso;
        private Label label8;
        private Label label11;
        private TextBox txtNombrePermiso;
        private Label label9;
        private TreeView tvPermisos;
        private TreeView tvRoles;
        private TreeView tvPermisosPorRol;
        private TreeView tvRolesYPermisosUsuario;
        private TreeView tvUsuario;
        private Label label12;
        private ComboBox cmbItem;
        private Label label14;
        private Button btnEliminarPermiso;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
    }
}