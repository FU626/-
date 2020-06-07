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
    public partial class FormTeacher_M : Form
    {
        public FormTeacher_M()
        {
            InitializeComponent();
        }

        private void FormTeacher_M_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“schoolDataSet2.Teacher”中。您可以根据需要移动或删除它。
            this.teacherTableAdapter.Fill(this.schoolDataSet2.Teacher);

        }
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=school;Persist Security Info=True;User ID=sa;Password=fucong916626");
        private void button_insert_Click(object sender, EventArgs e)
        {
            String Strtno = textBox_tno.Text.Trim();
            String Strtname = textBox_tname.Text.Trim();
            String StrSex = "男";  //默认性别为男
            String Striden = "讲师";  //默认教师职称为讲师
            String Strsalary = textBox_salary.Text.Trim();
            String Strtdept = textBox_tdept.Text.Trim();
            String StrAge = textBox_tage.Text.Trim();//取出字符串

            int flag = 0;

            if(radioButton2.Checked)
            {
                StrSex = "女";
            }

            if(radioButton_iden1.Checked)
            {
                Striden = "教授";
            }
            else if(radioButton_iden2.Checked)
            {
                Striden = "副教授";
            }

            try
            {
                con.Open();
                String insertstr = "INSERT INTO  Teacher (Tno,Tname,Tsex,Tdept,Tiden,Tage,Salary)    " +
                    "VALUES ('" + Strtno + "','" + Strtname + "','" + StrSex + "','" + Strtdept + "','" + Striden + "'," + StrAge + "," + Strsalary + ")";//SQL插入语句
                SqlCommand cmd = new SqlCommand(insertstr, con); //实例化数据库命令对象
                cmd.ExecuteNonQuery(); //执行命令

                String sql = "insert into SysLog values ( '" + userid + "' , '" + DateTime.Now + "' , '" + "Insert Teacher" + "')";                                            //编写SQL命令
                SqlCommand sqlCommand = new SqlCommand(sql, con);//记录日志
                sqlCommand.ExecuteNonQuery();
            }
            catch
            {
                flag = 1;
                MessageBox.Show("输入数据有误，请输入有效数据！", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);//插入数据有误，对话框提示
            }
            finally
            {
                this.teacherTableAdapter.Fill(this.schoolDataSet2.Teacher);//使其显示更新后的表
                con.Close(); //断开数据库连接
            }
            if (flag == 0)
            {
                MessageBox.Show("插入成功！", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }//增加

        private void button_delete_Click(object sender, EventArgs e)
        {
            int flag = 0;
            try
            {
                con.Open();
                string select_id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//选择的当前行第一列的值，也就是ID
                string delete_by_id = "delete from Teacher where Tno=" + "'" + select_id + "'";//sql删除语句,根据工号删除
                SqlCommand cmd = new SqlCommand(delete_by_id, con);
                cmd.ExecuteNonQuery();  //执行命令

                String sql = "insert into SysLog values ( '" + userid + "' , '" + DateTime.Now + "' , '" + "Delete Teacher" + "')";                                            //编写SQL命令
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
            this.teacherTableAdapter.Fill(this.schoolDataSet2.Teacher);//使其显示更新后的表
            if (flag == 0)
            {
                MessageBox.Show("成功删除！", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }//删除

        private void button_update_Click(object sender, EventArgs e)
        {
            String update_by_tno = textBox_update_by_tno.Text.Trim();
            String update_item = textBox_update_item.Text.Trim();
            String item_name = comboBox1.SelectedItem.ToString();
            int flag1 = 0;  //该变量表示组合框是否选中项
            int flag2 = 0; //该变量表示是否修改成功
            try
            {
                con.Open();
                String updatestr = "UPDATE Teacher SET ";
                switch(item_name)
                {
                    case "Tname": //第一个选项为Tname
                        {
                            updatestr += "Tname = '" + update_item + "'";
                            break;
                        }
                    case "Tsex":
                        {
                            updatestr += "Tsex = '" + update_item + "'";
                            break;
                        }
                    case "Tdept":
                        {
                            updatestr += "Tdept = '" + update_item + "'";
                            break;
                        }
                    case "Tiden":
                        {
                            updatestr += "Tiden = '" + update_item + "'";
                            break;
                        }
                    case "Tage":
                        {
                            updatestr += "Tage = " + update_item ;
                            break;
                        }
                    case "Salary":
                        {
                            updatestr += "Salary = " + update_item;
                            break;
                        }
                    default:
                        {
                            flag1 = 1;
                            MessageBox.Show("请选择你要修改的项", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            break;
                        }
                }
                if (flag1 == 0)
                {
                    updatestr += " Where Tno = '" + update_by_tno + "'";
                    SqlCommand cmd = new SqlCommand(updatestr, con); //实例化数据库命令对象
                    cmd.ExecuteNonQuery(); //执行命令

                    String sql = "insert into SysLog values ( '" + userid + "' , '" + DateTime.Now + "' , '" + "Update Teacher" + "')";                                            //编写SQL命令
                    SqlCommand sqlCommand = new SqlCommand(sql, con);//记录日志
                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch
            {
                flag2 = 1;
                MessageBox.Show("输入数据有误，请输入有效数据！", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.teacherTableAdapter.Fill(this.schoolDataSet2.Teacher);//使其显示更新后的表
                con.Close(); //释放
            }
            if(flag2 == 0)
            {
                MessageBox.Show("修改成功！", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }//更新

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_tno.Text = "";
            textBox_tname.Text = "";
            radioButton1.Checked = true;  //默认性别为男
            radioButton2.Checked = false;
            radioButton_iden3.Checked = true;  //默认教师职称为讲师
            radioButton_iden1.Checked = false;
            radioButton_iden2.Checked = false;
            textBox_salary.Text = "";
            textBox_tdept.Text = "";
            textBox_tage.Text = "";
        }//在插入界面中的全部清除所输入的数据

        private void button_select_Click(object sender, EventArgs e)
        {
            String Strtno = textBox_tno_select.Text.Trim();
            String Strtname = textBox_tname_select.Text.Trim();
            String Strsalary = textBox_salary_select.Text.Trim();
            String Strtdept = textBox_tdept_select.Text.Trim();
            String StrAge = textBox_tage_select.Text.Trim();//取出字符串
            
            try
            {
                con.Open();
                String select_by_id = "select * from Teacher where ";
                int flag1 = 0;       //表示前面是否已经加了筛选条件,1表示前面有其他条件，则后面的条件需要加AND       
                if (checkBox_tno.Checked == true)
                {
                    if (flag1 == 0)
                    {
                        select_by_id += "Tno='" + Strtno + "'";
                        flag1 = 1;
                    }
                    else
                    {
                        select_by_id += " AND Tno='" + Strtno + "'";
                    }
                }
                if (checkBox_tname.Checked == true)
                {
                    if (flag1 == 0)
                    {
                        select_by_id += "(Tname='" + Strtname + "' OR Tname LIKE '" + Strtname + "%')";
                        flag1 = 1;
                    }
                    else
                    {
                        select_by_id += "AND (Tname='" + Strtname + "' OR Tname LIKE '" + Strtname + "%')";
                    }
                }
                if (checkBox_tsex.Checked == true)
                {
                    String StrSex = comboBox2.SelectedItem.ToString();
                    if (flag1 == 0)
                    {
                        select_by_id += "Tsex='" + StrSex + "'";
                        flag1 = 1;
                    }
                    else
                    {
                        select_by_id += "AND Tsex='" + StrSex + "'";
                    }
                }
                if (checkBox_tdept.Checked == true)
                {
                    if (flag1 == 0)
                    {
                        select_by_id += "(Tdept='" + Strtdept + "' OR Tdept LIKE '" + Strtdept + "%')";
                        flag1 = 1;
                    }
                    else
                    {
                        select_by_id += "AND (Tdept='" + Strtdept + "' OR Tdept LIKE '" + Strtdept + "%')";
                    }
                }
                if (checkBox_tage.Checked == true)
                {
                    if (flag1 == 0)
                    {
                        select_by_id += "Tage=" + StrAge ;
                        flag1 = 1;
                    }
                    else
                    {
                        select_by_id += "AND Tage = " + StrAge;
                    }
                }
                if (checkBox_tiden.Checked == true)
                {
                    String Striden = comboBox3.SelectedItem.ToString();  //取出组合框中的选中项
                    if (flag1 == 0)
                    {
                        select_by_id += "Tiden='" + Striden + "'";
                        flag1 = 1;
                    }
                    else
                    {
                        select_by_id += "AND Tiden='" + Striden + "'";
                    }
                }
                if (checkBox_salary.Checked == true)
                {
                    if (flag1 == 0)
                    {
                        select_by_id += "Salary=" + Strsalary;
                        flag1 = 1;
                    }
                    else
                    {
                        select_by_id += "AND Salary=" + Strsalary;
                    }
                }
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
        }//查询

        private void button_show_all_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String select_by_id = "select * from Teacher";
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
        }//显示表中所有数据

        private void button_clear_select_Click(object sender, EventArgs e)
        {
            textBox_tno_select.Text = "";
            textBox_tname_select.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";  
            textBox_salary_select.Text = "";
            textBox_tdept_select.Text = "";
            textBox_tage_select.Text = "";
            checkBox_salary.Checked = false;
            checkBox_tno.Checked = false;
            checkBox_tname.Checked = false;
            checkBox_tsex.Checked = false;
            checkBox_tdept.Checked = false;
            checkBox_tiden.Checked = false;
            checkBox_tage.Checked = false;
        }//清除查询界面中的所有输入数据


        private void button_back_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }//返回之前的管理员界面

        private void button1_Click(object sender, EventArgs e)
        {
            textBox_update_by_tno.Text = "";
            comboBox1.Text = "";
            textBox_update_item.Text = "";
        }//更新界面中的清除所有输入
    }
}
