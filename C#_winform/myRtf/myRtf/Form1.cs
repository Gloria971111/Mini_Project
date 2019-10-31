using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myRtf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "新建rtf文档";
        }

        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void 剪切ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void 粘贴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "C:\\";
            openFileDialog.Filter = "rtf文件(*.rtf)|*.rtf|doc文件(*.doc)|*.doc";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            if(openFileDialog.ShowDialog()==DialogResult.OK)
            {
                try
                {
                    richTextBox1.LoadFile(openFileDialog.FileName);
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = "C:\\";
            saveFileDialog.Filter = "rtf文件(*.rtf)|*.rtf|doc文件(*.doc)|*.doc";
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                richTextBox1.SaveFile(saveFileDialog.FileName);
        }

        private void 打印ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;
            if(printDialog.ShowDialog()==DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void 字体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowColor = true;
            fontDialog.Font = richTextBox1.SelectionFont;
            fontDialog.Color = richTextBox1.SelectionColor;
            if(fontDialog.ShowDialog()==DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog.Font;
                richTextBox1.SelectionColor = fontDialog.Color;
            }
        }

        private void 版本ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version1.0", "版本信息");
        }
    }
}
