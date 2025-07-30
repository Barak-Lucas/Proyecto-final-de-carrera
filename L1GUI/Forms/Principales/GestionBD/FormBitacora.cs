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

namespace L1GUI.Forms.Principales
{
    public partial class FormBitacora : Form
    {
        UsuarioBE usuario;
        BitacoraBLL bllBitacora;
        List<UsuarioBE> usuarios;
        UsuarioBLL bllUsuario;
        List<BitacoraBE> entradasBitacora;
        public FormBitacora(UsuarioBE pUsuario)
        {

            try
            {
                this.usuario = pUsuario;
                this.bllBitacora = new BitacoraBLL();
                this.entradasBitacora = bllBitacora.ConsultarBitacora();
                bllUsuario = new UsuarioBLL();
                usuarios = bllUsuario.ConsultarUsuarios();
                InitializeComponent();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void FormBitacora_Load(object sender, EventArgs e)
        {

            try
            {
                dgvBitacora.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvBitacora.MultiSelect = false;
                RefrescarDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void RefrescarDGV()
        {
            dgvBitacora.DataSource = null;
            dgvBitacora.DataSource = (from b in entradasBitacora
                                      select new
                                      {
                                          b.ID,
                                          Culpable = $"[{b.Culpable.ID}]-" + b.Culpable.ToString(),
                                          Fecha = b.FechaRegistro,
                                          b.Detalle
                                      }).ToList();

            foreach (DataGridViewRow dgvRow in dgvBitacora.Rows)
            {
                if (dgvRow.Cells["Detalle"].Value.ToString() == "Backup")
                {
                    dgvRow.DefaultCellStyle.BackColor = Color.LightGreen;
                }
                else
                {
                    dgvRow.DefaultCellStyle.BackColor = Color.LightBlue;
                }
            }

            dgvBitacora.Refresh();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvBitacora_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (dgvBitacora.SelectedRows.Count > 0)
                {
                    string seleccion = (dgvBitacora.SelectedRows[0].Cells["Culpable"].Value.ToString().Replace('[', ' ').Replace(']', ' ')).Trim();
                    int indiceRecorte = seleccion.IndexOf('-');
                    string usuarioStringID = seleccion.Substring(0, indiceRecorte);
                    int id = Convert.ToInt32(usuarioStringID);
                    UsuarioBE usuarioSelect = usuarios.Find(u => u.ID == id);
                    lblID.Text = usuarioSelect == null ? usuarioStringID : usuarioSelect.ID.ToString();
                    lblUsuario.Text = usuarioSelect == null ? "Inf. perdida" : usuarioSelect.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbSoloBackups_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSoloBackups.Checked)
            {
                dgvBitacora.DataSource = null;
                dgvBitacora.DataSource = (from b in entradasBitacora
                                          where b.Detalle == "Backup"
                                          select new
                                          {
                                              b.ID,
                                              Culpable = $"[{b.Culpable.ID}]-" + b.Culpable.ToString(),
                                              Fecha = b.FechaRegistro,
                                              b.Detalle
                                          }).ToList();

                foreach (DataGridViewRow dgvRow in dgvBitacora.Rows)
                {
                    dgvRow.DefaultCellStyle.BackColor = Color.LightGreen;
                }

                dgvBitacora.Refresh();
            }
        }

        private void rbSoloRestore_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSoloRestore.Checked)
            {
                dgvBitacora.DataSource = null;
                dgvBitacora.DataSource = (from b in entradasBitacora
                                          where b.Detalle == "Restore"
                                          select new
                                          {
                                              b.ID,
                                              Culpable = $"[{b.Culpable.ID}]-" + b.Culpable.ToString(),
                                              Fecha = b.FechaRegistro,
                                              b.Detalle
                                          }).ToList();

                foreach (DataGridViewRow dgvRow in dgvBitacora.Rows)
                {
                    dgvRow.DefaultCellStyle.BackColor = Color.LightBlue;
                }

                dgvBitacora.Refresh();
            }
        }


    }
}
