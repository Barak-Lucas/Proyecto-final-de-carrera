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
using static L1GUI.Forms.Principales.GestionAdministrativa.FormAltaTasacion;

namespace L1GUI.Forms.PopUps
{
    public partial class FormTasacionModificar : Form
    {
        TasacionBE tasacionModif;
        DelegadoRefreshDGV delegadoRefresh;
        ClienteBLL bllPropietario;
        TasacionBLL bllTasacion;
        ClienteBE propietario;

        public FormTasacionModificar(TasacionBE pTasacion, DelegadoRefreshDGV pRefreshDGV)
        {

            try
            {
                InitializeComponent();
                this.tasacionModif = pTasacion;
                this.delegadoRefresh = pRefreshDGV;
                bllPropietario = new ClienteBLL();
                bllTasacion = new TasacionBLL();
                propietario = bllPropietario.BuscarCliente(tasacionModif.PropietarioID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                   
        }

        private void FormTasacionModificar_Load(object sender, EventArgs e)
        {
            ConfigurarComponentes();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            try
            {
                tasacionModif.FechaHora = dtPicker.Value.Date + dtPickerH.Value.TimeOfDay;
                bllTasacion.Modificar(tasacionModif);
                MessageBox.Show("¡Modificación exitosa!", "Éxito",MessageBoxButtons.OK, MessageBoxIcon.Information);
                delegadoRefresh();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error durante la modificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfigurarComponentes()
        {
            try
            {
                dtPicker.Value = tasacionModif.FechaHora.Date;
                dtPickerH.Value = new DateTime(tasacionModif.FechaHora.Year, tasacionModif.FechaHora.Month, tasacionModif.FechaHora.Day, tasacionModif.FechaHora.Hour, tasacionModif.FechaHora.Minute, tasacionModif.FechaHora.Second);
                lblLocacion.Text += $" {tasacionModif.Domicilio}, {tasacionModif.Localidad}";
                lblPropietario.Text += $" {propietario} - ID [{propietario.ID}]";

                //TODO: Volver a ponerlo si es necesario dtPicker.MinDate = DateTime.Now;
                dtPicker.Format = DateTimePickerFormat.Custom;
                dtPicker.CustomFormat = "dd  MMM  yyyy";

                dtPickerH.ShowUpDown = true;
                dtPickerH.Format = DateTimePickerFormat.Custom;
                dtPickerH.CustomFormat = "HH:mm";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al configurar componentes del Form {Environment.NewLine} {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

           
        }
    }
}
