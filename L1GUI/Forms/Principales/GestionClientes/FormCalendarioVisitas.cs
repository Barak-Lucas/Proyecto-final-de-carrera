using L1GUI.Forms.PopUps;
using L2BE;
using L3BLL;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Estados = L2BE.VisitaBE.EstadosVisita;

namespace L1GUI.Forms
{
    public partial class FormCalendarioVisitas : Form
    {
        VisitaBLL bllVisita;
        ClienteBLL bllCliente;
        PropiedadBLL bllPropiedad;
        public FormCalendarioVisitas()
        {
            InitializeComponent();
            ConfigurarComponentes();
            bllVisita = new VisitaBLL();
            bllCliente = new ClienteBLL();
            bllPropiedad = new PropiedadBLL();
        }

        private void FormCalendarioVisitas_Load(object sender, EventArgs e)
        {
            //TODO: Form de historial de visitas para eliminar del historial también
            RefrescarDGV();
        }

        private void ConfigurarComponentes()
        {

            try
            {
                //TODO: Volver a ponerlo si es necesario dtPicker.MinDate = DateTime.Now;
                dtPicker.Format = DateTimePickerFormat.Custom;
                dtPicker.CustomFormat = "dd  MMM  yyyy";

                dtPickerH.ShowUpDown = true;
                dtPickerH.Format = DateTimePickerFormat.Custom;
                dtPickerH.CustomFormat = "HH:mm";

                dgvVisitas.MultiSelect = false;
                dgvVisitas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ProximaVisitaLabel()
        {

            try
            {
                List<VisitaBE> visitas = bllVisita.ConsultarVisitas(Estados.Pendiente);
                if (visitas.Count == 0) lblProximaVisita.Text = "Sin visitas pendientes";
                else
                {
                    visitas.Sort(new VisitaFechaCercana());
                    string fecha = visitas.First().FechaHora.Date.ToString("dd/MM/yyyy");
                    string hora = visitas.First().FechaHora.ToString("HH:mm");
                    lblProximaVisita.Text = $"Fecha: {fecha} - Hora: {hora} ";
                }
                   
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
                if (cnVisitante.Text.Length == 0 || cnPropiedad.Text.Length == 0)
                {
                    MessageBox.Show("¡Debe seleccionar un visitante y una propiedad!", "Información requerida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


                DateTime fechaHora = dtPicker.Value.Date + dtPickerH.Value.TimeOfDay;
                VisitaBE visita = new VisitaBE(Convert.ToInt32(cnVisitante.Text), Convert.ToInt32(cnPropiedad.Text), fechaHora);
                bllVisita.Alta(visita);
                RefrescarDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnBuscarPropiedad_Click(object sender, EventArgs e)
        {
            try
            {
                FormPropiedadesBuscar frmPropiedadesBuscar = new FormPropiedadesBuscar();
                frmPropiedadesBuscar.ShowDialog();
                PropiedadBE propiedadSeleccionada = frmPropiedadesBuscar.propiedadSeleccionada;

                if (propiedadSeleccionada != null)
                {
                    cnPropiedad.Text = propiedadSeleccionada.ID.ToString();
                    lblPropiedad.Text = propiedadSeleccionada.Domicilio + Environment.NewLine + propiedadSeleccionada.Localidad;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnCliente_Click(object sender, EventArgs e)
        {

            try
            {
                FormClientesBuscar frmClientesBuscar = new FormClientesBuscar();
                frmClientesBuscar.ShowDialog();
                ClienteBE clienteSeleccionado = frmClientesBuscar.clienteSeleccionado;

                if (clienteSeleccionado != null)
                {
                    cnVisitante.Text = clienteSeleccionado.ID.ToString();
                    lblVisitante.Text = clienteSeleccionado.ToString() + Environment.NewLine + "Contacto: ";
                    if (clienteSeleccionado.Telefono != string.Empty)
                    {
                        lblVisitante.Text += clienteSeleccionado.Telefono;
                    }
                    else
                    {
                        lblVisitante.Text += clienteSeleccionado.Email;

                    }
                }
                else { lblVisitante.Text = string.Empty; cnVisitante.Text = string.Empty; }


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
                dgvVisitas.DataSource = null;
                var listaTratada = (from v in bllVisita.ConsultarVisitas(Estados.Pendiente)
                                    select new
                                    {
                                        v.ID,
                                        Fecha = v.FechaHora.Date,
                                        Hora = v.FechaHora.ToString("HH:mm"),
                                        Visitante = bllCliente.BuscarCliente(v.VisitanteID).ToString(),
                                        Propiedad = v.PropiedadID,
                                        bllPropiedad.BuscarPropiedad(v.PropiedadID).Domicilio

                                    }).ToList();
                dgvVisitas.DataSource = listaTratada;
                dgvVisitas.Refresh();

                ProximaVisitaLabel();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancelarVisita_Click(object sender, EventArgs e)
        {
            if (dgvVisitas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una visita de la grilla para cancelarla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    int idVisita = Convert.ToInt32(dgvVisitas.SelectedRows[0].Cells["ID"].Value);
                    VisitaBE visitaCancelar = bllVisita.BuscarVisita(idVisita);

                    if (visitaCancelar == null)
                    {
                        MessageBox.Show("No se ha podido encontrar a la visita en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    DialogResult result = MessageBox.Show($"¿Confirma la cancelación de la visita programada para el {visitaCancelar.FechaHora.ToString("dd/MM/yyyy HH:mm")}?", "Confirmación de cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        string comentarios = Interaction.InputBox("¿Comentar cancelación?", "Comentarios", "Cancelada por el visitante");
                        visitaCancelar.ComentariosVisita = comentarios;
                        bllVisita.Cancelar(visitaCancelar);
                        RefrescarDGV();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            FormHistorialVisitas frmHistorialVisitas = new FormHistorialVisitas();
            frmHistorialVisitas.ShowDialog();
        }

        private void btnVisitaRealizada_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgvVisitas.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar una visita de la grilla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {

                    int idVisita = Convert.ToInt32(dgvVisitas.SelectedRows[0].Cells["ID"].Value);
                    VisitaBE visitaRealizar = bllVisita.BuscarVisita(idVisita);

                    if (visitaRealizar == null)
                    {
                        MessageBox.Show("No se ha podido encontrar la visita en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string comentarios = Interaction.InputBox("Agregar comentarios a la visita: ", "Comentarios", "Sin comentarios");

                    if (string.IsNullOrEmpty(comentarios)) comentarios = "Sin comentarios";

                    visitaRealizar.ComentariosVisita = comentarios;
                    bllVisita.VisitaRealizada(visitaRealizar);
                    RefrescarDGV();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnModif_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgvVisitas.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar una visita de la grilla para modificarla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {

                    int idVisita = Convert.ToInt32(dgvVisitas.SelectedRows[0].Cells["ID"].Value);
                    VisitaBE visitaModificar = bllVisita.BuscarVisita(idVisita);

                    if (visitaModificar == null)
                    {
                        MessageBox.Show("No se ha podido encontrar a la visita en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    FormVisitasModificar frmVisitasModif = new FormVisitasModificar(visitaModificar, () => RefrescarDGV());
                    frmVisitasModif.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void rbCercana_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                dgvVisitas.DataSource = null;
                List<VisitaBE> lista = bllVisita.ConsultarVisitas(Estados.Pendiente);
                lista.Sort(new VisitaFechaCercana());

                var listaTratada = (from v in lista
                                    select new
                                    {
                                        v.ID,
                                        Fecha = v.FechaHora.Date,
                                        Hora = v.FechaHora.ToString("HH:mm"),
                                        Visitante = bllCliente.BuscarCliente(v.VisitanteID).ToString(),
                                        Propiedad = v.PropiedadID,
                                        bllPropiedad.BuscarPropiedad(v.PropiedadID).Domicilio

                                    }).ToList();

                dgvVisitas.DataSource = listaTratada;
                dgvVisitas.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbAntigua_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                dgvVisitas.DataSource = null;
                List<VisitaBE> lista = bllVisita.ConsultarVisitas(Estados.Pendiente);
                lista.Sort(new VisitaFechaLejana());

                var listaTratada = (from v in lista
                                    select new
                                    {
                                        v.ID,
                                        Fecha = v.FechaHora.Date,
                                        Hora = v.FechaHora.ToString("HH:mm"),
                                        Visitante = bllCliente.BuscarCliente(v.VisitanteID).ToString(),
                                        Propiedad = v.PropiedadID,
                                        bllPropiedad.BuscarPropiedad(v.PropiedadID).Domicilio

                                    }).ToList();

                dgvVisitas.DataSource = listaTratada;
                dgvVisitas.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
