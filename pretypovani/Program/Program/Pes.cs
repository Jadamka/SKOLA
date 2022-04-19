using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Pes : Zvire
    {
        public string Rasa { get; private set; }

        public Pes(string jmeno, string rasa, int vaha) : base(jmeno, vaha)
        {
            Rasa = rasa;
        }

        public void Stekej()
        {
            Console.WriteLine("Štěkám");
            Console.ReadKey();
        }
    }
}
