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
            Menu menu = new Menu();

            char volba;
            do
            {
                volba = menu.VypsatMenu();
                switch (volba)
                {
                    case '1':
                        db.VlozitHru();
                        break;
                    case '2':
                        db.VypsatVsechnyHry();
                        break;
                    case '3':
                        db.VypsatPodlePristupnosti();
                        break;
                    case '4':
                        db.VypsatPodleVyrobce();
                        break;
                    case '5':
                        db.SmazatHru();
                        break;
                    case 'k':
                        Console.WriteLine("Ukončuji program...");
                        break;
                    default:
                        Console.WriteLine("Špatná volba... pomocí stisknutí libovolné klávesy pokračuj");
                        Console.ReadKey();
                        break;
                }

            } while (volba != 'k');

            Console.ReadKey();
        }
    }
}
