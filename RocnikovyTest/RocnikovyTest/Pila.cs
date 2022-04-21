using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocnikovyTest
{
    class Pila : Naradi
    {
        public Pila(string nazev, int vaha) : base(nazev, vaha)
        {

        }

        public override string Pracuj()
        {
            return "Řežu";
        }
    }
}
