namespace winform_student_management
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.rbGender1 = new System.Windows.Forms.RadioButton();
            this.rbGender2 = new System.Windows.Forms.RadioButton();
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbHotel2 = new System.Windows.Forms.RadioButton();
            this.rbHotel1 = new System.Windows.Forms.RadioButton();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cbDept = new System.Windows.Forms.ComboBox();
            this.regTime = new System.Windows.Forms.DateTimePicker();
            this.speciality = new System.Windows.Forms.CheckedListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "学生姓名：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(179, 41);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(119, 28);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "身份证号：";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(179, 95);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(119, 28);
            this.txtID.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "家庭住址：";
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(179, 147);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(278, 28);
            this.txtAdd.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(345, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "性别：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(345, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "入学成绩：";
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(449, 95);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(119, 28);
            this.txtScore.TabIndex = 8;
            // 
            // rbGender1
            // 
            this.rbGender1.AutoSize = true;
            this.rbGender1.Location = new System.Drawing.Point(413, 44);
            this.rbGender1.Name = "rbGender1";
            this.rbGender1.Size = new System.Drawing.Size(51, 22);
            this.rbGender1.TabIndex = 9;
            this.rbGender1.TabStop = true;
            this.rbGender1.Text = "男";
            this.rbGender1.UseVisualStyleBackColor = true;
            // 
            // rbGender2
            // 
            this.rbGender2.AutoSize = true;
            this.rbGender2.Location = new System.Drawing.Point(499, 44);
            this.rbGender2.Name = "rbGender2";
            this.rbGender2.Size = new System.Drawing.Size(51, 22);
            this.rbGender2.TabIndex = 10;
            this.rbGender2.TabStop = true;
            this.rbGender2.Text = "女";
            this.rbGender2.UseVisualStyleBackColor = true;
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Location = new System.Drawing.Point(499, 150);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(70, 22);
            this.cb1.TabIndex = 11;
            this.cb1.Text = "团员";
            this.cb1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbHotel2);
            this.groupBox1.Controls.Add(this.rbHotel1);
            this.groupBox1.Location = new System.Drawing.Point(84, 251);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "宿舍";
            // 
            // rbHotel2
            // 
            this.rbHotel2.AutoSize = true;
            this.rbHotel2.Location = new System.Drawing.Point(24, 57);
            this.rbHotel2.Name = "rbHotel2";
            this.rbHotel2.Size = new System.Drawing.Size(105, 22);
            this.rbHotel2.TabIndex = 1;
            this.rbHotel2.TabStop = true;
            this.rbHotel2.Text = "第二公寓";
            this.rbHotel2.UseVisualStyleBackColor = true;
            // 
            // rbHotel1
            // 
            this.rbHotel1.AutoSize = true;
            this.rbHotel1.Location = new System.Drawing.Point(24, 28);
            this.rbHotel1.Name = "rbHotel1";
            this.rbHotel1.Size = new System.Drawing.Size(105, 22);
            this.rbHotel1.TabIndex = 0;
            this.rbHotel1.TabStop = true;
            this.rbHotel1.Text = "第一公寓";
            this.rbHotel1.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(165, 420);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(105, 32);
            this.btnOk.TabIndex = 13;
            this.btnOk.Text = "确认";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(359, 420);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(105, 32);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cbDept
            // 
            this.cbDept.FormattingEnabled = true;
            this.cbDept.Location = new System.Drawing.Point(84, 200);
            this.cbDept.Name = "cbDept";
            this.cbDept.Size = new System.Drawing.Size(200, 26);
            this.cbDept.TabIndex = 16;
            // 
            // regTime
            // 
            this.regTime.Location = new System.Drawing.Point(325, 198);
            this.regTime.Name = "regTime";
            this.regTime.Size = new System.Drawing.Size(200, 28);
            this.regTime.TabIndex = 17;
            // 
            // speciality
            // 
            this.speciality.FormattingEnabled = true;
            this.speciality.Location = new System.Drawing.Point(325, 260);
            this.speciality.Name = "speciality";
            this.speciality.Size = new System.Drawing.Size(214, 119);
            this.speciality.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 488);
            this.Controls.Add(this.speciality);
            this.Controls.Add(this.regTime);
            this.Controls.Add(this.cbDept);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.rbGender2);
            this.Controls.Add(this.rbGender1);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "学生信息管理";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.RadioButton rbGender1;
        private System.Windows.Forms.RadioButton rbGender2;
        private System.Windows.Forms.CheckBox cb1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbHotel2;
        private System.Windows.Forms.RadioButton rbHotel1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cbDept;
        private System.Windows.Forms.DateTimePicker regTime;
        private System.Windows.Forms.CheckedListBox speciality;
    }
}

