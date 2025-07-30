using L2BE;
using L4ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static ServicioGeneradorID.GeneradorID;

namespace L3BLL
{
    public class PropiedadBLL
    {
        PropiedadMapper propiedadMapper;

        ContratoBLL contratoBLL;
        public PropiedadBLL()
        {
            propiedadMapper ??= new PropiedadMapper();
            contratoBLL = new ContratoBLL();
        }

        public void Alta(PropiedadBE pPropiedad)
        {
            try 
            {
                pPropiedad.ID = ObtenerProximoID(ConsultarPropiedades());
                propiedadMapper.AltaPropiedad(pPropiedad); 
            }
            catch (Exception)
            { throw; }
           
        }

        public void Baja(int pID)
        {
            try { propiedadMapper.BajaPropiedad(pID); }
            catch (Exception)
            { throw; }
        }

        public void Modificar(PropiedadBE pPropiedad)
        {
            try { propiedadMapper.ModificarPropiedad(pPropiedad); }
            catch (Exception)
            { throw; }
        }

        /// <summary>
        /// Devuelve las propiedades que se encuentren ACTIVAS. 
        /// </summary>
        /// <returns></returns>
        public List<PropiedadBE> ConsultarPropiedades()
        {
            try 
            {
                List<PropiedadBE> listaReturn = new List<PropiedadBE>();
                foreach (PropiedadBE propiedad in propiedadMapper.ConsultarPropiedades())
                {
                    ContratoBE cont = contratoBLL.BuscarContratoPropiedad(propiedad.ID);
                    propiedad.ContratoID = cont == null ? 0 : cont.ID;
                    listaReturn.Add(propiedad);
                    
                }
                return listaReturn; 
            }
            catch (Exception)
            { throw; }
        }

        public List<PropiedadBE> ConsultarPropiedadesPropietario(int pPropietarioID)
        {
            try
            {
                return ConsultarPropiedades().Where(p => p.PropietarioID == pPropietarioID).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
        
        public PropiedadBE BuscarPropiedad(int pPropiedadID)
        {
            try 
            {
                return ConsultarPropiedades().Find(p => p.ID == pPropiedadID);
            }
            catch (Exception)
            { throw; }
        }

        public string GetImgPortada(int pID)
        {
            try { return propiedadMapper.GetImgPortadaPropiedad(pID); }
            catch (Exception)
            { throw; }
        }

        public void SetImgPortada(int pID, string pRuta)
        {
            try { propiedadMapper.SetImgPortadaPropiedad(pID, pRuta); }
            catch (Exception)
            { throw; }
        }

        public void Vender(PropiedadBE pPropiedad)
        {
            try
            {
                pPropiedad.Estado = PropiedadBE.EstadosPropiedad.Vendida;
                Modificar(pPropiedad);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
