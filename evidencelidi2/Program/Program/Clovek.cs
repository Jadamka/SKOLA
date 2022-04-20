using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Clovek
    {
        public string Jmeno { get; private set; }
        public string Prijmeni { get; private set; }
        public DateTime DatumNarozeni { get; private set; }

        public Clovek(string jmeno, string prijmeni, DateTime datumNarozeni)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            DatumNarozeni = datumNarozeni;
        }

        public void Info()
        {
            Console.WriteLine($"Jméno a Přijmení: {Jmeno} {Prijmeni}\nDatum narození: {DatumNarozeni}\n");
        }
    }
}
