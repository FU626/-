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
    public partial class FormLogin_Alter_password : Form
    {
        public FormLogin_Alter_password()
        {
            InitializeComponent();
        }

        public static string EncryptWithMD5(string source)
        {
            //MD5加密，source为要加密的字符串
            byte[] sor = Encoding.UTF8.GetBytes(source);//将字符串编码为一个字符序列
            MD5 md5 = MD5.Create();
            byte[] result = md5.ComputeHash(sor);//计算指定字节数组的哈希值
            StringBuilder strbul = new StringBuilder(40);//可变字符字符串
            for (int i = 0; i < result.Length; i++)
            {
                strbul.Append(result[i].ToString("x2"));//加密结果"x2"结果为32位,"x3"结果为48位,"x4"结果为64位
                //向strbul字符串后追加
            }
            return strbul.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            String username = textBox_id.Text.Trim(); //取出用户名
            String password1 = textBox_password1.Text.Trim(); //取出新密码
            String password2 = textBox_password2.Text.Trim();
            String Mobilestr = textBox_phone.Text.Trim(); //取出手机号

            String myConnString = "Data Source=.;Initial Catalog=school;Persist Security Info=True;User ID=sa;Password=fucong916626";
            //创建数据库连接对象并实例化
            SqlConnection sqlConnection = new SqlConnection(myConnString);
            try
            {

                sqlConnection.Open();//打开数据库

                String sql = "select UserID,UserMobile from SysUser where UserID = '" + username + "' and UserMobile = '" + Mobilestr + "'";//SQL查询语句
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);//初始化SQL命令对象
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader(); //执行命令并取出结果
                if (sqlDataReader.HasRows)
                {
                    if (password1 == password2)
                    {
                        sqlDataReader.Close();
                        String updatestr = "Update SysUser SET UserPassword = '" + EncryptWithMD5(password1) + "' where userID = '" + username + "'and UserMobile = '" + Mobilestr + "'";
                        SqlCommand sqlCommand2 = new SqlCommand(updatestr, sqlConnection);//初始化SQL命令对象
                        sqlCommand2.ExecuteReader();
                        MessageBox.Show("修改密码成功！", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("请保证确认密码处和新密码一致！", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("请输入正确的用户名和手机号！", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR!" + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
