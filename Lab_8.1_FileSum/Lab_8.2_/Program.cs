using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab_8._2_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int sum = 0;
            using (StreamWriter info = new StreamWriter(@"C:\info.txt"))
            {
                Random r = new Random();
                for (int i = 0; i < 10; i++)
                {
                    info.WriteLine(r.Next(0, 50));
                }
            }
            using (StreamReader info = new StreamReader(@"C:\info.txt"))
            {
                for (int i = 0; i < 10; i++)
                {
                    array[i] = Convert.ToInt32(info.ReadLine());
                    sum += array[i];
                }
            }
            Console.WriteLine("Сумма чисел, записаннах в файл info.txt, составляет {0}", sum);
            Console.ReadKey();
        }
    }
}
