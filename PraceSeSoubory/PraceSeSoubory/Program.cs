using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraceSeSoubory
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
                string[] hodnota = line.Split(',');

                db.Add($"{hodnota[3].Trim()};{hodnota[0].Trim()};{hodnota[2].Trim()};{hodnota[1].Trim()};{hodnota[4].Trim()}");
            }

            cteni.Close();

            StreamWriter zapis = new StreamWriter("Output.txt");

            foreach(string a in db)
            {
                zapis.WriteLine(a);
            }

            zapis.Close();

            Console.ReadKey();
        }
    }
}
