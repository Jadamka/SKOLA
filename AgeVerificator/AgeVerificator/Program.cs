using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeVerificator
{
    class Program
    {
        static void Main(string[] args)
        {
            Human h1 = new Human("Franta", "Random", 18);

            h1.Info();

            Console.ReadKey();
        }
    }
}
