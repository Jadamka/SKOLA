using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocnikovyTest
{
    class Kladivo : Naradi
    {
        public bool Obourucni { get; private set; }
        public Kladivo(string nazev, int vaha, bool obourucni) : base(nazev, vaha)
        {
            Obourucni = obourucni;
        }

        public override string Pracuj()
        {
            return "Zatloukám";
        }
    }
}
