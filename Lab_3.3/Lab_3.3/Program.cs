using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число от 20 до 69 включительно, чтобы получить текстовое описание числа");
            byte age = Convert.ToByte(Console.ReadLine());
            double ageTemp1 = age / 10;
            double ageSecond = age % 10;
            if (age >= 20 && age <= 69)
            {
                double ageFirst = Math.Floor(ageTemp1);
                switch (ageFirst)
                {
                    case 2:
                        Console.Write("{0} - двадцать ", age);
                        break;
                    case 3:
                        Console.Write("{0} - тридцать ", age);
                        break;
                    case 4:
                        Console.Write("{0} - сорок ", age);
                        break;
                    case 5:
                        Console.Write("{0} - пятьдесят ", age);
                        break;
                    case 6:
                        Console.Write("{0} - шестьдесят ", age);
                        break;
                }
                switch (ageSecond)
                {
                    case 1:
                        Console.Write("один год");
                        break;
                    case 2:
                        Console.Write("два года");
                        break;
                    case 3:
                        Console.Write("три года");
                        break;
                    case 4:
                        Console.Write("четыре года");
                        break;
                    case 5:
                        Console.Write("пять лет");
                        break;
                    case 6:
                        Console.Write("шесть лет");
                        break;
                    case 7:
                        Console.Write("семь лет");
                        break;
                    case 8:
                        Console.Write("восемь лет");
                        break;
                    case 9:
                        Console.Write("девять лет");
                        break;
                    case 0:
                        Console.Write("лет");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Вы ввели некорректное число");
            }
                
                
            Console.ReadKey();
        }
    }
}
