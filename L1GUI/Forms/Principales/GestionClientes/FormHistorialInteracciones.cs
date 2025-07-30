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

namespace L1GUI.Forms.Principales
{
    public partial class FormHistorialInteracciones : Form
    {
        PropiedadBE propiedadBuscada;
        InteraccionBLL bllInteraccion;
        Action ActionRefrescarDGV;
        PropiedadBE propiedadCatalogoInteractuada;
        public FormHistorialInteracciones(PropiedadBE pPropiedadCatalogoInteractuada = null)
        {

            try
            {
                InitializeComponent();
                propiedadBuscada = new PropiedadBE();
                bllInteraccion = new InteraccionBLL();
                ActionRefrescarDGV = RefrescarDGV;
                propiedadCatalogoInteractuada = pPropiedadCatalogoInteractuada;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void FormHistorialInteracciones_Load(object sender, EventArgs e)
        {

            try
            {
                ConfigurarComponentes();
                RefrescarDGV();
                if (propiedadCatalogoInteractuada != null)
                {
                    cnPropiedadID.Text = propiedadCatalogoInteractuada.ID.ToString();
                    txtDomicilio.Text = propiedadCatalogoInteractuada.Domicilio;
                }
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
                //TODO: Volver a ponerlo luego si es necesario dtPicker.MinDate = DateTime.Now.AddDays(-30);
                dtPicker.CustomFormat = "dd  MMMM  yyyy";
                dtPicker.Format = DateTimePickerFormat.Custom;
                dgvInteracciones.MultiSelect = false;
                dgvInteracciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            try
            {
                FormPropiedadesBuscar frmBuscarPropiedades = new FormPropiedadesBuscar();
                frmBuscarPropiedades.ShowDialog();
                propiedadBuscada = frmBuscarPropiedades.propiedadSeleccionada;

                if (propiedadBuscada != null)
                {
                    cnPropiedadID.Text = propiedadBuscada.ID.ToString();
                    txtDomicilio.Text = propiedadBuscada.Domicilio;
                }
                else { cnPropiedadID.Text = string.Empty; }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {

            try
            {
                if (cnPropiedadID.Text.Length == 0)
                {
                    MessageBox.Show("Seleccione la propiedad sobre la cual se interactuó", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txtNombreApellido.Text.Length == 0)
                {
                    MessageBox.Show("Ingrese el nombre del cliente interesado", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txtContacto.Text.Length == 0)
                {
                    MessageBox.Show("Ingrese un medio de contacto con el interesado", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string detalles = string.IsNullOrEmpty(txtDetalles.Text) ? "Sin detalles" : txtDetalles.Text;
                string nombreInteresado = string.IsNullOrEmpty(txtNombreApellido.Text) ? "Sin nombre/apellido" : txtNombreApellido.Text;
                string contacto = txtContacto.Text;
                DateTime fecha = dtPicker.Value;
                int propiedadID = Convert.ToInt32(cnPropiedadID.Text);

                InteraccionBE interaccion = new InteraccionBE(propiedadID, contacto, detalles, fecha, nombreInteresado);
                bllInteraccion.Alta(interaccion);
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
                dgvInteracciones.DataSource = null;
                var listaTratada =
                    (from i in bllInteraccion.ConsultarInteracciones()
                     select new
                     {
                         i.ID,
                         i.PropiedadID,
                         i.Interesado,
                         i.Contacto,
                         Fecha = i.Fecha.ToString("dd/MM/yyyy")
                     }).ToList();
                dgvInteracciones.DataSource = listaTratada;
                dgvInteracciones.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (dgvInteracciones.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una interacción para eliminar", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                int id = Convert.ToInt32(dgvInteracciones.SelectedRows[0].Cells["ID"].Value);
                bllInteraccion.Baja(id);
                RefrescarDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvInteracciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (dgvInteracciones.SelectedRows.Count != 0)
                {
                    int idSeleccionado = Convert.ToInt32(dgvInteracciones.SelectedRows[0].Cells["ID"].Value);
                    txtDetallesDGV.Text = bllInteraccion.BuscarInteraccion(idSeleccionado).Detalles;
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
                if (dgvInteracciones.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione una interacción para modificar", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int idInteraccion = Convert.ToInt32(dgvInteracciones.SelectedRows[0].Cells["ID"].Value);
                FormInteraccionModificar frmInteraccionModif = new FormInteraccionModificar(idInteraccion, ActionRefrescarDGV);
                frmInteraccionModif.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
