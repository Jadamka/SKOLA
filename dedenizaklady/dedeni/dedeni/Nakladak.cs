using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dedeni
{
    // Potomek, který dědí ze třídy Auto(Předek)
    class Nakladak : Auto
    {
        public int MaxNaklad { get; private set; }

        public Nakladak(string nazev, float spotreba, int max, int maxNaklad): base(nazev, spotreba, max)
        {
            MaxNaklad = maxNaklad;
        }

        public void NalozNaklad()
        {
            Console.WriteLine("Naložil jsem náklad");
        }
    }
}
