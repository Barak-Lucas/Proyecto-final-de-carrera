using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace L2BE
{

    public class FacturaVentaBE : Entidad
    {
        public int VentaAsociadaID { get; set; }

        public int CompradorID { get; set; }

        public int VendedorID { get; set; }

        public DateTime Fecha { get; private set; }

        public decimal ImporteComprador { get; set; }

        public decimal  ImporteVendedor { get; set; }

        public decimal IvaComprador { get => ImporteComprador * 0.21m; }

        public decimal IvaVendedor { get => ImporteVendedor * 0.21m; }

        public  decimal TotalComprador { get => ImporteComprador + IvaComprador; }

        public decimal TotalVendedor { get => ImporteVendedor + IvaVendedor; }

        public string Detalles { get; private set; }


        public FacturaVentaBE()
        {

        }

        public FacturaVentaBE(VentaBE pVenta, string pDetalles) :this()
        {
            this.VentaAsociadaID = pVenta.ID;
            this.Fecha = DateTime.Now;
            this.CompradorID = pVenta.CompradorID;
            this.VendedorID = pVenta.VendedorID;
            this.ImporteVendedor = (pVenta.PrecioConvenido) * pVenta.PorcentajeComisionVendedor;
            this.ImporteComprador = (pVenta.PrecioConvenido) * pVenta.PorcentajeComisionComprador;
            this.Detalles = pDetalles;
        }

        public FacturaVentaBE(object[] pItemArray)
        {
            this.ID = (int)pItemArray[0];
            this.VendedorID = (int)pItemArray[1];
            this.CompradorID = (int)pItemArray[2];
            this.VentaAsociadaID = (int)pItemArray[3];
            this.Detalles = (string)pItemArray[4];
            this.Fecha = Convert.ToDateTime(pItemArray[5]);
            this.ImporteVendedor = Convert.ToDecimal(pItemArray[6]);
            this.ImporteComprador = Convert.ToDecimal(pItemArray[7]);
        }

    }

    public class FacturaTasacionBE : Entidad
    {
        public  string? Observaciones { get; set; }

        public DateTime Fecha { get; set; }

        public int PropietarioID { get; set; }

        public int TasacionAsociadaID { get; set; }

        public decimal Importe { get; set; }

        public  decimal IVA { get => Importe * 0.21m; }

        public  decimal Total { get => Importe + IVA; }

        public FacturaTasacionBE()
        {

        }

        public FacturaTasacionBE(ClienteBE pPropietario, TasacionBE pTasacion, string pObservaciones, decimal pValorDolar)
        {
            this.PropietarioID = pPropietario.ID;
            this.TasacionAsociadaID = pTasacion.ID;
            this.Observaciones = pObservaciones;
            this.Fecha = DateTime.Now;
            this.Importe = (pTasacion.ValorInmuebleTasado * pTasacion.PorcentajeComision) * pValorDolar;
        }

        public FacturaTasacionBE(object[] pItemArray)
        {
            this.ID = (int)pItemArray[0];
            this.TasacionAsociadaID = (int)pItemArray[1];
            this.PropietarioID = (int)pItemArray[2];
            this.Fecha = Convert.ToDateTime(pItemArray[3]);
            this.Importe = Convert.ToDecimal(pItemArray[4]);
            this.Observaciones = pItemArray[6].ToString();
        }
    }
}
