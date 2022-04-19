using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Zvire
    {
        public string Jmeno { get; private set; }
        public int Vaha { get; protected set; }

        public Zvire(string jmeno, int vaha)
        {
            Jmeno = jmeno;
            Vaha = vaha;
        }
        public void Dychej()
        {
            Console.WriteLine("Dýchám...");
            Console.ReadKey();
        }
    }
}
