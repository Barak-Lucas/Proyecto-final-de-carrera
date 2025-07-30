using L1GUI.Forms;
using L1GUI.Forms.PopUps;
using L1GUI.Forms.Principales;
using L1GUI.Forms.Principales.GestionAdministrativa;
using L2BE;
using L3BLL;

namespace L1GUI
{
    public partial class FormPrincipal : Form
    {
        UsuarioBE usuarioLoggeado;
        UsuarioBLL bllUsuario;
        PermisoBLL bllPermiso;
        RolBLL bllROL;
        List<Permiso> listaPermisos;
        Action formLoginClose;
        public static List<ToolStripMenuItem> menus;

        public FormPrincipal(UsuarioBE pUsuarioLoggeado)
        {
            InitializeComponent();
            bllPermiso = new PermisoBLL();
            bllUsuario = new UsuarioBLL();
            bllROL = new RolBLL();
            usuarioLoggeado = pUsuarioLoggeado;
            try
            {
                OcultarMenuItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        #region MenuItems
        private void FormPrincipal_Load(object sender, EventArgs e)
        {

            try
            {
                MostrarItemsSegunPermiso(usuarioLoggeado.Permisos);
                ConfigurarComponentes();
                menus = new List<ToolStripMenuItem>();
                foreach (ToolStripMenuItem item in menuStrip1.Items)
                {
                    menus.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void carteraDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                FormCarteraClientes frmCarteraClientes = new FormCarteraClientes();
                frmCarteraClientes.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                FormDashboard frmDashboard = new FormDashboard();
                frmDashboard.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void catalogoDePropiedadesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                FormCatalogoPropiedades frmCatalogoPropiedades = new FormCatalogoPropiedades();
                frmCatalogoPropiedades.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void contratosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                FormContratos frmContratos = new FormContratos();
                frmContratos.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void registrarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                FormRegistrarVenta frmRegistrarVenta = new FormRegistrarVenta();
                frmRegistrarVenta.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void calendarioDeTasacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                FormAltaTasacion frmAltaTasacion = new FormAltaTasacion();
                frmAltaTasacion.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void aBMDePropiedadesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                FormAbmPropiedades frmAbm = new FormAbmPropiedades(usuarioLoggeado);
                frmAbm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void gestionRolpermisoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                FormRolesPermisos frmRolesPermisos = new FormRolesPermisos();
                frmRolesPermisos.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aBMUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                FormAbmUsuario frmAbmUsuario = new FormAbmUsuario(this.usuarioLoggeado);
                frmAbmUsuario.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion

        private void OcultarMenuItems()
        {

            try
            {
                if (this.menuStrip1 != null)
                {
                    foreach (ToolStripMenuItem item in menuStrip1.Items)
                    {
                        if (item is ToolStripMenuItem menuItem)
                        {
                            menuItem.Visible = false;
                            if (menuItem.DropDownItems.Count > 0) { OcultarMenuSubItems(menuItem.DropDownItems); }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void OcultarMenuSubItems(ToolStripItemCollection pItems)
        {
            foreach (ToolStripItem item in pItems)
            {
                if (item is ToolStripItem subMenuItem)
                {
                    subMenuItem.Visible = false;
                }
            }
        }

        private void MostrarItemsSegunPermiso(List<Permiso> pPermisosUsuario)
        {

            try
            {
                foreach (ToolStripItem item in menuStrip1.Items)
                {
                    if (item is ToolStripMenuItem menuItem)
                    {
                        if (menuItem.DropDownItems.Count > 0)
                        {
                            MostrarSubItemsSegunPermiso(menuItem, pPermisosUsuario);
                        }
                        if (TienePermiso(menuItem.Text, pPermisosUsuario))
                        {
                            menuItem.Visible = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void MostrarSubItemsSegunPermiso(ToolStripMenuItem pMenuItem, List<Permiso> pPermisosUsuario)
        {

            try
            {
                bool algunSubItemVisible = false;
                foreach (ToolStripItem subItem in pMenuItem.DropDownItems)
                {
                    if (subItem is ToolStripMenuItem subMenuItem)
                    {
                        //Si el sub item tiene a su ves sub item ---> recursiva
                        if (subMenuItem.DropDownItems.Count > 0)
                        {
                            MostrarSubItemsSegunPermiso(subMenuItem, pPermisosUsuario);
                        }
                        if (TienePermiso(subItem.Text, pPermisosUsuario))
                        {
                            subMenuItem.Visible = true;
                            algunSubItemVisible = true;
                        }
                    }
                }
                if (algunSubItemVisible)
                {
                    pMenuItem.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool TienePermiso(string pNombreItem, List<Permiso> pPermisosUsuario)
        {
            return pPermisosUsuario.Any(p => p.Nombre.Equals(pNombreItem, StringComparison.OrdinalIgnoreCase));
        }

        private void ConfigurarComponentes()
        {

            try
            {
                this.Text = $"Menú principal - Usuario [{usuarioLoggeado.ID}]: {usuarioLoggeado.NombreUsuario}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void bitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                FormBitacora frmBitacora = new FormBitacora(usuarioLoggeado);
                frmBitacora.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormBackup frmBackup = new FormBackup(usuarioLoggeado);
                frmBackup.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                FormRestore frmRestore = new FormRestore(usuarioLoggeado);
                frmRestore.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void estadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormEstadoPropiedad frmGestionarPropiedad = new FormEstadoPropiedad();
                frmGestionarPropiedad.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            usuarioLoggeado = null;
            this.Close();
        }

        private void registroDeInteraccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormHistorialInteracciones frmHistorialInteracciones = new FormHistorialInteracciones();
                frmHistorialInteracciones.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void calendarioDeVisitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormCalendarioVisitas frmCalendarioVisitas = new FormCalendarioVisitas();
                frmCalendarioVisitas.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void reimprimirTasacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                FormReimprimirFactura frmReimprimir = new FormReimprimirFactura();
                frmReimprimir.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cobrarTasacionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                FormCobrarTasacion frmTasaciones = new FormCobrarTasacion();
                frmTasaciones.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
