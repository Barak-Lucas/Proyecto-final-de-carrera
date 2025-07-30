using L2BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L1GUI.Forms
{
    public partial class FormContratosRenovar : Form
    {
        public ContratoBE contrato { get; private set; }
        ClienteBE propietario;
        PropiedadBE propiedad;
        public static bool confirmado;
        public FormContratosRenovar(ContratoBE pContrato, ClienteBE pPropietario, PropiedadBE pPropiedad)
        {
            contrato = pContrato;
            propiedad = pPropiedad;
            propietario = pPropietario;
            confirmado = false; 
            InitializeComponent();
        }

        private void FormContratosRenovar_Load(object sender, EventArgs e)
        {

            try
            {
                lblInfoPropiedad.Text += $" ID [{propiedad.ID}] - {propiedad.Domicilio} {propiedad.Localidad}";
                lblPropietario.Text += $" ID [{propietario.ID}] - {propietario} - DNI: {propietario.DNI}";
                lblPrecio.Text = contrato.PrecioUSD.ToString("C2", new CultureInfo("es-AR"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnRenovarContrato_Click(object sender, EventArgs e)
        {

            try
            {
               
                contrato.FechaInicio = dtPicker.Value;
                confirmado = true;
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al renovar el contrato {Environment.NewLine} {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }

}
