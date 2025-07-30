using L2BE;
using L5DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static L2BE.TasacionBE;

namespace L4ORM
{
    public class VisitaMapper
    {
        DAO dao = DAO.Instancia;
        static DataSet dataSet;
        static DataTable dtVisita;
        public VisitaMapper()
        {
            dataSet = dao.ReturnDataset();
            dtVisita = dataSet.Tables["Visita"];
        }

        #region Visitas

        public void AltaVisita(VisitaBE pVisita)
        {
            if (pVisita == null) throw new ArgumentException("Visita NULL en Mapper.AltaVisita()");
            try
            {
                if (dtVisita.AsEnumerable().Any(row => row.Field<int>("ClienteID") == pVisita.VisitanteID && row.Field<int>("PropiedadID") == pVisita.PropiedadID && row.Field<string>("Estado") == "Pendiente"))
                {
                    throw new Exception($"Ya existe una visita pendiente para el cliente {pVisita.VisitanteID} y la propiedad {pVisita.PropiedadID}.");
                }

                DataRow drNuevaVisita = dtVisita.NewRow();
                drNuevaVisita.ItemArray = new object[]
                {
                    pVisita.ID,
                    pVisita.VisitanteID,
                    pVisita.PropiedadID,
                    pVisita.FechaHora,
                    pVisita.Estado.ToString(),
                    pVisita.ComentariosVisita
                };
                dtVisita.Rows.Add(drNuevaVisita);
                dao.GrabarCambios();

            }
            catch (Exception)
            {
                throw;
            }
        }

        public void BajaVisita(int pID)
        {
            try
            {
                DataRow drBajaVisita = dtVisita.Rows.Find(pID);
                if (drBajaVisita == null) throw new Exception($"No se ha encontrado a ninguna visita bajo el ID {pID}. Mapper.BajaVisita()");
                dtVisita.Rows.Remove(drBajaVisita);
                dao.GrabarCambios();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void ModificarVisita(VisitaBE pVisita)
        {
            if (pVisita == null) throw new ArgumentException("Visita NULL en Mapper.ModificarVisita()");
            try
            {
                

                DataRow drVisita = dtVisita.Rows.Find(pVisita.ID);
                if (drVisita == null) throw new Exception($"No se ha encontrado a ninguna visita bajo el ID {pVisita.ID}. Mapper.ModificarVisita()");
                drVisita.ItemArray = new object[]
                {
                    drVisita.ItemArray[0],
                    pVisita.VisitanteID,
                    pVisita.PropiedadID,
                    pVisita.FechaHora,
                    pVisita.Estado.ToString(),
                    pVisita.ComentariosVisita
                };
                dao.GrabarCambios();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<VisitaBE> ConsultarVisitas()
        {
            List<VisitaBE> listaReturn = new List<VisitaBE>();
            try
            {
                foreach (DataRow row in dtVisita.Rows)
                {
                    VisitaBE visita = new VisitaBE(row.ItemArray);
                    listaReturn.Add(visita);
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
