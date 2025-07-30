using L2BE;
using L4ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static L2BE.TasacionBE;
using Estados = L2BE.TasacionBE.Estados;
using static ServicioGeneradorID.GeneradorID;

namespace L3BLL
{
    public class TasacionBLL
    {
         TasacionMapper tasacionMapper;

        public TasacionBLL()
        {
            tasacionMapper ??= new TasacionMapper();
        }

        public void Alta(TasacionBE pTasacion)
        {
            try
            {
                pTasacion.ID = ObtenerProximoID(ConsultarTasaciones());
                tasacionMapper.AltaTasacion(pTasacion);
            }
            catch (Exception){throw;}
        }

        public void Cobrar(TasacionBE pTasacion, string pDetalles)
        {
            pTasacion.Estado = Estados.Cobrada;
            pTasacion.Observaciones = pDetalles;
            try { tasacionMapper.ModificarTasacion(pTasacion); }
            catch (Exception) { throw; }
        }

        public void Cancelar(TasacionBE pTasacion)
        {
            try
            {
                pTasacion.Estado = Estados.Cancelada;
                tasacionMapper.ModificarTasacion(pTasacion);
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
                tasacionMapper.BajaTasacion(pID);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void LimpiarHistorial()
        {
            try
            {
                tasacionMapper.LimpiarHistorialTasaciones();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Modificar(TasacionBE pTasacion)
        {
            try
            {
                if (ConsultarTasaciones().Any(t => t.FechaHora == pTasacion.FechaHora) && (pTasacion.Estado != Estados.Cobrada || pTasacion.Estado != Estados.Cancelada))
                    throw new Exception($"Ya existe una tasacion el día {pTasacion.FechaHora.Date} a las {pTasacion.FechaHora.TimeOfDay} para el cliente {pTasacion.PropietarioID}");
                tasacionMapper.ModificarTasacion(pTasacion);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<TasacionBE> ConsultarTasaciones(IComparer<TasacionBE> pOrdenamiento = null)
        {
            try
            {
                List<TasacionBE> lista = tasacionMapper.ConsultarTasaciones();
                if(pOrdenamiento != null) lista.Sort(pOrdenamiento);
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<TasacionBE> ConsultarTasaciones(Estados pEstado)
        {
            try
            {
                List<TasacionBE> listaReturn = new List<TasacionBE>();
                foreach (TasacionBE tasacion in tasacionMapper.ConsultarTasaciones())
                {
                    if (tasacion.Estado == pEstado)
                    {
                        listaReturn.Add(tasacion);
                    }
                }
                return listaReturn;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public TasacionBE BuscarTasacion(int pTasacionID)
        {
            try
            {
                return tasacionMapper.ConsultarTasaciones().Find(t => t.ID == pTasacionID);
            }
            catch (Exception)
            {

                throw;
            }
        }



    }
}
