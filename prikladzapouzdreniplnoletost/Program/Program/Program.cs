using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Clovek franta = new Clovek("Franta", "Omáčka", 16);
            franta.Info();

            Console.ReadKey();
        }
    }
}
