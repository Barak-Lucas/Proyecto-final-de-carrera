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
    public partial class FormRestore : Form
    {
        BitacoraBLL bllBitacora;
        string backupSeleccionado;
        UsuarioBE usuario;
        public FormRestore(UsuarioBE pUsuario)
        {
            this.usuario = pUsuario;
            bllBitacora = new BitacoraBLL();
            InitializeComponent();
        }

        private void btnRealizar_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrEmpty(backupSeleccionado))
                {
                    MessageBox.Show("Debe seleccionar un backup", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                DialogResult result = MessageBox.Show($"Está a punto de recuperar los datos de la Base de Datos de la fecha y hora {backupSeleccionado.Substring(0, backupSeleccionado.Length - 4)}. {Environment.NewLine}" +
                                                  $"Todo dato perteneciente a una fecha posterior se perderá. {Environment.NewLine}" +
                                                  "¿Está completamente seguro?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.Cancel)
                {
                    MessageBox.Show("Restore cancelado", "Cancelación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    backupSeleccionado = string.Empty;
                    return;
                }


                bllBitacora.Restore(usuario, backupSeleccionado);
                MessageBox.Show($"¡Restore exitoso!","Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                
                backupSeleccionado = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void RefrescarTreeView()
        {
            tvBackups.Nodes.Clear();
            foreach (string backup in bllBitacora.ConsultarBackups())
            {
                tvBackups.Nodes.Add(new TreeNode(backup));
            }
        }

        private void FormRestore_Load(object sender, EventArgs e)
        {
            RefrescarTreeView();
        }

        private void tvBackups_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tvBackups.SelectedNode != null)
                backupSeleccionado = tvBackups.SelectedNode.Text;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
