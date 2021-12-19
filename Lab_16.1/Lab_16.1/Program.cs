using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Unicode;
using System.Threading.Tasks;
using System.IO;


namespace Lab_16._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:/Products.json";
            string jsonString;
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            StreamWriter infoW = new StreamWriter(path);
            Product[] products = new Product[5];
            Console.WriteLine("Введите данные по 5 товарам\n");

            for (int i = 0; i <= 4; i++)
            {

                Console.WriteLine($"Введите код товара № {i + 1}:");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Введите название товара № {i + 1}:");
                string name = Console.ReadLine();
                Console.WriteLine($"Введите цену товара № {i + 1}:");
                double price = Convert.ToDouble(Console.ReadLine());

                Product product = new Product(id, name, price);
                products[i] = product;
                Console.WriteLine();
            }

            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true
            };
            for (int i = 0; i < products.Length; i++)
            {
                jsonString = JsonSerializer.Serialize(products[i], options);
                infoW.Write(jsonString);
            }
            infoW.Close();
            StreamReader infoR = new StreamReader(path);
            string jsonStringR = infoR.ReadToEnd();
            infoR.Close();
            string str = jsonStringR.Replace("{", "\t{");
            string[] strArrive = str.Split(new char[] { '\t' }, StringSplitOptions.RemoveEmptyEntries);
            double maxPrice = 0;
            int count = 0;
            Product[] productR = new Product[5];
            for (int i = 0; i < strArrive.Length; i++)
            {
                productR[i] = JsonSerializer.Deserialize<Product>(strArrive[i], options);
                if (maxPrice < productR[i].PriceProduct)
                {
                    maxPrice = productR[i].PriceProduct;
                    count = i;
                }
            }

            Console.WriteLine($"{productR[count].NameProduct} - самый дорогой товар");
            Console.ReadKey();
        }
        public class Product
        {
            [JsonPropertyName("Код товара")]
            public int IdProduct { get; set; }
            [JsonPropertyName("Название товара")]
            public string NameProduct { get; set; }
            [JsonPropertyName("Цена товара")]
            public double PriceProduct { get; set; }
            public Product(int id, string name, double price)
            {
                IdProduct = id;
                NameProduct = name;
                PriceProduct = price;
            }
        }
    }
}
