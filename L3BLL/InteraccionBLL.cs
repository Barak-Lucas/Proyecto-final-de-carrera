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
    public class InteraccionBLL
    {
         InteraccionMapper interaccionMapper;

        public InteraccionBLL()
        {
            interaccionMapper ??= new InteraccionMapper();
        }

        public void Alta(InteraccionBE pInteracción)
        {
            try
            {
                pInteracción.ID = ObtenerProximoID(ConsultarInteracciones());
                interaccionMapper.AltaInteracción(pInteracción);
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
                interaccionMapper.BajaInteraccion(pID);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<InteraccionBE> ConsultarInteracciones()
        {
            try
            {
                return interaccionMapper.ConsultarInteracciones();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public InteraccionBE BuscarInteraccion(int pInteraccionID)
        {
            try
            {
                return interaccionMapper.ConsultarInteracciones().Find( i => i.ID == pInteraccionID);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Modificar(InteraccionBE pInteracción)
        {
            try
            {
                interaccionMapper.ModificarInteraccion(pInteracción);
            }
            catch (Exception)
            {
                throw;
            }
        }   
    }
}
