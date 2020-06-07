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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 登录
{
    public partial class FormUserInsert_M : Form
    {
        public FormUserInsert_M()
        {
            InitializeComponent();
        }

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

        private void buttonclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Byte[] mybyte = new byte[0];

        private void button_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();//打开浏览图片对话框
            string picturePath = openFileDialog.FileName;//获取图片路径
            //文件的名称，每次必须更换图片的名称，这里很为不便
            //创建FileStream对象
            FileStream fs = new FileStream(picturePath, FileMode.Open, FileAccess.Read);
            //声明Byte数组
            mybyte = new byte[fs.Length];
            //读取数据
            fs.Read(mybyte, 0, mybyte.Length);//offset -- 偏移量开始存储字符的位置,mybyte为缓冲区
            DialogResult result = MessageBox.Show("一旦上传，照片将不能更改，确定上传么？", "Tips", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);//取出按钮结果
            if (result == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromStream(fs);//从fs数据流创建图像
            }
            fs.Close();
        }
        string connString = Class1.schoolConnectionString;//数据库连接字符串
        private void button_OK_Click(object sender, EventArgs e)
        {
            int flag = 0;//0表示身份是STUDENT，1表示身份是Teacher
            try
            {
                SqlConnection connection = new SqlConnection(connString);//创建connection对象
                connection.Open(); //打开数据库连接
                if (comboBox_identity.Text != "Administrator")//不是管理员的时候要对schoolid做处理
                {
                    string sql1 = "";
                    if (comboBox_identity.Text == "Student")//schoolid要对应Sno,Sno存在，则注册成功
                    {
                        sql1 = "select Sno from Student where Sno = '" + textBox_schoolid.Text.Trim() + "'";
                    }
                    else if (comboBox_identity.Text == "Teacher")//教师schoolid对应tno
                    {
                        flag = 1;
                        sql1 = "select Tno from Teacher where Tno = '" + textBox_schoolid.Text.Trim() + "'";
                    }
                    SqlCommand sqlCommand = new SqlCommand(sql1, connection);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    if (sqlDataReader.HasRows)
                    {
                        sqlDataReader.Close();
                        string sql = "insert into SysUser (UserID,   UserPassWord ,   UserSchoolID, UserMobile, UserBirthday , UserIdentity , UserPhoto ) " +
                                                        "values (@userid, @userpassword,@userschoolid,@usermobile,@userbirthday,@useridentity,@userphoto)";
                        SqlCommand command = new SqlCommand(sql, connection);

                        SqlParameter sqlParameter = new SqlParameter("@userid", textBox_userid.Text.Trim());
                        command.Parameters.Add(sqlParameter);
                        sqlParameter = new SqlParameter("@userpassword", EncryptWithMD5(textBox_password.Text.Trim()));//加密后再保存
                        command.Parameters.Add(sqlParameter);
                        sqlParameter = new SqlParameter("@userschoolid", textBox_schoolid.Text.Trim());
                        command.Parameters.Add(sqlParameter);
                        sqlParameter = new SqlParameter("@usermobile", textBox_mobile.Text.Trim());
                        command.Parameters.Add(sqlParameter);
                        sqlParameter = new SqlParameter("@userbirthday", dateTimePicker1.Value);
                        command.Parameters.Add(sqlParameter);
                        sqlParameter = new SqlParameter("@useridentity", comboBox_identity.Text.Trim());
                        command.Parameters.Add(sqlParameter);
                        sqlParameter = new SqlParameter("@userphoto", SqlDbType.VarBinary, mybyte.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, mybyte);
                        command.Parameters.Add(sqlParameter);
                        command.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("注册成功！");
                        this.Close();//关闭该窗口
                        sqlDataReader.Close();

                        sql = "insert into SysLog values ( '" + userid + "' , '" + DateTime.Now + "' , '" + "Insert SysUser" + "')";                                            //编写SQL命令
                        sqlCommand = new SqlCommand(sql, connection);//记录日志
                        sqlCommand.ExecuteNonQuery();
                    }
                    else//没有找到Tno或Sno
                    {
                        if (flag == 1)//教师身份，提醒schoolid错误,应输入正确的工号Tno
                        {
                            MessageBox.Show("请在SchoolID处输入正确的工号Tno", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else//学生身份，提醒schoolid错误,应输入正确的学号Sno
                        {
                            MessageBox.Show("请在SchoolID处输入正确的学号Sno", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        textBox_schoolid.Focus();
                    }
                }
                else//身份是管理员，直接注册
                {
                    string sql = "insert into SysUser (UserID,   UserPassWord ,   UserSchoolID, UserMobile, UserBirthday , UserIdentity , UserPhoto ) " +
                                                        "values (@userid, @userpassword,@userschoolid,@usermobile,@userbirthday,@useridentity,@userphoto)";
                    SqlCommand command = new SqlCommand(sql, connection);

                    SqlParameter sqlParameter = new SqlParameter("@userid", textBox_userid.Text.Trim());
                    command.Parameters.Add(sqlParameter);
                    sqlParameter = new SqlParameter("@userpassword", EncryptWithMD5(textBox_password.Text.Trim()));//加密后再保存
                    command.Parameters.Add(sqlParameter);
                    sqlParameter = new SqlParameter("@userschoolid", textBox_schoolid.Text.Trim());
                    command.Parameters.Add(sqlParameter);
                    sqlParameter = new SqlParameter("@usermobile", textBox_mobile.Text.Trim());
                    command.Parameters.Add(sqlParameter);
                    sqlParameter = new SqlParameter("@userbirthday", dateTimePicker1.Value);
                    command.Parameters.Add(sqlParameter);
                    sqlParameter = new SqlParameter("@useridentity", comboBox_identity.Text.Trim());
                    command.Parameters.Add(sqlParameter);
                    sqlParameter = new SqlParameter("@userphoto", SqlDbType.VarBinary, mybyte.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, mybyte);
                    command.Parameters.Add(sqlParameter);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("注册成功！");
                    this.Close();//关闭该窗口
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox_userid_Leave(object sender, EventArgs e)
        {
            if (textBox_userid.Text.Trim() != "")
            {
                //使用regex（正则表达式）进行格式设置 至少有数字、大写字母、小写字母各一个。最少3个字符、最长20个字符。
                Regex regex = new Regex(@"(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z]).{3,20}");

                if (regex.IsMatch(textBox_userid.Text))//判断格式是否符合要求
                {
                    //MessageBox.Show("输入密码格式正确!");
                }
                else
                {
                    MessageBox.Show("至少有数字、大写字母、小写字母各一个。最少3个字符、最长20个字符！", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox_userid.Focus();//设置输入焦点
                }
            }
            else
            {
                MessageBox.Show("请填写UserID！", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Warning);//不能为空
            }
        }

        private void textBox_password_Leave(object sender, EventArgs e)
        {
            if (textBox_password.Text.Trim() != "")
            {
                //使用regex（正则表达式）进行格式设置
                Regex regex = new Regex(@"(?=.*[0-9])(?=.*[a-z]).{6,20}");

                if (regex.IsMatch(textBox_password.Text))//判断格式是否符合要求
                {
                    //MessageBox.Show("输入密码格式正确!");
                }
                else
                {
                    MessageBox.Show("必须有数字和字母。最少6个字符、最长20个字符！", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox_password.Focus();//设置输入焦点
                }
            }
            else
            {
                MessageBox.Show("请填写Password！", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Warning);//不能为空
            }
        }

        private void textBox_mobile_Leave(object sender, EventArgs e)
        {
            if (textBox_mobile.Text.Trim() != "")
            {
                //使用regex（正则表达式）进行格式设置 
                Regex regex = new Regex(@"(?=.*[0-9]).{8,11}");

                if (regex.IsMatch(textBox_mobile.Text))//判断格式是否符合要求
                {
                    //MessageBox.Show("输入密码格式正确!");
                }
                else
                {
                    MessageBox.Show("最少8个字符、最长11个字符！", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox_mobile.Focus();//设置输入焦点
                }
            }
            else
            {
                MessageBox.Show("请填写Mobile！", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Warning);//不能为空
            }
        }
    }
}
