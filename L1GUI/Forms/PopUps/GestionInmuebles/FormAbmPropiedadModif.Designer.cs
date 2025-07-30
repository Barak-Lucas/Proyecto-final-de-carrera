namespace L1GUI.Forms
{
    partial class FormAbmPropiedadModif
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
            label21 = new Label();
            label20 = new Label();
            cnPrecio = new ControlesDeUsuario.CajaNumerica();
            label19 = new Label();
            label15 = new Label();
            cbCable = new CheckBox();
            nudToilette = new NumericUpDown();
            label18 = new Label();
            cbTerraza = new CheckBox();
            cbLavadero = new CheckBox();
            cbBalcon = new CheckBox();
            cbCocina = new CheckBox();
            cbGarage = new CheckBox();
            cbLiving = new CheckBox();
            cbPatio = new CheckBox();
            cbJardin = new CheckBox();
            cbPavimento = new CheckBox();
            cbAguaCte = new CheckBox();
            cbInternet = new CheckBox();
            cbElectricidad = new CheckBox();
            cbCloaca = new CheckBox();
            cbGasNatural = new CheckBox();
            txtDescripcion = new TextBox();
            label13 = new Label();
            label12 = new Label();
            txtDomicilio = new TextBox();
            label11 = new Label();
            label10 = new Label();
            cmbOrientacion = new ComboBox();
            nudPlantas = new NumericUpDown();
            label9 = new Label();
            label8 = new Label();
            cnM2 = new ControlesDeUsuario.CajaNumerica();
            nudAntiguedad = new NumericUpDown();
            label6 = new Label();
            nudDorm = new NumericUpDown();
            label5 = new Label();
            nudBaños = new NumericUpDown();
            label4 = new Label();
            label2 = new Label();
            nudAmbientes = new NumericUpDown();
            label3 = new Label();
            cmbTipo = new ComboBox();
            lblTitulo = new Label();
            btnModificar = new Button();
            btnCancelar = new Button();
            cmbLocalidad = new ComboBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)nudToilette).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPlantas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAntiguedad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDorm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudBaños).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAmbientes).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label21.ForeColor = Color.Red;
            label21.Location = new Point(384, 363);
            label21.Name = "label21";
            label21.Size = new Size(17, 23);
            label21.TabIndex = 139;
            label21.Text = "*";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label20.Location = new Point(16, 363);
            label20.Name = "label20";
            label20.Size = new Size(99, 23);
            label20.TabIndex = 138;
            label20.Text = "Precio USD:";
            // 
            // cnPrecio
            // 
            cnPrecio.Location = new Point(121, 363);
            cnPrecio.MaxLength = 32767;
            cnPrecio.Name = "cnPrecio";
            cnPrecio.Size = new Size(257, 28);
            cnPrecio.TabIndex = 6;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label19.ForeColor = Color.Red;
            label19.Location = new Point(384, 311);
            label19.Name = "label19";
            label19.Size = new Size(17, 23);
            label19.TabIndex = 137;
            label19.Text = "*";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label15.ForeColor = Color.Red;
            label15.Location = new Point(384, 260);
            label15.Name = "label15";
            label15.Size = new Size(17, 23);
            label15.TabIndex = 136;
            label15.Text = "*";
            // 
            // cbCable
            // 
            cbCable.AutoSize = true;
            cbCable.Location = new Point(159, 117);
            cbCable.Name = "cbCable";
            cbCable.Size = new Size(69, 24);
            cbCable.TabIndex = 18;
            cbCable.Text = "Cable";
            cbCable.UseVisualStyleBackColor = true;
            // 
            // nudToilette
            // 
            nudToilette.Location = new Point(547, 25);
            nudToilette.Name = "nudToilette";
            nudToilette.Size = new Size(57, 27);
            nudToilette.TabIndex = 9;
            nudToilette.Enter += nudToilette_Enter;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label18.Location = new Point(921, 88);
            label18.Name = "label18";
            label18.Size = new Size(69, 23);
            label18.TabIndex = 134;
            label18.Text = "Toilette:";
            // 
            // cbTerraza
            // 
            cbTerraza.AutoSize = true;
            cbTerraza.Location = new Point(140, 117);
            cbTerraza.Name = "cbTerraza";
            cbTerraza.Size = new Size(79, 24);
            cbTerraza.TabIndex = 25;
            cbTerraza.Text = "Terraza";
            cbTerraza.UseVisualStyleBackColor = true;
            // 
            // cbLavadero
            // 
            cbLavadero.AutoSize = true;
            cbLavadero.Location = new Point(22, 156);
            cbLavadero.Name = "cbLavadero";
            cbLavadero.Size = new Size(92, 24);
            cbLavadero.TabIndex = 26;
            cbLavadero.Text = "Lavadero";
            cbLavadero.UseVisualStyleBackColor = true;
            // 
            // cbBalcon
            // 
            cbBalcon.AutoSize = true;
            cbBalcon.Location = new Point(22, 117);
            cbBalcon.Name = "cbBalcon";
            cbBalcon.Size = new Size(76, 24);
            cbBalcon.TabIndex = 24;
            cbBalcon.Text = "Balcón";
            cbBalcon.UseVisualStyleBackColor = true;
            // 
            // cbCocina
            // 
            cbCocina.AutoSize = true;
            cbCocina.Location = new Point(22, 41);
            cbCocina.Name = "cbCocina";
            cbCocina.Size = new Size(76, 24);
            cbCocina.TabIndex = 20;
            cbCocina.Text = "Cocina";
            cbCocina.UseVisualStyleBackColor = true;
            // 
            // cbGarage
            // 
            cbGarage.AutoSize = true;
            cbGarage.Location = new Point(140, 156);
            cbGarage.Name = "cbGarage";
            cbGarage.Size = new Size(79, 24);
            cbGarage.TabIndex = 27;
            cbGarage.Text = "Garage";
            cbGarage.UseVisualStyleBackColor = true;
            // 
            // cbLiving
            // 
            cbLiving.AutoSize = true;
            cbLiving.Location = new Point(140, 41);
            cbLiving.Name = "cbLiving";
            cbLiving.Size = new Size(138, 24);
            cbLiving.TabIndex = 21;
            cbLiving.Text = "Living/Comedor";
            cbLiving.UseVisualStyleBackColor = true;
            // 
            // cbPatio
            // 
            cbPatio.AutoSize = true;
            cbPatio.Location = new Point(22, 78);
            cbPatio.Name = "cbPatio";
            cbPatio.Size = new Size(64, 24);
            cbPatio.TabIndex = 22;
            cbPatio.Text = "Patio";
            cbPatio.UseVisualStyleBackColor = true;
            // 
            // cbJardin
            // 
            cbJardin.AutoSize = true;
            cbJardin.Location = new Point(140, 78);
            cbJardin.Name = "cbJardin";
            cbJardin.Size = new Size(70, 24);
            cbJardin.TabIndex = 23;
            cbJardin.Text = "Jardin";
            cbJardin.UseVisualStyleBackColor = true;
            // 
            // cbPavimento
            // 
            cbPavimento.AutoSize = true;
            cbPavimento.Location = new Point(24, 41);
            cbPavimento.Name = "cbPavimento";
            cbPavimento.Size = new Size(100, 24);
            cbPavimento.TabIndex = 13;
            cbPavimento.Text = "Pavimento";
            cbPavimento.UseVisualStyleBackColor = true;
            // 
            // cbAguaCte
            // 
            cbAguaCte.AutoSize = true;
            cbAguaCte.Location = new Point(24, 156);
            cbAguaCte.Name = "cbAguaCte";
            cbAguaCte.Size = new Size(129, 24);
            cbAguaCte.TabIndex = 19;
            cbAguaCte.Text = "Agua corriente";
            cbAguaCte.UseVisualStyleBackColor = true;
            // 
            // cbInternet
            // 
            cbInternet.AutoSize = true;
            cbInternet.Location = new Point(159, 41);
            cbInternet.Name = "cbInternet";
            cbInternet.Size = new Size(82, 24);
            cbInternet.TabIndex = 14;
            cbInternet.Text = "Internet";
            cbInternet.UseVisualStyleBackColor = true;
            // 
            // cbElectricidad
            // 
            cbElectricidad.AutoSize = true;
            cbElectricidad.Location = new Point(159, 78);
            cbElectricidad.Name = "cbElectricidad";
            cbElectricidad.Size = new Size(109, 24);
            cbElectricidad.TabIndex = 16;
            cbElectricidad.Text = "Electricidad";
            cbElectricidad.UseVisualStyleBackColor = true;
            // 
            // cbCloaca
            // 
            cbCloaca.AutoSize = true;
            cbCloaca.Location = new Point(24, 78);
            cbCloaca.Name = "cbCloaca";
            cbCloaca.Size = new Size(76, 24);
            cbCloaca.TabIndex = 15;
            cbCloaca.Text = "Cloaca";
            cbCloaca.UseVisualStyleBackColor = true;
            // 
            // cbGasNatural
            // 
            cbGasNatural.AutoSize = true;
            cbGasNatural.Location = new Point(24, 117);
            cbGasNatural.Name = "cbGasNatural";
            cbGasNatural.Size = new Size(105, 24);
            cbGasNatural.TabIndex = 17;
            cbGasNatural.Text = "Gas natural";
            cbGasNatural.UseVisualStyleBackColor = true;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(16, 457);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(575, 182);
            txtDescripcion.TabIndex = 0;
            // 
            // label13
            // 
            label13.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label13.Location = new Point(16, 431);
            label13.Name = "label13";
            label13.Size = new Size(575, 23);
            label13.TabIndex = 115;
            label13.Text = "Descripción comercial";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label12.Location = new Point(29, 307);
            label12.Name = "label12";
            label12.Size = new Size(86, 23);
            label12.TabIndex = 114;
            label12.Text = "Localidad:";
            // 
            // txtDomicilio
            // 
            txtDomicilio.Location = new Point(121, 252);
            txtDomicilio.Multiline = true;
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(257, 31);
            txtDomicilio.TabIndex = 4;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label11.Location = new Point(30, 252);
            label11.Name = "label11";
            label11.Size = new Size(85, 23);
            label11.TabIndex = 113;
            label11.Text = "Domicilio:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label10.Location = new Point(12, 151);
            label10.Name = "label10";
            label10.Size = new Size(103, 23);
            label10.TabIndex = 112;
            label10.Text = "Orientación:";
            // 
            // cmbOrientacion
            // 
            cmbOrientacion.FormattingEnabled = true;
            cmbOrientacion.Location = new Point(121, 151);
            cmbOrientacion.Name = "cmbOrientacion";
            cmbOrientacion.Size = new Size(257, 28);
            cmbOrientacion.TabIndex = 2;
            // 
            // nudPlantas
            // 
            nudPlantas.Location = new Point(328, 25);
            nudPlantas.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudPlantas.Name = "nudPlantas";
            nudPlantas.Size = new Size(57, 27);
            nudPlantas.TabIndex = 8;
            nudPlantas.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudPlantas.Enter += nudPlantas_Enter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label9.Location = new Point(702, 92);
            label9.Name = "label9";
            label9.Size = new Size(69, 23);
            label9.TabIndex = 111;
            label9.Text = "Plantas:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label8.Location = new Point(77, 198);
            label8.Name = "label8";
            label8.Size = new Size(38, 23);
            label8.TabIndex = 110;
            label8.Text = "m2:";
            // 
            // cnM2
            // 
            cnM2.Location = new Point(121, 198);
            cnM2.MaxLength = 32767;
            cnM2.Name = "cnM2";
            cnM2.Size = new Size(257, 27);
            cnM2.TabIndex = 3;
            // 
            // nudAntiguedad
            // 
            nudAntiguedad.Location = new Point(328, 71);
            nudAntiguedad.Name = "nudAntiguedad";
            nudAntiguedad.Size = new Size(57, 27);
            nudAntiguedad.TabIndex = 11;
            nudAntiguedad.Enter += nudAntiguedad_Enter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label6.Location = new Point(680, 136);
            label6.Name = "label6";
            label6.Size = new Size(91, 23);
            label6.TabIndex = 109;
            label6.Text = "Años ant. :";
            // 
            // nudDorm
            // 
            nudDorm.Location = new Point(547, 70);
            nudDorm.Name = "nudDorm";
            nudDorm.Size = new Size(57, 27);
            nudDorm.TabIndex = 12;
            nudDorm.Enter += nudDorm_Enter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label5.Location = new Point(886, 136);
            label5.Name = "label5";
            label5.Size = new Size(104, 23);
            label5.TabIndex = 108;
            label5.Text = "Dormitorios:";
            // 
            // nudBaños
            // 
            nudBaños.Location = new Point(111, 73);
            nudBaños.Name = "nudBaños";
            nudBaños.Size = new Size(57, 27);
            nudBaños.TabIndex = 10;
            nudBaños.Enter += nudBaños_Enter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label4.Location = new Point(494, 137);
            label4.Name = "label4";
            label4.Size = new Size(60, 23);
            label4.TabIndex = 107;
            label4.Text = "Baños:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.Location = new Point(459, 92);
            label2.Name = "label2";
            label2.Size = new Size(95, 23);
            label2.TabIndex = 106;
            label2.Text = "Ambientes:";
            // 
            // nudAmbientes
            // 
            nudAmbientes.Location = new Point(111, 29);
            nudAmbientes.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudAmbientes.Name = "nudAmbientes";
            nudAmbientes.Size = new Size(57, 27);
            nudAmbientes.TabIndex = 7;
            nudAmbientes.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudAmbientes.Enter += nudAmbientes_Enter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.Location = new Point(68, 100);
            label3.Name = "label3";
            label3.Size = new Size(47, 23);
            label3.TabIndex = 105;
            label3.Text = "Tipo:";
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(121, 100);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(257, 28);
            cmbTipo.TabIndex = 1;
            cmbTipo.SelectedIndexChanged += cmbTipo_SelectedIndexChanged;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ControlText;
            lblTitulo.Location = new Point(12, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(1085, 41);
            lblTitulo.TabIndex = 104;
            lblTitulo.Text = "MODIFICANDO PROPIEDAD ";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.SteelBlue;
            btnModificar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnModificar.ForeColor = SystemColors.ButtonHighlight;
            btnModificar.Location = new Point(680, 583);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(147, 56);
            btnModificar.TabIndex = 28;
            btnModificar.Text = "Confirmar modificación";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.SteelBlue;
            btnCancelar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnCancelar.ForeColor = SystemColors.ButtonHighlight;
            btnCancelar.Location = new Point(906, 583);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(147, 56);
            btnCancelar.TabIndex = 29;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cmbLocalidad
            // 
            cmbLocalidad.FormattingEnabled = true;
            cmbLocalidad.Location = new Point(121, 307);
            cmbLocalidad.Name = "cmbLocalidad";
            cmbLocalidad.Size = new Size(257, 28);
            cmbLocalidad.TabIndex = 140;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(nudDorm);
            groupBox1.Controls.Add(nudAmbientes);
            groupBox1.Controls.Add(nudBaños);
            groupBox1.Controls.Add(nudAntiguedad);
            groupBox1.Controls.Add(nudPlantas);
            groupBox1.Controls.Add(nudToilette);
            groupBox1.Location = new Point(449, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(648, 141);
            groupBox1.TabIndex = 141;
            groupBox1.TabStop = false;
            groupBox1.Text = "Estructura";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbCable);
            groupBox2.Controls.Add(cbGasNatural);
            groupBox2.Controls.Add(cbCloaca);
            groupBox2.Controls.Add(cbElectricidad);
            groupBox2.Controls.Add(cbInternet);
            groupBox2.Controls.Add(cbAguaCte);
            groupBox2.Controls.Add(cbPavimento);
            groupBox2.Location = new Point(449, 210);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(298, 192);
            groupBox2.TabIndex = 142;
            groupBox2.TabStop = false;
            groupBox2.Text = "Servicios";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cbLiving);
            groupBox3.Controls.Add(cbJardin);
            groupBox3.Controls.Add(cbPatio);
            groupBox3.Controls.Add(cbGarage);
            groupBox3.Controls.Add(cbCocina);
            groupBox3.Controls.Add(cbBalcon);
            groupBox3.Controls.Add(cbLavadero);
            groupBox3.Controls.Add(cbTerraza);
            groupBox3.Location = new Point(810, 210);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(287, 192);
            groupBox3.TabIndex = 143;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ambientes";
            // 
            // FormAbmPropiedadModif
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1109, 673);
            Controls.Add(cmbLocalidad);
            Controls.Add(btnCancelar);
            Controls.Add(label21);
            Controls.Add(label20);
            Controls.Add(cnPrecio);
            Controls.Add(label19);
            Controls.Add(label15);
            Controls.Add(label18);
            Controls.Add(txtDescripcion);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(txtDomicilio);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(cmbOrientacion);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(cnM2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(cmbTipo);
            Controls.Add(lblTitulo);
            Controls.Add(btnModificar);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Name = "FormAbmPropiedadModif";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAbmPropiedadModif";
            Load += FormAbmPropiedadModif_Load;
            ((System.ComponentModel.ISupportInitialize)nudToilette).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPlantas).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAntiguedad).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDorm).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudBaños).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAmbientes).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label21;
        private Label label20;
        private ControlesDeUsuario.CajaNumerica cnPrecio;
        private Label label19;
        private Label label15;
        private CheckBox cbCable;
        private NumericUpDown nudToilette;
        private Label label18;
        private CheckBox cbTerraza;
        private CheckBox cbLavadero;
        private CheckBox cbBalcon;
        private CheckBox cbCocina;
        private CheckBox cbGarage;
        private CheckBox cbLiving;
        private CheckBox cbPatio;
        private CheckBox cbJardin;
        private CheckBox cbPavimento;
        private CheckBox cbAguaCte;
        private CheckBox cbInternet;
        private CheckBox cbElectricidad;
        private CheckBox cbCloaca;
        private CheckBox cbGasNatural;
        private TextBox txtDescripcion;
        private Label label13;
        private Label label12;
        private TextBox txtDomicilio;
        private Label label11;
        private Label label10;
        private ComboBox cmbOrientacion;
        private NumericUpDown nudPlantas;
        private Label label9;
        private Label label8;
        private ControlesDeUsuario.CajaNumerica cnM2;
        private NumericUpDown nudAntiguedad;
        private Label label6;
        private NumericUpDown nudDorm;
        private Label label5;
        private NumericUpDown nudBaños;
        private Label label4;
        private Label label2;
        private NumericUpDown nudAmbientes;
        private Label label3;
        private ComboBox cmbTipo;
        private Label lblTitulo;
        private Button btnModificar;
        private Button btnCancelar;
        private ComboBox cmbLocalidad;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
    }
}