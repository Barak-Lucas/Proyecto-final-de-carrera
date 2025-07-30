using L2BE;
using L5DAO;
using System.Data;

namespace L4ORM
{
    public class ClienteMapper
    {
        DAO dao = DAO.Instancia;
        static DataSet dataSet;
        static DataTable dtCliente;
        public ClienteMapper()
        {
            
            dataSet = dao.ReturnDataset();
            dtCliente = dataSet.Tables["Cliente"];
        }

        #region Clientes

        public void AltaCliente(ClienteBE pCliente)
        {
            if (pCliente == null) throw new ArgumentException("Cliente NULL en Mapper.AltaCliente()");
            try
            {

                DataRow drNuevoCliente = dtCliente.NewRow();
                drNuevoCliente.ItemArray = new object[]
                {
                    pCliente.ID,
                    pCliente.Apellido,
                    pCliente.Nombre,
                    pCliente.DNI,
                    pCliente.Telefono,
                    pCliente.Email,
                    pCliente.Domicilio,
                    pCliente.Propietario,
                    true, //Activo
                };

                dtCliente.Rows.Add(drNuevoCliente);
                dao.GrabarCambios();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void BajaCliente(int pID)
        {
            if (pID == 0) throw new ArgumentException($"ID 0 en Mapper.BajaPropeitario() {pID}");
            try
            {
                DataRow drBajaPropietario = dtCliente.Rows.Find(pID);
                if (drBajaPropietario == null) throw new Exception($"No se ha encontrado a ningún cliente bajo el ID {pID}. Mapper.BajaCliente()");

                drBajaPropietario["Activo"] = false;
                dao.GrabarCambios();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void ModificarCliente(ClienteBE pCliente)
        {
            if (pCliente == null) throw new ArgumentException("Cliente NULL en Mapper.ModificarCliente()");
            try
            {
                DataRow drClienteModif = dtCliente.Rows.Find(pCliente.ID);
                drClienteModif.ItemArray = new object[]
                {
                    drClienteModif.ItemArray[0],
                    pCliente.Apellido,
                    pCliente.Nombre,
                    pCliente.DNI,                   
                    pCliente.Domicilio,
                    pCliente.Email,
                    pCliente.Telefono,
                    pCliente.Propietario,
                    pCliente.Activo
                };

                dao.GrabarCambios();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Devuelve todos los clientes, activos e inactivos
        /// </summary>
        /// <returns></returns>
        public List<ClienteBE> ConsultarClientes()
        {

            List<ClienteBE> listaReturn = new List<ClienteBE>();

            try
            {
                foreach (DataRow dr in dtCliente.Rows)
                {
                    listaReturn.Add(new ClienteBE(dr.ItemArray));
                }
                return listaReturn;
            }
            catch (Exception)
            {
                throw;
            }

        }

        #endregion
    }
}
