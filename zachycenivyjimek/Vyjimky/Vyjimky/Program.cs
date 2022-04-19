using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// Program zkusí načíst hodnotu z klávesnice a převést ji na datový typ int
/// pokud se mu to nepodaří, vypíše chybu proč.....
/// </summary>

namespace Vyjimky
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadej cislo: ");
            byte cislo;
            try
            {
                cislo = byte.Parse(Console.ReadLine());
            }

            catch (FormatException f)
            {
                Console.WriteLine(f.Message);
            }
            catch (OverflowException o)
            {
                Console.WriteLine(o.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            finally
            {
                Console.WriteLine("Tohle se provede vždy, ať chyba nastane nebo ne");
            }

            Console.ReadKey();
        }
    }
}
