using L2BE;
using L4ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Estados = L2BE.ContratoBE.EstadoContrato;
using static ServicioGeneradorID.GeneradorID;

namespace L3BLL
{
    public class ContratoBLL
    {
         ContratoMapper contratoMapper;

        public ContratoBLL()
        {
            contratoMapper ??= new ContratoMapper();
        }

        /// <summary>
        /// Crea un nuevo contrato en la base de datos y retorna el ID del datarow creado.
        /// </summary>
        /// <param name="pContrato"></param>
        /// <returns>el ID del nuevo contrato</returns>
        public int Alta(ContratoBE pContrato)
        {
            try
            {
                pContrato.ID = ObtenerProximoID(ConsultarContratos());
                return contratoMapper.AltaContrato(pContrato); 
            }
            catch (Exception){ throw; }
        }

        public void Baja(int pContratoID)
        {
            try{ contratoMapper.BajaContrato(pContratoID); }
            catch (Exception){ throw; }
        }

        public void ActualizarEstado(int pContratoID, Estados pNuevoEstado)
        {
            try
            {
                ContratoBE contrato = BuscarContrato(pContratoID);
                contrato.Estado = pNuevoEstado;
                contratoMapper.ModificarContrato(contrato); 
            }
            catch (Exception){throw;}
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pContrato">El contrato con el nuevo valor y fecha de vencimiento</param>
        public void Renovar(ContratoBE pContrato)
        {
            try{contratoMapper.ModificarContrato(pContrato);}
            catch (Exception) { throw; }
        }

        public List<ContratoBE> ConsultarContratos()
        {
            try
            {
                List<ContratoBE> contratosReturn = contratoMapper.ConsultarContratos();
                foreach (ContratoBE contrato in contratosReturn)
                {
                    if (contrato.Estado != Estados.Cancelado && contrato.Estado != Estados.Finalizado)
                    {
                        TimeSpan diferencia = contrato.FechaVencimiento - DateTime.Now;
                        int diasRestantes = diferencia.Days;

                        if (diasRestantes <= 0)
                        {
                            contrato.Estado = Estados.Renovar;
                            contratoMapper.ModificarContrato(contrato);
                        }
                        else
                        {
                            contrato.Estado = Estados.Vigente;
                        }

                    }
                }
                return contratosReturn; 
            }
            catch (Exception) { throw; }
        }


        public ContratoBE BuscarContrato(int pContratoID)
        {
            try 
            {
                List<ContratoBE> contratos = contratoMapper.ConsultarContratos();
                return contratos.Find(c => c.ID == pContratoID); 
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// Retorna el contrato activo (Vigente o Renovar) de la propiedad o NULL si no tiene ninguno activo
        /// </summary>
        /// <param name="pPropiedadID"></param>
        /// <returns></returns>
        public ContratoBE BuscarContratoPropiedad(int pPropiedadID)
        {
            try
            {
                List<ContratoBE> contratos = contratoMapper.ConsultarContratos();
                return contratos.Find(c => c.PropiedadID == pPropiedadID && (c.Estado != Estados.Cancelado || c.Estado != Estados.Finalizado));
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
