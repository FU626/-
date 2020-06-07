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
    public partial class FormGrade_stu : Form
    {
        public FormGrade_stu()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(Class1.schoolConnectionString);
        private void FormGrade_stu_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“schoolDataSet3.STU_Grade”中。您可以根据需要移动或删除它。
            this.sTU_GradeTableAdapter.Fill(this.schoolDataSet3.STU_Grade);
           
            String Strsno = label2.Text.Trim();
            String select_by_sno = "select * from STU_Grade where Sno = '" + Strsno + "'";
            try
            {
                con.Open();
                SqlCommand sqlCommand = new SqlCommand(select_by_sno, con);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = sqlDataReader;
                dataGridView1.DataSource = bindingSource;
            }
            catch
            {
                MessageBox.Show("ERROR！");
            }
            finally
            {
                con.Close();
            }
        }
        int flag = 0;//flag表示按下的哪个按钮，确定当前显示 0 为显示所有成绩，1为显示pass成绩，2为显示no pass成绩
        private void button_all_Click(object sender, EventArgs e)
        {
            if (flag != 0)//当前不是显示所有的时候处理，否则不处理
            {
                flag = 0;
                String Strsno = label2.Text.Trim();
                String select_by_sno = "select * from STU_Grade where Sno = '" + Strsno + "'";
                try
                {
                    con.Open();
                    SqlCommand sqlCommand = new SqlCommand(select_by_sno, con);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = sqlDataReader;
                    dataGridView1.DataSource = bindingSource;
                }
                catch
                {
                    MessageBox.Show("ERROR！");
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void button_pass_Click(object sender, EventArgs e)
        {
            if (flag != 1)
            {
                flag = 1;
                String Strsno = label2.Text.Trim();
                String select_by_sno = "select * from STU_Grade where Grade >= 60 and Sno = '" + Strsno + "'";
                try
                {
                    con.Open();
                    SqlCommand sqlCommand = new SqlCommand(select_by_sno, con);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = sqlDataReader;
                    dataGridView1.DataSource = bindingSource;
                }
                catch
                {
                    MessageBox.Show("ERROR！");
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void button_nopass_Click(object sender, EventArgs e)
        {
            if (flag != 2)
            {
                flag = 2;
                String Strsno = label2.Text.Trim();
                String select_by_sno = "select * from STU_Grade where Grade < 60 and Sno = '" + Strsno + "'";
                try
                {
                    con.Open();
                    SqlCommand sqlCommand = new SqlCommand(select_by_sno, con);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = sqlDataReader;
                    dataGridView1.DataSource = bindingSource;
                }
                catch
                {
                    MessageBox.Show("ERROR！");
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void button_grade_order_Click(object sender, EventArgs e)
        {
            String Strsno = label2.Text.Trim();
            String order_by = "";
            if (flag == 0)//对所有成绩排序
            {
                order_by = "select* from STU_Grade where Sno = '" + Strsno + "' order by Grade DESC";
            }//成绩降序排列
            else if(flag == 1)//仅对pass成绩排序
            {
                order_by = "select * from STU_Grade where Grade >= 60 and Sno = '" + Strsno + "' order by Grade DESC";
            }
            else//仅对no pass成绩排序
            {
                order_by = "select * from STU_Grade where Grade < 60 and Sno = '" + Strsno + "' order by Grade DESC";
            }
            try
            {
                con.Open();
                SqlCommand sqlCommand = new SqlCommand(order_by, con);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = sqlDataReader;
                dataGridView1.DataSource = bindingSource;
            }
            catch
            {
                MessageBox.Show("ERROR！");
            }
            finally
            {
                con.Close();
            }
        }
    }
}
