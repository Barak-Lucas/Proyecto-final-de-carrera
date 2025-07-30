using L3BLL;
using L2BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L1GUI.Forms
{
    public partial class FormAbmPropiedadModif : Form
    {
        PropiedadBLL bllPropiedad;
        Action refrescarDGVpadre; 
        int propiedadModificarID;
        int propietarioID;

        public FormAbmPropiedadModif(int pIDpropiedad, int pPropietarioID, Action pRefrescarDGV)
        {
            bllPropiedad = new PropiedadBLL();
            propiedadModificarID = pIDpropiedad;
            propietarioID = pPropietarioID;
            refrescarDGVpadre = pRefrescarDGV;
            InitializeComponent();
            ConfigurarComponentes();
        }

        private void ConfigurarComponentes()
        {

            try
            {
                cmbTipo.DataSource = Enum.GetValues(typeof(PropiedadBE.TiposPropiedad));
                cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbOrientacion.DataSource = Enum.GetValues(typeof(PropiedadBE.Orientaciones));
                cmbOrientacion.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbLocalidad.DataSource = PropiedadBE.LocalidadesAbarcadas;
                cmbLocalidad.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FormAbmPropiedadModif_Load(object sender, EventArgs e)
        {

            try
            {
                lblTitulo.Text += $"[{propiedadModificarID}]";
                PropiedadBE propiedad = bllPropiedad.BuscarPropiedad(propiedadModificarID);

                //Propiedad
                txtDescripcion.Text = propiedad.DescripcionComercial;
                txtDomicilio.Text = propiedad.Domicilio;
                cmbLocalidad.Text = propiedad.Localidad;
                cmbOrientacion.SelectedItem = propiedad.Orientacion;
                cmbTipo.SelectedItem = propiedad.Tipo;
                cnPrecio.Text = propiedad.PrecioUSD.ToString();
                cnM2.Text = propiedad.Estructura.MetrosCuadrados.ToString();


                //Estructura
                nudAmbientes.Value = propiedad.Estructura.Ambientes;
                nudAntiguedad.Value = propiedad.Estructura.Antiguedad;
                nudBaños.Value = propiedad.Estructura.Baños;
                nudDorm.Value = propiedad.Estructura.Dormitorios;
                nudPlantas.Value = propiedad.Estructura.Plantas;
                nudToilette.Value = propiedad.Estructura.Toilette;


                //Ambientes
                cbBalcon.Checked = propiedad.Ambientes.Balcon;
                cbPatio.Checked = propiedad.Ambientes.Patio;
                cbTerraza.Checked = propiedad.Ambientes.Terraza;
                cbGarage.Checked = propiedad.Ambientes.Garage;
                cbLiving.Checked = propiedad.Ambientes.Living;
                cbCocina.Checked = propiedad.Ambientes.Cocina;
                cbJardin.Checked = propiedad.Ambientes.Jardin;
                cbLavadero.Checked = propiedad.Ambientes.Lavadero;

                //Servicios
                cbAguaCte.Checked = propiedad.Servivios.AguaCorriente;
                cbCable.Checked = propiedad.Servivios.Cable;
                cbCloaca.Checked = propiedad.Servivios.Cloaca;
                cbElectricidad.Checked = propiedad.Servivios.Electricidad;
                cbGasNatural.Checked = propiedad.Servivios.GasNatural;
                cbInternet.Checked = propiedad.Servivios.Internet;
                cbPavimento.Checked = propiedad.Servivios.Pavimento;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            try
            {
                PropiedadBEambientes amb = new PropiedadBEambientes(cbBalcon.Checked, cbCocina.Checked, cbGarage.Checked, cbJardin.Checked, cbLiving.Checked, cbLavadero.Checked, cbPatio.Checked, cbTerraza.Checked);
                PropiedadBEestructura estr = new PropiedadBEestructura((int)nudAmbientes.Value, (int)nudAntiguedad.Value, (int)nudBaños.Value, (int)nudDorm.Value, Convert.ToInt32(cnM2.Text), (int)nudPlantas.Value, (int)nudToilette.Value);
                PropiedadBEservicios serv = new PropiedadBEservicios(cbAguaCte.Checked, cbCable.Checked, cbCloaca.Checked, cbElectricidad.Checked, cbInternet.Checked, cbGasNatural.Checked, cbPavimento.Checked);
                PropiedadBE propiedad = bllPropiedad.BuscarPropiedad(propiedadModificarID);

                propiedad.Estructura = estr;
                propiedad.Servivios = serv;
                propiedad.Ambientes = amb;
                propiedad.DescripcionComercial = txtDescripcion.Text;
                propiedad.Domicilio = txtDomicilio.Text;
                propiedad.Localidad = cmbLocalidad.SelectedValue.ToString();
                propiedad.Orientacion = (PropiedadBE.Orientaciones)cmbOrientacion.SelectedValue;
                propiedad.PrecioUSD = Convert.ToDecimal(cnPrecio.Text);
                propiedad.Tipo = (PropiedadBE.TiposPropiedad)cmbTipo.SelectedValue;

                if (CamposVacios())
                {
                    MessageBox.Show("¡Complete los campos obligatorios marcados con un '*' rojo!");
                    return;
                }
                bllPropiedad.Modificar(propiedad);

                MessageBox.Show("¡Propiedad modificada!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refrescarDGVpadre?.Invoke();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private bool CamposVacios()
        {

            try
            {
                if (txtDomicilio.Text.Length == 0) return true;
                else if (Convert.ToInt32(cnPrecio.Text) <= 0)
                {
                    throw new Exception("El valor de la propiedad debe ser mayor a 0");
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Eventos NUD
        private void nudAmbientes_Enter(object sender, EventArgs e)
        {
            nudAmbientes.Select(0, nudAmbientes.Text.Length);
        }

        private void nudBaños_Enter(object sender, EventArgs e)
        {
            nudBaños.Select(0, nudBaños.Text.Length);
        }

        private void nudToilette_Enter(object sender, EventArgs e)
        {
            nudToilette.Select(0, nudToilette.Text.Length);
        }

        private void nudDorm_Enter(object sender, EventArgs e)
        {
            nudDorm.Select(0, nudDorm.Text.Length);
        }

        private void nudPlantas_Enter(object sender, EventArgs e)
        {
            nudPlantas.Select(0, nudPlantas.Text.Length);
        }

        private void nudAntiguedad_Enter(object sender, EventArgs e)
        {
            nudAntiguedad.Select(0, nudAntiguedad.Text.Length);
        }
        #endregion

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                if (Enum.Parse<PropiedadBE.TiposPropiedad>(cmbTipo.SelectedValue.ToString()) == PropiedadBE.TiposPropiedad.Terreno)
                {
                    foreach (Control control in groupBox1.Controls)
                    {
                        if (control is NumericUpDown c)
                        {
                            c.Value = c.Minimum;
                        }

                    }
                    foreach (Control control in groupBox2.Controls)
                    {
                        if (control is CheckBox c)
                        {
                            c.Checked = false;
                        }

                    }
                    foreach (Control control in groupBox3.Controls)
                    {
                        if (control is CheckBox c)
                        {
                            c.Checked = false;
                        }

                    }

                    groupBox1.Enabled = false;
                    groupBox2.Enabled = false;
                    groupBox3.Enabled = false;
                }
                else
                {
                    groupBox1.Enabled = true;
                    groupBox2.Enabled = true;
                    groupBox3.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
