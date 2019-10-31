using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace myExplor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void NodeUpdate(TreeNode node)
        {
            try
            {
                node.Nodes.Clear();
                DirectoryInfo dir = new DirectoryInfo(node.FullPath);
                DirectoryInfo[] dirs = dir.GetDirectories();
                foreach(DirectoryInfo d in dirs)
                {
                    TreeNode subnode = new TreeNode(d.Name);
                    subnode.ImageIndex = 2;
                    subnode.SelectedImageIndex = 2;
                    node.Nodes.Add(subnode);
                }
            }
            catch
            { }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            listView1.Items.Clear();
            DriveInfo[] drs = DriveInfo.GetDrives();
            foreach(DriveInfo dr in drs)
            {
                TreeNode node = treeView1.Nodes.Add(dr.Name);
                ListViewItem item = listView1.Items.Add(dr.Name);
                item.Name = dr.Name;
                if(dr.DriveType==DriveType.CDRom)
                {
                    node.ImageIndex = 1;
                    node.SelectedImageIndex = 1;
                    item.ImageIndex = 1;
                }
                else
                {
                    node.ImageIndex = 0;
                    node.SelectedImageIndex = 0;
                    item.ImageIndex = 0;
                }
            }
            foreach(TreeNode node in treeView1.Nodes)
            {
                this.NodeUpdate(node);
            }
        }

        private void treeView1_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            NodeUpdate(e.Node);
            foreach(TreeNode node in e.Node.Nodes)
            {
                NodeUpdate(node);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            e.Node.Expand();
            try
            {
                DirectoryInfo currentDir = new DirectoryInfo(e.Node.FullPath);
                DirectoryInfo[] dirs = currentDir.GetDirectories();
                FileInfo[] files = currentDir.GetFiles();
                listView1.Items.Clear();
                foreach(DirectoryInfo dir in dirs)
                {
                    ListViewItem item = new ListViewItem(new string[] { dir.Name + "文件夹", dir.LastAccessTime.ToString() });
                    listView1.Items.Add(item);
                }
                foreach(FileInfo file in files)
                {
                    ListViewItem item = new ListViewItem(new string[] { file.Name, file.LastAccessTime.ToString() });
                    listView1.Items.Add(item);
                }
            }
            catch { }
        }
    }
}
