namespace 登录
{
    partial class FormCourseview_T
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stunumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCNUMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolDataSet4 = new 登录.schoolDataSet4();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.t_C_NUMTableAdapter = new 登录.schoolDataSet4TableAdapters.T_C_NUMTableAdapter();
            this.button_mycourses = new System.Windows.Forms.Button();
            this.textBox_Tno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonall = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCNUMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tnoDataGridViewTextBoxColumn,
            this.tnameDataGridViewTextBoxColumn,
            this.cnoDataGridViewTextBoxColumn,
            this.cnameDataGridViewTextBoxColumn,
            this.stunumDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tCNUMBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(48, 238);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(843, 343);
            this.dataGridView1.TabIndex = 0;
            // 
            // tnoDataGridViewTextBoxColumn
            // 
            this.tnoDataGridViewTextBoxColumn.DataPropertyName = "Tno";
            this.tnoDataGridViewTextBoxColumn.HeaderText = "Tno";
            this.tnoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tnoDataGridViewTextBoxColumn.Name = "tnoDataGridViewTextBoxColumn";
            this.tnoDataGridViewTextBoxColumn.Width = 150;
            // 
            // tnameDataGridViewTextBoxColumn
            // 
            this.tnameDataGridViewTextBoxColumn.DataPropertyName = "Tname";
            this.tnameDataGridViewTextBoxColumn.HeaderText = "Tname";
            this.tnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tnameDataGridViewTextBoxColumn.Name = "tnameDataGridViewTextBoxColumn";
            this.tnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // cnoDataGridViewTextBoxColumn
            // 
            this.cnoDataGridViewTextBoxColumn.DataPropertyName = "Cno";
            this.cnoDataGridViewTextBoxColumn.HeaderText = "Cno";
            this.cnoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cnoDataGridViewTextBoxColumn.Name = "cnoDataGridViewTextBoxColumn";
            this.cnoDataGridViewTextBoxColumn.Width = 150;
            // 
            // cnameDataGridViewTextBoxColumn
            // 
            this.cnameDataGridViewTextBoxColumn.DataPropertyName = "Cname";
            this.cnameDataGridViewTextBoxColumn.HeaderText = "Cname";
            this.cnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cnameDataGridViewTextBoxColumn.Name = "cnameDataGridViewTextBoxColumn";
            this.cnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // stunumDataGridViewTextBoxColumn
            // 
            this.stunumDataGridViewTextBoxColumn.DataPropertyName = "stunum";
            this.stunumDataGridViewTextBoxColumn.HeaderText = "stunum";
            this.stunumDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.stunumDataGridViewTextBoxColumn.Name = "stunumDataGridViewTextBoxColumn";
            this.stunumDataGridViewTextBoxColumn.Width = 150;
            // 
            // tCNUMBindingSource
            // 
            this.tCNUMBindingSource.DataMember = "T_C_NUM";
            this.tCNUMBindingSource.DataSource = this.schoolDataSet4;
            // 
            // schoolDataSet4
            // 
            this.schoolDataSet4.DataSetName = "schoolDataSet4";
            this.schoolDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(34, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "所有课程及授课教师信息：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(514, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(401, 63);
            this.label2.TabIndex = 2;
            this.label2.Text = "仅显示目前有学生选课的课程\r\n\r\n如果出现错误，请联系管理员进行修改";
            // 
            // t_C_NUMTableAdapter
            // 
            this.t_C_NUMTableAdapter.ClearBeforeFill = true;
            // 
            // button_mycourses
            // 
            this.button_mycourses.BackColor = System.Drawing.Color.LightCoral;
            this.button_mycourses.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_mycourses.Location = new System.Drawing.Point(600, 36);
            this.button_mycourses.Name = "button_mycourses";
            this.button_mycourses.Size = new System.Drawing.Size(206, 64);
            this.button_mycourses.TabIndex = 3;
            this.button_mycourses.Text = "View My Courses";
            this.button_mycourses.UseVisualStyleBackColor = false;
            this.button_mycourses.Click += new System.EventHandler(this.button_mycourses_Click);
            // 
            // textBox_Tno
            // 
            this.textBox_Tno.Enabled = false;
            this.textBox_Tno.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Tno.ForeColor = System.Drawing.Color.LightCoral;
            this.textBox_Tno.Location = new System.Drawing.Point(408, 54);
            this.textBox_Tno.Name = "textBox_Tno";
            this.textBox_Tno.Size = new System.Drawing.Size(113, 40);
            this.textBox_Tno.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(319, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(12, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(293, 48);
            this.label4.TabIndex = 6;
            this.label4.Text = "点击“View My Courses\"\r\n根据Tno,查询所教课程";
            // 
            // buttonall
            // 
            this.buttonall.BackColor = System.Drawing.Color.LightCoral;
            this.buttonall.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonall.Location = new System.Drawing.Point(354, 130);
            this.buttonall.Name = "buttonall";
            this.buttonall.Size = new System.Drawing.Size(136, 64);
            this.buttonall.TabIndex = 7;
            this.buttonall.Text = "All Courses";
            this.buttonall.UseVisualStyleBackColor = false;
            this.buttonall.Click += new System.EventHandler(this.buttonall_Click);
            // 
            // FormCourseview_T
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(946, 613);
            this.Controls.Add(this.buttonall);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Tno);
            this.Controls.Add(this.button_mycourses);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormCourseview_T";
            this.Text = "教师课程信息查看";
            this.Load += new System.EventHandler(this.FormCourseview_T_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCNUMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private schoolDataSet4 schoolDataSet4;
        private System.Windows.Forms.BindingSource tCNUMBindingSource;
        private schoolDataSet4TableAdapters.T_C_NUMTableAdapter t_C_NUMTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stunumDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button_mycourses;
        public System.Windows.Forms.TextBox textBox_Tno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonall;
    }
}