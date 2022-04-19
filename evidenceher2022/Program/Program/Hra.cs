using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Hra
    {
        public string Nazev { get; private set; }
        public int RokVydani { get; private set; }
        public string vyrobce { get; private set; }
        public string Pristupnost { get; private set; }
        private int pegi;
        public int Pegi
        {
            get
            {
                return pegi;
            }
            private set
            {
                pegi = value;
                if (pegi < 8)
                    Pristupnost = "dětská hra";
                else if (pegi < 18)
                    Pristupnost = "mp";
                else
                    Pristupnost = "mn";
            }
        }

        public Hra(string nazev, int rok, string vyrobce, int pegi)
        {
            Nazev = nazev;
            RokVydani = rok;
            this.vyrobce = vyrobce;
            Pegi = pegi;
        }

        public void Info()
        {
            Console.WriteLine($"Nazev: {Nazev}\nRok vydání: {RokVydani}\nVýrobce: {vyrobce}\nPEGI: {pegi}\nPřístupnost: {Pristupnost}");
        }
    }
}
