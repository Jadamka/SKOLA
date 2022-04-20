using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeVerificator
{
    class Human
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public bool Adult { get; private set; }
        private int age;
        public int Age
        {
            get
            {
                return age;
            }
            private set
            {
                age = value;
                if(age < 18)
                {
                    Adult = false;
                }
                else
                {
                    Adult = true;
                }
            }
        }

        public Human(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public void Info()
        {
            Console.WriteLine($"Jmeno: {Name}\nPrijmeni: {Surname}\nAge: {age}\nDospely: {Adult}");
        }
    }
}
