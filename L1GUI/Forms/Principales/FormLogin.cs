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

namespace L1GUI.Forms
{
    public partial class FormLogin : Form
    {
        UsuarioBLL bllUsuario;
        UsuarioBE usuarioLogin;
        string contraseñaIngresada;

        public FormLogin()
        {
            bllUsuario = new UsuarioBLL();
            InitializeComponent();
            ConfigurarComponentes();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtContraseña.Text))
                {
                    MessageBox.Show("Complete los campos necesarios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return; ;
                }

                string usuario = txtUsuario.Text;
                usuarioLogin = bllUsuario.BuscarUsuario(usuario);

                if (usuarioLogin == null)
                {
                    MessageBox.Show("No existe ningún usuario con el nombre de usuario proporcionado", "Usuario inexistente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (usuarioLogin.Bloqueado)
                {
                    MessageBox.Show("El usuario se encuentra bloqueado", "Usuario bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                if (!usuarioLogin.Activo)
                {
                    MessageBox.Show("El usuario se encuentra dado de baja", "Usuario dado de baja", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                if (!bllUsuario.Login(usuarioLogin, txtContraseña.Text))
                {
                    MessageBox.Show("Credenciales incorrectas", "Fallo al loguear", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                this.Visible = false; //Lo oculto cuando se abre el form principal

                FormPrincipal formPrincipal = new FormPrincipal(usuarioLogin);
                formPrincipal.ShowDialog();

                //lo hago visible luego de limpiar usuario y contraseña al cerrarse el form principal
                this.txtContraseña.Text = string.Empty;
                this.txtUsuario.Text = string.Empty;
                this.Visible = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show($"{ex.Message}", "Fallo al loguear", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void ConfigurarComponentes()
        {
            txtUsuario.MaxLength = 20;
            txtContraseña.MaxLength = 20;
        }

    }
}
