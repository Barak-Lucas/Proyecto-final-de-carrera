namespace ControlesDeUsuario
{
    partial class CajaNumerica
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            textBox = new TextBox();
            SuspendLayout();
            // 
            // textBox
            // 
            textBox.Location = new Point(0, 0);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.Size = new Size(67, 24);
            textBox.TabIndex = 0;
            textBox.TextChanged += textBox_TextChanged;
            textBox.KeyPress += txt_KeyPress;
            // 
            // CajaNumerica
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox);
            Name = "CajaNumerica";
            Size = new Size(96, 27);
            Load += CajaNumerica_Load;
            Resize += CajaNumerica_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox;
    }
}
