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
    public class TasacionMapper
    {
        DAO dao = DAO.Instancia;
        static DataSet dataSet;
        static DataTable dtTasacion;

        public TasacionMapper()
        {
            dataSet = dao.ReturnDataset();
            dtTasacion = dataSet.Tables["Tasacion"];
        }


        #region Tasaciones

        public void AltaTasacion(TasacionBE pTasacion)
        {
            if (pTasacion == null) throw new ArgumentException("Tasacion NULL en Mapper.AltaTasacion()");
            try
            {

                DataRow drNuevaTasacion = dtTasacion.NewRow();
                drNuevaTasacion.ItemArray = new object[]
                {
                    pTasacion.ID,
                    pTasacion.PropietarioID,
                    pTasacion.Domicilio,
                    pTasacion.Estado,
                    pTasacion.FechaHora,
                    pTasacion.Localidad,
                    pTasacion.m2,
                    pTasacion.Observaciones,
                    pTasacion.PorcentajeComision,
                    pTasacion.TipoInmueble,
                    pTasacion.ValorInmuebleTasado
                };
                dtTasacion.Rows.Add(drNuevaTasacion);
                dao.GrabarCambios();

            }
            catch (Exception)
            {
                throw;
            }
        }

        public void BajaTasacion(int pID)
        {
            try
            {
                DataRow drBajaTasacion = dtTasacion.Rows.Find(pID);
                if (drBajaTasacion == null) throw new Exception($"No se ha encontrado a ninguna tasación bajo el ID {pID}. Mapper.BajaTasacion()");
                dtTasacion.Rows.Remove(drBajaTasacion);
                dao.GrabarCambios();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void ModificarTasacion(TasacionBE pTasacion)
        {
            try
            {
                if (pTasacion == null) throw new ArgumentException("Tasación NULL en Mapper.ModificarTasacion()");
                try
                {

                    DataRow drTasacion = dtTasacion.Rows.Find(pTasacion.ID);
                    if (drTasacion == null) throw new Exception($"No se ha encontrado a ninguna tasacion bajo el ID {pTasacion.ID}. Mapper.ModificarTasacion()");
                    drTasacion.ItemArray = new object[]
                    {
                        drTasacion.ItemArray[0],
                        pTasacion.PropietarioID,
                        pTasacion.Domicilio,
                        pTasacion.Estado.ToString(),
                        pTasacion.FechaHora,
                        pTasacion.Localidad,
                        pTasacion.m2,
                        pTasacion.Observaciones,
                        pTasacion.PorcentajeComision,
                        pTasacion.TipoInmueble.ToString(),
                        pTasacion.ValorInmuebleTasado
                        };

                    dao.GrabarCambios();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void LimpiarHistorialTasaciones()
        {
            try
            {
                dtTasacion.Clear();
                dao.GrabarCambios();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<TasacionBE> ConsultarTasaciones()
        {
            List<TasacionBE> listaReturn = new List<TasacionBE>();
            try
            {
                foreach (DataRow row in dtTasacion.Rows)
                {
                    TasacionBE tasacion = new TasacionBE(row.ItemArray);
                    listaReturn.Add(tasacion);
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
