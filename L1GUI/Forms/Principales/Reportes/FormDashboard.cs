using L2BE;
using L3BLL;
using Microsoft.Office.Interop.Word;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using EstadoContrato = L2BE.ContratoBE.EstadoContrato;

namespace L1GUI.Forms
{
    public partial class FormDashboard : Form
    {
        ContratoBLL bllContrato;
        ClienteBLL bllCliente;
        PropiedadBLL bllPropiedad;
        TasacionBLL bllTasacion;
        VentaBLL bllVenta;
        InteraccionBLL bllInteraccion;
        FacturaTasacionBLL bllFacturaTasacion;
        VisitaBLL bllVisita;
        List<PropiedadBE> propiedades = new List<PropiedadBE>();
        DateTime fechaParametro;

        public FormDashboard()
        {
            InitializeComponent();
            bllContrato = new ContratoBLL();
            bllCliente = new ClienteBLL();
            bllPropiedad = new PropiedadBLL();
            bllTasacion = new TasacionBLL();
            bllVenta = new VentaBLL();
            bllInteraccion = new InteraccionBLL();
            bllTasacion = new TasacionBLL();
            bllFacturaTasacion = new FacturaTasacionBLL();
            bllVisita = new VisitaBLL();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            ConfigurarComponentes();
        }

