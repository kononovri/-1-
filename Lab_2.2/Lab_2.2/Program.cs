using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координату по оси X первой вершины треугольника");
            short x1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите координату по оси Y первой вершины треугольника");
            short y1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите координату по оси X второй вершины треугольника");
            short x2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите координату по оси Y второй вершины треугольника");
            short y2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите координату по оси X третьей вершины треугольника");
            short x3 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите координату по оси Y третьей вершины треугольника");
            short y3 = Convert.ToInt16(Console.ReadLine());
            double a = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow(y1 - y2, 2));
            double b = Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow(y3 - y2, 2));
            double c = Math.Sqrt(Math.Pow((x1 - x3), 2) + Math.Pow(y1 - y3, 2));
            double P = Math.Round(a + b + c, 2);
            double PoluP = (a + b + c) / 2;
            double S = Math.Round(Math.Sqrt(PoluP * (PoluP - a) * (PoluP - b) * (PoluP - c)), 2);
            Console.WriteLine("Периметр заданного треугольника составляет {0}", P);
            Console.WriteLine("Площадь заданного треугольника составляет {0}", S);
            Console.WriteLine("Для завершения нажмите любую клавишу на клавиатуре");
            Console.ReadKey();
        }   
    }
}
