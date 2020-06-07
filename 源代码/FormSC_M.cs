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
    public partial class FormSC_M : Form
    {
        public FormSC_M()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=school;Persist Security Info=True;User ID=sa;Password=fucong916626");
        private void FormSC_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“schoolDataSet1.SC”中。您可以根据需要移动或删除它。
            this.sCTableAdapter.Fill(this.schoolDataSet1.SC);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonall_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String select_by_id = "select * from SC";
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
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            textBox_cno.Text = "";
            textBox_sno.Text = "";
            textBox_grade.Text = "";
            checkBox_cno.Checked = false;
            checkBox_sno.Checked = false;
            checkBox_grade.Checked = false;
            comboBox1.Text = "";
        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            int flag = 0;
            try
            {
                con.Open();
                String Courseno = textBox_cno.Text.Trim();
                String Stuno = textBox_sno.Text.Trim();
                String SCGrade = textBox_grade.Text.Trim();//取出字符串

                String insertstr = "INSERT INTO  SC (Cno,Sno,Grade)    " +
                    "VALUES ('" + Courseno + "','" + Stuno + "','" + SCGrade + "')";
                SqlCommand cmd = new SqlCommand(insertstr, con); //实例化数据库命令对象
                cmd.ExecuteNonQuery(); //执行命令

                String sql = "insert into SysLog values ( '" + userid + "' , '" + DateTime.Now + "' , '" + "Insert SC" + "')";                                            //编写SQL命令
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
            this.sCTableAdapter.Fill(this.schoolDataSet1.SC);//使其显示更新后的表
            if(flag == 0)
            {
                MessageBox.Show("成功插入！", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            int flag = 0;
            try
            {
                con.Open();
                string select_sno = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string select_cno = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();//选择的当前行第一列的值，也就是ID
                string delete_by_cno = "delete from SC where Cno=" + "'" + select_cno + "' AND Sno = " + "'" + select_sno + "'";//sql删除语句,根据学号删除
                SqlCommand cmd = new SqlCommand(delete_by_cno, con);
                cmd.ExecuteNonQuery();  //执行命令

                String sql = "insert into SysLog values ( '" + userid + "' , '" + DateTime.Now + "' , '" + "Delete SC" + "')";                                            //编写SQL命令
                SqlCommand sqlCommand = new SqlCommand(sql, con);//记录日志
                sqlCommand.ExecuteNonQuery();
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
            this.sCTableAdapter.Fill(this.schoolDataSet1.SC);//使其显示更新后的表
            if(flag == 0)
            {
                MessageBox.Show("成功删除！", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            int flag2 = 0;
            try
            {
                con.Open();//打开数据库
                
                String Courseno = textBox_cno.Text.Trim();
                String Stuno = textBox_sno.Text.Trim();
                String SCGrade = textBox_grade.Text.Trim();//取出字符串
                string updatestr = "UPDATE SC SET Grade = " + SCGrade +"WHERE Sno = '" + Stuno + "' AND Cno = '" + Courseno + "'";
                SqlCommand cmd = new SqlCommand(updatestr, con);
                cmd.ExecuteNonQuery();

                String sql = "insert into SysLog values ( '" + userid + "' , '" + DateTime.Now + "' , '" + "Update SC" + "')";                                            //编写SQL命令
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
            this.sCTableAdapter.Fill(this.schoolDataSet1.SC);
            if (flag2 == 0)
            {
                MessageBox.Show("修改成功！", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void button_select_Click(object sender, EventArgs e)
        {
            String Courseno = textBox_cno.Text.Trim();
            String Stuno = textBox_sno.Text.Trim();
            String SCGrade = textBox_grade.Text.Trim();
            try
            {
                con.Open();
                String select_by = "select * from SC where ";
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
                if (checkBox_sno.Checked == true)
                {
                    if (flag1 == 0)
                    {
                        select_by += "Sno='" + Stuno + "'";
                        flag1 = 1;
                    }
                    else
                    {
                        select_by += "AND Sno='" + Stuno + "'";
                    }
                }
                if (checkBox_grade.Checked == true)
                {
                    if (flag1 == 0)
                    {
                        switch(comboBox1.Text)
                        {
                            case ">":
                                {
                                    select_by += "Grade>" + SCGrade;
                                    break;
                                }
                            case "<":
                                {
                                    select_by += "Grade<" + SCGrade;
                                    break;
                                }
                            case "=":
                                {
                                    select_by += "Grade=" + SCGrade;
                                    break;
                                }
                            case "<=":
                                {
                                    select_by += "Grade<=" + SCGrade;
                                    break;
                                }
                            case ">=":
                                {
                                    select_by += "Grade>=" + SCGrade;
                                    break;
                                }
                        }
                        flag1 = 1;
                    }
                    else
                    {
                        switch (comboBox1.Text)
                        {
                            case ">":
                                {
                                    select_by += "AND Grade>" + SCGrade;
                                    break;
                                }
                            case "<":
                                {
                                    select_by += "AND Grade<" + SCGrade;
                                    break;
                                }
                            case "=":
                                {
                                    select_by += "AND Grade=" + SCGrade;
                                    break;
                                }
                            case "<=":
                                {
                                    select_by += "AND Grade<=" + SCGrade;
                                    break;
                                }
                            case ">=":
                                {
                                    select_by += "AND Grade>=" + SCGrade;
                                    break;
                                }
                        }
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
        }
    }
}
