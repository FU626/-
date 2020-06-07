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
    public partial class Formstudelete_M : Form
    {
        public Formstudelete_M()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“schoolDataSet.Student”中。您可以根据需要移动或删除它。
            this.studentTableAdapter.Fill(this.schoolDataSet.Student);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    

        SqlConnection con = new SqlConnection(Class1.schoolConnectionString);
       
        private void button_delete_Click(object sender, EventArgs e)
        {
            int flag = 0;
            try
            {
               
                con.Open();
                string select_id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//选择的当前行第一列的值，也就是ID
                string delete_by_id = "delete from Student where Sno=" + "'"+select_id+"'";//sql删除语句,根据学号删除
                SqlCommand cmd = new SqlCommand(delete_by_id, con);
                cmd.ExecuteNonQuery();  //执行命令

                String sql = "insert into SysLog values ( '" + userid + "' , '" + DateTime.Now + "' , '" + "Delete Student" + "')";                                            //编写SQL命令
                SqlCommand sqlCommand = new SqlCommand(sql, con);//记录日志
                sqlCommand.ExecuteNonQuery();
            }
            catch
            {
                flag = 1;
                MessageBox.Show("请正确选择行!","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            this.studentTableAdapter.Fill(this.schoolDataSet.Student);//使其显示更新后的表
            if(flag == 0)
            {
                MessageBox.Show("成功删除！", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void button_BACK_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Formdelete_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
