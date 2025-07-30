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
    public class FacturaVentaBLL
    {
        FacturaMapper facturaMapper;
        public FacturaVentaBLL()
        {
            facturaMapper ??= new FacturaMapper();
        }

        public int Alta(FacturaVentaBE pFacturaVenta)
        {
            
            try
            {
                pFacturaVenta.ID = ObtenerProximoID(ConsultarFacturas());
                return facturaMapper.AltaFacturaVenta(pFacturaVenta);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Baja(int pID)
        {
            try
            {
                facturaMapper.BajaFacturaVenta(pID);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<FacturaVentaBE> ConsultarFacturas()
        {
            try
            {
                return facturaMapper.ConsultarFacturasVentas();
            }
            catch (Exception)
            {
                throw;
            }
        }

        
    }
}
