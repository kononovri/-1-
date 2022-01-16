using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab23
{
    class Program
    {
        static public void Main(string[] args)
        {
            Console.WriteLine("Main начал работу");
            Console.WriteLine("Введите натуральное число для расчета факториала этого числа");
            int number = Convert.ToInt32(Console.ReadLine());
            _ = FactorialAsync(number);
            Console.WriteLine("Main закончил работу");
            Console.ReadKey();
        }
        static public void Factorial(int number)
        {
            Console.WriteLine("Factorial начал работу");

            long result = 1;
            for (long i = 1; i <= number; i++)
            {
                result *= i;
            }
            Console.WriteLine($"Факториал числа {number}!={result}");
            Console.WriteLine("Factorial закончил работу");
            Console.ReadKey();
        }
        static public async Task FactorialAsync(int number)
        {
            Console.WriteLine("FactorialAsync начал работу");
            await Task.Run(() => Factorial(number));
            Console.WriteLine("FactorialAsync закончил работу");
            Console.ReadKey();
        }
    }
}