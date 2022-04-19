using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Obdelnik : Ctverec
    {
        public double StranaB { get; private set; }

        public Obdelnik(string barva, double stranaA, double stranaB) : base(barva, stranaA)
        {
            StranaB = stranaB;
        }

        public override double Obsah()
        {
            return StranaA * StranaB;
        }

        public override double Obvod()
        {
            return 2 * (StranaA + StranaB);
        }
    }
}
