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
    public class InteraccionMapper
    {
        DAO dao = DAO.Instancia;
        static DataSet dataSet;
        static DataTable dtInteraccion;
        public InteraccionMapper()
        {
            dataSet = dao.ReturnDataset();
            dtInteraccion = dataSet.Tables["Interaccion"];
        }


        #region Interacciones

        public void AltaInteracción(InteraccionBE pInteraccion)
        {
            if (pInteraccion == null) throw new ArgumentException("Interacción NULL en Mapper.AltaInteracción()");
            try
            {
                DataRow drNuevaInteraccion = dtInteraccion.NewRow();
                drNuevaInteraccion.ItemArray = new object[]
                {
                    pInteraccion.ID,
                    pInteraccion.PropiedadID,
                    pInteraccion.Contacto,
                    pInteraccion.Detalles,
                    pInteraccion.Fecha,
                    pInteraccion.Interesado
                };
                dtInteraccion.Rows.Add(drNuevaInteraccion);
                dao.GrabarCambios();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void BajaInteraccion(int pID)
        {
            try
            {
                DataRow drBajaInteraccion = dtInteraccion.Rows.Find(pID);
                if (drBajaInteraccion == null) throw new Exception($"No se ha encontrado a ninguna interacción bajo el ID {pID}. Mapper.BajaInteraccion()");
                dtInteraccion.Rows.Remove(drBajaInteraccion);
                dao.GrabarCambios();
            }

            catch (Exception)
            {
                throw;
            }
        }

        public void ModificarInteraccion(InteraccionBE pInteraccion)
        {
            if (pInteraccion == null) throw new ArgumentException("Interacción NULL en Mapper.ModificarInteracción()");
            try
            {
                DataRow drInteraccion = dtInteraccion.Rows.Find(pInteraccion.ID);
                if (drInteraccion == null) throw new Exception($"No se ha encontrado a ninguna interacción bajo el ID {pInteraccion.ID}. Mapper.ModificarInteracción()");
                drInteraccion.ItemArray = new object[]
                {
                    drInteraccion.ItemArray[0],
                    pInteraccion.PropiedadID,
                    pInteraccion.Contacto,
                    pInteraccion.Detalles,
                    pInteraccion.Fecha,
                    pInteraccion.Interesado
                };
                dao.GrabarCambios();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<InteraccionBE> ConsultarInteracciones()
        {
            List<InteraccionBE> listaReturn = new List<InteraccionBE>();
            try
            {
                foreach (DataRow row in dtInteraccion.Rows)
                {
                    InteraccionBE interaccion = new InteraccionBE(row.ItemArray);
                    listaReturn.Add(interaccion);
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
