using L2BE;
using L3BLL;
using ServicioDeEncriptado;
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
    public partial class FormRolesPermisos : Form
    {
        UsuarioBLL bllUsuario;
        RolBLL bllRol;
        PermisoBLL bllPermiso;
        List<UsuarioBE> listaUsuarios;
        List<PermisoCompuestoBE> listaPermisos;
        List<PermisoCompuestoBE> listaRoles;

        public FormRolesPermisos()
        {
            InitializeComponent();
            bllUsuario = new UsuarioBLL();
            bllRol = new RolBLL();
            bllPermiso = new PermisoBLL();
        }

        private void FormRolesPermisos_Load(object sender, EventArgs e)
        {

            try
            {
                RefrescarListas();
                RefrescarTreeViews();
                ConfigurarComponentes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }




        private void btnAltaRol_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrEmpty(txtNombreRolAlta.Text))
                {
                    MessageBox.Show("Ingrese un nombre para el ROL", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string nombre = txtNombreRolAlta.Text;
                bllRol.Alta(new PermisoCompuestoBE(nombre, true));

                RefrescarListas();
                RefrescarTreeViews();
                cmbListaRoles.DataSource = bllRol.ConsultarRoles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnModifRol_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNombreRolAlta.Text))
                {
                    MessageBox.Show("Nombre para el nuevo rol es inválido", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    return;
                }
                if (string.IsNullOrEmpty(txtIdRol.Text))
                {
                    MessageBox.Show("Debe seleccionar un rol", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    return;
                }
                string nuevoNombre = txtNombreRolAlta.Text;
                int id = Convert.ToInt32(txtIdRol.Text);
                Permiso rol = listaRoles.Find(r => r.ID == id);
                rol.Nombre = nuevoNombre;
                bllRol.Modificar(rol);

                RefrescarListas();
                RefrescarTreeViews();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarRol_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrEmpty(txtIdRol.Text))
                {
                    MessageBox.Show("Debe seleccionar un rol", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    return;
                }
                int id = Convert.ToInt32(txtIdRol.Text);
                if (id == 1)
                {
                    DialogResult result = MessageBox.Show($"El rol que está a punto de eliminar [{txtNombreRolAlta.Text}] es el rol ADMIN. {Environment.NewLine}" +
                                                          $"Si lo elimina, podría perder funciones básicas del sistema y podría requerir un reinicio del sistema " +
                                                          $"para recuperar las funcionalidades. ¿Desea continuar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.No)
                    {
                        MessageBox.Show("Eliminación cancelada", "Operación cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                bllRol.Baja(id);

                RefrescarListas();
                RefrescarTreeViews();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAsociarPermisoArol_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrEmpty(txtIdPermiso.Text))
                {
                    MessageBox.Show("Seleccione un permiso", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (string.IsNullOrEmpty(txtIdRol.Text))
                {
                    MessageBox.Show("Seleccione un rol", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                bllRol.AsociarPermisoAlRol(Convert.ToInt32(txtIdRol.Text), Convert.ToInt32(txtIdPermiso.Text));

                RefrescarListas();
                RefrescarTreeViews();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAltaPermiso_Click(object sender, EventArgs e)
        {

            try
            {
                if (cmbMenu.SelectedValue == null || cmbItem.SelectedValue == null)
                {
                    MessageBox.Show("Error al dar de alta un permiso. Menu o item del menú inválidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string nombrePermiso = cmbMenu.SelectedItem.ToString();
                string nombreItem = cmbItem.SelectedItem.ToString();

                bllPermiso.Alta(new PermisoCompuestoBE(nombrePermiso, false,new PermisoSimpleBE(nombreItem)));

                RefrescarListas();
                RefrescarTreeViews();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEliminarPermiso_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrEmpty(txtIdPermiso.Text))
                {
                    MessageBox.Show("Debe seleccionar un permiso", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    return;
                }
                int id = Convert.ToInt32(txtIdPermiso.Text);

                if (id <= 7)
                {
                    DialogResult result = MessageBox.Show($"El permiso que está a punto de eliminar [{txtNombrePermiso.Text}] es un permiso principal. {Environment.NewLine}" +
                                                          $"Si lo elimina, podría perder funciones básicas del sistema y podría requerir un reinicio del sistema " +
                                                          $"para recuperar las funcionalidades. ¿Desea continuar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.No)
                    {
                        MessageBox.Show("Eliminación cancelada", "Operación cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                bllPermiso.Baja(id);
                RefrescarListas();
                RefrescarTreeViews();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AsociarRolUsuario_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrEmpty(txtIdRol.Text))
                {
                    MessageBox.Show("Debe seleccionar un rol", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (string.IsNullOrEmpty(txtIdUsuario.Text))
                {
                    MessageBox.Show("Debe seleccionar un usuario", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (Convert.ToInt32(txtIdUsuario.Text) == 0)
                {
                    MessageBox.Show("No puede editar el rol ADMIN", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                int rolID = Convert.ToInt32(txtIdRol.Text);
                int idUsuario = Convert.ToInt32(txtIdUsuario.Text);

                bllRol.AsociarRolAlUsuario(rolID, idUsuario);

                RefrescarListas();
                RefrescarTreeViews();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDesasociarPermisoArol_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtIdPermiso.Text))
                {
                    MessageBox.Show("Seleccione un permiso", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (string.IsNullOrEmpty(txtIdRol.Text))
                {
                    MessageBox.Show("Seleccione un rol", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                int idPermiso = Convert.ToInt32(txtIdPermiso.Text);
                int idRol = Convert.ToInt32(txtIdRol.Text);
                if (idPermiso <= 7)
                {
                    DialogResult result = MessageBox.Show($"El permiso que está a punto de desasociar [{txtNombrePermiso.Text}] es un permiso principal. {Environment.NewLine}" +
                                                          $"Si lo elimina, podría perder funciones básicas del sistema y podría requerir un reinicio del sistema " +
                                                          $"para recuperar las funcionalidades. ¿Desea continuar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.No)
                    {
                        MessageBox.Show("Desasociación cancelada", "Operación cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                bllRol.DesasociarPermisoDelrol(idPermiso, idRol);

                RefrescarListas();
                RefrescarTreeViews();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAsociarPermisoUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtIdPermiso.Text))
                {
                    MessageBox.Show("Seleccione un permiso", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (string.IsNullOrEmpty(txtIdUsuario.Text))
                {
                    MessageBox.Show("Seleccione un usuario", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (Convert.ToInt32(txtIdUsuario.Text) == 1)
                {
                    MessageBox.Show("No puede editar el rol ADMIN", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                bllPermiso.AsociarPermisoAlUsuario(Convert.ToInt32(txtIdPermiso.Text), Convert.ToInt32(txtIdUsuario.Text));

                RefrescarListas();
                RefrescarTreeViews();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDesasociarPermisoUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtIdPermiso.Text))
                {
                    MessageBox.Show("Seleccione un permiso", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (string.IsNullOrEmpty(txtIdUsuario.Text))
                {
                    MessageBox.Show("Seleccione un usuario", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if(Convert.ToInt32(txtIdUsuario.Text) == 1)
                {
                    MessageBox.Show("No puede editar el rol ADMIN", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                bllPermiso.DesasociarPermisoDelUsuario(Convert.ToInt32(txtIdPermiso.Text), Convert.ToInt32(txtIdUsuario.Text));

                RefrescarListas();
                RefrescarTreeViews();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #region Miscelaneos
        private void cbDescifrarCifrar_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
                if (txtContraseña.Text != string.Empty)
                {
                    if (cbDescifrarCifrar.Checked)
                    {
                        txtContraseña.Text = Encriptador.Desencriptar(txtContraseña.Text);
                    }
                    else
                    {
                        txtContraseña.Text = Encriptador.Encriptar(txtContraseña.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void cmbMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                #region Actualizar menu item

                List<ToolStripMenuItem> subMenus = new List<ToolStripMenuItem>();
                ToolStripMenuItem menuSeleccionado = FormPrincipal.menus.Find(m => m.Text == cmbMenu.Text);

                foreach (ToolStripMenuItem subMenu in menuSeleccionado.DropDownItems)
                {
                    subMenus.Add(subMenu);
                }
                cmbItem.DataSource = (from sb in subMenus select sb.Text).ToList();


                #endregion
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }

        }

        /// <summary>
        /// Obtiene el ID de cualquier Tv, porque lo obtiene a partir de eliminar lo que empieza a partir '.' (1.Lucas Barak)
        /// </summary>
        /// <param name="pTreeView"></param>
        /// <returns></returns>
        private int ObtenerIdDelTreeView(TreeView pTreeView)
        {

            try
            {
                string nodoSeleccionado = pTreeView.SelectedNode.Text;
                int indiceDelPunto = nodoSeleccionado.IndexOf('.');
                //Remuevo todo a pertir del punto
                int idReturn = Convert.ToInt32(nodoSeleccionado.Substring(0, indiceDelPunto));
                return idReturn;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
           
        }

        private void cmbListaRoles_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                Permiso rolSeleccionado = cmbListaRoles.SelectedValue as Permiso;
                if (rolSeleccionado != null)
                {
                    txtNombreRolAlta.Text = rolSeleccionado.Nombre;
                    txtIdRol.Text = rolSeleccionado.ID.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefrescarListas()
        {
            try
            {
                listaUsuarios = bllUsuario.ConsultarUsuarios();
                listaPermisos = bllPermiso.ConsultarPermisos();
                listaRoles = bllRol.ConsultarRoles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefrescarTreeViews()
        {
            try
            {
                tvUsuario.Nodes.Clear();
                tvRoles.Nodes.Clear();
                tvPermisos.Nodes.Clear();

                List<TreeNode> nodosUsuarios = new List<TreeNode>();
                List<TreeNode> nodosPermisos = new List<TreeNode>();
                List<TreeNode> nodosRoles = new List<TreeNode>();

                //TREE NODE DE USUARIOS
                foreach (UsuarioBE usuario in listaUsuarios)
                {
                    string usuarioInfo = $"{usuario.ID}. {usuario.ToString()}";
                    nodosUsuarios.Add(new TreeNode(usuarioInfo));
                }

                //TREE NODE DE PERMISOS
                foreach (PermisoCompuestoBE permiso in listaPermisos)
                {
                    TreeNode nodoRaiz = new TreeNode(permiso.ToString());

                    foreach (Permiso permisoHijo in permiso.Hijos)
                    {
                        nodoRaiz.Nodes.Add(new TreeNode(permisoHijo.ToString()));
                    }
                    nodosPermisos.Add(nodoRaiz);

                }

                //TREE NODE DE ROLES
                foreach (PermisoCompuestoBE rol in listaRoles)
                {
                    nodosRoles.Add(new TreeNode(rol.ToString()));
                }

                tvUsuario.Nodes.AddRange(nodosUsuarios.ToArray());
                tvRoles.Nodes.AddRange(nodosRoles.ToArray());
                tvPermisos.Nodes.AddRange(nodosPermisos.ToArray());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tvPermisosPorRol_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                int idPermiso = ObtenerIdDelTreeView(tvPermisosPorRol);
                Permiso permisoSeleccionado = bllPermiso.BuscarPermiso(idPermiso);

                txtNombrePermiso.Text = permisoSeleccionado.Nombre;
                txtIdPermiso.Text = permisoSeleccionado.ID.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tvRoles_AfterSelect(object sender, TreeViewEventArgs e)
        {

            try
            {
                #region Interacción entre TreeViews

                tvPermisosPorRol.Nodes.Clear();

                int idRol = ObtenerIdDelTreeView(tvRoles);

                List<Permiso> listaPermisosRol = bllRol.ConsultarPermisosDeRol(idRol);
                List<TreeNode> nodosPermisosDelRol = new List<TreeNode>();

                foreach (PermisoCompuestoBE menu in listaPermisosRol)
                {
                    TreeNode nodoMenu = new TreeNode(menu.ToString());

                    foreach (Permiso item in menu.Hijos)
                    {
                        TreeNode nodoItem = new TreeNode(item.ToString());
                        nodoMenu.Nodes.Add(nodoItem);
                    }

                    nodosPermisosDelRol.Add(nodoMenu);
                }

                tvPermisosPorRol.Nodes.AddRange(nodosPermisosDelRol.ToArray());

                #endregion

                #region Interaccion con panel de rol

                txtIdRol.Text = idRol.ToString();
                txtNombreRolAlta.Text = listaRoles.Find(r => r.ID == idRol).Nombre;

                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tvUsuario_AfterSelect(object sender, TreeViewEventArgs e)
        {

            try
            {
                #region Interaccion con TreeViews

                tvRolesYPermisosUsuario.Nodes.Clear();

                int idUsuario = ObtenerIdDelTreeView(tvUsuario);

                List<Permiso> listaRolesYPermisos = bllRol.ConsultarRolesYPermisosDelUsuario(idUsuario);

               
                TreeNode tituloROL = new TreeNode("ROLES DEL USUARIO");
                TreeNode tituloPermisos = new TreeNode("PERMISOS DEL USUARIO");
                List<TreeNode> roles = new List<TreeNode>() { tituloROL};
                List<TreeNode> permisos = new List<TreeNode>() { tituloPermisos};

                foreach (Permiso permiso in listaRolesYPermisos)
                {                 

                    if (permiso is PermisoCompuestoBE && (permiso as PermisoCompuestoBE).EsRol)
                    {
                        TreeNode nodoRol = new TreeNode(permiso.ToString());

                        foreach (Permiso menu in permiso.Hijos)
                        {
                            TreeNode nodoMenu = new TreeNode(menu.ToString());
                            nodoRol.Nodes.Add(nodoMenu);

                            foreach (Permiso item in menu.Hijos)
                            {
                                TreeNode nodoItem = new TreeNode(item.ToString());
                                nodoMenu.Nodes.Add(nodoItem);
                            }
                        }

                        roles.Add(nodoRol);                 
                       
                    }
                    else if(permiso is PermisoCompuestoBE)
                    {
                        TreeNode nodoMenu = new TreeNode(permiso.ToString());

                        foreach (Permiso item in permiso.Hijos)
                        {
                            TreeNode nodoItem = new TreeNode(item.ToString());
                            nodoMenu.Nodes.Add(nodoItem);
                        }
                        permisos.Add(nodoMenu);
                    }
                    else
                    {
                        TreeNode nodoItem = new TreeNode(permiso.ToString());
                        permisos.Add(nodoItem);
                    }
                        
                }


                tvRolesYPermisosUsuario.Nodes.AddRange(roles.ToArray());
                tvRolesYPermisosUsuario.Nodes.AddRange(permisos.ToArray());

                #endregion

                #region Interaccion panel de usuario

                cbDescifrarCifrar.Checked = false;
                UsuarioBE usuarioSeleccionado = bllUsuario.BuscarUsuario(idUsuario);
                txtIdUsuario.Text = usuarioSeleccionado.ID.ToString();
                txtNombreUsuario.Text = usuarioSeleccionado.NombreUsuario.ToString();
                txtContraseña.Text = usuarioSeleccionado.Contraseña;
                cbBloqueado.Checked = usuarioSeleccionado.Bloqueado;
                cbActivo.Checked = usuarioSeleccionado.Activo;

                #endregion

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ConfigurarComponentes()
        {
            try
            {
                cmbListaRoles.DataSource = bllRol.ConsultarRoles();
                cmbMenu.DataSource = (from m in FormPrincipal.menus select m.Text).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void tvPermisos_AfterSelect(object sender, TreeViewEventArgs e)
        {

            try
            {
                int idPermiso = ObtenerIdDelTreeView(tvPermisos);
                txtIdPermiso.Text = idPermiso.ToString();
                txtNombrePermiso.Text = bllPermiso.BuscarPermiso(idPermiso).Nombre;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion


        private void btnDesasiociarRolUsuario_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrEmpty(txtIdRol.Text))
                {
                    MessageBox.Show("Debe seleccionar un rol", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (string.IsNullOrEmpty(txtIdUsuario.Text))
                {
                    MessageBox.Show("Debe seleccionar un usuario", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                int rolID = Convert.ToInt32(txtIdRol.Text);
                int idUsuario = Convert.ToInt32(txtIdUsuario.Text);

                bllRol.DesasociarRolDelUsuario(rolID, idUsuario);

                RefrescarListas();
                RefrescarTreeViews();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }


}
