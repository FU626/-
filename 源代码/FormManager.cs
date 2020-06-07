using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 登录
{
    public partial class FormManager : Form
    {
        public FormManager()
        {
            InitializeComponent();
        }


        private void buttonall_Click(object sender, EventArgs e)
        {
            FormCheck_M formCheck = new FormCheck_M();
            formCheck.ShowDialog();
        }

        private void button_stu_Click(object sender, EventArgs e)
        {
            FormStu_M formStu = new FormStu_M();
            formStu.userid = this.userid;
            formStu.Show();
            this.Hide();
        }

        private void button_course_Click(object sender, EventArgs e)
        {
            FormCourse_M formCourse = new FormCourse_M();
            formCourse.labelid.Text = userid;
            formCourse.ShowDialog();
        }

        private void button_sc_Click(object sender, EventArgs e)
        {
            FormSC_M formSC = new FormSC_M();
            formSC.userid = this.userid;
            formSC.ShowDialog();
        }

        

        private void button_Teacher_Click(object sender, EventArgs e)
        {
            FormTeacher_M formTeacher_M = new FormTeacher_M();
            formTeacher_M.userid = this.userid;
            formTeacher_M.ShowDialog();
        }

        private void button_person_Click(object sender, EventArgs e)
        {
            FormPersoninputUserID_M formPersonUserID = new FormPersoninputUserID_M();
            formPersonUserID.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要退出登录么？", "Tips", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);//取出按钮结果
            if (result == DialogResult.OK)
            {
                Formlogin formlogin = new Formlogin();
                formlogin.Show();
                this.Close();
            }
        }

        private void button_User_Click(object sender, EventArgs e)
        {
            FormUser_M formUser_M = new FormUser_M();
            formUser_M.userid = this.userid;
            formUser_M.ShowDialog();
        }
    }
}
