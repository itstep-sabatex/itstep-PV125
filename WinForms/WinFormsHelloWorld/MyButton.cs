using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsHelloWorld
{
    public class MyButton:Button
    {
        public int? MyProperty3 { get; set; }//null - int
        public List<string>? MyProperty { get; set; }            // null - string
        public string MyProperty2 { get; set; } = default!; // string
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            MyProperty?.Clear();
            var g= pevent.Graphics;
            
            var pen = new Pen(Color.Blue,3);
            g.DrawLine(pen, 0,0,ClientRectangle.Width,ClientRectangle.Height);



        }
    }
}
