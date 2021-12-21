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
            string jsonString;
            Product[] products = new Product[5];
            Console.WriteLine("Введите данные по 5 товарам:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Введите код товара № {i + 1}:");
                int idProduct = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Введите название товара № {i + 1}:");
                string nameProduct = Console.ReadLine();
                Console.WriteLine($"Введите цену товара № {i + 1}:");
                double priceProduct = Convert.ToDouble(Console.ReadLine());
                Product product = new Product(idProduct, nameProduct, priceProduct);
                products[i] = product;
                Console.WriteLine();
            }
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true
            };
            StreamWriter info = new StreamWriter(@"C:\info.json");
            for (int i = 0; i < products.Length; i++)
            {
                jsonString = JsonSerializer.Serialize(products[i], options);
                info.Write(jsonString);
            }
            info.Close();
            StreamReader infoRead = new StreamReader(@"C:\info.json");
            string jsonStringRead = infoRead.ReadToEnd();
            infoRead.Close();
            string strReplace = jsonStringRead.Replace("{", "\t{");
            string[] stringArrive = strReplace.Split(new char[] { '\t' }, StringSplitOptions.RemoveEmptyEntries);
            double maxPrice = 0;
            int count = 0;
            Product[] productRead = new Product[5];
            for (int i = 0; i < stringArrive.Length; i++)
            {
                productRead[i] = JsonSerializer.Deserialize<Product>(stringArrive[i], options);
                if (maxPrice < productRead[i].PriceProduct)
                {
                    maxPrice = productRead[i].PriceProduct;
                    count = i;
                }
            }
            Console.WriteLine($"{productRead[count].NameProduct} - самый дорогой товар");
            Console.ReadKey();
        }
        class Product
        {
            [JsonPropertyName("Код товара")]
            public int IdProduct { get; set; }
            [JsonPropertyName("Название товара")]
            public string NameProduct { get; set; }
            [JsonPropertyName("Цена товара")]
            public double PriceProduct { get; set; }
            public Product(int idProduct, string nameProduct, double priceProduct)
            {
                IdProduct = idProduct;
                NameProduct = nameProduct;
                PriceProduct = priceProduct;
            }
        }
    }
}
