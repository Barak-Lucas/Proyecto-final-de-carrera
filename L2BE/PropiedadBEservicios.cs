using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2BE
{
    public class PropiedadBEservicios 
    {
        public int PropietarioID { get; set; }

        public bool AguaCorriente { get; set; }

        public bool Cable { get; set; }

        public bool Cloaca { get; set; }

        public bool Electricidad { get; set; }

        public bool Internet { get; set; }

        public bool GasNatural { get; set; }

        public bool Pavimento { get; set; }

        public Dictionary<string, string> dServicios
        {
            get
            {
                return new Dictionary<string, string>
                {
                    { "Agua Corriente: ", this.AguaCorriente ? "✔" : "❌" },
                    { "Cable: ", this.Cable ? "✔" : "❌"},
                    { "Cloaca: ", this.Cloaca ? "✔" : "❌"},
                    { "Electricidad: ", this.Electricidad ? "✔" : "❌"},
                    { "Internet: ", this.Internet ? "✔" : "❌"},
                    { "Gas Natural: ", this.GasNatural ? "✔" : "❌" },
                    { "Pavimento: ", this.Pavimento ? "✔" : "❌"}
                };
            }
        }

        public PropiedadBEservicios( bool pAgua, bool pCable, bool pCloaca, bool pElecttricidad, bool pInternet, bool pGas, bool pPavimento)
        {

            this.AguaCorriente = pAgua;
            this.Cable = pCable;
            this.Cloaca = pCloaca;
            this.Electricidad = pElecttricidad;
            this.Internet = pInternet;
            this.GasNatural = pGas;
            this.Pavimento = pPavimento;
        }

        public PropiedadBEservicios(object[] pItemArray) : this((bool)pItemArray[1], (bool)pItemArray[2], (bool)pItemArray[3], (bool)pItemArray[4], (bool)pItemArray[5], (bool)pItemArray[6], (bool)pItemArray[7])
        {
            this.PropietarioID = (int)pItemArray[0];
        }
    }
}
