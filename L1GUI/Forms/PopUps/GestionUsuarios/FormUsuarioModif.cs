using L2BE;
using L3BLL;
using ServicioDeEncriptado;
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

namespace L1GUI.Forms.PopUps
{
    public partial class FormUsuarioModif : Form
    {
        Action refrescarDGV;
        UsuarioBE usuarioModif;
        UsuarioBLL bllUsuario;
        public FormUsuarioModif(UsuarioBE pUsuario, Action pRefreshDGV)
        {
            InitializeComponent();
            this.usuarioModif = pUsuario;
            this.bllUsuario = new UsuarioBLL();
            this.refrescarDGV = pRefreshDGV;
        }

        private void FormUsuarioModif_Load(object sender, EventArgs e)
        {

            try
            {
                txtNombreUsuario.Text = usuarioModif.NombreUsuario;
                txtContraseña1.Text = Encriptador.Desencriptar(usuarioModif.Contraseña);
                txtContraseña2.Text = txtContraseña1.Text;
                lblModificando.Text += $"[{usuarioModif.ID}]";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al abrir form modif", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
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
                if (txtContraseña1.Text != txtContraseña2.Text)
                {
                    MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                string nombreUsuario = txtNombreUsuario.Text;
                string contraseña = txtContraseña1.Text;


                usuarioModif.NombreUsuario = txtNombreUsuario.Text;
                usuarioModif.Contraseña = txtContraseña1.Text;

                bllUsuario.Modificar(usuarioModif);

                MessageBox.Show("¡Usuario modificado!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("El email ingresado no es válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error capturado, verifique que los campos ingresados sean válidos. Mensaje de error: {Environment.NewLine} {ex.Message}", "Error al dar de alta al Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.refrescarDGV();
            }
        }




        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Eventos txtEnter



        private void txtNombreUsuario_Enter(object sender, EventArgs e)
        {
            txtNombreUsuario.Select(0, txtNombreUsuario.Text.Length);
        }

        private void txtContraseña1_Enter(object sender, EventArgs e)
        {
            txtContraseña1.Select(0, txtContraseña1.Text.Length);
        }

        private void txtContraseña2_Enter(object sender, EventArgs e)
        {
            txtContraseña2.Select(0, txtContraseña2.Text.Length);
        }


        #endregion
    }
}
