using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
    
            Kadry kadry1 = new Kadry();
            kadry1.Fam = "Иванов";
            kadry1.Age = 30;
            kadry1.Dol = "Инженер";
            kadry1.Staj = 10;
            kadry1.Display();

            Kadry kadry2 = new Kadry("Петров", 40, "Менеджер", 15);
            kadry2.Display();

            Console.Write("Введите фамилию: ");
            string fam = Console.ReadLine();
            Console.Write("Введите возраст: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Введите должность: ");
            string dol = Console.ReadLine();
            Console.Write("Введите стаж: ");
            int staj = int.Parse(Console.ReadLine());

            Kadry kadry3 = new Kadry(fam, age, dol, staj);
            kadry3.Display();
        }
    }
}
