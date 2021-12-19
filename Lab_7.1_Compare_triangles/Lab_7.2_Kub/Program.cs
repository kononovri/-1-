using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7._2_Kub
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра куба");
            int a = Convert.ToInt32(Console.ReadLine());
            Kub(a, out double V, out double S);
            if (a > 0)
            {
                Console.WriteLine("Объем куба равен {0}", V);
                Console.WriteLine("Площадь поверхности куба равна {0}", S);
                Console.ReadKey();
            }
            else Console.WriteLine("Вы ввели некорректную длину");
            Console.ReadKey();
        }
        static void Kub(int a, out double V, out double S)
        {
            V = Math.Pow(a, 3);
            S = 6 * a * a;
        }

    }

}