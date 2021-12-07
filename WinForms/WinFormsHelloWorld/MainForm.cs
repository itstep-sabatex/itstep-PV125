namespace WinFormsHelloWorld
{
    public partial class MainForm : Form
    {
        private Color buttonColor;
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

        private void btLogin_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            loginForm.UserName = "Petro";
            var result = DialogResult.OK;
            loginForm.Show();
            if (result == DialogResult.OK)
            {
                var userName = loginForm.UserName;
                var password = loginForm.Password;
                MessageBox.Show($"{userName} with password {password}");
            }


        }

        private void btChess_Click(object sender, EventArgs e)
        {
            var chessForm = new ChessForm();
            chessForm.Show();
        }
    }
}