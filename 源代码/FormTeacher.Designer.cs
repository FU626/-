namespace 登录
{
    partial class FormTeacher
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
            this.label5 = new System.Windows.Forms.Label();
            this.button_exit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button_course = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button_stu_grade_input = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button_stu_grade_view = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_personal = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label_userid = new System.Windows.Forms.Label();
            this.label_tno = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.FloralWhite;
            this.label5.Location = new System.Drawing.Point(668, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 21);
            this.label5.TabIndex = 19;
            this.label5.Text = "←退出登录";
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.FloralWhite;
            this.button_exit.Font = new System.Drawing.Font("Kristen ITC", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_exit.ForeColor = System.Drawing.Color.DarkCyan;
            this.button_exit.Location = new System.Drawing.Point(480, 280);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(165, 78);
            this.button_exit.TabIndex = 18;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.FloralWhite;
            this.label4.Location = new System.Drawing.Point(668, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "←课程信息查看";
            // 
            // button_course
            // 
            this.button_course.BackColor = System.Drawing.Color.FloralWhite;
            this.button_course.Font = new System.Drawing.Font("Kristen ITC", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_course.ForeColor = System.Drawing.Color.DarkCyan;
            this.button_course.Location = new System.Drawing.Point(480, 174);
            this.button_course.Name = "button_course";
            this.button_course.Size = new System.Drawing.Size(165, 78);
            this.button_course.TabIndex = 16;
            this.button_course.Text = "Courses Info View";
            this.button_course.UseVisualStyleBackColor = false;
            this.button_course.Click += new System.EventHandler(this.button_course_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.FloralWhite;
            this.label3.Location = new System.Drawing.Point(61, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "录入学生成绩→";
            // 
            // button_stu_grade_input
            // 
            this.button_stu_grade_input.BackColor = System.Drawing.Color.FloralWhite;
            this.button_stu_grade_input.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_stu_grade_input.ForeColor = System.Drawing.Color.DarkCyan;
            this.button_stu_grade_input.Location = new System.Drawing.Point(247, 327);
            this.button_stu_grade_input.Name = "button_stu_grade_input";
            this.button_stu_grade_input.Size = new System.Drawing.Size(190, 87);
            this.button_stu_grade_input.TabIndex = 14;
            this.button_stu_grade_input.Text = "Input Student Grade";
            this.button_stu_grade_input.UseVisualStyleBackColor = false;
            this.button_stu_grade_input.Click += new System.EventHandler(this.button_stu_grade_input_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.FloralWhite;
            this.label2.Location = new System.Drawing.Point(61, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "学生成绩查看→";
            // 
            // button_stu_grade_view
            // 
            this.button_stu_grade_view.BackColor = System.Drawing.Color.FloralWhite;
            this.button_stu_grade_view.Font = new System.Drawing.Font("Kristen ITC", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_stu_grade_view.ForeColor = System.Drawing.Color.DarkCyan;
            this.button_stu_grade_view.Location = new System.Drawing.Point(247, 222);
            this.button_stu_grade_view.Name = "button_stu_grade_view";
            this.button_stu_grade_view.Size = new System.Drawing.Size(190, 78);
            this.button_stu_grade_view.TabIndex = 12;
            this.button_stu_grade_view.Text = "Student Grade View";
            this.button_stu_grade_view.UseVisualStyleBackColor = false;
            this.button_stu_grade_view.Click += new System.EventHandler(this.button_stu_grade_view_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FloralWhite;
            this.label1.Location = new System.Drawing.Point(98, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "个人信息→";
            // 
            // button_personal
            // 
            this.button_personal.BackColor = System.Drawing.Color.FloralWhite;
            this.button_personal.Font = new System.Drawing.Font("Kristen ITC", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_personal.ForeColor = System.Drawing.Color.DarkCyan;
            this.button_personal.Location = new System.Drawing.Point(247, 121);
            this.button_personal.Name = "button_personal";
            this.button_personal.Size = new System.Drawing.Size(190, 78);
            this.button_personal.TabIndex = 10;
            this.button_personal.Text = "Personal Info";
            this.button_personal.UseVisualStyleBackColor = false;
            this.button_personal.Click += new System.EventHandler(this.button_personal_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.FloralWhite;
            this.label6.Location = new System.Drawing.Point(219, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 21);
            this.label6.TabIndex = 20;
            this.label6.Text = "用户：";
            // 
            // label_userid
            // 
            this.label_userid.AutoSize = true;
            this.label_userid.Font = new System.Drawing.Font("Kristen ITC", 10.5F, System.Drawing.FontStyle.Bold);
            this.label_userid.ForeColor = System.Drawing.Color.FloralWhite;
            this.label_userid.Location = new System.Drawing.Point(313, 42);
            this.label_userid.Name = "label_userid";
            this.label_userid.Size = new System.Drawing.Size(82, 29);
            this.label_userid.TabIndex = 21;
            this.label_userid.Text = "用户：";
            // 
            // label_tno
            // 
            this.label_tno.AutoSize = true;
            this.label_tno.Font = new System.Drawing.Font("Kristen ITC", 10.5F, System.Drawing.FontStyle.Bold);
            this.label_tno.ForeColor = System.Drawing.Color.FloralWhite;
            this.label_tno.Location = new System.Drawing.Point(573, 42);
            this.label_tno.Name = "label_tno";
            this.label_tno.Size = new System.Drawing.Size(82, 29);
            this.label_tno.TabIndex = 23;
            this.label_tno.Text = "用户：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.FloralWhite;
            this.label8.Location = new System.Drawing.Point(442, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 21);
            this.label8.TabIndex = 22;
            this.label8.Text = "教师工号：";
            // 
            // FormTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(863, 484);
            this.Controls.Add(this.label_tno);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label_userid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_course);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_stu_grade_input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_stu_grade_view);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_personal);
            this.Name = "FormTeacher";
            this.Text = "FormTeacher";
            this.Load += new System.EventHandler(this.FormTeacher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_course;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_stu_grade_input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_stu_grade_view;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_personal;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label_userid;
        private System.Windows.Forms.Label label_tno;
        private System.Windows.Forms.Label label8;
    }
}