using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку, содержащую скобки трёх видов: (), [] и {}");
            string str = Console.ReadLine();
            Console.WriteLine(CorrectCheck(str) ? "В введенной строке скобки стоят корректно" : "В введенной строке скобки стоят не корректно");
            Console.ReadKey();
        }
        static bool CorrectCheck(string str)
        {
            Stack<char> stack = new Stack<char>();
            foreach (var s in str)
            {
                if (s == '{')
                {
                    stack.Push('}');
                }
                if (s == '(')
                {
                    stack.Push(')');
                }
                if (s == '[')
                {
                    stack.Push(']');
                }
                if (stack.Count != 0 && s == stack.Peek())
                {
                    stack.Pop();
                }
            }
            if (stack.Count != 0)
            {
                return false;
            }
            return true;
        }
    }
}