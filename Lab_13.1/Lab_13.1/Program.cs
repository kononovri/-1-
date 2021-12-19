using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13._1
{
    class Program
    {
        static void Main(string[] args)
        {
            MultiBuilding multibuilding = new MultiBuilding("Ул. Полевая, 27", 30, 9, 12, 20);
            multibuilding.Print();
            Console.ReadKey();
        }
    }
    class Building
    {
        public string Adress { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public Building(string a, double l, double w, double h)
        {
            Adress = a;
            Length = l;
            Width = w;
            Height = h;
        }
        public void Print()
        {
            Console.WriteLine("Адрес здания: {0}", Adress);
            Console.WriteLine("Длина здания: {0} м", Length);
            Console.WriteLine("Ширина здания: {0} м", Width);
            Console.WriteLine("Высота здания: {0} м", Height);
        }
    }
    sealed class MultiBuilding : Building
    {
        public double Floors { get; set; }
        public MultiBuilding(string a, double l, double w, double h, double f)
        : base(a, l, w, h)
        {
            Floors = f;
        }
        public new void Print()
        {
            base.Print();
            Console.WriteLine("Этажей в здании: {0}", Floors);
        }
    }

}
