namespace 登录
{
    partial class FormStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_personal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_course = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button_grade = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button_select = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button_exit = new System.Windows.Forms.Button();
            this.textBox_sno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_userid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_personal
            // 
            this.button_personal.BackColor = System.Drawing.Color.FloralWhite;
            this.button_personal.Font = new System.Drawing.Font("Kristen ITC", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_personal.ForeColor = System.Drawing.Color.DarkCyan;
            this.button_personal.Location = new System.Drawing.Point(233, 104);
            this.button_personal.Name = "button_personal";
            this.button_personal.Size = new System.Drawing.Size(140, 78);
            this.button_personal.TabIndex = 0;
            this.button_personal.Text = "Personal Info";
            this.button_personal.UseVisualStyleBackColor = false;
            this.button_personal.Click += new System.EventHandler(this.button_personal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FloralWhite;
            this.label1.Location = new System.Drawing.Point(84, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "个人信息→";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.FloralWhite;
            this.label2.Location = new System.Drawing.Point(84, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "我的课表→";
            // 
            // button_course
            // 
            this.button_course.BackColor = System.Drawing.Color.FloralWhite;
            this.button_course.Font = new System.Drawing.Font("Kristen ITC", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_course.ForeColor = System.Drawing.Color.DarkCyan;
            this.button_course.Location = new System.Drawing.Point(233, 205);
            this.button_course.Name = "button_course";
            this.button_course.Size = new System.Drawing.Size(140, 78);
            this.button_course.TabIndex = 2;
            this.button_course.Text = "My Courses";
            this.button_course.UseVisualStyleBackColor = false;
            this.button_course.Click += new System.EventHandler(this.button_course_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.FloralWhite;
            this.label3.Location = new System.Drawing.Point(84, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "我的成绩→";
            // 
            // button_grade
            // 
            this.button_grade.BackColor = System.Drawing.Color.FloralWhite;
            this.button_grade.Font = new System.Drawing.Font("Kristen ITC", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_grade.ForeColor = System.Drawing.Color.DarkCyan;
            this.button_grade.Location = new System.Drawing.Point(233, 308);
            this.button_grade.Name = "button_grade";
            this.button_grade.Size = new System.Drawing.Size(140, 66);
            this.button_grade.TabIndex = 4;
            this.button_grade.Text = "My Grade";
            this.button_grade.UseVisualStyleBackColor = false;
            this.button_grade.Click += new System.EventHandler(this.button_grade_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.FloralWhite;
            this.label4.Location = new System.Drawing.Point(628, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "←选课/退课";
            // 
            // button_select
            // 
            this.button_select.BackColor = System.Drawing.Color.FloralWhite;
            this.button_select.Font = new System.Drawing.Font("Kristen ITC", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_select.ForeColor = System.Drawing.Color.DarkCyan;
            this.button_select.Location = new System.Drawing.Point(440, 143);
            this.button_select.Name = "button_select";
            this.button_select.Size = new System.Drawing.Size(165, 78);
            this.button_select.TabIndex = 6;
            this.button_select.Text = "Select/Quit Courses";
            this.button_select.UseVisualStyleBackColor = false;
            this.button_select.Click += new System.EventHandler(this.button_select_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.FloralWhite;
            this.label5.Location = new System.Drawing.Point(628, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "←退出登录";
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.FloralWhite;
            this.button_exit.Font = new System.Drawing.Font("Kristen ITC", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_exit.ForeColor = System.Drawing.Color.DarkCyan;
            this.button_exit.Location = new System.Drawing.Point(440, 249);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(165, 78);
            this.button_exit.TabIndex = 8;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // textBox_sno
            // 
            this.textBox_sno.Enabled = false;
            this.textBox_sno.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_sno.Location = new System.Drawing.Point(481, 29);
            this.textBox_sno.Name = "textBox_sno";
            this.textBox_sno.Size = new System.Drawing.Size(142, 40);
            this.textBox_sno.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.FloralWhite;
            this.label6.Location = new System.Drawing.Point(369, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "学号：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.FloralWhite;
            this.label7.Location = new System.Drawing.Point(133, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "用户：";
            // 
            // label_userid
            // 
            this.label_userid.AutoSize = true;
            this.label_userid.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold);
            this.label_userid.ForeColor = System.Drawing.Color.FloralWhite;
            this.label_userid.Location = new System.Drawing.Point(218, 39);
            this.label_userid.Name = "label_userid";
            this.label_userid.Size = new System.Drawing.Size(90, 33);
            this.label_userid.TabIndex = 14;
            this.label_userid.Text = "用户名";
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_userid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_sno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_select);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_grade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_course);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_personal);
            this.Name = "FormStudent";
            this.Text = "FormStudent";
            this.Load += new System.EventHandler(this.FormStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_personal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_course;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_grade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_select;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.TextBox textBox_sno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label_userid;
    }
}