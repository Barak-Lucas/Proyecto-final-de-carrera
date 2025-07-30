using L1GUI.Forms.Principales;
using L1GUI.Properties;
using L2BE;
using L3BLL;
using Microsoft.VisualBasic;
using System.Data;
using Estados = L2BE.PropiedadBE.EstadosPropiedad;


namespace L1GUI.Forms
{
    public partial class FormCatalogoPropiedades : Form
    {
        PropiedadBLL bllPropiedad;
        PropiedadBE propiedadSeleccionada;

        public FormCatalogoPropiedades()
        {
            InitializeComponent();
            bllPropiedad = new PropiedadBLL();
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPropiedades.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar una propiedad para ver los detalles.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int idPropiedadSeleccionada = Convert.ToInt32(dgvPropiedades.SelectedRows[0].Cells["ID"].Value);
                PropiedadBE propiedadDetalles = bllPropiedad.BuscarPropiedad(idPropiedadSeleccionada);
                FormCatalogoPropiedadesDetalles frmCatDetalles = new FormCatalogoPropiedadesDetalles(propiedadDetalles);
                frmCatDetalles.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FormCatalogoPropiedades_Load(object sender, EventArgs e)
        {

            try
            {
                RefrescarDGV();
                ConfigurarComponentes();
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                if (dgvPropiedades.Rows.Count == 0)
                {
                    pictureBox.Image = Resources.Sin_propiedades;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void RefrescarDGV()
        {

            try
            {
                dgvPropiedades.DataSource = null;
                var listaTratada = (from p in bllPropiedad.ConsultarPropiedades()
                                    where p.Estado != Estados.Retirada
                                    && p.Estado != Estados.Suspendida
                                    select new
                                    {
                                        p.ID,
                                        p.Tipo,
                                        p.Estado,
                                        Antiguedad = p.Estructura.Antiguedad,
                                        Ambientes = p.Estructura.Ambientes,
                                        p.Orientacion,

                                    }).ToList();
                dgvPropiedades.DataSource = listaTratada;
                dgvPropiedades.Columns["Antiguedad"].HeaderText = "Antiguedad (años)";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void ConfigurarComponentes()
        {

            try
            {
                dgvPropiedades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvPropiedades.MultiSelect = false;
                cmbTipo.DataSource = Enum.GetValues(typeof(PropiedadBE.TiposPropiedad));
                cmbOrientacion.DataSource = Enum.GetValues(typeof(PropiedadBE.Orientaciones));
                cmbLocalidad.DataSource = PropiedadBE.LocalidadesAbarcadas;
                cmbLocalidad.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbOrientacion.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
                cnDesde.Text = "0";
                cnHasta.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnCambiarPortada_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgvPropiedades.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar una propiedad para cambiar la portada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int idPropiedadSeleccionada = Convert.ToInt32(dgvPropiedades.SelectedRows[0].Cells["ID"].Value);

                OpenFileDialog pfd = new OpenFileDialog();
                pfd.Filter = "Elegir imagen(*.jpg;*.png;*.gif| *jpg;*.png;*.gif)";

                DialogResult result = pfd.ShowDialog();
                if (result == DialogResult.OK)
                {
                    pictureBox.Image = Image.FromFile(pfd.FileName);
                    bllPropiedad.SetImgPortada(idPropiedadSeleccionada, pfd.FileName.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgvPropiedades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPropiedades.Rows.Count > 0)
            {
                try
                {
                    int idPropiedadSeleccionada = Convert.ToInt32(dgvPropiedades.SelectedRows[0].Cells["ID"].Value);
                    propiedadSeleccionada = bllPropiedad.BuscarPropiedad(idPropiedadSeleccionada);

                    string ruta = @$"{bllPropiedad.GetImgPortada(idPropiedadSeleccionada)}";
                    if (!File.Exists(ruta))
                    {
                        pictureBox.Image = Resources.Propiedad_sin_imagen;
                    }
                    else
                    {
                        pictureBox.Image = Image.FromFile(ruta);
                    }

                    lblVendida.BackColor = Color.Transparent;
                    lblVendida.Visible = dgvPropiedades.SelectedRows[0].Cells["Estado"].Value.ToString() == "Vendida" ? true : false;

                    txtDescripCorta.Text = propiedadSeleccionada.DescripcionComercial;
                    txtValor.Text = "Precio venta: " + propiedadSeleccionada.PrecioUSD.ToString("C2", new System.Globalization.CultureInfo("es-AR"));
                    txtDomicilio.Text = "Domicilio: " + propiedadSeleccionada.Domicilio + Environment.NewLine + propiedadSeleccionada.Localidad;

                }
                catch (Exception) { }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            try
            {
                PropiedadBE.TiposPropiedad tipo = (PropiedadBE.TiposPropiedad)cmbTipo.SelectedValue;
                PropiedadBE.Orientaciones orientacion = (PropiedadBE.Orientaciones)cmbOrientacion.SelectedValue;
                string localidad = cmbLocalidad.SelectedValue.ToString();
                int ambientes = (int)nudAmbientes.Value;
                // Asignación ternaria se llama, la coalescente es ??
                decimal desde = Decimal.TryParse(cnDesde.Text, out decimal outDesde) ? outDesde : 0;
                decimal hasta = Decimal.TryParse(cnHasta.Text, out decimal outHasta) ? outHasta : 100000000;

                dgvPropiedades.DataSource = null;
                var listaTratada = (from p in bllPropiedad.ConsultarPropiedades()
                                    where
                                   (p.Tipo == tipo &&
                                    p.Orientacion == orientacion &&
                                    p.Localidad == p.Localidad &&
                                    p.Estructura.Ambientes == ambientes &&
                                    p.PrecioUSD >= desde &&
                                    p.PrecioUSD <= hasta)
                                    select new
                                    {
                                        p.ID,
                                        p.Tipo,
                                        p.Estado,
                                        Antiguedad = p.Estructura.Antiguedad,
                                        Ambientes = p.Estructura.Ambientes,
                                        p.Orientacion,
                                    }).ToList();

                dgvPropiedades.DataSource = listaTratada;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

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

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            RefrescarDGV();
        }

        private void btnBuscarID_Click(object sender, EventArgs e)
        {

            try
            {
                if(dgvPropiedades.Rows.Count > 0)
                {
                    int idBuscar = Int32.TryParse(Interaction.InputBox("Ingrese el ID de la propiedad que desea buscar:", "Buscar Propiedad", ""), out int idIngresado) ? idIngresado : 0;
                    if (idBuscar <= 0)
                    {
                        MessageBox.Show("Debe ingresar un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        RefrescarDGV();
                        return;
                    }
                    else
                    {
                        dgvPropiedades.DataSource = null;
                        var propiedadesEncontrada = bllPropiedad.ConsultarPropiedades().Where(p => p.ID == idBuscar).Select(p => new
                        {
                            p.ID,
                            p.Tipo,
                            p.Estado,
                            Antiguedad = p.Estructura.Antiguedad,
                            Ambientes = p.Estructura.Ambientes,
                            p.Orientacion,
                        }).ToList();
                        dgvPropiedades.DataSource = propiedadesEncontrada;
                        dgvPropiedades.Refresh();
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnAgregarInteraccion_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgvPropiedades.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione una propiedad", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
                if (dgvPropiedades.SelectedRows[0].Cells["Estado"].Value.ToString() != "Disponible")
                {
                    MessageBox.Show("Esta propiedad no se encuentra disponible para la venta, compruebe su estado");
                    return;
                }

                FormHistorialInteracciones frmInteracciones = new FormHistorialInteracciones(propiedadSeleccionada);
                frmInteracciones.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


    }
}
