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

namespace WPFDemo
{
    /// <summary>
    /// Interaction logic for TextBoxWithButton.xaml
    /// </summary>
    public partial class TextBoxWithButton : UserControl
    {
        public TextBoxWithButton()
        {
            InitializeComponent();
        }

        public readonly static DependencyProperty TextProperty = 
            DependencyProperty.Register(nameof(Text), typeof(string), typeof(TextBoxWithButton),
                new PropertyMetadata(null));  

        public string Text 
        { 
            get=>(string)GetValue(TextProperty);
            set=>SetValue(TextProperty,value); 
        }


        public static readonly RoutedEvent ButtonClickEvent = EventManager.RegisterRoutedEvent(typeof(ButtonClick),RoutingStrategy.

        public event RoutedEventHandler ButtonClick
        {
            
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
