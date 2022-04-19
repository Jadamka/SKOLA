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
            Ctverec ctverec = new Ctverec("červený", 10);
            Obdelnik obdelnik = new Obdelnik("modrý", 10, 5);

            Console.WriteLine($"Obsah čtverce: {ctverec.Obsah()}");
            Console.WriteLine($"Obvod čtverce: {ctverec.Obvod()}");
            Console.WriteLine($"Obsah obdelníku: {obdelnik.Obsah()}");
            Console.WriteLine($"Obvod obdelníku: {obdelnik.Obvod()}");

            Console.ReadKey();
        }
    }
}
