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


        public static readonly RoutedEvent ButtonClickEvent = 
            EventManager.RegisterRoutedEvent(nameof(ButtonClick), RoutingStrategy.Bubble, 
                                             typeof(RoutedEventHandler), typeof(TextBoxWithButton));

        public event RoutedEventHandler ButtonClick
        {
            add { AddHandler(ButtonClickEvent, value); }
            remove { RemoveHandler(ButtonClickEvent, value); }
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RoutedEventArgs args = new RoutedEventArgs();
            args.RoutedEvent = ButtonClickEvent;
            RaiseEvent(args);
        }
    }
}
