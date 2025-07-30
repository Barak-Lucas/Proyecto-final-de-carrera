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

namespace L1GUI.Forms
{
    public partial class FormPropiedadesBuscar : Form
    {
        PropiedadBLL bllPropiedad;
        public PropiedadBE propiedadSeleccionada { get; private set; }
        FormContratos formContratos;

        int propietarioID;
        public FormPropiedadesBuscar(int pPropietarioID = 0, FormContratos pFormDeContratos = null)
        {
            this.propietarioID = pPropietarioID;
            this.formContratos = pFormDeContratos;
            bllPropiedad = new PropiedadBLL();
            InitializeComponent();
        }

        private void FormPopiedadBuscar_Load(object sender, EventArgs e)
        {
            ConfigurarComponentes();
            RefrescarDGV();
        }

        private void btnNuevaPropiedad_Click(object sender, EventArgs e)
        {
            FormAbmPropiedades frmAbmProp = new FormAbmPropiedades(null, () => RefrescarDGV());
            frmAbmProp.ShowDialog();
        }

        private void RefrescarDGV()
        {

            try
            {
                object listaTratada = null;

                //Si se busca una propiedad desde los contratos, se muestran las propiedades suspendidas, reservadas y disponibles
                if (formContratos != null)
                {
                    dgvPropiedades.DataSource = null;
                    listaTratada = (from p in bllPropiedad.ConsultarPropiedadesPropietario(propietarioID)
                                    where (p.Estado != PropiedadBE.EstadosPropiedad.Vendida && p.Estado != PropiedadBE.EstadosPropiedad.Retirada)
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
                }
                //si es para vender, solo las disponibles
                else
                {
                    dgvPropiedades.DataSource = null;
                    listaTratada = (from p in bllPropiedad.ConsultarPropiedades()
                                    where (p.Estado == PropiedadBE.EstadosPropiedad.Disponible)
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
                }


                dgvPropiedades.DataSource = listaTratada;
                dgvPropiedades.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgvPropiedades_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvPropiedades.SelectedRows[0].Cells["ID"].Value);
                propiedadSeleccionada = bllPropiedad.BuscarPropiedad(id);
                this.Close();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtBuscarDomicilio_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string patron = txtBuscarDomicilio.Text.Trim();
                Regex reDOM = new Regex(patron, RegexOptions.IgnoreCase);

                object listaTratada = null;

                if (formContratos != null)
                {
                    dgvPropiedades.DataSource = null;
                    listaTratada = (from p in bllPropiedad.ConsultarPropiedadesPropietario(propietarioID)
                                    where (p.Estado != PropiedadBE.EstadosPropiedad.Vendida && p.Estado != PropiedadBE.EstadosPropiedad.Retirada) &&
                                    reDOM.IsMatch(p.Domicilio)
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
                }
                else
                {
                    dgvPropiedades.DataSource = null;
                    listaTratada = (from p in bllPropiedad.ConsultarPropiedades()
                                    where (p.Estado != PropiedadBE.EstadosPropiedad.Vendida && p.Estado != PropiedadBE.EstadosPropiedad.Retirada)
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
                }


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

                if (formContratos != null)
                {
                    dgvPropiedades.DataSource = null;
                    listaTratada = (from p in bllPropiedad.ConsultarPropiedadesPropietario(propietarioID)
                                    where (p.Estado != PropiedadBE.EstadosPropiedad.Vendida && p.Estado != PropiedadBE.EstadosPropiedad.Retirada) &&
                                    reID.IsMatch(p.ID.ToString())
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
                }
                else
                {
                    dgvPropiedades.DataSource = null;
                    listaTratada = (from p in bllPropiedad.ConsultarPropiedades()
                                    where (p.Estado != PropiedadBE.EstadosPropiedad.Vendida && p.Estado != PropiedadBE.EstadosPropiedad.Retirada)
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
                }


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
