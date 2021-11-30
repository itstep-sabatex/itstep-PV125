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
    public partial class HelloWorldForm : Form
    {
        private bool _directionRight = true;
        private int _step = 5;
        public HelloWorldForm()
        {
            InitializeComponent();
            
                
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var size = ClientSize;
            if (_directionRight)
            {
                var newPositionX = bBoll.Location.X + _step;
                if ((newPositionX + bBoll.Size.Width) <= ClientSize.Width)
                {
                    bBoll.Location = new Point(newPositionX,bBoll.Location.Y);
                }
                else
                {
                    _directionRight = false;
                }

            }
            else
            {
                var newPositionX = bBoll.Location.X - _step;
                if (newPositionX >= 0)
                {
                    bBoll.Location = new Point(newPositionX, bBoll.Location.Y);
                }
                else
                {
                    _directionRight = true;
                }


            }

        }

        private void HelloWorldForm_Load(object sender, EventArgs e)
        {
            bBoll.Location = new Point(0,0);
            timer1.Enabled = true;
        }

        private void HelloWorldForm_FormClosed(object sender, FormClosedEventArgs e)
        {
           // DialogResult = DialogResult.Cancel;
        }

        private void bBoll_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.OK;
            Close();
        }
    }
}
