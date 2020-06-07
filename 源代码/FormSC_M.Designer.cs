namespace 登录
{
    partial class FormSC_M
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
            this.components = new System.ComponentModel.Container();
            this.buttonclear = new System.Windows.Forms.Button();
            this.buttonall = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_grade = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button_insert = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_select = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolDataSet1 = new 登录.schoolDataSet1();
            this.checkBox_grade = new System.Windows.Forms.CheckBox();
            this.checkBox_sno = new System.Windows.Forms.CheckBox();
            this.checkBox_cno = new System.Windows.Forms.CheckBox();
            this.textBox_sno = new System.Windows.Forms.TextBox();
            this.textBox_cno = new System.Windows.Forms.TextBox();
            this.label_sdept = new System.Windows.Forms.Label();
            this.label_sage = new System.Windows.Forms.Label();
            this.label_sname = new System.Windows.Forms.Label();
            this.sCTableAdapter = new 登录.schoolDataSet1TableAdapters.SCTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonclear
            // 
            this.buttonclear.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonclear.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonclear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonclear.Location = new System.Drawing.Point(710, 132);
            this.buttonclear.Name = "buttonclear";
            this.buttonclear.Size = new System.Drawing.Size(157, 55);
            this.buttonclear.TabIndex = 65;
            this.buttonclear.Text = "Clear All";
            this.buttonclear.UseVisualStyleBackColor = false;
            this.buttonclear.Click += new System.EventHandler(this.buttonclear_Click);
            // 
            // buttonall
            // 
            this.buttonall.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonall.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonall.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonall.Location = new System.Drawing.Point(880, 45);
            this.buttonall.Name = "buttonall";
            this.buttonall.Size = new System.Drawing.Size(157, 55);
            this.buttonall.TabIndex = 64;
            this.buttonall.Text = "Show All";
            this.buttonall.UseVisualStyleBackColor = false;
            this.buttonall.Click += new System.EventHandler(this.buttonall_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Viner Hand ITC", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(41, 468);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 45);
            this.label2.TabIndex = 63;
            this.label2.Text = "Tips:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tekton Pro Ext", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(150, 495);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(572, 145);
            this.label1.TabIndex = 62;
            this.label1.Text = "insert: 输入以上所有数据，插入\r\ndelete：选中删除行，删除\r\nupdate: 输入Sno,Cno，输入更改后的成绩，更改\r\nselect: 选中查询" +
    "项，输入查询信息，查询\r\n（其中成绩可以选择>,<,=>=等符号进行查询）";
            // 
            // textBox_grade
            // 
            this.textBox_grade.BackColor = System.Drawing.Color.Azure;
            this.textBox_grade.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_grade.Location = new System.Drawing.Point(930, 409);
            this.textBox_grade.Name = "textBox_grade";
            this.textBox_grade.Size = new System.Drawing.Size(100, 40);
            this.textBox_grade.TabIndex = 61;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Azure;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(863, 561);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 59);
            this.button1.TabIndex = 59;
            this.button1.Text = "CLOSE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_insert
            // 
            this.button_insert.BackColor = System.Drawing.Color.SeaGreen;
            this.button_insert.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_insert.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_insert.Location = new System.Drawing.Point(49, 401);
            this.button_insert.Name = "button_insert";
            this.button_insert.Size = new System.Drawing.Size(132, 55);
            this.button_insert.TabIndex = 58;
            this.button_insert.Text = "Insert";
            this.button_insert.UseVisualStyleBackColor = false;
            this.button_insert.Click += new System.EventHandler(this.button_insert_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.SeaGreen;
            this.button_delete.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_delete.Location = new System.Drawing.Point(245, 401);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(132, 53);
            this.button_delete.TabIndex = 57;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.SeaGreen;
            this.button_update.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_update.Location = new System.Drawing.Point(448, 401);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(132, 55);
            this.button_update.TabIndex = 56;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_select
            // 
            this.button_select.BackColor = System.Drawing.Color.SeaGreen;
            this.button_select.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_select.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_select.Location = new System.Drawing.Point(652, 398);
            this.button_select.Name = "button_select";
            this.button_select.Size = new System.Drawing.Size(132, 61);
            this.button_select.TabIndex = 55;
            this.button_select.Text = "Select";
            this.button_select.UseVisualStyleBackColor = false;
            this.button_select.Click += new System.EventHandler(this.button_select_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snoDataGridViewTextBoxColumn,
            this.cnoDataGridViewTextBoxColumn,
            this.gradeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sCBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(32, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(632, 331);
            this.dataGridView1.TabIndex = 54;
            // 
            // snoDataGridViewTextBoxColumn
            // 
            this.snoDataGridViewTextBoxColumn.DataPropertyName = "Sno";
            this.snoDataGridViewTextBoxColumn.HeaderText = "Sno";
            this.snoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.snoDataGridViewTextBoxColumn.Name = "snoDataGridViewTextBoxColumn";
            this.snoDataGridViewTextBoxColumn.Width = 150;
            // 
            // cnoDataGridViewTextBoxColumn
            // 
            this.cnoDataGridViewTextBoxColumn.DataPropertyName = "Cno";
            this.cnoDataGridViewTextBoxColumn.HeaderText = "Cno";
            this.cnoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cnoDataGridViewTextBoxColumn.Name = "cnoDataGridViewTextBoxColumn";
            this.cnoDataGridViewTextBoxColumn.Width = 150;
            // 
            // gradeDataGridViewTextBoxColumn
            // 
            this.gradeDataGridViewTextBoxColumn.DataPropertyName = "Grade";
            this.gradeDataGridViewTextBoxColumn.HeaderText = "Grade";
            this.gradeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.gradeDataGridViewTextBoxColumn.Name = "gradeDataGridViewTextBoxColumn";
            this.gradeDataGridViewTextBoxColumn.Width = 150;
            // 
            // sCBindingSource
            // 
            this.sCBindingSource.DataMember = "SC";
            this.sCBindingSource.DataSource = this.schoolDataSet1;
            // 
            // schoolDataSet1
            // 
            this.schoolDataSet1.DataSetName = "schoolDataSet1";
            this.schoolDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // checkBox_grade
            // 
            this.checkBox_grade.AutoSize = true;
            this.checkBox_grade.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_grade.ForeColor = System.Drawing.Color.OrangeRed;
            this.checkBox_grade.Location = new System.Drawing.Point(900, 367);
            this.checkBox_grade.Name = "checkBox_grade";
            this.checkBox_grade.Size = new System.Drawing.Size(22, 21);
            this.checkBox_grade.TabIndex = 75;
            this.checkBox_grade.UseVisualStyleBackColor = true;
            // 
            // checkBox_sno
            // 
            this.checkBox_sno.AutoSize = true;
            this.checkBox_sno.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_sno.ForeColor = System.Drawing.Color.OrangeRed;
            this.checkBox_sno.Location = new System.Drawing.Point(746, 248);
            this.checkBox_sno.Name = "checkBox_sno";
            this.checkBox_sno.Size = new System.Drawing.Size(22, 21);
            this.checkBox_sno.TabIndex = 73;
            this.checkBox_sno.UseVisualStyleBackColor = true;
            // 
            // checkBox_cno
            // 
            this.checkBox_cno.AutoSize = true;
            this.checkBox_cno.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_cno.Location = new System.Drawing.Point(896, 250);
            this.checkBox_cno.Name = "checkBox_cno";
            this.checkBox_cno.Size = new System.Drawing.Size(22, 21);
            this.checkBox_cno.TabIndex = 72;
            this.checkBox_cno.UseVisualStyleBackColor = true;
            // 
            // textBox_sno
            // 
            this.textBox_sno.BackColor = System.Drawing.Color.Azure;
            this.textBox_sno.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_sno.Location = new System.Drawing.Point(751, 292);
            this.textBox_sno.Name = "textBox_sno";
            this.textBox_sno.Size = new System.Drawing.Size(100, 40);
            this.textBox_sno.TabIndex = 71;
            // 
            // textBox_cno
            // 
            this.textBox_cno.BackColor = System.Drawing.Color.Azure;
            this.textBox_cno.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_cno.Location = new System.Drawing.Point(908, 292);
            this.textBox_cno.Name = "textBox_cno";
            this.textBox_cno.Size = new System.Drawing.Size(100, 40);
            this.textBox_cno.TabIndex = 70;
            // 
            // label_sdept
            // 
            this.label_sdept.AutoSize = true;
            this.label_sdept.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sdept.ForeColor = System.Drawing.Color.OrangeRed;
            this.label_sdept.Location = new System.Drawing.Point(928, 360);
            this.label_sdept.Name = "label_sdept";
            this.label_sdept.Size = new System.Drawing.Size(92, 33);
            this.label_sdept.TabIndex = 69;
            this.label_sdept.Text = "Grade";
            // 
            // label_sage
            // 
            this.label_sage.AutoSize = true;
            this.label_sage.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sage.ForeColor = System.Drawing.Color.OrangeRed;
            this.label_sage.Location = new System.Drawing.Point(774, 243);
            this.label_sage.Name = "label_sage";
            this.label_sage.Size = new System.Drawing.Size(62, 33);
            this.label_sage.TabIndex = 68;
            this.label_sage.Text = "Sno";
            // 
            // label_sname
            // 
            this.label_sname.AutoSize = true;
            this.label_sname.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sname.ForeColor = System.Drawing.Color.OrangeRed;
            this.label_sname.Location = new System.Drawing.Point(924, 243);
            this.label_sname.Name = "label_sname";
            this.label_sname.Size = new System.Drawing.Size(67, 33);
            this.label_sname.TabIndex = 66;
            this.label_sname.Text = "Cno";
            // 
            // sCTableAdapter
            // 
            this.sCTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(45, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 21);
            this.label3.TabIndex = 76;
            this.label3.Text = "新增选课记录";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(241, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 21);
            this.label4.TabIndex = 77;
            this.label4.Text = "删除选课记录";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.DarkGreen;
            this.label5.Location = new System.Drawing.Point(444, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 21);
            this.label5.TabIndex = 78;
            this.label5.Text = "修改选课成绩";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.DarkGreen;
            this.label6.Location = new System.Drawing.Point(648, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 21);
            this.label6.TabIndex = 79;
            this.label6.Text = "查看选课记录";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.DarkGreen;
            this.label7.Location = new System.Drawing.Point(706, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 21);
            this.label7.TabIndex = 80;
            this.label7.Text = "所有选课记录→";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.DarkGreen;
            this.label8.Location = new System.Drawing.Point(876, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 21);
            this.label8.TabIndex = 81;
            this.label8.Text = "←清除所有输入";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            ">",
            "<",
            "=",
            "<=",
            ">="});
            this.comboBox1.Location = new System.Drawing.Point(832, 408);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(86, 41);
            this.comboBox1.TabIndex = 82;
            // 
            // FormSC_M
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1052, 649);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox_grade);
            this.Controls.Add(this.checkBox_sno);
            this.Controls.Add(this.checkBox_cno);
            this.Controls.Add(this.textBox_sno);
            this.Controls.Add(this.textBox_cno);
            this.Controls.Add(this.label_sdept);
            this.Controls.Add(this.label_sage);
            this.Controls.Add(this.label_sname);
            this.Controls.Add(this.buttonclear);
            this.Controls.Add(this.buttonall);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_grade);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_insert);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_select);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormSC_M";
            this.Text = "SC Info Management";
            this.Load += new System.EventHandler(this.FormSC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonclear;
        private System.Windows.Forms.Button buttonall;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_grade;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_insert;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_select;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox checkBox_grade;
        private System.Windows.Forms.CheckBox checkBox_sno;
        private System.Windows.Forms.CheckBox checkBox_cno;
        private System.Windows.Forms.TextBox textBox_sno;
        private System.Windows.Forms.TextBox textBox_cno;
        private System.Windows.Forms.Label label_sdept;
        private System.Windows.Forms.Label label_sage;
        private System.Windows.Forms.Label label_sname;
        private schoolDataSet1 schoolDataSet1;
        private System.Windows.Forms.BindingSource sCBindingSource;
        private schoolDataSet1TableAdapters.SCTableAdapter sCTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        public string userid;
    }
}