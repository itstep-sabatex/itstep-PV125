namespace WinFormsHelloWorld
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            var a = 0;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //e.Cancel = true;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            var dr = MessageBox.Show(this,"Hello world","Привіт світ",MessageBoxButtons.OKCancel);
            var a = 0;
        }

        private void btHelloWorld_Click(object sender, EventArgs e)
        {
            var helloWorldForm = new HelloWorldForm();
           
            var dr =helloWorldForm.ShowDialog();
            var a = 0;

        }

        private void btShowHelloWorld_Click(object sender, EventArgs e)
        {
            var helloWorldForm = new HelloWorldForm();
            helloWorldForm.MdiParent = this;
            helloWorldForm.Show();
        }

 
    }
}