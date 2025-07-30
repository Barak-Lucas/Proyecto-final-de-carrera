using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using L1GUI.Properties;
using L2BE;

namespace L1GUI.Forms
{
    public partial class FormCatalogoPropiedadesDetalles : Form
    {
        PropiedadBE propiedadDetalles;        

        public FormCatalogoPropiedadesDetalles(PropiedadBE pPropiedad)
        {
            this.propiedadDetalles = pPropiedad;
            InitializeComponent();
        }

        private void FormCatalogoPropiedadesDetalles_Load(object sender, EventArgs e)
        {

            try
            {
                if (propiedadDetalles == null)
                {
                    MessageBox.Show("No se han encontrado detalles para la propiedad seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }

                foreach (var ambiente in propiedadDetalles.Ambientes.dAmbientes)
                {
                    lbAmbientes.Items.Add($"{ambiente.Key} {ambiente.Value} {Environment.NewLine}");
                }
                foreach (var estructura in propiedadDetalles.Estructura.dEstructura)
                {
                    lbEstructura.Items.Add($"{estructura.Key} {estructura.Value} {Environment.NewLine}");
                }
                foreach (var servicio in propiedadDetalles.Servivios.dServicios)
                {
                    lbServicios.Items.Add($"{servicio.Key} {servicio.Value} {Environment.NewLine}");
                }

                txtDescripción.Text = propiedadDetalles.DescripcionComercial;

                this.BackgroundImage = propiedadDetalles.RutaFotos != null && propiedadDetalles.RutaFotos != "Pendiente"
                    ? Image.FromFile(propiedadDetalles.RutaFotos)
                    : null;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }


    }
}
