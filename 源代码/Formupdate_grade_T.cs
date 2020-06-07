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
    public partial class Formupdate_grade_T : Form
    {
        public Formupdate_grade_T()
        {
            InitializeComponent();
        }

        private void Formupdate_grade_T_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“schoolDataSet1.SC”中。您可以根据需要移动或删除它。
            this.sCTableAdapter.Fill(this.schoolDataSet1.SC);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int flag = 0;//判断是否修改或录入成功
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=school;Persist Security Info=True;User ID=sa;Password=fucong916626");
            String strsno = textBox_sno.Text.Trim();
            String strcno = textBox_cno.Text.Trim();
            String Grade = textBox_grade.Text.Trim();
            String stralter = "update SC set grade = " + Grade + " where sno = '" + strsno + "' and cno = '" + strcno + "'";
            try
            {
                con.Open();
                SqlCommand sqlCommand = new SqlCommand(stralter, con);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                sqlDataReader.Close();

                String sql = "insert into SysLog values ( '" + userid + "' , '" + DateTime.Now + "' , '" + "Update SC Grade" + "')";                                            //编写SQL命令
                sqlCommand = new SqlCommand(sql, con);//记录日志
                sqlCommand.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                flag = 1;
                MessageBox.Show("ERROR！" + ex.Message);
            }
            finally
            {
                con.Close();
            }
            this.sCTableAdapter.Fill(this.schoolDataSet1.SC);
            if (flag == 0)//表示修改成功
            {
                MessageBox.Show("成绩录入成功！", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_cno.Text = "";
            textBox_grade.Text = "";
            textBox_sno.Text = "";
        }
    }
}
