using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12._1
{
    class Program
    {
        static public void Main(string[] args)
        {
            Console.WriteLine("Введите величину радиуса окружности:");
            try
            {
                double radius = Convert.ToDouble(Console.ReadLine());
                if (radius > 0)
                {

                    Console.WriteLine("Введите координаты центра окружности x0 и y0:");
                    double x0 = Convert.ToDouble(Console.ReadLine());
                    double y0 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите координаты точки x1 и y1:");
                    double x1 = Convert.ToDouble(Console.ReadLine());
                    double y1 = Convert.ToDouble(Console.ReadLine());
                    Circle.Length(radius);
                    Circle.Square(radius);
                    Circle.Point(radius, x0, y0, x1, y1);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Ошибка! Введено отрицательное значение радиуса");
                    Console.ReadKey();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка! Входная строка имела неверный формат");
                Console.ReadKey();
            }
        }
    }
    static class Circle
    {
        static double length;
        static double square;
        static double hypo;

        public static void Length(double radius)
        {
            length = 2 * Math.PI * radius;
            Console.WriteLine("Длина окружности с радиусом {0} составляет {1:F2}", radius, length);
        }
        public static void Square(double radius)
        {
            square = Math.PI * radius * radius;
            Console.WriteLine("Площадь окружности с радиусом {0} составляет {1:F2}", radius, square);
        }
        public static void Point(double radius, double x0, double y0, double x1, double y1)
        {

            hypo = Math.Sqrt(Math.Pow(x1 - x0, 2) + Math.Pow(y1 - y0, 2));
            if (hypo <= radius)
            {
                Console.WriteLine("Точка лежит в круге");
            }
            else
            {
                Console.WriteLine("Точка лежит вне круга");
            }
        }

    }
}
