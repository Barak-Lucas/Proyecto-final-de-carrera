using L1GUI.Forms.Principales;
using L2BE;
using L3BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L1GUI.Forms
{
    public partial class FormCarteraClientes : Form
    {
        ClienteBLL bllCliente;
        PropiedadBLL bllPropiedad;
        VisitaBLL bllVisita;
        VentaBLL bllVenta;
        Action refrescarDGVhijo;

        public FormCarteraClientes(Action pRefrescarDGVhijo = null)
        {
            InitializeComponent();
            bllPropiedad = new PropiedadBLL();
            bllCliente = new ClienteBLL();
            this.refrescarDGVhijo = pRefrescarDGVhijo;
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtApellido.Text.Length == 0 && cnDNI.Text.Length == 0)
                {
                    MessageBox.Show("¡Se requiere como mínimo un apellido y un DNI!", "Información requerida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (cnDNI.Text.Length < 6)
                {
                    MessageBox.Show("¡Longitud del DNI inválida!", "DNI inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }


                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                int dni = Convert.ToInt32(cnDNI.Text);
                string telefono = txtTelefono.Text;
                new MailAddress(txtEmail.Text); string email = txtEmail.Text;
                string domicilio = txtDomicilio.Text;
                bool propietario = cbPropietario.Checked;

                ClienteBE cliente = new ClienteBE(apellido, nombre, dni, telefono, email, domicilio, propietario);
                if (bllCliente.Alta(cliente))
                {
                    MessageBox.Show("Se ha encontrado a un cliente con el mismo DNI proporcionado. Se a reactivado al cliente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                RefrescarDGV();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error en el FORMATO del email. \r" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Verifique el campo EMAIL", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verifique los campos ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void FormCarteraClientes_Load(object sender, EventArgs e)
        {
            RefrescarDGV();
            ConfigurarComponentes();

        }

        private void ConfigurarComponentes()
        {

            try
            {
                cnDNI.MaxLength = 8;
                dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvClientes.MultiSelect = false;
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
                RefrescarListas();
                dgvClientes.DataSource = null;
                dgvClientes.DataSource = bllCliente.ConsultarTodosLosClientes();
                dgvClientes.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void RefrescarListas()
        {
            lblClientesCartera.Text = bllCliente.ConsultarTodosLosClientes().Count().ToString();
        }

        private void btnModif_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgvClientes.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Por favor, seleccione en la grilla al Cliente al que desea modificar");
                    return;
                }
                if (txtApellido.Text.Length == 0 && cnDNI.Text.Length == 0)
                {
                    MessageBox.Show("¡Se requiere como mínimo un apellido y un DNI!", "Información requerida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (cnDNI.Text.Length < 6)
                {
                    MessageBox.Show("¡Longitud del DNI inválida!", "DNI inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                //Nueva data
                int id = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells["ID"].Value);
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                int dni = Convert.ToInt32(cnDNI.Text);
                string telefono = txtTelefono.Text;
                new MailAddress(txtEmail.Text); string email = txtEmail.Text;
                string domicilio = txtDomicilio.Text;
                bool propietario = cbPropietario.Checked;

                //Vieja data
                string viejoDNI = dgvClientes.SelectedRows[0].Cells["DNI"].Value.ToString();
                string viejoNombre = dgvClientes.SelectedRows[0].Cells["Nombre"].Value.ToString();
                string viejoApellido = dgvClientes.SelectedRows[0].Cells["Apellido"].Value.ToString();
                string viejoTelef = dgvClientes.SelectedRows[0].Cells["Telefono"].Value.ToString();
                string viejoMail = dgvClientes.SelectedRows[0].Cells["Email"].Value.ToString();
                string viejoDomicilio = dgvClientes.SelectedRows[0].Cells["Domicilio"].Value.ToString();


                DialogResult result = MessageBox.Show($"Confirme los cambios al cliente: {Environment.NewLine}" +
                                                        $"Nombre: {viejoNombre} ------> {nombre} {Environment.NewLine}" +
                                                        $"Apellido: {viejoApellido} ------> {apellido} {Environment.NewLine}" +
                                                        $"DNI: {viejoDNI} ------> {dni} {Environment.NewLine}" +
                                                        $"Teléfono: {viejoTelef} ------> {telefono} {Environment.NewLine}" +
                                                        $"Email: {viejoMail} ------> {email} {Environment.NewLine}" +
                                                        $"Domicilio: {viejoDomicilio} ------> {domicilio} {Environment.NewLine}", "Confirmación"
                                                        , MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result != DialogResult.OK) { MessageBox.Show("Modificación cancelada", "Cacelado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); return; }

                ClienteBE cliente = new ClienteBE()
                {
                    ID = id,
                    Apellido = apellido,
                    Nombre = nombre,
                    DNI = dni,
                    Domicilio = domicilio,
                    Email = email,
                    Telefono = telefono,
                    Propietario = propietario,
                    Activo = true

                };


                bllCliente.Modificar(cliente);

                RefrescarDGV();
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"El email ingresado no es válido {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvClientes.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Por favor, seleccione en la grilla al Cliente al que desea eliminar");
                    return;
                }
                //obtener el id para preguntar si tiene propiedades activas
                int id = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells["ID"].Value);

                if (bllPropiedad.ConsultarPropiedadesPropietario(id).Any(p => p.Activa))
                {
                    MessageBox.Show("El cliente seleccionado tiene propiedades activas. No se puede eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                string nombre = dgvClientes.SelectedRows[0].Cells["Nombre"].Value.ToString();
                string apellido = dgvClientes.SelectedRows[0].Cells["Apellido"].Value.ToString();


                DialogResult result = MessageBox.Show($"¿Confirma la baja del cliente {nombre}, {apellido}?", "Confirmación de baja", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result != DialogResult.OK) return;

                bllCliente.Baja(Convert.ToInt32(id));
                RefrescarDGV();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error al eliminar al cliente. {Environment.NewLine} Mensaje de error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void FormCarteraClientes_FormClosed(object sender, FormClosedEventArgs e)
        {

            try
            {
                refrescarDGVhijo?.Invoke();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //private void btnVisitas_Click(object sender, EventArgs e)
        //{

        //    try
        //    {
        //        if (dgvClientes.SelectedRows.Count > 0)
        //        {
        //            int clienteID = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells["ID"].Value);
        //            lblVisitasComprasVentas.Text = "Visitas del cliente";
        //            dgvVisitasComprasVentas.DataSource = bllCliente.VisitasDelCliente(clienteID);
        //            dgvVisitasComprasVentas.Refresh();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Por favor, seleccione un cliente de la grilla para ver sus visitas.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}


        private void txtBuscarDNI_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtBuscarDNI.Text.Length > 0)
                {
                    string patron = txtBuscarDNI.Text.Trim();
                    Regex reDNI = new Regex(patron);

                    dgvClientes.DataSource = null;
                    var clientesFiltrados = bllCliente.ConsultarTodosLosClientes().Where(c => reDNI.IsMatch(c.DNI.ToString())).ToList();
                    dgvClientes.DataSource = clientesFiltrados;
                    dgvClientes.Refresh();
                }
                else
                {
                    RefrescarDGV();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    dgvClientes.DataSource = null;
                    var clientesFiltrados = bllCliente.ConsultarTodosLosClientes().Where(c => reID.IsMatch(c.ID.ToString())).ToList();
                    dgvClientes.DataSource = clientesFiltrados;
                    dgvClientes.Refresh();
                }
                else
                {
                    RefrescarDGV();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbNoProp_CheckedChanged(object sender, EventArgs e)
        {
            dgvClientes.DataSource = null;
            var listaTratada = (from c in bllCliente.ConsultarTodosLosClientes() where c.Propietario == false select c).ToList();
            dgvClientes.DataSource = listaTratada;
            dgvClientes.Refresh();
        }

        private void rbPropietarios_CheckedChanged(object sender, EventArgs e)
        {
            dgvClientes.DataSource = null;
            var listaTratada = (from c in bllCliente.ConsultarTodosLosClientes() where c.Propietario == true select c).ToList();
            dgvClientes.DataSource = listaTratada;
            dgvClientes.Refresh();
        }

        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            RefrescarDGV();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            RefrescarDGV();
        }

        //private void btnCompras_Click(object sender, EventArgs e)
        //{
        //    if (dgvClientes.SelectedRows.Count > 0)
        //    {
        //        int clienteID = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells["ID"].Value);
        //        lblVisitasComprasVentas.Text = "Compras del cliente";
        //        var listaTratada = (from v in bllCliente.ComprasDelCliente(clienteID)
        //                            select new
        //                            {
        //                                v.ID,
        //                                Propiedad = v.PropiedadVendidaID,
        //                                Precio = v.PrecioConvenido.ToString("C2", new System.Globalization.CultureInfo("es-AR")),
        //                                Vendedor = bllCliente.BuscarCliente(v.VendedorID),
        //                                v.FechaVenta,
        //                            }).ToArray();

        //        dgvVisitasComprasVentas.DataSource = listaTratada;
        //        dgvVisitasComprasVentas.Columns["Precio"].HeaderText = "Precio convenido";
        //        dgvVisitasComprasVentas.Columns["FechaVenta"].HeaderText = "Fecha de venta";

        //        dgvVisitasComprasVentas.DataSource = listaTratada;
        //        dgvVisitasComprasVentas.Refresh();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Por favor, seleccione un cliente de la grilla para ver sus visitas.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}

        //private void btnVentas_Click(object sender, EventArgs e)
        //{
        //    if (dgvClientes.SelectedRows.Count > 0)
        //    {
        //        int clienteID = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells["ID"].Value);
        //        lblVisitasComprasVentas.Text = "Compras del cliente";
        //        var listaTratada = (from v in bllCliente.VentasDelCliente(clienteID)
        //                            select new
        //                            {
        //                                v.ID,
        //                                Propiedad = v.PropiedadVendidaID,
        //                                Precio = v.PrecioConvenido.ToString("C2", new System.Globalization.CultureInfo("es-AR")),
        //                                Comprador = bllCliente.BuscarCliente(v.CompradorID),
        //                                v.FechaVenta,
        //                            }).ToArray();

        //        dgvVisitasComprasVentas.DataSource = listaTratada;
        //        dgvVisitasComprasVentas.Columns["Precio"].HeaderText = "Precio convenido";
        //        dgvVisitasComprasVentas.Columns["FechaVenta"].HeaderText = "Fecha de venta";

        //        dgvVisitasComprasVentas.DataSource = listaTratada;
        //        dgvVisitasComprasVentas.Refresh();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Por favor, seleccione un cliente de la grilla para ver sus visitas.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}
    }
}
