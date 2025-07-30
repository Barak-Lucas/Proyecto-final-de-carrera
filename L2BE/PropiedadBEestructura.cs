using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2BE
{
    public class PropiedadBEestructura 
    {
        public int PropiedadID { get; set; }

        public int Antiguedad { get; set; }

        public int Baños { get; set; }

        public int Ambientes { get; set; }

        public int Dormitorios { get; set; }

        public int MetrosCuadrados { get; set; }

        public int Plantas { get; set; }

        public int Toilette { get; set; }

        public Dictionary<string, int> dEstructura 
        {
            get
            {
                return new Dictionary<string, int>
                {
                    { "Ambientes: ", this.Ambientes },
                    { "Plantas: ", this.Plantas },
                    { "Dormitorios: ", this.Dormitorios },
                    { "Baños: ", this.Baños },
                    { "Toilette: ", this.Toilette },
                    { "Antiguedad en años: ", this.Antiguedad },                 
                    { "Metros Cuadrados: ", this.MetrosCuadrados },
                    
                };
            }
        }

        public PropiedadBEestructura(int pAmbientes, int pAntiguedad, int pBaños,  int pDormitorios, int pM2, int pPlantas, int pToilette)
        {

            this.Antiguedad = pAntiguedad;
            this.Baños = pBaños;
            this.Ambientes = pAmbientes;
            this.Dormitorios = pDormitorios;
            this.MetrosCuadrados = pM2;
            this.Plantas = pPlantas;
            this.Toilette = pToilette;
        }

        public PropiedadBEestructura(object[] pItemArray) : this((int)pItemArray[1], (int)pItemArray[2], (int)pItemArray[3], (int)pItemArray[4], (int)pItemArray[5], (int)pItemArray[6], (int)pItemArray[7])
        {
            this.PropiedadID = (int)pItemArray[0];
        }
    }
}
