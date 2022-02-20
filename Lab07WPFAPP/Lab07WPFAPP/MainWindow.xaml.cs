using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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



namespace Lab07WPFAPP
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            List<string> styles = new List<string>() { "Светлая тема", "Темная тема" };
            styleBox.ItemsSource = styles;
            styleBox.SelectedIndex = 0;
            styleBox.SelectionChanged += ThemeChange;
            FillFontComboBox(cbFonts);
            textBox.TextDecorations = null;
        }

        public void ThemeChange(object sender, SelectionChangedEventArgs e)
        {
            int styleIndex = styleBox.SelectedIndex;
            Uri uri = new Uri("Light.xaml", UriKind.Relative);
            if (styleIndex == 1)
            {
                uri = new Uri("Dark.xaml", UriKind.Relative);
            }
            ResourceDictionary resource = Application.LoadComponent(uri) as ResourceDictionary;
            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(resource);
        }

        public void FillFontComboBox(ComboBox cbFonts)
        {
            foreach (FontFamily fontsFamily in Fonts.SystemFontFamilies)
            {
                cbFonts.Items.Add(fontsFamily.Source);
            }
            cbFonts.SelectedIndex = 0;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string fontName = ((sender as ComboBox).SelectedItem as String);
            if (textBox != null)
            {
                textBox.FontFamily = new FontFamily(fontName);
            }

        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            double fontSize = Convert.ToDouble(((sender as ComboBox).SelectedItem as String));
            if (textBox != null)
            {
                textBox.FontSize = fontSize;
            }
        }

        private void ButtonBold_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.FontWeight == FontWeights.Normal)
            {
                textBox.FontWeight = FontWeights.Bold;
            }
            else
            {
                textBox.FontWeight = FontWeights.Normal;
            }
        }

        private void ButtonItalic_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.FontStyle == FontStyles.Normal)
            {
                textBox.FontStyle = FontStyles.Italic;
            }
            else
            {
                textBox.FontStyle = FontStyles.Normal;
            }
        }

        private void ButtonUnderLine_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.TextDecorations == null)
            {
                textBox.TextDecorations = TextDecorations.Underline;
            }
            else
            {
                textBox.TextDecorations = null;
            }
        }

        private void RbuttonBlack_Click(object sender, RoutedEventArgs e)
        {
            textBox.Foreground = Brushes.Black;
        }

        private void RbuttonRed_Click(object sender, RoutedEventArgs e)
        {
            textBox.Foreground = Brushes.Red;
        }

        private void ExitExecuted(object sender, System.Windows.Input.ExecutedRoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void OpenExecuted(object sender, System.Windows.Input.ExecutedRoutedEventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (openDialog.ShowDialog() == true)
                textBox.Text = File.ReadAllText(openDialog.FileName);
        }

        private void SaveExecuted(object sender, System.Windows.Input.ExecutedRoutedEventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (saveDialog.ShowDialog() == true)
                File.WriteAllText(saveDialog.FileName, textBox.Text);
        }
    }
}