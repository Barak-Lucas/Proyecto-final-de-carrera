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
    public class ClienteBLL
    {
        ClienteMapper clienteMapper;
        VentaBLL bllVenta ;
        VisitaBLL bllVisita;
        public ClienteBLL()
        {
            clienteMapper ??= new ClienteMapper();  
            bllVenta ??= new VentaBLL();
            bllVisita ??= new VisitaBLL();
        }

        /// <summary>
        /// Da de alta un nuevo cliente o reactiva al cliente existente bajo el DNI proporcionado.
        /// </summary>
        /// <param name="pCliente"></param>
        /// <returns>Retorna false si el alta del cliente fue de 0 y retorna true si el cliente ya existía y fue reactivado</returns>
        public bool Alta(ClienteBE pCliente)
        {
            try 
            {

                ClienteBE clienteExistente = clienteMapper.ConsultarClientes().Find(c => c.DNI == pCliente.DNI);
                if (clienteExistente != null && clienteExistente.Activo)
                    throw new Exception("Ya existe un cliente activo con ese DNI");

                if(clienteExistente != null && !clienteExistente.Activo)
                {
                    clienteExistente.Activo = true;
                    clienteMapper.ModificarCliente(clienteExistente);
                    return true;
                }
                else
                {
                    pCliente.ID = ObtenerProximoID(clienteMapper.ConsultarClientes());
                    clienteMapper.AltaCliente(pCliente);
                    return false;
                }
            }
            catch (Exception) { throw; }
        }

        public void Baja(int pClienteID)
        {
            try { clienteMapper.BajaCliente(pClienteID); }
            catch (Exception) { throw; }
        }

        public void Modificar(ClienteBE pCliente)
        {
            try { clienteMapper.ModificarCliente(pCliente); }
            catch (Exception) { throw; }
        }

        public List<VentaBE> VentasDelCliente(int pVendedorID)
        {
            try
            {
                List<VentaBE> ventas = bllVenta.ConsultarVentas();
                if (ventas.Count > 0)
                    return ventas.Where(v => v.VendedorID == pVendedorID).ToList();
                return new List<VentaBE>();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<VentaBE> ComprasDelCliente(int pCompradorID)
        {
            try
            {
                List<VentaBE> ventas = bllVenta.ConsultarVentas();
                if (ventas.Count > 0)
                    return ventas.Where(v => v.CompradorID == pCompradorID).ToList();
                return new List<VentaBE>();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<VisitaBE> VisitasDelCliente(int pClienteID)
        {
            try
            {
                List<VisitaBE> visitas = bllVisita.ConsultarVisitas() ;
                if (visitas.Count > 0)
                    return visitas.Where(v => v.VisitanteID == pClienteID).ToList();
                return new List<VisitaBE>();
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Devuelve una lista de todos los clientes (propietarios y clientes) que se encuentren activos.
        /// </summary>
        /// <returns></returns>
        public List<ClienteBE> ConsultarTodosLosClientes()
        {
            try 
            {
                return clienteMapper.ConsultarClientes().Where(c => c.Activo).ToList(); 
            }
            catch (Exception) { throw; }
        }

        public ClienteBE BuscarCliente(int pClienteID)
        {
            try
            {
                List<ClienteBE> listaClientes = clienteMapper.ConsultarClientes();
                return listaClientes.Find(c => c.ID == pClienteID);
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// Devuelve los propietarios activos
        /// </summary>
        /// <returns></returns>
        public List<ClienteBE> ConsultarPropietarios()
        {
            try 
            {
                return clienteMapper.ConsultarClientes().Where(c => c.Propietario && c.Activo).ToList();               
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// Devuelve los no propietarios activos
        /// </summary>
        /// <returns></returns>
        public List<ClienteBE> ConsultarNoPropietarios()
        {
            try
            {
                return clienteMapper.ConsultarClientes().Where(c => !c.Propietario && c.Activo).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
