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
    public partial class FormCourse_M : Form
    {
        public FormCourse_M()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=school;Persist Security Info=True;User ID=sa;Password=fucong916626");
        private void FormCourse_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“schoolDataSet1.Course”中。您可以根据需要移动或删除它。
            this.courseTableAdapter.Fill(this.schoolDataSet1.Course);

        }

        private void button_update_Click(object sender, EventArgs e)
        {
            int flag1 = 0, flag2 = 0;
            try
            {
                con.Open();//打开数据库
                string updatestr = "UPDATE Course SET ";
                String Courseno = textBox_cno.Text.Trim();
                String Coursename = textBox_cname.Text.Trim();
                String Coursepno = textBox_cpno.Text.Trim();//取出字符串
                String Coursecredit = textBox_ccredit.Text.Trim();
                if (checkBox_ccredit.Checked == true)
                {
                    if (flag1 == 0)
                    {
                        updatestr += "Ccredit = " + Coursecredit ;
                        flag1 = 1;
                    }
                    else
                        updatestr += ",Ccredit = " + Coursecredit;
                }
                if (checkBox_cname.Checked == true)
                {
                    if (flag1 == 0)
                    {
                        updatestr += "Cname = '" + Coursename + "'";
                        flag1 = 1;
                    }
                    else
                        updatestr += ",Cname = '" + Coursename + "'";
                }
                if (checkBox_cpno.Checked == true)
                {
                    if (flag1 == 0)
                    {
                        updatestr += "Cpno = '" + Coursepno + "'";
                        flag1 = 1;
                    }
                    else
                        updatestr += ",Cpno = '" + Coursepno + "'";
                }//被选中的项取出相应字符串
                updatestr += " WHERE Cno = '" + Courseno + "'";
                SqlCommand cmd = new SqlCommand(updatestr, con);
                cmd.ExecuteNonQuery();

                String sql = "insert into SysLog values ( '" + labelid.Text.Trim() + "' , '" + DateTime.Now + "' , '" + "Update Course" + "')";                                            //编写SQL命令
                SqlCommand sqlCommand = new SqlCommand(sql, con);//记录日志
                sqlCommand.ExecuteNonQuery();
            }
            catch
            {
                flag2 = 1;
                MessageBox.Show("输入数据违反要求!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();//断开数据库连接
            }
            
            if (flag2 == 0)
            {
                this.courseTableAdapter.Fill(this.schoolDataSet1.Course);
                MessageBox.Show("修改成功！", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }//改

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }//关闭

        private void button_delete_Click(object sender, EventArgs e)
        {
            int flag = 0;
            try
            {
                con.Open();
                string select_cno = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//选择的当前行第一列的值，也就是ID
                string delete_by_cno = "delete from Course where Cno=" + "'" + select_cno + "'";//sql删除语句,根据学号删除
                SqlCommand cmd = new SqlCommand(delete_by_cno, con);
                cmd.ExecuteNonQuery();  //执行命令

                String sql = "insert into SysLog values ( '" + labelid.Text.Trim() + "' , '" + DateTime.Now + "' , '" + "Delete Course" + "')";                                            //编写SQL命令
                SqlCommand sqlCommand = new SqlCommand(sql, con);//记录日志
                sqlCommand.ExecuteNonQuery();
            }
            catch
            {
                flag = 1;
                MessageBox.Show("请正确选择行!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(flag == 0)
            {
                this.courseTableAdapter.Fill(this.schoolDataSet1.Course);//使其显示更新后的表
                MessageBox.Show("成功删除！", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            con.Close();
        }//删

        private void button_insert_Click(object sender, EventArgs e)
        {

            int flag = 0;
            try
            {
                con.Open();
                String Courseno = textBox_cno.Text.Trim();
                String Coursename = textBox_cname.Text.Trim();
                String Coursepno = textBox_cpno.Text.Trim();//取出字符串
                String Coursecredit = textBox_ccredit.Text.Trim();
                String insertstr = "INSERT INTO  Course (Cno,Cname,Cpno,Ccredit)    " +
                    "VALUES ('" + Courseno + "','" + Coursename + "','" + Coursepno + "'," + Coursecredit +  ")";
                SqlCommand cmd = new SqlCommand(insertstr, con); //实例化数据库命令对象
                cmd.ExecuteNonQuery(); //执行命令

                String sql = "insert into SysLog values ( '" + labelid.Text.Trim() + "' , '" + DateTime.Now + "' , '" + "Insert Course" + "')";                                            //编写SQL命令
                SqlCommand sqlCommand = new SqlCommand(sql, con);//记录日志
                sqlCommand.ExecuteNonQuery();
            }
            catch
            {
                flag = 1;
                MessageBox.Show("输入数据有误，请输入有效数据！", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            
            if(flag == 0)
            {
                this.courseTableAdapter.Fill(this.schoolDataSet1.Course);//使其显示更新后的表
                MessageBox.Show("成功插入！", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }//增

        private void button_select_Click(object sender, EventArgs e)
        {

            String Courseno = textBox_cno.Text.Trim();
            String Coursename = textBox_cname.Text.Trim();
            String Coursepno = textBox_cpno.Text.Trim();//取出字符串
            String Coursecredit = textBox_ccredit.Text.Trim();
            try
            {
                con.Open();
                String select_by = "select * from Course where ";
                int flag1 = 0;       //表示前面是否已经加了筛选条件,为1，则后面的条件需要加AND       
                if (checkBox_cno.Checked == true)
                {
                    if (flag1 == 0)
                    {
                        select_by += "Cno='" + Courseno + "'";
                        flag1 = 1;
                    }
                    else
                    {
                        select_by += "AND Cno='" + Courseno + "'";
                    }
                }
                if (checkBox_cname.Checked == true)
                {
                    if (flag1 == 0)
                    {
                        select_by += "Cname='" + Coursename + "'";
                        flag1 = 1;
                    }
                    else
                    {
                        select_by += "AND Cname='" + Coursename + "'";
                    }
                }
                if (checkBox_cpno.Checked == true)
                {
                    if (flag1 == 0)
                    {
                        select_by += "Cpno='" + Coursepno + "'";
                        flag1 = 1;
                    }
                    else
                    {
                        select_by += "AND Cpno='" + Coursepno + "'";
                    }
                }
                if (checkBox_ccredit.Checked == true)
                {
                    if (flag1 == 0)
                    {
                        select_by += "Ccredit='" + Coursecredit + "'";
                        flag1 = 1;
                    }
                    else
                    {
                        select_by += "AND Ccredit='" + Coursecredit + "'";
                    }
                }
                
                SqlCommand sqlCommand = new SqlCommand(select_by, con);
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
        }//查

        private void buttonall_Click(object sender, EventArgs e)
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

        private void buttonclear_Click(object sender, EventArgs e)
        {
            textBox_cno.Text = "";
            textBox_cname.Text = "";
            textBox_cpno.Text = "";
            textBox_ccredit.Text = "";
            checkBox_cno.Checked = false;
            checkBox_cname.Checked = false;
            checkBox_cpno.Checked = false;
            checkBox_ccredit.Checked = false;
        }//清除所有
    }
}
