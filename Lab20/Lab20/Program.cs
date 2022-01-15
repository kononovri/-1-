using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20
{
    class Program
    {
        delegate double Circle(double r);
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус окружности:");
            double r = Convert.ToDouble(Console.ReadLine());
            Circle circle = new Circle(Length);
            circle += Area;
            circle += Volume;
            circle?.Invoke(r);
            Console.ReadKey();
        }
        static double Length(double r)
        {
            double length = 2 * Math.PI * r;
            Console.WriteLine($"Длина окружности L={String.Format("{0:F}", length)};");
            return length;
        }
        static double Area(double r)
        {
            double area = Math.PI * r * r;
            Console.WriteLine($"Площадь круга S={String.Format("{0:F}", area)};");
            return area;
        }
        static double Volume(double r)
        {
            double volume = 4 / 3 * Math.PI * r * r * r;
            Console.WriteLine($"Объём шара V={String.Format("{0:F}", volume)}.");
            return volume;
        }
    }
}
