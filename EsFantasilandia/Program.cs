using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsFantasilandia
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<CAttrazioni> attrazioni = new List<CAttrazioni>();
            List<IRiparabile> riparabili = new List<IRiparabile>();
            List<CVisitatore> visitatori = new List<CVisitatore>();

            CMontagnaRussa montagnaRussa = new CMontagnaRussa("Montagna Russa Extreme", 20, 160);
            riparabili.Add(montagnaRussa);
            CSaltoNelVuoto saltoNelVuoto = new CSaltoNelVuoto("Salto nel Vuoto Medievale", 15, 120, 90);
            riparabili.Add(saltoNelVuoto);
            CGiostraBambini giostraBambini = new CGiostraBambini("Giostra dei Bambini Barbie", 10, 12);
            riparabili.Add(giostraBambini);
            CSalaGiochi salaGiochi = new CSalaGiochi("Sala Giochi Arcade", 5);
            riparabili.Add(salaGiochi);
            CChiosco chiosco = new CChiosco("Chiosco di Popcorn e Bibite", 12);
            riparabili.Add(chiosco);
            CBagno bagno = new CBagno(20);
            riparabili.Add(bagno);

            montagnaRussa.SegnalaGuasto();
            salaGiochi.SegnalaGuasto();
            bagno.SegnalaGuasto();

            foreach (IRiparabile riparabile in riparabili)
            {
                if (riparabile is CAttrazioni attrazione)
                {
                    attrazioni.Add(attrazione);
                }
            }

            CVisitatore mario = new CVisitatore(true, 170, 100, 34);
            visitatori.Add(mario);
            CVisitatore luigi = new CVisitatore(false, 180, 80, 30);
            visitatori.Add(luigi);
            CVisitatore sara = new CVisitatore(true, 130, 40, 11);
            visitatori.Add(sara);

            int incassoTot = 0;

            //Accesso dei visitatori alle attrazioni
            foreach (CVisitatore visitatore in visitatori)
            {
                Console.WriteLine(visitatore.ToString());
                foreach (CAttrazioni a in attrazioni)
                {
                    if (a.IsGuasta())
                        continue;

                    bool accessoConsentito = true;
                    if (a is CMontagnaRussa montR)
                    {
                        accessoConsentito = montR.Verifica(visitatore);
                    }
                    else if (a is CGiostraBambini giostra)
                    {
                        accessoConsentito = giostra.Verifica(visitatore);
                    }
                    
                    if (accessoConsentito)
                    {
                        int costo = a.CalcoloCosto(visitatore);
                        incassoTot += costo;
                        Console.WriteLine($"Accesso consentito a {a.Nome}. Costo: {costo} euro.");
                    }
                    else
                    {
                        Console.WriteLine($"Accesso negato a {a.Nome} per visitatore numero {visitatori.IndexOf(visitatore) + 1}.");
                    }

                }
            }

            Console.WriteLine($"Incasso totale del parco: {incassoTot} euro.");

            //Manutenzioni
            string manutenzione = "Manutenzioni da fare: \n";
            foreach (IRiparabile riparabile in riparabili)
            {
                if (riparabile.IsGuasta())
                {
                    manutenzione += riparabile.ToString() + "\n";
                }
            }

            Console.WriteLine(manutenzione);

            int costoTotaleManutenzione = 0;
            foreach (IRiparabile riparabile in riparabili)
            {
                if (riparabile.IsGuasta())
                {
                    costoTotaleManutenzione += riparabile.Ripara();
                }
            }

            Console.WriteLine($"Costo totale della manutenzione: {costoTotaleManutenzione} euro.");

        }
    }
}
