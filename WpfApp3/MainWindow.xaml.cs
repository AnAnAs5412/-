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

namespace WpfApp3
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
            string a = Login.Text; //создание переменной строки для логина и присваивание к TextBox
            string b = Password.Password; //создание переменной строки для пароля и присваивание к PasswordBox
            if (a == "1111" && b == "1") //проверка введенного логина и пароля
            {
                Window1 window1 = new Window1(); //создание переменной для окна
                window1.Show(); //переход на соответствующее окно
            }
            else if (a == "2222" && b == "2") //проверка введенного логина и пароля
            {
                Window2 window2 = new Window2(); //создание переменной для окна
                window2.Show(); //переход на соответствующее окно
            }
            else if (a == "3333" && b == "3") //проверка введенного логина и пароля
            {
                Window3 window3 = new Window3(); //создание переменной для окна
                window3.Show(); //переход на соответствующее окно
            }
            else
            {
                MessageBox.Show("Ошибка!!!"); //вывод ошибки при неправильном вводе логина и(или) пароля
            }
        }
    }
}
