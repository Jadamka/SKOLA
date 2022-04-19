using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dedeni
{
    // Potomek, který dědí ze třídy Auto(Předek)
    class Osobak : Auto
    {
        public int PocetMist { get; private set; }

        public Osobak(string nazev, float spotreba, int max, int pocetMist): base(nazev, spotreba, max)
        {
            PocetMist = pocetMist;
        }

        public void OtevriKufr()
        {
            Console.WriteLine("Otevřel jsem kufr");
        }
    }
}
