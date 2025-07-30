using L2BE;
using L4ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ServicioGeneradorID.GeneradorID;
namespace L3BLL
{
    public class VentaBLL
    {
        VentaMapper ventaMapper;
        FacturaVentaBLL bllFactura ;

        public VentaBLL()
        {
            ventaMapper ??= new VentaMapper();
            bllFactura ??= new FacturaVentaBLL();
        }

        public void Alta(VentaBE pVenta)
        {
            try
            {
                pVenta.ID = ObtenerProximoID(ConsultarVentas());
                ventaMapper.AltaVenta(pVenta);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<VentaBE> ConsultarVentas()
        {
            try
            {
                return ventaMapper.ConsultarVentas();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public VentaBE BuscarVenta(int pVentaID)
        {
            try
            {
                return ConsultarVentas().Find(v => v.ID == pVentaID);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Baja(int pVentaID)
        {
            try
            {
                ventaMapper.BajaVenta(pVentaID);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public FacturaVentaBE? FacturaAsociada(VentaBE pVenta)
        {
            try
            {
                FacturaVentaBE factura = bllFactura.ConsultarFacturas().Find(f => f.VentaAsociadaID == pVenta.ID);
                return factura ?? null;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
