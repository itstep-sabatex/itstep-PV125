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

        private void btCalendarDemo_Click(object sender, EventArgs e)
        {
            var calendarDemoForm = new CalendarDemo();
            calendarDemoForm.Show();
        }

        private void btListDemo_Click(object sender, EventArgs e)
        {
            var listDemoForm = new ListDemoForm();
            listDemoForm.Show();


        }

        private void btTreeView_Click(object sender, EventArgs e)
        {
            var treeView = new ExplorerForm();
            treeView.Show();
        }

        private void btOpenFile_Click(object sender, EventArgs e)
        {
            var fontDialog = new FontDialog();
            fontDialog.ShowDialog();



            var cd = new ColorDialog();
            cd.ShowDialog();
            
           


            var sfd = new FolderBrowserDialog();
            sfd.ShowDialog();



            var of = new OpenFileDialog();
            of.Multiselect = true;
            var dr=of.ShowDialog();
            if (dr == DialogResult.OK)
            {
                if (of.FileNames.Length > 0)
                {

                }
            }
        }

        private void demoToolStripMenuItem_Click(object sender, EventArgs e)
        {
 
        }

        private void listDemoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var listDemoForm = new ListDemoForm();
            listDemoForm.Show();


        }

        private void calendarDemoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           var calendarDemoForm = new CalendarDemo();
           calendarDemoForm.Show();

        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuSave_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void toolStripMenuExpand_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void dragEndDropToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dragEndDrop = new DragEndDropDemo();
            dragEndDrop.Show();
        }

        private void gDIDemoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gdiDemoForm = new GDIDemoForm();
            gdiDemoForm.Show();
        }
    }
}