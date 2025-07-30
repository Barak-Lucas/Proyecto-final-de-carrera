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
using static L1GUI.Forms.FormCobrarTasacion;

namespace L1GUI.Forms.PopUps
{
    public partial class FormReimprimirFactura : Form
    {
        TasacionBLL bllTasacion;
        FacturaTasacionBLL bllFacturaTasacion;
        ClienteBLL bllPropietario;
        FormCobrarTasacion frmTasacion;


        public FormReimprimirFactura()
        {
            bllPropietario = new ClienteBLL();
            bllTasacion = new TasacionBLL();
            bllFacturaTasacion = new FacturaTasacionBLL();
            frmTasacion = new FormCobrarTasacion();
            InitializeComponent();
            dgvTasaciones.MultiSelect = false;
            dgvTasaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgvTasaciones.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar una tasacion", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                TasacionBE tasacionBaja = bllTasacion.BuscarTasacion(Convert.ToInt32(dgvTasaciones.SelectedRows[0].Cells["ID"].Value));
                if (tasacionBaja == null)
                {
                    MessageBox.Show("No se ha encontrado la tasación en la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult result = MessageBox.Show($"¿Está seguro que desea eliminar la tasación de ID {tasacionBaja.ID}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        bllTasacion.Baja(tasacionBaja.ID);
                        RefrescarDGV();
                        MessageBox.Show("Tasación eliminada", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void FormHistorialTasaciones_Load(object sender, EventArgs e)
        {
            RefrescarDGV();
        }

        private void btnLimpiarHistorial_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult result = MessageBox.Show("¿Está completamente seguro que desea eliminar todas las tasaciones del historial?", "ELIMINACIÓN EN CURSO", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (result == DialogResult.OK)
                {
                    bllTasacion.LimpiarHistorial();
                    RefrescarDGV();
                    MessageBox.Show("Historial de tasaciones eliminado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }



        private void RefrescarDGV(IComparer<TasacionBE> pOrdenamiento = null)
        {

            try
            {
                dgvTasaciones.DataSource = null;

                object[] listaTratada = { };

                if (pOrdenamiento == null)
                {
                    listaTratada = (
                        from t in bllTasacion.ConsultarTasaciones()
                        where t.Estado != TasacionBE.Estados.Pendiente
                        select new
                        {
                            t.ID,
                            Propietario = t.PropietarioID,
                            t.Domicilio,
                            t.Localidad,
                            t.TipoInmueble,
                            Fecha = t.FechaHora.ToString("dd/MM/yyyy"),
                            Valor = t.ValorInmuebleTasado == 0 ? "NO TASADO" : t.ValorInmuebleTasado.ToString("C2", new System.Globalization.CultureInfo("es-AR")),
                            Comision = t.ValorInmuebleTasado == 0 ? "NO TASADO" : (t.ValorInmuebleTasado * t.PorcentajeComision).ToString("C2", new System.Globalization.CultureInfo("es-AR")),
                            t.Estado

                        }).ToArray();
                }
                else
                {
                    listaTratada = (
                          from t in bllTasacion.ConsultarTasaciones(pOrdenamiento)
                          where t.Estado != TasacionBE.Estados.Pendiente
                          select new
                          {
                              t.ID,
                              Propietario = t.PropietarioID,
                              t.Domicilio,
                              t.Localidad,
                              t.TipoInmueble,
                              Fecha = t.FechaHora.ToString("dd/MM/yyyy"),
                              Valor = t.ValorInmuebleTasado == 0 ? "NO TASADO" : t.ValorInmuebleTasado.ToString("C2", new System.Globalization.CultureInfo("es-AR")),
                              Comision = t.ValorInmuebleTasado == 0 ? "NO TASADO" : (t.ValorInmuebleTasado * t.PorcentajeComision).ToString("C2", new System.Globalization.CultureInfo("es-AR")),
                              t.Estado

                          }).ToArray();
                }



                dgvTasaciones.DataSource = listaTratada;
                dgvTasaciones.Columns["Valor"].HeaderText = "Valor del Inmueble";
                dgvTasaciones.Columns["TipoInmueble"].HeaderText = "Tipo de Inmueble";

                foreach (DataGridViewRow row in dgvTasaciones.Rows)
                {
                    if (row.Cells["Estado"].Value.ToString() == "Cobrada")
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                    else if (row.Cells["Estado"].Value.ToString() == "Cancelada")
                    {
                        row.DefaultCellStyle.BackColor = Color.LightCoral;
                    }
                }

                dgvTasaciones.Refresh();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnReimprimir_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgvTasaciones.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar una factura para reimprimir", "Falta informaciín", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (dgvTasaciones.SelectedRows[0].Cells["Estado"].Value.ToString() != "Cobrada")
                {
                    MessageBox.Show("No se puede reimprimir una factura de una tasacion que no fue cobrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int idTasacion = Convert.ToInt32(dgvTasaciones.SelectedRows[0].Cells["ID"].Value);
                TasacionBE tasacionFactura = bllTasacion.BuscarTasacion(idTasacion);
                FacturaTasacionBE facturaReimprimir = bllFacturaTasacion.BuscarFactura(tasacionFactura);
                frmTasacion.ImprimirFactura(facturaReimprimir, "REIMPRESA");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }

        private void rbValorInmuebleASC_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                RefrescarDGV(new TasacionValorASC());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void rbValorInmuebleDESC_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
                RefrescarDGV(new TasacionValorDESC());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void rbReciente_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
                RefrescarDGV(new TasacionFechaCercana());
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
                RefrescarDGV(new TasacionFechaLejana());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void rbCobradas_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
                RefrescarDGV(new TasacionCobradaOrden());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void rbCanceladas_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
                RefrescarDGV(new TasacionCanceladaOrden());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }

}
