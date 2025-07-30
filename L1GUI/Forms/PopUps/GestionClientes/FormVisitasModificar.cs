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

namespace L1GUI.Forms.PopUps
{
    public partial class FormVisitasModificar : Form
    {
        VisitaBLL bllVisita;
        PropiedadBLL bllPropiedad;
        ClienteBLL bllCliente;
        ClienteBE visitante;
        PropiedadBE propiedad;

        VisitaBE visitaModif;
        Action refrescarDGVHijo;
        public FormVisitasModificar(VisitaBE pVisitaModif, Action pRefreshDGV)
        {

            try
            {
                InitializeComponent();
                this.visitaModif = pVisitaModif;
                this.refrescarDGVHijo = pRefreshDGV;
                bllVisita = new VisitaBLL();
                bllPropiedad = new PropiedadBLL();
                bllCliente = new ClienteBLL();
                visitante = bllCliente.BuscarCliente(visitaModif.VisitanteID);
                propiedad = bllPropiedad.BuscarPropiedad(visitaModif.PropiedadID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void FormVisitasModificar_Load(object sender, EventArgs e)
        {
            ConfigurarComponentes();
            
        }
        private void ConfigurarComponentes()
        {

            try
            {
                dtPicker.Value = visitaModif.FechaHora.Date;
                dtPickerH.Value = new DateTime(visitaModif.FechaHora.Year, visitaModif.FechaHora.Month, visitaModif.FechaHora.Day, visitaModif.FechaHora.Hour, visitaModif.FechaHora.Minute, visitaModif.FechaHora.Second);
                lblPropiedad.Text += $" ID [{propiedad.ID}] - {propiedad.Domicilio}";
                lblVisitante.Text += $" ID [{visitante.ID}] - {visitante}";

                //TODO: Volver a ponerlo si es necesario dtPicker.MinDate = DateTime.Now;
                dtPicker.Format = DateTimePickerFormat.Custom;
                dtPicker.CustomFormat = "dd  MMM  yyyy";

                dtPickerH.ShowUpDown = true;
                dtPickerH.Format = DateTimePickerFormat.Custom;
                dtPickerH.CustomFormat = "HH:mm";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            try
            {
                visitaModif.FechaHora = new DateTime(dtPicker.Value.Year, dtPicker.Value.Month, dtPicker.Value.Day, dtPickerH.Value.Hour, dtPickerH.Value.Minute, 0);
                bllVisita.Modificar(visitaModif);
                refrescarDGVHijo();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
