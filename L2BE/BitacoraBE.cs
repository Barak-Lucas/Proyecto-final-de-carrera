using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace L2BE
{
    public class BitacoraBE : Entidad
    {
        public DateTime FechaRegistro { get; set; }

        public string Detalle { get; set; }

        public UsuarioBE Culpable { get; set; }


        public BitacoraBE(DateTime pFecha, string pDetalle, UsuarioBE pUsuario)
        {
            this.FechaRegistro = pFecha;
            this.Detalle = pDetalle;
            this.Culpable = pUsuario;
        }

        public BitacoraBE(object[] pItemArray, UsuarioBE pUsuario) : this(Convert.ToDateTime(pItemArray[2]), pItemArray[3].ToString(), pUsuario)
        {
            this.ID = Convert.ToInt32(pItemArray[0]);
        }
    }
}
