using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myText
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void 剪切ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void 粘贴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = "现在共" + textBox1.Text.Length + "个字符数";
        }
    }
}
