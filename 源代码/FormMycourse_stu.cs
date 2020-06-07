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
    public partial class FormMycourse_stu : Form
    {
        public FormMycourse_stu()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=school;Persist Security Info=True;User ID=sa;Password=fucong916626");
        private void FormMycourse_stu_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“schoolDataSet1.Course”中。您可以根据需要移动或删除它。
            this.courseTableAdapter.Fill(this.schoolDataSet1.Course);
            String Strsno = label2.Text.Trim();
            try
            {
                con.Open();
                String select_by_sno = "Select Course.Cno,Cname,Cpno,Ccredit from Course,SC where SC.Cno = Course.Cno AND SC.Sno = '" + Strsno + "'";
                SqlCommand cmd = new SqlCommand(select_by_sno, con);
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = sqlDataReader;
                dataGridView1.DataSource = bindingSource;
            }
            catch
            {
                MessageBox.Show("ERROR!");
            }
            finally
            {
                con.Close();
            }
        }
        
       
       
    }
}
