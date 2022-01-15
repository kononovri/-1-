using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lab21
{
    class Program
    {


        static int w;
        static int h;
        static int[,] garden;
        static object locker = new object();

        static void Main()
        {
            Console.WriteLine("Введите размеры сада:");
            Console.WriteLine("По вертикали:");
            h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("По горизонтали:");
            w = Convert.ToInt32(Console.ReadLine());
            garden = new int[h, w];
            ThreadStart threadStart = new ThreadStart(garden1);
            Thread thread = new Thread(threadStart);
            thread.Start();
            garden2();
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    Console.Write(garden[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        private static void garden1()
        {
            lock (locker)
            {
                for (int i = 0; i < h; i++)
                {
                    for (int j = 0; j < w; j++)
                    {
                        if (garden[i, j] == 0)
                            garden[i, j] = 1;
                        Thread.Sleep(1);
                    }
                }
            }
        }
        private static void garden2()
        {
            for (int i = w - 1; i >= 0; i--)
            {
                for (int j = h - 1; j >= 0; j--)
                {
                    if (garden[j, i] == 0)
                        garden[j, i] = 2;
                    Thread.Sleep(1);
                }
            }
        }
    }
}