        private void ConfigurarComponentes()
        {

            try
            {
                #region General
                //fecha inicial para mostrar los cuando se abra el form
                fechaParametro = DateTime.Now.AddDays(-30);
                ActualizarLabelIngresosBrutos();

                propiedades = bllPropiedad.ConsultarPropiedades();

                lblClientesCount.Text = bllCliente.ConsultarTodosLosClientes().Count().ToString();
                lblPropiedadesCount.Text = propiedades.Count().ToString();
                lblPropietariosCount.Text = bllCliente.ConsultarPropietarios().Count().ToString();

                rbVentas.Checked = true;
                rbConsultadas.Checked = true;
                rbTodos.Checked = true;

                dtp1.Format = DateTimePickerFormat.Custom;
                dtp1.CustomFormat = "dd  MMMM  yyyy";

                #endregion

                #region Charts

                cBarras.ChartAreas[0].AxisX.Interval = 1;
                cBarras.ChartAreas[0].AxisY.Interval = 2;

                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Barras
        private void ActualizarBarrasPorInteracciones()
        {
            try
            {
                cBarras.Series[0].Points.Clear();
                var interacciones = bllInteraccion.ConsultarInteracciones().Where(i => i.Fecha.Date >= fechaParametro.Date);
                var interaccionesAgrupadas = interacciones.GroupBy(i => i.Fecha.Date).OrderBy(grupo => grupo.Key);

                int indice = 0;
                foreach (var grupo in interaccionesAgrupadas)
                {
                    //Cuantas consultas por fecha
                    int cantidad = grupo.Count();
                    //En el eje X agrego la cantidad según el número del índice
                    var punto = cBarras.Series[0].Points.AddXY(indice, cantidad);
                    //reemplazo el label
                    cBarras.Series[0].Points[indice].AxisLabel = grupo.Key.ToShortDateString();

                    indice++;
                }
                if (interacciones.Count() < 1) lblSinInformacion.Visible = true;
                else lblSinInformacion.Visible = false;
            }
            catch (InvalidOperationException)
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarBarrasPorVisitas()
        {
            try
            {
                cBarras.Series[0].Points.Clear();
                var visitas = bllVisita.ConsultarVisitas().Where(v => v.FechaHora.Date >= fechaParametro.Date && v.Estado == VisitaBE.EstadosVisita.Realizada);
                var visitasAgrupadas = visitas.GroupBy(v => v.FechaHora.Date).OrderBy(grupo => grupo.Key);

                int indice = 0;
                foreach (var grupo in visitasAgrupadas)
                {
                    //Cuantas consultas por fecha
                    int cantidad = grupo.Count();
                    //En el eje X agrego la cantidad según el número del índice
                    var punto = cBarras.Series[0].Points.AddXY(indice, cantidad);
                    //reemplazo el label
                    cBarras.Series[0].Points[indice].AxisLabel = grupo.Key.ToShortDateString();

                    indice++;
                }
                if (visitas.Count() < 1) lblSinInformacion.Visible = true;
                else lblSinInformacion.Visible = false;
            }
            catch (InvalidOperationException)
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }


        private void ActualizarBarrasPorVentas()
        {
            try
            {
                cBarras.Series[0].Points.Clear();
                var ventas = bllVenta.ConsultarVentas().Where(v => v.FechaVenta.Date >= fechaParametro.Date);
                var ventasAgrupadas = ventas.GroupBy(v => v.FechaVenta.Date).OrderBy(grupo => grupo.Key);

                int indice = 0;
                foreach (var grupo in ventasAgrupadas)
                {
                    //Cuantas consultas por fecha
                    int cantidad = grupo.Count();
                    //En el eje X agrego la cantidad según el número del índice
                    var punto = cBarras.Series[0].Points.AddXY(indice, cantidad);
                    //reemplazo el label
                    cBarras.Series[0].Points[indice].AxisLabel = grupo.Key.ToShortDateString();

                    indice++;
                }
                if (ventas.Count() < 1) lblSinInformacion.Visible = true;
                else lblSinInformacion.Visible = false;
            }
            catch (InvalidOperationException)
            {

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarBarrasPorTasaciones()
        {
            try
            {
                cBarras.Series[0].Points.Clear();
                var tasaciones = bllTasacion.ConsultarTasaciones().Where(t => t.FechaHora.Date >= fechaParametro.Date);
                var tasacionesAgrupadas = tasaciones.GroupBy(t => t.FechaHora.Date).OrderBy(grupo => grupo.Key);

                int indice = 0;
                foreach (var grupo in tasacionesAgrupadas)
                {
                    //Cuantas consultas por fecha
                    int cantidad = grupo.Count();
                    //En el eje X agrego la cantidad según el número del índice
                    var punto = cBarras.Series[0].Points.AddXY(indice, cantidad);
                    //reemplazo el label
                    cBarras.Series[0].Points[indice].AxisLabel = grupo.Key.ToShortDateString();

                    indice++;
                }
                if (tasaciones.Count() < 1) lblSinInformacion.Visible = true;
                else lblSinInformacion.Visible = false;
            }
            catch (InvalidOperationException)
            {

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarLabelIngresosBrutos()
        {
            try
            {
                decimal ingresosVentas = 0;
                decimal ingresosTasaciones = 0;
                var ventas = bllVenta.ConsultarVentas().Where(v => v.FechaVenta.Date >= fechaParametro.Date);
                var facturasTasacion = bllFacturaTasacion.ConsultarFacturas().Where(t => t.Fecha.Date >= fechaParametro.Date);

                foreach (VentaBE venta in ventas)
                {
                    ingresosVentas += (venta.PrecioConvenido * venta.PorcentajeComisionVendedor) + (venta.PrecioConvenido * venta.PorcentajeComisionComprador);
                }
                foreach (FacturaTasacionBE factura in facturasTasacion)
                {
                    ingresosTasaciones += factura.Total;
                }

                

                lblIngresosBrutos.Text = $"INGRESOS BRUTOS DE " + fechaParametro.ToString("MMMM").ToUpper();
                lblIngresosBrutosValue.Text = "(USD) " + ingresosVentas.ToString("C2", new System.Globalization.CultureInfo("es-AR"));
                lblBrutosARS.Text = "(ARS) " + ingresosTasaciones.ToString("C2", new System.Globalization.CultureInfo("es-AR"));



            }
            catch (InvalidOperationException)
            {

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Botones de fechas
        private void btnHoy_Click(object sender, EventArgs e)
        {
            fechaParametro = DateTime.Now;
            if (rbInteracciones.Checked) { ActualizarBarrasPorInteracciones(); }
            else if (rbVentas.Checked) { ActualizarBarrasPorVentas(); }
            else if (rbTasaciones.Checked) { ActualizarBarrasPorTasaciones(); }
            else if (rbVisitas.Checked) { ActualizarBarrasPorVisitas(); }
            if (rbConsultadas.Checked) { ActualizarTortaConsultadas(); }
            else { ActualizarTortaVendidas(); }

            ActualizarLabelIngresosBrutos();
        }

        private void btnSemana_Click(object sender, EventArgs e)
        {
            fechaParametro = DateTime.Now.AddDays(-7);
            if (rbInteracciones.Checked) { ActualizarBarrasPorInteracciones(); }
            else if (rbVentas.Checked) { ActualizarBarrasPorVentas(); }
            else if (rbTasaciones.Checked) { ActualizarBarrasPorTasaciones(); }
            else if (rbVisitas.Checked) { ActualizarBarrasPorVisitas(); }
            if (rbConsultadas.Checked) { ActualizarTortaConsultadas(); }
            else { ActualizarTortaVendidas(); }

            ActualizarLabelIngresosBrutos();
        }

        private void btnUltimos_Click(object sender, EventArgs e)
        {
            fechaParametro = DateTime.Now.AddDays(-30);
            if (rbInteracciones.Checked) { ActualizarBarrasPorInteracciones(); }
            else if (rbVentas.Checked) { ActualizarBarrasPorVentas(); }
            else if (rbTasaciones.Checked) { ActualizarBarrasPorTasaciones(); }
            else if (rbVisitas.Checked) { ActualizarBarrasPorVisitas(); }
            if (rbConsultadas.Checked) { ActualizarTortaConsultadas(); }
            else { ActualizarTortaVendidas(); }
            ActualizarLabelIngresosBrutos();
        }

        private void btMes_Click(object sender, EventArgs e)
        {
            int diaDelMes = DateTime.Now.Day;
            fechaParametro = DateTime.Now.AddDays(-(diaDelMes - 1));
            if (rbInteracciones.Checked) { ActualizarBarrasPorInteracciones(); }
            else if (rbVentas.Checked) { ActualizarBarrasPorVentas(); }
            else if (rbTasaciones.Checked) { ActualizarBarrasPorTasaciones(); }
            else if (rbVisitas.Checked) { ActualizarBarrasPorVisitas(); }
            if (rbConsultadas.Checked) { ActualizarTortaConsultadas(); }
            else { ActualizarTortaVendidas(); }
            ActualizarLabelIngresosBrutos();
        }

        private void dtp1_CloseUp(object sender, EventArgs e)
        {
            fechaParametro = dtp1.Value;
            if (rbInteracciones.Checked) { ActualizarBarrasPorInteracciones(); }
            else if (rbVentas.Checked) { ActualizarBarrasPorVentas(); }
            else if (rbTasaciones.Checked) { ActualizarBarrasPorTasaciones(); }
            else if (rbVisitas.Checked) { ActualizarBarrasPorVisitas(); }
            if (rbConsultadas.Checked) { ActualizarTortaConsultadas(); }
            else { ActualizarTortaVendidas(); }
            ActualizarLabelIngresosBrutos();
        }

        #endregion

        #region Radio Buttons Barras

        private void rbInteracciones_CheckedChanged(object sender, EventArgs e)
        {
            if (rbInteracciones.Checked) { ActualizarBarrasPorInteracciones(); }
        }

        private void rbVentas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbVentas.Checked) { ActualizarBarrasPorVentas(); }
        }

        private void rbTasaciones_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTasaciones.Checked) { ActualizarBarrasPorTasaciones(); }
        }

        #endregion

        #region Radio buttons Torta
        private void rbConsultadas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbConsultadas.Checked)
            {
                ActualizarTortaConsultadas();
            }

        }
        private void rbVendidas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbVendidas.Checked)
            {
                ActualizarTortaVendidas();
            }
        }

        private void ActualizarTortaConsultadas()
        {

            try
            {
                cTorta.Series[0].Points.Clear();
                int duplex, terreno, casa, departamento, local = 0;
                duplex = terreno = casa = departamento = local;
                var interacciones = bllInteraccion.ConsultarInteracciones().Where(i => i.Fecha.Date >= fechaParametro.Date);
                foreach (InteraccionBE interaccion in interacciones)
                {
                    switch (propiedades.Find(p => p.ID == interaccion.PropiedadID).Tipo)
                    {
                        case PropiedadBE.TiposPropiedad.Casa:
                            casa += 1;
                            break;

                        case PropiedadBE.TiposPropiedad.Departamento:
                            departamento += 1;
                            break;

                        case PropiedadBE.TiposPropiedad.Terreno:
                            terreno += 1;
                            break;
                        case PropiedadBE.TiposPropiedad.Local:
                            local += 1;
                            break;
                        case PropiedadBE.TiposPropiedad.Duplex:
                            duplex += 1;
                            break;
                    }
                }
                cTorta.Series[0].Points.AddXY("Casa", casa);
                cTorta.Series[0].Points.AddXY("Depto", departamento);
                cTorta.Series[0].Points.AddXY("Duplex", duplex);
                cTorta.Series[0].Points.AddXY("Terreno", terreno);
                cTorta.Series[0].Points.AddXY("Local", local);
                cTorta.Series[0].IsValueShownAsLabel = false;
                if (interacciones.Count() < 1)
                    lblSinInformacion2.Visible = true;
                else lblSinInformacion2.Visible = false;

            }
            catch (InvalidOperationException)
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarTortaVendidas()
        {

            try
            {
                cTorta.Series[0].Points.Clear();

                int duplex, terreno, casa, departamento, local;
                duplex = terreno = casa = departamento = local = 0;

                var ventas = bllVenta.ConsultarVentas().Where(v => v.FechaVenta.Date >= fechaParametro.Date);

                List<PropiedadBE> propiedadesVendidas = new List<PropiedadBE>();

                foreach (VentaBE venta in ventas)
                {
                    propiedadesVendidas.Add(bllPropiedad.BuscarPropiedad(venta.PropiedadVendidaID));
                }

                foreach (PropiedadBE propiedad in propiedadesVendidas)
                {
                    switch (propiedad.Tipo)
                    {
                        case PropiedadBE.TiposPropiedad.Casa:
                            casa += 1;
                            break;

                        case PropiedadBE.TiposPropiedad.Departamento:
                            departamento += 1;
                            break;

                        case PropiedadBE.TiposPropiedad.Terreno:
                            terreno += 1;
                            break;
                        case PropiedadBE.TiposPropiedad.Local:
                            local += 1;
                            break;
                        case PropiedadBE.TiposPropiedad.Duplex:
                            duplex += 1;
                            break;
                    }
                }
                cTorta.Series[0].Points.AddXY("Casa", casa);
                cTorta.Series[0].Points.AddXY("Depto", departamento);
                cTorta.Series[0].Points.AddXY("Duplex", duplex);
                cTorta.Series[0].Points.AddXY("Terreno", terreno);
                cTorta.Series[0].Points.AddXY("Local", local);
                cTorta.Series[0].IsValueShownAsLabel = false;
                if (ventas.Count() < 1)
                    lblSinInformacion2.Visible = true;
                else lblSinInformacion2.Visible = false;

            }
            catch (InvalidOperationException)
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion

        #region Contratos

        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTodos.Checked)
            {

                dgvContratos.DataSource = false;
                var listaTratada = (from c in bllContrato.ConsultarContratos()
                                    where c.Estado == EstadoContrato.Vigente
                                    select new
                                    {
                                        c.ID,
                                        c.FechaVencimiento,
                                        c.Estado,
                                        Propiedad = c.PropiedadID,
                                        Propietario = bllCliente.BuscarCliente(c.PropietarioID).ToString()
                                    }).ToList();
                dgvContratos.DataSource = listaTratada;
                dgvContratos.Refresh();
            }
        }

        private void rbProximaSemana_CheckedChanged(object sender, EventArgs e)
        {
            if (rbProximaSemana.Checked)
            {

                dgvContratos.DataSource = false;
                var listaTratada = (from c in bllContrato.ConsultarContratos()
                                    where c.Estado == EstadoContrato.Vigente &&
                                    c.FechaVencimiento.Date < DateTime.Now.AddDays(7)
                                    select new
                                    {
                                        c.ID,
                                        c.FechaVencimiento,
                                        c.Estado,
                                        Propiedad = c.PropiedadID,
                                        Propietario = bllCliente.BuscarCliente(c.PropietarioID).ToString()
                                    }).ToList();
                dgvContratos.DataSource = listaTratada;
                dgvContratos.Refresh();
            }
        }

        private void rbProximoMes_CheckedChanged(object sender, EventArgs e)
        {
            if (rbProximoMes.Checked)
            {

                dgvContratos.DataSource = false;
                var listaTratada = (from c in bllContrato.ConsultarContratos()
                                    where c.Estado == EstadoContrato.Vigente &&
                                    c.FechaVencimiento.Date < DateTime.Now.AddMonths(1)
                                    select new
                                    {
                                        c.ID,
                                        c.FechaVencimiento,
                                        c.Estado,
                                        Propiedad = c.PropiedadID,
                                        Propietario = bllCliente.BuscarCliente(c.PropietarioID).ToString()
                                    }).ToList();
                dgvContratos.DataSource = listaTratada;
                dgvContratos.Refresh();
            }
        }

        #endregion

        private void rbVisitas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbVisitas.Checked) { ActualizarBarrasPorVisitas(); }
        }
    }
}
