using L2BE;
using L4ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3BLL
{
    public class PermisoBLL
    {
         SistemaMapper sistemaMapper;

        public PermisoBLL()
        {
            sistemaMapper ??= new SistemaMapper();
        }

        public void Alta(PermisoCompuestoBE pPermiso)
        {
            try
            {
                sistemaMapper.AltaPermiso(pPermiso);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Baja(int pPermisoID)
        {            
            try
            {
                sistemaMapper.BajaPermiso(pPermisoID);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Permiso BuscarPermiso(int pPermisoID)
        {
            try
            {
                return sistemaMapper.BuscarPermiso(pPermisoID);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<PermisoCompuestoBE> ConsultarPermisos()
        {
            try
            {
                return sistemaMapper.ConsultarTodosLosPermisos();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void AsociarPermisoAlUsuario(int pPermisoID, int pUsuarioID)
        {
            try
            {
                sistemaMapper.AsociarPermisoAlUsuario(pPermisoID, pUsuarioID);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DesasociarPermisoDelUsuario(int pPermisoID, int pUsuarioID)
        {
            try
            {
                sistemaMapper.DesasignarPermisoAlUsuario(pPermisoID, pUsuarioID);
            }
            catch (Exception)
            {

                throw;
            }
        }
       
    }
}
