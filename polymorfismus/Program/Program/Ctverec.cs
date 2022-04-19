using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Ctverec
    {
        public string Barva { get; private set; }
        public double StranaA { get; private set; }

        public Ctverec(string barva, double stranaA)
        {
            Barva = barva;
            StranaA = stranaA;
        }

        public virtual double Obsah()
        {
            return StranaA * StranaA;
        }

        public virtual double Obvod()
        {
            return 4 * StranaA;
        }
    }
}
