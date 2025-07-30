using L1GUI.Properties;
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
using pEstados = L2BE.PropiedadBE.EstadosPropiedad;
using cEstados = L2BE.ContratoBE.EstadoContrato;

namespace L1GUI.Forms
{
    public partial class FormEstadoPropiedad : Form
    {
        PropiedadBLL bllPropiedad;
        ContratoBLL bllContrato;

        public FormEstadoPropiedad()
        {
            bllPropiedad = new PropiedadBLL();
            bllContrato = new ContratoBLL();
            InitializeComponent();
        }

        private void FormGestionarPropiedad_Load(object sender, EventArgs e)
        {
            ConfigurarComponentes();
            RefrescarDGV();
        }

        private void ConfigurarComponentes()
        {

            try
            {
                cmbEstadoProp.DataSource = Enum.GetValues(typeof(pEstados));
                cmbUbicacionLlaves.DataSource = Enum.GetValues(typeof(PropiedadBE.UbicacionesLlaves));
                cmbEstadoProp.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbUbicacionLlaves.DropDownStyle = ComboBoxStyle.DropDownList;
                dgvPropiedades.MultiSelect = false;
                dgvPropiedades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnAplicarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPropiedades.SelectedRows.Count == 0)
                {
                    MessageBox.Show("¡Seleccione una propiedad de la grilla para dar de baja!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int idSeleccionado = Convert.ToInt32(dgvPropiedades.SelectedRows[0].Cells["ID"].Value);
                PropiedadBE propiedadModif = bllPropiedad.BuscarPropiedad(idSeleccionado);
                ContratoBE contrato = bllContrato.BuscarContrato(propiedadModif.ContratoID);

                //¿Tiene contrato vinculado o no/esta cancelado?
                if (cmbEstadoProp.SelectedValue.ToString() == "Disponible" && contrato == null || contrato.Estado == cEstados.Cancelado)
                {
                    DialogResult result = MessageBox.Show("La propiedad no posee un contrato vinculado vigente. En orden para cambiar su estado a Disponible debe vincular un contrato. \r" +
                                    "¿Desea dirigirse a la interfaz de contratos ahora?", "Contrato faltante", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    if (result != DialogResult.OK)
                    {
                        MessageBox.Show("Modificación de estado cancelado", "Modificación cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    FormContratos frmContrato = new FormContratos(() => RefrescarDGV());
                    frmContrato.ShowDialog();
                    //Refresco para traerme el estado de la propiedad desde el datatable (cambiado, presumiblemente), en el form contratos
                    propiedadModif = bllPropiedad.BuscarPropiedad(idSeleccionado);
                }
                else
                {
                    propiedadModif.Estado = Enum.Parse<pEstados>(cmbEstadoProp.SelectedValue.ToString());
                }
                propiedadModif.UbicacionLlaves = Enum.Parse<PropiedadBE.UbicacionesLlaves>(cmbUbicacionLlaves.SelectedValue.ToString());

                bllPropiedad.Modificar(propiedadModif);
                RefrescarDGV();

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
                                    select new
                                    {
                                        p.ID,
                                        p.ContratoID,
                                        p.PropietarioID,
                                        p.Estado,
                                        Llaves = p.UbicacionLlaves,
                                        p.Domicilio,
                                        p.Localidad,
                                        p.PrecioUSD,

                                    }).ToList();
                dgvPropiedades.DataSource = listaTratada;
                dgvPropiedades.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btngestionContrato_Click(object sender, EventArgs e)
        {

            try
            {
                FormContratos frmContratos = new FormContratos();
                frmContratos.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPropiedades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvPropiedades.SelectedRows.Count > 0)
                {
                    int idPropiedadSeleccionada = Convert.ToInt32(dgvPropiedades.SelectedRows[0].Cells["ID"].Value);
                    PropiedadBE propiedadSeleccionada = bllPropiedad.BuscarPropiedad(idPropiedadSeleccionada);

                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    string ruta = @$"{bllPropiedad.GetImgPortada(idPropiedadSeleccionada)}";
                    if (!File.Exists(ruta))
                    {
                        pictureBox1.Image = Resources.Propiedad_sin_imagen;
                    }
                    else
                    {
                        pictureBox1.Image = Image.FromFile(ruta);
                    }

                    ContratoBE contratoVinculado = bllContrato.BuscarContratoPropiedad(idPropiedadSeleccionada);

                    lblVence.Text = contratoVinculado == null ? "Sin contrato" : contratoVinculado.FechaVencimiento.ToShortDateString();
                    cnContrato.Text = contratoVinculado == null ? "" : contratoVinculado.ID.ToString();
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void txtBuscarDomic_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if (txtBuscarDomic.Text.Length > 0)
                {
                    string patron = txtBuscarDomic.Text.Trim();
                    Regex reDom = new Regex(patron, RegexOptions.IgnoreCase);

                    dgvPropiedades.DataSource = null;
                    var listaTratada = (from p in bllPropiedad.ConsultarPropiedades().Where(p => reDom.IsMatch(p.Domicilio))
                                        where p.Estado != pEstados.Vendida
                                        select new
                                        {
                                            p.ID,
                                            p.ContratoID,
                                            p.PropietarioID,
                                            p.Estado,
                                            Llaves = p.UbicacionLlaves,
                                            p.Domicilio,
                                            p.Localidad,
                                            p.PrecioUSD,

                                        }).ToList();


                    dgvPropiedades.DataSource = listaTratada;
                    dgvPropiedades.Refresh();
                }
                else
                {
                    RefrescarDGV();
                }
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
                if (txtBuscarID.Text.Length > 0)
                {
                    string patron = txtBuscarID.Text.Trim();
                    Regex reID = new Regex(patron);

                    dgvPropiedades.DataSource = null;
                    var listaTratada = (from p in bllPropiedad.ConsultarPropiedades().Where(p => reID.IsMatch(p.ID.ToString()))
                                        where p.Estado != pEstados.Vendida
                                        select new
                                        {
                                            p.ID,
                                            p.ContratoID,
                                            p.PropietarioID,
                                            p.Estado,
                                            Llaves = p.UbicacionLlaves,
                                            p.Domicilio,
                                            p.Localidad,
                                            p.PrecioUSD,

                                        }).ToList();


                    dgvPropiedades.DataSource = listaTratada;
                    dgvPropiedades.Refresh();
                }
                else
                {
                    RefrescarDGV();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
