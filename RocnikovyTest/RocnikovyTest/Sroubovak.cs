using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocnikovyTest
{
    class Sroubovak : Naradi
    {
        public Sroubovak(string nazev, int vaha) : base(nazev, vaha)
        {

        }

        public override string Pracuj()
        {
            return "Šroubuji";
        }
    }
}
