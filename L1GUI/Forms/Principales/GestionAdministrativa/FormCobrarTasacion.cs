using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using L1GUI.Forms.PopUps;
using L1GUI.Properties;
using L2BE;
using L3BLL;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace L1GUI.Forms
{
    public partial class FormCobrarTasacion : Form
    {
        ClienteBE propietario;
        ClienteBLL bllPropietario;
        TasacionBLL bllTasacion = new TasacionBLL();
        FacturaTasacionBLL bllFacturaTasacion;
        public delegate void DelegadoImprimirFactura(FacturaTasacionBE facturaTasacion, string pReimpreso = "");
        

        public FormCobrarTasacion()
        {
            InitializeComponent();
            bllPropietario = new ClienteBLL();
            bllTasacion = new TasacionBLL();
            bllFacturaTasacion = new FacturaTasacionBLL();

        }

        private void FormTasaciones_Load(object sender, EventArgs e)
        {
            //TODO: PopUp para cobrar una tasación del historial

            ConfigurarComponentes();
            RefrescarDGV();
            //Esto lo necesita Itextsharp para poder trabajar con el encoding que pide
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        }

        private void ConfigurarComponentes()
        {
            dgvTasaciones.MultiSelect = false;
            dgvTasaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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



        private void btnHistorial_Click(object sender, EventArgs e)
        {
            FormReimprimirFactura frmHistorialTasaciones = new FormReimprimirFactura();
            frmHistorialTasaciones.ShowDialog();
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if (dgvTasaciones.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una tasación para cobrar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                int idTasacion = Convert.ToInt32(dgvTasaciones.SelectedRows[0].Cells["ID"].Value);
                TasacionBE tasacionCobrar = bllTasacion.BuscarTasacion(idTasacion);

                if (tasacionCobrar == null)
                {
                    MessageBox.Show("No se ha encontrado la tasación en la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int metrosCuadrados = Int32.TryParse(Interaction.InputBox("Ingrese los metros cuadrados del inmueble:", "Metros cuadrados", "1"), out int outM2) ? outM2 : -1;
                int valorInmuebleTasado = Int32.TryParse(Interaction.InputBox("Ingrese el valor del inmueble tasado en dólares:", "Valor del inmueble tasado", "1"), out int outValor) ? outValor : -1;
                decimal valorDolarHoy = Decimal.TryParse(Interaction.InputBox("¿Valor del dolar en este momento? Es requerido para calcular el valor de la tasación en pesos", "Dolar hoy", "0"), out decimal outDolar) ? outDolar : -1;

                string detalles = Interaction.InputBox("Ingrese observaciones adicionales para la tasación cobrada:", "Observaciones de la tasación cobrada", "Sin observaciones adicionales") ?? "Sin observaciones";
                if (metrosCuadrados < 1)
                {
                    MessageBox.Show("Debe ingresar un valor numérico válido para los metros cuadrados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (valorInmuebleTasado < 1)
                {
                    MessageBox.Show("Debe ingresar un valor numérico válido para el valor del inmueble tasado .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (valorDolarHoy < 1)
                {
                    MessageBox.Show("Debe ingresar un valor numérico válido para el valor del dólar hoy.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //Actualizo la tasacion
                tasacionCobrar.m2 = metrosCuadrados;
                tasacionCobrar.ValorInmuebleTasado = valorInmuebleTasado;
                //Cobro la tasacion
                bllTasacion.Cobrar(tasacionCobrar, detalles);

                ClienteBE propietario = bllPropietario.BuscarCliente(tasacionCobrar.PropietarioID);
                FacturaTasacionBE facturaTasacion = new FacturaTasacionBE(propietario, tasacionCobrar, detalles, valorDolarHoy);
                bllFacturaTasacion.Alta(facturaTasacion);

                //CREACIÓN DE LA FACTURA FISICA
                ImprimirFactura(facturaTasacion);

                RefrescarDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        public void ImprimirFactura(FacturaTasacionBE facturaTasacion, string pReimpresa = "")
        {
            ClienteBE propietario = bllPropietario.BuscarCliente(facturaTasacion.PropietarioID);
            TasacionBE tasacionCobrar = bllTasacion.BuscarTasacion(facturaTasacion.TasacionAsociadaID);

            SaveFileDialog guardarDialog = new SaveFileDialog();
            guardarDialog.FileName = $"FACTURA tasacion N°[{facturaTasacion.ID}] - TASACION fecha {tasacionCobrar.FechaHora.ToString("dd-MM-yyyy")}" + $" {pReimpresa}" + ".pdf";

            //Reemplazar campos en la plantilla
            string plantillaHTML = Resources.FACTURA_TASACION.ToString();
            plantillaHTML = plantillaHTML.Replace("@PROPIETARIO", propietario.ToString());
            plantillaHTML = plantillaHTML.Replace("@DNI", propietario.DNI.ToString());
            plantillaHTML = plantillaHTML.Replace("@FECHA", tasacionCobrar.FechaHora.ToString("dd/MM/yyyy"));
            plantillaHTML = plantillaHTML.Replace("@LOCALIDAD", tasacionCobrar.Localidad);
            plantillaHTML = plantillaHTML.Replace("@DOMICILIO", tasacionCobrar.Domicilio);
            plantillaHTML = plantillaHTML.Replace("@TIPO", tasacionCobrar.TipoInmueble);
            plantillaHTML = plantillaHTML.Replace("@M2", tasacionCobrar.m2.ToString());
            plantillaHTML = plantillaHTML.Replace("@VALORINMUEBLETASADO", tasacionCobrar.ValorInmuebleTasado.ToString("C2", new System.Globalization.CultureInfo("es-AR")));
            plantillaHTML = plantillaHTML.Replace("@IMPORTE", facturaTasacion.Importe.ToString("C2", new System.Globalization.CultureInfo("es-AR")));
            plantillaHTML = plantillaHTML.Replace("@IVA", facturaTasacion.IVA.ToString("C2", new System.Globalization.CultureInfo("es-AR")));
            plantillaHTML = plantillaHTML.Replace("@TOTAL", facturaTasacion.Total.ToString("C2", new System.Globalization.CultureInfo("es-AR")));
            plantillaHTML = plantillaHTML.Replace("@IDFACTURA", facturaTasacion.ID.ToString().PadLeft(4, '0'));
            plantillaHTML = plantillaHTML.Replace("@DETALLES", facturaTasacion.Observaciones);


            if (guardarDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(guardarDialog.FileName, FileMode.Create))
                {
                    Document documentoPDF = new Document(PageSize.A4);

                    PdfWriter escritor = PdfWriter.GetInstance(documentoPDF, stream);
                    documentoPDF.Open();

                    iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(Resources.Logo_Costoya_Negro, System.Drawing.Imaging.ImageFormat.Png);
                    logo.ScaleToFit(90, 90);
                    logo.Alignment = iTextSharp.text.Image.UNDERLYING;
                    logo.SetAbsolutePosition(documentoPDF.LeftMargin + 10, documentoPDF.Top - 78);
                    documentoPDF.Add(logo);


                    using (StringReader lector = new StringReader(plantillaHTML))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(escritor, documentoPDF, lector);
                    }

                    documentoPDF.Close();
                    stream.Close();
                }
                Process.Start(new ProcessStartInfo
                {
                    FileName = guardarDialog.FileName,
                    UseShellExecute = true
                });

            }
        }

        private void rbCercana_CheckedChanged(object sender, EventArgs e)
        {
            RefrescarDGV(new TasacionFechaCercana());
        }

        private void rbLejana_CheckedChanged(object sender, EventArgs e)
        {
            RefrescarDGV(new TasacionFechaLejana());
        }
    }
}
