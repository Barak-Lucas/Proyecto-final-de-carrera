using ControlesDeUsuario;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using L1GUI.Forms.PopUps;
using L1GUI.Properties;
using L2BE;
using L3BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L1GUI.Forms
{
    public partial class FormRegistrarVenta : Form
    {
        PropiedadBE propiedadVendida;

        PropiedadBLL bllPropiedad;
        ContratoBLL bllContrato;
        ClienteBLL bllCliente;
        ClienteBE comprador;
        ClienteBE vendedor;
        VentaBE nuevaVenta;
        VentaBLL bllVenta;
        FacturaVentaBLL bllFactura;
        //VentaBLL bllVenta;
        public FormRegistrarVenta()
        {
            InitializeComponent();
            bllPropiedad = new PropiedadBLL();
            bllCliente = new ClienteBLL();
            bllVenta = new VentaBLL();
            bllFactura = new FacturaVentaBLL();
            bllContrato = new ContratoBLL();
        }

        private void FormRegistrarVenta_Load(object sender, EventArgs e)
        {

            try
            {
                ConfigurarComponentes();
                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance); //Esto es para el ITextSharp
                RefrescarDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CajaNumericaPrecio_TextChanged(object sender, EventArgs e)
        {

            try
            {
                decimal precioOut = 0;
                if (Decimal.TryParse(cnPrecio.Text, out precioOut))
                {
                    txtComisionComp.Text = (precioOut * 0.03m).ToString("C2", new System.Globalization.CultureInfo("es-AR"));
                    txtComisionVend.Text = (precioOut * 0.01m).ToString("C2", new System.Globalization.CultureInfo("es-AR"));
                }
                else { txtComisionComp.Text = string.Empty; txtComisionVend.Text = string.Empty; }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnBuscarProp_Click(object sender, EventArgs e)
        {

            try
            {
                FormPropiedadesBuscar frmPropiedadesBuscar = new FormPropiedadesBuscar();
                frmPropiedadesBuscar.ShowDialog();

                propiedadVendida = frmPropiedadesBuscar.propiedadSeleccionada;
                if (propiedadVendida != null)
                {
                    cnPropiedadID.Text = propiedadVendida.ID.ToString();
                    txtDomicilio.Text = propiedadVendida.Domicilio;
                    txtLocalidad.Text = propiedadVendida.Localidad;
                    txtPropietario.Text = bllCliente.BuscarCliente(propiedadVendida.PropietarioID).ToString();
                    cnPrecio.Text = propiedadVendida.PrecioUSD.ToString();
                }
                else
                {
                    cnPropiedadID.Text = string.Empty;
                    txtDomicilio.Text = string.Empty;
                    txtLocalidad.Text = string.Empty;
                    txtPropietario.Text = string.Empty;
                    cnPrecio.Text = string.Empty;
                }
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
                FormClientesBuscar frmClientesBuscar = new FormClientesBuscar();
                frmClientesBuscar.ShowDialog();
                comprador = frmClientesBuscar.clienteSeleccionado;
                if (comprador != null)
                {
                    cnCompradorID.Text = comprador.ID.ToString();
                    txtDNI.Text = comprador.DNI.ToString();
                    txtNombre.Text = comprador.ToString();
                }
                else
                {
                    cnCompradorID.Text = string.Empty;
                    txtDNI.Text = string.Empty;
                    txtNombre.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {

            try
            {
                if (cnCompradorID.Text.Length == 0)
                {
                    MessageBox.Show("Debe seleccionar un comprador antes de registrar una venta", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
                if (cnPropiedadID.Text.Length == 0)
                {
                    MessageBox.Show("Debe seleccionar una propiedad antes de registrar una venta", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
                if (cnPrecio.Text.Length == 0 || Convert.ToInt32(cnPrecio.Text) < 1)
                {
                    MessageBox.Show("Ingrese un precio convenido en dólares válido", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
                if (Convert.ToInt32(cnCompradorID.Text) == propiedadVendida.PropietarioID)
                {
                    MessageBox.Show("El comprador no puede ser el dueño de la propiedad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }

                //Instanciar la venta
                DateTime FechaVenta = dtPicker.Value.Date;
                decimal PrecioConvenido = Convert.ToDecimal(cnPrecio.Text);
                comprador = bllCliente.BuscarCliente(Convert.ToInt32(cnCompradorID.Text));
                propiedadVendida = bllPropiedad.BuscarPropiedad(Convert.ToInt32(cnPropiedadID.Text));
                vendedor = bllCliente.BuscarCliente(propiedadVendida.PropietarioID);

                nuevaVenta = new VentaBE(vendedor, comprador, propiedadVendida, FechaVenta, PrecioConvenido);


                bllVenta.Alta(nuevaVenta);

                //Finalizar el contrato
                ContratoBE contrato = bllContrato.BuscarContratoPropiedad(propiedadVendida.ID);
                bllContrato.ActualizarEstado(contrato.ID, ContratoBE.EstadoContrato.Finalizado);

                bllPropiedad.Vender(propiedadVendida);

                string detalles = $"Honorarios por servicio de intermediación de venta del inmueble situado en {propiedadVendida.Domicilio}, {propiedadVendida.Localidad}. Identificador único de la propiedad: [{propiedadVendida.ID}]";

                FacturaVentaBE facturaVenta = new FacturaVentaBE(nuevaVenta, detalles);

                int idFactura = bllFactura.Alta(facturaVenta);
                facturaVenta.ID = idFactura;
                ImprimirFactura(facturaVenta, 'c');
                ImprimirFactura(facturaVenta, 'v');

                RefrescarDGV();

                LimpiarTextBoxes();

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
                dgvHistorialVentas.DataSource = null;
                var listaTratada = (from v in bllVenta.ConsultarVentas()
                                    select new
                                    {
                                        v.ID,
                                        Propiedad = v.PropiedadVendidaID,
                                        Precio = v.PrecioConvenido.ToString("C2", new System.Globalization.CultureInfo("es-AR")),
                                        Vendedor = v.VendedorID,
                                        Comprador = v.CompradorID,
                                        v.FechaVenta,
                                    }).ToArray();
                dgvHistorialVentas.DataSource = listaTratada;
                dgvHistorialVentas.Columns["Precio"].HeaderText = "Precio convenido";
                dgvHistorialVentas.Columns["FechaVenta"].HeaderText = "Fecha de venta";
                dgvHistorialVentas.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void LimpiarTextBoxes()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox txt)
                    txt.Text = string.Empty;
                else if (c is CajaNumerica cn)
                    cn.Text = string.Empty;
            }

        }

        private void ConfigurarComponentes()
        {
            dgvHistorialVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistorialVentas.MultiSelect = false;
            dtPicker.Format = DateTimePickerFormat.Custom;
            dtPicker.CustomFormat = "dd   MMM   yyyy";
        }

        /// <summary>
        /// Imprime la factura de venta para comprador o vendedor dependiendo del parámetro pCompradorVendedor.
        /// </summary>
        /// <param name="pFacturaVenta"></param>
        /// <param name="pCompradorVendedor">'c' para comprador y 'v' para vendedor</param>
        /// <param name="pReimpresa"></param>
        private void ImprimirFactura(FacturaVentaBE pFacturaVenta, char pCompradorVendedor, string pReimpresa = "")
        {

            try
            {
                if (pCompradorVendedor.ToString().ToLower() != "c" && pCompradorVendedor.ToString().ToLower() != "v") throw new ArgumentException("El parámetro pCompradorVendedor debe ser 'c' para comprador o 'v' para vendedor.");

                ClienteBE comprador = bllCliente.BuscarCliente(pFacturaVenta.CompradorID);
                ClienteBE vendedor = bllCliente.BuscarCliente(pFacturaVenta.VendedorID);
                VentaBE venta = bllVenta.BuscarVenta(pFacturaVenta.VentaAsociadaID);


                SaveFileDialog guardarDialog = new SaveFileDialog();


                string plantillaHTML = Resources.FACTURA_VENTA.ToString();

                if (pCompradorVendedor == 'c')
                {
                    guardarDialog.FileName = $"Factura al comprador - VENTA N°[{pFacturaVenta.ID}] - VENTA fecha {venta.FechaVenta.ToString("dd-MM-yyyy")}" + $" {pReimpresa}" + ".pdf";

                    plantillaHTML = plantillaHTML.Replace("@COMPRADORVENDEDOR", "COMPRADOR");
                    plantillaHTML = plantillaHTML.Replace("@NOMBRE", comprador.ToString());
                    plantillaHTML = plantillaHTML.Replace("@DOMICILIO", comprador.Domicilio);
                    plantillaHTML = plantillaHTML.Replace("@DNI", comprador.DNI.ToString());
                    plantillaHTML = plantillaHTML.Replace("@FECHA", pFacturaVenta.Fecha.ToString("dd/MM/yyyy"));
                    plantillaHTML = plantillaHTML.Replace("@DETALLES", pFacturaVenta.Detalles);
                    plantillaHTML = plantillaHTML.Replace("@VALORINMUEBLEVENDIDO", venta.PrecioConvenido.ToString("C2", new System.Globalization.CultureInfo("es-AR")));
                    plantillaHTML = plantillaHTML.Replace("@IMPORTE", pFacturaVenta.ImporteComprador.ToString("C2", new System.Globalization.CultureInfo("es-AR")));
                    plantillaHTML = plantillaHTML.Replace("@IVA", pFacturaVenta.IvaComprador.ToString("C2", new System.Globalization.CultureInfo("es-AR")));
                    plantillaHTML = plantillaHTML.Replace("@TOTAL", pFacturaVenta.TotalComprador.ToString("C2", new System.Globalization.CultureInfo("es-AR")));
                    plantillaHTML = plantillaHTML.Replace("@IDFACTURA", pFacturaVenta.ID.ToString().PadLeft(4, '0'));
                }
                else
                {
                    guardarDialog.FileName = $"Factura al vendedor - VENTA N°[{pFacturaVenta.ID}] - VENTA fecha {venta.FechaVenta.ToString("dd-MM-yyyy")}" + $" {pReimpresa}" + ".pdf";

                    plantillaHTML = plantillaHTML.Replace("@COMPRADORVENDEDOR", "VENDEDOR");
                    plantillaHTML = plantillaHTML.Replace("@NOMBRE", vendedor.ToString());
                    plantillaHTML = plantillaHTML.Replace("@DOMICILIO", vendedor.Domicilio);
                    plantillaHTML = plantillaHTML.Replace("@DNI", vendedor.DNI.ToString());
                    plantillaHTML = plantillaHTML.Replace("@FECHA", pFacturaVenta.Fecha.ToString("dd/MM/yyyy"));
                    plantillaHTML = plantillaHTML.Replace("@DETALLES", pFacturaVenta.Detalles);
                    plantillaHTML = plantillaHTML.Replace("@VALORINMUEBLEVENDIDO", venta.PrecioConvenido.ToString("C2", new System.Globalization.CultureInfo("es-AR")));
                    plantillaHTML = plantillaHTML.Replace("@IMPORTE", pFacturaVenta.ImporteVendedor.ToString("C2", new System.Globalization.CultureInfo("es-AR")));
                    plantillaHTML = plantillaHTML.Replace("@IVA", pFacturaVenta.IvaVendedor.ToString("C2", new System.Globalization.CultureInfo("es-AR")));
                    plantillaHTML = plantillaHTML.Replace("@TOTAL", pFacturaVenta.TotalVendedor.ToString("C2", new System.Globalization.CultureInfo("es-AR")));
                    plantillaHTML = plantillaHTML.Replace("@IDFACTURA", pFacturaVenta.ID.ToString().PadLeft(4, '0'));
                }



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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnReimprimir_Click(object sender, EventArgs e)
        {

            try
            {
                if(dgvHistorialVentas.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar una venta para reimprimir las facturas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int idVenta = Convert.ToInt32(dgvHistorialVentas.SelectedRows[0].Cells["ID"].Value);

                VentaBE venta = bllVenta.BuscarVenta(idVenta);
                FacturaVentaBE factura = bllVenta.FacturaAsociada(venta);
                ClienteBE comprador = bllCliente.BuscarCliente(factura.CompradorID);
                ClienteBE vendedor = bllCliente.BuscarCliente(factura.VendedorID);

                ImprimirFactura(factura, 'c', "Reimpresa");
                ImprimirFactura(factura, 'v', "Reimpresa");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
