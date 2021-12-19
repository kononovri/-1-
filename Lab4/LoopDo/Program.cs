using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopDo
{
    class Program
    {
        static void Main(string[] args)
        {
            double Sum = 1000;
            double Sum2 = Sum * 2;
            double p = 4;
            int year = 0;
            do
            {
                Sum += Sum * 4 / 100;
                year++;
            } while (Sum < Sum2);
            Console.WriteLine(year);
            Console.ReadKey();
        }
    }
}
