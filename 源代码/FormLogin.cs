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
    public partial class Formlogin : Form
    {
        public Formlogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public string code;

        private void Formlogin_Load(object sender, EventArgs e)
        {
            Random ran = new Random();
            int number;
            char code1;
            //取五个数 
            for (int i = 0; i < 5; i++)
            {
                number = ran.Next();//取非负随机数
                if (number % 2 == 0)
                    code1 = (char)('0' + (char)(number % 10));//两个char类型运算会自动转换为int类型的运算
                else
                    code1 = (char)('A' + (char)(number % 26)); //转化为字符 

                this.code += code1.ToString();
            }

            label5.Text = code;
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
            String username = textBox2.Text.Trim(); //取出用户名
            String password = EncryptWithMD5(textBox1.Text.Trim()); //取出密码,加密
            String Identity = comboBox_identity.Text.Trim(); //取出身份

           
            String myConnString = Class1.schoolConnectionString;
            //创建数据库连接对象并实例化
            SqlConnection sqlConnection = new SqlConnection(myConnString);
            sqlConnection.Open();//打开数据库

            String sql = "select UserID,UserPassword,UserIdentity from SysUser where UserID = '" + username + "' and UserPassword = '" + password + "'" + " and UserIdentity = '" + Identity + "'";//SQL查询语句
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);//初始化SQL命令对象
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader(); //执行命令并取出结果

            if (sqlDataReader.HasRows) //查询结果存在
            {
                if (textBox3.Text == code)//验证码正确
                {
                    MessageBox.Show("登录成功！", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);//设置弹出对话窗
                    if(Identity == "Student")
                    {
                        FormStudent formStudent = new FormStudent();
                        formStudent.label_userid.Text = username;
                        formStudent.Show();
                        this.Hide();
                    }
                    else if(Identity == "Administrator")
                    {
                        FormManager formManager = new FormManager();
                        formManager.userid = username;
                        formManager.Show();
                        this.Hide();
                    }
                    else
                    {
                        FormTeacher formTeacher = new FormTeacher();
                        formTeacher.label_userid.Text = username;
                        formTeacher.Show();
                        this.Hide();
                    }//据不同身份，显示不同窗口
                }
                else
                {
                    MessageBox.Show("验证码错误！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("用户名或密码错误！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            sqlDataReader.Close();
            sql = "insert into SysLog values ( '" + username + "' , '" + DateTime.Now + "' , '" + "Login" + "')";                                            //编写SQL命令
            sqlCommand = new SqlCommand(sql, sqlConnection);//记录日志（登录部分）
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();//关闭数据库连接
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegister formregister = new FormRegister();
            formregister.ShowDialog();
        }

        private void Formlogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Random ran = new Random();
            int number;
            char code1;
            this.code = "";
            //取五个数 
            for (int i = 0; i < 5; i++)
            {
                number = ran.Next();//取非负随机数
                if (number % 2 == 0)
                    code1 = (char)('0' + (char)(number % 10));//两个char类型运算会自动转换为int类型的运算
                else
                    code1 = (char)('A' + (char)(number % 26)); //转化为字符 

                this.code += code1.ToString();
            }

            label5.Text = code;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormLogin_Alter_password formLogin_Alter_Password = new FormLogin_Alter_password();
            formLogin_Alter_Password.ShowDialog();
        }
    }
}
