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
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'demoDataSet.StudentGroup' table. You can move, or remove it, as needed.
            this.studentGroupTableAdapter.Fill(this.demoDataSet.StudentGroup);
            // TODO: This line of code loads data into the 'demoDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.demoDataSet.Student);

        }
    }
}
