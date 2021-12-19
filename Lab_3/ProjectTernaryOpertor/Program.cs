using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTernaryOpertor
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            int max = (firstNumber > secondNumber) ? firstNumber : secondNumber;
            Console.WriteLine(max);
            Console.ReadKey();
        }
    }
}
