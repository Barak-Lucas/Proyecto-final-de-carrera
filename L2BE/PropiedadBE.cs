using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2BE
{
    public class PropiedadBE : Entidad
    {

        #region Props


        #region Servicios

        public PropiedadBEservicios? Servivios { get; set; }

        #endregion

        #region Ambientes

        public PropiedadBEambientes? Ambientes { get; set; }

        #endregion

        #region Estructura

        public PropiedadBEestructura? Estructura { get; set; }

        #endregion


        public int PropietarioID { get; set; }

        public int ContratoID { get; set; } = 0;

        public string DescripcionComercial { get; set; }

        public string Domicilio { get; set; }

        public EstadosPropiedad Estado { get; set; } = EstadosPropiedad.Suspendida;

        public UbicacionesLlaves? UbicacionLlaves { get; set; } = UbicacionesLlaves.Otro;

        public DateTime FechaPublicacion { get; set; }

        public string Localidad { get; set; }

        public Orientaciones? Orientacion { get; set; }

        public decimal PrecioUSD { get; set; }

        public string? RutaFotos { get; set; } = "Pendiente";

        public TiposPropiedad Tipo { get; set; }

        public bool Activa { get; set; }

        static List<string> localidadesAbarcadas = new List<string>()
        {
            "Aguas Verdes",
            "Costa Azul",
            "Costa del Este",  
            "General Lavalle (Paraje Pavón)",
            "La Lucila del Mar",
            "Mar de Ajó",
            "Nueva Atlantis",
            "San Bernardo",            
        };

        #region Enums 
        public static List<string> LocalidadesAbarcadas => localidadesAbarcadas;

        public enum UbicacionesLlaves
        {
            Oficina,
            Propietario,
            Extraviadas,
            Mantenimiento,
            Otro   
        }

        public enum TiposPropiedad
        {
            Casa,
            Departamento,
            Duplex,
            Local,
            Terreno,

        }

        public enum Orientaciones
        {
            Norte,
            Sur,
            Este,
            Oeste,
        }

        public enum EstadosPropiedad
        {
            Disponible,
            Vendida,
            Reservada,
            Suspendida,
            Retirada
        }

        #endregion

        public PropiedadBE()
        {
            Activa = true;
        }



        public PropiedadBE(int pPropietarioID,  string pDescripcion, string pDomicilio, string pLocalidad, Orientaciones pOrientacion, decimal pPrecio, TiposPropiedad pTipo,
                          PropiedadBEambientes? pAmbientes = null, PropiedadBEestructura? pEstructura = null, PropiedadBEservicios? pServivios = null) : this()
        {
            this.PropietarioID = pPropietarioID;
            this.DescripcionComercial = pDescripcion;
            this.Domicilio = pDomicilio;
            this.FechaPublicacion = DateTime.Now;
            this.Localidad = pLocalidad;
            this.Orientacion = pOrientacion;
            this.PrecioUSD = pPrecio;
            this.Tipo = pTipo;
            this.Ambientes = pAmbientes;
            this.Estructura = pEstructura;
            this.Servivios = pServivios;

        }

        /// <summary>
        /// Constructor para instanciar por completo la propiedad a partir de los Datatables asociados.
        /// Usado para recuperar toda la información de la propiedad. "pAmbientes, pEstructura y pServicios" se instancian de la misma 
        /// manera (en el mapper) al hacer la consulta. 
        /// </summary>
        /// <param name="pItemArray">DataTable => dtPropiedad.Row.ItemArray</param>
        /// <param name="pAmbientes">Objeto creado en el mapper</param>
        /// <param name="pEstructura">Objeto creado en el mapper</param>
        /// <param name="pServivios">Objeto creado en el mapper</param>
        public PropiedadBE(object[] pItemArray, PropiedadBEambientes pAmbientes, PropiedadBEestructura pEstructura, PropiedadBEservicios pServivios) :
                           this((int)pItemArray[1],  (string)pItemArray[3], (string)pItemArray[4], (string)pItemArray[8], 
                           Enum.Parse<Orientaciones>((string)pItemArray[9]), Convert.ToDecimal(pItemArray[10]), Enum.Parse<PropiedadBE.TiposPropiedad>((string)pItemArray[12]), pAmbientes, pEstructura, pServivios)
        {
            this.ID = (int)pItemArray[0];
            this.ContratoID = (int)pItemArray[2];
            this.Estado = Enum.Parse<EstadosPropiedad>((string)pItemArray[5]);
            this.UbicacionLlaves = Enum.Parse<PropiedadBE.UbicacionesLlaves>((string)pItemArray[6]);
            this.FechaPublicacion = Convert.ToDateTime(pItemArray[7]);
            this.RutaFotos = (string)pItemArray[11];
        }

        #endregion
    }
}
