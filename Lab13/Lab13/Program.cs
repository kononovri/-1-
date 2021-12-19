using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(1, 2, 3);
            ReactangularTriangle rectangulartriangle = new ReactangularTriangle();
            rectangulartriangle.GetArea;
        }
    }
    class Triangle
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;

        }
        public double GetArea()
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }


    }
    class ReactangularTriangle : Triangle
    {
        public ReactangularTriangle(double a, double b)
                : base(a, b, Math.Sqrt(a * a + b * b));

    }
}
