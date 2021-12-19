using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует калькулятор!");
            try
            {
                Console.Write("Введите целое число. X=");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите целое число. Y=");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите код операции:");
                Console.WriteLine("     1 - сложение");
                Console.WriteLine("     2 - вычитание");
                Console.WriteLine("     3 - произведение");
                Console.WriteLine("     4 - частное");
                byte oper = Convert.ToByte(Console.ReadLine());
                Console.WriteLine("Ваш выбор: {0}", oper);
                switch (oper)
                {
                    case 1:
                        Console.WriteLine("Результат = {0}", x + y);
                        break;
                    case 2:
                        Console.WriteLine("Результат = {0}", x - y);
                        break;
                    case 3:
                        Console.WriteLine("Результат = {0}", x * y);
                        break;
                    case 4:

                        Console.WriteLine("Результат = {0}", x / y);
                        break;
                    default:
                        Console.WriteLine("Нет операции с указанным номером");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка! Входная строка имела неверный формат");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка! Деление на ноль");
            }
            Console.ReadKey();
        }
    }
}
