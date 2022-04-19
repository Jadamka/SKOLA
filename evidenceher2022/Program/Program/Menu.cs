using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Menu
    {
        public char VypsatMenu()
        {
            Console.Clear();
            Console.WriteLine("Menu:");
            Console.WriteLine("-----");
            Console.WriteLine("\n1. Vložit hru");
            Console.WriteLine("2. Vypsat všechny hry");
            Console.WriteLine("3. Výpis her podle přístupnosti");
            Console.WriteLine("4. Výpis her od zadaného výrobce");
            Console.WriteLine("5. Smazat hru z databáze");
            Console.WriteLine("\n\tk. - Konec programu");

            char inp;
            inp = Console.ReadLine()[0];

            return inp;
        }
    }
}
