using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Databaze
    {
        public List<Clovek> listLidi { get; private set; }

        public Databaze()
        {
            listLidi = new List<Clovek>();
        }

        public void Vlozit(Clovek clovek)
        {
            listLidi.Add(clovek);
        }

        public void Smazat(Clovek clovek)
        {
            listLidi.Remove(clovek);
        }

        public void StartImport()
        {
            StreamReader cteni = new StreamReader("Data.txt");

            string line;

            // složení řádků v souboru: jmeno;prijmeni;rok;mesic;den
            while((line = cteni.ReadLine()) != null)
            {
                string[] hodnoty = line.Split(';');

                Vlozit(new Clovek(hodnoty[0], hodnoty[1], new DateTime(int.Parse(hodnoty[2]), int.Parse(hodnoty[3]), int.Parse(hodnoty[4]))));
            }

            cteni.Close();
        }

        public void ExportPriUkonceni()
        {
            StreamWriter zapis = new StreamWriter("Data.txt");

            foreach (Clovek clovek in listLidi)
            {
                string radekZapis = clovek.Jmeno + ";" + clovek.Prijmeni + ";" + clovek.DatumNarozeni.Year+";"+clovek.DatumNarozeni.Month+";"+clovek.DatumNarozeni.Day;

                zapis.WriteLine(radekZapis);
            }

            zapis.Close();
        }

        public void VypisVsech()
        {
            Console.Clear();
            foreach(Clovek clovek in listLidi)
            {
                clovek.Info();
            }
            Console.WriteLine("Konec výpisu, pokračuj libovolnou klávesou...");
            Console.ReadKey();
        }

        public void VlozeniCloveka()
        {
            Console.Clear();
            Console.Write("Zadej jméno: ");
            string jmeno = Console.ReadLine();
            Console.Write("Zadej přijmení: ");
            string prijmeni = Console.ReadLine();
            Console.Write("Zadej rok narození: ");
            int rok = int.Parse(Console.ReadLine());
            Console.Write("Zadej měsíc narození: ");
            int mesic = int.Parse(Console.ReadLine());
            Console.Write("Zadej den narození: ");
            int den = int.Parse(Console.ReadLine());

            Vlozit(new Clovek(jmeno, prijmeni, new DateTime(rok, mesic, den)));
            Console.WriteLine("Člověk vložen do databáze... stisknutím libovolné klávesy pokračuj");
            Console.ReadKey();
        }

        public void Import()
        {
            StreamReader cteni = new StreamReader("Import.txt");

            string line;
            while((line = cteni.ReadLine()) != null)
            {
                string[] hodnoty = line.Split(';');

                Vlozit(new Clovek(hodnoty[0], hodnoty[1], new DateTime(int.Parse(hodnoty[2]), int.Parse(hodnoty[3]), int.Parse(hodnoty[4]))));

                StreamWriter zapis = new StreamWriter("Data.txt", true);

                string lineWrite = hodnoty[0] + ";"+hodnoty[1]+";"+hodnoty[2]+";"+hodnoty[3]+";"+hodnoty[4];
                zapis.WriteLine();

                zapis.Close();
            }

            cteni.Close();

            Console.WriteLine("Import proběhl úspešně, data se automaticky exportovala do textového souboru Data... stistknutím libovolné klávesy pokračuj");
            Console.ReadKey();
        }
    }
}
