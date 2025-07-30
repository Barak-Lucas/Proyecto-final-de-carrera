using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlesDeUsuario
{
    public partial class CajaNumerica : UserControl
    {

        public event EventHandler TextChanged;

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            TextChanged?.Invoke(this, e);
        }

        public string Text
        {
            get { return textBox.Text; }
            set { textBox.Text = value; }

        }

        private int maxLength;

        public int MaxLength
        {
            get { return maxLength; }
            set { maxLength = value; }
        }


        public CajaNumerica()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(96, 27);
            textBox.Location = new Point(0, 0);
            textBox.Size = this.Size;
            textBox.TextChanged += TextBox1_TextChanged;
        }

        private void CajaNumerica_Load(object sender, EventArgs e)
        {

        }



        private void AjustarTamaño()
        {
            textBox.Location = new Point(0, 0);
            textBox.Size = this.Size;
        }

        private void CajaNumerica_Resize(object sender, EventArgs e)
        {
            AjustarTamaño();
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar > 47 && e.KeyChar < 58) || e.KeyChar == 8) || !((textBox.Text.Length < MaxLength || textBox.SelectedText.Length == maxLength)  || e.KeyChar == 8))
            {
                e.KeyChar = '\0';
            }
        }

        public void Select(int start, int length)
        {
            textBox.Select(start, length);
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
