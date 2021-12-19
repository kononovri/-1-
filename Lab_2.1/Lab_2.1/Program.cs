using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координату по оси X первой вершины прямоугольника");
            short x1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите координату по оси Y первой вершины прямоугольника");
            short y1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите координату по оси X противоположной вершины прямоугольника");
            short x2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите координату по оси Y противоположной вершины прямоугольника");
            short y2 = Convert.ToInt16(Console.ReadLine());
            int Perimetr = (Math.Abs(x2) - Math.Abs(x1)) * 2 + (Math.Abs(y2) - Math.Abs(y1)) * 2;
            int S = (Math.Abs(x2) - Math.Abs(x1)) * (Math.Abs(y2) - Math.Abs(y1));
            Console.WriteLine("Периметр заданного прямоугольника составляет {0}", Perimetr);
            Console.WriteLine("Площадь заданного прямоугольника составляет {0}", S);
            Console.WriteLine("Для завершения нажмите любую клавишу на клавиатуре");
            Console.ReadKey();
        }
    }
}
