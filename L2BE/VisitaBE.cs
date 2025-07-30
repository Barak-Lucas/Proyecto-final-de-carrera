using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2BE
{
    public class VisitaBE : Entidad
    {
        public int VisitanteID { get; set; }

        public int PropiedadID { get; set; }

        public DateTime FechaHora { get; set; }

        public string? ComentariosVisita { get; set; }

        public EstadosVisita? Estado { get; set; }

        public enum EstadosVisita
        {
            Pendiente,
            Realizada,
            Cancelada,
        }

        public VisitaBE()
        {
            
        }

        public VisitaBE(int pClienteID, int pPropiedadID, DateTime pFechaHora)
        {
            this.VisitanteID = pClienteID;
            this.PropiedadID = pPropiedadID;
            this.FechaHora = pFechaHora;
            this.Estado = EstadosVisita.Pendiente;
        }

        public VisitaBE(object[] pItemArray) : this((int)pItemArray[1], (int)pItemArray[2], Convert.ToDateTime(pItemArray[3]))
        {
            this.ID = (int)pItemArray[0];
            this.Estado = Enum.Parse<EstadosVisita>(pItemArray[4].ToString());
            this.ComentariosVisita = pItemArray[5].ToString();

        }

    }

    public class VisitaFechaLejana : IComparer<VisitaBE>
    {
        public int Compare(VisitaBE? x, VisitaBE? y)
        {
            if (x == null && y == null) return 0;
            if (x == null) return -1;
            if (y == null) return 1;

            return y.FechaHora.CompareTo(x.FechaHora); 
        }
    }



    public class VisitaFechaCercana : IComparer<VisitaBE>
    {
        public int Compare(VisitaBE? x, VisitaBE? y)
        {
            if (x == null && y == null) return 0;
            if (x == null) return -1;
            if (y == null) return 1;

            return x.FechaHora.CompareTo(y.FechaHora); 
        }
    }

}
