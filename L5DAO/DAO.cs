using System.Data;

namespace L5DAO
{
    public class DAO
    {
        DataSet dataSetBitacora;
        DataSet dataSet;
        DataTable dtContrato, dtFacturaVenta, dtFacturaTasacion, dtInteraccion, dtCliente, 
                         dtUsuario, dtPermiso, dtPermisoComponente, dtPermisosUsuario, dtPropiedad, 
                         dtEstructuraPropiedad, dtAmbientesPropiedad, dtServiciosPropiedad, 
                         dtTasacion, dtVenta, dtVisita, dtBitacora;

        private static DAO instancia;
        public static DAO Instancia => instancia ??= new DAO();


        string rutaBackup = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Backups\");
        string rutaBaseDeDatos = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Base de datos\InmobiliariaBD.xml");
        string rutaBitacora = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Bitacora\Bitacora.xml");

        private DAO()
        {
            dataSetBitacora ??= new DataSet("Bitacora");
            dataSet ??= new DataSet("InmobiliariaBD");

            if (!File.Exists(rutaBaseDeDatos))
            {
                CrearArchivo();
            }
            else
            {
                dataSet.ReadXml(rutaBaseDeDatos);
            }

            if (!File.Exists(rutaBitacora))
            {
                CrearBitacora();
            }
            else
            {
                dataSetBitacora.ReadXml(rutaBitacora);
            }
            
        }

        public DataSet ReturnDataset()
        {
            return dataSet;
        }

        public DataSet ReturnDataSetBitacora()
        {
            return dataSetBitacora;
        }

