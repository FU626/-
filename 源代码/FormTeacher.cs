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
    public partial class FormTeacher : Form
    {
        public FormTeacher()
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
        }

        private void button_course_Click(object sender, EventArgs e)
        {
            FormCourseview_T formCourseview_T = new FormCourseview_T();
            formCourseview_T.textBox_Tno.Text = label_tno.Text.Trim();
            formCourseview_T.ShowDialog();
        }

        private void button_stu_grade_view_Click(object sender, EventArgs e)
        {
            Formstu_Grade_View_T formstu_Grade_View_T = new Formstu_Grade_View_T();
            formstu_Grade_View_T.ShowDialog();
        }

        private void button_stu_grade_input_Click(object sender, EventArgs e)
        {
            Formupdate_grade_T formupdate_Grade_T = new Formupdate_grade_T();
            formupdate_Grade_T.userid = label_userid.Text.Trim();
            formupdate_Grade_T.ShowDialog();
        }

        private void button_personal_Click(object sender, EventArgs e)
        {
            FormPerson_T formPerson_T = new FormPerson_T();
            formPerson_T.textBox_userid.Text = label_userid.Text.Trim();
            formPerson_T.ShowDialog();
        }
        SqlConnection con = new SqlConnection(Class1.schoolConnectionString);
        private void FormTeacher_Load(object sender, EventArgs e)
        {
            try
            {
                String userid = label_userid.Text.Trim();
                con.Open();

                String sql = "Select * from SysUser where userID = '" + userid + "'";
                SqlCommand sqlCommand1 = new SqlCommand(sql, con);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand1);
                //创建DataSet对象
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "SysUser");
                label_tno.Text = (string)dataSet.Tables["SysUser"].Rows[0]["UserSchoolID"];//根据用户名查找工号并显示
            }
            catch
            {
                MessageBox.Show("error!");
            }
        }
    }
}
