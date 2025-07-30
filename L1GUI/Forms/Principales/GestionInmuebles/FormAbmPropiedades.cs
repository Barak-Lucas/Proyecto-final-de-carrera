using L2BE;
using L3BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Estados = L2BE.PropiedadBE.EstadosPropiedad;


namespace L1GUI.Forms
{
    public partial class FormAbmPropiedades : Form
    {
        PropiedadBLL bllPropiedad;
        ClienteBLL bllPropietario;
        Action refrescarDGVhijo;
        ClienteBE propietario;
        UsuarioBE usuarioLogeado;
        public FormAbmPropiedades(UsuarioBE pUsueario = null, Action pRefrescarDGV = null)
        {
            InitializeComponent();
            bllPropiedad = new PropiedadBLL();
            bllPropietario = new ClienteBLL();
            ConfigurarComponentes();
            refrescarDGVhijo = pRefrescarDGV;
            usuarioLogeado = pUsueario;
        }
        private void FormAbmPropiedades_Load(object sender, EventArgs e)
        {
            RefrescarDGV();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {

            try
            {
                if (CamposVacios())
                {
                    MessageBox.Show("¡Complete los campos obligatorios marcados con un '*' rojo!");
                    return;
                }
                Int32.TryParse(cnM2.Text, out int m2);
                PropiedadBEambientes amb = new PropiedadBEambientes(cbBalcon.Checked, cbCocina.Checked, cbGarage.Checked, cbJardin.Checked, cbLiving.Checked, cbLavadero.Checked, cbPatio.Checked, cbTerraza.Checked);
                PropiedadBEestructura estr = new PropiedadBEestructura((int)nudAmbientes.Value, (int)nudAntiguedad.Value, (int)nudBaños.Value, (int)nudDorm.Value, m2, (int)nudPlantas.Value, (int)nudToilette.Value);
                PropiedadBEservicios serv = new PropiedadBEservicios(cbAguaCte.Checked, cbCable.Checked, cbCloaca.Checked, cbElectricidad.Checked, cbInternet.Checked, cbGasNatural.Checked, cbPavimento.Checked);

                PropiedadBE propiedad = new PropiedadBE(Convert.ToInt32(cnPropietario.Text), txtDescripcion.Text, txtDomicilio.Text, cmbLocalidad.SelectedValue.ToString(), (PropiedadBE.Orientaciones)cmbOrientacion.SelectedValue,
                                                                   Convert.ToDecimal(cnPrecio.Text), (PropiedadBE.TiposPropiedad)cmbTipo.SelectedValue, amb, estr, serv);
                bllPropiedad.Alta(propiedad);

                MessageBox.Show("¡Propiedad creada!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefrescarDGV();

                if(usuarioLogeado != null && usuarioLogeado.Permisos.Any(p => p.Nombre == "Gestionar contratos"))
                {
                    DialogResult result = MessageBox.Show("¿Desea ir a la interfaz de Contratos ahora?", "Ir a contratos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        FormContratos frmContrato = new FormContratos();
                        frmContrato.ShowDialog();
                    }
                }
               
            }
            catch(FormatException)
            {
                MessageBox.Show("Verifique que los campos obligatorios (*) tengan el formato correcto o no estén vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgvPropiedades.SelectedRows.Count == 0)
                {
                    MessageBox.Show("¡Seleccione una propiedad de la grilla para dar de baja!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int idBaja = Convert.ToInt32(dgvPropiedades.SelectedRows[0].Cells["ID"].Value);
                DialogResult result = MessageBox.Show($"¿Confirma la baja de la propiedad con ID: {idBaja}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bllPropiedad.Baja(idBaja);
                    MessageBox.Show("¡Propiedad dada de eliminada!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefrescarDGV();
                }
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
                if (dgvPropiedades.SelectedRows.Count == 0)
                {
                    MessageBox.Show("¡Seleccione una propiedad de la grilla para modificar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                FormAbmPropiedadModif frmPropiedadModif
                = new FormAbmPropiedadModif(Convert.ToInt32(dgvPropiedades.SelectedRows[0].Cells["ID"].Value), Convert.ToInt32(dgvPropiedades.SelectedRows[0].Cells["PropietarioID"].Value),
                () => RefrescarDGV());
                frmPropiedadModif.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void btnBuscarProp_Click(object sender, EventArgs e)
        {

            try
            {
                FormPropietariosBuscar frmPropBuscar = new FormPropietariosBuscar();
                frmPropBuscar.ShowDialog();
                propietario = frmPropBuscar.propietarioSeleccionado;
                cnPropietario.Text = propietario.ID.ToString();
            }
            catch (Exception ex)
            {
                cnPropietario.Text = string.Empty;
                //MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ConfigurarComponentes()
        {

            try
            {
                cmbTipo.DataSource = Enum.GetValues(typeof(PropiedadBE.TiposPropiedad));
                cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbOrientacion.DataSource = Enum.GetValues(typeof(PropiedadBE.Orientaciones));
                cmbOrientacion.DropDownStyle = ComboBoxStyle.DropDownList;
                dgvPropiedades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvPropiedades.MultiSelect = false;
                cmbLocalidad.DataSource = PropiedadBE.LocalidadesAbarcadas;
                cmbLocalidad.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool CamposVacios()
        {
            if (txtDomicilio.Text.Length == 0) return true;
            else if (cnPropietario.Text.Length == 0) return true;
            else if (Convert.ToInt32(cnPrecio.Text) <= 0)
            {
                MessageBox.Show("El valor de la propiedad debe ser mayor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        private void RefrescarDGV()
        {

            try
            {
                dgvPropiedades.DataSource = null;
                var listaTratada =
                    (from p in bllPropiedad.ConsultarPropiedades()
                     where p.Estado != Estados.Vendida
                     select new
                     {
                         p.ID,
                         p.PropietarioID,
                         Precio_USD = p.PrecioUSD.ToString("C2", new System.Globalization.CultureInfo("es-AR")),
                         Propietario = bllPropietario.BuscarCliente(p.PropietarioID).ToString(),
                         p.Domicilio,
                         p.Localidad,
                         Tipo = p.Tipo.ToString(),
                         Metros2 = p.Estructura.MetrosCuadrados,
                         Ingresada = p.FechaPublicacion.ToString("dd/MM/yyyy"),
                     }).ToList();

                dgvPropiedades.DataSource = listaTratada;
                dgvPropiedades.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #region Eventos NUD
        private void nudAmbientes_Enter(object sender, EventArgs e)
        {

            try
            {
                nudAmbientes.Select(0, nudAmbientes.Text.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void nudBaños_Enter(object sender, EventArgs e)
        {

            try
            {
                nudBaños.Select(0, nudBaños.Text.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void nudToilette_Enter(object sender, EventArgs e)
        {

            try
            {
                nudToilette.Select(0, nudToilette.Text.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void nudDorm_Enter(object sender, EventArgs e)
        {

            try
            {
                nudDorm.Select(0, nudDorm.Text.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void nudPlantas_Enter(object sender, EventArgs e)
        {

            try
            {
                nudPlantas.Select(0, nudPlantas.Text.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void nudAntiguedad_Enter(object sender, EventArgs e)
        {

            try
            {
                nudAntiguedad.Select(0, nudAntiguedad.Text.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion

        private void FormAbmPropiedades_FormClosed(object sender, FormClosedEventArgs e)
        {

            try
            {
                refrescarDGVhijo?.Invoke();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Enum.Parse<PropiedadBE.TiposPropiedad>(cmbTipo.SelectedValue.ToString()) == PropiedadBE.TiposPropiedad.Terreno)
            {
                foreach (Control control in gbEstructura.Controls)
                {
                    if (control is NumericUpDown c)
                    {
                        c.Value = c.Minimum;
                    }

                }
                foreach (Control control in gbServicios.Controls)
                {
                    if (control is CheckBox c)
                    {
                        c.Checked = false;
                    }

                }
                foreach (Control control in gbAmbientes.Controls)
                {
                    if (control is CheckBox c)
                    {
                        c.Checked = false;
                    }

                }

                gbAmbientes.Enabled = false;
                gbEstructura.Enabled = false;
                gbServicios.Enabled = false;
            }
            else
            {
                gbEstructura.Enabled = true;
                gbAmbientes.Enabled = true;
                gbServicios.Enabled = true;
            }
        }

        private void txtBuscarDomicilio_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string patron = txtBuscarDomicilio.Text.Trim();
                Regex reDOM = new Regex(patron, RegexOptions.IgnoreCase);

                object listaTratada = null;

                dgvPropiedades.DataSource = null;
                listaTratada = (from p in bllPropiedad.ConsultarPropiedades()
                                where (p.Estado != Estados.Vendida)
                                && reDOM.IsMatch(p.Domicilio)
                                select new
                                {
                                    p.ID,
                                    Precio_USD = p.PrecioUSD.ToString("C2", new System.Globalization.CultureInfo("es-AR")),
                                    p.Domicilio,
                                    p.Localidad,
                                    Tipo = p.Tipo.ToString(),
                                    Metros2 = p.Estructura.MetrosCuadrados,
                                    Ingresada = p.FechaPublicacion.ToString("dd/MM/yyyy"),
                                }).ToList();

                dgvPropiedades.DataSource = listaTratada;
                dgvPropiedades.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBuscarID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string patron = txtBuscarID.Text.Trim();
                Regex reID = new Regex(patron);

                object listaTratada = null;

              
                dgvPropiedades.DataSource = null;
                listaTratada = (from p in bllPropiedad.ConsultarPropiedades()
                                where (p.Estado != Estados.Vendida )
                                && reID.IsMatch(p.ID.ToString())
                                select new
                                {
                                    p.ID,
                                    Precio_USD = p.PrecioUSD.ToString("C2", new System.Globalization.CultureInfo("es-AR")),
                                    p.Domicilio,
                                    p.Localidad,
                                    Tipo = p.Tipo.ToString(),
                                    Metros2 = p.Estructura.MetrosCuadrados,
                                    Ingresada = p.FechaPublicacion.ToString("dd/MM/yyyy"),
                                }).ToList();
                

                dgvPropiedades.DataSource = listaTratada;
                dgvPropiedades.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
