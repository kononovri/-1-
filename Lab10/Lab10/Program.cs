using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cet();
            cat.name = "Мурка";
            cat.color = "Черный";
            cat.age = 1;
            Console.WriteLine(cat.name);
            Console.WriteLine(cat.color);
            Console.ReadKey();
        }
    }
    class Cat
    {
        private string name;
        public string color;
        private int age;

        public int Age
        {
            set
            {
                if (value>0)
                {
                    age = value;

                }
            }
        
            public int GetAge()
        {
            return age;
        }
        void Say()
        {
            Console.WriteLine("Мяу");
        }
    }
}
