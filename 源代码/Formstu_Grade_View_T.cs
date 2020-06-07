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
    public partial class Formstu_Grade_View_T : Form
    {
        public Formstu_Grade_View_T()
        {
            InitializeComponent();
        }

        private void Formstu_Grade_View_T_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“schoolDataSet5.AVG_Grade”中。您可以根据需要移动或删除它。
            this.aVG_GradeTableAdapter.Fill(this.schoolDataSet5.AVG_Grade);
            // TODO: 这行代码将数据加载到表“schoolDataSet3.STU_Grade”中。您可以根据需要移动或删除它。
            this.sTU_GradeTableAdapter.Fill(this.schoolDataSet3.STU_Grade);

        }
        SqlConnection con = new SqlConnection(Class1.schoolConnectionString);
        private void button_select_Click(object sender, EventArgs e)
        {
            if(textBox_cno.Text.Trim()== "")
            {
                MessageBox.Show("请输入课程号！", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                String strcno = textBox_cno.Text.Trim();
                String select_by_cno = "select * from STU_Grade where cno = '" + strcno + "'";
                String select_avg_grade = "select * from AVG_Grade where cno = '" + strcno + "'";
                try
                {
                    con.Open();
                    SqlCommand sqlCommand1 = new SqlCommand(select_by_cno, con);
                    SqlDataReader sqlDataReader1 = sqlCommand1.ExecuteReader();
                    BindingSource bindingSource1 = new BindingSource();
                    bindingSource1.DataSource = sqlDataReader1;
                    dataGridView1.DataSource = bindingSource1;
                    sqlDataReader1.Close();
                    SqlCommand sqlCommand2 = new SqlCommand(select_avg_grade, con);
                    SqlDataReader sqlDataReader2 = sqlCommand2.ExecuteReader();
                    BindingSource bindingSource2 = new BindingSource();
                    bindingSource2.DataSource = sqlDataReader2;
                    dataGridView2.DataSource = bindingSource2;
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
}
