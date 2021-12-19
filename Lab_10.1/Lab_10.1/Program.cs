using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите через пробел величину угла в градусах, минутах и секундах:");
            int[] arrayС1 = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            if (Math.Abs(arrayС1[0]) > 360 || arrayС1[1] > 60 || arrayС1[2] > 60)
            {
                Console.WriteLine("Ошибка! Введены некорректные величины");
            }
            else
            {
                Corner corner1 = new Corner(arrayС1[0], arrayС1[1], arrayС1[2]);
                corner1.ToRadians();
            }
            Console.ReadKey();
        }
    }
    class Corner
    {
        readonly int Grade;
        readonly int Min;
        readonly int Sec;
        public Corner(int Grade, int Min, int Sec)
        {
            this.Grade = Grade;
            this.Min = Min;
            this.Sec = Sec;
        }
        public void ToRadians()
        {
            if (Grade >= 0)
            {
                double Radians = (Grade + Min / 60 + Sec / 3600) * (Math.PI) / 180;
                Console.WriteLine("Величина указанного угла составляет: {0:F2} рад", Radians);
            }
            else
            {
                double Radians = (Grade - Min / 60 - Sec / 3600) * (Math.PI) / 180;
                Console.WriteLine("Величина указанного угла составляет: {0:F2} рад", Radians);
            }

        }
    }
}