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
    public class BitacoraBLL
    {
        SistemaMapper sistemaMapper;
        public BitacoraBLL()
        {
            sistemaMapper ??= new SistemaMapper();
        }

        public void Backup(UsuarioBE pUsuario)
        {
            try
            {
                sistemaMapper.CrearBackup(pUsuario);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Restore(UsuarioBE pUsuario, string pNombreBackup)
        {
            try
            {
                sistemaMapper.Restore(pUsuario, pNombreBackup);
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        public List<BitacoraBE> ConsultarBitacora()
        {
            try
            {
                return sistemaMapper.ConsultarBitacora();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string[] ConsultarBackups()
        {
            try
            {
                return sistemaMapper.ConsultarBackups();
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
