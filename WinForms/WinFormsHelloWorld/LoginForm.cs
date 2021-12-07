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
    public partial class LoginForm : Form
    {
        public string UserName { get=>tbUser.Text; set=>tbUser.Text=value; }
        public string Password { get=>tbPassword.Text;}


        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_ResizeBegin(object sender, EventArgs e)
        {
 
        }

        private void LoginForm_Resize(object sender, EventArgs e)
        {
           Control control = sender as Control;
           
            if (control != null)
            {
                control.Size = new Size(control.Size.Width, 200);
        
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
