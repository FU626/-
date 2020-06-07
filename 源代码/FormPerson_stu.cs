using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 登录
{
    public partial class FormPerson_stu : Form
    {
        public FormPerson_stu()
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
        private void FormPerson_stu_Load(object sender, EventArgs e)
        { 
            String snostr = label_Sno.Text.Trim();
            try
            {
                con.Open();

                String sql = "Select * from SysUser where UserSchoolID = '" + snostr + "'";
                SqlCommand sqlCommand1 = new SqlCommand(sql, con);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand1);
                //创建DataSet对象
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "SysUser");
                dateTimePicker1.Value = (DateTime)dataSet.Tables["SysUser"].Rows[0]["UserBirthday"];
                textBox_mobile.Text = (string)dataSet.Tables["SysUser"].Rows[0]["UserMobile"];
                label_id.Text = (string)dataSet.Tables["SysUser"].Rows[0]["UserID"];

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

                String sql_T = "select * from Student where Sno = '" + label_Sno.Text.Trim() + "'";
                SqlCommand sqlCommand2 = new SqlCommand(sql_T, con);
                SqlDataAdapter dataAdapter2 = new SqlDataAdapter(sqlCommand2);
                //创建DataSet对象
                DataSet dataSet2 = new DataSet();
                dataAdapter2.Fill(dataSet2, "Student");
                textBox_sname.Text = (string)dataSet2.Tables["Student"].Rows[0]["Sname"];
                comboBox_sex.Text = (string)dataSet2.Tables["Student"].Rows[0]["Ssex"];
                label_sdept.Text = (string)dataSet2.Tables["Student"].Rows[0]["Sdept"];
                label_sage.Text = dataSet2.Tables["Student"].Rows[0]["Sage"].ToString();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!" + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            
            String password = textBox_password.Text.Trim();
            DateTime birthday = dateTimePicker1.Value;
            String Mobile = textBox_mobile.Text.Trim();
            String sname = textBox_sname.Text.Trim();
            String ssex = comboBox_sex.Text.Trim();
            String sno = label_Sno.Text.Trim();
            try
            {
                con.Open();
                String sql1 = "";
                SqlCommand sqlCommand1 = new SqlCommand(sql1, con);
                SqlParameter sqlParameter = new SqlParameter();
                if (password == "*****")//密码未修改
                {
                    sql1 = "update SysUser set UserBirthday = @Birthday,UserMobile = @Mobile where Userschoolid = @sno";//根据学号查询
                    sqlCommand1.CommandText = sql1;
                }
                else//密码修改
                {
                    sql1 = "update SysUser set UserPassword = @password, UserBirthday = @Birthday,UserMobile = @Mobile where Userschoolid = @sno";
                    sqlCommand1.CommandText = sql1;
                    sqlParameter = new SqlParameter("@password", EncryptWithMD5(password));//加密后再保存
                    sqlCommand1.Parameters.Add(sqlParameter);
                }
                sqlParameter = new SqlParameter("@Birthday", birthday);
                sqlCommand1.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@Mobile", Mobile);
                sqlCommand1.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@sno", sno);
                sqlCommand1.Parameters.Add(sqlParameter);
                sqlCommand1.ExecuteNonQuery();

                String sql2 = "update Student set Sname = @sname, Ssex = @ssex where Sno = @sno";
                SqlCommand sqlCommand2 = new SqlCommand(sql2, con);
                sqlParameter = new SqlParameter("@sname", sname);
                sqlCommand2.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@ssex", ssex);
                sqlCommand2.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@sno", sno);
                sqlCommand2.Parameters.Add(sqlParameter);
                sqlCommand2.ExecuteNonQuery();
                MessageBox.Show("保存成功！", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!" + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
