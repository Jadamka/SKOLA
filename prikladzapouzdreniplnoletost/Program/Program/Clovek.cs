using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Clovek
    {
        public string Jmeno { get; private set; }
        public string Prijmeni { get; private set; }
        public bool PlnoLetost { get; private set; }

        private int vek;
        public int Vek
        {
            get
            {
                return vek;
            }
            set
            {
                vek = value;
                if(vek < 18)
                {
                    PlnoLetost = false;
                }
                else
                {
                    PlnoLetost = true;
                }
            }
        }

        public Clovek(string jmeno, string prijmeni, int vek)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Vek = vek;
        }

        public void Info()
        {
            Console.WriteLine($"\nJmeno: {Jmeno}\nPrijmeni: {Prijmeni}\nVek: {vek}\nPlnoletost: {PlnoLetost}");
        }
    }
}
