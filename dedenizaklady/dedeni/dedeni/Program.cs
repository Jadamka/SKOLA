using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dedeni
{
    class Program
    {
        static void Main(string[] args)
        {
            Osobak o = new Osobak("Osobak", 4.8f, 220, 4);

            o.OtevriKufr();

            Console.ReadKey();
        }
    }
}
