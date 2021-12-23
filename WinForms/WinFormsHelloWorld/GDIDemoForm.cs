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
    public partial class GDIDemoForm : Form
    {
        public GDIDemoForm()
        {
            InitializeComponent();
        }

        private void btDraw_Click(object sender, EventArgs e)
        {
            var g = pPicture.CreateGraphics();
            var pen = new Pen(Color.Red, 10);
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            pen.StartCap = System.Drawing.Drawing2D.LineCap.RoundAnchor;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            g.DrawLine(pen, 20, 20, 200, pPicture.ClientSize.Height -50);
        }

        private void btDraw_Paint(object sender, PaintEventArgs e)
        {
            var pen = new Pen(Color.Red, 10);
            var g = e.Graphics;
            g.DrawLine(pen, 0,0,g.VisibleClipBounds.Width,g.VisibleClipBounds.Height);
        }

        private void pPicture_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            var pen = new Pen(Color.Red, 10);
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            //pen.StartCap = System.Drawing.Drawing2D.LineCap.RoundAnchor;
            //pen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            g.DrawLine(pen, 20, 20, 200, g.VisibleClipBounds.Height - 50);

        }
    }
}
