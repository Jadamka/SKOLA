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
            Databaze db = new Databaze();
            
            db.StartImport();

            string volba="";

            do
            {
                Console.Clear();
                Console.WriteLine("Menu");
                Console.WriteLine("####");
                Console.WriteLine("\n1. Ruční přidání člověka");
                Console.WriteLine("2. Vypsání všech");
                Console.WriteLine("3. Přidat lidi ze souboru Import.txt");
                Console.WriteLine("\n\tk - Konec programu");
                Console.WriteLine("#######################");
                Console.Write("Volba: ");
                volba = Console.ReadLine();

                switch (volba)
                {
                    case "1":
                        db.VlozeniCloveka();
                        break;
                    case "2":
                        db.VypisVsech();
                        break;
                    case "3":
                        db.Import();
                        break;
                    case "k":
                        break;
                    default:
                        Console.WriteLine("Špatná volba...");
                        Console.ReadKey();
                        break;
                }

            } while (volba != "k");

            db.ExportPriUkonceni();

            Console.ReadKey();
        }
    }
}
