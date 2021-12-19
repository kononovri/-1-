using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 7 чисел через пробел для заполнения массива");
            int[] array = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            Console.WriteLine("Заполненный с клавиатуры массив чисел:");
            float S = 0;
            for (int i = 0; i < 7; i++)
            {
                Console.Write("{0} ", array[i]);
                S += array[i];
            }
            Console.WriteLine();
            Console.WriteLine("Среднее арифметическое значение элементов массива: {0:f2}", S / 7);
            Console.ReadKey();
        }



    }
}
