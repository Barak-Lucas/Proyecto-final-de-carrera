namespace L1GUI.Forms
{
    partial class FormDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            cBarras = new System.Windows.Forms.DataVisualization.Charting.Chart();
            cTorta = new System.Windows.Forms.DataVisualization.Charting.Chart();
            rbConsultadas = new RadioButton();
            rbVendidas = new RadioButton();
            label1 = new Label();
            label3 = new Label();
            lblPropiedades = new Label();
            label5 = new Label();
            label6 = new Label();
            btnMes = new Button();
            rbVentas = new RadioButton();
            rbTasaciones = new RadioButton();
            rbInteracciones = new RadioButton();
            label2 = new Label();
            dtp1 = new DateTimePicker();
            btnHoy = new Button();
            btnSemana = new Button();
            btMes = new Button();
            btnUltimos = new Button();
            dgvContratos = new DataGridView();
            lblIngresosBrutos = new Label();
            lblPropiedadesCount = new Label();
            lblClientesCount = new Label();
            label4 = new Label();
            gpEnGestion = new GroupBox();
            lblPropietariosCount = new Label();
            gboxTipo = new GroupBox();
            lblIngresosBrutosValue = new Label();
            lblSinInformacion = new Label();
            lblSinInformacion2 = new Label();
            groupBox1 = new GroupBox();
            rbProximoMes = new RadioButton();
            rbProximaSemana = new RadioButton();
            rbTodos = new RadioButton();
            rbVisitas = new RadioButton();
            lblBrutosARS = new Label();
            ((System.ComponentModel.ISupportInitialize)cBarras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cTorta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvContratos).BeginInit();
            gpEnGestion.SuspendLayout();
            gboxTipo.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // cBarras
            // 
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Area3DStyle.Inclination = 20;
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.None;
            chartArea1.Area3DStyle.Rotation = 10;
            chartArea1.Name = "ChartArea1";
            cBarras.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            cBarras.Legends.Add(legend1);
            cBarras.Location = new Point(12, 164);
            cBarras.Name = "cBarras";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            cBarras.Series.Add(series1);
            cBarras.Size = new Size(857, 237);
            cBarras.TabIndex = 2;
            // 
            // cTorta
            // 
            chartArea2.Area3DStyle.Enable3D = true;
            chartArea2.Area3DStyle.Inclination = 25;
            chartArea2.Area3DStyle.IsRightAngleAxes = false;
            chartArea2.Name = "ChartArea1";
            cTorta.ChartAreas.Add(chartArea2);
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Name = "Legend1";
            cTorta.Legends.Add(legend2);
            cTorta.Location = new Point(921, 142);
            cTorta.Name = "cTorta";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            cTorta.Series.Add(series2);
            cTorta.Size = new Size(329, 519);
            cTorta.TabIndex = 4;
            // 
            // rbConsultadas
            // 
            rbConsultadas.AutoSize = true;
            rbConsultadas.Font = new Font("Times New Roman", 9F);
            rbConsultadas.Location = new Point(6, 11);
            rbConsultadas.Name = "rbConsultadas";
            rbConsultadas.Size = new Size(165, 21);
            rbConsultadas.TabIndex = 6;
            rbConsultadas.TabStop = true;
            rbConsultadas.Text = "MÁS CONSULTADO";
            rbConsultadas.UseVisualStyleBackColor = true;
            rbConsultadas.CheckedChanged += rbConsultadas_CheckedChanged;
            // 
            // rbVendidas
            // 
            rbVendidas.AutoSize = true;
            rbVendidas.Font = new Font("Times New Roman", 9F);
            rbVendidas.Location = new Point(177, 10);
            rbVendidas.Name = "rbVendidas";
            rbVendidas.Size = new Size(134, 21);
            rbVendidas.TabIndex = 7;
            rbVendidas.TabStop = true;
            rbVendidas.Text = "MÁS VENDIDO";
            rbVendidas.UseVisualStyleBackColor = true;
            rbVendidas.CheckedChanged += rbVendidas_CheckedChanged;
            // 
            // label1
            // 
            label1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(921, 151);
            label1.Name = "label1";
            label1.Size = new Size(329, 19);
            label1.TabIndex = 8;
            label1.Text = "TIPO DE PROPIEDAD";
            label1.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 422);
            label3.Name = "label3";
            label3.Size = new Size(109, 26);
            label3.TabIndex = 9;
            label3.Text = "En gestión";
            // 
            // lblPropiedades
            // 
            lblPropiedades.AutoSize = true;
            lblPropiedades.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPropiedades.ForeColor = SystemColors.ButtonShadow;
            lblPropiedades.Location = new Point(73, 474);
            lblPropiedades.Name = "lblPropiedades";
            lblPropiedades.Size = new Size(101, 19);
            lblPropiedades.TabIndex = 10;
            lblPropiedades.Text = "Propiedades";
            lblPropiedades.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonShadow;
            label5.Location = new Point(73, 539);
            label5.Name = "label5";
            label5.Size = new Size(104, 19);
            label5.TabIndex = 11;
            label5.Text = "Propietarios";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonShadow;
            label6.Location = new Point(73, 602);
            label6.Name = "label6";
            label6.Size = new Size(71, 19);
            label6.TabIndex = 12;
            label6.Text = "Clientes";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnMes
            // 
            btnMes.BackColor = Color.SteelBlue;
            btnMes.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnMes.ForeColor = SystemColors.ButtonHighlight;
            btnMes.Location = new Point(1104, 12);
            btnMes.Name = "btnMes";
            btnMes.Size = new Size(146, 39);
            btnMes.TabIndex = 34;
            btnMes.Text = "Este mes";
            btnMes.UseVisualStyleBackColor = false;
            // 
            // rbVentas
            // 
            rbVentas.AutoSize = true;
            rbVentas.Font = new Font("Times New Roman", 9F);
            rbVentas.Location = new Point(707, 189);
            rbVentas.Name = "rbVentas";
            rbVentas.Size = new Size(87, 21);
            rbVentas.TabIndex = 36;
            rbVentas.TabStop = true;
            rbVentas.Text = "VENTAS";
            rbVentas.UseVisualStyleBackColor = true;
            rbVentas.CheckedChanged += rbVentas_CheckedChanged;
            // 
            // rbTasaciones
            // 
            rbTasaciones.AutoSize = true;
            rbTasaciones.Font = new Font("Times New Roman", 9F);
            rbTasaciones.Location = new Point(519, 189);
            rbTasaciones.Name = "rbTasaciones";
            rbTasaciones.Size = new Size(121, 21);
            rbTasaciones.TabIndex = 37;
            rbTasaciones.TabStop = true;
            rbTasaciones.Text = "TASACIONES";
            rbTasaciones.UseVisualStyleBackColor = true;
            rbTasaciones.CheckedChanged += rbTasaciones_CheckedChanged;
            // 
            // rbInteracciones
            // 
            rbInteracciones.AutoSize = true;
            rbInteracciones.Font = new Font("Times New Roman", 9F);
            rbInteracciones.Location = new Point(153, 189);
            rbInteracciones.Name = "rbInteracciones";
            rbInteracciones.Size = new Size(148, 21);
            rbInteracciones.TabIndex = 38;
            rbInteracciones.TabStop = true;
            rbInteracciones.Text = "INTERACCIONES";
            rbInteracciones.UseVisualStyleBackColor = true;
            rbInteracciones.CheckedChanged += rbInteracciones_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F);
            label2.Location = new Point(295, 422);
            label2.Name = "label2";
            label2.Size = new Size(260, 26);
            label2.TabIndex = 41;
            label2.Text = "Contratos por vencimiento";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtp1
            // 
            dtp1.Location = new Point(437, 17);
            dtp1.Name = "dtp1";
            dtp1.Size = new Size(192, 27);
            dtp1.TabIndex = 44;
            dtp1.CloseUp += dtp1_CloseUp;
            // 
            // btnHoy
            // 
            btnHoy.BackColor = Color.SteelBlue;
            btnHoy.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnHoy.ForeColor = SystemColors.ButtonHighlight;
            btnHoy.Location = new Point(648, 12);
            btnHoy.Name = "btnHoy";
            btnHoy.Size = new Size(146, 39);
            btnHoy.TabIndex = 45;
            btnHoy.Text = "Día de hoy";
            btnHoy.UseVisualStyleBackColor = false;
            btnHoy.Click += btnHoy_Click;
            // 
            // btnSemana
            // 
            btnSemana.BackColor = Color.SteelBlue;
            btnSemana.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnSemana.ForeColor = SystemColors.ButtonHighlight;
            btnSemana.Location = new Point(800, 12);
            btnSemana.Name = "btnSemana";
            btnSemana.Size = new Size(146, 39);
            btnSemana.TabIndex = 46;
            btnSemana.Text = "Esta semana";
            btnSemana.UseVisualStyleBackColor = false;
            btnSemana.Click += btnSemana_Click;
            // 
            // btMes
            // 
            btMes.BackColor = Color.SteelBlue;
            btMes.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btMes.ForeColor = SystemColors.ButtonHighlight;
            btMes.Location = new Point(952, 12);
            btMes.Name = "btMes";
            btMes.Size = new Size(146, 39);
            btMes.TabIndex = 49;
            btMes.Text = "Este mes";
            btMes.UseVisualStyleBackColor = false;
            btMes.Click += btMes_Click;
            // 
            // btnUltimos
            // 
            btnUltimos.BackColor = Color.SteelBlue;
            btnUltimos.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnUltimos.ForeColor = SystemColors.ButtonHighlight;
            btnUltimos.Location = new Point(1104, 12);
            btnUltimos.Name = "btnUltimos";
            btnUltimos.Size = new Size(146, 39);
            btnUltimos.TabIndex = 50;
            btnUltimos.Text = "Ultimos 30 días";
            btnUltimos.UseVisualStyleBackColor = false;
            btnUltimos.Click += btnUltimos_Click;
            // 
            // dgvContratos
            // 
            dgvContratos.AllowUserToAddRows = false;
            dgvContratos.AllowUserToDeleteRows = false;
            dgvContratos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContratos.Location = new Point(295, 451);
            dgvContratos.Name = "dgvContratos";
            dgvContratos.ReadOnly = true;
            dgvContratos.RowHeadersWidth = 51;
            dgvContratos.Size = new Size(574, 170);
            dgvContratos.TabIndex = 52;
            // 
            // lblIngresosBrutos
            // 
            lblIngresosBrutos.AutoSize = true;
            lblIngresosBrutos.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIngresosBrutos.ForeColor = SystemColors.ButtonShadow;
            lblIngresosBrutos.Location = new Point(153, 79);
            lblIngresosBrutos.Name = "lblIngresosBrutos";
            lblIngresosBrutos.Size = new Size(198, 19);
            lblIngresosBrutos.TabIndex = 53;
            lblIngresosBrutos.Text = "INGRESOS BRUTOS DE ";
            lblIngresosBrutos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPropiedadesCount
            // 
            lblPropiedadesCount.AutoSize = true;
            lblPropiedadesCount.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPropiedadesCount.Location = new Point(77, 502);
            lblPropiedadesCount.Name = "lblPropiedadesCount";
            lblPropiedadesCount.Size = new Size(18, 19);
            lblPropiedadesCount.TabIndex = 54;
            lblPropiedadesCount.Text = "0";
            lblPropiedadesCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblClientesCount
            // 
            lblClientesCount.AutoSize = true;
            lblClientesCount.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClientesCount.Location = new Point(77, 631);
            lblClientesCount.Name = "lblClientesCount";
            lblClientesCount.Size = new Size(18, 19);
            lblClientesCount.TabIndex = 56;
            lblClientesCount.Text = "0";
            lblClientesCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(233, 21);
            label4.Name = "label4";
            label4.Size = new Size(194, 19);
            label4.TabIndex = 57;
            label4.Text = "Desde fecha personalizada:";
            // 
            // gpEnGestion
            // 
            gpEnGestion.Controls.Add(lblPropietariosCount);
            gpEnGestion.Location = new Point(12, 443);
            gpEnGestion.Name = "gpEnGestion";
            gpEnGestion.Size = new Size(250, 218);
            gpEnGestion.TabIndex = 58;
            gpEnGestion.TabStop = false;
            // 
            // lblPropietariosCount
            // 
            lblPropietariosCount.AutoSize = true;
            lblPropietariosCount.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPropietariosCount.Location = new Point(65, 125);
            lblPropietariosCount.Name = "lblPropietariosCount";
            lblPropietariosCount.Size = new Size(18, 19);
            lblPropietariosCount.TabIndex = 61;
            lblPropietariosCount.Text = "0";
            lblPropietariosCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gboxTipo
            // 
            gboxTipo.Controls.Add(rbConsultadas);
            gboxTipo.Controls.Add(rbVendidas);
            gboxTipo.Location = new Point(921, 179);
            gboxTipo.Name = "gboxTipo";
            gboxTipo.Size = new Size(329, 37);
            gboxTipo.TabIndex = 59;
            gboxTipo.TabStop = false;
            // 
            // lblIngresosBrutosValue
            // 
            lblIngresosBrutosValue.AutoSize = true;
            lblIngresosBrutosValue.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIngresosBrutosValue.Location = new Point(159, 107);
            lblIngresosBrutosValue.Name = "lblIngresosBrutosValue";
            lblIngresosBrutosValue.Size = new Size(18, 19);
            lblIngresosBrutosValue.TabIndex = 60;
            lblIngresosBrutosValue.Text = "0";
            lblIngresosBrutosValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSinInformacion
            // 
            lblSinInformacion.BackColor = Color.LightGray;
            lblSinInformacion.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSinInformacion.ForeColor = SystemColors.ButtonShadow;
            lblSinInformacion.Location = new Point(134, 280);
            lblSinInformacion.Name = "lblSinInformacion";
            lblSinInformacion.Size = new Size(668, 19);
            lblSinInformacion.TabIndex = 61;
            lblSinInformacion.Text = "SIN INFORMACIÓN EN EL RANGO DE FECHAS SELECCIONADO";
            lblSinInformacion.TextAlign = ContentAlignment.MiddleCenter;
            lblSinInformacion.Visible = false;
            // 
            // lblSinInformacion2
            // 
            lblSinInformacion2.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSinInformacion2.ForeColor = SystemColors.ButtonShadow;
            lblSinInformacion2.Location = new Point(927, 311);
            lblSinInformacion2.Name = "lblSinInformacion2";
            lblSinInformacion2.Size = new Size(305, 62);
            lblSinInformacion2.TabIndex = 62;
            lblSinInformacion2.Text = "SIN INFORMACIÓN EN EL RANGO DE FECHAS SELECCIONADO";
            lblSinInformacion2.TextAlign = ContentAlignment.MiddleCenter;
            lblSinInformacion2.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbProximoMes);
            groupBox1.Controls.Add(rbProximaSemana);
            groupBox1.Controls.Add(rbTodos);
            groupBox1.Location = new Point(295, 619);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(574, 42);
            groupBox1.TabIndex = 63;
            groupBox1.TabStop = false;
            // 
            // rbProximoMes
            // 
            rbProximoMes.AutoSize = true;
            rbProximoMes.Font = new Font("Times New Roman", 9F);
            rbProximoMes.Location = new Point(425, 15);
            rbProximoMes.Name = "rbProximoMes";
            rbProximoMes.Size = new Size(132, 21);
            rbProximoMes.TabIndex = 12;
            rbProximoMes.TabStop = true;
            rbProximoMes.Text = "PRÓXIMO MES";
            rbProximoMes.UseVisualStyleBackColor = true;
            rbProximoMes.CheckedChanged += rbProximoMes_CheckedChanged;
            // 
            // rbProximaSemana
            // 
            rbProximaSemana.AutoSize = true;
            rbProximaSemana.Font = new Font("Times New Roman", 9F);
            rbProximaSemana.Location = new Point(236, 15);
            rbProximaSemana.Name = "rbProximaSemana";
            rbProximaSemana.Size = new Size(164, 21);
            rbProximaSemana.TabIndex = 11;
            rbProximaSemana.TabStop = true;
            rbProximaSemana.Text = "PRÓXIMA SEMANA";
            rbProximaSemana.UseVisualStyleBackColor = true;
            rbProximaSemana.CheckedChanged += rbProximaSemana_CheckedChanged;
            // 
            // rbTodos
            // 
            rbTodos.AutoSize = true;
            rbTodos.Font = new Font("Times New Roman", 9F);
            rbTodos.Location = new Point(15, 15);
            rbTodos.Name = "rbTodos";
            rbTodos.Size = new Size(187, 21);
            rbTodos.TabIndex = 10;
            rbTodos.TabStop = true;
            rbTodos.Text = "TODOS LOS VIGENTES";
            rbTodos.UseVisualStyleBackColor = true;
            rbTodos.CheckedChanged += rbTodos_CheckedChanged;
            // 
            // rbVisitas
            // 
            rbVisitas.AutoSize = true;
            rbVisitas.Font = new Font("Times New Roman", 9F);
            rbVisitas.Location = new Point(353, 189);
            rbVisitas.Name = "rbVisitas";
            rbVisitas.Size = new Size(85, 21);
            rbVisitas.TabIndex = 64;
            rbVisitas.TabStop = true;
            rbVisitas.Text = "VISITAS";
            rbVisitas.UseVisualStyleBackColor = true;
            rbVisitas.CheckedChanged += rbVisitas_CheckedChanged;
            // 
            // lblBrutosARS
            // 
            lblBrutosARS.AutoSize = true;
            lblBrutosARS.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBrutosARS.Location = new Point(420, 107);
            lblBrutosARS.Name = "lblBrutosARS";
            lblBrutosARS.Size = new Size(18, 19);
            lblBrutosARS.TabIndex = 65;
            lblBrutosARS.Text = "0";
            lblBrutosARS.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(lblBrutosARS);
            Controls.Add(rbVisitas);
            Controls.Add(groupBox1);
            Controls.Add(lblSinInformacion2);
            Controls.Add(lblSinInformacion);
            Controls.Add(lblIngresosBrutosValue);
            Controls.Add(gboxTipo);
            Controls.Add(label4);
            Controls.Add(lblClientesCount);
            Controls.Add(lblPropiedadesCount);
            Controls.Add(lblIngresosBrutos);
            Controls.Add(dgvContratos);
            Controls.Add(btnUltimos);
            Controls.Add(btMes);
            Controls.Add(btnSemana);
            Controls.Add(btnHoy);
            Controls.Add(dtp1);
            Controls.Add(label2);
            Controls.Add(rbInteracciones);
            Controls.Add(rbTasaciones);
            Controls.Add(rbVentas);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(lblPropiedades);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(cBarras);
            Controls.Add(cTorta);
            Controls.Add(gpEnGestion);
            Name = "FormDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDashboard";
            Load += FormDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)cBarras).EndInit();
            ((System.ComponentModel.ISupportInitialize)cTorta).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvContratos).EndInit();
            gpEnGestion.ResumeLayout(false);
            gpEnGestion.PerformLayout();
            gboxTipo.ResumeLayout(false);
            gboxTipo.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart cBarras;
        private System.Windows.Forms.DataVisualization.Charting.Chart cTorta;
        private RadioButton rbConsultadas;
        private RadioButton rbVendidas;
        private Label label1;
        private Label label3;
        private Label lblPropiedades;
        private Label label5;
        private Label label6;
        private Button btnModificar;
        private Button button1;
        private Button button2;
        private Button btnMes;
        private RadioButton rbVentas;
        private RadioButton rbTasaciones;
        private RadioButton rbInteracciones;
        private DataGridView dgvContratos;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dtp1;
        private Button btnHoy;
        private Button button3;
        private Button btnSemana;
        private Button btMes;
        private Button btnUltimos;
        private Label lblIngresosBrutos;
        private Label lblPropiedadesCount;
        private Label lblClientesCount;
        private Label label4;
        private GroupBox gpEnGestion;
        private GroupBox gboxTipo;
        private Label lblIngresosBrutosValue;
        private Label lblPropietariosCount;
        private Label lblSinInformacion;
        private Label lblSinInformacion2;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private RadioButton rbTodos;
        private RadioButton rbProximoMes;
        private RadioButton rbProximaSemana;
        private RadioButton rbVisitas;
        private Label lblBrutosARS;
    }
}