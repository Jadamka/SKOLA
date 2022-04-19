using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dedeni
{
    // Trida pro vytvareni potomku
    class Auto
    {
        public string Nazev { get; private set; }
        public float Spotreba { get; private set; }
        public int MaxRychlost { get; private set; }

        public Auto(string nazev, float spotreba, int max)
        {
            Nazev = nazev;
            Spotreba = spotreba;
            MaxRychlost = max;
        }

        public void Jizda()
        {
            Console.WriteLine("Jedu!");
        }
    }
}
