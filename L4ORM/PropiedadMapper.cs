using L2BE;
using L5DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4ORM
{
    public class PropiedadMapper
{
        DAO dao = DAO.Instancia;
        static DataSet dataset;
        static DataTable dtPropiedad, dtEstructuraPropiedad, dtAmbientesPropiedad, dtServiciosPropiedad;

        public PropiedadMapper()
        {
            dataset = dao.ReturnDataset();
            dtPropiedad = dataset.Tables["Propiedad"];
            dtEstructuraPropiedad = dataset.Tables["EstructuraPropiedad"];
            dtAmbientesPropiedad = dataset.Tables["AmbientesPropiedad"];
            dtServiciosPropiedad = dataset.Tables["ServiciosPropiedad"];
        }

        #region Propiedades

        /// <summary>
        /// Da de alta filas en 4 data tables: Propiedad, AmbientesPropiedad, EstructuraPropiedad, ServiciosPropiedad.
        /// </summary>
        /// <param name="pPropiedad"></param>
        /// <exception cref="ArgumentException"></exception>
        public void AltaPropiedad(PropiedadBE pPropiedad)
        {
            if (pPropiedad == null) throw new ArgumentException("PropiedadBE NULL en Mapper.AltaPropiedad()");
            try
            {
                DataRow drNuevaPropiedad = dtPropiedad.NewRow();
                DataRow drPropiedadAmbientes = dtAmbientesPropiedad.NewRow();
                DataRow drPropiedadEstructura = dtEstructuraPropiedad.NewRow();
                DataRow drPropiedadServicios = dtServiciosPropiedad.NewRow();


                drNuevaPropiedad.ItemArray = new object[]
                {
                    pPropiedad.ID,
                    pPropiedad.PropietarioID,
                    pPropiedad.ContratoID,
                    pPropiedad.DescripcionComercial,
                    pPropiedad.Domicilio,
                    pPropiedad.Estado.ToString(),
                    pPropiedad.UbicacionLlaves,
                    pPropiedad.FechaPublicacion,
                    pPropiedad.Localidad,
                    pPropiedad.Orientacion,
                    pPropiedad.PrecioUSD,
                    pPropiedad.RutaFotos,
                    pPropiedad.Tipo,
                    pPropiedad.Activa
                };

                drPropiedadAmbientes.ItemArray = new object[]
                {
                    pPropiedad.ID,
                    pPropiedad.Ambientes.Balcon,
                    pPropiedad.Ambientes.Cocina,
                    pPropiedad.Ambientes.Garage,
                    pPropiedad.Ambientes.Jardin,
                    pPropiedad.Ambientes.Living,
                    pPropiedad.Ambientes.Lavadero,
                    pPropiedad.Ambientes.Patio,
                    pPropiedad.Ambientes.Terraza
                };

                drPropiedadEstructura.ItemArray = new object[]
                {
                    pPropiedad.ID,
                    pPropiedad.Estructura.Ambientes,
                    pPropiedad.Estructura.Antiguedad,
                    pPropiedad.Estructura.Baños,
                    pPropiedad.Estructura.Dormitorios,
                    pPropiedad.Estructura.MetrosCuadrados,
                    pPropiedad.Estructura.Plantas,
                    pPropiedad.Estructura.Toilette
                };

                drPropiedadServicios.ItemArray = new object[]
                {
                    pPropiedad.ID,
                    pPropiedad.Servivios.AguaCorriente,
                    pPropiedad.Servivios.Cable,
                    pPropiedad.Servivios.Cloaca,
                    pPropiedad.Servivios.Electricidad,
                    pPropiedad.Servivios.Internet,
                    pPropiedad.Servivios.GasNatural,
                    pPropiedad.Servivios.Pavimento
                };

                dtPropiedad.Rows.Add(drNuevaPropiedad);
                dtAmbientesPropiedad.Rows.Add(drPropiedadAmbientes);
                dtEstructuraPropiedad.Rows.Add(drPropiedadEstructura);
                dtServiciosPropiedad.Rows.Add(drPropiedadServicios);

                dao.GrabarCambios();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Busca a la propiedad bajo el ID suministrado y la elimina de la base de datos, junto con sus tablas asociadas 
        /// (dtAmbientesPropiedad, dtEstructuraPropiedad, dtServiciosPropiedad).
        /// </summary>
        /// <param name="pID"></param>
        /// <exception cref="ArgumentException"></exception>
        public void BajaPropiedad(int pID)
        {
            try
            {
                DataRow drBajaPropiedad = dtPropiedad.Rows.Find(pID);
                if (drBajaPropiedad == null) throw new Exception($"No se ha encontrado a ninguna propiedad bajo el ID {pID}. Mapper.BajaPropiedad()");

                drBajaPropiedad["Activa"] = false;

                dao.GrabarCambios();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Modifica los datos de la propiedad indicada, junto con sus tablas asociadas (dtAmbientesPropiedad, dtEstructuraPropiedad, dtServiciosPropiedad).
        /// </summary>
        /// <param name="pPropiedad"></param>
        /// <exception cref="ArgumentException"></exception>
        public void ModificarPropiedad(PropiedadBE pPropiedad)
        {
            if (pPropiedad == null) throw new ArgumentException("Propiedad NULL en Mapper.ModificarPropiedad()");

            try
            {
                DataRow drPropiedad = dtPropiedad.Rows.Find(pPropiedad.ID);
                DataRow drAmbientes = dtAmbientesPropiedad.AsEnumerable().FirstOrDefault(row => row.Field<int>("PropiedadID") == pPropiedad.ID);
                DataRow drEstructura = dtEstructuraPropiedad.AsEnumerable().FirstOrDefault(row => row.Field<int>("PropiedadID") == pPropiedad.ID);
                DataRow drServicios = dtServiciosPropiedad.AsEnumerable().FirstOrDefault(row => row.Field<int>("PropiedadID") == pPropiedad.ID);

                drPropiedad.ItemArray = new object[]
                {
                    pPropiedad.ID,
                    pPropiedad.PropietarioID,
                    pPropiedad.ContratoID,
                    pPropiedad.DescripcionComercial,
                    pPropiedad.Domicilio,
                    pPropiedad.Estado.ToString(),
                    pPropiedad.UbicacionLlaves.ToString(),
                    drPropiedad["FechaPublicacion"],
                    pPropiedad.Localidad,
                    pPropiedad.Orientacion,
                    pPropiedad.PrecioUSD,
                    drPropiedad["RutaImgPortada"],
                    pPropiedad.Tipo,
                    pPropiedad.Activa
                };

                drAmbientes.ItemArray = new object[]
                {
                    drAmbientes["ID"],
                    pPropiedad.Ambientes.Balcon,
                    pPropiedad.Ambientes.Cocina,
                    pPropiedad.Ambientes.Garage,
                    pPropiedad.Ambientes.Jardin,
                    pPropiedad.Ambientes.Living,
                    pPropiedad.Ambientes.Lavadero,
                    pPropiedad.Ambientes.Patio,
                    pPropiedad.Ambientes.Terraza,
                    pPropiedad.ID
                };

                drEstructura.ItemArray = new object[]
                {
                    drEstructura["ID"],
                    pPropiedad.Estructura.Ambientes,
                    pPropiedad.Estructura.Antiguedad,
                    pPropiedad.Estructura.Baños,
                    pPropiedad.Estructura.Dormitorios,
                    pPropiedad.Estructura.MetrosCuadrados,
                    pPropiedad.Estructura.Plantas,
                    pPropiedad.Estructura.Toilette,
                    pPropiedad.ID
                };

                drServicios.ItemArray = new object[]
                {
                    drServicios["ID"],
                    pPropiedad.Servivios.AguaCorriente,
                    pPropiedad.Servivios.Cable,
                    pPropiedad.Servivios.Cloaca,
                    pPropiedad.Servivios.Electricidad,
                    pPropiedad.Servivios.Internet,
                    pPropiedad.Servivios.GasNatural,
                    pPropiedad.Servivios.Pavimento,
                    pPropiedad.ID
                };


                dao.GrabarCambios();
            }
            catch (Exception)
            {

                throw;
            }

        }


        public List<PropiedadBE> ConsultarPropiedades()
        {
            if (dtPropiedad.Rows.Count == 0) return new List<PropiedadBE>();

            try
            {
                List<PropiedadBE> listaReturn = new List<PropiedadBE>();

                foreach (DataRow row in dtPropiedad.Rows)
                {
                    //Buscar sus caracteristicas
                    DataRow drAmbientes = dtAmbientesPropiedad.AsEnumerable().Where(r => r.Field<int>("PropiedadID") == (int)row["ID"]).First();
                    DataRow drEstructura = dtEstructuraPropiedad.AsEnumerable().Where(r => r.Field<int>("PropiedadID") == (int)row["ID"]).First();
                    DataRow drServicios = dtServiciosPropiedad.AsEnumerable().Where(r => r.Field<int>("PropiedadID") == (int)row["ID"]).First();

                    PropiedadBEambientes ambientes = new PropiedadBEambientes(drAmbientes.ItemArray);
                    PropiedadBEestructura estructura = new PropiedadBEestructura(drEstructura.ItemArray);
                    PropiedadBEservicios servicios = new PropiedadBEservicios(drServicios.ItemArray);

                    //Buscar el contrato
                    PropiedadBE prop = new PropiedadBE(row.ItemArray, ambientes, estructura, servicios);

                    listaReturn.Add(prop);
                }
                return listaReturn;

            }
            catch (Exception)
            {

                throw;
            }

        }

        public string GetImgPortadaPropiedad(int pID)
        {
            try
            {
                DataRow drPropiedad = dtPropiedad.Rows.Find(pID);
                if (drPropiedad == null) throw new Exception($"No se ha encontrado a ninguna propiedad bajo el ID {pID}. Mapper.GetImgPortadaPropiedad()");
                return drPropiedad["RutaImgPortada"].ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void SetImgPortadaPropiedad(int pID, string pRuta)
        {
            try
            {
                DataRow drPropiedad = dtPropiedad.Rows.Find(pID);
                if (drPropiedad == null) throw new Exception($"No se ha encontrado a ninguna propiedad bajo el ID {pID}. Mapper.SetImgPortadaPropiedad()");
                drPropiedad["RutaImgPortada"] = pRuta;
                dao.GrabarCambios();
            }
            catch (Exception)
            {
                throw;
            }
        }


        #endregion
    }
}
