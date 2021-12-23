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
    public partial class DragEndDropDemo : Form
    {
        public DragEndDropDemo()
        {
            InitializeComponent();
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            button1.DoDragDrop(button1.Name, DragDropEffects.Move);
        }

        private void splitContainer1_Panel2_DragEnter(object sender, DragEventArgs e)
        {
            //Value Key
            // 1(bit 0)   The left mouse button.
            // 2(bit 1)   The right mouse button.
            // 4(bit 2)   The SHIFT key.
            // 8(bit 3)   The CTRL key.
            // 16(bit 4)  The middle mouse button.
            // 32(bit 5)  The ALT key.
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                if ((e.KeyState & 8) >0)
                    e.Effect = DragDropEffects.Copy;
                else
                    e.Effect = DragDropEffects.Move;
            }
            else
                e.Effect = DragDropEffects.None;
        }

        private void splitContainer1_Panel2_DragDrop(object sender, DragEventArgs e)
        {
            var buttonName = e.Data.GetData(DataFormats.Text).ToString();
            foreach (var c in splitContainer1.Panel2.Controls.Find(buttonName, false))
            {
                c.Location = splitContainer1.Panel2.PointToClient(new Point(e.X, e.Y));
            }

            foreach (var c in splitContainer1.Panel1.Controls.Find(buttonName,false))
            {
                splitContainer1.Panel1.Controls.Remove(c);
                splitContainer1.Panel2.Controls.Add(c);
                c.Location = splitContainer1.Panel2.PointToClient(new Point(e.X,e.Y));
            }
        }
    }
}
