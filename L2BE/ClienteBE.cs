using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace L2BE
{

    public class ClienteBE : Entidad
    {
        public int DNI { get; set; }

        public string? Nombre { get; set; }

        public string? Apellido { get; set; }

        public string? Domicilio { get; set; }

        public string? Email { get; set; }

        public string? Telefono { get; set; }

        public bool Activo { get; set; }

        public bool Propietario { get; set; }

        public ClienteBE()
        {

        }

        public ClienteBE(string pApellido, string pNombre, int pDNI, string pDomicilio, string pEmail, string pTelefono, bool pPropietario)
        {
            this.Nombre = pNombre;
            this.Apellido = pApellido;
            this.DNI = pDNI;
            this.Telefono = pTelefono;
            this.Email = pEmail;
            this.Domicilio = pDomicilio;
            this.Propietario = pPropietario;
            this.Activo = true;
        }

        public ClienteBE(object[] pItemArray) : this((string)pItemArray[1], (string)pItemArray[2], (int)pItemArray[3],
                                                        (string)pItemArray[4], (string)pItemArray[5], (string)pItemArray[6], (bool)pItemArray[7])
        {
            this.ID = (int)(pItemArray[0]);
            this.Activo = (bool)pItemArray[8];
        }

        public override string ToString()
        {
            return  this.Nombre + " " + this.Apellido;
        }
    }
   
}
