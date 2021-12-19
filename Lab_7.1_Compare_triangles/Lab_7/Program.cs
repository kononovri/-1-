using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите через пробел длины сторон треугольника A");
            int[] arrayT1 = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            Console.WriteLine("Введите через пробел длины сторон треугольника B");
            int[] arrayT2 = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            int a1 = arrayT1[0];
            int b1 = arrayT1[1];
            int c1 = arrayT1[2];
            int a2 = arrayT2[0];
            int b2 = arrayT2[1];
            int c2 = arrayT2[2];
            double S1 = GetS(a1, b1, c1);
            double S2 = GetS(a2, b2, c2);
            if (a1 + b1 > c1 && b1 + c1 > a1 && c1 + a1 > b1 && a2 + b2 > c2 && b2 + c2 > a2 && c2 + a2 > b2)
            {
                Console.WriteLine("Площадь треугольника А составляет {0:F2} ", S1);
                Console.WriteLine("Площадь треугольника B составляет {0:F2} ", S2);
                if (S1 > S2)
                {
                    Console.WriteLine("Площадь треугольника А больше площади треугольника B");
                }
                else Console.WriteLine("Площадь треугольника B больше площади треугольника A");
            }
            else Console.WriteLine("Введенные длины сторон треугольников не корректны");
            Console.ReadKey();
        }

        static double GetS(int a, int b, int c)
        {
            double halfP = (a + b + c) / 2;
            double S = Math.Sqrt(halfP * (halfP - a) * (halfP - b) * (halfP - c));
            return S;
        }
    }

}
