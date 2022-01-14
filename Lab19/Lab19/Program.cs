using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab19
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PC> listComps = new List<PC>()
            {
                new PC(){ Id="0001", Brand="Sony", TypeCPU="AMD Ryzen7", FreqCPU=3500, RAM=32, HDD=2000, VGA=12, Price=240000, Stock=6},
                new PC(){ Id="0002", Brand="Acer", TypeCPU="AMD Ryzen5", FreqCPU=3300, RAM=16, HDD=1000, VGA=8, Price=120000, Stock=11},
                new PC(){ Id="0003", Brand="Asus", TypeCPU="Intel i5", FreqCPU=3600, RAM=16, HDD=1500, VGA=8, Price=130000, Stock=31},
                new PC(){ Id="0004", Brand="Dexp", TypeCPU="Intel i5", FreqCPU=3500, RAM=16, HDD=1000, VGA=4, Price=70000, Stock=14},
                new PC(){ Id="0006", Brand="MSI", TypeCPU="Intel i7", FreqCPU=3800, RAM=32, HDD=1000, VGA=8, Price=160000, Stock=5},
                new PC(){ Id="0007", Brand="Acer", TypeCPU="Intel i9", FreqCPU=4200, RAM=64, HDD=4000, VGA=24, Price=400000, Stock=2},
                new PC(){ Id="0008", Brand="Dexp", TypeCPU="AMD Ryzen9", FreqCPU=4300, RAM=64, HDD=6000, VGA=24, Price=380000, Stock=3},
                new PC(){ Id="0009", Brand="Lenovo", TypeCPU="Intel i3", FreqCPU=2000, RAM=8, HDD=1000, VGA=4, Price=50000, Stock=32},
                new PC(){ Id="0010", Brand="Asus", TypeCPU="AMD Ryzen3", FreqCPU=2200, RAM=8, HDD=1000, VGA=4, Price=40000, Stock=21},
            };

            Console.WriteLine("Введите характеристики компьютера:");

            Console.WriteLine("Название процессора (AMD Ryzen3, AMD Ryzen5, AMD Ryzen7, AMD Ryzen9, Intel Core i3, Intel Core i5, Intel Core i7, Intel Core i9):");
            string TypeCPU = Console.ReadLine();
            List<PC> comps = listComps
                .Where(c => c.TypeCPU == TypeCPU)
                .ToList();
            Console.WriteLine();
            Console.WriteLine("|ID|Brand|   CPU   |Freq|RAM|HDD|VGA|Price|Stock|");
            foreach (PC c in comps)
                Console.WriteLine($"{c.Id} {c.Brand} {c.TypeCPU} {c.FreqCPU} {c.RAM} {c.HDD} {c.VGA} {c.Price} {c.Stock}");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("Минимальный объём ОЗУ, Гб:");
            int ram = Convert.ToInt32(Console.ReadLine());
            List<PC> comps2 = listComps
                .Where(c => c.RAM >= ram)
                .ToList();
            Console.WriteLine();
            Console.WriteLine("|ID|Brand|   CPU   |Freq|RAM|HDD|VGA|Price|Stock|");
            foreach (PC c in comps2)
                Console.WriteLine($"{c.Id} {c.Brand} {c.TypeCPU} {c.FreqCPU} {c.RAM} {c.HDD} {c.VGA} {c.Price} {c.Stock}");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Cписок, отсортированный по увеличению стоимости:");
            var compsPrice = listComps
                .OrderBy(c => c.Price)
                .ToList();
            Console.WriteLine();
            Console.WriteLine("|ID|Brand|   CPU   |Freq|RAM|HDD|VGA|Price|Stock|");
            foreach (var c in compsPrice)
                Console.WriteLine($"{c.Id} {c.Brand} {c.TypeCPU} {c.FreqCPU} {c.RAM} {c.HDD} {c.VGA} {c.Price} {c.Stock}");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("Cписок, сгруппированный по типу процессора:\n");
            Console.WriteLine("|ID|Brand|   CPU   |Freq|RAM|HDD|VGA|Price|Stock|");
            var compsTypeCPU = from PC in listComps
                               group PC by PC.TypeCPU;
            foreach (IGrouping<string, PC> c in compsTypeCPU)
            {
                Console.WriteLine(c.Key);
                foreach (var t in c)
                    Console.WriteLine($"{t.Id} {t.Brand} {t.TypeCPU} {t.FreqCPU} {t.RAM} {t.HDD} {t.VGA} {t.Price} {t.Stock}");
                Console.WriteLine();
            }
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("Самый дорогой компьютер:");
            var compMax = listComps
                .Max(c => c.Price);
            Console.WriteLine(compMax);

            Console.WriteLine("\nСамый дешевый компьютер:");
            var compMin = listComps
                .Min(c => c.Price);
            Console.WriteLine(compMin);

            Console.WriteLine("\nКомпьютер в количестве не менее 30 штук:");
            List<PC> comps3 = listComps
                .Where(c => c.Stock >= 30)
                .ToList();
            Console.WriteLine();
            Console.WriteLine("|ID|Brand|   CPU   |Freq|RAM|HDD|VGA|Price|Stock|");
            foreach (PC c in comps3)
                Console.WriteLine($"{c.Id} {c.Brand} {c.TypeCPU} {c.FreqCPU} {c.RAM} {c.HDD} {c.VGA} {c.Price}");
            Console.ReadKey();
            Console.Clear();
        }
    }
    class PC
    {
        public string Id { get; set; }
        public string Brand { get; set; }
        public string TypeCPU { get; set; }
        public int FreqCPU { get; set; }
        public int RAM { get; set; }
        public int HDD { get; set; }
        public int VGA { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }
}
