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
using WPFDemo.Models;

namespace WPFDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string Autor = "Autor";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Width = 1366;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var ul = new UserLogin();
            ul.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var userLogin =  new UserLogin();
            userLogin.LoginData = new LoginExtend();
            //userLogin.CustomUserLogin = new Login();
            if (userLogin.ShowDialog() == true)
            {
                var result = (LoginExtend)(userLogin.LoginData);
                int a = 10;

            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Resources["buttonBackgroundColor"] = new SolidColorBrush(Colors.Green);
        }

        private void TextBoxWithButton_ButtonClick(object sender, RoutedEventArgs e)
        {
            var a = new  Microsoft.Win32. OpenFileDialog();
        }

        private void shapeDemo_Click(object sender, RoutedEventArgs e)
        {
            new ShapeDemo().Show();
        }
    }
}
