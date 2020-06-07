namespace 登录
{
    partial class FormGrade_stu
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
            this.snoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccreditDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUGradeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolDataSet3 = new 登录.schoolDataSet3();
            this.schoolDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolDataSet1 = new 登录.schoolDataSet1();
            this.sCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sCTableAdapter = new 登录.schoolDataSet1TableAdapters.SCTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_nopass = new System.Windows.Forms.Button();
            this.button_pass = new System.Windows.Forms.Button();
            this.button_all = new System.Windows.Forms.Button();
            this.button_grade_order = new System.Windows.Forms.Button();
            this.schoolDataSet = new 登录.schoolDataSet();
            this.schoolDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sCBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sCTableAdapter1 = new 登录.schoolDataSetTableAdapters.SCTableAdapter();
            this.sTU_GradeTableAdapter = new 登录.schoolDataSet3TableAdapters.STU_GradeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUGradeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snoDataGridViewTextBoxColumn,
            this.cnoDataGridViewTextBoxColumn,
            this.cnameDataGridViewTextBoxColumn,
            this.ccreditDataGridViewTextBoxColumn,
            this.gradeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sTUGradeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(633, 356);
            this.dataGridView1.TabIndex = 0;
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
            // cnameDataGridViewTextBoxColumn
            // 
            this.cnameDataGridViewTextBoxColumn.DataPropertyName = "Cname";
            this.cnameDataGridViewTextBoxColumn.HeaderText = "Cname";
            this.cnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cnameDataGridViewTextBoxColumn.Name = "cnameDataGridViewTextBoxColumn";
            this.cnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // ccreditDataGridViewTextBoxColumn
            // 
            this.ccreditDataGridViewTextBoxColumn.DataPropertyName = "Ccredit";
            this.ccreditDataGridViewTextBoxColumn.HeaderText = "Ccredit";
            this.ccreditDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ccreditDataGridViewTextBoxColumn.Name = "ccreditDataGridViewTextBoxColumn";
            this.ccreditDataGridViewTextBoxColumn.Width = 150;
            // 
            // gradeDataGridViewTextBoxColumn
            // 
            this.gradeDataGridViewTextBoxColumn.DataPropertyName = "Grade";
            this.gradeDataGridViewTextBoxColumn.HeaderText = "Grade";
            this.gradeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.gradeDataGridViewTextBoxColumn.Name = "gradeDataGridViewTextBoxColumn";
            this.gradeDataGridViewTextBoxColumn.Width = 150;
            // 
            // sTUGradeBindingSource
            // 
            this.sTUGradeBindingSource.DataMember = "STU_Grade";
            this.sTUGradeBindingSource.DataSource = this.schoolDataSet3;
            // 
            // schoolDataSet3
            // 
            this.schoolDataSet3.DataSetName = "schoolDataSet3";
            this.schoolDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // schoolDataSet1BindingSource
            // 
            this.schoolDataSet1BindingSource.DataSource = this.schoolDataSet1;
            this.schoolDataSet1BindingSource.Position = 0;
            // 
            // schoolDataSet1
            // 
            this.schoolDataSet1.DataSetName = "schoolDataSet1";
            this.schoolDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sCBindingSource
            // 
            this.sCBindingSource.DataMember = "SC";
            this.sCBindingSource.DataSource = this.schoolDataSet1;
            // 
            // sCTableAdapter
            // 
            this.sCTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your Sno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(287, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 33);
            this.label2.TabIndex = 2;
            // 
            // button_nopass
            // 
            this.button_nopass.BackColor = System.Drawing.Color.DarkCyan;
            this.button_nopass.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_nopass.ForeColor = System.Drawing.Color.FloralWhite;
            this.button_nopass.Location = new System.Drawing.Point(706, 193);
            this.button_nopass.Name = "button_nopass";
            this.button_nopass.Size = new System.Drawing.Size(205, 64);
            this.button_nopass.TabIndex = 3;
            this.button_nopass.Text = "仅显示\r\n不及格成绩";
            this.button_nopass.UseVisualStyleBackColor = false;
            this.button_nopass.Click += new System.EventHandler(this.button_nopass_Click);
            // 
            // button_pass
            // 
            this.button_pass.BackColor = System.Drawing.Color.DarkCyan;
            this.button_pass.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_pass.ForeColor = System.Drawing.Color.FloralWhite;
            this.button_pass.Location = new System.Drawing.Point(706, 105);
            this.button_pass.Name = "button_pass";
            this.button_pass.Size = new System.Drawing.Size(205, 62);
            this.button_pass.TabIndex = 4;
            this.button_pass.Text = "仅显示及格成绩";
            this.button_pass.UseVisualStyleBackColor = false;
            this.button_pass.Click += new System.EventHandler(this.button_pass_Click);
            // 
            // button_all
            // 
            this.button_all.BackColor = System.Drawing.Color.DarkCyan;
            this.button_all.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_all.ForeColor = System.Drawing.Color.FloralWhite;
            this.button_all.Location = new System.Drawing.Point(706, 283);
            this.button_all.Name = "button_all";
            this.button_all.Size = new System.Drawing.Size(205, 64);
            this.button_all.TabIndex = 5;
            this.button_all.Text = "显示所有";
            this.button_all.UseVisualStyleBackColor = false;
            this.button_all.Click += new System.EventHandler(this.button_all_Click);
            // 
            // button_grade_order
            // 
            this.button_grade_order.BackColor = System.Drawing.Color.DarkCyan;
            this.button_grade_order.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_grade_order.ForeColor = System.Drawing.Color.FloralWhite;
            this.button_grade_order.Location = new System.Drawing.Point(706, 373);
            this.button_grade_order.Name = "button_grade_order";
            this.button_grade_order.Size = new System.Drawing.Size(205, 64);
            this.button_grade_order.TabIndex = 6;
            this.button_grade_order.Text = "成绩排序";
            this.button_grade_order.UseVisualStyleBackColor = false;
            this.button_grade_order.Click += new System.EventHandler(this.button_grade_order_Click);
            // 
            // schoolDataSet
            // 
            this.schoolDataSet.DataSetName = "schoolDataSet";
            this.schoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // schoolDataSetBindingSource
            // 
            this.schoolDataSetBindingSource.DataSource = this.schoolDataSet;
            this.schoolDataSetBindingSource.Position = 0;
            // 
            // sCBindingSource1
            // 
            this.sCBindingSource1.DataMember = "SC";
            this.sCBindingSource1.DataSource = this.schoolDataSetBindingSource;
            // 
            // sCTableAdapter1
            // 
            this.sCTableAdapter1.ClearBeforeFill = true;
            // 
            // sTU_GradeTableAdapter
            // 
            this.sTU_GradeTableAdapter.ClearBeforeFill = true;
            // 
            // FormGrade_stu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(933, 505);
            this.Controls.Add(this.button_grade_order);
            this.Controls.Add(this.button_all);
            this.Controls.Add(this.button_pass);
            this.Controls.Add(this.button_nopass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormGrade_stu";
            this.Text = "我的成绩";
            this.Load += new System.EventHandler(this.FormGrade_stu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUGradeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private schoolDataSet1 schoolDataSet1;
        private System.Windows.Forms.BindingSource sCBindingSource;
        private schoolDataSet1TableAdapters.SCTableAdapter sCTableAdapter;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_nopass;
        private System.Windows.Forms.Button button_pass;
        private System.Windows.Forms.Button button_all;
        private System.Windows.Forms.Button button_grade_order;
        private System.Windows.Forms.BindingSource schoolDataSet1BindingSource;
        private System.Windows.Forms.BindingSource schoolDataSetBindingSource;
        private schoolDataSet schoolDataSet;
        private System.Windows.Forms.BindingSource sCBindingSource1;
        private schoolDataSetTableAdapters.SCTableAdapter sCTableAdapter1;
        private schoolDataSet3 schoolDataSet3;
        private System.Windows.Forms.BindingSource sTUGradeBindingSource;
        private schoolDataSet3TableAdapters.STU_GradeTableAdapter sTU_GradeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccreditDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeDataGridViewTextBoxColumn;
    }
}