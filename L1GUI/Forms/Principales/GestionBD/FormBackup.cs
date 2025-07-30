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
    public partial class FormBackup : Form
    {
        BitacoraBLL bllBitacora;
        UsuarioBE usuario;
        public FormBackup(UsuarioBE pUsuario)
        {
            this.usuario = pUsuario;
            bllBitacora = new BitacoraBLL();
            InitializeComponent();
        }

        private void btnRealizar_Click(object sender, EventArgs e)
        {

            try
            {
                bllBitacora.Backup(usuario);
                RefrescarDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void RefrescarDGV()
        {
            dgvBackup.DataSource = null;
            dgvBackup.DataSource = (from b in bllBitacora.ConsultarBitacora() where b.Detalle == "Backup"
                                    select new
                                    {
                                        b.ID,
                                        Culpable = $"[{b.Culpable.ID}]-" + b.Culpable.ToString(),
                                        Fecha = b.FechaRegistro,
                                        b.Detalle
                                    }).ToList();

            dgvBackup.Refresh();

        }

        private void FormBackup_Load(object sender, EventArgs e)
        {

            try
            {
                RefrescarDGV();
                dgvBackup.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvBackup.MultiSelect = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
