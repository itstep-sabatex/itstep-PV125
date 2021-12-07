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
    public partial class ChessForm : Form
    {
        const string celSimbolNames = "abcdefgh";

        public ChessForm()
        {
            InitializeComponent();
            for (int i = 0; i < celSimbolNames.Length; i++)
            { 
                var label = new Label();
                label.Text = ""+celSimbolNames[i];
                label.Dock = DockStyle.Fill;
                label.TextAlign = ContentAlignment.MiddleCenter;
                chessTLP.Controls.Add(label);
                chessTLP.SetCellPosition(label, new TableLayoutPanelCellPosition(i + 1, 0));
            }
            for (int i = 1; i < 9; i++)
            {
                var c = (9 - i).ToString();
                var label = new Label();
                label.Text = c;
                label.Dock = DockStyle.Fill;
                label.TextAlign = ContentAlignment.MiddleCenter;
                chessTLP.Controls.Add(label);
                chessTLP.SetCellPosition(label, new TableLayoutPanelCellPosition(0, i));
            }
            for (int i = 1;i < 9; i++)
            {
                for(int j = 1;j < 9; j++)
                {
                    var pb = new Panel();
                    pb.Dock = DockStyle.Fill;
                    //pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    pb.BackColor =  (i+j)%2 == 0 ? Color.White:Color.Gray;
                    pb.Margin = new Padding(0);
                    chessTLP.Controls.Add(pb);
                    chessTLP.SetCellPosition(pb, new TableLayoutPanelCellPosition(i, j));
                }
            }



        }

        private void ChessForm_Resize(object sender, EventArgs e)
        {
            Control control = sender as Control;
            if (control != null)
            {
                control.Size = new Size(control.Width, control.Width);
            }
        }
    }
}
