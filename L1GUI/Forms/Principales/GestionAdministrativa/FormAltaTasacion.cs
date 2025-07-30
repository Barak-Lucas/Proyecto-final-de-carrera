using L1GUI.Forms.PopUps;
using L2BE;
using L3BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L1GUI.Forms.Principales.GestionAdministrativa
{
    public partial class FormAltaTasacion : Form
    {
        ClienteBE propietario;
        ClienteBLL bllPropietario;
        TasacionBLL bllTasacion = new TasacionBLL();
        FacturaTasacionBLL bllFacturaTasacion;
        public delegate void DelegadoRefreshDGV(IComparer<TasacionBE> pOrdenamiento = null);
        public FormAltaTasacion()
        {
            InitializeComponent();
            bllPropietario = new ClienteBLL();
            bllTasacion = new TasacionBLL();
            bllFacturaTasacion = new FacturaTasacionBLL();
        }

        private void FormAltaTasacion_Load(object sender, EventArgs e)
        {

            try
            {
                ConfigurarComponentes();
                RefrescarDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void ConfigurarComponentes()
        {

            txtNombre.Enabled = false;
            //TODO: Volver a ponerlo si es necesario dtPicker.MinDate = DateTime.Now;
            dtPicker.Format = DateTimePickerFormat.Custom;
            dtPicker.CustomFormat = "dd  MMM  yyyy";

            dtPickerH.ShowUpDown = true;
            dtPickerH.Format = DateTimePickerFormat.Custom;
            dtPickerH.CustomFormat = "HH:mm";

            dgvTasaciones.MultiSelect = false;
            dgvTasaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            cmbLocalidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLocalidad.DataSource = PropiedadBE.LocalidadesAbarcadas;
            cmbTipo.DataSource = Enum.GetValues(typeof(PropiedadBE.TiposPropiedad));
        }

        private void RefrescarDGV(IComparer<TasacionBE> pOrdenamiento = null)
        {
            dgvTasaciones.DataSource = null;
            object[] listaTratada = { };

            if (pOrdenamiento == null)
            {
                listaTratada =
               (from t in bllTasacion.ConsultarTasaciones()
                where t.Estado == TasacionBE.Estados.Pendiente
                select new
                {
                    t.ID,
                    Propietario = bllPropietario.BuscarCliente(t.PropietarioID).ToString(),
                    t.Domicilio,
                    t.Localidad,
                    t.TipoInmueble,
                    Fecha = t.FechaHora.ToString("dd/MM/yyyy"),
                    Hora = t.FechaHora.ToString("HH:mm"),
                    Estado = t.Estado.ToString()
                }).ToArray();
            }
            else
            {
                listaTratada =
                (from t in bllTasacion.ConsultarTasaciones(pOrdenamiento)
                 where t.Estado == TasacionBE.Estados.Pendiente
                 select new
                 {
                     t.ID,
                     Propietario = bllPropietario.BuscarCliente(t.PropietarioID).ToString(),
                     t.Domicilio,
                     t.Localidad,
                     t.TipoInmueble,
                     Fecha = t.FechaHora.ToString("dd/MM/yyyy"),
                     Hora = t.FechaHora.ToString("HH:mm"),
                     Estado = t.Estado.ToString()
                 }).ToArray();
            }


            dgvTasaciones.DataSource = listaTratada;
            dgvTasaciones.Columns["TipoInmueble"].HeaderText = "Tipo del inmueble";
            dgvTasaciones.Refresh();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            if (cnPropietario.Text.Length == 0)
            {
                MessageBox.Show("Debe seleccionar un propietario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtDomicilio.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar el domicilio del inmueble a tasar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                int propietarioID = Convert.ToInt32(cnPropietario.Text);
                string domicilio = txtDomicilio.Text;
                string localidad = cmbLocalidad.Text;
                string tipo = cmbTipo.SelectedItem.ToString();
                DateTime fechaHora = dtPicker.Value.Date + dtPickerH.Value.TimeOfDay;
                TasacionBE tasacion = new TasacionBE(propietarioID, domicilio, fechaHora, localidad, tipo);
                bllTasacion.Alta(tasacion);
                RefrescarDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            if (dgvTasaciones.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una tasación para modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                int idTasacion = Convert.ToInt32(dgvTasaciones.SelectedRows[0].Cells["ID"].Value);
                TasacionBE tasacionModif = bllTasacion.BuscarTasacion(idTasacion);

                FormTasacionModificar frnTasacionModif = new FormTasacionModificar(tasacionModif, RefrescarDGV);
                frnTasacionModif.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvTasaciones.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una tasación de la grilla", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            try
            {
                int idTasacionCancel = Convert.ToInt32(dgvTasaciones.SelectedRows[0].Cells["ID"].Value);
                TasacionBE tasacionCancel = bllTasacion.BuscarTasacion(idTasacionCancel);

                if (tasacionCancel == null)
                {
                    MessageBox.Show("No se ha encontrado a la tasación en la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    DialogResult result = MessageBox.Show($"¿Está seguro que desea cancelar la tasación de ID {tasacionCancel.ID}?", "Confirmar cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        bllTasacion.Cancelar(tasacionCancel);
                        RefrescarDGV();
                        MessageBox.Show("Tasación cancelada", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void btnBuscarCliente_Click_1(object sender, EventArgs e)
        {
            FormPropietariosBuscar frmPropietariosBuscar = new FormPropietariosBuscar();
            frmPropietariosBuscar.ShowDialog();
            propietario = frmPropietariosBuscar.propietarioSeleccionado;

            if (propietario != null)
            {
                cnPropietario.Text = propietario.ID.ToString();
                txtNombre.Text = propietario.ToString();
                RefrescarDGV();
            }
            else
            {
                cnPropietario.Text = string.Empty;
            }
        }
    }
}
