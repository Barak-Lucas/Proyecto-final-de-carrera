using L2BE;
using L5DAO;
using ServicioDeEncriptado;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4ORM
{
    public class SistemaMapper
    {
        DAO dao = DAO.Instancia;
        DataSet dataSetBitacora;
        static DataSet dataSet;
        static DataTable dtPermiso, dtPermisoComponente, dtPermisosUsuario, dtUsuario, dtBitacora;

        public SistemaMapper()
        {            
            InicializarTablas();
            InicializarAdmin();
        }

        private void InicializarTablas()
        {
            dataSet = dao.ReturnDataset();
            dataSetBitacora = dao.ReturnDataSetBitacora();
            dtPermisoComponente = dataSet.Tables["PermisoComponente"];
            dtPermiso = dataSet.Tables["Permiso"];
            dtPermisosUsuario = dataSet.Tables["PermisosUsuario"];
            dtUsuario = dataSet.Tables["Usuario"];
            dtBitacora = dataSetBitacora.Tables["Bitacora"];
        }


        #region Permisos y Roles

        /// <summary>
        /// Da de alta un permiso "Menú" (PermisoCompuestoBE) con su respectivo "Item" (PermisoSimpleBE).
        /// Si el Menú ya existe, solo agrega el item y su relación. De otro modo, crea el Menú, el Item y la relación.
        /// </summary>
        /// <param name="pPermisoMenu"></param>
        public void AltaPermiso(PermisoCompuestoBE pPermisoMenu)
        {
            try
            {
                if (RelacionPermisoPermisoExiste(pPermisoMenu, pPermisoMenu.Hijos.First())) throw new Exception($"Ya existe una relación entre {pPermisoMenu.Nombre} y {pPermisoMenu.Hijos.First().Nombre}");

                DataRow drPermisoMenu = dtPermiso.NewRow();
                DataRow drPermisoItem = dtPermiso.NewRow();
                DataRow drRelacion = dtPermisoComponente.NewRow();

                DataRow? row = dtPermiso.AsEnumerable().Where(r => r.Field<string>("Nombre") == pPermisoMenu.Nombre).FirstOrDefault();

                
                //Si ya existe el menu, no vuelvo a crear otro drMenu, porque se duplicaría por cada permiso hijo
                if (row != null)
                {
                    drPermisoMenu = row;

                    drPermisoItem.ItemArray = new object[] //hijo del menu
                    {
                        drPermisoItem["ID"], //55
                        pPermisoMenu.Hijos.First().Nombre,
                        false,
                        false
                    };

                    drRelacion.ItemArray = new object[] //relacion con el menu
                    {
                        row["ID"], //69
                        drPermisoItem["ID"]
                    };

                    dtPermiso.Rows.Add(drPermisoItem);
                    dtPermisoComponente.Rows.Add(drRelacion);

                }
                //Si no existe el menu, lo creo
                else
                {
                    drPermisoMenu.ItemArray = new object[] //el menu
                    {
                        drPermisoMenu["ID"],
                        pPermisoMenu.Nombre,
                        true, //es compuesto
                        false //no es rol
                    };

                    drPermisoItem.ItemArray = new object[] //su hijo
                    {
                        drPermisoItem["ID"],
                        pPermisoMenu.Hijos.First().Nombre,
                        false,
                        false
                    };

                    drRelacion.ItemArray = new object[]// la relacion
                    {
                        drPermisoMenu["ID"],
                        drPermisoItem["ID"]
                    };

                    dtPermiso.Rows.Add(drPermisoMenu);
                    dtPermiso.Rows.Add(drPermisoItem);
                    dtPermisoComponente.Rows.Add(drRelacion);
                }

                dao.GrabarCambios();
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Da de alta un rol (PermisoCompuestoBE). El permiso compuesto puede ir vacío, ya los permisos hijos se agregan después. 
        /// </summary>
        /// <param name="pRol"></param>
        public void AltaRol(PermisoCompuestoBE pRol)
        {
            try
            {
                if (pRol == null) throw new ArgumentException("Rol NULL en Mapper.AltaRol()");
                if (dtPermiso.AsEnumerable().Any(row => row["Nombre"].ToString().ToLower() == pRol.Nombre.ToLower() && (bool)row["EsRol"])) throw new Exception($"Ya existe un rol con el nombre {pRol.Nombre}");
                DataRow drNuevoPermiso = dtPermiso.NewRow();
                drNuevoPermiso.ItemArray = new object[]
                {
                    drNuevoPermiso["ID"],
                    pRol.Nombre,
                    true, //Compuesto
                    true //es rol
                };
                dtPermiso.Rows.Add(drNuevoPermiso);
                dao.GrabarCambios();
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Modifica el nombre de un permiso (sea rol, menú o item). No modifica sus permisos hijos ni sus relaciones.
        /// </summary>
        /// <param name="pPermiso"></param>
        /// <exception cref="ArgumentException"></exception>
        public void ModificarPermiso(Permiso pPermiso)
        {
            if (pPermiso == null) throw new ArgumentException("Permiso NULL en Mapper.ModificarPermiso()");

            try
            {
                if (dtPermiso.AsEnumerable().Any(row => row["Nombre"].ToString().ToLower() == pPermiso.Nombre.ToLower())) throw new Exception($"Ya existe un permiso con el nombre {pPermiso.Nombre}.");
                DataRow drPermisoModif = dtPermiso.Rows.Find(pPermiso.ID);
                if (drPermisoModif == null) throw new Exception($"No se ha encontrado a ningún permiso bajo el ID {pPermiso.ID}. Mapper.ModificarPermiso()");

                drPermisoModif.ItemArray = new object[]
                {
                drPermisoModif.ItemArray[0],
                pPermiso.Nombre,
                drPermisoModif["EsCompuesto"],
                drPermisoModif["EsRol"]
                };



                dao.GrabarCambios();
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Elimina un permiso, sea rol, menú o item. Elimina sus relaciones con otros permisos y usuarios.
        /// </summary>
        /// <param name="pPermisoID"></param>
        public void BajaPermiso(int pPermisoID)
        {
            try
            {

                DataRow drBajaPermiso = dtPermiso.Rows.Find(pPermisoID);
                List<DataRow> rowsBaja = new List<DataRow>();
                if (drBajaPermiso == null) throw new Exception($"No se ha encontrado a ningún permiso bajo el ID {pPermisoID}. Mapper.BajaPermiso()");

                //Eliminar las relaciones entre permisos
                foreach (DataRow drPermisoComponente in dtPermisoComponente.Rows)
                {
                    if ((int)drPermisoComponente["PermisoHijoID"] == pPermisoID || (int)drPermisoComponente["PermisoPadreID"] == pPermisoID)
                    {
                        rowsBaja.Add(drPermisoComponente);
                    }
                }
                //ELiminar relaciones entre permisos y usuarios
                foreach (DataRow drPermisoUsuario in dtPermisosUsuario.Rows)
                {
                    if ((int)drPermisoUsuario["PermisoID"] == pPermisoID)
                    {
                        rowsBaja.Add(drPermisoUsuario);
                    }
                }
                foreach (DataRow row in rowsBaja)
                {
                    row.Delete();
                }
                dtPermiso.Rows.Remove(drBajaPermiso);
                dao.GrabarCambios();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Retorna un permiso, sea rol, menu o item. No toma en cuenta sus permisos hijos. Retorna null si no encuentra ningún permiso.
        /// </summary>
        /// <param name="pPermisoID"></param>
        /// <returns></returns>
        public Permiso? BuscarPermiso(int pPermisoID)
        {
            try
            {
                foreach (DataRow permiso in dtPermiso.Rows)
                {
                    if ((int)permiso["ID"] == pPermisoID)
                    {
                        DataRow drPermiso = dtPermiso.Rows.Find(pPermisoID);
                        if ((bool)drPermiso["EsROl"])
                        {
                            return new PermisoCompuestoBE(drPermiso.ItemArray, ConsultarPermisosDeRol(pPermisoID));
                        }
                        else if ((bool)permiso["EsCompuesto"])
                        {
                            return new PermisoCompuestoBE(drPermiso.ItemArray, ConsultarPermisosMenu(pPermisoID));
                        }
                        else return new PermisoSimpleBE(drPermiso.ItemArray);
                    }
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }

        }

        /// <summary>
        /// Retorna roles (PermisoCompuestoBE) que existen en el sistema. Retorna dentro de cada rol sus permisos compuestos (menús) y sus permisos simples (items).
        /// </summary>
        /// <returns></returns>
        public List<PermisoCompuestoBE> ConsultarRoles()
        {
            try
            {
                List<PermisoCompuestoBE> roles = new List<PermisoCompuestoBE>();

                foreach (DataRow dataRow in dtPermiso.Rows)
                {
                    if ((bool)dataRow["EsRol"] && (string)dataRow["Nombre"] != "ADMIN")
                    {
                        roles.Add(new PermisoCompuestoBE(dataRow.ItemArray, ConsultarPermisosDeRol((int)dataRow["ID"])));
                    }
                }
                return roles;
            }
            catch (Exception)
            {

                throw;
            }

        }

        /// <summary>
        /// Retorn los permisos "Menú" (compuesto) + sus "menú item" (componente)
        /// </summary>
        /// <returns></returns>
        public List<PermisoCompuestoBE> ConsultarTodosLosPermisos()
        {
            try
            {
                List<PermisoCompuestoBE> permisosMenuReturn = new List<PermisoCompuestoBE>();
                List<Permiso> permisosMenuItem = new List<Permiso>();
                if (dtPermiso.Rows.Count == 0) return permisosMenuReturn;

                foreach (DataRow drPermiso in dtPermiso.Rows)
                {
                    if ((bool)drPermiso["EsCompuesto"] && !(bool)drPermiso["EsRol"])
                    {
                        permisosMenuItem = new List<Permiso>();

                        foreach (DataRow drPermisoComponente in dtPermisoComponente.Rows)
                        {
                            //Si el padre de esa relación es el drPermiso
                            if ((int)drPermisoComponente["PermisoPadreID"] == (int)drPermiso["ID"])
                            {
                                //entonces recupero el permiso hijo
                                DataRow drPermisoSimple = dtPermiso.Rows.Find((int)drPermisoComponente["PermisoHijoID"]);
                                permisosMenuItem.Add(new PermisoSimpleBE(drPermisoSimple.ItemArray));
                            }
                        }
                        permisosMenuReturn.Add(new PermisoCompuestoBE(drPermiso.ItemArray, permisosMenuItem.Cast<Permiso>().ToList()));
                    }
                }
                return permisosMenuReturn;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Retorna los permisos de un rol. Sus "Menú" (PermisoCompuestoBE) y el "Item" del menú (PermisoSimpleBE)
        /// </summary>
        /// <param name="pRolID"></param>
        /// <returns></returns>
        public List<Permiso> ConsultarPermisosDeRol(int pRolID)
        {

            try
            {
                List<Permiso> permisosMenu = new List<Permiso>();
                List<Permiso> permisosItem;
                DataRow drPermisoROL = dtPermiso.Rows.Find(pRolID);

                if (drPermisoROL == null) throw new Exception($"No se ha encontrado a ningún rol con el ID {pRolID} en Mapper.ConsultarPermisosDeRol()");

                //busco la relación entre cada componente su compuesto...
                foreach (DataRow drPermisoComponenteMenu in dtPermisoComponente.Rows)
                {
                    if ((int)drPermisoComponenteMenu["PermisoPadreID"] == (int)drPermisoROL["ID"])
                    {
                        permisosItem = new List<Permiso>(); //Reiniciar la lista para que no queden los menuItem de los Menu anteriores

                        DataRow drPermisoMenu = dtPermiso.Rows.Find(drPermisoComponenteMenu["PermisoHijoID"]);

                        if ((bool)drPermisoMenu["EsCompuesto"])
                        {
                            foreach (DataRow drPermisoComponenteItem in dtPermisoComponente.Rows)
                            {
                                if ((int)drPermisoComponenteItem["PermisoPadreID"] == (int)drPermisoMenu["ID"])
                                {
                                    DataRow drPermisoItem = dtPermiso.Rows.Find(drPermisoComponenteItem["PermisoHijoID"]);

                                    permisosItem.Add(new PermisoSimpleBE(drPermisoItem.ItemArray));
                                }
                            }
                        }
                        permisosMenu.Add(new PermisoCompuestoBE(drPermisoMenu.ItemArray, permisosItem));
                    }
                }
                return permisosMenu;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Retorna los permisos "Item" (PermisoSimpleBE) del menú. 
        /// </summary>
        /// <param name="pPermisoMenuID"></param>
        /// <returns></returns>
        public List<Permiso> ConsultarPermisosMenu(int pPermisoMenuID)
        {
            try
            {
                List<Permiso> permisosItem = new List<Permiso>();
                DataRow drPermisoMenu = dtPermiso.Rows.Find(pPermisoMenuID);

                if (drPermisoMenu == null) throw new Exception($"No se ha encontrado a ningún permiso menu con el ID {pPermisoMenuID} en Mapper.ConsultarPermisosMenu()");

                //Por cada relación en la que el menú sea el padre...
                foreach (DataRow drRelacion in dtPermisoComponente.AsEnumerable().Where(r => r.Field<int>("PermisoPadreID") == pPermisoMenuID))
                {
                    DataRow permisoHijo = dtPermiso.Rows.Find(drRelacion["PermisoHijoID"]);
                    permisosItem.Add(new PermisoSimpleBE(permisoHijo.ItemArray));
                }
                return permisosItem;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<PermisoCompuestoBE> ConsultarRolesUsuario(int pUsuarioID)
        {
            try
            {
                DataRow drUsuario = dtUsuario.Rows.Find(pUsuarioID);

                if (drUsuario == null) throw new Exception($"No se ha encontrado a ningún usuario con el ID {pUsuarioID} en Mapper.ConsultarRolesUsuario()");

                List<PermisoCompuestoBE> rolesReturn = new List<PermisoCompuestoBE>();

                foreach (DataRow rowPermisoUsuario in dtPermisosUsuario.Rows)
                {
                    if ((int)rowPermisoUsuario["UsuarioID"] == pUsuarioID)
                    {
                        DataRow rowPermiso = dtPermiso.Rows.Find(rowPermisoUsuario["PermisoID"]);
                        if ((bool)rowPermiso["EsRol"])
                        {
                            rolesReturn.Add(new PermisoCompuestoBE(rowPermiso.ItemArray, ConsultarPermisosDeRol((int)rowPermiso["ID"])));
                        }
                    }

                }
                return rolesReturn;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Utiliza los métodos ConsultarRolesUsuario y ConsultarPermisosMenuUsuario para retornar una lista de esos dos combinados.
        /// No hay mucha ciencia, la verdad.
        /// </summary>
        /// <param name="pUsuarioID"></param>
        /// <returns></returns>
        public List<Permiso> ConsultarRolesYPermisosDelUsuario(int pUsuarioID)
        {
            try
            {
                List<Permiso> permisosReturn = new List<Permiso>();
                List<PermisoCompuestoBE> roles = ConsultarRolesUsuario(pUsuarioID);
                List<PermisoCompuestoBE> permisosMenu = ConsultarPermisosMenuUsuario(pUsuarioID);

                permisosReturn.AddRange(roles);
                permisosReturn.AddRange(permisosMenu);

                return permisosReturn;
            }
            catch (Exception)
            {

                throw;
            }
        }


        /// <summary>
        /// Devuelve los permisos menú (PermisoCompuestoBE) + los permisos item (PermisoSimpleBE) de los menú de un usuario. No se tienen en cuenta los roles.
        /// </summary>
        /// <param name="pUsuarioID"></param>
        /// <returns></returns>
        public List<PermisoCompuestoBE> ConsultarPermisosMenuUsuario(int pUsuarioID)
        {
            try
            {
                List<PermisoCompuestoBE> permisosReturn = new List<PermisoCompuestoBE>();

                foreach (DataRow drPermisoUsuario in dtPermisosUsuario.Rows)
                {
                    if ((int)drPermisoUsuario["UsuarioID"] == pUsuarioID)
                    {
                        DataRow drPermiso = dtPermiso.Rows.Find(drPermisoUsuario["PermisoID"]);

                        if (!(bool)drPermiso["EsRol"])
                        {
                            permisosReturn.Add(new PermisoCompuestoBE(drPermiso.ItemArray, ConsultarPermisosMenu((int)drPermiso["ID"])));
                        }

                    }
                }
                return permisosReturn;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Retorna le ID actual +1
        /// </summary>
        /// <returns></returns>
        public int ObtenerIDPermiso()
        {
            try
            {
                if (dtPermiso.Rows.Count == 0) return 1;
                return dtPermiso.AsEnumerable().Max(row => row.Field<int>("ID")) + 1;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Busca si existe ya una asociación entre Permiso-Componente y si no es así, los asocia. 
        /// </summary>
        /// <param name="pRolID"></param>
        /// <param name="pPermisoID"></param>
        public void AsociarPermisoAlRol(int pRolID, int pPermisoID)
        {

            try
            {
                DataRow drRol = dtPermiso.Rows.Find(pRolID);
                DataRow drPermiso = dtPermiso.Rows.Find(pPermisoID);

                DataRow drNuevaRelacion = dtPermisoComponente.NewRow();

                if (dtPermisoComponente.Rows.Find(new object[] { drRol["ID"], drPermiso["ID"] }) != null)
                    throw new Exception($"Ya existe la relación rol {drRol["Nombre"]} permiso {drPermiso["Nombre"]}");

                if (!(bool)drRol["EsRol"])
                    throw new Exception("Puede que validar esto sea un tiro en la pierna, no recuerdo si asocio permisos a menús también con esto. Mapper.AsociarPermisoAlRol()");


                drNuevaRelacion.ItemArray = new object[]
                {
                        drRol["ID"],
                        drPermiso["ID"]
                };

                dtPermisoComponente.Rows.Add(drNuevaRelacion);

                dao.GrabarCambios();

            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Asocia un Rol o Menú (Permisos compuestos) o un Menú Item (permiso simple). Si es compuesto, busca a los hijos del compuesto y agrega esa relación también.
        /// </summary>
        /// <param name="pPermisoID"></param>
        /// <param name="pUsuarioID"></param>
        /// 
        public void AsociarPermisoAlUsuario(int pPermisoID, int pUsuarioID)
        {
            try
            {
                DataRow drUsuario = dtUsuario.Rows.Find(pUsuarioID);
                DataRow drPermiso = dtPermiso.Rows.Find(pPermisoID);

                if (RelacionPermisoUsuarioExiste(pPermisoID, pUsuarioID))
                    throw new Exception($"Ya se encuentra asociado el permiso [{drPermiso["Nombre"]}] al usuario [{drUsuario["NombreUsuario"]}]");
                DataRow drNuevaRelacion = dtPermisosUsuario.NewRow();

                drNuevaRelacion.ItemArray = new object[]
                {
                    drPermiso["ID"],
                    drUsuario["ID"]

                };


                dtPermisosUsuario.Rows.Add(drNuevaRelacion);

                dao.GrabarCambios();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DesasignarPermisoAlUsuario(int pPermisoID, int pUsuarioID)
        {
            try
            {
                DataRow drUsuario = dtUsuario.Rows.Find(pUsuarioID);
                DataRow drPermiso = dtPermiso.Rows.Find(pPermisoID);

                if (!RelacionPermisoUsuarioExiste(pPermisoID, pUsuarioID))
                    throw new Exception($"No se ha encontrado la relación [{drPermiso["Nombre"]}] al usuario [{drUsuario["NombreUsuario"]}] {Environment.NewLine}" +
                                        $"Si el permiso es un Item del menú, intente dar de baja el menú");

                DataRow drRelacion = dtPermisosUsuario.Rows.Find(new object[] { drPermiso["ID"], drUsuario["ID"] });
                dtPermisosUsuario.Rows.Remove(drRelacion);
                dao.GrabarCambios();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DesasignarPermisoAlRol(int pPermisoID, int pRolID)
        {
            try
            {
                DataRow drRol = dtPermiso.Rows.Find(pRolID);
                DataRow drPermiso = dtPermiso.Rows.Find(pPermisoID);
                if (drRol == null || drPermiso == null)
                    throw new Exception("Error al desasociar permiso del rol. El Usuario y/o el usuario fueron null en Mapper.AsociarPermisoAlUsuario()");
                if (!(bool)drRol["EsRol"])
                    throw new Exception($"El permiso ID {drRol["ID"]} con nombre {drRol["Nombre"]} no es un rol");

                DataRow drRelacion = dtPermisoComponente.Rows.Find(new object[] { drRol["ID"], drPermiso["ID"] });
                if (drRelacion == null)
                    throw new Exception($"No se ha encontrado la relación entre el rol {drRol["Nombre"]} y el permiso {drPermiso["Nombre"]}");

                dtPermisoComponente.Rows.Remove(drRelacion);
                dao.GrabarCambios();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DesasignarRolAUsuario(int pRolID, int pUsuarioID)
        {
            try
            {
                DataRow drRol = dtPermiso.Rows.Find(pRolID);
                DataRow drUsuario = dtUsuario.Rows.Find(pUsuarioID);

                if (drRol == null || drUsuario == null)
                    throw new Exception("Rol o usuario null en DesasignarRolAUsuario");
                if (!(bool)drRol["EsRol"])
                    throw new Exception($"El permiso ID {drRol["ID"]} con nombre {drRol["Nombre"]} no es un rol");
                if (!RelacionPermisoUsuarioExiste(pRolID, pUsuarioID))
                    throw new Exception($"No se ha encontrado la relación entre el rol {drRol["Nombre"]} y el usuario {drUsuario["NombreUsuario"]}");

                DataRow drRelacion = dtPermisosUsuario.Rows.Find(new object[] { drRol["ID"], drUsuario["ID"] });
                dtPermisosUsuario.Rows.Remove(drRelacion);
                dao.GrabarCambios();

            }
            catch (Exception)
            {

                throw;
            }
        }

        private bool RelacionPermisoPermisoExiste(Permiso pPermiso1, Permiso pPermiso2)
        {
            DataRow drPermiso1 = dtPermiso.AsEnumerable().Where(row => row.Field<string>("Nombre").ToLower() == pPermiso1.Nombre.ToLower()).FirstOrDefault();
            DataRow drPermiso2 = dtPermiso.AsEnumerable().Where(row => row.Field<string>("Nombre").ToLower() == pPermiso2.Nombre.ToLower()).FirstOrDefault();

            if (drPermiso1 == null || drPermiso2 == null) return false;

            DataRow drRelacion = dtPermisoComponente.Rows.Find(new object[] { (int)drPermiso1["ID"], (int)drPermiso2["ID"] });

            if (drRelacion != null) return true;

            return false;
        }

        private bool RelacionPermisoUsuarioExiste(int pPermisoID, int pUsuarioID)
        {
            DataRow drPermiso = dtPermiso.Rows.Find(pPermisoID);
            DataRow drUsuario = dtUsuario.Rows.Find(pUsuarioID);

            if (drPermiso == null || drUsuario == null) return false;

            DataRow drRelacion = dtPermisosUsuario.Rows.Find(new object[] { drPermiso["ID"], drUsuario["ID"] });

            if (drRelacion != null) return true;

            return false;
        }

        /// <summary>
        /// Harcode totalmente necesario (?
        /// </summary>
        private void InicializarAdmin()
        {
            if (dtPermiso.Rows.Count == 0 && dtUsuario.Rows.Count == 0)
            {
                try
                {
                    //Usuario admin
                    DataRow drUsuarioAdmin = dtUsuario.NewRow();
                    drUsuarioAdmin.ItemArray = new object[]
                    {
                        1,
                        "ADMIN",
                        new DateTime(2999,1,1,0,0,0),                   
                        Encriptador.Encriptar("ADMIN"),
                        false, //bloqueado
                        true, //activo
                    };

                    dtUsuario.Rows.Add(drUsuarioAdmin);

                    //Rol basico de admin para dar de alta otros roles y permisos
                    #region Permisos
                    DataRow drRolAdmin = dtPermiso.NewRow();
                    drRolAdmin.ItemArray = new object[]
                    {
                        drRolAdmin["ID"], //1
                        "ADMIN",
                        true, //es compuesto
                        true //es rol
                    };

                    DataRow drPermisoInicio = dtPermiso.NewRow();
                    drPermisoInicio.ItemArray = new object[]
                    {
                        drPermisoInicio["ID"], //2
                        "Inicio",
                        true,
                        false
                    };

                    DataRow drPermisoLogout = dtPermiso.NewRow();
                    drPermisoLogout.ItemArray = new object[]
                    {
                        drPermisoLogout["ID"], //3
                        "Logout",
                        false,
                        false
                    };

                    DataRow drPermisoSalir = dtPermiso.NewRow();
                    drPermisoSalir.ItemArray = new object[]
                    {
                        drPermisoSalir["ID"], //4
                        "Salir",
                        false,
                        false
                    };

                    DataRow drPermisoGestionDeUsuarios = dtPermiso.NewRow();
                    drPermisoGestionDeUsuarios.ItemArray = new object[]
                    {
                        drPermisoGestionDeUsuarios["ID"], //5
                        "Gestion de Usuarios",
                        true,
                        false
                    };

                    DataRow drPermisoAbmUsuario = dtPermiso.NewRow();
                    drPermisoAbmUsuario.ItemArray = new object[]
                    {
                        drPermisoAbmUsuario["ID"],// 6
                        "ABM Usuario",
                        false,
                        false
                    };
                    DataRow drPermisoRolesYPermisos = dtPermiso.NewRow();
                    drPermisoRolesYPermisos.ItemArray = new object[]
                    {
                        drPermisoRolesYPermisos["ID"], //7
                        "Roles y permisos",
                        false,
                        false
                    };
                    DataRow drPermisoBD = dtPermiso.NewRow();
                    drPermisoBD.ItemArray = new object[]
                    {
                        drPermisoBD["ID"], //8
                        "Gestion de BD",
                        true,
                        false
                    };
                    DataRow drBitacora = dtPermiso.NewRow();
                    drBitacora.ItemArray = new object[]
                    {
                        drBitacora["ID"], //9
                        "Bitacora",
                        false,
                        false
                    };
                    DataRow drBackup = dtPermiso.NewRow();
                    drBackup.ItemArray = new object[]
                    {
                        drBackup["ID"], //10
                        "Backup",
                        false,
                        false
                    };
                    DataRow drRestore = dtPermiso.NewRow();
                    drRestore.ItemArray = new object[]
                    {
                        drRestore["ID"], //11
                        "Restore",
                        false,
                        false
                    };

                    dtPermiso.Rows.Add(drRolAdmin);
                    dtPermiso.Rows.Add(drPermisoInicio);
                    dtPermiso.Rows.Add(drPermisoLogout);
                    dtPermiso.Rows.Add(drPermisoSalir);
                    dtPermiso.Rows.Add(drPermisoGestionDeUsuarios);
                    dtPermiso.Rows.Add(drPermisoAbmUsuario);
                    dtPermiso.Rows.Add(drPermisoRolesYPermisos);
                    dtPermiso.Rows.Add(drPermisoBD);
                    dtPermiso.Rows.Add(drBitacora);
                    dtPermiso.Rows.Add(drBackup);
                    dtPermiso.Rows.Add(drRestore);

                    #endregion

                    //relación entre permisos
                    #region Relacions entre permisos

                    /*************ADMIN => INICIO + GESTION USUARIOS + BD **************/
                    DataRow drRelacionAdminInicio = dtPermisoComponente.NewRow();
                    drRelacionAdminInicio.ItemArray = new object[]
                    {
                        drRolAdmin["ID"],                //0
                        drPermisoInicio["ID"]            //2
                    };

                    DataRow drRelacionAdminGestionUsuarios = dtPermisoComponente.NewRow();
                    drRelacionAdminGestionUsuarios.ItemArray = new object[]
                    {
                        drRolAdmin["ID"],                //1
                        drPermisoGestionDeUsuarios["ID"] //5
                    };
                    DataRow drRelacionAdminBD = dtPermisoComponente.NewRow();
                    drRelacionAdminBD.ItemArray = new object[]
                    {
                        drRolAdmin["ID"],                //1
                        drPermisoBD["ID"]               //8
                    };


                    /***********GESTION DE USUARIO => ABMUSUARIO + ROLES Y PERMISOS**************/

                    DataRow drRelacionGestionUsuariosAbmUsuario = dtPermisoComponente.NewRow();
                    drRelacionGestionUsuariosAbmUsuario.ItemArray = new object[]
                    {
                        drPermisoGestionDeUsuarios["ID"], //5
                        drPermisoAbmUsuario["ID"]         //6
                    };

                    DataRow drRelacionGestionUsuariosRolesYPermisos = dtPermisoComponente.NewRow();
                    drRelacionGestionUsuariosRolesYPermisos.ItemArray = new object[]
                    {
                        drPermisoGestionDeUsuarios["ID"], //5
                        drPermisoRolesYPermisos["ID"]     //7
                    };

                    /*************INICIO => LOGOUT + SALIR **************/
                    DataRow drRelacionInicioLogout = dtPermisoComponente.NewRow();
                    drRelacionInicioLogout.ItemArray = new object[]
                    {
                        drPermisoInicio["ID"],            //2
                        drPermisoLogout["ID"]             //3
                    };

                    DataRow drRelacionInicioSalir = dtPermisoComponente.NewRow();
                    drRelacionInicioSalir.ItemArray = new object[]
                    {
                        drPermisoInicio["ID"],            //2
                        drPermisoSalir["ID"]              //4
                    };

                    /*************BACKUP => BITÁCORA + BACKUP + SALIR **************/

                    DataRow drRelacionBdBitacora = dtPermisoComponente.NewRow();
                    drRelacionBdBitacora.ItemArray = new object[]
                    {
                        drPermisoBD["ID"],            //8
                        drBitacora["ID"]             //9
                    };
                    DataRow drRelacionBdBackup = dtPermisoComponente.NewRow();
                    drRelacionBdBackup.ItemArray = new object[]
                    {
                        drPermisoBD["ID"],            //8
                        drBackup["ID"]             //10
                    };
                    DataRow drRelacionBdRestore = dtPermisoComponente.NewRow();
                    drRelacionBdRestore.ItemArray = new object[]
                    {
                        drPermisoBD["ID"],            //8
                        drRestore["ID"]             //11
                    };

                    //Admin con permisos
                    dtPermisoComponente.Rows.Add(drRelacionAdminInicio);
                    dtPermisoComponente.Rows.Add(drRelacionAdminGestionUsuarios);
                    dtPermisoComponente.Rows.Add(drRelacionAdminBD);

                    //permisos menu con permisos item
                    dtPermisoComponente.Rows.Add(drRelacionGestionUsuariosAbmUsuario);
                    dtPermisoComponente.Rows.Add(drRelacionGestionUsuariosRolesYPermisos);
                    dtPermisoComponente.Rows.Add(drRelacionInicioLogout);
                    dtPermisoComponente.Rows.Add(drRelacionInicioSalir);
                    dtPermisoComponente.Rows.Add(drRelacionBdBitacora);
                    dtPermisoComponente.Rows.Add(drRelacionBdBackup);
                    dtPermisoComponente.Rows.Add(drRelacionBdRestore);


                    #endregion

                    //Permisos del admin
                    DataRow drPermisoDelAdmin = dtPermisosUsuario.NewRow();
                    drPermisoDelAdmin.ItemArray = new object[]
                    {
                        drRolAdmin["ID"],
                        drUsuarioAdmin["ID"]
                    };

                    dtPermisosUsuario.Rows.Add(drPermisoDelAdmin);
                    dao.GrabarCambios();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        #endregion

        #region Usuarios

        public void AltaUsuario(UsuarioBE pUsuario)
        {
            if (pUsuario == null) throw new ArgumentException("Usuario NULL en Mapper.AltaUsuario()");

            try
            {
                if (dtUsuario.AsEnumerable().Any(row => (string)row["NombreUsuario"] == (string)pUsuario.NombreUsuario)) throw new Exception("El nombre de usuario ya se encuentra registrado");
                DataRow drNuevoUsuario = dtUsuario.NewRow();
                drNuevoUsuario.ItemArray = new object[]
                {
                    pUsuario.ID,
                    pUsuario.NombreUsuario,
                    pUsuario.FechaIngreso,
                    Encriptador.Encriptar(pUsuario.Contraseña),
                    pUsuario.Bloqueado,
                    pUsuario.Activo
                };

                dtUsuario.Rows.Add(drNuevoUsuario);

                if (pUsuario.Roles.Count() > 0)
                    AsociarPermisoAlUsuario(pUsuario.Roles.First().ID, (int)drNuevoUsuario.ItemArray[0]);

                dao.GrabarCambios();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void BajaUsuario(int pUsuarioID)
        {
            try
            {
                DataRow drUsuarioBaja = dtUsuario.Rows.Find(pUsuarioID);
                if (drUsuarioBaja == null) throw new Exception($"No se ha encontrado al usuario que quiere dar de baja con el ID [{pUsuarioID}]");

                drUsuarioBaja["Activo"] = false;
                dao.GrabarCambios();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void ReactivarUsuario(int pUsuarioID)
        {
            try
            {
                DataRow drUsuarioBaja = dtUsuario.Rows.Find(pUsuarioID);
                if (drUsuarioBaja == null) throw new Exception($"No se ha encontrado al usuario que quiere reactivar con el ID [{pUsuarioID}]");

                drUsuarioBaja["Activo"] = true;
                dao.GrabarCambios();
            }
            catch (Exception)
            {

                throw;
            }
        }


        public void ModificarUsuario(UsuarioBE pUsuario)
        {
            if (pUsuario == null) throw new ArgumentException("Usuario NULL en Mapper.AltaUsuario()");

            try
            {
                DataRow drUsuarioModif = dtUsuario.Rows.Find(pUsuario.ID);
                drUsuarioModif.ItemArray = new object[]
                {
                    pUsuario.ID,
                    pUsuario.NombreUsuario,
                    pUsuario.FechaIngreso,
                    pUsuario.Contraseña, 
                    pUsuario.Bloqueado,
                    pUsuario.Activo
                };

                dao.GrabarCambios();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<UsuarioBE> ConsultarUsuarios()
        {

            try
            {
                if (dtUsuario.Rows.Count == 0) new List<UsuarioBE>();

                List<UsuarioBE> listaReturn = new List<UsuarioBE>();

                foreach (DataRow drUsuario in dtUsuario.Rows)
                {
                    listaReturn.Add(new UsuarioBE(drUsuario.ItemArray, ConsultarRolesUsuario((int)drUsuario["ID"]), ConsultarPermisosMenuUsuario((int)drUsuario["ID"])));
                }
                return listaReturn;
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion



        #region Bitacora

        public void CrearBackup(UsuarioBE pUsuario)
        {
            try
            {
                DataRow drEntradaBitacora = dtBitacora.NewRow();
                drEntradaBitacora.ItemArray = new object[]
                {
                    drEntradaBitacora["ID"],
                    pUsuario.ID,
                    DateTime.Now,
                    "Backup"

                };
                dtBitacora.Rows.Add(drEntradaBitacora);
                dao.GuardarBitacora();
                dao.CrearBackup();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Restore(UsuarioBE pUsuario, string pNombreBackup)
        {
            try
            {
                DataRow drNuevaEntradaBitacora = dtBitacora.NewRow();
                drNuevaEntradaBitacora.ItemArray = new object[]
                {
                    drNuevaEntradaBitacora["ID"],
                    pUsuario.ID,
                    DateTime.Now,
                    "Restore"
                };

                dtBitacora.Rows.Add(drNuevaEntradaBitacora);
                dao.GuardarBitacora();
                dao.Restore(pNombreBackup);
                InicializarTablas();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<BitacoraBE> ConsultarBitacora()
        {
            List<BitacoraBE> listaReturn = new List<BitacoraBE>();
            foreach (DataRow drEntrada in dtBitacora.Rows)
            {
                int idUsuario = (int)drEntrada["Usuario"];
                DataRow drUsuario = dtUsuario.Rows.Find(idUsuario);
                UsuarioBE usuario = new UsuarioBE(drUsuario.ItemArray);
                listaReturn.Add(new BitacoraBE(drEntrada.ItemArray, usuario));
            }
            return listaReturn;
        }

        public string[] ConsultarBackups()
        {
            try
            {
                return dao.BackupsDisponibles();
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion
    }
}
