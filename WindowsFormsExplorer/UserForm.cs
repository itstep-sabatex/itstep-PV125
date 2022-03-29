using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsExplorer
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'demoDataSet.User' table. You can move, or remove it, as needed.
            
            
            
            //this.userTableAdapter.Fill(this.demoDataSet.User);
            this.demoDataSet.ReadXml(@"C:\DataBases\demoDataSet.xml");

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //this.userTableAdapter.Update(this.demoDataSet.User);
            this.demoDataSet.WriteXml(@"C:\DataBases\demoDataSet.xml");


        }
    }
}
