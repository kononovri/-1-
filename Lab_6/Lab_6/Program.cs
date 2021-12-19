using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string resultString = String.Format("{0:#(###)###-##-##}", 89384485780);
            string resultString1 = String.Format("{0:0,0}", 1000999999);
            string resultString2 = String.Format("{0:+0;-0;0}", -6);
            string resultString3 = String.Format("{0:F2}", -6);
            string resultString4 = String.Format("{0:D3}", 23);
            string resultString5 = String.Format("{0:N2}", 1000999999);
            string resultString6 = String.Format("{0:P0}", 23);
            Console.WriteLine(resultString);
            Console.WriteLine(resultString1);
            Console.WriteLine(resultString2);
            Console.WriteLine(resultString3);
            Console.WriteLine(resultString4);
            Console.WriteLine(resultString5);
            Console.WriteLine(resultString6);
            Console.ReadKey();
        }
    }
}
