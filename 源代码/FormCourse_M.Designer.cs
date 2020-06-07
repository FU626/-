namespace 登录
{
    partial class FormCourse_M
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
            this.cnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccreditDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolDataSet1 = new 登录.schoolDataSet1();
            this.courseTableAdapter = new 登录.schoolDataSet1TableAdapters.CourseTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button_insert = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_select = new System.Windows.Forms.Button();
            this.checkBox_ccredit = new System.Windows.Forms.CheckBox();
            this.checkBox_cpno = new System.Windows.Forms.CheckBox();
            this.checkBox_cname = new System.Windows.Forms.CheckBox();
            this.checkBox_cno = new System.Windows.Forms.CheckBox();
            this.textBox_ccredit = new System.Windows.Forms.TextBox();
            this.textBox_cname = new System.Windows.Forms.TextBox();
            this.textBox_cpno = new System.Windows.Forms.TextBox();
            this.textBox_cno = new System.Windows.Forms.TextBox();
            this.label_sdept = new System.Windows.Forms.Label();
            this.label_sage = new System.Windows.Forms.Label();
            this.label_ssex = new System.Windows.Forms.Label();
            this.label_sname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonall = new System.Windows.Forms.Button();
            this.buttonclear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cnoDataGridViewTextBoxColumn,
            this.cnameDataGridViewTextBoxColumn,
            this.cpnoDataGridViewTextBoxColumn,
            this.ccreditDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.courseBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(398, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(666, 366);
            this.dataGridView1.TabIndex = 0;
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
            // cpnoDataGridViewTextBoxColumn
            // 
            this.cpnoDataGridViewTextBoxColumn.DataPropertyName = "Cpno";
            this.cpnoDataGridViewTextBoxColumn.HeaderText = "Cpno";
            this.cpnoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cpnoDataGridViewTextBoxColumn.Name = "cpnoDataGridViewTextBoxColumn";
            this.cpnoDataGridViewTextBoxColumn.Width = 150;
            // 
            // ccreditDataGridViewTextBoxColumn
            // 
            this.ccreditDataGridViewTextBoxColumn.DataPropertyName = "Ccredit";
            this.ccreditDataGridViewTextBoxColumn.HeaderText = "Ccredit";
            this.ccreditDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ccreditDataGridViewTextBoxColumn.Name = "ccreditDataGridViewTextBoxColumn";
            this.ccreditDataGridViewTextBoxColumn.Width = 150;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.schoolDataSet1;
            // 
            // schoolDataSet1
            // 
            this.schoolDataSet1.DataSetName = "schoolDataSet1";
            this.schoolDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Lavender;
            this.button1.Location = new System.Drawing.Point(912, 553);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 59);
            this.button1.TabIndex = 22;
            this.button1.Text = "CLOSE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_insert
            // 
            this.button_insert.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_insert.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_insert.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_insert.Location = new System.Drawing.Point(38, 326);
            this.button_insert.Name = "button_insert";
            this.button_insert.Size = new System.Drawing.Size(132, 55);
            this.button_insert.TabIndex = 21;
            this.button_insert.Text = "Insert";
            this.button_insert.UseVisualStyleBackColor = false;
            this.button_insert.Click += new System.EventHandler(this.button_insert_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_delete.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_delete.Location = new System.Drawing.Point(224, 328);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(132, 53);
            this.button_delete.TabIndex = 20;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_update.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_update.Location = new System.Drawing.Point(38, 400);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(132, 55);
            this.button_update.TabIndex = 19;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_select
            // 
            this.button_select.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_select.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_select.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_select.Location = new System.Drawing.Point(224, 400);
            this.button_select.Name = "button_select";
            this.button_select.Size = new System.Drawing.Size(132, 61);
            this.button_select.TabIndex = 18;
            this.button_select.Text = "Select";
            this.button_select.UseVisualStyleBackColor = false;
            this.button_select.Click += new System.EventHandler(this.button_select_Click);
            // 
            // checkBox_ccredit
            // 
            this.checkBox_ccredit.AutoSize = true;
            this.checkBox_ccredit.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_ccredit.ForeColor = System.Drawing.Color.Navy;
            this.checkBox_ccredit.Location = new System.Drawing.Point(209, 168);
            this.checkBox_ccredit.Name = "checkBox_ccredit";
            this.checkBox_ccredit.Size = new System.Drawing.Size(22, 21);
            this.checkBox_ccredit.TabIndex = 49;
            this.checkBox_ccredit.UseVisualStyleBackColor = true;
            // 
            // checkBox_cpno
            // 
            this.checkBox_cpno.AutoSize = true;
            this.checkBox_cpno.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_cpno.ForeColor = System.Drawing.Color.Navy;
            this.checkBox_cpno.Location = new System.Drawing.Point(48, 168);
            this.checkBox_cpno.Name = "checkBox_cpno";
            this.checkBox_cpno.Size = new System.Drawing.Size(22, 21);
            this.checkBox_cpno.TabIndex = 48;
            this.checkBox_cpno.UseVisualStyleBackColor = true;
            // 
            // checkBox_cname
            // 
            this.checkBox_cname.AutoSize = true;
            this.checkBox_cname.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_cname.ForeColor = System.Drawing.Color.Navy;
            this.checkBox_cname.Location = new System.Drawing.Point(209, 61);
            this.checkBox_cname.Name = "checkBox_cname";
            this.checkBox_cname.Size = new System.Drawing.Size(22, 21);
            this.checkBox_cname.TabIndex = 47;
            this.checkBox_cname.UseVisualStyleBackColor = true;
            // 
            // checkBox_cno
            // 
            this.checkBox_cno.AutoSize = true;
            this.checkBox_cno.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_cno.ForeColor = System.Drawing.Color.Navy;
            this.checkBox_cno.Location = new System.Drawing.Point(48, 61);
            this.checkBox_cno.Name = "checkBox_cno";
            this.checkBox_cno.Size = new System.Drawing.Size(22, 21);
            this.checkBox_cno.TabIndex = 46;
            this.checkBox_cno.UseVisualStyleBackColor = true;
            // 
            // textBox_ccredit
            // 
            this.textBox_ccredit.BackColor = System.Drawing.Color.Azure;
            this.textBox_ccredit.Font = new System.Drawing.Font("Segoe Script", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ccredit.ForeColor = System.Drawing.Color.Navy;
            this.textBox_ccredit.Location = new System.Drawing.Point(224, 208);
            this.textBox_ccredit.Name = "textBox_ccredit";
            this.textBox_ccredit.Size = new System.Drawing.Size(100, 41);
            this.textBox_ccredit.TabIndex = 45;
            // 
            // textBox_cname
            // 
            this.textBox_cname.BackColor = System.Drawing.Color.Azure;
            this.textBox_cname.Font = new System.Drawing.Font("Segoe Script", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_cname.ForeColor = System.Drawing.Color.Navy;
            this.textBox_cname.Location = new System.Drawing.Point(224, 101);
            this.textBox_cname.Name = "textBox_cname";
            this.textBox_cname.Size = new System.Drawing.Size(100, 41);
            this.textBox_cname.TabIndex = 44;
            // 
            // textBox_cpno
            // 
            this.textBox_cpno.BackColor = System.Drawing.Color.Azure;
            this.textBox_cpno.Font = new System.Drawing.Font("Segoe Script", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_cpno.ForeColor = System.Drawing.Color.Navy;
            this.textBox_cpno.Location = new System.Drawing.Point(77, 208);
            this.textBox_cpno.Name = "textBox_cpno";
            this.textBox_cpno.Size = new System.Drawing.Size(100, 41);
            this.textBox_cpno.TabIndex = 43;
            // 
            // textBox_cno
            // 
            this.textBox_cno.BackColor = System.Drawing.Color.Azure;
            this.textBox_cno.Font = new System.Drawing.Font("Segoe Script", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_cno.ForeColor = System.Drawing.Color.Navy;
            this.textBox_cno.Location = new System.Drawing.Point(77, 101);
            this.textBox_cno.Name = "textBox_cno";
            this.textBox_cno.Size = new System.Drawing.Size(100, 41);
            this.textBox_cno.TabIndex = 42;
            // 
            // label_sdept
            // 
            this.label_sdept.AutoSize = true;
            this.label_sdept.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sdept.ForeColor = System.Drawing.Color.Navy;
            this.label_sdept.Location = new System.Drawing.Point(230, 158);
            this.label_sdept.Name = "label_sdept";
            this.label_sdept.Size = new System.Drawing.Size(111, 38);
            this.label_sdept.TabIndex = 41;
            this.label_sdept.Text = "Ccredit";
            // 
            // label_sage
            // 
            this.label_sage.AutoSize = true;
            this.label_sage.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sage.ForeColor = System.Drawing.Color.Navy;
            this.label_sage.Location = new System.Drawing.Point(237, 51);
            this.label_sage.Name = "label_sage";
            this.label_sage.Size = new System.Drawing.Size(106, 38);
            this.label_sage.TabIndex = 40;
            this.label_sage.Text = "Cname";
            // 
            // label_ssex
            // 
            this.label_ssex.AutoSize = true;
            this.label_ssex.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ssex.ForeColor = System.Drawing.Color.Navy;
            this.label_ssex.Location = new System.Drawing.Point(88, 158);
            this.label_ssex.Name = "label_ssex";
            this.label_ssex.Size = new System.Drawing.Size(82, 38);
            this.label_ssex.TabIndex = 39;
            this.label_ssex.Text = "Cpno";
            // 
            // label_sname
            // 
            this.label_sname.AutoSize = true;
            this.label_sname.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sname.ForeColor = System.Drawing.Color.Navy;
            this.label_sname.Location = new System.Drawing.Point(93, 52);
            this.label_sname.Name = "label_sname";
            this.label_sname.Size = new System.Drawing.Size(66, 38);
            this.label_sname.TabIndex = 38;
            this.label_sname.Text = "Cno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tekton Pro Ext", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(137, 542);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(616, 116);
            this.label1.TabIndex = 50;
            this.label1.Text = "insert: 输入以上所有数据，插入\r\ndelete：选中删除行，删除\r\nupdate: 输入Cno，选中更改项，输入更改信息，更改\r\nselect: 选中查询" +
    "项，输入查询信息，查询";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Viner Hand ITC", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(41, 513);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 45);
            this.label2.TabIndex = 51;
            this.label2.Text = "Tips:";
            // 
            // buttonall
            // 
            this.buttonall.BackColor = System.Drawing.Color.Azure;
            this.buttonall.Font = new System.Drawing.Font("Matura MT Script Capitals", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonall.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonall.Location = new System.Drawing.Point(720, 462);
            this.buttonall.Name = "buttonall";
            this.buttonall.Size = new System.Drawing.Size(157, 55);
            this.buttonall.TabIndex = 52;
            this.buttonall.Text = "Show All";
            this.buttonall.UseVisualStyleBackColor = false;
            this.buttonall.Click += new System.EventHandler(this.buttonall_Click);
            // 
            // buttonclear
            // 
            this.buttonclear.BackColor = System.Drawing.Color.Azure;
            this.buttonclear.Font = new System.Drawing.Font("Matura MT Script Capitals", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonclear.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonclear.Location = new System.Drawing.Point(912, 462);
            this.buttonclear.Name = "buttonclear";
            this.buttonclear.Size = new System.Drawing.Size(152, 55);
            this.buttonclear.TabIndex = 53;
            this.buttonclear.Text = "Clear All";
            this.buttonclear.UseVisualStyleBackColor = false;
            this.buttonclear.Click += new System.EventHandler(this.buttonclear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(49, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 24);
            this.label3.TabIndex = 54;
            this.label3.Text = "开设课程";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(233, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 24);
            this.label4.TabIndex = 55;
            this.label4.Text = "删除课程";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(49, 473);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 24);
            this.label5.TabIndex = 56;
            this.label5.Text = "更改课程";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(233, 473);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 24);
            this.label6.TabIndex = 57;
            this.label6.Text = "查看课程";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(16, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 38);
            this.label7.TabIndex = 58;
            this.label7.Text = "User：";
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelid.ForeColor = System.Drawing.Color.Navy;
            this.labelid.Location = new System.Drawing.Point(118, 9);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(72, 38);
            this.labelid.TabIndex = 59;
            this.labelid.Text = "User";
            // 
            // FormCourse_M
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1109, 683);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonclear);
            this.Controls.Add(this.buttonall);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox_ccredit);
            this.Controls.Add(this.checkBox_cpno);
            this.Controls.Add(this.checkBox_cname);
            this.Controls.Add(this.checkBox_cno);
            this.Controls.Add(this.textBox_ccredit);
            this.Controls.Add(this.textBox_cname);
            this.Controls.Add(this.textBox_cpno);
            this.Controls.Add(this.textBox_cno);
            this.Controls.Add(this.label_sdept);
            this.Controls.Add(this.label_sage);
            this.Controls.Add(this.label_ssex);
            this.Controls.Add(this.label_sname);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_insert);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_select);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormCourse_M";
            this.Text = "Course Info Management";
            this.Load += new System.EventHandler(this.FormCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private schoolDataSet1 schoolDataSet1;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private schoolDataSet1TableAdapters.CourseTableAdapter courseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccreditDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_insert;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_select;
        private System.Windows.Forms.CheckBox checkBox_ccredit;
        private System.Windows.Forms.CheckBox checkBox_cpno;
        private System.Windows.Forms.CheckBox checkBox_cname;
        private System.Windows.Forms.CheckBox checkBox_cno;
        private System.Windows.Forms.TextBox textBox_ccredit;
        private System.Windows.Forms.TextBox textBox_cname;
        private System.Windows.Forms.TextBox textBox_cpno;
        private System.Windows.Forms.TextBox textBox_cno;
        private System.Windows.Forms.Label label_sdept;
        private System.Windows.Forms.Label label_sage;
        private System.Windows.Forms.Label label_ssex;
        private System.Windows.Forms.Label label_sname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonall;
        private System.Windows.Forms.Button buttonclear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label labelid;
    }
}