using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17
{
    class Program
    {
        static void Main(string[] args)
        {
        m1:
            Console.Clear();
            Console.WriteLine("Введите номер банковского счета: цифровой или буквенно-цифровой");
            string acc = Console.ReadLine();
            try
            {
                for (int i = 0; i < acc.Length; i++)
                {
                    if (acc[i] != '0' && acc[i] != '1' && acc[i] != '2' && acc[i] != '3' && acc[i] != '4' && acc[i] != '5' && acc[i] != '6' && acc[i] != '7' && acc[i] != '8' && acc[i] != '9')
                    {
                        string accNum = acc;
                        Console.WriteLine("Введите баланс счета:");
                        decimal balance = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Введите ФИО владельца счета:");
                        string fio = Convert.ToString(Console.ReadLine());
                        Account<string> accInt = new Account<string>(accNum, balance, fio);
                        Print<string>(accNum, balance, fio);
                    }
                    else
                    {
                        int accNum = Convert.ToInt32(acc);
                        Console.WriteLine("Введите баланс счета:");
                        decimal balance = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Введите ФИО владельца счета:");
                        string fio = Convert.ToString(Console.ReadLine());
                        Account<int> accInt = new Account<int>(accNum, balance, fio);
                        Print<int>(accNum, balance, fio);
                    }

                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ошибка! Номер банковского счета имеет неверный формат, нажмите любую клавишу для повтора");
                Console.ReadKey();
                goto m1;
            }
            Console.ReadKey();
            void Print<T>(T accNum, decimal balance, string fio)
            {
                Console.WriteLine($"На банковском счете № {accNum} баланс: {balance} руб. Владелец счета: {fio}");

            }

        }
    }
    class Account<T>
    {
        private T AccNum { get; set; }
        private decimal Balance { get; set; }
        private string Fio { get; set; }
        public Account(T accNum, decimal balance, string fio)
        {
            AccNum = accNum;
            Balance = balance;
            Fio = fio;
        }

    }
}
