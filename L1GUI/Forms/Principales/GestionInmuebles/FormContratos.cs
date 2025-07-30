using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using L1GUI.Properties;
using L2BE;
using L3BLL;
using System.Data;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;
using cEstados = L2BE.ContratoBE.EstadoContrato;
using pEstados = L2BE.PropiedadBE.EstadosPropiedad;


namespace L1GUI.Forms
{
    public partial class FormContratos : Form
    {
        ClienteBE propietario;
        PropiedadBE propiedad;
        ContratoBLL bllContrato;
        ClienteBLL bllPropietario;
        PropiedadBLL bllPropiedad;
        Action refrescarDGV;
        public FormContratos(Action pRefrescarDGV = null)
        {
            InitializeComponent();
            bllContrato = new ContratoBLL();
            bllPropietario = new ClienteBLL();
            bllPropiedad = new PropiedadBLL();
            this.refrescarDGV = pRefrescarDGV;
        }

        private void FormContratos_Load(object sender, EventArgs e)
        {

            try
            {
                
                ConfigurarComponentes();

                RefrescarDVG();
                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance); //Esto es para el ITextSharp
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnCrearContrato_Click(object sender, EventArgs e)
        {
            try
            {

                if (cnPropiedad.Text.Length == 0 || cnPropietario.Text.Length == 0)
                {
                    MessageBox.Show("Debe seleccionar una propiedad y un propietario para crear un contrato", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                ContratoBE contratoActivo = bllContrato.BuscarContratoPropiedad(Convert.ToInt32(cnPropiedad.Text));

                if (contratoActivo != null && contratoActivo.Estado == cEstados.Vigente)
                {
                    MessageBox.Show("La propiedad ya tiene contratos vigentes activos. Renueve el contrato en su lugar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                int propiearioID = Convert.ToInt32(cnPropietario.Text);
                int propiedadID = Convert.ToInt32(cnPropiedad.Text);
                string nombreConyugue = txtNombreConyugue.Text;
                string dniConyugue = cnDNIconyugue.Text;
                DateTime fechaInicio = dtPicker.Value;
                decimal precioUSD = Convert.ToDecimal(cnPrecio.Text);

                ContratoBE contrato = new ContratoBE(propiearioID, propiedadID, nombreConyugue, dniConyugue, fechaInicio, precioUSD);
                int contratoID = bllContrato.Alta(contrato);
                contrato.ID = contratoID;

                //Asociar el contrato;
                propiedad.ContratoID = contratoID;

                CrearDocumento(contrato, propiedad, propietario);

                MessageBox.Show("¡Contrato creado!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult result = MessageBox.Show($"¿Desea cambiar el estado de la propiedad de {propiedad.Estado} a {pEstados.Disponible}?", "Estado de propiedad", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    propiedad.Estado = pEstados.Disponible;
                }

                //Actualizar el estado y asociar el contrato contrato
                bllPropiedad.Modificar(propiedad);
                RefrescarDVG();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnBuscarProp_Click(object sender, EventArgs e)
        {

            try
            {
                FormPropietariosBuscar frmPropietariosBuscar = new FormPropietariosBuscar();
                frmPropietariosBuscar.ShowDialog();

                propietario = frmPropietariosBuscar.propietarioSeleccionado;

                if (propietario == null) cnPropietario.Text = string.Empty;
                else
                {
                    cnPropietario.Text = propietario.ID.ToString();
                    txtNombre.Text = propietario.Nombre;
                    txtApellido.Text = propietario.Apellido;
                    cnDNI.Text = propietario.DNI.ToString();
                    txtDomicilio.Text = propietario.Domicilio;
                    txtEmail.Text = propietario.Email;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnBuscarPropiedad_Click(object sender, EventArgs e)
        {

            try
            {
                if (cnPropietario.Text.Length == 0)
                {
                    MessageBox.Show("Debe seleccionar un propietario antes de buscar una propiedad", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                FormPropiedadesBuscar frmPropiedadBuscar = new FormPropiedadesBuscar(Convert.ToInt32(cnPropietario.Text), this);
                frmPropiedadBuscar.ShowDialog();
                propiedad = frmPropiedadBuscar.propiedadSeleccionada;

                if (propiedad == null)
                {
                    cnPropiedad.Text = string.Empty;
                    txtDomicilioVenta.Text = string.Empty;
                    cnPrecio.Text = string.Empty;
                }
                else
                {
                    cnPropiedad.Text = propiedad.ID.ToString();
                    txtDomicilioVenta.Text = propiedad.Domicilio;
                    cnPrecio.Text = propiedad.PrecioUSD.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnContratosPropietario_Click(object sender, EventArgs e)
        {

            try
            {
                FormContratosPropietario frmContratosPropietario = new FormContratosPropietario();
                frmContratosPropietario.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnReimprimir_Click(object sender, EventArgs e)
        {

            try
            {
                string estado = dgvContratos.SelectedRows[0].Cells["Estado"].Value.ToString();
                if (estado == "Cancelado")
                {
                    MessageBox.Show("No se puede reimprimir un contrato cancelado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (estado == "Renovar")
                {
                    MessageBox.Show("¡El contrato está pendiente de renovación!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    ContratoBE contratoReimprimir = bllContrato.BuscarContrato(Convert.ToInt32(dgvContratos.SelectedRows[0].Cells["ID"].Value));
                    ClienteBE propietario = bllPropietario.BuscarCliente(contratoReimprimir.PropietarioID);
                    PropiedadBE propiedad = bllPropiedad.BuscarPropiedad(contratoReimprimir.PropiedadID);

                    CrearDocumento(contratoReimprimir, propiedad, propietario, "[Reimpreso]");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgvContratos.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar un contrato para cancelarlo", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                int contratoID = Convert.ToInt32(dgvContratos.SelectedRows[0].Cells["ID"].Value);
                int propiedadID = Convert.ToInt32(dgvContratos.SelectedRows[0].Cells["Propiedad"].Value);

                PropiedadBE propiedadModif = bllPropiedad.BuscarPropiedad(propiedadID);
                ContratoBE contratoCancelar = bllContrato.BuscarContrato(contratoID);

                if (contratoCancelar.Estado == cEstados.Cancelado)
                {
                    MessageBox.Show("El contrato ya se encuentra cancelado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DialogResult result = MessageBox.Show($"¿Está seguro que desea cancelar el contrato {contratoID}?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {

                    propiedadModif.ContratoID = 0;
                    propiedadModif.Estado = pEstados.Retirada;
                    bllContrato.ActualizarEstado(contratoID, cEstados.Cancelado);
                    bllPropiedad.Modificar(propiedadModif);
                    RefrescarDVG();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnBaja_Click(object sender, EventArgs e)
        {

            try
            {
                int contratoID = Convert.ToInt32(dgvContratos.SelectedRows[0].Cells["ID"].Value);
                string estado = dgvContratos.SelectedRows[0].Cells["Estado"].Value.ToString();
                if (estado == "Vigente")
                {
                    MessageBox.Show("El contrato aun se encuentra vigente. Cancélelo primero", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                DialogResult result = MessageBox.Show($"¿Está seguro que desea eliminar el contrato {contratoID}?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    bllContrato.Baja(contratoID);
                    RefrescarDVG();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnRenovar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvContratos.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar un contrato para renovarlo", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                string estado = dgvContratos.SelectedRows[0].Cells["Estado"].Value.ToString();
                int contratoID = Convert.ToInt32(dgvContratos.SelectedRows[0].Cells["ID"].Value);

                if (estado == "Cancelado")
                {
                    MessageBox.Show("No se puede renovar un contrato cancelado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {

                    if (estado == "Vigente")
                    {
                        DialogResult result = MessageBox.Show($"El contrato {dgvContratos.SelectedRows[0].Cells["ID"].Value} se encuentra VIGENTE. ¿Renovar de todos modos?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (result != DialogResult.OK) return;
                    }

                    ContratoBE contratoRenovar = bllContrato.BuscarContrato(Convert.ToInt32(contratoID));
                    ClienteBE propietario = bllPropietario.BuscarCliente(contratoRenovar.PropietarioID);
                    PropiedadBE propiedad = bllPropiedad.BuscarPropiedad(contratoRenovar.PropiedadID);

                    FormContratosRenovar frmContratoRenovar = new FormContratosRenovar(contratoRenovar, propietario, propiedad);
                    frmContratoRenovar.ShowDialog();

                    if (!FormContratosRenovar.confirmado)
                    {
                        MessageBox.Show("Renovación cancelada por el usuario", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    contratoRenovar = frmContratoRenovar.contrato;


                    bllContrato.Renovar(contratoRenovar);
                    RefrescarDVG();
                    CrearDocumento(contratoRenovar, propiedad, propietario, "[Renovado]");
                    MessageBox.Show("¡Contrato renovado!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",  MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pContrato"></param>
        /// <param name="pPropietario"></param>
        /// <param name="pPropiedad"></param>
        /// <param name="pTipoImpresion">"Reimpreso" - "Renovado" - o cualquier otro tipo</param>
        private void CrearDocumento(ContratoBE pContrato, PropiedadBE pPropiedad, ClienteBE pPropietario, string pTipoImpresion = "")
        {
            try
            {

                SaveFileDialog guardarDialog = new SaveFileDialog();


                string plantillaHTML = Resources.AUTORIZACION_VENTA.ToString();

                guardarDialog.FileName = $"CONTRATO N° [{pContrato.ID}] - PROPIEDAD ID [{pPropiedad.ID}]" + $" {pTipoImpresion}" + ".pdf";

                plantillaHTML = plantillaHTML.Replace("@NOMBRE", pPropietario.Nombre);
                plantillaHTML = plantillaHTML.Replace("@APELLIDO", pPropietario.Apellido);
                plantillaHTML = plantillaHTML.Replace("@DNI", pPropietario.DNI.ToString());
                plantillaHTML = plantillaHTML.Replace("@DOMICILIO", pPropietario.Domicilio);
                plantillaHTML = plantillaHTML.Replace("@DVENTA", pPropiedad.Domicilio);
                plantillaHTML = plantillaHTML.Replace("@PRECIO", pContrato.PrecioUSD.ToString());
                plantillaHTML = plantillaHTML.Replace("@NCONYUGUE", pContrato.NombreConyugue);
                plantillaHTML = plantillaHTML.Replace("@DCONYUGUE", pContrato.DNIConyugue);
                plantillaHTML = plantillaHTML.Replace("@EMAIL", pPropietario.Email);
                plantillaHTML = plantillaHTML.Replace("@DIA", pContrato.FechaInicio.Day.ToString());
                plantillaHTML = plantillaHTML.Replace("@MES", pContrato.FechaInicio.ToString("MMMM", new System.Globalization.CultureInfo("es-ES")));
                plantillaHTML = plantillaHTML.Replace("@AÑO", pContrato.FechaInicio.Year.ToString());


                if (guardarDialog.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(guardarDialog.FileName, FileMode.Create))
                    {
                        Document documentoPDF = new Document(PageSize.LEGAL);

                        PdfWriter escritor = PdfWriter.GetInstance(documentoPDF, stream);
                        documentoPDF.Open();

                        iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(Resources.Logo_Costoya_Negro, System.Drawing.Imaging.ImageFormat.Png);
                        logo.ScaleToFit(90, 90);
                        logo.Alignment = iTextSharp.text.Image.UNDERLYING;
                        logo.SetAbsolutePosition(documentoPDF.LeftMargin - 20, documentoPDF.Top - 78);
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

        private void ConfigurarComponentes()
        {

            try
            {
                dgvContratos.MultiSelect = false;
                dgvContratos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dtPicker.CustomFormat = "dd  MMM  yyyy";
                dtPicker.Format = DateTimePickerFormat.Custom;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void RefrescarDVG()
        {

            try
            {
                dgvContratos.DataSource = null;
                var listaTratada = (from c in bllContrato.ConsultarContratos()
                                    select new
                                    {
                                        c.ID,
                                        Propietario = $"{bllPropietario.BuscarCliente(c.PropietarioID).ToString()}",
                                        Propiedad = $"{c.PropiedadID}",
                                        Estado = c.Estado.ToString(),
                                        Desde = c.FechaInicio.ToString("dd/MMM/yyyy"),
                                        Hasta = c.FechaVencimiento.ToString("dd/MMM/yyyy"),
                                        Precio_venta = c.PrecioUSD.ToString("C2", new System.Globalization.CultureInfo("es-AR")),
                                    }).ToList();

                dgvContratos.DataSource = listaTratada;
                foreach (DataGridViewRow dgvRow in dgvContratos.Rows)
                {
                    if (dgvRow.Cells["Estado"].Value.ToString() == "Renovar")
                    {
                        dgvRow.DefaultCellStyle.BackColor = Color.LightPink;
                    }
                    else if (dgvRow.Cells["Estado"].Value.ToString() == "Cancelado")
                    {
                        dgvRow.DefaultCellStyle.BackColor = Color.Gray;
                    }
                    else if (dgvRow.Cells["Estado"].Value.ToString() == "Vigente")
                    {
                        dgvRow.DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                    else if (dgvRow.Cells["Estado"].Value.ToString() == "Finalizado")
                    {
                        dgvRow.DefaultCellStyle.BackColor = Color.LightBlue;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void FormContratos_FormClosed(object sender, FormClosedEventArgs e)
        {

            try
            {
                refrescarDGV?.Invoke();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            RefrescarDVG();
        }

        private void rbVigente_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                dgvContratos.DataSource = null;
                var listaTratada = (from c in bllContrato.ConsultarContratos()
                                    where c.Estado == cEstados.Vigente
                                    select new
                                    {
                                        c.ID,
                                        Propietario = $"{bllPropietario.BuscarCliente(c.PropietarioID).ToString()}",
                                        Propiedad = $"{c.PropiedadID}",
                                        Estado = c.Estado.ToString(),
                                        Desde = c.FechaInicio.ToString("dd/MMM/yyyy"),
                                        Hasta = c.FechaVencimiento.ToString("dd/MMM/yyyy"),
                                        Precio_venta = c.PrecioUSD.ToString("C2", new System.Globalization.CultureInfo("es-AR")),
                                    }).ToList();

                dgvContratos.DataSource = listaTratada;
                foreach (DataGridViewRow dgvRow in dgvContratos.Rows)
                {
                   dgvRow.DefaultCellStyle.BackColor = Color.LightGreen;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rbaRenovar_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                dgvContratos.DataSource = null;
                var listaTratada = (from c in bllContrato.ConsultarContratos()
                                    where c.Estado == cEstados.Renovar
                                    select new
                                    {
                                        c.ID,
                                        Propietario = $"{bllPropietario.BuscarCliente(c.PropietarioID).ToString()}",
                                        Propiedad = $"{c.PropiedadID}",
                                        Estado = c.Estado.ToString(),
                                        Desde = c.FechaInicio.ToString("dd/MMM/yyyy"),
                                        Hasta = c.FechaVencimiento.ToString("dd/MMM/yyyy"),
                                        Precio_venta = c.PrecioUSD.ToString("C2", new System.Globalization.CultureInfo("es-AR")),
                                    }).ToList();

                dgvContratos.DataSource = listaTratada;
                foreach (DataGridViewRow dgvRow in dgvContratos.Rows)
                {
                    dgvRow.DefaultCellStyle.BackColor = Color.LightPink;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rbCancelado_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
                dgvContratos.DataSource = null;
                var listaTratada = (from c in bllContrato.ConsultarContratos()
                                    where c.Estado == cEstados.Cancelado
                                    select new
                                    {
                                        c.ID,
                                        Propietario = $"{bllPropietario.BuscarCliente(c.PropietarioID).ToString()}",
                                        Propiedad = $"{c.PropiedadID}",
                                        Estado = c.Estado.ToString(),
                                        Desde = c.FechaInicio.ToString("dd/MMM/yyyy"),
                                        Hasta = c.FechaVencimiento.ToString("dd/MMM/yyyy"),
                                        Precio_venta = c.PrecioUSD.ToString("C2", new System.Globalization.CultureInfo("es-AR")),
                                    }).ToList();

                dgvContratos.DataSource = listaTratada;
                foreach (DataGridViewRow dgvRow in dgvContratos.Rows)
                {
                    dgvRow.DefaultCellStyle.BackColor = Color.Gray;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void txtBuscarID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtBuscarID.Text.Length > 0)
                {
                    string patron = txtBuscarID.Text.Trim();
                    Regex reID = new Regex(patron);

                    dgvContratos.DataSource = null;
                    var contratosFiltrados = (from c in bllContrato.ConsultarContratos()
                                              where reID.IsMatch(c.PropiedadID.ToString())
                                              select new
                                              {
                                                  c.ID,
                                                  Propietario = $"{bllPropietario.BuscarCliente(c.PropietarioID).ToString()}",
                                                  Propiedad = $"{c.PropiedadID}",
                                                  Estado = c.Estado.ToString(),
                                                  Desde = c.FechaInicio.ToString("dd/MMM/yyyy"),
                                                  Hasta = c.FechaVencimiento.ToString("dd/MMM/yyyy"),
                                                  Precio_venta = c.PrecioUSD.ToString("C2", new System.Globalization.CultureInfo("es-AR")),

                                              }).ToList();

                    dgvContratos.DataSource = contratosFiltrados;
                    foreach (DataGridViewRow dgvRow in dgvContratos.Rows)
                    {
                        if (dgvRow.Cells["Estado"].Value.ToString() == "Renovar")
                        {
                            dgvRow.DefaultCellStyle.BackColor = Color.LightPink;
                        }
                        else if (dgvRow.Cells["Estado"].Value.ToString() == "Cancelado")
                        {
                            dgvRow.DefaultCellStyle.BackColor = Color.Gray;
                        }
                        else if (dgvRow.Cells["Estado"].Value.ToString() == "Vigente")
                        {
                            dgvRow.DefaultCellStyle.BackColor = Color.LightGreen;
                        }
                    }
                    dgvContratos.Refresh();
                }
                else
                {
                    RefrescarDVG();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
