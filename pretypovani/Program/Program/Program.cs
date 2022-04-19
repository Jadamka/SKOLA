using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Zvire> zvirata = new List<Zvire>();
            Zvire p1 = new Pes("Rex", "neznam", 20);
            Zvire p2 = new Pes("Rox", "neznam", 15); 

            Zvire d1 = new Delfin("Wor", 40, 20);
            Zvire d2 = new Delfin("Kurl", 50, 35);

            zvirata.Add(p1);
            zvirata.Add(p2);
            zvirata.Add(d1);
            zvirata.Add(d2);

            // průchod listem a pokud bude zvíře pes, zaštěká
            foreach(Zvire zvire in zvirata)
            {
                if(zvire is Pes)
                {
                    ((Pes)zvire).Stekej();
                }
            }

            Console.Clear();

            int pocetP = 0;
            int pocetD = 0;
            foreach (Zvire zvire in zvirata)
            {
                if (zvire is Pes)
                    pocetP++;
                else if (zvire is Delfin)
                    pocetD++;
            }

            Console.WriteLine($"Počet psů: {pocetP}\nPočet delfínů: {pocetD}");

            Console.ReadKey();
        }
    }
}
