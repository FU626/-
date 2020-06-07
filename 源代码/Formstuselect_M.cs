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
    public partial class FormSelect : Form
    {
        public FormSelect()
        {
            InitializeComponent();
        }

        private void FormSelect_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“schoolDataSet.Student”中。您可以根据需要移动或删除它。
            this.studentTableAdapter.Fill(this.schoolDataSet.Student);

        }
        
        SqlConnection con = new SqlConnection(Class1.schoolConnectionString);
        private void buttonall_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String select_by_id = "select * from Student";
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

        private void button_select_Click(object sender, EventArgs e)
        {
            String StuID = textBox_sno.Text.Trim();
            String StuName = textBox_sname.Text.Trim();
            String StuSex = textBox_ssex.Text.Trim();
            String StuSdept = textBox_sdept.Text.Trim();
            String StuAge = textBox_sage.Text.Trim();//取出字符串

            try
            {
                con.Open();
                String select_by_id = "select * from Student where ";
                int flag1 = 0;       //表示前面是否已经加了筛选条件,为1，则后面的条件需要加AND       
                if (checkBox_sno.Checked == true)
                {
                    if(flag1 == 0)
                    {
                        select_by_id += "(Sno='" + StuID + "' OR Sno LIKE '" + StuID +"%')";
                        flag1 = 1;
                    }
                    else
                    {
                        select_by_id += "AND (Sno='" + StuID + "' OR Sno LIKE '" + StuID + "%')";
                    }
                }
                if(checkBox_sname.Checked == true)
                {
                    if (flag1 == 0)
                    {
                        select_by_id += "(Sname='" + StuName + "' OR Sname LIKE '" + StuName + "%')";
                        flag1 = 1;
                    }
                    else
                    {
                        select_by_id += "AND (Sname='" + StuName + "' OR Sname LIKE '" + StuName + "%')";
                    }
                }
                if(checkBox_ssex.Checked == true)
                {
                    if (flag1 == 0)
                    {
                        select_by_id += "Ssex='" + StuSex + "'";
                        flag1 = 1;
                    }
                    else
                    {
                        select_by_id += "AND Ssex='" + StuSex + "'";
                    }
                }
                if(checkBox_sdept.Checked == true)
                {
                    if (flag1 == 0)
                    {
                        select_by_id += "Sdept='" + StuSdept + "'";
                        flag1 = 1;
                    }
                    else
                    {
                        select_by_id += "AND Sdept='" + StuSdept + "'";
                    }
                }
                if(checkBox_sage.Checked == true)
                {
                    if (flag1 == 0)
                    {
                        select_by_id += "Sage=" + StuAge ;
                        flag1 = 1;
                    }
                    else
                    {
                        select_by_id += "AND Sage=" + StuAge;
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
        }

       
        private void button_BACK_Click(object sender, EventArgs e)
        {
            this.Hide();//隐藏登录的界面
        }

        private void FormSelect_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
