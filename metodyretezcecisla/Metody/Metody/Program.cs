using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metody
{
    class Program
    {
        static void Main(string[] args)
        {
            // základní výpočetní operace
            /// 

            // výpočet aboslutní hodnota
            Console.WriteLine("Math.Abs(-5.5) = {0}", Math.Abs(-5.5));

            // vrácení nejbližšího většího celého čísla (zaokrouhlení vždy nahoru)
            Console.WriteLine("Math.Ceiling(3.1) = {0}", Math.Ceiling(3.1));

            // vrácení nejbližšího menšího celého čísla (zaokrouhlení vždy dolu)
            Console.WriteLine("Math.Floor(3.7) = {0}", Math.Floor(3.7));

            // výpočet mocniny
            Console.WriteLine("Math.Pow(3,4) = {0}", Math.Pow(3, 4));

            // výpočet odmocniny
            Console.WriteLine("Math.Sqrt(85) = {0}", Math.Sqrt(85));

            // zaokrouhlení - podle pravidel
            Console.WriteLine("Math.Round(5.2) = {0}", Math.Round(5.2));
            Console.WriteLine("Math.Round(5.5) = {0}", Math.Round(5.5));

            Console.WriteLine();

            /// základní metody pro práci s řetězci
            /// 

            // sloučení řetězců do jednoho za pomoci +
            string prvniSlovo = "nejaky text";
            string druhySlovo = " dalsi text";
            string tretiSlovo = " posledni text";
            string spojeniSlov = prvniSlovo + druhySlovo + tretiSlovo;
            Console.WriteLine("\nSpojený řetězec: {0}",spojeniSlov);

            // sloučení pole řetězců do jednoho řetězce
            string[] poleRetezcu = {"prvni prvek pole", "druhy prvek pole", "treti prvek pole"};
            Console.WriteLine("\nString.Concat(poleRetezcu) = {0}", String.Concat(poleRetezcu));

            // zjisteni zda jde o prazdny retezec - vrati true/false
            
            Console.WriteLine("\nstring.IsNullOrEmpty(\"ahoj\") = {0}", string.IsNullOrEmpty("ahoj"));
            Console.WriteLine("string.IsNullOrEmpty(\"\") = {0}", string.IsNullOrEmpty(""));

            // zjisteni znaku v retezci
            string text = "abcdefghijk";
            Console.WriteLine("\nProhledej retezec: {0}", text);
            Console.WriteLine("text.Contains(\"l\") = {0}", text.Contains("l"));
            Console.WriteLine("text.Contains(\"b\") = {0}", text.Contains("b"));
            Console.WriteLine("text.Contains(\"abc\") = {0}", text.Contains("abc"));
            Console.WriteLine("text.Contains(\"abq\") = {0}", text.Contains("abq"));

            // zjisteni poctu znaku v retezci - bere i mezery
            Console.WriteLine("\ntext.Length = {0}", text.Length);

            // zjisteni, zda retezec konci konkretnim retezcem
            Console.WriteLine("\ntext.EndsWith(\"ijk\") = {0}", text.EndsWith("ijk"));
            Console.WriteLine("text.EndsWith(\"abc\") = {0}", text.EndsWith("abc"));

            // zjisteni, zda retezec zacina konkretnim retezcem
            Console.WriteLine("\ntext.StartWith(\"ijk\") = {0}", text.StartsWith("ijk"));
            Console.WriteLine("text.StartWith(\"abc\") = {0}", text.StartsWith("abc"));

            // string - je pole znaku
            Console.WriteLine("\nProhledavany retezec: {0}", text);
            Console.WriteLine("text[1] = {0}", text[1]);
            Console.WriteLine("text[5] = {0}", text[5]);

            // hledani indexu(pozice) konkretniho prvku v retezci - vrati index prvku
            // pokud je znak nenalazen vrati -1
            text = "jan.adamka";
            Console.WriteLine("\nProhledavany retezec: {0}", text);
            Console.WriteLine("text.IndexOf('.') = {0}",text.IndexOf('.'));
            Console.WriteLine("text.IndexOf(';') = {0}", text.IndexOf(';'));

            // hledani indexu prvku od urcite pozice
            Console.WriteLine("\nProhledavany retezec: {0}", text);
            Console.WriteLine("text.IndexOf('a',4) = {0}", text.IndexOf('a',4));
            Console.WriteLine("text.IndexOf('.',5) = {0}", text.IndexOf('.', 4));

            // odstraneni znaku z retezce
            string upravenyText = text.Remove(3);
            Console.WriteLine("\nText k uprave: {0}", text);
            Console.WriteLine("Upraveny text: {0}", upravenyText);

            upravenyText = text.Remove(2,3);
            Console.WriteLine("\nText k uprave: {0}", text);
            Console.WriteLine("Upraveny text: {0}", upravenyText);

            // vytvoreni podretezce z retezce od urciteho indexu
            upravenyText = text.Substring(2);
            Console.WriteLine("\nText k uprave: {0}", text);
            Console.WriteLine("Upraveny text: {0}", upravenyText);

            // podretezec od zadaneho indexu + pocet prvku
            upravenyText = text.Substring(2, 5);
            Console.WriteLine("\nText k uprave: {0}", text);
            Console.WriteLine("Upraveny text pomoci upravenyText = text.Substring(2,5): {0}", upravenyText);

            // prevedeni textu na velka pismena
            Console.WriteLine("\nText k uprave: {0}", text);
            Console.WriteLine("text.ToUpper(): {0}", text.ToUpper());
            text = text.ToUpper();

            // prevedeni textu na mala pismena
            Console.WriteLine("\nText k uprave: {0}", text);
            Console.WriteLine("text.ToLower(): {0}", text.ToLower());
            text = text.ToLower();

            // nahrazeni znaku/retezce jinym znakem/retezcem
            text = "jan.adamka; Jan Adamka";
            Console.WriteLine("\nText k uprave: {0}", text);
            text = text.Replace(';', ',');
            Console.WriteLine("Upraveny text: {0}", text);

            string jmeno = "Novak";
            Console.WriteLine("\nPuvodni jmeno: {0}", jmeno);
            jmeno = jmeno.Replace("ak", "áková");
            Console.WriteLine("Prejmenovano pomoci replace: {0}", jmeno);

            // odstraneni netisknutelnych znaku na zacatku a na konci retezce
            jmeno = "     Jan Adamka   ";
            Console.WriteLine("Zadane jmeno: {0}", jmeno);
            jmeno = jmeno.Trim();
            Console.WriteLine("Otrimovane jmeno: {0}", jmeno);

            jmeno = "   Jan Adamka";
            jmeno = jmeno.TrimStart();
            Console.WriteLine("Otrimovane na zacatku: {0}", jmeno);

            jmeno = "Jan Adamka   ";
            jmeno = jmeno.TrimEnd();
            Console.WriteLine("Otrimovane na konci: {0}", jmeno);

            jmeno = "....Jan....";
            Console.WriteLine("Puvodni jmeno: {0}", jmeno);
            jmeno = jmeno.Trim('.');
            Console.WriteLine("Jmeno otrimovano o tecky: {0}", jmeno);

            DateTime date = DateTime.Now;
            Console.WriteLine(date);


            Console.ReadKey();
        }
    }
}
