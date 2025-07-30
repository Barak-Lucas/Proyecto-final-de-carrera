using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2BE
{
    public class UsuarioBE : Entidad
    {
        public string Contraseña { get; set; }

        public string NombreUsuario { get; set; }

        public List<PermisoCompuestoBE> Roles { get; set; }

        public List<Permiso> Permisos { get; set; }

        public DateTime FechaIngreso { get; set; }

        public bool Bloqueado { get; set; }

        public bool Activo { get; set; }

        public UsuarioBE()
        {
            this.Roles = new List<PermisoCompuestoBE>();
            this.Permisos = new List<Permiso>();
        }

        public UsuarioBE(string pNombreUsuario, string pContraseña, PermisoCompuestoBE pRolInicial = null) : this()
        {
            this.NombreUsuario = pNombreUsuario;
            this.FechaIngreso = DateTime.Now;
            this.Contraseña = pContraseña;
            this.Activo = true;
            if (pRolInicial != null)
                Roles.Add(pRolInicial);
        }

        public UsuarioBE(object[] pItemArray) : this()
        {
            this.ID = Convert.ToInt32(pItemArray[0]);
            this.NombreUsuario = pItemArray[1].ToString();
            this.FechaIngreso = Convert.ToDateTime(pItemArray[2]);
            this.Contraseña = pItemArray[3].ToString();
            this.Bloqueado = Convert.ToBoolean(pItemArray[4]);
            this.Activo = Convert.ToBoolean(pItemArray[5]);
        }

        public UsuarioBE(object[] pItemArray, List<PermisoCompuestoBE> pRoles, List<PermisoCompuestoBE> pPermisosMenu) : this(pItemArray)
        {
            this.Roles = pRoles;
            this.Permisos = pPermisosMenu.Cast<Permiso>().ToList();

            foreach (PermisoCompuestoBE permisoMenu in pPermisosMenu)
            {
                Permisos.AddRange(permisoMenu.Hijos);
            }

            foreach (PermisoCompuestoBE rol in pRoles)
            {
                if (rol.Hijos.Count > 0)
                {
                    foreach (PermisoCompuestoBE permisoMenu in rol.Hijos)
                    {
                        //Solo agrego el permiso a la lista de permisos si no existe ya en la lista
                        if (this.Permisos.Find(p => p.ID == permisoMenu.ID) == null)
                        {
                            this.Permisos.Add(permisoMenu);
                        }

                        if (permisoMenu.Hijos.Count > 0)
                        {
                            foreach (Permiso permisoItem in permisoMenu.Hijos)
                            {
                                //Lo mismo acá
                                if (this.Permisos.Find(p => p.ID == permisoItem.ID) == null)
                                {
                                    this.Permisos.Add(permisoItem);
                                }
                            }
                        }
                    }
                }
            }

        }

        public override string ToString()
        {
            return $"{this.ID}. {this.NombreUsuario}";
        }
    }
}
