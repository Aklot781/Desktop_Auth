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

namespace TeleCom
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
        //Константное значение символов для генерации кода
        public static readonly string[] symbols = {"1", "2", "3", "4", "5", "6", "A", "b"};
        //Метод генерации одноразового кода
        public static string Generate_Code(int length)
        {
            string s = "";
            Random rand = new Random();
            for (int i = 0; i < length; i++)
            {
                s += symbols[rand.Next(0, 7)];
            }
            return s;
        }
        //Сам вход в программу
        private void Btvhod_Click(object sender, RoutedEventArgs e)
        {
            if (Tbkod.Text == code && is_login_timeout != false) MessageBox.Show("Успешная авторизация!");
            if (Tbkod.Text == cod && is_login_timeout != false) MessageBox.Show("Успешная авторизация!");
        }

        //Ввод номера
        private void TbNomer_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (new BD.DemoBKEntities().ТехПерсонал.FirstOrDefault(i => i.Номер == TbNomer.Text.Trim()) != null) Tbpassword.IsEnabled = true;
           
        }

        //Ввод пароля
        public static string code = "";
        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
                if (new BD.DemoBKEntities().ТехПерсонал.FirstOrDefault(i => i.Пароль == Tbpassword.Text.Trim()) != null && e.Key == Key.Enter)
                {
                code = Generate_Code(8);
                MessageBox.Show(code);
                Async_Method();
                } 
                else if (new BD.DemoBKEntities().ТехПерсонал.FirstOrDefault(i => i.Пароль == Tbpassword.Text.Trim()) == null && e.Key == Key.Enter)
            {
                MessageBox.Show("Ашепка!");
            }
            
        }

        //поле для хранения логического значения
        public static bool is_login_timeout = true;
        private async void Async_Method()
        {
            for (int i = 0; i < 10; i++)
            {
               await Task.Delay(1000);
            }
            is_login_timeout = false;
        }

        public static string cod = "";
        private void TbObnovit_Click(object sender, RoutedEventArgs e)
        {
            if(new BD.DemoBKEntities().ТехПерсонал.FirstOrDefault(i => i.Пароль == Tbpassword.Text.Trim()) != null)
            {
                cod = Generate_Code(8);
                MessageBox.Show(cod);
                Async_Method();
            }
        }

        private void Btotmena_Click(object sender, RoutedEventArgs e)
        {
            TbNomer.Clear();
            Tbpassword.Clear();
            Tbkod.Clear();
        }
    }
}
