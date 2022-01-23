using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab22
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите количество случайных элементов массива:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите максимальное число для заполнения массива случайными значениями от 0 до максимального:");
            int random = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[number];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            { 
                array[i] = rnd.Next(0, random);
            }
            Task<int> task1 = new Task<int>(() => Sum(array));
            Action<Task, object> actionTask = new Action<Task, object>(Max);
            Task task2 = task1.ContinueWith(actionTask, array);
            task1.Start();
            Console.WriteLine($"Сумма чисел в массиве: {task1.Result}");
            Console.ReadLine();
        }
        static int Sum(int[] array)
        {
            Console.WriteLine("Метод Sum начал работу");
            int sum = 0;
            foreach (int a in array)
            {
                sum += a;
            }
            Console.WriteLine("Метод Sum закончил работу");
            return sum;
        }
        static void Max(Task task, object a)
        {
            Console.WriteLine("Метод Max начал работу");
            int[] array = (int[])a;
            int max = array[0];
            foreach (int x in array)
            {
                if (x > max)
                    max = x;
            }
            Console.WriteLine("Метод Max закончил работу");
            Console.WriteLine($"Максимальное число в массиве: {max}");
        }
    }
}