        private  void CrearArchivo()
        {
            if(dataSet.Tables.Count == 0)
            {
                #region Creación de datatables

                #region Negocio

                /*********** Contrato ***********/
                dtContrato = new DataTable("Contrato");
                dtContrato.Columns.AddRange(new DataColumn[]
                {
                new DataColumn("ID", typeof(int)), //0
                new DataColumn("PropietarioID", typeof(int)),//1
                new DataColumn("PropiedadID",typeof(int)),//2
                new DataColumn("NombreConyugue", typeof (string)),//3
                new DataColumn("DNIconyugue", typeof(string)),//4
                new DataColumn("FechaInicio", typeof(DateTime)),//5
                new DataColumn("FechaVencimiento", typeof(string)),//6
                new DataColumn("Estado", typeof(string)),//7
                new DataColumn("ValorVentaUSD",typeof(int))//8
                });

                dtContrato.PrimaryKey = new DataColumn[] { dtContrato.Columns["ID"] };


                /*********** Venta ***********/
                dtVenta = new DataTable("Venta");
                dtVenta.Columns.AddRange(new DataColumn[]
                {
                new DataColumn("ID", typeof(int)), /*0*/
                new DataColumn("CompradorID",typeof(int)),/*1*/
                new DataColumn("VendedorID", typeof(int)),/*2*/
                new DataColumn("PropiedadVendidaID",typeof(int)),/*3*/
                new DataColumn("FechaDeVenta", typeof(DateTime)),/*4*/
                new DataColumn("PorcentajeComisionComprador", typeof(decimal)),/*5*/
                new DataColumn("PorcentajeComisionVendedor", typeof(decimal)),/*6*/
                new DataColumn("PrecioConvenido", typeof(decimal)),/*7*/
                });

                dtVenta.PrimaryKey = new DataColumn[] { dtVenta.Columns["ID"] };



                /*********** FacturaVenta ***********/
                dtFacturaVenta = new DataTable("FacturaVenta");
                dtFacturaVenta.Columns.AddRange(new DataColumn[]
                {
                new DataColumn("ID", typeof(int)),
                new DataColumn("VendedorID", typeof(int)),
                new DataColumn("CompradorID",typeof(int)),
                new DataColumn("VentaAsociadaID", typeof(int)),
                new DataColumn("Detalles", typeof(string)),
                new DataColumn("Fecha", typeof(DateTime)),
                new DataColumn("ImporteComprador", typeof(string)),
                new DataColumn("ImporteVendedor", typeof(string)),
                new DataColumn("IvaComprador", typeof(string)),
                new DataColumn("IvaVendedor", typeof(string)),
                new DataColumn("TotalComprador", typeof(decimal)),
                new DataColumn("TotalVendedor", typeof(decimal)),
                });

                dtFacturaVenta.PrimaryKey = new DataColumn[] { dtFacturaVenta.Columns["ID"] };


                /*********** Tasacion ***********/
                dtTasacion = new DataTable("Tasacion");
                dtTasacion.Columns.AddRange(new DataColumn[]
                {
                new DataColumn("ID", typeof(int)), //0
                new DataColumn("PropietarioID", typeof(int)),//1                     
                new DataColumn("Domicilio", typeof(string)),//2
                new DataColumn("Estado",typeof(string)),//3
                new DataColumn("FechaHora", typeof(DateTime)),//4
                new DataColumn("Localidad", typeof(string)),//5
                new DataColumn("m2", typeof(int)),//6
                new DataColumn("Observaciones", typeof (string)),//7
                new DataColumn("PorcentajeComision",typeof(decimal)),//8
                new DataColumn("TipoInmueble",typeof(string)),//9
                new DataColumn("ValorInmuebleTasado",typeof(decimal)),//10

                });

                dtTasacion.PrimaryKey = new DataColumn[] { dtTasacion.Columns["ID"] };



                /*********** FacturaTasacion ***********/
                dtFacturaTasacion = new DataTable("FacturaTasacion");
                dtFacturaTasacion.Columns.AddRange(new DataColumn[]
                {
                new DataColumn("ID", typeof(int)), //0
                new DataColumn("TasacionID",typeof(int)),//1
                new DataColumn("PropietarioID", typeof(int)),//2              
                new DataColumn("Fecha", typeof(string)),//3
                new DataColumn("Importe", typeof(decimal)),//4
                new DataColumn("IVA", typeof(decimal)),//5
                new DataColumn("Observaciones", typeof(string)),//6
                new DataColumn("Total", typeof(decimal)),//7 
                });

                dtFacturaTasacion.PrimaryKey = new DataColumn[] { dtFacturaTasacion.Columns["ID"] };



                /*********** Interacción ***********/
                dtInteraccion = new DataTable("Interaccion");
                dtInteraccion.Columns.AddRange(new DataColumn[]
                {
                new DataColumn("ID", typeof(int)),
                new DataColumn("PropiedadID",typeof(int)),
                new DataColumn("Contacto", typeof(string)),
                new DataColumn("Detalle", typeof(string)),
                new DataColumn("Fecha", typeof(DateTime)),
                new DataColumn("Interesado", typeof(string)),
                });

                dtInteraccion.PrimaryKey = new DataColumn[] { dtInteraccion.Columns["ID"] };



                /*********** Propiedad ***********/
                dtPropiedad = new DataTable("Propiedad");
                dtPropiedad.Columns.AddRange(new DataColumn[]
                {
                new DataColumn("ID", typeof(int)), //0
                new DataColumn("PropietarioID", typeof(int)), //1
                new DataColumn("ContratoID",typeof(int)), //2
                new DataColumn("Descripcion", typeof (string)),//3
                new DataColumn("Domicilio", typeof(string)),//4
                new DataColumn("EstadoPropiedad", typeof(string)),//5
                new DataColumn("EstadoLlaves", typeof(string)),//6
                new DataColumn("FechaPublicacion",typeof(DateTime)),//7
                new DataColumn("Localidad", typeof(string)),//8
                new DataColumn("Orientacion",typeof(string)),//9
                new DataColumn("PrecioUSD", typeof(decimal)),//10
                new DataColumn("RutaImgPortada",typeof(string)),//11
                new DataColumn("Tipo",typeof(string)),//12
                new DataColumn("Activa", typeof(bool)) //13
                });

                dtPropiedad.PrimaryKey = new DataColumn[] { dtPropiedad.Columns["ID"] };

                /*********** EstructuraPropiedad ***********/
                dtEstructuraPropiedad = new DataTable("EstructuraPropiedad");
                dtEstructuraPropiedad.Columns.AddRange(new DataColumn[]
                {
                new DataColumn("PropiedadID", typeof(int)),
                new DataColumn("Ambientes", typeof(int)),
                new DataColumn("Antiguedad",typeof(int)),
                new DataColumn("Baños", typeof (int)),
                new DataColumn("Dormitorios", typeof(int)),
                new DataColumn("MetrosCuadrados", typeof(int)),
                new DataColumn("Plantas", typeof(int)),
                new DataColumn("Toilette",typeof(int)),
                new DataColumn("ID", typeof(int))
                });

                dtEstructuraPropiedad.PrimaryKey = new DataColumn[] { dtEstructuraPropiedad.Columns["ID"] };
                dtEstructuraPropiedad.Columns["ID"].AutoIncrement = true;
                dtEstructuraPropiedad.Columns["ID"].AutoIncrementSeed = 1;  

                /*********** AmbientesPropiedad ***********/
                dtAmbientesPropiedad = new DataTable("AmbientesPropiedad");
                dtAmbientesPropiedad.Columns.AddRange(new DataColumn[]
                {
                new DataColumn("PropiedadID", typeof(int)),
                new DataColumn("Balcon",typeof(bool)),
                new DataColumn("Cocina", typeof (bool)),
                new DataColumn("Garage", typeof(bool)),
                new DataColumn("Jardin", typeof(bool)),
                new DataColumn("Living", typeof(bool)),
                new DataColumn("Lavadero", typeof(bool)),
                new DataColumn("Patio",typeof(bool)),
                new DataColumn("Terraza",typeof(bool)),
                new DataColumn("ID", typeof(int))
                });

                dtAmbientesPropiedad.PrimaryKey = new DataColumn[] { dtAmbientesPropiedad.Columns["ID"] };
                dtAmbientesPropiedad.Columns["ID"].AutoIncrement = true;
                dtAmbientesPropiedad.Columns["ID"].AutoIncrementSeed = 1;

                /*********** ServiciosPropiedad ***********/
                dtServiciosPropiedad = new DataTable("ServiciosPropiedad");
                dtServiciosPropiedad.Columns.AddRange(new DataColumn[]
                {
                new DataColumn("PropiedadID", typeof(int)),
                new DataColumn("AguaCorriente",typeof(bool)),
                new DataColumn("Cable", typeof (bool)),
                new DataColumn("Cloaca", typeof(bool)),
                new DataColumn("Electricidad", typeof(bool)),
                new DataColumn("Internet", typeof(bool)),
                new DataColumn("GasNatural", typeof(bool)),
                new DataColumn("Pavimento",typeof(bool)),
                new DataColumn("ID", typeof(int))
                });

                dtServiciosPropiedad.PrimaryKey = new DataColumn[] { dtServiciosPropiedad.Columns["ID"] };
                dtServiciosPropiedad.Columns["ID"].AutoIncrement = true;
                dtServiciosPropiedad.Columns["ID"].AutoIncrementSeed = 1;

                /*********** Visita ***********/
                dtVisita = new DataTable("Visita");
                dtVisita.Columns.AddRange(new DataColumn[]
                {
                new DataColumn("ID", typeof(int)),
                new DataColumn("ClienteID", typeof(int)),
                new DataColumn("PropiedadID",typeof(int)),
                new DataColumn("FechaHora",typeof(DateTime)),
                new DataColumn("Estado", typeof(string)),
                new DataColumn("Comentarios", typeof (string)),

                });

                dtVisita.PrimaryKey = new DataColumn[] { dtVisita.Columns["ID"] };

                /*********** Cliente ***********/
                dtCliente = new DataTable("Cliente");
                dtCliente.Columns.AddRange(new DataColumn[]
                {
                new DataColumn("ID", typeof(int)),
                new DataColumn("Apellido",typeof(string)),
                new DataColumn("Nombre",typeof(string)),
                new DataColumn("DNI", typeof(int)),
                new DataColumn("Domicilio", typeof (string)),
                new DataColumn("Email", typeof (string)),
                new DataColumn("Telefono", typeof (string)),
                new DataColumn("Propietario", typeof(bool)),
                new DataColumn("Activo", typeof(bool))
                });

                dtCliente.PrimaryKey = new DataColumn[] { dtCliente.Columns["ID"] };

                #endregion

                #region Sistema

                /*********** USUARIO ***********/
                dtUsuario = new DataTable("Usuario");
                dtUsuario.Columns.AddRange(new DataColumn[]
                {
                new DataColumn("ID", typeof(int)),//0
                new DataColumn("NombreUsuario", typeof(string)),//1
                new DataColumn("FechaIngreso", typeof(DateTime)),//2
                new DataColumn("Contraseña", typeof(string)),//3
                new DataColumn("Bloqueado", typeof(bool)),//4
                new DataColumn("Activo", typeof(bool)) //5
                });

                dtUsuario.PrimaryKey = new DataColumn[] { dtUsuario.Columns["ID"] };


                /*********** Permiso ***********/
                dtPermiso = new DataTable("Permiso");
                dtPermiso.Columns.AddRange(new DataColumn[]
                {
                new DataColumn("ID", typeof(int)),
                new DataColumn("Nombre",typeof(string)),
                new DataColumn("EsCompuesto", typeof(bool)),
                new DataColumn("EsRol", typeof(bool))
                });

                dtPermiso.PrimaryKey = new DataColumn[] { dtPermiso.Columns["ID"] };
                dtPermiso.Columns["ID"].AutoIncrement = true;
                dtPermiso.Columns["ID"].AutoIncrementSeed = 1;


                /*********** PermisoComponente ***********/

                dtPermisoComponente = new DataTable("PermisoComponente");
                dtPermisoComponente.Columns.AddRange(new DataColumn[]
                {
                new DataColumn("PermisoPadreID", typeof(int)),
                new DataColumn("PermisoHijoID",typeof(int)),
                });

                dtPermisoComponente.PrimaryKey = new DataColumn[] { dtPermisoComponente.Columns["PermisoPadreID"], dtPermisoComponente.Columns["PermisoHijoID"] };


                /*********** PermisosUsuario ***********/
                dtPermisosUsuario = new DataTable("PermisosUsuario");
                dtPermisosUsuario.Columns.AddRange(new DataColumn[]
                {
                new DataColumn("PermisoID", typeof(int)),
                new DataColumn("UsuarioID",typeof(int)),
                });

                dtPermisosUsuario.PrimaryKey = new DataColumn[] { dtPermisosUsuario.Columns["PermisoID"], dtPermisosUsuario.Columns["UsuarioID"] };


                #endregion

                #endregion

                dataSet.Tables.AddRange(new DataTable[]
                {
                dtContrato, dtFacturaVenta, dtFacturaTasacion, dtInteraccion, dtCliente,
                dtPropiedad, dtEstructuraPropiedad, dtAmbientesPropiedad, dtServiciosPropiedad,
                dtTasacion, dtVenta, dtVisita, dtUsuario,  dtPermiso, dtPermisosUsuario, dtPermisoComponente,

                });

                GrabarCambios();
            }
            
        }

