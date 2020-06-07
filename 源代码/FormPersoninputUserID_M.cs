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
    public partial class FormPersoninputUserID_M : Form
    {
        public FormPersoninputUserID_M()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            try
            {
                
                if (textBox1.Text.Trim() == "")
                {
                    MessageBox.Show("请输入用户名！", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    FormPerson_M formPersonM = new FormPerson_M();
                    formPersonM.label_id.Text = textBox1.Text.Trim(); 
                    formPersonM.Show();
                    this.Hide();
                }
            }
            catch
            {
                MessageBox.Show("出错！", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
