using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocnikovyTest
{
    class Naradi
    {
        public string Nazev { get; private set; }
        public int Vaha { get; private set; }

        public Naradi(string nazev, int vaha)
        {
            Nazev = nazev;
            Vaha = vaha;
        }

        public virtual string Pracuj()
        {
            return "Pracuju";
        }
    }
}
