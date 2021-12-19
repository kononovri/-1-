using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координату по оси X первой вершины прямоугольника");
            short x1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите координату по оси Y первой вершины прямоугольника");
            short y1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите координату по оси X второй вершины прямоугольника");
            short x2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите координату по оси Y второй вершины прямоугольника");
            short y2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите координату по оси X третьей вершины прямоугольника");
            short x3 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите координату по оси Y третьей вершины прямоугольника");
            short y3 = Convert.ToInt16(Console.ReadLine());
            short x4;
            short y4;
            if ((x1 == x2 && y1 == y2) || (x1 == x3 && y1 == y3) || (x3 == x2 && y3 == y2))
            {
                Console.WriteLine("Ошибка, вы ввели некорректные координаты прямоугольника");
            }
            else {
                if ((x1 == x2 || x2 == x3 || x3 == x1) && (y1 == y2 || y2 == y3 || y3 == y1))
                {
                    if (x1 == x2)
                    {
                        x4 = x3;
                    }
                    else if (x1 == x3)
                    {
                        x4 = x2;
                    }
                    else
                    {
                        x4 = x1;
                    }
                    if (y1 == y2)
                    {
                        y4 = y3;
                    }
                    else {
                        if (y1 == y3)
                        {
                            y4 = y2;
                        }
                        else
                        {
                            y4 = y1;
                        }
                     }
                    Console.WriteLine("Координаты четвертой вершины прямоугольника x4 = {0}, y4 = {1}", x4, y4);
                }
                else
                {
                    Console.WriteLine("Ошибка, стороны прямоугольника не параллельны осям координат");
                }
             }
            Console.ReadKey();
        }
        
    }
}
