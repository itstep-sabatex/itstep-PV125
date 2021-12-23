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
    public partial class ExplorerForm : Form
    {
        public ExplorerForm()
        {
            InitializeComponent();
        }

        private void ExplorerForm_Load(object sender, EventArgs e)
        {
            var root1 = new TreeNode 
            { 
                Text = "Windows"
            };
            var root2 = new TreeNode
            {
                Text = "Users"
            };
            root1.Nodes.Add(new TreeNode("User") { Tag = true });
            root1.Nodes.Add(new TreeNode("Notepad.exe") { Tag = false });
            root1.Nodes.Add(new TreeNode("List.exe") { Tag = false });
            root2.Nodes.Add(new TreeNode("Ivan") { Tag = true });
            root2.Nodes.Add(new TreeNode("Petro") { Tag = true });
            root2.Nodes.Add(new TreeNode("Default") { Tag = true });
            treeView1.Nodes.Add(root1);
            treeView1.Nodes.Add(root2);

        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            var node = treeView1.SelectedNode;
       
            if (node != null)
            {
                foreach(TreeNode n in node.Nodes)
                {
                    if ((bool)n.Tag == true && n.Nodes.Count == 0)
                    {
                        for(int i=0 ; i < 3; i++)
                        {
                            n.Nodes.Add(new TreeNode($"element{i}"));
                        }
                    }
                }
            }
        }
    }
}
