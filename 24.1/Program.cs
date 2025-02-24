using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Avto avto = new Avto();
            Console.WriteLine(avto.ToString());
           
            Avto avto2 = new Avto("БМВ", "Желтый", 220);
            Console.WriteLine(avto2.ToString());
           
            Console.WriteLine("Введите марку");
            string brand = Console.ReadLine();
            Console.WriteLine("Введите цвет");
            string color = Console.ReadLine();
            Console.WriteLine("Введите скорость");
            double skor = double.Parse(Console.ReadLine());
            Avto avto3 = new Avto(brand, color, skor);
            Console.WriteLine($"{avto3.ToString()}\n");
            Console.ReadLine();
        }
    }
}
