using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Databaze
    {
        public List<Hra> Db { get; private set; }

        public Databaze()
        {
            Db = new List<Hra>();
        }

        public void VlozitHru()
        {
            Console.Clear();
            string nazev;
            string vyrobce;
            int rok;
            int pegi;

            Console.Write("Nazev: ");
            nazev = Console.ReadLine();
            Console.Write("Vyrobce: ");
            vyrobce = Console.ReadLine();
            Console.Write("Rok: ");
            rok = int.Parse(Console.ReadLine());
            Console.Write("Pegi: ");
            pegi = int.Parse(Console.ReadLine());

            Db.Add(new Hra(nazev, rok, vyrobce, pegi));

            Console.WriteLine("Hra byla úspěšně vložena do databáze, stisknutím libovolné klávesy pokračuj.");
            Console.ReadKey();
        }

        public void VypsatVsechnyHry()
        {
            Console.Clear();
            foreach(Hra a in Db)
            {
                a.Info();
                Console.WriteLine();
            }
            Console.WriteLine("Výpis skončil... stisknutím libovolné klávesy pokračuj");
            Console.ReadKey();
        }

        public void VypsatPodlePristupnosti()
        {
            Console.Clear();
            Console.WriteLine("Vyber jednu z možností:");
            Console.WriteLine("\n1. dětské hry");
            Console.WriteLine("2. mládeži přístupné");
            Console.WriteLine("3. mládeži nepřístupně");
            int volba = int.Parse(Console.ReadLine());
            string pristupnost = "";

            switch (volba)
            {
                case 1:
                    pristupnost = "dětská hra";
                    break;
                case 2:
                    pristupnost = "mp";
                    break;
                case 3:
                    pristupnost = "mn";
                    break;
                default:
                    pristupnost = "0";
                    Console.WriteLine("Špatná hodnota...");
                    Console.ReadKey();
                    break;
            }

            Console.Clear();
            foreach(Hra a in Db)
            {
                if(pristupnost == a.Pristupnost)
                {
                    a.Info();
                    Console.WriteLine();
                }
            }
            Console.WriteLine("Výpis skončil... stisknutím libovolné klávesy pokračuj");
            Console.ReadKey();
        }

        public void VypsatPodleVyrobce()
        {
            Console.Clear();
            string vyrobce;
            Console.Write("Jakého výrobce hledáta: ");
            vyrobce = Console.ReadLine();

            Console.Clear();
            foreach(Hra a in Db)
            {
                if(vyrobce == a.vyrobce)
                {
                    a.Info();
                    Console.WriteLine();
                }
            }
            Console.WriteLine("Výpis skončil... stisknutím libovolné klávesy pokračuj");
            Console.ReadKey();
        }

        public void SmazatHru()
        {
            int x = 1;
            foreach(Hra a in Db)
            {
                Console.WriteLine($"{x}. {a.Nazev}");
                x++;
            }

            if (Db.Any())
            {
                Console.Write("Vyberte pozici hry, kterou chcete smazat: ");
                int volba = int.Parse(Console.ReadLine());
                volba--;
                if (volba < 0 || volba >= Db.Count)
                {
                    Console.WriteLine("Moc malý nebo moc velký index");
                    Console.ReadKey();
                }
                else
                    Db.RemoveAt(volba);
            }
            else
            {
                Console.WriteLine("Databáze je prázdná nejdřív ji naplň");
                Console.ReadKey();
            }
        }
    }
}
