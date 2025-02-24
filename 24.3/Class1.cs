using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._3
{
    internal class Kadry
    {
        private string fam;
        private int age;
        private string dol;
        private int staj;

        public Kadry()
        {
            fam = "";
            age = 16;
            dol = "";
            staj = 0;
        }

        public Kadry(string fam, int age, string dol, int staj)
        {
            this.Fam = fam;
            this.Age = age;
            this.Dol = dol;
            this.Staj = staj;
        }

        public string Fam
        {
            get { return fam; }
            set { fam = value; }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 16 && value <= 60)
                    age = value;
                else
                    throw new ArgumentException("Возраст должен быть в пределах от 16 до 60 лет.");
            }
        }

        public string Dol
        {
            get { return dol; }
            set { dol = value; }
        }

        public int Staj
        {
            get { return staj; }
            set
            {
                if (value >= 0 && value <= 45)
                    staj = value;
                else
                    throw new ArgumentException("Стаж должен быть в пределах от 0 до 45 лет.");
            }
        }

        public void Display()
        {
            Console.WriteLine($"Фамилия: {fam}, Возраст: {age}, Должность: {dol}, Стаж: {staj}");
        }
    }

}

