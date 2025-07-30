using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2BE
{
    public class TasacionBE : Entidad
    {
        public int PropietarioID { get; set; }

        public decimal PorcentajeComision = 0.005m;

        public Estados Estado { get; set; }

        public string Observaciones { get; set; }

        public string Domicilio { get; set; }

        public  string Localidad { get; set; }

        public int m2 { get; set; }

        public DateTime FechaHora { get; set; }

        public string TipoInmueble { get; set; }

        public decimal ValorInmuebleTasado { get; set; }

        public enum Estados
        {
            Pendiente,
            Cobrada,
            Cancelada,
        }


        public TasacionBE()
        {

        }

        public TasacionBE(int pPropietarioID, string pDomicilio, DateTime pFechaHora, string pLocalidad, string pTipo)
        {
            this.PropietarioID = pPropietarioID;
            this.Domicilio = pDomicilio;
            this.FechaHora = pFechaHora;
            this.Localidad = pLocalidad;
            this.TipoInmueble = pTipo;
            this.Estado = Estados.Pendiente;
            this.m2 = 0;
        }

        public TasacionBE(object[] pItemArray) : this((int)pItemArray[1], (string)pItemArray[2], Convert.ToDateTime(pItemArray[4]), (string)pItemArray[5], (string)pItemArray[9]) 
        {
            this.ID = (int)pItemArray[0];
            this.PorcentajeComision = Convert.ToDecimal(pItemArray[8]);
            this.Estado = Enum.Parse<Estados>((string)pItemArray[3]);
            this.Observaciones = pItemArray[7].ToString();
            this.ValorInmuebleTasado = Convert.ToDecimal(pItemArray[10]);
            this.m2 = (int)pItemArray[6];
        }

    }

    public class TasacionValorASC : IComparer<TasacionBE>
    {
        public int Compare(TasacionBE? x, TasacionBE? y)
        {
            int resultado = 0;

            if(x.ValorInmuebleTasado < y.ValorInmuebleTasado) resultado = -1;
            else if (x.ValorInmuebleTasado > y.ValorInmuebleTasado) resultado = 1;

            return resultado;
        }
    }

    public class TasacionValorDESC : IComparer<TasacionBE>
    {
        public int Compare(TasacionBE? x, TasacionBE? y)
        {
            int resultado = 0;

            if (x.ValorInmuebleTasado < y.ValorInmuebleTasado) resultado = -1;
            else if (x.ValorInmuebleTasado > y.ValorInmuebleTasado) resultado = 1;

            return resultado * -1;
        }
    }

    public class TasacionFechaLejana : IComparer<TasacionBE>
    {
        public int Compare(TasacionBE? x, TasacionBE? y)
        {
            int resultado = 0;

            if (x.FechaHora.Date < y.FechaHora.Date) resultado = -1;
            else if (x.FechaHora.Date > y.FechaHora.Date) resultado = 1;

            return resultado;
        }
    }

    public class TasacionFechaCercana : IComparer<TasacionBE>
    {
        public int Compare(TasacionBE? x, TasacionBE? y)
        {
            int resultado = 0;

            if (x.FechaHora.Date < y.FechaHora.Date) resultado = -1;
            else if (x.FechaHora.Date > y.FechaHora.Date) resultado = 1;

            return resultado *-1;
        }
    }

    public class TasacionCobradaOrden : IComparer<TasacionBE>
    {
        public int Compare(TasacionBE? x, TasacionBE? y)
        {
            int resultado = 0;

            if (x.Estado.ToString() == "Cobrada" && y.Estado.ToString() == "Cancelada") resultado = -1;
            else if (x.Estado.ToString() == "Cancelada" && y.Estado.ToString() == "Cobrada") resultado = 1;
            
            return resultado;
        }
    }

    public class TasacionCanceladaOrden : IComparer<TasacionBE>
    {
        public int Compare(TasacionBE? x, TasacionBE? y)
        {
            int resultado = 0;

            if (x.Estado.ToString() == "Cobrada" && y.Estado.ToString() == "Cancelada") resultado = -1;
            else if (x.Estado.ToString() == "Cancelada" && y.Estado.ToString() == "Cobrada") resultado = 1;

            return resultado * -1;
        }
    }
}
