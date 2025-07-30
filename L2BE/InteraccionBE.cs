using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2BE
{
    public class InteraccionBE : Entidad
    {

        public int PropiedadID { get; set; }
        public DateTime Fecha { get; set; }

        public string Detalles { get; set; }

        public string Contacto { get; set; }

        public string Interesado { get; set; }

        public InteraccionBE()
        {

        }

        public InteraccionBE(int pPropiedadID, string pContacto, string pDetalle, DateTime pFecha, string pInteresado ) : this()
        {
            this.PropiedadID = pPropiedadID;
            this.Interesado = pInteresado;
            this.Contacto = pContacto;
            this.Detalles = pDetalle;
            this.Fecha = pFecha;
        }

        public InteraccionBE(object[] pItemArray) : this((int)pItemArray[1], (string)pItemArray[2], (string)pItemArray[3], Convert.ToDateTime(pItemArray[4]), (string)pItemArray[5]) 
        {
            this.ID = (int)pItemArray[0];
        }

        public override string ToString()
        {
            return $"[{this.ID}] {this.Fecha.ToShortDateString()}";
        }
    }

    //public class InteraccionFechaDesc : IComparer<InteraccionBE>
    //{
    //    public int Compare(InteraccionBE? x, InteraccionBE? y)
    //    {
    //        int rdo = 0;
    //        if (x.Fecha > y.Fecha) rdo = 1;
    //        else if (x.Fecha < y.Fecha) rdo = -1;
    //        if (rdo == 0)
    //        {
    //            if (x.ID > y.ID) rdo = 1;
    //            else if (x.ID < y.ID) rdo = -1;
    //        }
    //        return rdo;
    //    }
    //}

    //public class InteraccionFechaAsc : IComparer<InteraccionBE>
    //{
    //    public int Compare(InteraccionBE? x, InteraccionBE? y)
    //    {
    //        int rdo = 0;
    //        if (x.Fecha > y.Fecha) rdo = 1;
    //        else if (x.Fecha < y.Fecha) rdo = -1;
    //        if(rdo == 0)
    //        {
    //            if (x.ID > y.ID) rdo = 1;
    //            else if (x.ID < y.ID) rdo = -1;
    //        }
    //            return rdo * -1;
    //    }
    //}
}
