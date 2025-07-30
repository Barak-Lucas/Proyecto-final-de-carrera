namespace L1GUI.Forms.PopUps
{
    partial class FormTasacionModificar
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
            lblPropietario = new Label();
            lblLocacion = new Label();
            label7 = new Label();
            btnCancelar = new Button();
            dtPickerH = new DateTimePicker();
            btnConfirmar = new Button();
            label4 = new Label();
            dtPicker = new DateTimePicker();
            SuspendLayout();
            // 
            // lblPropietario
            // 
            lblPropietario.AutoSize = true;
            lblPropietario.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblPropietario.Location = new Point(79, 127);
            lblPropietario.Name = "lblPropietario";
            lblPropietario.Size = new Size(98, 23);
            lblPropietario.TabIndex = 76;
            lblPropietario.Text = "Propietario:";
            // 
            // lblLocacion
            // 
            lblLocacion.AutoSize = true;
            lblLocacion.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblLocacion.Location = new Point(96, 76);
            lblLocacion.Name = "lblLocacion";
            lblLocacion.Size = new Size(81, 23);
            lblLocacion.TabIndex = 75;
            lblLocacion.Text = "Locación:";
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 9);
            label7.Name = "label7";
            label7.Size = new Size(503, 41);
            label7.TabIndex = 74;
            label7.Text = "MODIFICANDO TASACIÓN";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.SteelBlue;
            btnCancelar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnCancelar.ForeColor = SystemColors.ButtonHighlight;
            btnCancelar.Location = new Point(296, 266);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(140, 42);
            btnCancelar.TabIndex = 73;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // dtPickerH
            // 
            dtPickerH.Format = DateTimePickerFormat.Time;
            dtPickerH.Location = new Point(343, 172);
            dtPickerH.Name = "dtPickerH";
            dtPickerH.Size = new Size(107, 27);
            dtPickerH.TabIndex = 70;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.SteelBlue;
            btnConfirmar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnConfirmar.ForeColor = SystemColors.ButtonHighlight;
            btnConfirmar.Location = new Point(91, 266);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(140, 42);
            btnConfirmar.TabIndex = 71;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label4.Location = new Point(12, 172);
            label4.Name = "label4";
            label4.Size = new Size(165, 23);
            label4.TabIndex = 72;
            label4.Text = "Nueva fecha y hora:";
            // 
            // dtPicker
            // 
            dtPicker.Format = DateTimePickerFormat.Short;
            dtPicker.Location = new Point(197, 172);
            dtPicker.Name = "dtPicker";
            dtPicker.Size = new Size(120, 27);
            dtPicker.TabIndex = 69;
            // 
            // FormTasacionModificar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 320);
            Controls.Add(lblPropietario);
            Controls.Add(lblLocacion);
            Controls.Add(label7);
            Controls.Add(btnCancelar);
            Controls.Add(dtPickerH);
            Controls.Add(btnConfirmar);
            Controls.Add(label4);
            Controls.Add(dtPicker);
            Name = "FormTasacionModificar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormTasacionModificar";
            Load += FormTasacionModificar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPropietario;
        private Label lblLocacion;
        private Label label7;
        private Button btnCancelar;
        private DateTimePicker dtPickerH;
        private Button btnConfirmar;
        private Label label4;
        private DateTimePicker dtPicker;
    }
}