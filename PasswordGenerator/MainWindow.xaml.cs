using System;
using System.Collections.Generic;
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
using System.IO;
namespace PasswordGenerator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string parametrz = "qwertyuiopasdfghjklzxcvbnm0123456789QWERTYUIOPASDFGHJKLZXCVBNM";
                int kol = 20;
            string result = "";
            Random rnd = new Random();
            int lng = parametrz.Length;
            for (int i = 0; i < kol; i++)
            {
                result += parametrz[rnd.Next(lng)];
            }
            NumberofGenerate.Text = result;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            string parametrz = "qwertyuiopasdfghjklzxcvbnm0123456789QWERTYUIOPASDFGHJKLZXCVBNM";
            int kol = 20;
            string result = "";
            Random rnd = new Random();
            int lng = parametrz.Length;
            for (int i = 0; i < kol; i++)
            {
                result += parametrz[rnd.Next(lng)];
            }
            NumberofGenerate.Text = result;
            StreamWriter sw = new StreamWriter(@"C:\Users\ПК\Desktop\Сгенерированный_Пароль.txt");
            sw.WriteLine(NumberofGenerate.Text = result);
            sw.Close();
        }
    }
}
