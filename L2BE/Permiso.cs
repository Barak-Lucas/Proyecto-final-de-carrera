using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace L2BE
{
    public abstract class Permiso : Entidad
    {

        public abstract string Nombre { get; set; }

        public abstract List<Permiso> Hijos { get; set; }

        /// <summary>
        /// Devuelve el ID del permiso seguido de un punto y su nombre.
        /// 1. ADMIN
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{this.ID}. {this.Nombre}";
        }
    }
    public class PermisoSimpleBE : Permiso
    {
        public override string Nombre { get; set; }

        public override List<Permiso> Hijos { get; set; } = new(); //Los permisos simples siempre retornan lista vacía, no tienen hijos

        public PermisoSimpleBE(string pNombre)
        {
            this.Nombre = pNombre;
        }

        public PermisoSimpleBE(object[] pItemArray) : this(pItemArray[1].ToString())
        {
            this.ID = (int)pItemArray[0];
        }


    }

    public class PermisoCompuestoBE : Permiso
    {
        public override string Nombre { get; set; }

        private List<Permiso> hijos = new();

        public bool EsRol { get; set; }

        public override List<Permiso> Hijos
        {
            get { return hijos; }
            set { hijos = value; }
        }

        public PermisoCompuestoBE(string pNombre, bool pEsRol)
        {
            this.Nombre = pNombre;
            this.EsRol = pEsRol;
        }

        public PermisoCompuestoBE(string pNombre, bool pEsRol, Permiso pPermisoHijo) : this(pNombre, pEsRol)
        {
            this.hijos.Add(pPermisoHijo);   
        }

        public PermisoCompuestoBE(object[] pItemArray, List<Permiso> pPermisosHijos) : this(pItemArray[1].ToString(), Convert.ToBoolean(pItemArray[3]))
        {
            this.ID = Convert.ToInt32(pItemArray[0]);
            this.hijos = pPermisosHijos;
        }

        /// <summary>
        /// Unicamente para inicializar el permiso del Admin en Mapper.AltaPermiso();
        /// </summary>
        /// <param name="pItemArrayPadre"></param>
        /// <param name="pItemArrayHijo"></param>
        public PermisoCompuestoBE(object[] pItemArrayPermisoPadre, object[] pItemArrayPermisoHijo = null)
        {
            this.ID = Convert.ToInt32(pItemArrayPermisoPadre[0]);
            this.Nombre = pItemArrayPermisoPadre[1].ToString();
            this.EsRol = Convert.ToBoolean(pItemArrayPermisoPadre[3]);
            if(pItemArrayPermisoHijo != null)
            {
                this.hijos.Add(new PermisoSimpleBE(pItemArrayPermisoHijo));
            }
            
        }
    }
}
