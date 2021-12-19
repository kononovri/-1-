using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите через пробел коэффициенты уравнения k, b:");
            double[] ratio = Console.ReadLine().Split(' ').Select(x => double.Parse(x)).ToArray();
            Equation equation = new Equation(ratio[0], ratio[1]);
            equation.Root();
            Console.ReadKey();
        }
    }
    struct Equation
    {
        readonly double K;
        readonly double B;
        public Equation(double K, double B)
        {
            this.K = K;
            this.B = B;
        }
        public void Root()
        {
            double X = -B / K;
            Console.WriteLine("Решением уравнения  0 = k * x + B, где k={0}, b={1}, является x = {2:F2}", K, B, X);
        }
    }
}
