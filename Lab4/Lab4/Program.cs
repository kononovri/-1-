using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Введите целое положительное число N");
            int N = Convert.ToInt32(Console.ReadLine());

            if (N >= 0)
            {
                for (int a = 1; a <= 2 * N - 1; a += 2)
                {
                    sum += a;

                    Console.WriteLine("Текущее значение суммы равно {0}", sum);
                }
                Console.WriteLine("Квадрат числа {0} равен сумме квадратов целых чисел от 1 до {0} = {1}", N, N * N);
            }
            else Console.WriteLine("Ошибка, вы ввели некорректное число");

            Console.ReadKey();
        }
    }
}
