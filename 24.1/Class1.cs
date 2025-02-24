using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._1
{
    internal class Avto
    {
 
        string brand;
        string color;
        double skor;

        public string Brand { get { return brand; } set { brand = value; } }
        public string Color { get { return color; } set { color = value; } }
        public double Skor { get { return skor; } set { if (value < 20) { skor = 20; } else if (value > 120) { skor = 120; } else { skor = value; } } }
 
        public Avto() { }
 
        public Avto(string brand, string color, double skor)
        {
            this.Brand = brand;
            this.Color = color;
            this.Skor = skor;
        }
        public override string ToString()
        {
            return $"Brand = {Brand}, Color = {Color}, Skor = {Skor}";
        }
    }
}
