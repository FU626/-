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
    public partial class FormUpdate : Form
    {
        public FormUpdate()
        {
            InitializeComponent();
        }

        private void FormUpdate_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“schoolDataSet.Student”中。您可以根据需要移动或删除它。
            this.studentTableAdapter.Fill(this.schoolDataSet.Student);

        }

        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=school;Persist Security Info=True;User ID=sa;Password=fucong916626");

        private void buttonclear_Click(object sender, EventArgs e)
        {
            textBox_sno.Text = "";
            textBox_sname.Text = "";
            textBox_ssex.Text = "";
            textBox_sdept.Text = "";
            textBox_sage.Text = "";
            checkBox_sage.Checked = false;
            checkBox_sdept.Checked = false;
            checkBox_ssex.Checked = false;
            checkBox_sname.Checked = false;
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            int flag1 = 0, flag2 = 0;
            try
            {
                con.Open();//打开数据库
                string updatestr = "UPDATE Student SET ";
                String StuID = textBox_sno.Text.Trim();
                String StuSdept = textBox_sdept.Text.Trim();
                String StuAge = textBox_sage.Text.Trim();//取出字符串
                String StuName = textBox_sname.Text.Trim();
                String StuSex = textBox_ssex.Text.Trim();
                if (checkBox_sdept.Checked == true)
                {
                    if (flag1 == 0)
                    {
                        updatestr += "Sdept = '" + StuSdept + "'";
                        flag1 = 1;
                    }
                    else
                        updatestr += ", Sdept = '" + StuSdept + "'";
                }
                if (checkBox_sage.Checked == true)
                {
                    if (flag1 == 0)
                    {
                        updatestr += "Sage = " + StuAge ;
                        flag1 = 1;
                    }
                    else
                        updatestr += ", Sage = " + StuAge ;
                }
                if (checkBox_sname.Checked == true)
                {
                    if (flag1 == 0)
                    {
                        updatestr += "Sname = '" + StuName + "'";
                        flag1 = 1;
                    }
                    else
                        updatestr += ", Sname = '" + StuName + "'";
                }
                if (checkBox_ssex.Checked == true)
                {
                    if (flag1 == 0)
                    {
                        updatestr += "Ssex = '" + StuSex + "'";
                        flag1 = 1;
                    }
                    else
                        updatestr += ", Ssex = '" + StuSex + "'";
                }//被选中的项取出相应字符串
                updatestr += " WHERE Sno = '" + StuID + "'";
                SqlCommand cmd = new SqlCommand(updatestr, con);
                cmd.ExecuteNonQuery();

                String sql = "insert into SysLog values ( '" + userid + "' , '" + DateTime.Now + "' , '" + "Update Student" + "')";//编写SQL命令
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
            this.studentTableAdapter.Fill(this.schoolDataSet.Student);
            if (flag2 == 0)
            {
                MessageBox.Show("修改成功！", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void button_BACK_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FormUpdate_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
