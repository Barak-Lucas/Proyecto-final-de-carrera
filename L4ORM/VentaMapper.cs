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
    public class VentaMapper
    {
        DAO dao = DAO.Instancia;
        static DataSet dataSet;
        static DataTable dtVenta;
        public VentaMapper()
        {
 
            dataSet = dao.ReturnDataset();
            dtVenta = dataSet.Tables["Venta"];
        }

        #region Ventas

        public void AltaVenta(VentaBE pVenta)
        {
            if (pVenta == null) throw new ArgumentException("Venta NULL en Mapper.AltaVenta()");
            try
            {
                DataRow drNuevaVenta = dtVenta.NewRow();
                drNuevaVenta.ItemArray = new object[]
                {
                    pVenta.ID,
                    pVenta.CompradorID,
                    pVenta.VendedorID,
                    pVenta.PropiedadVendidaID,
                    pVenta.FechaVenta,
                    pVenta.PorcentajeComisionComprador,
                    pVenta.PorcentajeComisionVendedor,
                    pVenta.PrecioConvenido,

                };
                dtVenta.Rows.Add(drNuevaVenta);
                dao.GrabarCambios();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void BajaVenta(int pID)
        {
            try
            {
                DataRow drBajaVenta = dtVenta.Rows.Find(pID);
                if (drBajaVenta == null) throw new Exception($"No se ha encontrado a ninguna venta bajo el ID {pID}. Mapper.BajaVenta()");
                dtVenta.Rows.Remove(drBajaVenta);
                dao.GrabarCambios();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<VentaBE> ConsultarVentas()
        {
            List<VentaBE> listaReturn = new List<VentaBE>();

            if (dtVenta.Rows.Count == 0) return listaReturn;
            try
            {

                foreach (DataRow row in dtVenta.Rows)
                {
                    VentaBE venta = new VentaBE(row.ItemArray);
                    listaReturn.Add(venta);
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
