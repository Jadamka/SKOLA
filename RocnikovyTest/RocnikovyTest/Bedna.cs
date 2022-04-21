using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocnikovyTest
{
    class Bedna
    {
        public List<Naradi> bedna { get; private set; }
        public int Nosnost { get; private set; }
        public int VahaNaradi { get; private set; }

        public Bedna(int nosnost, int vahaNaradi)
        {
            Nosnost = nosnost;
            VahaNaradi = vahaNaradi;
            bedna = new List<Naradi>();
        }

        public void Vlozit(Naradi naradi)
        {
            Console.Clear();

            if((VahaNaradi+naradi.Vaha) > Nosnost)
            {
                Console.WriteLine("Překročen váhový limit, vložte něco lehčího, nebo něco z bedny vyndejte");
            }
            else
            {
                VahaNaradi += naradi.Vaha;
                bedna.Add(naradi);
                Console.WriteLine("Předmět vložen do bedny");
            }

            Console.ReadKey();
        }

        public void CoJeUvnitr()
        {
            Console.Clear();

            if(bedna.Count > 0)
            {
                foreach (Naradi a in bedna)
                {
                    Console.WriteLine(a.Nazev);
                }
            }
            else
            {
                Console.WriteLine("Žádné nářadí tu není");
            }

            Console.ReadKey();
        }

        public void Prace()
        {
            Console.Clear();

            if(bedna.Count > 0)
            {
                foreach (Naradi a in bedna)
                {
                    Console.WriteLine(a.Pracuj());
                }
            }
            else
            {
                Console.WriteLine("Nemáš nic s čím bys mohl pracoval");
            }

            Console.ReadKey();
        }
    }
}
