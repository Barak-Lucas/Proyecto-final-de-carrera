using L2BE;
using L4ORM;
using ServicioDeEncriptado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ServicioGeneradorID.GeneradorID;

namespace L3BLL
{
    
    public class UsuarioBLL
    {
         SistemaMapper sistemaMapper;

        public UsuarioBLL()
        {
            if (sistemaMapper == null)
            {
                sistemaMapper = new SistemaMapper();
            }
            
        }

        public void Alta(UsuarioBE pUsuario)
        {
            try
            {
                pUsuario.ID = ObtenerProximoID(ConsultarUsuarios());
                sistemaMapper.AltaUsuario(pUsuario);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Baja(int pUsuarioID)
        {
            try
            {
                sistemaMapper.BajaUsuario(pUsuarioID);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Reactivar(int pUsuarioID)
        {
            try
            {
                sistemaMapper.ReactivarUsuario(pUsuarioID);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void Modificar(UsuarioBE pUsuario)
        {
            try
            {
                pUsuario.Contraseña = Encriptador.Encriptar(pUsuario.Contraseña);
                sistemaMapper.ModificarUsuario(pUsuario);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public UsuarioBE? BuscarUsuario(int pUsuarioID)
        {
            try
            {
                List<UsuarioBE> usuarios = sistemaMapper.ConsultarUsuarios();
                if (usuarios.Count == 0)
                {
                    return null;
                }
                return usuarios.Find(u => u.ID == pUsuarioID);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public UsuarioBE? BuscarUsuario(string pNombreUsuario)
        {
            try
            {
                List<UsuarioBE> usuarios = sistemaMapper.ConsultarUsuarios();
                if (usuarios.Count == 0)
                {
                    return null;
                }
                return usuarios.Find(u => u.NombreUsuario.ToLower() == pNombreUsuario.ToLower());
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void BloquearDesbloquear(UsuarioBE pUsuario)
        {
            try
            {
                pUsuario.Bloqueado = !pUsuario.Bloqueado;
                sistemaMapper.ModificarUsuario(pUsuario);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<UsuarioBE> ConsultarUsuarios()
        {
            try
            {
                return sistemaMapper.ConsultarUsuarios();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Login(UsuarioBE pUsuario, string pContraseña)
        {
            if (Encriptador.Desencriptar(pUsuario.Contraseña) != pContraseña)
            {
                return false;
            }
            return true;
        }
    }
}
