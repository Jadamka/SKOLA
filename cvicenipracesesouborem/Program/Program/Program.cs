using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> db = new List<string>();

            StreamReader cteni = new StreamReader("Input.txt");

            string line = "";
            while((line = cteni.ReadLine()) != null)
            {
                string[] hodnoty = line.Split(',');

                db.Add($"{hodnoty[3].Trim()};{hodnoty[0].Trim()};{hodnoty[2].Trim()};{hodnoty[1].Trim()};{hodnoty[4].Trim()}");
            }

            cteni.Close();

            foreach(string a in db)
            {
                Console.WriteLine(a);
            }

            Console.ReadKey();
        }
    }
}
