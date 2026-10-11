using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsFantasilandia
{
    internal class CSaltoNelVuoto : CMontagnaRussa
    {
        private int pesoMax;
        public CSaltoNelVuoto(string nome, int capienza, int altezzaMinima, int pesoMax) : base(nome, capienza, altezzaMinima)
        {
            Supplemento = 3;
            this.pesoMax = pesoMax;
        }

        public override bool Verifica(CVisitatore V)
        {
            return base.Verifica(V) && V.Peso <= pesoMax;
        }

        public override string ToString()
        {
            return base.ToString() + $", Tipologia Particolare: Salto nel Vuoto, Peso Massimo: {pesoMax}";
        }
    }
}
