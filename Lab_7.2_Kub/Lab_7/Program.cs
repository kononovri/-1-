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
            Console.WriteLine("Введите длину ребра куба");
            int a = Convert.ToInt32(Console.ReadLine());
            int V, S;
            Kub(a, V, S);
            Console.WriteLine("Объем куба равен {0:F2}", V);
            Console.WriteLine("Площадь поверхности куба равна {0:F2}", S);
            Console.ReadKey();
        }
    }
    static void Kub(int a, out int V, out int S)
    {
        int V = Math.Pow(a, 3);
        int S = 6 * a * a;
    }
