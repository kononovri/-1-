using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6._2_Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текстовое предложение без знаков препинания");
            string phrase = Console.ReadLine();
            phrase = phrase.ToLower();
            phrase = phrase.Replace(" ", "");
            for (int i = 0; i < phrase.Length / 2; i++)
            {
                if (phrase[i] == phrase[phrase.Length - i - 1])
                {
                    Console.WriteLine("Введенное предложение является палиндромом");
                    break;
                }
                else Console.WriteLine("Введенное предложение не является палиндромом");
                break;
            }
                Console.ReadKey();
        }
        
    }
}
