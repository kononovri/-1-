using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //  DriveInfo[] drives = DriveInfo.GetDrives();
            //  foreach (DriveInfo d in drives)
            //  {
            //      Console.WriteLine("Название: {0}", d.Name);
            //      if (d.IsReady)
            //      {
            //          Console.WriteLine("Объем диска: {0}", d.TotalSize);
            //          Console.WriteLine("Свободно: {0}", d.AvailableFreeSpace);
            //      }
            //      Console.WriteLine();
            //  }
            //  Console.ReadKey();
            string Path = "Logs2/log.txt";
            //if (!Directory.Exists(Path))
            //{
            //    Directory.CreateDirectory(Path);
            //}
            //DirectoryInfo directory = new DirectoryInfo(Path);
            //if (!directory.Exists)
            //{
            //    directory.Create();
            //}
            //if (!File.Exists(Path))
            //{
            //    File.Create(Path);
            //}
            using (StreamWriter sw = new StreamWriter(Path, true)) // накапливает записи вместо перезаписи
            {
                sw.WriteLine("Старт программы");
                sw.WriteLine("Ошибка");
            }
        }
    }
}
