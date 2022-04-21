using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocnikovyTest
{
    class ElektrickySroubovak : Sroubovak
    {
        public int Kapacita { get; private set; }

        public ElektrickySroubovak(string nazev, int vaha, int kapacita) : base(nazev, vaha)
        {
            Kapacita = kapacita;
        }
    }
}
