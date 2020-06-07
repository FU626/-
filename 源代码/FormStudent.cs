using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 登录
{
    public partial class FormStudent : Form
    {
        public FormStudent()
        {
            InitializeComponent();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要退出登录么？", "Tips", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);//取出按钮结果
            if (result == DialogResult.OK)
            {
                Formlogin formlogin = new Formlogin();
                formlogin.Show();
                this.Close();
            }
        }//退出登录

        private void button_course_Click(object sender, EventArgs e)
        {
            if (textBox_sno.Text.Trim() == "")
            {
                MessageBox.Show("请先输入你的学号，而后选择功能！", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                FormMycourse_stu formMycourse_Stu = new FormMycourse_stu();
                formMycourse_Stu.label2.Text = textBox_sno.Text.Trim();
                formMycourse_Stu.ShowDialog();
            }
        }

        private void button_grade_Click(object sender, EventArgs e)
        {
            if (textBox_sno.Text.Trim() == "")
            {
                MessageBox.Show("请先输入你的学号，而后选择功能！", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                FormGrade_stu formGrade_Stu = new FormGrade_stu();
                formGrade_Stu.label2.Text += textBox_sno.Text.Trim();
                formGrade_Stu.ShowDialog();
            }
        }

        private void button_select_Click(object sender, EventArgs e)
        {
            if (textBox_sno.Text.Trim() == "")
            {
                MessageBox.Show("请先输入你的学号，而后选择功能！", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Formselectcourse_stu formselectcourse_Stu = new Formselectcourse_stu();
                formselectcourse_Stu.label2.Text = textBox_sno.Text.Trim();
                formselectcourse_Stu.ShowDialog();
            }
        }

        private void button_personal_Click(object sender, EventArgs e)
        {
            if (textBox_sno.Text.Trim() == "")
            {
                MessageBox.Show("请先输入你的学号，而后选择功能！", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                FormPerson_stu formPerson_Stu = new FormPerson_stu();
                formPerson_Stu.label_Sno.Text = textBox_sno.Text.Trim();
                formPerson_Stu.ShowDialog();
            }
        }

        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=school;Persist Security Info=True;User ID=sa;Password=fucong916626");
        private void FormStudent_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String username = label_userid.Text.Trim();
                String sql = "Select * from SysUser where UserID = '" + username + "'";
                SqlCommand sqlCommand1 = new SqlCommand(sql, con);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand1);
                //创建DataSet对象
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "SysUser");
                textBox_sno.Text = (string)dataSet.Tables["SysUser"].Rows[0]["UserSchoolID"];
                //根据用户名取出学号，防止输入他人的学号，窥视他人信息
            }
            catch
            {
                MessageBox.Show("ERROR!");
            }
            con.Close();
        }
    }
}