        private  void CrearBitacora()
        {
            /*********** Bitacora ***********/
            dtBitacora = new DataTable("Bitacora");
            dtBitacora.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("ID", typeof(int)),
                new DataColumn("Usuario",typeof(int)),
                new DataColumn("Fecha", typeof(DateTime)),
                new DataColumn("Detalle", typeof(string))
            });

            dtBitacora.PrimaryKey = new DataColumn[] { dtBitacora.Columns["ID"] };
            dtBitacora.Columns["ID"].AutoIncrement = true;
            dtBitacora.Columns["ID"].AutoIncrementSeed = 1;
            dataSetBitacora.Tables.Add(dtBitacora);

            GuardarBitacora();
        }

        public  void GrabarCambios()
        {
            dataSet.WriteXml(rutaBaseDeDatos, XmlWriteMode.WriteSchema);        
        }


        public  void GuardarBitacora()
        {
            dataSetBitacora.WriteXml(rutaBitacora, XmlWriteMode.WriteSchema);
        }


        public  void CrearBackup()
        {
            //ruta del currentDomain\backups\fecha como nombre 
            string ruta = rutaBackup + DateTime.Now.ToString("dd-MM-yyyy HH-mm-ss") + ".xml";

            dataSet.WriteXml(ruta, XmlWriteMode.WriteSchema);
        }


        public void Restore(string pNombreBackup)
        {
            string ruta = rutaBackup + pNombreBackup;
            dataSet = new DataSet("InmobiliariaBD");
            dataSet.ReadXml(ruta);
            GrabarCambios();
        }


        public string[] BackupsDisponibles()
        {
            string[] rutas = Directory.GetFiles(rutaBackup);
            int indiceRecorte = rutaBackup.Length;
            for (int i = 0; i < rutas.Length; i++)
            {
                rutas[i] = rutas[i].Substring(indiceRecorte);
            }
            return rutas;
        }
    }

}
