using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab_8_
{
    class Program
    {
        static void Main(string[] args)
        {
            string way = @"c:\Program Files\DAEMON Tools Lite";
            string search = "*.*";
            DirectoryInfo dir = new DirectoryInfo(way);
            DirectoryInfo[] directories = dir.GetDirectories(search, SearchOption.AllDirectories);
            FileInfo[] files = dir.GetFiles();
            Console.WriteLine(@"{0}\", way);
            foreach (FileInfo file in files)
            {
                Console.WriteLine("- {0}", file.Name);
            }
            Console.WriteLine();
            foreach (DirectoryInfo di in directories)
            {
                Console.WriteLine(@"{0}\", di.FullName);
                string subname = di.FullName;
                DirectoryInfo fullnameSub = new DirectoryInfo(subname);
                foreach (var file in fullnameSub.GetFiles())
                {
                    Console.WriteLine("- {0}", file.Name);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
