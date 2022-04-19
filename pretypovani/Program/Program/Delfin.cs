using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Delfin : Zvire
    {
        public int Delka { get; protected set; }

        public Delfin(string jmeno, int vaha, int delka) : base(jmeno, vaha)
        {
            Delka = delka;
        }

        public void Plav()
        {
            Console.WriteLine("Plavu");
            Console.ReadKey();
        }
    }
}
