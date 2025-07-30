namespace L1GUI.Forms
{
    partial class FormCatalogoPropiedadesDetalles
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
            label9 = new Label();
            txtDescripción = new TextBox();
            label7 = new Label();
            lbServicios = new ListBox();
            lbAmbientes = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lbEstructura = new ListBox();
            SuspendLayout();
            // 
            // label9
            // 
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label9.Location = new Point(271, 115);
            label9.Name = "label9";
            label9.Size = new Size(705, 23);
            label9.TabIndex = 41;
            label9.Text = "DESCRIPCIÓN";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDescripción
            // 
            txtDescripción.Enabled = false;
            txtDescripción.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescripción.Location = new Point(271, 141);
            txtDescripción.Multiline = true;
            txtDescripción.Name = "txtDescripción";
            txtDescripción.ReadOnly = true;
            txtDescripción.ScrollBars = ScrollBars.Vertical;
            txtDescripción.Size = new Size(705, 222);
            txtDescripción.TabIndex = 42;
            // 
            // label7
            // 
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 23);
            label7.Name = "label7";
            label7.Size = new Size(1238, 41);
            label7.TabIndex = 80;
            label7.Text = "DETALLES ";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbServicios
            // 
            lbServicios.Font = new Font("Segoe UI", 10.2F);
            lbServicios.FormattingEnabled = true;
            lbServicios.ItemHeight = 23;
            lbServicios.Location = new Point(29, 450);
            lbServicios.Name = "lbServicios";
            lbServicios.Size = new Size(360, 211);
            lbServicios.TabIndex = 82;
            // 
            // lbAmbientes
            // 
            lbAmbientes.Font = new Font("Segoe UI", 10.2F);
            lbAmbientes.FormattingEnabled = true;
            lbAmbientes.ItemHeight = 23;
            lbAmbientes.Location = new Point(450, 450);
            lbAmbientes.Name = "lbAmbientes";
            lbAmbientes.Size = new Size(360, 211);
            lbAmbientes.TabIndex = 83;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label1.Location = new Point(450, 424);
            label1.Name = "label1";
            label1.Size = new Size(360, 23);
            label1.TabIndex = 84;
            label1.Text = "SERVICIOS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.Location = new Point(29, 424);
            label2.Name = "label2";
            label2.Size = new Size(360, 23);
            label2.TabIndex = 85;
            label2.Text = "AMBIENTES";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.Location = new Point(868, 424);
            label3.Name = "label3";
            label3.Size = new Size(360, 23);
            label3.TabIndex = 87;
            label3.Text = "ESTRUCTURA";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbEstructura
            // 
            lbEstructura.Font = new Font("Segoe UI", 10.2F);
            lbEstructura.FormattingEnabled = true;
            lbEstructura.ItemHeight = 23;
            lbEstructura.Location = new Point(868, 450);
            lbEstructura.Name = "lbEstructura";
            lbEstructura.Size = new Size(360, 211);
            lbEstructura.TabIndex = 86;
            // 
            // FormCatalogoPropiedadesDetalles
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1262, 673);
            Controls.Add(label3);
            Controls.Add(lbEstructura);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbAmbientes);
            Controls.Add(lbServicios);
            Controls.Add(label7);
            Controls.Add(label9);
            Controls.Add(txtDescripción);
            Name = "FormCatalogoPropiedadesDetalles";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCatalogoPropiedadesDetalles";
            Load += FormCatalogoPropiedadesDetalles_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private TextBox txtDescripción;
        private TextBox textBox1;
        private Label label7;
        private ListBox lbServicios;
        private ListBox lbAmbientes;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox lbEstructura;
    }
}