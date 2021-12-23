using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsHelloWorld
{
    public partial class ListDemoForm : Form
    {
        public ListDemoForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           StringBuilder stringBuilder = new StringBuilder();
           foreach(var item in  checkedListBox1.CheckedItems)
           {
                stringBuilder.Append(item.ToString());
                stringBuilder.Append(';');
           }
            label1.Text = stringBuilder.ToString();




        }
    }
}
