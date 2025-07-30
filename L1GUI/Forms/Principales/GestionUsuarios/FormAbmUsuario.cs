using L1GUI.Forms.PopUps;
using L2BE;
using L3BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L1GUI.Forms.Principales
{
    public partial class FormAbmUsuario : Form
    {
        RolBLL bllRol;
        UsuarioBLL bllUsuario;
        UsuarioBE usuarioLogeado;

        public FormAbmUsuario(UsuarioBE pUsuario)
        {
            InitializeComponent();
            bllRol = new RolBLL();
            bllUsuario = new UsuarioBLL();
            usuarioLogeado = pUsuario;
        }

        private void FormAbmUsuario_Load(object sender, EventArgs e)
        {

            try
            {
                ConfigurarComponentes();
                RefrescarDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnAlta_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtNombreUsuario.Text.Length < 4)
                {
                    MessageBox.Show("Longitud del nombre de usuario debe ser al menos 4 caracteres", "Campos obligatorios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (txtContraseña1.Text.Length < 4)
                {
                    MessageBox.Show("Ingrese al menos 4 caracteres como contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if(txtContraseña1.Text != txtContraseña2.Text)
                {
                    MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (cmbRol.Items.Count == 0)
                {
                    DialogResult result = MessageBox.Show("Dará de alta a un Usuario sin un rol inicial. Recuerde que puede asignarle un rol más tarde \r " +
                                                          "¿Continuar?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.Cancel) return;
                }

                #region captura de datos

                string nombreUsuario = txtNombreUsuario.Text;
                string contraseña = txtContraseña1.Text;

                PermisoCompuestoBE rolInicial = (PermisoCompuestoBE)cmbRol.SelectedValue;
                #endregion

                UsuarioBE usuario = new UsuarioBE(nombreUsuario, contraseña, rolInicial);
                bllUsuario.Alta(usuario);
                RefrescarDGV();

            }
            catch (FormatException)
            {
                MessageBox.Show("El email ingresado no es válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error capturado, verifique que los campos ingresados sean válidos. Mensaje de error: {Environment.NewLine} {ex.Message}", "Error al dar de alta al Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void ConfigurarComponentes()
        {

            try
            {
                txtContraseña1.MaxLength = 20;
                txtContraseña2.MaxLength = 20;
                txtNombreUsuario.MaxLength = 20;
                cmbRol.DataSource = bllRol.ConsultarRoles();
                dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvUsuarios.MultiSelect = false;
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
                dgvUsuarios.DataSource = null;
                dgvUsuarios.DataSource = bllUsuario.ConsultarUsuarios();
                foreach (DataGridViewRow row in dgvUsuarios.Rows)
                {
                    if (!(bool)row.Cells["Activo"].Value)
                    {
                        row.DefaultCellStyle.BackColor = Color.DarkGray;
                    }
                    else if ((bool)row.Cells["Bloqueado"].Value)
                    {
                        row.DefaultCellStyle.BackColor = Color.LightSalmon;
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.LightBlue;
                    }
                }
                dgvUsuarios.Refresh();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }

        }

        private void btnBloquear_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgvUsuarios.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar un usuario", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (Convert.ToBoolean(dgvUsuarios.SelectedRows[0].Cells["Bloqueado"].Value))
                {
                    MessageBox.Show("El usuario ya se encuentra bloqueado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (Convert.ToInt32(dgvUsuarios.SelectedRows[0].Cells["ID"].Value) == 0)
                {
                    MessageBox.Show("No se puede bloquear al usuario ADMIN", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int id = Convert.ToInt32(dgvUsuarios.SelectedRows[0].Cells["ID"].Value);
                bllUsuario.BloquearDesbloquear(bllUsuario.BuscarUsuario(id));
                RefrescarDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDesbloquear_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvUsuarios.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar un usuario", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (!Convert.ToBoolean(dgvUsuarios.SelectedRows[0].Cells["Bloqueado"].Value))
                {
                    MessageBox.Show("El usuario ya se encuentra desbloqueado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                int id = Convert.ToInt32(dgvUsuarios.SelectedRows[0].Cells["ID"].Value);
                bllUsuario.BloquearDesbloquear(bllUsuario.BuscarUsuario(id));
                RefrescarDGV();
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
                if (dgvUsuarios.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar un usuario", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (Convert.ToInt32(dgvUsuarios.SelectedRows[0].Cells["ID"].Value) == 0)
                {
                    MessageBox.Show("No se puede dar de baja al usuario ADMIN", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (Convert.ToInt32(dgvUsuarios.SelectedRows[0].Cells["ID"].Value) == usuarioLogeado.ID)
                {
                    MessageBox.Show("No se puede puede eliminar al mismo usuario que está usando el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int id = Convert.ToInt32(dgvUsuarios.SelectedRows[0].Cells["ID"].Value);

                bllUsuario.Baja(id);
                RefrescarDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvUsuarios.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar un usuario", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (Convert.ToInt32(dgvUsuarios.SelectedRows[0].Cells["ID"].Value) == 0)
                {
                    MessageBox.Show("No se puede modificar al usuario ADMIN", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int id = Convert.ToInt32(dgvUsuarios.SelectedRows[0].Cells["ID"].Value);
                FormUsuarioModif frmUsuarioModif = new FormUsuarioModif(bllUsuario.BuscarUsuario(id), () => RefrescarDGV());
                frmUsuarioModif.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReactivar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvUsuarios.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar un usuario", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (Convert.ToBoolean(dgvUsuarios.SelectedRows[0].Cells["Activo"].Value))
                {
                    MessageBox.Show("El usuario se encuentra activo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int id = Convert.ToInt32(dgvUsuarios.SelectedRows[0].Cells["ID"].Value);

                bllUsuario.Reactivar(id);
                RefrescarDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
