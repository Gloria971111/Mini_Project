using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_student_management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Clear();
        }

        public void Clear()
        {
            txtName.Text = "";
            txtScore.Text = "";
            txtID.Text = "";
            txtAdd.Text = "";
            rbGender1.Checked = true;
            rbHotel1.Checked = true;
            cb1.Checked = false;
            cbDept.Items.Clear();
            cbDept.Items.Add("计算机学院");
            cbDept.Items.Add("理学院");
            cbDept.Items.Add("生命科学学院");

            regTime.Value = DateTime.Today;

            speciality.Items.Clear();
            speciality.Items.Add("爱好音乐");
            speciality.Items.Add("爱好运动");
            speciality.Items.Add("爱好书法");
            speciality.Items.Add("爱好读书");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Clear();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string str = "";
            str = "学生详细信息如下:\r\n";
            str += "姓名：" + txtName.Text + "\r\n";
            if (rbGender1.Checked)
                str += "性别：" + rbGender1.Text + "\r\n";
            else
                str += "性别：" + rbGender2.Text + "\r\n";
            str += "身份证号：" + txtID.Text + "\r\n";
            str += "入学成绩：" + txtScore.Text + "\r\n";
            str += "家庭住址：" + txtAdd.Text + "\r\n";
            str += "专业：" + cbDept.SelectedText + "\r\n";
            str += "注册时间：" + regTime.Value.ToString() + "\r\n";
            str += "爱好：" + "\r\n";
            for (int i = 0; i < speciality.Items.Count; i++)
                if (speciality.GetItemChecked(i))
                    str += speciality.Items[i].ToString() + "\r\n";
            //result.Text = str;
            MessageBox.Show(str);
        }

        private void result_Click(object sender, EventArgs e)
        {

        }
    }
}
