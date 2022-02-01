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

namespace WPFDemo
{
    
    /// <summary>
    /// Interaction logic for ShapeDemo.xaml
    /// </summary>
    public partial class ShapeDemo : Window
    {
        System.Windows.Threading.DispatcherTimer timer;


        public ShapeDemo()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            timer = new System.Windows.Threading.DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            secondAngle.Angle = 360 / 60 * DateTime.Now.Second;
            minuteAngle.Angle = 360 / 60 * DateTime.Now.Minute;
            hourAngle.Angle = 360 / 60 * DateTime.Now.Hour;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            timer.Stop();
        }
    }
}
