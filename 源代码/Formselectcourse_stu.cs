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
    public partial class Formselectcourse_stu : Form
    {
        public Formselectcourse_stu()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=school;Persist Security Info=True;User ID=sa;Password=fucong916626");
        int flag = 0;//该标志变量表示是否存在该课程
        private void Formselectcourse_stu_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“schoolDataSet.Course”中。您可以根据需要移动或删除它。
            this.courseTableAdapter.Fill(this.schoolDataSet.Course);
            String Strsno = label2.Text.Trim();
            try
            {
                con.Open();
                String select_by_sno = "Select Course.Cno,Cname,Cpno,Ccredit from Course,SC where SC.Cno = Course.Cno AND SC.Sno = '" + Strsno + "'";
                SqlCommand cmd = new SqlCommand(select_by_sno, con);
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = sqlDataReader;
                dataGridView2.DataSource = bindingSource;
            }
            catch
            {
                MessageBox.Show("ERROR!");
            }
            finally
            {
                con.Close();
            }
        }//窗口加载事件

        private void button_select_Click(object sender, EventArgs e)
        {
            if(textBox_select.Text.Trim() == "")
            {
                MessageBox.Show("请输入你要的选择的课程号！", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                String Strselect = textBox_select.Text.Trim();
                String strsno = label2.Text.Trim();
                try
                {
                    if (flag == 1)//课程存在
                    {
                        con.Open();
                        DialogResult result = MessageBox.Show("确定选择该课程么？", "Tips", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if(result == DialogResult.OK)
                        {
                            String insertstr = "Insert into SC VALUES('" + strsno + "','" + Strselect + "',NULL)";
                            SqlCommand cmd1 = new SqlCommand(insertstr, con);
                            cmd1.ExecuteNonQuery();
                            String select_by_sno = "Select Course.Cno,Cname,Cpno,Ccredit from Course,SC where SC.Cno = Course.Cno AND SC.Sno = '" + strsno + "'";
                            SqlCommand cmd = new SqlCommand(select_by_sno, con);
                            SqlDataReader sqlDataReader = cmd.ExecuteReader();
                            BindingSource bindingSource = new BindingSource();
                            bindingSource.DataSource = sqlDataReader;
                            dataGridView2.DataSource = bindingSource;
                            MessageBox.Show("选课成功！", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        } 
                    }
                }
                catch
                {
                    MessageBox.Show("ERROR!");
                }
                finally
                {
                    con.Close();
                }
            }
        }//选课

        private void button_question_Click(object sender, EventArgs e)
        {
            try
            {
                String Strselect = textBox_select.Text.Trim();
                con.Open();
                String Coursestr = "Select * from Course where Cno = '" + Strselect + "'";
                SqlCommand cmd2 = new SqlCommand(Coursestr, con);
                SqlDataReader sqlDataReader1 = cmd2.ExecuteReader();
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = sqlDataReader1;
                dataGridView1.DataSource = bindingSource;
                if (sqlDataReader1.HasRows)
                {
                    flag = 1;//课程存在
                }
            }
            catch
            {
                MessageBox.Show("ERROR!");
            }
            finally
            {
                con.Close();
            }
        }//查询课程

        private void button_quit_Click(object sender, EventArgs e)
        {
            int flag = 0;
            String strsno = label2.Text.Trim();
            try
            {
                con.Open();
                string select_cno = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();//选择的当前行第一列的值
                string delete_by = "delete from SC where Cno=" + "'" + select_cno + "' and Sno = '" + strsno + "'";//sql删除语句,根据学号删除
                SqlCommand cmd = new SqlCommand(delete_by, con);
                cmd.ExecuteNonQuery();  //执行命令
                String select_by_sno = "Select Course.Cno,Cname,Cpno,Ccredit from Course,SC where SC.Cno = Course.Cno AND SC.Sno = '" + strsno + "'";
                SqlCommand cmd2 = new SqlCommand(select_by_sno, con);
                SqlDataReader sqlDataReader = cmd2.ExecuteReader();
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = sqlDataReader;
                dataGridView2.DataSource = bindingSource;
            }
            catch
            {
                flag = 1;
                MessageBox.Show("请正确选择行!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            if (flag == 0)
            {
                MessageBox.Show("成功退课！", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String select_by_id = "select * from Course";
                SqlCommand sqlCommand = new SqlCommand(select_by_id, con);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = sqlDataReader;
                dataGridView1.DataSource = bindingSource;
            }
            catch
            {
                MessageBox.Show("查询语句有误，请认真检查SQL语句!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }//显示所有
    }
}
