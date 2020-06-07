using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 登录
{
    public partial class Formperson_alter_M : Form
    {
        public Formperson_alter_M()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(Class1.schoolConnectionString);
        public static string EncryptWithMD5(string source)
        {
            byte[] sor = Encoding.UTF8.GetBytes(source);
            MD5 md5 = MD5.Create();
            byte[] result = md5.ComputeHash(sor);
            StringBuilder strbul = new StringBuilder(40);
            for (int i = 0; i < result.Length; i++)
            {
                strbul.Append(result[i].ToString("x2"));//加密结果"x2"结果为32位,"x3"结果为48位,"x4"结果为64位
            }
            return strbul.ToString();
        }
        private void button_OK_Click(object sender, EventArgs e)
        {
            String userid = label_userid.Text.Trim();
            String password = textBox_password.Text.Trim();
            DateTime birthday = dateTimePicker1.Value;
            String Mobile = textBox_mobile.Text.Trim();
            String Schoolid = textBox_schoolid.Text.Trim();

            try
            {
                con.Open();
                String sql1 = "";
                SqlParameter sqlParameter = new SqlParameter();
                SqlCommand sqlCommand1 = new SqlCommand(sql1, con);
                if (textBox_password.Text.Trim() == "your password")
                {
                    sql1 = "update SysUser set UserBirthday = @Birthday,UserMobile = @Mobile,UserSchoolID = @schoolid where userid = @userid";
                    sqlCommand1.CommandText = sql1;
                }
                else
                {
                    sql1 = "update SysUser set UserPassword = @password, UserBirthday = @Birthday,UserMobile = @Mobile,UserSchoolID = @schoolid where userid = @userid";
                    sqlCommand1.CommandText = sql1;
                    sqlParameter = new SqlParameter("@password", EncryptWithMD5(password));//加密后再保存
                    sqlCommand1.Parameters.Add(sqlParameter);
                }
                sqlParameter = new SqlParameter("@userid", userid);
                sqlCommand1.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@Birthday", birthday);
                sqlCommand1.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@Mobile", Mobile);
                sqlCommand1.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@schoolid", Schoolid);
                sqlCommand1.Parameters.Add(sqlParameter);
                sqlCommand1.ExecuteNonQuery();
                MessageBox.Show("修改成功！", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR!" + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormpersonM2_Load(object sender, EventArgs e)
        {

        }
    }
}
