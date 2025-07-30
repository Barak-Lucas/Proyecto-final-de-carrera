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
    public partial class FormPropietariosBuscar : Form
    {
        ClienteBLL bllProp;
        public ClienteBE? propietarioSeleccionado { get; private set; }

        public FormPropietariosBuscar()
        {
            InitializeComponent();
            bllProp = new ClienteBLL();
        }


        private void RefrescarDGV()
        {

            try
            {
                dgvPropietarios.DataSource = null;
                dgvPropietarios.DataSource = bllProp.ConsultarPropietarios();
                dgvPropietarios.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FormPropietariosBuscar_Load(object sender, EventArgs e)
        {

            try
            {
                RefrescarDGV();
                dgvPropietarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvPropietarios.MultiSelect = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgvPropietarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvPropietarios.SelectedRows.Count > 0)
                {
                    int id = Convert.ToInt32(dgvPropietarios.SelectedRows[0].Cells["ID"].Value);
                    propietarioSeleccionado = bllProp.BuscarCliente(id);
                    this.Close();
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

        private void btnActualizarGrilla_Click(object sender, EventArgs e)
        {
            RefrescarDGV();
        }

        private void txtBuscarDNI_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtBuscarDNI.Text.Length > 0)
                {
                    string patron = txtBuscarDNI.Text.Trim();
                    Regex reDNI = new Regex(patron);

                    dgvPropietarios.DataSource = null;
                    var clientesFiltrados = bllProp.ConsultarPropietarios().Where(c => reDNI.IsMatch(c.DNI.ToString())).ToList();
                    dgvPropietarios.DataSource = clientesFiltrados;
                    dgvPropietarios.Refresh();
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
