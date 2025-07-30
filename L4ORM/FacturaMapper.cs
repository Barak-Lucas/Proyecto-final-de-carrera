using L2BE;
using L5DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4ORM
{
    public class FacturaMapper
    {
        DAO dao = DAO.Instancia;
        static DataSet dataSet;
        static DataTable dtFacturaVenta, dtFacturaTasacion;

        public FacturaMapper()
        {
            dataSet = dao.ReturnDataset();
            dtFacturaVenta = dataSet.Tables["FacturaVenta"];
            dtFacturaTasacion = dataSet.Tables["FacturaTasacion"];
        }

        #region FacturaTasacion

        public int AltaFacturaTasacion(FacturaTasacionBE pFactura)
        {
            if (pFactura == null) throw new ArgumentException("Factura NULL en Mapper.AltaFacturaTasacion()");
           
            try
            {
                DataRow drNuevaFactura = dtFacturaTasacion.NewRow();
                drNuevaFactura.ItemArray = new object[]
                {
                    pFactura.ID,
                    pFactura.TasacionAsociadaID,
                    pFactura.PropietarioID,
                    pFactura.Fecha,
                    pFactura.Importe,
                    pFactura.IVA,
                    pFactura.Observaciones,
                    pFactura.Total,
                };

                dtFacturaTasacion.Rows.Add(drNuevaFactura);
                dao.GrabarCambios();

                return (int)drNuevaFactura["ID"];
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<FacturaTasacionBE> ConsultarFacturasTasacion()
        {
            List<FacturaTasacionBE> listaReturn = new List<FacturaTasacionBE>();
            try
            {
                foreach (DataRow row in dtFacturaTasacion.Rows)
                {
                    FacturaTasacionBE factura = new FacturaTasacionBE(row.ItemArray);
                    listaReturn.Add(factura);
                }
                return listaReturn;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion


        #region FacturasVenta
        public int AltaFacturaVenta(FacturaVentaBE pFactura)
        {
            if (pFactura == null) throw new ArgumentException("Venta NULL en Mapper.AltaFacturaVenta()");

            try
            {
                DataRow drNuevaFactura = dtFacturaVenta.NewRow();
                drNuevaFactura.ItemArray = new object[]
                {
                    pFactura.ID,
                    pFactura.CompradorID,
                    pFactura.VendedorID,
                    pFactura.VentaAsociadaID,
                    pFactura.Detalles,
                    pFactura.Fecha,
                    pFactura.ImporteComprador,
                    pFactura.ImporteVendedor,
                    pFactura.IvaComprador,
                    pFactura.IvaVendedor,
                    pFactura.TotalComprador,
                    pFactura.TotalVendedor

                };
                dtFacturaVenta.Rows.Add(drNuevaFactura);
                dao.GrabarCambios();
                return pFactura.ID;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void BajaFacturaVenta(int pID)
        {
            try
            {
                DataRow drBajaFactura = dtFacturaVenta.Rows.Find(pID);
                if (drBajaFactura == null) throw new Exception($"No se ha encontrado a ninguna factura de venta bajo el ID {pID}. Mapper.BajaFacturaVenta()");
                dtFacturaVenta.Rows.Remove(drBajaFactura);
                dao.GrabarCambios();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<FacturaVentaBE> ConsultarFacturasVentas()
        {
            List<FacturaVentaBE> listaReturn = new List<FacturaVentaBE>();
            try
            {
                foreach (DataRow row in dtFacturaVenta.Rows)
                {
                    FacturaVentaBE factura = new FacturaVentaBE(row.ItemArray);
                    listaReturn.Add(factura);
                }
                return listaReturn;
            }
            catch (Exception)
            {
                throw;
            }

        }

        #endregion
    }
}
