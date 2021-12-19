using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текстовое предложение без знаков препинания");
            string phrase = Console.ReadLine();
            string[] words = phrase.Split(' ');
            int maxL = 0, index = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > maxL)
                {
                    maxL = words[i].Length;
                    index = i;
                }
            }
            Console.Write("Самое длинное слово: {0}", words[index]);
            Console.ReadKey();
        }
        
    }
}
