using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using L2BE;

namespace ServicioGeneradorID
{
    public static class GeneradorID
    {

        /// <summary>
        /// Obtiene el ID que debería ser aplicado al cliente que se está creando.
        /// </summary>
        /// <returns></returns>
        public static int ObtenerProximoID<T>(List<T> pLista) where T : Entidad
        {
            try
            {
                int idReturn = pLista.Count > 0 ? pLista.Max(c => c.ID) + 1 : 1;
                return idReturn;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
