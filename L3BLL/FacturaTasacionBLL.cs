using L2BE;
using L4ORM;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ServicioGeneradorID.GeneradorID;

namespace L3BLL
{
    public class FacturaTasacionBLL
    {
         FacturaMapper facturaMapper;
        public FacturaTasacionBLL()
        {
            facturaMapper ??= new FacturaMapper();
        }

        /// <summary>
        /// Retorna el ID de la factura creada
        /// </summary>
        /// <param name="pFacturaTasacion"></param>
        /// <returns></returns>
        public int Alta(FacturaTasacionBE pFacturaTasacion)
        {
			try
            {
                pFacturaTasacion.ID = ObtenerProximoID(ConsultarFacturas());
                return facturaMapper.AltaFacturaTasacion(pFacturaTasacion); 
            }
            catch (Exception){throw;}
        }


        public FacturaTasacionBE BuscarFactura(TasacionBE pTasacionAsociada)
        {  
            try { return ConsultarFacturas().Find(f => f.TasacionAsociadaID == pTasacionAsociada.ID); }
            catch (Exception) { throw; }
        }

        public List<FacturaTasacionBE> ConsultarFacturas()
        {
            try
            {
                //TODO: RECUPERAR LA INFORMACIÓN DEL PROPIETARIO Y TASACIÓN ASOCIADA

                return facturaMapper.ConsultarFacturasTasacion();
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
