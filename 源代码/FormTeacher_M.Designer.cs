namespace 登录
{
    partial class FormTeacher_M
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
            this.tsexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdeptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tidenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolDataSet2 = new 登录.schoolDataSet2();
            this.teacherTableAdapter = new 登录.schoolDataSet2TableAdapters.TeacherTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton_iden1 = new System.Windows.Forms.RadioButton();
            this.radioButton_iden2 = new System.Windows.Forms.RadioButton();
            this.radioButton_iden3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_insert = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_salary = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_tage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_tdept = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_tname = new System.Windows.Forms.TextBox();
            this.textBox_tno = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button_delete = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_update_item = new System.Windows.Forms.TextBox();
            this.textBox_update_by_tno = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button_update = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button_show_all = new System.Windows.Forms.Button();
            this.button_clear_select = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.checkBox_salary = new System.Windows.Forms.CheckBox();
            this.checkBox_tage = new System.Windows.Forms.CheckBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.checkBox_tiden = new System.Windows.Forms.CheckBox();
            this.checkBox_tdept = new System.Windows.Forms.CheckBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.checkBox_tsex = new System.Windows.Forms.CheckBox();
            this.checkBox_tname = new System.Windows.Forms.CheckBox();
            this.checkBox_tno = new System.Windows.Forms.CheckBox();
            this.textBox_tdept_select = new System.Windows.Forms.TextBox();
            this.textBox_salary_select = new System.Windows.Forms.TextBox();
            this.textBox_tage_select = new System.Windows.Forms.TextBox();
            this.textBox_tname_select = new System.Windows.Forms.TextBox();
            this.textBox_tno_select = new System.Windows.Forms.TextBox();
            this.button_select = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
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
            this.tsexDataGridViewTextBoxColumn,
            this.tdeptDataGridViewTextBoxColumn,
            this.tidenDataGridViewTextBoxColumn,
            this.tageDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.teacherBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(34, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(1304, 331);
            this.dataGridView1.TabIndex = 55;
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
            // tsexDataGridViewTextBoxColumn
            // 
            this.tsexDataGridViewTextBoxColumn.DataPropertyName = "Tsex";
            this.tsexDataGridViewTextBoxColumn.HeaderText = "Tsex";
            this.tsexDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tsexDataGridViewTextBoxColumn.Name = "tsexDataGridViewTextBoxColumn";
            this.tsexDataGridViewTextBoxColumn.Width = 150;
            // 
            // tdeptDataGridViewTextBoxColumn
            // 
            this.tdeptDataGridViewTextBoxColumn.DataPropertyName = "Tdept";
            this.tdeptDataGridViewTextBoxColumn.HeaderText = "Tdept";
            this.tdeptDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tdeptDataGridViewTextBoxColumn.Name = "tdeptDataGridViewTextBoxColumn";
            this.tdeptDataGridViewTextBoxColumn.Width = 150;
            // 
            // tidenDataGridViewTextBoxColumn
            // 
            this.tidenDataGridViewTextBoxColumn.DataPropertyName = "Tiden";
            this.tidenDataGridViewTextBoxColumn.HeaderText = "Tiden";
            this.tidenDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tidenDataGridViewTextBoxColumn.Name = "tidenDataGridViewTextBoxColumn";
            this.tidenDataGridViewTextBoxColumn.Width = 150;
            // 
            // tageDataGridViewTextBoxColumn
            // 
            this.tageDataGridViewTextBoxColumn.DataPropertyName = "Tage";
            this.tageDataGridViewTextBoxColumn.HeaderText = "Tage";
            this.tageDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tageDataGridViewTextBoxColumn.Name = "tageDataGridViewTextBoxColumn";
            this.tageDataGridViewTextBoxColumn.Width = 150;
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "Salary";
            this.salaryDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            this.salaryDataGridViewTextBoxColumn.Width = 150;
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataMember = "Teacher";
            this.teacherBindingSource.DataSource = this.schoolDataSet2;
            // 
            // schoolDataSet2
            // 
            this.schoolDataSet2.DataSetName = "schoolDataSet2";
            this.schoolDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teacherTableAdapter
            // 
            this.teacherTableAdapter.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.ItemSize = new System.Drawing.Size(150, 57);
            this.tabControl1.Location = new System.Drawing.Point(34, 364);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1025, 408);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 56;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.button_clear);
            this.tabPage1.Controls.Add(this.button_insert);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.textBox_salary);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.textBox_tage);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textBox_tdept);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBox_tname);
            this.tabPage1.Controls.Add(this.textBox_tno);
            this.tabPage1.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage1.Location = new System.Drawing.Point(4, 61);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1017, 343);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "新增教师信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton_iden1);
            this.groupBox2.Controls.Add(this.radioButton_iden2);
            this.groupBox2.Controls.Add(this.radioButton_iden3);
            this.groupBox2.Location = new System.Drawing.Point(454, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 54);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // radioButton_iden1
            // 
            this.radioButton_iden1.AutoSize = true;
            this.radioButton_iden1.Location = new System.Drawing.Point(6, 20);
            this.radioButton_iden1.Name = "radioButton_iden1";
            this.radioButton_iden1.Size = new System.Drawing.Size(85, 28);
            this.radioButton_iden1.TabIndex = 14;
            this.radioButton_iden1.TabStop = true;
            this.radioButton_iden1.Text = "教授";
            this.radioButton_iden1.UseVisualStyleBackColor = true;
            // 
            // radioButton_iden2
            // 
            this.radioButton_iden2.AutoSize = true;
            this.radioButton_iden2.Location = new System.Drawing.Point(103, 19);
            this.radioButton_iden2.Name = "radioButton_iden2";
            this.radioButton_iden2.Size = new System.Drawing.Size(110, 28);
            this.radioButton_iden2.TabIndex = 15;
            this.radioButton_iden2.TabStop = true;
            this.radioButton_iden2.Text = "副教授";
            this.radioButton_iden2.UseVisualStyleBackColor = true;
            // 
            // radioButton_iden3
            // 
            this.radioButton_iden3.AutoSize = true;
            this.radioButton_iden3.Location = new System.Drawing.Point(225, 18);
            this.radioButton_iden3.Name = "radioButton_iden3";
            this.radioButton_iden3.Size = new System.Drawing.Size(85, 28);
            this.radioButton_iden3.TabIndex = 16;
            this.radioButton_iden3.TabStop = true;
            this.radioButton_iden3.Text = "讲师";
            this.radioButton_iden3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(132, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 51);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 17);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(60, 28);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "男";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(89, 17);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(60, 28);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "女";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(333, 247);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(410, 24);
            this.label11.TabIndex = 20;
            this.label11.Text = "注：性别默认为男，职称默认为讲师";
            // 
            // button_clear
            // 
            this.button_clear.BackColor = System.Drawing.Color.LightSalmon;
            this.button_clear.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear.Location = new System.Drawing.Point(811, 106);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(151, 60);
            this.button_clear.TabIndex = 19;
            this.button_clear.Text = "Clear all";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_insert
            // 
            this.button_insert.BackColor = System.Drawing.Color.LightSalmon;
            this.button_insert.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_insert.Location = new System.Drawing.Point(811, 191);
            this.button_insert.Name = "button_insert";
            this.button_insert.Size = new System.Drawing.Size(151, 60);
            this.button_insert.TabIndex = 18;
            this.button_insert.Text = "Insert";
            this.button_insert.UseVisualStyleBackColor = false;
            this.button_insert.Click += new System.EventHandler(this.button_insert_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(324, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 33);
            this.label7.TabIndex = 17;
            this.label7.Text = "Salary";
            // 
            // textBox_salary
            // 
            this.textBox_salary.BackColor = System.Drawing.Color.LightSalmon;
            this.textBox_salary.Location = new System.Drawing.Point(454, 156);
            this.textBox_salary.Name = "textBox_salary";
            this.textBox_salary.Size = new System.Drawing.Size(100, 34);
            this.textBox_salary.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(337, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 33);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tage";
            // 
            // textBox_tage
            // 
            this.textBox_tage.BackColor = System.Drawing.Color.LightSalmon;
            this.textBox_tage.Location = new System.Drawing.Point(454, 96);
            this.textBox_tage.Name = "textBox_tage";
            this.textBox_tage.Size = new System.Drawing.Size(100, 34);
            this.textBox_tage.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(331, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 33);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tiden";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 33);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tdept";
            // 
            // textBox_tdept
            // 
            this.textBox_tdept.BackColor = System.Drawing.Color.LightSalmon;
            this.textBox_tdept.Location = new System.Drawing.Point(132, 227);
            this.textBox_tdept.Name = "textBox_tdept";
            this.textBox_tdept.Size = new System.Drawing.Size(100, 34);
            this.textBox_tdept.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tsex";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tno";
            // 
            // textBox_tname
            // 
            this.textBox_tname.BackColor = System.Drawing.Color.LightSalmon;
            this.textBox_tname.Location = new System.Drawing.Point(132, 103);
            this.textBox_tname.Name = "textBox_tname";
            this.textBox_tname.Size = new System.Drawing.Size(100, 34);
            this.textBox_tname.TabIndex = 1;
            // 
            // textBox_tno
            // 
            this.textBox_tno.BackColor = System.Drawing.Color.LightSalmon;
            this.textBox_tno.Location = new System.Drawing.Point(132, 46);
            this.textBox_tno.Name = "textBox_tno";
            this.textBox_tno.Size = new System.Drawing.Size(100, 34);
            this.textBox_tno.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button_delete);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage2.Location = new System.Drawing.Point(4, 61);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1017, 343);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "删除教师信息";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.LightSalmon;
            this.button_delete.Font = new System.Drawing.Font("Kristen ITC", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.Location = new System.Drawing.Point(411, 180);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(171, 60);
            this.button_delete.TabIndex = 1;
            this.button_delete.Text = "delete";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(245, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(510, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "在上面的表中，选中想要删除的行，进行删除";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.textBox_update_item);
            this.tabPage3.Controls.Add(this.textBox_update_by_tno);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.comboBox1);
            this.tabPage3.Controls.Add(this.button_update);
            this.tabPage3.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage3.Location = new System.Drawing.Point(4, 61);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1017, 343);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "修改教师信息";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSalmon;
            this.button1.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(801, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 55);
            this.button1.TabIndex = 6;
            this.button1.Text = "Clear all";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(197, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 33);
            this.label10.TabIndex = 5;
            this.label10.Text = "Tno";
            // 
            // textBox_update_item
            // 
            this.textBox_update_item.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_update_item.ForeColor = System.Drawing.Color.LightSalmon;
            this.textBox_update_item.Location = new System.Drawing.Point(575, 167);
            this.textBox_update_item.Name = "textBox_update_item";
            this.textBox_update_item.Size = new System.Drawing.Size(124, 40);
            this.textBox_update_item.TabIndex = 4;
            // 
            // textBox_update_by_tno
            // 
            this.textBox_update_by_tno.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_update_by_tno.ForeColor = System.Drawing.Color.LightSalmon;
            this.textBox_update_by_tno.Location = new System.Drawing.Point(355, 83);
            this.textBox_update_by_tno.Name = "textBox_update_by_tno";
            this.textBox_update_by_tno.Size = new System.Drawing.Size(129, 40);
            this.textBox_update_by_tno.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(159, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 24);
            this.label9.TabIndex = 2;
            this.label9.Text = "选择修改项";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.LightSalmon;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Tname",
            "Tsex",
            "Tdept",
            "Tiden",
            "Tage",
            "Salary"});
            this.comboBox1.Location = new System.Drawing.Point(355, 167);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 41);
            this.comboBox1.TabIndex = 1;
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.LightSalmon;
            this.button_update.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.Location = new System.Drawing.Point(801, 225);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(152, 55);
            this.button_update.TabIndex = 0;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button_show_all);
            this.tabPage4.Controls.Add(this.button_clear_select);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.checkBox_salary);
            this.tabPage4.Controls.Add(this.checkBox_tage);
            this.tabPage4.Controls.Add(this.comboBox3);
            this.tabPage4.Controls.Add(this.checkBox_tiden);
            this.tabPage4.Controls.Add(this.checkBox_tdept);
            this.tabPage4.Controls.Add(this.comboBox2);
            this.tabPage4.Controls.Add(this.checkBox_tsex);
            this.tabPage4.Controls.Add(this.checkBox_tname);
            this.tabPage4.Controls.Add(this.checkBox_tno);
            this.tabPage4.Controls.Add(this.textBox_tdept_select);
            this.tabPage4.Controls.Add(this.textBox_salary_select);
            this.tabPage4.Controls.Add(this.textBox_tage_select);
            this.tabPage4.Controls.Add(this.textBox_tname_select);
            this.tabPage4.Controls.Add(this.textBox_tno_select);
            this.tabPage4.Controls.Add(this.button_select);
            this.tabPage4.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage4.Location = new System.Drawing.Point(4, 61);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1017, 343);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "查看教师信息";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button_show_all
            // 
            this.button_show_all.BackColor = System.Drawing.Color.LightSalmon;
            this.button_show_all.Font = new System.Drawing.Font("Kristen ITC", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_show_all.Location = new System.Drawing.Point(835, 158);
            this.button_show_all.Name = "button_show_all";
            this.button_show_all.Size = new System.Drawing.Size(162, 61);
            this.button_show_all.TabIndex = 20;
            this.button_show_all.Text = "Show ALL";
            this.button_show_all.UseVisualStyleBackColor = false;
            this.button_show_all.Click += new System.EventHandler(this.button_show_all_Click);
            // 
            // button_clear_select
            // 
            this.button_clear_select.BackColor = System.Drawing.Color.LightSalmon;
            this.button_clear_select.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear_select.Location = new System.Drawing.Point(835, 241);
            this.button_clear_select.Name = "button_clear_select";
            this.button_clear_select.Size = new System.Drawing.Size(162, 61);
            this.button_clear_select.TabIndex = 19;
            this.button_clear_select.Text = "Clear all";
            this.button_clear_select.UseVisualStyleBackColor = false;
            this.button_clear_select.Click += new System.EventHandler(this.button_clear_select_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(729, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(235, 72);
            this.label12.TabIndex = 18;
            this.label12.Text = "勾选查询依据项\r\n并填写查询的内容\r\n该系统支持模糊查询";
            // 
            // checkBox_salary
            // 
            this.checkBox_salary.AutoSize = true;
            this.checkBox_salary.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_salary.Location = new System.Drawing.Point(359, 177);
            this.checkBox_salary.Name = "checkBox_salary";
            this.checkBox_salary.Size = new System.Drawing.Size(116, 37);
            this.checkBox_salary.TabIndex = 17;
            this.checkBox_salary.Text = "Salary";
            this.checkBox_salary.UseVisualStyleBackColor = true;
            // 
            // checkBox_tage
            // 
            this.checkBox_tage.AutoSize = true;
            this.checkBox_tage.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_tage.Location = new System.Drawing.Point(359, 102);
            this.checkBox_tage.Name = "checkBox_tage";
            this.checkBox_tage.Size = new System.Drawing.Size(102, 37);
            this.checkBox_tage.TabIndex = 16;
            this.checkBox_tage.Text = "Tage";
            this.checkBox_tage.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "教授",
            "副教授",
            "讲师"});
            this.comboBox3.Location = new System.Drawing.Point(504, 35);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(137, 41);
            this.comboBox3.TabIndex = 15;
            // 
            // checkBox_tiden
            // 
            this.checkBox_tiden.AutoSize = true;
            this.checkBox_tiden.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_tiden.Location = new System.Drawing.Point(359, 33);
            this.checkBox_tiden.Name = "checkBox_tiden";
            this.checkBox_tiden.Size = new System.Drawing.Size(113, 37);
            this.checkBox_tiden.TabIndex = 14;
            this.checkBox_tiden.Text = "Tiden";
            this.checkBox_tiden.UseVisualStyleBackColor = true;
            // 
            // checkBox_tdept
            // 
            this.checkBox_tdept.AutoSize = true;
            this.checkBox_tdept.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_tdept.Location = new System.Drawing.Point(41, 229);
            this.checkBox_tdept.Name = "checkBox_tdept";
            this.checkBox_tdept.Size = new System.Drawing.Size(117, 37);
            this.checkBox_tdept.TabIndex = 13;
            this.checkBox_tdept.Text = "Tdept";
            this.checkBox_tdept.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "男",
            "女"});
            this.comboBox2.Location = new System.Drawing.Point(171, 166);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(147, 41);
            this.comboBox2.TabIndex = 12;
            // 
            // checkBox_tsex
            // 
            this.checkBox_tsex.AutoSize = true;
            this.checkBox_tsex.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_tsex.Location = new System.Drawing.Point(41, 162);
            this.checkBox_tsex.Name = "checkBox_tsex";
            this.checkBox_tsex.Size = new System.Drawing.Size(101, 37);
            this.checkBox_tsex.TabIndex = 11;
            this.checkBox_tsex.Text = "Tsex";
            this.checkBox_tsex.UseVisualStyleBackColor = true;
            // 
            // checkBox_tname
            // 
            this.checkBox_tname.AutoSize = true;
            this.checkBox_tname.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_tname.Location = new System.Drawing.Point(41, 102);
            this.checkBox_tname.Name = "checkBox_tname";
            this.checkBox_tname.Size = new System.Drawing.Size(124, 37);
            this.checkBox_tname.TabIndex = 10;
            this.checkBox_tname.Text = "Tname";
            this.checkBox_tname.UseVisualStyleBackColor = true;
            // 
            // checkBox_tno
            // 
            this.checkBox_tno.AutoSize = true;
            this.checkBox_tno.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_tno.Location = new System.Drawing.Point(41, 32);
            this.checkBox_tno.Name = "checkBox_tno";
            this.checkBox_tno.Size = new System.Drawing.Size(91, 37);
            this.checkBox_tno.TabIndex = 9;
            this.checkBox_tno.Text = "Tno";
            this.checkBox_tno.UseVisualStyleBackColor = true;
            // 
            // textBox_tdept_select
            // 
            this.textBox_tdept_select.BackColor = System.Drawing.Color.LightSalmon;
            this.textBox_tdept_select.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_tdept_select.Location = new System.Drawing.Point(171, 232);
            this.textBox_tdept_select.Name = "textBox_tdept_select";
            this.textBox_tdept_select.Size = new System.Drawing.Size(126, 40);
            this.textBox_tdept_select.TabIndex = 8;
            // 
            // textBox_salary_select
            // 
            this.textBox_salary_select.BackColor = System.Drawing.Color.LightSalmon;
            this.textBox_salary_select.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_salary_select.Location = new System.Drawing.Point(504, 174);
            this.textBox_salary_select.Name = "textBox_salary_select";
            this.textBox_salary_select.Size = new System.Drawing.Size(116, 40);
            this.textBox_salary_select.TabIndex = 7;
            // 
            // textBox_tage_select
            // 
            this.textBox_tage_select.BackColor = System.Drawing.Color.LightSalmon;
            this.textBox_tage_select.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_tage_select.Location = new System.Drawing.Point(504, 105);
            this.textBox_tage_select.Name = "textBox_tage_select";
            this.textBox_tage_select.Size = new System.Drawing.Size(116, 40);
            this.textBox_tage_select.TabIndex = 6;
            // 
            // textBox_tname_select
            // 
            this.textBox_tname_select.BackColor = System.Drawing.Color.LightSalmon;
            this.textBox_tname_select.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_tname_select.Location = new System.Drawing.Point(171, 105);
            this.textBox_tname_select.Name = "textBox_tname_select";
            this.textBox_tname_select.Size = new System.Drawing.Size(126, 40);
            this.textBox_tname_select.TabIndex = 3;
            // 
            // textBox_tno_select
            // 
            this.textBox_tno_select.BackColor = System.Drawing.Color.LightSalmon;
            this.textBox_tno_select.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_tno_select.Location = new System.Drawing.Point(171, 34);
            this.textBox_tno_select.Name = "textBox_tno_select";
            this.textBox_tno_select.Size = new System.Drawing.Size(126, 40);
            this.textBox_tno_select.TabIndex = 2;
            // 
            // button_select
            // 
            this.button_select.BackColor = System.Drawing.Color.LightSalmon;
            this.button_select.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_select.Location = new System.Drawing.Point(648, 241);
            this.button_select.Name = "button_select";
            this.button_select.Size = new System.Drawing.Size(162, 61);
            this.button_select.TabIndex = 1;
            this.button_select.Text = "select";
            this.button_select.UseVisualStyleBackColor = false;
            this.button_select.Click += new System.EventHandler(this.button_select_Click);
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_back.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_back.Location = new System.Drawing.Point(1153, 551);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(171, 61);
            this.button_back.TabIndex = 21;
            this.button_back.Text = "BACK";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click_1);
            // 
            // FormTeacher_M
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1384, 794);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormTeacher_M";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacher Info Management";
            this.Load += new System.EventHandler(this.FormTeacher_M_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private schoolDataSet2 schoolDataSet2;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private schoolDataSet2TableAdapters.TeacherTableAdapter teacherTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tsexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdeptDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tidenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button_insert;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_salary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_tage;
        private System.Windows.Forms.RadioButton radioButton_iden3;
        private System.Windows.Forms.RadioButton radioButton_iden2;
        private System.Windows.Forms.RadioButton radioButton_iden1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_tdept;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_tname;
        private System.Windows.Forms.TextBox textBox_tno;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_update_item;
        private System.Windows.Forms.TextBox textBox_update_by_tno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkBox_salary;
        private System.Windows.Forms.CheckBox checkBox_tage;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.CheckBox checkBox_tiden;
        private System.Windows.Forms.CheckBox checkBox_tdept;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.CheckBox checkBox_tsex;
        private System.Windows.Forms.CheckBox checkBox_tname;
        private System.Windows.Forms.CheckBox checkBox_tno;
        private System.Windows.Forms.TextBox textBox_tdept_select;
        private System.Windows.Forms.TextBox textBox_salary_select;
        private System.Windows.Forms.TextBox textBox_tage_select;
        private System.Windows.Forms.TextBox textBox_tname_select;
        private System.Windows.Forms.TextBox textBox_tno_select;
        private System.Windows.Forms.Button button_select;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button_show_all;
        private System.Windows.Forms.Button button_clear_select;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;

        public string userid;
    }
}