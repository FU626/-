using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 登录
{
    public partial class FormUser_M : Form
    {
        public FormUser_M()
        {
            InitializeComponent();
        }

        private void FormUser_M_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“schoolDataSet1.SysUser”中。您可以根据需要移动或删除它。
            this.sysUserTableAdapter.Fill(this.schoolDataSet1.SysUser);

        }

       

        private void button_insert_Click(object sender, EventArgs e)
        {
            FormUserInsert_M formUserInsert = new FormUserInsert_M();
            formUserInsert.userid = this.userid;
            formUserInsert.ShowDialog();
            this.sysUserTableAdapter.Fill(this.schoolDataSet1.SysUser);
        }

        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=school;Persist Security Info=True;User ID=sa;Password=fucong916626");
        private void button_delete_Click(object sender, EventArgs e)
        {
            int flag = 0;
            try
            {
                con.Open();
                string select_id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//选择的当前行第一列的值，也就是ID
                string delete_by_id = "delete from SysUser where UserID=" + "'" + select_id + "'";//sql删除语句,根据工号删除
                SqlCommand cmd = new SqlCommand(delete_by_id, con);
                cmd.ExecuteNonQuery();  //执行命令

                String sql = "insert into SysLog values ( '" + userid + "' , '" + DateTime.Now + "' , '" + "Delete SysUser" + "')";                                            //编写SQL命令
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
            this.sysUserTableAdapter.Fill(this.schoolDataSet1.SysUser);
            if (flag == 0)
            {
                MessageBox.Show("成功删除！", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
