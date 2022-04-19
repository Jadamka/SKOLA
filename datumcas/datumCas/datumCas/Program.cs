using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datumCas
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Zjištení aktuálního data a času
            ///
            DateTime aktualniDatumCas = DateTime.Now;

            Console.WriteLine("Celý datum: {0}", aktualniDatumCas);
            Console.WriteLine("Pouze rok: {0}", aktualniDatumCas.Year);
            Console.WriteLine("Pouze mesic: {0}", aktualniDatumCas.Month);
            Console.WriteLine("Pouze hodina: {0}", aktualniDatumCas.Hour);

            Console.ReadKey();
            // Porovnani datumu

            DateTime pozdejsiCas = DateTime.Now;

            Console.WriteLine("\nPorovnani aktualniDatumCas == pozdejsiCas: {0}", aktualniDatumCas==pozdejsiCas);
#pragma warning disable
            Console.WriteLine("Porovnani pozdejsiCas == pozdejsiCas: {0}", pozdejsiCas == pozdejsiCas);
            Console.WriteLine("Porovnani aktualniDatumCas > pozdejsiCas: {0}", aktualniDatumCas > pozdejsiCas);
            Console.WriteLine("Porovnani aktualniDatumCas < pozdejsiCas: {0}", aktualniDatumCas < pozdejsiCas);

            Console.ReadKey();
            // Vytvoreni vlastniho data a casu
            // 
            DateTime vlastniDatumCas = new DateTime(2002, 12, 28, 13, 23, 56);
            Console.WriteLine("\nMnou zadany datum: {0}", vlastniDatumCas);

            Console.ReadKey();
            // Upravy datumu a casu
            DateTime upravenyDatum = vlastniDatumCas.AddDays(100);
            Console.WriteLine("\nUpravene datum - pridano 100 dni: {0}", upravenyDatum);
            Console.WriteLine("Odecteno 75 hodin od upraveneho data: {0}", upravenyDatum.AddHours(-75));
            Console.WriteLine("Pridano 365 sekund k upravenemu datu: {0}", upravenyDatum.AddSeconds(365));

            Console.ReadKey();
            // Vypis dne - nazvem, mesice - nazvem
            Console.WriteLine("\nVypis dne z aktualniDatumCas slovem: {0}", aktualniDatumCas.ToLongDateString());

            Console.ReadKey();
            // Odecteni datumu
            TimeSpan sub = upravenyDatum.Subtract(aktualniDatumCas);
            Console.WriteLine("upravenyDatum - aktualniDatumCas = {0}", sub);

            Console.ReadKey();
            /// zjistete ze stringu ziskaneho z aktualniDatumCas.ToLongDateStirng()
            /// pouze nazev mesice
            /// 

            var mesice = new Dictionary<string, string>(){
                {"ledna", "Leden"},
                {"února", "Únor" },
                {"března", "Březen" },
                {"dubna", "Duben" },
                {"května", "Květen" },
                {"června", "Červen" },
                {"července", "Červenec" },
                {"srpna", "Srpen" },
                {"září", "Září" },
                {"října", "Říjen" },
                {"listopadu", "Listopad"},
                {"prosince", "Prosinec"}
            };

            string monthString = aktualniDatumCas.ToLongDateString();

            int x = monthString.IndexOf(' ');
            int y = monthString.IndexOf(' ', x+1);
            int z = monthString.IndexOf(' ', y + 1);
            monthString = monthString.Remove(z);
            monthString = monthString.Remove(0, y);
            monthString = monthString.Trim();

            for(int i = 0; i < mesice.Count(); i++)
            {
                if(mesice.ElementAt(i).Key == monthString)
                {
                    Console.WriteLine(mesice.ElementAt(i).Value);
                }
            }

            Console.ReadKey();
        }
    }
}
