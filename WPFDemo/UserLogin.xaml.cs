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
using System.Windows.Shapes;
using WPFDemo.Models;

namespace WPFDemo
{
    /// <summary>
    /// Interaction logic for UserLogin.xaml
    /// </summary>
    public partial class UserLogin : Window
    {
        public UserLogin()
        {
            InitializeComponent();
            //DataContext = new Login();
        }

        public readonly static DependencyProperty RememberMeProperty =
            DependencyProperty.Register(nameof(RememberMe), typeof(bool), typeof(UserLogin), new PropertyMetadata(false));
 
        public bool RememberMe 
        { 
            get=>(bool)GetValue(RememberMeProperty);
            set=>SetValue(RememberMeProperty,value);
        }
        
        
        public object LoginData { get => DataContext; set => DataContext = value; }
 
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }
    }
}
