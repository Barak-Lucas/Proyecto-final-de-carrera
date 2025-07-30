namespace L1GUI.Forms
{
    partial class FormAbmPropiedades
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
            btnBaja = new Button();
            btnAlta = new Button();
            label1 = new Label();
            btnModificar = new Button();
            label7 = new Label();
            cmbTipo = new ComboBox();
            label3 = new Label();
            nudAmbientes = new NumericUpDown();
            label2 = new Label();
            label4 = new Label();
            nudBaños = new NumericUpDown();
            label5 = new Label();
            nudDorm = new NumericUpDown();
            label6 = new Label();
            nudAntiguedad = new NumericUpDown();
            cnM2 = new ControlesDeUsuario.CajaNumerica();
            label8 = new Label();
            nudPlantas = new NumericUpDown();
            label9 = new Label();
            cmbOrientacion = new ComboBox();
            label10 = new Label();
            label11 = new Label();
            txtDomicilio = new TextBox();
            label12 = new Label();
            txtDescripcion = new TextBox();
            label13 = new Label();
            cnPropietario = new ControlesDeUsuario.CajaNumerica();
            label14 = new Label();
            dgvPropiedades = new DataGridView();
            btnBuscarProp = new Button();
            cbGasNatural = new CheckBox();
            cbCloaca = new CheckBox();
            cbElectricidad = new CheckBox();
            cbInternet = new CheckBox();
            cbAguaCte = new CheckBox();
            cbPavimento = new CheckBox();
            cbCocina = new CheckBox();
            cbGarage = new CheckBox();
            cbLiving = new CheckBox();
            cbPatio = new CheckBox();
            cbJardin = new CheckBox();
            cbBalcon = new CheckBox();
            cbLavadero = new CheckBox();
            cbTerraza = new CheckBox();
            nudToilette = new NumericUpDown();
            label18 = new Label();
            cbCable = new CheckBox();
            label15 = new Label();
            label19 = new Label();
            label22 = new Label();
            cnPrecio = new ControlesDeUsuario.CajaNumerica();
            label20 = new Label();
            label21 = new Label();
            cmbLocalidad = new ComboBox();
            gbEstructura = new GroupBox();
            gbServicios = new GroupBox();
            gbAmbientes = new GroupBox();
            txtBuscarID = new TextBox();
            txtBuscarDomicilio = new TextBox();
            label16 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudAmbientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudBaños).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDorm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAntiguedad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPlantas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPropiedades).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudToilette).BeginInit();
            gbEstructura.SuspendLayout();
            gbServicios.SuspendLayout();
            gbAmbientes.SuspendLayout();
            SuspendLayout();
            // 
            // btnBaja
            // 
            btnBaja.BackColor = Color.Red;
            btnBaja.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnBaja.ForeColor = SystemColors.ButtonHighlight;
            btnBaja.Location = new Point(1104, 396);
            btnBaja.Name = "btnBaja";
            btnBaja.Size = new Size(124, 42);
            btnBaja.TabIndex = 31;
            btnBaja.Text = "Eliminar";
            btnBaja.UseVisualStyleBackColor = false;
            btnBaja.Click += btnBaja_Click;
            // 
            // btnAlta
            // 
            btnAlta.BackColor = Color.SteelBlue;
            btnAlta.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnAlta.ForeColor = SystemColors.ButtonHighlight;
            btnAlta.Location = new Point(1104, 615);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(124, 42);
            btnAlta.TabIndex = 28;
            btnAlta.Text = "Alta";
            btnAlta.UseVisualStyleBackColor = false;
            btnAlta.Click += btnAlta_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label1.Location = new Point(1031, 63);
            label1.Name = "label1";
            label1.Size = new Size(117, 23);
            label1.TabIndex = 14;
            label1.Text = "Buscar por ID:";
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.SteelBlue;
            btnModificar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnModificar.ForeColor = SystemColors.ButtonHighlight;
            btnModificar.Location = new Point(919, 396);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(124, 42);
            btnModificar.TabIndex = 30;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 9);
            label7.Name = "label7";
            label7.Size = new Size(1238, 41);
            label7.TabIndex = 24;
            label7.Text = "ABM PROPIEDADES ";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(114, 81);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(257, 28);
            cmbTipo.TabIndex = 0;
            cmbTipo.SelectedIndexChanged += cmbTipo_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.Location = new Point(61, 81);
            label3.Name = "label3";
            label3.Size = new Size(47, 23);
            label3.TabIndex = 26;
            label3.Text = "Tipo:";
            // 
            // nudAmbientes
            // 
            nudAmbientes.Location = new Point(147, 26);
            nudAmbientes.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudAmbientes.Name = "nudAmbientes";
            nudAmbientes.Size = new Size(57, 27);
            nudAmbientes.TabIndex = 8;
            nudAmbientes.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudAmbientes.Enter += nudAmbientes_Enter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.Location = new Point(46, 26);
            label2.Name = "label2";
            label2.Size = new Size(95, 23);
            label2.TabIndex = 28;
            label2.Text = "Ambientes:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label4.Location = new Point(81, 71);
            label4.Name = "label4";
            label4.Size = new Size(60, 23);
            label4.TabIndex = 29;
            label4.Text = "Baños:";
            // 
            // nudBaños
            // 
            nudBaños.Location = new Point(147, 70);
            nudBaños.Name = "nudBaños";
            nudBaños.Size = new Size(57, 27);
            nudBaños.TabIndex = 9;
            nudBaños.Enter += nudBaños_Enter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label5.Location = new Point(37, 154);
            label5.Name = "label5";
            label5.Size = new Size(104, 23);
            label5.TabIndex = 31;
            label5.Text = "Dormitorios:";
            // 
            // nudDorm
            // 
            nudDorm.Location = new Point(147, 154);
            nudDorm.Name = "nudDorm";
            nudDorm.Size = new Size(57, 27);
            nudDorm.TabIndex = 11;
            nudDorm.Enter += nudDorm_Enter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label6.Location = new Point(50, 252);
            label6.Name = "label6";
            label6.Size = new Size(91, 23);
            label6.TabIndex = 33;
            label6.Text = "Años ant. :";
            // 
            // nudAntiguedad
            // 
            nudAntiguedad.Location = new Point(147, 248);
            nudAntiguedad.Name = "nudAntiguedad";
            nudAntiguedad.Size = new Size(57, 27);
            nudAntiguedad.TabIndex = 13;
            nudAntiguedad.Enter += nudAntiguedad_Enter;
            // 
            // cnM2
            // 
            cnM2.Location = new Point(114, 179);
            cnM2.MaxLength = 32767;
            cnM2.Name = "cnM2";
            cnM2.Size = new Size(257, 27);
            cnM2.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label8.Location = new Point(70, 179);
            label8.Name = "label8";
            label8.Size = new Size(38, 23);
            label8.TabIndex = 36;
            label8.Text = "m2:";
            // 
            // nudPlantas
            // 
            nudPlantas.Location = new Point(147, 202);
            nudPlantas.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudPlantas.Name = "nudPlantas";
            nudPlantas.Size = new Size(57, 27);
            nudPlantas.TabIndex = 12;
            nudPlantas.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudPlantas.Enter += nudPlantas_Enter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label9.Location = new Point(72, 206);
            label9.Name = "label9";
            label9.Size = new Size(69, 23);
            label9.TabIndex = 37;
            label9.Text = "Plantas:";
            // 
            // cmbOrientacion
            // 
            cmbOrientacion.FormattingEnabled = true;
            cmbOrientacion.Location = new Point(114, 132);
            cmbOrientacion.Name = "cmbOrientacion";
            cmbOrientacion.Size = new Size(257, 28);
            cmbOrientacion.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label10.Location = new Point(5, 132);
            label10.Name = "label10";
            label10.Size = new Size(103, 23);
            label10.TabIndex = 40;
            label10.Text = "Orientación:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label11.Location = new Point(23, 233);
            label11.Name = "label11";
            label11.Size = new Size(85, 23);
            label11.TabIndex = 41;
            label11.Text = "Domicilio:";
            // 
            // txtDomicilio
            // 
            txtDomicilio.Location = new Point(114, 233);
            txtDomicilio.Multiline = true;
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(257, 31);
            txtDomicilio.TabIndex = 3;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label12.Location = new Point(22, 288);
            label12.Name = "label12";
            label12.Size = new Size(86, 23);
            label12.TabIndex = 45;
            label12.Text = "Localidad:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(12, 481);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(359, 180);
            txtDescripcion.TabIndex = 7;
            // 
            // label13
            // 
            label13.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label13.Location = new Point(12, 444);
            label13.Name = "label13";
            label13.Size = new Size(359, 23);
            label13.TabIndex = 47;
            label13.Text = "Descripción comercial";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cnPropietario
            // 
            cnPropietario.Enabled = false;
            cnPropietario.Location = new Point(114, 340);
            cnPropietario.MaxLength = 32767;
            cnPropietario.Name = "cnPropietario";
            cnPropietario.Size = new Size(141, 28);
            cnPropietario.TabIndex = 6;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label14.Location = new Point(10, 337);
            label14.Name = "label14";
            label14.Size = new Size(98, 23);
            label14.TabIndex = 50;
            label14.Text = "Propietario:";
            // 
            // dgvPropiedades
            // 
            dgvPropiedades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPropiedades.Location = new Point(694, 92);
            dgvPropiedades.Name = "dgvPropiedades";
            dgvPropiedades.RowHeadersWidth = 51;
            dgvPropiedades.Size = new Size(556, 298);
            dgvPropiedades.TabIndex = 51;
            // 
            // btnBuscarProp
            // 
            btnBuscarProp.BackColor = Color.SteelBlue;
            btnBuscarProp.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnBuscarProp.ForeColor = SystemColors.ButtonHighlight;
            btnBuscarProp.Location = new Point(272, 337);
            btnBuscarProp.Name = "btnBuscarProp";
            btnBuscarProp.Size = new Size(99, 33);
            btnBuscarProp.TabIndex = 5;
            btnBuscarProp.Text = "Buscar";
            btnBuscarProp.UseVisualStyleBackColor = false;
            btnBuscarProp.Click += btnBuscarProp_Click;
            // 
            // cbGasNatural
            // 
            cbGasNatural.AutoSize = true;
            cbGasNatural.Location = new Point(20, 120);
            cbGasNatural.Name = "cbGasNatural";
            cbGasNatural.Size = new Size(105, 24);
            cbGasNatural.TabIndex = 17;
            cbGasNatural.Text = "Gas natural";
            cbGasNatural.UseVisualStyleBackColor = true;
            // 
            // cbCloaca
            // 
            cbCloaca.AutoSize = true;
            cbCloaca.Location = new Point(20, 81);
            cbCloaca.Name = "cbCloaca";
            cbCloaca.Size = new Size(76, 24);
            cbCloaca.TabIndex = 15;
            cbCloaca.Text = "Cloaca";
            cbCloaca.UseVisualStyleBackColor = true;
            // 
            // cbElectricidad
            // 
            cbElectricidad.AutoSize = true;
            cbElectricidad.Location = new Point(155, 81);
            cbElectricidad.Name = "cbElectricidad";
            cbElectricidad.Size = new Size(109, 24);
            cbElectricidad.TabIndex = 16;
            cbElectricidad.Text = "Electricidad";
            cbElectricidad.UseVisualStyleBackColor = true;
            // 
            // cbInternet
            // 
            cbInternet.AutoSize = true;
            cbInternet.Location = new Point(155, 44);
            cbInternet.Name = "cbInternet";
            cbInternet.Size = new Size(82, 24);
            cbInternet.TabIndex = 14;
            cbInternet.Text = "Internet";
            cbInternet.UseVisualStyleBackColor = true;
            // 
            // cbAguaCte
            // 
            cbAguaCte.AutoSize = true;
            cbAguaCte.Location = new Point(20, 159);
            cbAguaCte.Name = "cbAguaCte";
            cbAguaCte.Size = new Size(129, 24);
            cbAguaCte.TabIndex = 19;
            cbAguaCte.Text = "Agua corriente";
            cbAguaCte.UseVisualStyleBackColor = true;
            // 
            // cbPavimento
            // 
            cbPavimento.AutoSize = true;
            cbPavimento.Location = new Point(20, 44);
            cbPavimento.Name = "cbPavimento";
            cbPavimento.Size = new Size(100, 24);
            cbPavimento.TabIndex = 13;
            cbPavimento.Text = "Pavimento";
            cbPavimento.UseVisualStyleBackColor = true;
            // 
            // cbCocina
            // 
            cbCocina.AutoSize = true;
            cbCocina.Location = new Point(21, 44);
            cbCocina.Name = "cbCocina";
            cbCocina.Size = new Size(76, 24);
            cbCocina.TabIndex = 20;
            cbCocina.Text = "Cocina";
            cbCocina.UseVisualStyleBackColor = true;
            // 
            // cbGarage
            // 
            cbGarage.AutoSize = true;
            cbGarage.Location = new Point(139, 159);
            cbGarage.Name = "cbGarage";
            cbGarage.Size = new Size(79, 24);
            cbGarage.TabIndex = 27;
            cbGarage.Text = "Garage";
            cbGarage.UseVisualStyleBackColor = true;
            // 
            // cbLiving
            // 
            cbLiving.AutoSize = true;
            cbLiving.Location = new Point(139, 44);
            cbLiving.Name = "cbLiving";
            cbLiving.Size = new Size(138, 24);
            cbLiving.TabIndex = 21;
            cbLiving.Text = "Living/Comedor";
            cbLiving.UseVisualStyleBackColor = true;
            // 
            // cbPatio
            // 
            cbPatio.AutoSize = true;
            cbPatio.Location = new Point(21, 81);
            cbPatio.Name = "cbPatio";
            cbPatio.Size = new Size(64, 24);
            cbPatio.TabIndex = 22;
            cbPatio.Text = "Patio";
            cbPatio.UseVisualStyleBackColor = true;
            // 
            // cbJardin
            // 
            cbJardin.AutoSize = true;
            cbJardin.Location = new Point(139, 81);
            cbJardin.Name = "cbJardin";
            cbJardin.Size = new Size(70, 24);
            cbJardin.TabIndex = 23;
            cbJardin.Text = "Jardin";
            cbJardin.UseVisualStyleBackColor = true;
            // 
            // cbBalcon
            // 
            cbBalcon.AutoSize = true;
            cbBalcon.Location = new Point(21, 120);
            cbBalcon.Name = "cbBalcon";
            cbBalcon.Size = new Size(76, 24);
            cbBalcon.TabIndex = 24;
            cbBalcon.Text = "Balcón";
            cbBalcon.UseVisualStyleBackColor = true;
            // 
            // cbLavadero
            // 
            cbLavadero.AutoSize = true;
            cbLavadero.Location = new Point(21, 159);
            cbLavadero.Name = "cbLavadero";
            cbLavadero.Size = new Size(92, 24);
            cbLavadero.TabIndex = 26;
            cbLavadero.Text = "Lavadero";
            cbLavadero.UseVisualStyleBackColor = true;
            // 
            // cbTerraza
            // 
            cbTerraza.AutoSize = true;
            cbTerraza.Location = new Point(139, 120);
            cbTerraza.Name = "cbTerraza";
            cbTerraza.Size = new Size(79, 24);
            cbTerraza.TabIndex = 25;
            cbTerraza.Text = "Terraza";
            cbTerraza.UseVisualStyleBackColor = true;
            // 
            // nudToilette
            // 
            nudToilette.Location = new Point(147, 113);
            nudToilette.Name = "nudToilette";
            nudToilette.Size = new Size(57, 27);
            nudToilette.TabIndex = 10;
            nudToilette.Enter += nudToilette_Enter;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label18.Location = new Point(72, 113);
            label18.Name = "label18";
            label18.Size = new Size(69, 23);
            label18.TabIndex = 78;
            label18.Text = "Toilette:";
            // 
            // cbCable
            // 
            cbCable.AutoSize = true;
            cbCable.Location = new Point(155, 120);
            cbCable.Name = "cbCable";
            cbCable.Size = new Size(69, 24);
            cbCable.TabIndex = 18;
            cbCable.Text = "Cable";
            cbCable.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label15.ForeColor = Color.Red;
            label15.Location = new Point(377, 241);
            label15.Name = "label15";
            label15.Size = new Size(17, 23);
            label15.TabIndex = 81;
            label15.Text = "*";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label19.ForeColor = Color.Red;
            label19.Location = new Point(377, 292);
            label19.Name = "label19";
            label19.Size = new Size(17, 23);
            label19.TabIndex = 82;
            label19.Text = "*";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label22.ForeColor = Color.Red;
            label22.Location = new Point(377, 342);
            label22.Name = "label22";
            label22.Size = new Size(17, 23);
            label22.TabIndex = 85;
            label22.Text = "*";
            // 
            // cnPrecio
            // 
            cnPrecio.Location = new Point(114, 396);
            cnPrecio.MaxLength = 32767;
            cnPrecio.Name = "cnPrecio";
            cnPrecio.Size = new Size(257, 28);
            cnPrecio.TabIndex = 6;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label20.Location = new Point(9, 396);
            label20.Name = "label20";
            label20.Size = new Size(99, 23);
            label20.TabIndex = 88;
            label20.Text = "Precio USD:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label21.ForeColor = Color.Red;
            label21.Location = new Point(377, 396);
            label21.Name = "label21";
            label21.Size = new Size(17, 23);
            label21.TabIndex = 89;
            label21.Text = "*";
            // 
            // cmbLocalidad
            // 
            cmbLocalidad.FormattingEnabled = true;
            cmbLocalidad.Location = new Point(114, 287);
            cmbLocalidad.Name = "cmbLocalidad";
            cmbLocalidad.Size = new Size(257, 28);
            cmbLocalidad.TabIndex = 4;
            // 
            // gbEstructura
            // 
            gbEstructura.Controls.Add(nudAmbientes);
            gbEstructura.Controls.Add(label2);
            gbEstructura.Controls.Add(label4);
            gbEstructura.Controls.Add(nudBaños);
            gbEstructura.Controls.Add(label5);
            gbEstructura.Controls.Add(nudDorm);
            gbEstructura.Controls.Add(label6);
            gbEstructura.Controls.Add(nudAntiguedad);
            gbEstructura.Controls.Add(nudToilette);
            gbEstructura.Controls.Add(label9);
            gbEstructura.Controls.Add(label18);
            gbEstructura.Controls.Add(nudPlantas);
            gbEstructura.Location = new Point(425, 81);
            gbEstructura.Name = "gbEstructura";
            gbEstructura.Size = new Size(256, 311);
            gbEstructura.TabIndex = 8;
            gbEstructura.TabStop = false;
            gbEstructura.Text = "Estructura";
            // 
            // gbServicios
            // 
            gbServicios.Controls.Add(cbInternet);
            gbServicios.Controls.Add(cbGasNatural);
            gbServicios.Controls.Add(cbCloaca);
            gbServicios.Controls.Add(cbElectricidad);
            gbServicios.Controls.Add(cbAguaCte);
            gbServicios.Controls.Add(cbPavimento);
            gbServicios.Controls.Add(cbCable);
            gbServicios.Location = new Point(406, 467);
            gbServicios.Name = "gbServicios";
            gbServicios.Size = new Size(290, 194);
            gbServicios.TabIndex = 14;
            gbServicios.TabStop = false;
            gbServicios.Text = "Servicios";
            // 
            // gbAmbientes
            // 
            gbAmbientes.Controls.Add(cbTerraza);
            gbAmbientes.Controls.Add(cbJardin);
            gbAmbientes.Controls.Add(cbPatio);
            gbAmbientes.Controls.Add(cbLiving);
            gbAmbientes.Controls.Add(cbGarage);
            gbAmbientes.Controls.Add(cbCocina);
            gbAmbientes.Controls.Add(cbBalcon);
            gbAmbientes.Controls.Add(cbLavadero);
            gbAmbientes.Location = new Point(713, 467);
            gbAmbientes.Name = "gbAmbientes";
            gbAmbientes.Size = new Size(284, 194);
            gbAmbientes.TabIndex = 15;
            gbAmbientes.TabStop = false;
            gbAmbientes.Text = "Ambientes";
            // 
            // txtBuscarID
            // 
            txtBuscarID.Location = new Point(1154, 63);
            txtBuscarID.Name = "txtBuscarID";
            txtBuscarID.Size = new Size(86, 27);
            txtBuscarID.TabIndex = 90;
            txtBuscarID.TextChanged += txtBuscarID_TextChanged;
            // 
            // txtBuscarDomicilio
            // 
            txtBuscarDomicilio.Location = new Point(869, 63);
            txtBuscarDomicilio.Name = "txtBuscarDomicilio";
            txtBuscarDomicilio.Size = new Size(137, 27);
            txtBuscarDomicilio.TabIndex = 92;
            txtBuscarDomicilio.TextChanged += txtBuscarDomicilio_TextChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label16.Location = new Point(694, 63);
            label16.Name = "label16";
            label16.Size = new Size(169, 23);
            label16.TabIndex = 91;
            label16.Text = "Buscar por domicilio:";
            // 
            // FormAbmPropiedades
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(txtBuscarDomicilio);
            Controls.Add(label16);
            Controls.Add(txtBuscarID);
            Controls.Add(cmbLocalidad);
            Controls.Add(label21);
            Controls.Add(label20);
            Controls.Add(cnPrecio);
            Controls.Add(label22);
            Controls.Add(label19);
            Controls.Add(label15);
            Controls.Add(btnBuscarProp);
            Controls.Add(dgvPropiedades);
            Controls.Add(cnPropietario);
            Controls.Add(label14);
            Controls.Add(txtDescripcion);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(txtDomicilio);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(cmbOrientacion);
            Controls.Add(label8);
            Controls.Add(cnM2);
            Controls.Add(label3);
            Controls.Add(cmbTipo);
            Controls.Add(label7);
            Controls.Add(btnModificar);
            Controls.Add(btnBaja);
            Controls.Add(btnAlta);
            Controls.Add(label1);
            Controls.Add(gbEstructura);
            Controls.Add(gbServicios);
            Controls.Add(gbAmbientes);
            Name = "FormAbmPropiedades";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCatalogoPropiedades";
            FormClosed += FormAbmPropiedades_FormClosed;
            Load += FormAbmPropiedades_Load;
            Enter += nudBaños_Enter;
            ((System.ComponentModel.ISupportInitialize)nudAmbientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudBaños).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDorm).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAntiguedad).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPlantas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPropiedades).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudToilette).EndInit();
            gbEstructura.ResumeLayout(false);
            gbEstructura.PerformLayout();
            gbServicios.ResumeLayout(false);
            gbServicios.PerformLayout();
            gbAmbientes.ResumeLayout(false);
            gbAmbientes.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnBaja;
        private Button btnAlta;
        private Label label1;
        private Button btnModificar;
        private Label label7;
        private ComboBox cmbTipo;
        private Label label3;
        private NumericUpDown nudAmbientes;
        private Label label2;
        private Label label4;
        private NumericUpDown nudBaños;
        private Label label5;
        private NumericUpDown nudDorm;
        private Label label6;
        private NumericUpDown nudAntiguedad;
        private ControlesDeUsuario.CajaNumerica cnM2;
        private Label label8;
        private NumericUpDown nudPlantas;
        private Label label9;
        private ComboBox cmbOrientacion;
        private Label label10;
        private Label label11;
        private TextBox txtDomicilio;
        private Label label12;
        private TextBox txtDescripcion;
        private Label label13;
        private ControlesDeUsuario.CajaNumerica cnPropietario;
        private Label label14;
        private DataGridView dgvPropiedades;
        private Button btnBuscarProp;
        private CheckBox cbGasNatural;
        private CheckBox cbCloaca;
        private CheckBox cbElectricidad;
        private CheckBox cbInternet;
        private CheckBox cbAguaCte;
        private CheckBox cbPavimento;
        private Label label17;
        private CheckBox cbCocina;
        private CheckBox cbGarage;
        private CheckBox cbLiving;
        private CheckBox cbPatio;
        private CheckBox cbJardin;
        private CheckBox cbBalcon;
        private CheckBox cbLavadero;
        private CheckBox cbTerraza;
        private NumericUpDown nudToilette;
        private Label label18;
        private CheckBox cbCable;
        private Label label15;
        private Label label19;
        private Label label22;
        private ControlesDeUsuario.CajaNumerica cnPrecio;
        private Label label20;
        private Label label21;
        private ComboBox cmbLocalidad;
        private GroupBox gbEstructura;
        private GroupBox gbServicios;
        private GroupBox gbAmbientes;
        private TextBox txtBuscarID;
        private TextBox txtBuscarDomicilio;
        private Label label16;
    }
}