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
    public class ContratoMapper
    {
        DAO dao = DAO.Instancia;
        static DataSet dataSet;
        static DataTable dtContrato;
        public ContratoMapper()
        {
            dataSet = dao.ReturnDataset();
            dtContrato = dataSet.Tables["Contrato"];
        }

        #region Contratos
        public int AltaContrato(ContratoBE pContrato)
        {
            if (pContrato == null) throw new ArgumentException("Contrato NULL en Mapper.AltaContrato()");
            try
            {
                DataRow drNuevoContrato = dtContrato.NewRow();
                drNuevoContrato.ItemArray = new object[]
                {
                    pContrato.ID,
                    pContrato.PropietarioID,
                    pContrato.PropiedadID,
                    pContrato.NombreConyugue,
                    pContrato.DNIConyugue,
                    pContrato.FechaInicio,
                    pContrato.FechaVencimiento,
                    pContrato.Estado,
                    pContrato.PrecioUSD
                };

                dtContrato.Rows.Add(drNuevoContrato);
                dao.GrabarCambios();
                return (int)drNuevoContrato.ItemArray[0];
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void BajaContrato(int pID)
        {
            try
            {
                DataRow drBajaContrato = dtContrato.Rows.Find(pID);
                if (drBajaContrato == null) throw new Exception($"No se ha encontrado a ningún contrato bajo el ID {pID}. Mapper.BajaContrato()");
                dtContrato.Rows.Remove(drBajaContrato);
                dao.GrabarCambios();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<ContratoBE> ConsultarContratos()
        {
            if (dtContrato.Rows.Count == 0) return new List<ContratoBE>();
            List<ContratoBE> listaReturn = new List<ContratoBE>();
            try
            {
                foreach (DataRow row in dtContrato.Rows)
                {
                    listaReturn.Add(new ContratoBE(row.ItemArray));
                }
                return listaReturn;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Reemplazando al "ActualizarEstado"
        /// </summary>
        /// <param name="pContrato"></param>
        public void ModificarContrato(ContratoBE pContrato)
        {
            try
            {
                DataRow drContrato = dtContrato.Rows.Find(pContrato.ID);
                if (drContrato == null) throw new Exception($"No se ha encontrado a ningún contrato bajo el ID {pContrato.ID}. Mapper.RenovarContrato()");
                drContrato["Estado"] = pContrato.Estado.ToString();
                drContrato["FechaInicio"] = pContrato.FechaInicio;
                drContrato["FechaVencimiento"] = pContrato.FechaVencimiento;
                drContrato["ValorVentaUSD"] = pContrato.PrecioUSD;
                dao.GrabarCambios();
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion
    }
}
