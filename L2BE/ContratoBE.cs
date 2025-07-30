    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2BE
{
    public class ContratoBE : Entidad
    {
        public int  PropietarioID { get; set; }

        public int PropiedadID { get; set; }

        public string? NombreConyugue { get; set; }

        public string? DNIConyugue { get; set; }   

        public DateTime FechaInicio { get; set; }

        public DateTime FechaVencimiento
        {
            get { return FechaInicio.AddDays(90); }
        }


        public EstadoContrato Estado { get; set; }

        public decimal PrecioUSD { get; set; }


        public enum EstadoContrato
        {
            Vigente,
            Renovar, 
            Cancelado,
            Finalizado
        }

        public ContratoBE()
        {
            
        }

        public ContratoBE(int pPropietario, int pPropiedad, string pNombreConyugue, string pDNIConyugue, DateTime pFechaInicio, decimal pPrecioUSD)
        {
            this.PropietarioID = pPropietario;
            this.PropiedadID = pPropiedad;
            this.NombreConyugue = string.IsNullOrEmpty(pNombreConyugue) ? "N|A" : pNombreConyugue;
            this.DNIConyugue = string.IsNullOrEmpty(pDNIConyugue) ? "N|A": pDNIConyugue;
            this.FechaInicio = pFechaInicio;
            this.PrecioUSD = pPrecioUSD;
            this.Estado = EstadoContrato.Vigente;
            
        }

        public ContratoBE(object[] pItemArray): this((int)pItemArray[1], (int)pItemArray[2], (string)pItemArray[3], (string)pItemArray[4], Convert.ToDateTime(pItemArray[5]), Convert.ToDecimal(pItemArray[8]))
        {
            this.ID = (int)pItemArray[0];
            this.Estado = Enum.Parse<EstadoContrato>((string)pItemArray[7]);
        }

    }
}
