namespace WinFormsHelloWorld
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Петрович");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Петро", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Семен");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Root", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btCancel = new System.Windows.Forms.Button();
            this.btOk = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btHelloWorld = new System.Windows.Forms.Button();
            this.btShowHelloWorld = new System.Windows.Forms.Button();
            this.btLogin = new System.Windows.Forms.Button();
            this.btChess = new System.Windows.Forms.Button();
            this.btCalendarDemo = new System.Windows.Forms.Button();
            this.btListDemo = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuCollapse = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuExpand = new System.Windows.Forms.ToolStripMenuItem();
            this.btTreeView = new System.Windows.Forms.Button();
            this.btOpenFile = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.demoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendarDemoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listDemoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dragEndDropToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.gDIDemoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(664, 395);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(112, 34);
            this.btCancel.TabIndex = 0;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(546, 395);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(112, 34);
            this.btOk.TabIndex = 1;
            this.btOk.Text = "Ok";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(174, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Введіть прізвище";
            this.textBox1.Size = new System.Drawing.Size(226, 31);
            this.textBox1.TabIndex = 2;
            this.toolTip1.SetToolTip(this.textBox1, "Покажемо підказку");
            // 
            // btHelloWorld
            // 
            this.btHelloWorld.Location = new System.Drawing.Point(321, 395);
            this.btHelloWorld.Name = "btHelloWorld";
            this.btHelloWorld.Size = new System.Drawing.Size(219, 34);
            this.btHelloWorld.TabIndex = 3;
            this.btHelloWorld.Text = "ShowDialog Hello World";
            this.btHelloWorld.UseVisualStyleBackColor = true;
            this.btHelloWorld.Click += new System.EventHandler(this.btHelloWorld_Click);
            // 
            // btShowHelloWorld
            // 
            this.btShowHelloWorld.Location = new System.Drawing.Point(123, 395);
            this.btShowHelloWorld.Name = "btShowHelloWorld";
            this.btShowHelloWorld.Size = new System.Drawing.Size(178, 34);
            this.btShowHelloWorld.TabIndex = 4;
            this.btShowHelloWorld.Text = "Show Hello World";
            this.btShowHelloWorld.UseVisualStyleBackColor = true;
            this.btShowHelloWorld.Click += new System.EventHandler(this.btShowHelloWorld_Click);
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(575, 320);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(112, 34);
            this.btLogin.TabIndex = 6;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // btChess
            // 
            this.btChess.Location = new System.Drawing.Point(388, 321);
            this.btChess.Name = "btChess";
            this.btChess.Size = new System.Drawing.Size(112, 34);
            this.btChess.TabIndex = 7;
            this.btChess.Text = "Chess";
            this.btChess.UseVisualStyleBackColor = true;
            this.btChess.Click += new System.EventHandler(this.btChess_Click);
            // 
            // btCalendarDemo
            // 
            this.btCalendarDemo.Location = new System.Drawing.Point(12, 54);
            this.btCalendarDemo.Name = "btCalendarDemo";
            this.btCalendarDemo.Size = new System.Drawing.Size(172, 34);
            this.btCalendarDemo.TabIndex = 8;
            this.btCalendarDemo.Text = "Calendar Demo";
            this.btCalendarDemo.UseVisualStyleBackColor = true;
            this.btCalendarDemo.Click += new System.EventHandler(this.btCalendarDemo_Click);
            // 
            // btListDemo
            // 
            this.btListDemo.Location = new System.Drawing.Point(223, 44);
            this.btListDemo.Name = "btListDemo";
            this.btListDemo.Size = new System.Drawing.Size(112, 34);
            this.btListDemo.TabIndex = 9;
            this.btListDemo.Text = "List Demo";
            this.btListDemo.UseVisualStyleBackColor = true;
            this.btListDemo.Click += new System.EventHandler(this.btListDemo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(173, 147);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(227, 31);
            this.textBox2.TabIndex = 11;
            // 
            // treeView1
            // 
            this.treeView1.ContextMenuStrip = this.contextMenuStrip1;
            this.treeView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeView1.Location = new System.Drawing.Point(67, 210);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node3";
            treeNode1.Text = "Петрович";
            treeNode2.Name = "Node1";
            treeNode2.Text = "Петро";
            treeNode3.Name = "Node2";
            treeNode3.Text = "Семен";
            treeNode4.Name = "Node0";
            treeNode4.Text = "Root";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.treeView1.Size = new System.Drawing.Size(182, 146);
            this.treeView1.TabIndex = 12;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuCollapse,
            this.toolStripMenuExpand});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(244, 68);
            this.contextMenuStrip1.Text = "Collapse";
            this.contextMenuStrip1.Click += new System.EventHandler(this.contextMenuStrip1_Click);
            // 
            // toolStripMenuCollapse
            // 
            this.toolStripMenuCollapse.Name = "toolStripMenuCollapse";
            this.toolStripMenuCollapse.Size = new System.Drawing.Size(243, 32);
            this.toolStripMenuCollapse.Text = "Collapse";
            this.toolStripMenuCollapse.Click += new System.EventHandler(this.toolStripMenuSave_Click);
            // 
            // toolStripMenuExpand
            // 
            this.toolStripMenuExpand.Name = "toolStripMenuExpand";
            this.toolStripMenuExpand.Size = new System.Drawing.Size(243, 32);
            this.toolStripMenuExpand.Text = "toolStripMenuItem1";
            this.toolStripMenuExpand.Click += new System.EventHandler(this.toolStripMenuExpand_Click);
            // 
            // btTreeView
            // 
            this.btTreeView.Location = new System.Drawing.Point(361, 44);
            this.btTreeView.Name = "btTreeView";
            this.btTreeView.Size = new System.Drawing.Size(179, 34);
            this.btTreeView.TabIndex = 13;
            this.btTreeView.Text = "Tree View Demo";
            this.btTreeView.UseVisualStyleBackColor = true;
            this.btTreeView.Click += new System.EventHandler(this.btTreeView_Click);
            // 
            // btOpenFile
            // 
            this.btOpenFile.Location = new System.Drawing.Point(518, 86);
            this.btOpenFile.Name = "btOpenFile";
            this.btOpenFile.Size = new System.Drawing.Size(112, 34);
            this.btOpenFile.TabIndex = 14;
            this.btOpenFile.Text = "Open file";
            this.btOpenFile.UseVisualStyleBackColor = true;
            this.btOpenFile.Click += new System.EventHandler(this.btOpenFile_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.notifyIcon1.BalloonTipText = "ttrt";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.demoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(778, 33);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(223, 34);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(223, 34);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // demoToolStripMenuItem
            // 
            this.demoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calendarDemoToolStripMenuItem,
            this.listDemoToolStripMenuItem,
            this.dragEndDropToolStripMenuItem,
            this.gDIDemoToolStripMenuItem});
            this.demoToolStripMenuItem.Name = "demoToolStripMenuItem";
            this.demoToolStripMenuItem.Size = new System.Drawing.Size(77, 29);
            this.demoToolStripMenuItem.Text = "Demo";
            this.demoToolStripMenuItem.Click += new System.EventHandler(this.demoToolStripMenuItem_Click);
            // 
            // calendarDemoToolStripMenuItem
            // 
            this.calendarDemoToolStripMenuItem.Name = "calendarDemoToolStripMenuItem";
            this.calendarDemoToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.calendarDemoToolStripMenuItem.Text = "Calendar Demo";
            this.calendarDemoToolStripMenuItem.Click += new System.EventHandler(this.calendarDemoToolStripMenuItem_Click);
            // 
            // listDemoToolStripMenuItem
            // 
            this.listDemoToolStripMenuItem.Name = "listDemoToolStripMenuItem";
            this.listDemoToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.listDemoToolStripMenuItem.Text = "List Demo";
            this.listDemoToolStripMenuItem.Click += new System.EventHandler(this.listDemoToolStripMenuItem_Click);
            // 
            // dragEndDropToolStripMenuItem
            // 
            this.dragEndDropToolStripMenuItem.Name = "dragEndDropToolStripMenuItem";
            this.dragEndDropToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.dragEndDropToolStripMenuItem.Text = "DragEndDrop";
            this.dragEndDropToolStripMenuItem.Click += new System.EventHandler(this.dragEndDropToolStripMenuItem_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Location = new System.Drawing.Point(0, 415);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(778, 22);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // gDIDemoToolStripMenuItem
            // 
            this.gDIDemoToolStripMenuItem.Name = "gDIDemoToolStripMenuItem";
            this.gDIDemoToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.gDIDemoToolStripMenuItem.Text = "GDI Demo";
            this.gDIDemoToolStripMenuItem.Click += new System.EventHandler(this.gDIDemoToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 437);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btOpenFile);
            this.Controls.Add(this.btTreeView);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btListDemo);
            this.Controls.Add(this.btCalendarDemo);
            this.Controls.Add(this.btChess);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.btShowHelloWorld);
            this.Controls.Add(this.btHelloWorld);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Hello World";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btCancel;
        private Button btOk;
        private TextBox textBox1;
        private Button btHelloWorld;
        private Button btShowHelloWorld;
        private Button btLogin;
        private Button btChess;
        private Button btCalendarDemo;
        private Button btListDemo;
        private ToolTip toolTip1;
        private Label label1;
        private TextBox textBox2;
        private TreeView treeView1;
        private Button btTreeView;
        private Button btOpenFile;
        private NotifyIcon notifyIcon1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem demoToolStripMenuItem;
        private ToolStripMenuItem calendarDemoToolStripMenuItem;
        private ToolStripMenuItem listDemoToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuCollapse;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuExpand;
        private StatusStrip statusStrip1;
        private ToolStripMenuItem dragEndDropToolStripMenuItem;
        private ToolStripMenuItem gDIDemoToolStripMenuItem;
    }
}