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
using L2BE;
using Estados = L2BE.VisitaBE.EstadosVisita;

namespace L1GUI.Forms
{
    public partial class FormHistorialVisitas : Form
    {
        VisitaBLL bllVisita;
        ClienteBLL bllCliente;
        PropiedadBLL bllPropiedad;

        public FormHistorialVisitas()
        {
            InitializeComponent();
            bllVisita = new VisitaBLL();
            bllCliente = new ClienteBLL();
            bllPropiedad = new PropiedadBLL();
            ConfigurarComponentes();
        }

        private void FormHistorialVisitas_Load(object sender, EventArgs e)
        {
            RefrescarDGV();
        }

        private void ConfigurarComponentes()
        {

            try
            {
                dgvVisitas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvVisitas.MultiSelect = false;
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
                var listaTratada = (from v in bllVisita.ConsultarVisitas().Where(v => v.Estado != Estados.Pendiente)
                                    select new
                                    {
                                        v.ID,
                                        Estado = v.Estado.ToString(),
                                        Fecha = v.FechaHora.ToString("dd/MM/yy"),
                                        Hora = v.FechaHora.ToString("HH:mm"),
                                        Visitante = bllCliente.BuscarCliente(v.VisitanteID).ToString(),
                                        Propiedad = v.PropiedadID,
                                        bllPropiedad.BuscarPropiedad(v.PropiedadID).Domicilio

                                    }).ToList();

                dgvVisitas.DataSource = listaTratada;

                foreach (DataGridViewRow dgvRow in dgvVisitas.Rows)
                {
                    if (dgvRow.Cells["Estado"].Value.ToString() == "Cancelada")
                    {
                        dgvRow.DefaultCellStyle.BackColor = Color.LightPink;
                    }
                    else
                    {
                        dgvRow.DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                }
                dgvVisitas.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgvVisitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (dgvVisitas.SelectedRows.Count > 0)
                {
                    int idVisita = Convert.ToInt32(dgvVisitas.SelectedRows[0].Cells["ID"].Value);
                    txtComentarios.Text = bllVisita.BuscarVisita(idVisita).ComentariosVisita;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgvVisitas.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar una visita a eliminar", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


                int idVisita = Convert.ToInt32(dgvVisitas.SelectedRows[0].Cells["ID"].Value);
                bllVisita.Baja(idVisita);
                RefrescarDGV();

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
                List<VisitaBE> lista = bllVisita.ConsultarVisitas();
                lista.Sort(new VisitaFechaLejana());

                var listaTratada = (from v in lista.Where(v => v.Estado != Estados.Pendiente)
                                    select new
                                    {
                                        v.ID,
                                        Estado = v.Estado.ToString(),
                                        Fecha = v.FechaHora.Date,
                                        Hora = v.FechaHora.TimeOfDay,
                                        Visitante = bllCliente.BuscarCliente(v.VisitanteID).ToString(),
                                        Propiedad = v.PropiedadID,
                                        bllPropiedad.BuscarPropiedad(v.PropiedadID).Domicilio

                                    }).ToList();

                dgvVisitas.DataSource = listaTratada;

                foreach (DataGridViewRow dgvRow in dgvVisitas.Rows)
                {
                    if (dgvRow.Cells["Estado"].Value.ToString() == "Cancelada")
                    {
                        dgvRow.DefaultCellStyle.BackColor = Color.LightPink;
                    }
                    else
                    {
                        dgvRow.DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                }
                dgvVisitas.Refresh();

                dgvVisitas.Refresh();

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
                List<VisitaBE> lista = bllVisita.ConsultarVisitas();
                lista.Sort(new VisitaFechaCercana());

                var listaTratada = (from v in lista.Where(v => v.Estado != Estados.Pendiente)
                                    select new
                                    {
                                        v.ID,
                                        Estado = v.Estado.ToString(),
                                        Fecha = v.FechaHora.Date,
                                        Hora = v.FechaHora.TimeOfDay,
                                        Visitante = bllCliente.BuscarCliente(v.VisitanteID).ToString(),
                                        Propiedad = v.PropiedadID,
                                        bllPropiedad.BuscarPropiedad(v.PropiedadID).Domicilio

                                    }).ToList();

                dgvVisitas.DataSource = listaTratada;

                foreach (DataGridViewRow dgvRow in dgvVisitas.Rows)
                {
                    if (dgvRow.Cells["Estado"].Value.ToString() == "Cancelada")
                    {
                        dgvRow.DefaultCellStyle.BackColor = Color.LightPink;
                    }
                    else
                    {
                        dgvRow.DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                }
                dgvVisitas.Refresh();

                dgvVisitas.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
