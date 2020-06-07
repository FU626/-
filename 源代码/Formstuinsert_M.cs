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
    public partial class Formstuinsert_M : Form
    {
        public Formstuinsert_M()
        {
            InitializeComponent();
        }

        private void Forminsert_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“schoolDataSet.Student”中。您可以根据需要移动或删除它。
            this.studentTableAdapter.Fill(this.schoolDataSet.Student);

        }
        SqlConnection con = new SqlConnection(Class1.schoolConnectionString);
        private void button_insert_Click(object sender, EventArgs e)
        {
            String StuID = textBox_sno.Text.Trim();
            String StuName = textBox_sname.Text.Trim();
            String StuSex = textBox_ssex.Text.Trim();
            String StuSdept = textBox_sdept.Text.Trim();
            String StuAge = textBox_sage.Text.Trim();//取出字符串

            int flag = 0;
            try
            {
                con.Open();
                String insertstr = "INSERT INTO  Student (Sno,Sname,Ssex,Sdept,Sage)    " +
                    "VALUES ('" + StuID + "','" + StuName + "','" + StuSex + "','" + StuSdept + "'," + StuAge + ")";
                SqlCommand cmd = new SqlCommand(insertstr, con); //实例化数据库命令对象
                cmd.ExecuteNonQuery(); //执行命令

                String sql = "insert into SysLog values ( '" + userid + "' , '" + DateTime.Now + "' , '" + "Insert Student" + "')";                                            //编写SQL命令
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
                con.Close(); //释放
            }
            this.studentTableAdapter.Fill(this.schoolDataSet.Student);//使其显示更新后的表
            if(flag == 0)
            {
                MessageBox.Show("插入成功！", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void button_BACK_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            textBox_sno.Text = "";
            textBox_sname.Text = "";
            textBox_ssex.Text = "";
            textBox_sdept.Text = "";
            textBox_sage.Text = "";
        }

        private void Forminsert_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
