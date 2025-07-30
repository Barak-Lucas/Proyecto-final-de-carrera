using L2BE;
using L4ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estados = L2BE.VisitaBE.EstadosVisita;
using static ServicioGeneradorID.GeneradorID;

namespace L3BLL
{
    public class VisitaBLL
    {
        VisitaMapper visitaMapper;
        PropiedadBLL bllPropiedad ;
        public VisitaBLL()
        {
            visitaMapper ??= new VisitaMapper();
            bllPropiedad ??= new PropiedadBLL();
        }

        public void Alta(VisitaBE pVisita)
        {
            try
            {

                PropiedadBE propiedad = bllPropiedad.BuscarPropiedad(pVisita.PropiedadID);

                if (propiedad.PropietarioID == pVisita.VisitanteID) 
                    throw new Exception($"El cliente no puede visitar su propia propiedad.");

                pVisita.ID = ObtenerProximoID(ConsultarVisitas());
                visitaMapper.AltaVisita(pVisita); 
            }
            catch (Exception ) { throw ; }
        }

        public void Baja(int pID)
        {
            try { visitaMapper.BajaVisita(pID); }
            catch (Exception ) { throw ; }
        }

        public void VisitaRealizada(VisitaBE pVisita)
        {
            try
            {
                pVisita.Estado = VisitaBE.EstadosVisita.Realizada;
                visitaMapper.ModificarVisita(pVisita);
            }
            catch (Exception) { throw; }
        }

        public void Cancelar(VisitaBE pVisita)
        {
            try 
            {
                pVisita.Estado = VisitaBE.EstadosVisita.Cancelada; 
                visitaMapper.ModificarVisita(pVisita); 
            }
            catch (Exception ) { throw ; }
        }

        public void Modificar(VisitaBE pVisita)
        {
            try 
            {
                if (pVisita.Estado != Estados.Realizada || pVisita.Estado != Estados.Cancelada)
                {
                    if (ConsultarVisitas().Any(v => v.FechaHora == pVisita.FechaHora &&
                                               v.VisitanteID == pVisita.VisitanteID &&
                                               v.PropiedadID == pVisita.PropiedadID))
                    {
                        throw new Exception($"Ya existe una visita pendiente para el cliente {pVisita.VisitanteID} y la propiedad {pVisita.PropiedadID} a esa hora y fecha.");
                    }
                }
                visitaMapper.ModificarVisita(pVisita); 
            }
            catch (Exception ) { throw ; }
        }

        public List<VisitaBE> ConsultarVisitas()
        {          
            try { return visitaMapper.ConsultarVisitas(); }
            catch (Exception ) { throw ; }
        }

        public List<VisitaBE> ConsultarVisitas(Estados pEstado)
        {
            List<VisitaBE> visitasReturn = new List<VisitaBE>();
            try
            {
                foreach(VisitaBE visita in visitaMapper.ConsultarVisitas())
                {
                    if(visita.Estado == pEstado)
                    {
                        visitasReturn.Add(visita);
                    }
                }
                return visitasReturn;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public VisitaBE BuscarVisita(int pID)
        {
            try { return visitaMapper.ConsultarVisitas().Find(v => v.ID == pID); }
            catch (Exception ) { throw ; }
        }
    }
}
