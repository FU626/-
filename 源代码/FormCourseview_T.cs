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
    public partial class FormCourseview_T : Form
    {
        public FormCourseview_T()
        {
            InitializeComponent();
        }

        private void FormCourseview_T_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“schoolDataSet4.T_C_NUM”中。您可以根据需要移动或删除它。
            this.t_C_NUMTableAdapter.Fill(this.schoolDataSet4.T_C_NUM);

        }
        SqlConnection con = new SqlConnection(Class1.schoolConnectionString);
        private void button_mycourses_Click(object sender, EventArgs e)
        {
            String strtno = textBox_Tno.Text.Trim();
            String select_by_tno = "SELECT * FROM T_C_NUM WHERE Tno = '" + strtno + "'";
            try
            {
                con.Open();
                SqlCommand sqlCommand = new SqlCommand(select_by_tno, con);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.HasRows)
                {
                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = sqlDataReader;
                    dataGridView1.DataSource = bindingSource;
                }
                else
                {
                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = sqlDataReader;
                    dataGridView1.DataSource = bindingSource;
                    MessageBox.Show("您目前没有授课或者您所教授的课目前没有学生选择！", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
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

        private void buttonall_Click(object sender, EventArgs e)
        {
            String select_by_tno = "SELECT * FROM T_C_NUM";
            try
            {
                con.Open();
                SqlCommand sqlCommand = new SqlCommand(select_by_tno, con);
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
