using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2BE
{
    public class PropiedadBEambientes 
    {
        public int? PropiedadID { get; set; }
        public bool Balcon { get; set; }

        public bool Cocina { get; set; }

        public bool Garage { get; set; }

        public bool Jardin { get; set; }

        public bool Living { get; set; }

        public bool Lavadero { get; set; }

        public bool Patio { get; set; }

        public bool Terraza { get; set; }

        public Dictionary<string, string> dAmbientes
        {
            get
            {
                return new Dictionary<string, string>
                {
                    { "Balcon: ", this.Balcon ? "✔" : "❌" },
                    { "Cocina: ", this.Cocina ? "✔" : "❌"},
                    { "Garage: ", this.Garage ? "✔" : "❌"},
                    { "Jardin: ", this.Jardin ? "✔" : "❌"},
                    { "Living: ", this.Living ? "✔" : "❌"},
                    { "Lavadero: ", this.Lavadero ? "✔" : "❌" },
                    { "Patio: ", this.Patio ? "✔" : "❌"},
                    { "Terraza: ", this.Terraza ? "✔" : "❌"}
                };
            }
        }


        public PropiedadBEambientes(bool pBalcon, bool pCocina, bool pGarage, bool pJardin, bool pLiving, bool pLavadero, bool pPatio, bool pTerraza)
        {
            this.Balcon = pBalcon;
            this.Cocina = pCocina;
            this.Garage = pGarage;
            this.Jardin = pJardin;
            this.Living = pLiving;
            this.Lavadero = pLavadero;
            this.Patio = pPatio;
            this.Terraza = pTerraza;
        }

        public PropiedadBEambientes(object[] pItemArray) : this((bool)pItemArray[1], (bool)pItemArray[2], (bool)pItemArray[3], (bool)pItemArray[4], (bool)pItemArray[5], (bool)pItemArray[6], (bool)pItemArray[7], (bool)pItemArray[8])
        {
            this.PropiedadID = (int)pItemArray[0];
        }


    }
}
