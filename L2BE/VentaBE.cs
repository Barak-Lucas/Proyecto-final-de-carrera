using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2BE
{
    public class VentaBE : Entidad
    {

        public int VendedorID { get; set; }

        public int CompradorID { get; set; }

        public int PropiedadVendidaID { get; set; }

        public decimal PorcentajeComisionComprador
        {
            get { return 0.03m; }
        }

        public decimal PorcentajeComisionVendedor
        {
            get { return 0.01m; }
        }

        public DateTime FechaVenta { get; set; }

        public decimal PrecioConvenido { get; set; }


        public VentaBE()
        {
            
        }

        public VentaBE(ClienteBE pVendedor, ClienteBE pComprador, PropiedadBE pPropiedadVendida, DateTime pFechaVenta, decimal pPrecioConvenido)
        {
            this.VendedorID = pVendedor.ID;
            this.CompradorID = pComprador.ID;
            this.PropiedadVendidaID = pPropiedadVendida.ID;
            this.PrecioConvenido = pPrecioConvenido;
            this.FechaVenta = pFechaVenta;
        }

        public VentaBE(object[] pItemArray) 
        {
            this.ID = (int)pItemArray[0]; 
            this.CompradorID = (int)pItemArray[1];
            this.VendedorID = (int)pItemArray[2];
            this.PropiedadVendidaID = (int)pItemArray[3];
            this.FechaVenta = Convert.ToDateTime(pItemArray[4]);
            this.PrecioConvenido = (decimal)pItemArray[7];
        }


    }
}
