 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15._1
{
    class Program
    {
        static void Main(string[] args)
        {
        main:
            Console.WriteLine("Введите начальное значение прогрессии:");
            int startX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите шаг арифметической прогрессии:");
            int stepX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите знаменатель геометрической прогрессии:");
            int denomX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество членов прогрессий:");
            int number = Convert.ToInt32(Console.ReadLine());
            AProgres ap = new AProgres(startX, stepX);
            GProgres gp = new GProgres(startX, denomX);
            Console.WriteLine("Арифметическая прогрессия:");
            Console.Write($"{startX}     ");
            for (int i = 0; i < number - 1; i++)
            {
                Console.Write($"{ap.getNext()}     ");
            }
            Console.WriteLine();
            Console.WriteLine("Геометрическая прогрессия:");
            Console.Write($"{startX}     ");
            for (int i = 0; i < number - 1; i++)
            {
                Console.Write($"{gp.getNext()}     ");
            }
            Console.WriteLine("\n\n\nДля сброса результата и повторного задания прогрессий нажмите Пробел\n\nДля выхода, нажмите любую клавишу...");
            if (Console.ReadKey().Key == ConsoleKey.Spacebar)
            {
                Console.Clear();
                goto main;
            }
        }
    }
    interface ISeries
    {
        void setStart(int startX);
        int getNext();
        void reset();
    }
    class AProgres : ISeries
    {
        public int StartX;
        public int CurrentX;
        public int StepX;
        public AProgres(int startX, int stepX)
        {
            StartX = startX;
            CurrentX = startX;
            StepX = stepX;
        }
        public int getNext()
        {
            return CurrentX += StepX;
        }
        public void reset()
        {
            CurrentX = StartX;
        }
        public void setStart(int startX)
        {
            StartX = startX;
        }
    }
    class GProgres : ISeries
    {
        public int StartX;
        public int CurrentX;
        public int DenomX;
        public GProgres(int startX, int denomX)
        {
            StartX = startX;
            CurrentX = startX;
            DenomX = denomX;
        }
        public int getNext()
        {
            return CurrentX *= DenomX;
        }
        public void reset()
        {
            CurrentX = StartX;
        }
        public void setStart(int startX)
        {
            StartX = startX;
        }
    }
}
