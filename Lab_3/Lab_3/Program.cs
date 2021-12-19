using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int absoluteValue;
            if (number > 0)
            {
                absoluteValue = number;
            }
            else
            {
                absoluteValue = -number;
            }
            Console.WriteLine(absoluteValue);
            Console.ReadKey();
        }
    }
}
