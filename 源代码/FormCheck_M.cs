using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 登录
{
    public partial class FormCheck_M : Form
    {
        public FormCheck_M()
        {
            InitializeComponent();
        }

        private void FormCheck_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“schoolDataSet6.USER_NUM”中。您可以根据需要移动或删除它。
            this.uSER_NUMTableAdapter.Fill(this.schoolDataSet6.USER_NUM);
            // TODO: 这行代码将数据加载到表“schoolDataSet2.Teacher”中。您可以根据需要移动或删除它。
            this.teacherTableAdapter.Fill(this.schoolDataSet2.Teacher);
            // TODO: 这行代码将数据加载到表“schoolDataSet.SC”中。您可以根据需要移动或删除它。
            this.sCTableAdapter.Fill(this.schoolDataSet.SC);
            // TODO: 这行代码将数据加载到表“schoolDataSet.Course”中。您可以根据需要移动或删除它。
            this.courseTableAdapter.Fill(this.schoolDataSet.Course);
            // TODO: 这行代码将数据加载到表“schoolDataSet1.Student”中。您可以根据需要移动或删除它。
            this.studentTableAdapter.Fill(this.schoolDataSet1.Student);
            // TODO: 这行代码将数据加载到表“schoolDataSet1.SysLog”中。您可以根据需要移动或删除它。
            this.sysLogTableAdapter.Fill(this.schoolDataSet1.SysLog);
            // TODO: 这行代码将数据加载到表“schoolDataSet1.SysUser”中。您可以根据需要移动或删除它。
            this.sysUserTableAdapter.Fill(this.schoolDataSet1.SysUser);

            SqlConnection sqlConnection = new SqlConnection("Data Source=.;Initial Catalog=school;Persist Security Info=True;User ID=sa;Password=fucong916626");
            String select_by = "select * from SysLog order by DateAndTime ASC";
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(select_by, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = sqlDataReader;
            dataGridView1.DataSource = bindingSource;
            sqlConnection.Close();
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            this.sysLogTableAdapter.Fill(this.schoolDataSet1.SysLog);
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connString = "Data Source=.;Initial Catalog=school;Persist Security Info=True;User ID=sa;Password=fucong916626";//数据库连接字符串
                SqlConnection connection = new SqlConnection(connString);//创建connection对象

                //打开数据库连接
                connection.Open();
                //创建SQL语句
                string sql = "select UserPhoto from SysUser where UserID = '" + textBox1.Text + "'";
                //创建SqlCommand对象
                SqlCommand command = new SqlCommand(sql, connection);
                //创建DataAdapter对象
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                //创建DataSet对象
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "SysUser");
                int c = dataSet.Tables["SysUser"].Rows.Count;
                if (c > 0)
                {
                    Byte[] mybyte = new byte[0];
                    mybyte = (Byte[])(dataSet.Tables["SysUser"].Rows[c - 1]["UserPhoto"]);
                    MemoryStream ms = new MemoryStream(mybyte);
                    pictureBox1.Image = Image.FromStream(ms);
                }
                else
                    pictureBox1.Image = null;
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }//加载图片
}
