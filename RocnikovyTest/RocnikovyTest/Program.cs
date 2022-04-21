using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocnikovyTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Bedna bedna = new Bedna(10000, 0);

            int volba = -1;

            do
            {
                Console.WriteLine("1. Přidat nářadí");
                Console.WriteLine("2. Vypsat všechny nástroje v bedně");
                Console.WriteLine("3. Nechat všechny nástroje pracovat");
                Console.WriteLine("4. Vypsat součet vah všech jednoručních kladiv v bedně");
                Console.WriteLine("0. Ukončit program...");
                try
                {
                    volba = int.Parse(Console.ReadLine());
                    switch (volba)
                    {
                        case 1:
                            Console.WriteLine("Vyberte typ předmětu");
                            Console.WriteLine("1. Pila");
                            Console.WriteLine("2. Šroubovák");
                            Console.WriteLine("3. Kladivo");
                            Console.WriteLine("4. Elektrický šroubovák");
                            try
                            {
                                string nazev;
                                int vaha;
                                int predmet = int.Parse(Console.ReadLine());
                                switch (predmet)
                                {
                                    case 1:
                                        Console.Clear();
                                        Console.Write("Název: ");
                                        nazev = Console.ReadLine();
                                        Console.Write("Váha: ");
                                        vaha = int.Parse(Console.ReadLine());
                                        bedna.Vlozit(new Pila(nazev, vaha));
                                        break;
                                    case 2:
                                        Console.Clear();
                                        Console.Write("Název: ");
                                        nazev = Console.ReadLine();
                                        Console.Write("Váha: ");
                                        vaha = int.Parse(Console.ReadLine());
                                        bedna.Vlozit(new Sroubovak(nazev, vaha));
                                        break;
                                    case 3:
                                        Console.Clear();
                                        Console.Write("Název: ");
                                        nazev = Console.ReadLine();
                                        Console.Write("Váha: ");
                                        vaha = int.Parse(Console.ReadLine());
                                        Console.Write("Obouruční ano/ne: ");
                                        string obourucni = Console.ReadLine();
                                        if (obourucni == "ano")
                                            bedna.Vlozit(new Kladivo(nazev, vaha, true));
                                        else
                                            bedna.Vlozit(new Kladivo(nazev, vaha, false));
                                        break;
                                    case 4:
                                        Console.Clear();
                                        Console.Write("Název: ");
                                        nazev = Console.ReadLine();
                                        Console.Write("Váha: ");
                                        vaha = int.Parse(Console.ReadLine());
                                        Console.Write("Kapacita baterie (Ah): ");
                                        int kapacita = int.Parse(Console.ReadLine());
                                        bedna.Vlozit(new ElektrickySroubovak(nazev, vaha, kapacita));
                                        break;
                                    default:
                                        Console.WriteLine("Taková možnost tu není");
                                        break;
                                }
                            }
                            catch(Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            break;
                        case 2:
                            bedna.CoJeUvnitr();
                            break;
                        case 3:
                            bedna.Prace();
                            break;
                        case 4:
                            int vahaKladiv = 0;
                            foreach(Naradi a in bedna.bedna)
                            {
                                if(a is Kladivo)
                                {
                                    if (!((Kladivo)a).Obourucni)
                                    {
                                        vahaKladiv += a.Vaha;
                                    }
                                }
                            }

                            Console.WriteLine($"Hmotnost všech jednoručních kladiv: {vahaKladiv}");
                            Console.ReadKey();
                            break;
                        case 0:
                            Console.WriteLine("Ukončuji program...");
                            Console.ReadKey();
                            break;
                        default:
                            Console.WriteLine("Taková možnost tu není");
                            Console.ReadKey();
                            break;
                    }

                    Console.Clear();
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            } while (volba != 0);

            Console.ReadKey();
        }
    }
}
