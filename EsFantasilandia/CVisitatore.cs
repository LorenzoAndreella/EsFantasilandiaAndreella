using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsFantasilandia
{
    internal class CVisitatore
    {
        public bool FastPass { get; }
        public int Altezza { get; }
        public int Peso { get; }
        public int Eta { get; }
     
        public CVisitatore(bool fastPass, int altezza, int peso, int eta)
        {
            FastPass = fastPass;
            Altezza = altezza;
            Peso = peso;
            Eta = eta;
        }
        public override string ToString()
        {
            string fastPassSiNo = FastPass ? "Sì" : "No";
            return $"Visitatore: FastPass={fastPassSiNo}, Altezza={Altezza}, Peso={Peso}, Eta={Eta}";
        }
    }
}
