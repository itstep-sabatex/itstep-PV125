using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using WpfEFCoreDemo.Data;
using WpfEFCoreDemo.Models;

namespace WpfEFCoreDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            using (var context = new DemoDbContext())
            {
                //var group = new StudentGroup {
                //    Name="PV125"
                //};
                //context.StudenGroups.Add(group);
                //context.SaveChanges();

                //var gr = context.StudenGroups.FirstOrDefault(s=>s.Name == "PV125");

                //gr.Students.Add(new Student { Name = "Ivanenko Ivan", BirthDay = DateTime.Parse("01.01.2000") });
                //context.Update(gr);
                //context.SaveChanges();
                var temp = context.StudenGroups.Include(i => i.Students).ToArray();
                listBox.ItemsSource = temp;
                var json = System.Text.Json.JsonSerializer.Serialize(temp);
                var f = 10;
                //Debug.WriteLine($"Id={gr.Id} Name={gr.Name}");
                //foreach (var gr in context.StudenGroups.ToArray())
                //{
                //    Debug.WriteLine(gr.Name);
                //    context.StudenGroups.Remove(gr);
                //}
                //context.SaveChanges();


            }


        }
    }
}
