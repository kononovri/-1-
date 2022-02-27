
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab14WPFAPP
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                ProdName = "Картофель",
                ProdPrice = 45,
                ProdImage = "Data/Картофель.jpg",
                ProductCategory = ProductCategorys.Food
            });
            products.Add(new Product()
            {
                ProdName = "Лук",
                ProdPrice = 15,
                ProdImage = "Data/Лук.jpg",
                ProductCategory = ProductCategorys.Food
            }); 
            products.Add(new Product()
            {
                ProdName = "Морковь",
                ProdPrice = 35,
                ProdImage = "Data/Морковь.jpg",
                ProductCategory = ProductCategorys.Food
            }); 
            products.Add(new Product()
            {
                ProdName = "Кофемашина",
                ProdPrice = 40000,
                ProdImage = "Data/Кофемашина.jpg",
                ProductCategory = ProductCategorys.Appliances
            }); 
            products.Add(new Product()
            {
                ProdName = "Мясорубка",
                ProdPrice = 15000,
                ProdImage = "Data/Мясорубка.jpg",
                ProductCategory = ProductCategorys.Appliances
            }); 
            products.Add(new Product()
            {
                ProdName = "Комбайн кухонный",
                ProdPrice = 30000,
                ProdImage = "Data/Комбайн.jpg",
                ProductCategory = ProductCategorys.Appliances
            });
            listBox.ItemsSource = products;
        }
    }
}
