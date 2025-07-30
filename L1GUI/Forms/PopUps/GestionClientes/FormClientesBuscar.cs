using L2BE;
using L3BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L1GUI.Forms
{
    public partial class FormClientesBuscar : Form
    {
        public ClienteBE clienteSeleccionado { get; private set; }
        ClienteBLL bllCliente;

        public FormClientesBuscar()
        {
            bllCliente = new ClienteBLL();
            InitializeComponent();
            ConfigurarComponentes();
        }

        private void ConfigurarComponentes()
        {

            try
            {
                dgvClientes.MultiSelect = false;
                dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
                dgvClientes.DataSource = null;
                dgvClientes.DataSource = bllCliente.ConsultarTodosLosClientes();
                dgvClientes.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FormClientesBuscar_Load(object sender, EventArgs e)
        {
            RefrescarDGV();
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (dgvClientes.SelectedRows.Count > 0)
                {
                    int idCliente = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells["ID"].Value);
                    this.clienteSeleccionado = bllCliente.BuscarCliente(idCliente);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnNuevoPropietario_Click(object sender, EventArgs e)
        {

            try
            {
                FormCarteraClientes frmCarteraClientes = new FormCarteraClientes(() => RefrescarDGV());
                frmCarteraClientes.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

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
    }
}
