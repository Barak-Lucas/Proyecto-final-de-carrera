using L2BE;
using L4ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static ServicioGeneradorID.GeneradorID;

namespace L3BLL
{
    public class RolBLL
    {
         SistemaMapper sistemaMapper;
        public RolBLL()
        {
            sistemaMapper ??= new SistemaMapper();
        }

        public void Alta(PermisoCompuestoBE pRol)
        {
            try
            {
                pRol.ID = sistemaMapper.ObtenerIDPermiso();
                sistemaMapper.AltaRol(pRol);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Baja(int pRolID)
        {
            try
            {
                sistemaMapper.BajaPermiso(pRolID);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Modificar(Permiso pRol)
        {
            try
            {
                sistemaMapper.ModificarPermiso(pRol);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Permiso BuscarRol(int pRolID)
        {
            try
            {
                return sistemaMapper.BuscarPermiso(pRolID);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<PermisoCompuestoBE> ConsultarRoles()
        {
            try
            {
                return sistemaMapper.ConsultarRoles();
            }
            catch (Exception)
            {

                throw;
            }          
        }

        public List<PermisoCompuestoBE> ConsultarRolesDelUsuario(int pUsuarioID)
        {
            try
            {
                return sistemaMapper.ConsultarRolesUsuario(pUsuarioID);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void AsociarPermisoAlRol(int pRolID, int pPermisoID)
        {
            try
            {
                sistemaMapper.AsociarPermisoAlRol(pRolID, pPermisoID);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DesasociarPermisoDelrol(int pPermisoID, int pRolID)
        {
            try
            {
                sistemaMapper.DesasignarPermisoAlRol(pPermisoID, pRolID);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void AsociarRolAlUsuario(int pRolID, int pUsuarioID)
        {
            try
            {
                sistemaMapper.AsociarPermisoAlUsuario(pRolID, pUsuarioID);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DesasociarRolDelUsuario(int pRolID, int pUsuarioID)
        {
            try
            {
                sistemaMapper.DesasignarRolAUsuario(pRolID, pUsuarioID);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Permiso> ConsultarPermisosDeRol(int pRolID)
        {
            try
            {
                return sistemaMapper.ConsultarPermisosDeRol(pRolID);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Permiso> ConsultarRolesYPermisosDelUsuario(int pUsuarioID)
        {
            try
            {
                return sistemaMapper.ConsultarRolesYPermisosDelUsuario(pUsuarioID);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }


}
