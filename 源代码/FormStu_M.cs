using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 登录
{
    public partial class FormStu_M : Form
    {
        public FormStu_M()
        {
            InitializeComponent();
        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            Formstuinsert_M forminsert = new Formstuinsert_M();
            forminsert.userid = this.userid;
            forminsert.ShowDialog();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            Formstudelete_M form2 = new Formstudelete_M();
            form2.userid = this.userid;
            form2.ShowDialog();
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            FormManager formManager = new FormManager();
            formManager.userid = this.userid;
            formManager.Show();
            this.Close();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            FormUpdate formupdate = new FormUpdate();
            formupdate.userid = this.userid;
            formupdate.ShowDialog();
        }

        private void button_select_Click(object sender, EventArgs e)
        {
            FormSelect formselect = new FormSelect();
            formselect.ShowDialog();
        }
    }
}
