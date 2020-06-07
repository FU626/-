using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 登录
{
    
    public partial class FormPerson_M : Form
    {

        public FormPerson_M()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(Class1.schoolConnectionString);
        private void FormPersonM_Load(object sender, EventArgs e)
        {
            
            String id = label_id.Text.Trim();
            
            try
            {
                con.Open();
                string sql = "SELECT * FROM SysUser WHERE UserID = '"+id + "'";
                
                SqlCommand command = new SqlCommand(sql, con);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                //创建DataSet对象
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "SysUser");
                int c = dataSet.Tables["SysUser"].Rows.Count;

                if (c > 0)
                {
                    label_schoolid.Text = (string)dataSet.Tables["SysUser"].Rows[0]["UserSchoolID"];
                    label_mobile.Text = (string)dataSet.Tables["SysUser"].Rows[0]["UserMobile"];
                    label_birth.Text = dataSet.Tables["SysUser"].Rows[0]["UserBirthday"].ToString();

                    Byte[] mybyte = new byte[0];
                    mybyte = (Byte[])(dataSet.Tables["SysUser"].Rows[c - 1]["UserPhoto"]);
                    MemoryStream ms = new MemoryStream(mybyte);
                    pictureBox1.Image = Image.FromStream(ms);

                }
                else
                {
                    pictureBox1.Image = null;
                    con.Close();
                    MessageBox.Show("该用户不存在，请返回输入正确的用户名！", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    FormPersoninputUserID_M formPersonUserID = new FormPersoninputUserID_M();
                    formPersonUserID.Show();
                    this.Close();
                }
                    //以上为读取个人信息
                }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                label_id.Text = "出错！";
            }
            finally
            {
                con.Close();
            }
        }

        private void button_修改_Click(object sender, EventArgs e)
        {
            Formperson_alter_M formpersonM2 = new Formperson_alter_M();
            formpersonM2.label_userid.Text = label_id.Text.Trim();
            formpersonM2.textBox_mobile.Text = label_mobile.Text.Trim();
            formpersonM2.textBox_schoolid.Text = label_schoolid.Text.Trim();
            
            String id = label_id.Text.Trim();

            try
            {
                con.Open();
                string sql = "SELECT * FROM SysUser WHERE UserID = '" + id + "'";

                SqlCommand command = new SqlCommand(sql, con);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                //创建DataSet对象
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "SysUser");
                formpersonM2.dateTimePicker1.Value = (DateTime)dataSet.Tables["SysUser"].Rows[0]["UserBirthday"];
            }
            catch
            {
                MessageBox.Show("ERROR!");
            }
            con.Close();
            formpersonM2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormManager formManager = new FormManager();
            formManager.Show();
            this.Hide();
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Class1.schoolConnectionString);
            String id = label_id.Text.Trim();

            try
            {
                con.Open();
                string sql = "SELECT * FROM SysUser WHERE UserID = '" + id + "'";

                SqlCommand command = new SqlCommand(sql, con);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                //创建DataSet对象
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "SysUser");
                int c = dataSet.Tables["SysUser"].Rows.Count;

                if (c > 0)
                {
                    label_schoolid.Text = (string)dataSet.Tables["SysUser"].Rows[0]["UserSchoolID"];
                    label_mobile.Text = (string)dataSet.Tables["SysUser"].Rows[0]["UserMobile"];
                    label_birth.Text = dataSet.Tables["SysUser"].Rows[0]["UserBirthday"].ToString();

                }
                else
                {
                    con.Close();
                    this.Close();
                }
                //以上为读取个人信息
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                label_id.Text = "出错！";
            }
            finally
            {
                con.Close();
            }
        }
    }
}
