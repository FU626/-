namespace 登录
{
    partial class FormUpdate
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
            this.button_update = new System.Windows.Forms.Button();
            this.textBox_sdept = new System.Windows.Forms.TextBox();
            this.textBox_sage = new System.Windows.Forms.TextBox();
            this.textBox_ssex = new System.Windows.Forms.TextBox();
            this.textBox_sname = new System.Windows.Forms.TextBox();
            this.label_sdept = new System.Windows.Forms.Label();
            this.label_sage = new System.Windows.Forms.Label();
            this.label_ssex = new System.Windows.Forms.Label();
            this.label_sname = new System.Windows.Forms.Label();
            this.label_sno = new System.Windows.Forms.Label();
            this.textBox_sno = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ssexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdeptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolDataSet = new 登录.schoolDataSet();
            this.checkBox_sname = new System.Windows.Forms.CheckBox();
            this.checkBox_sage = new System.Windows.Forms.CheckBox();
            this.checkBox_ssex = new System.Windows.Forms.CheckBox();
            this.checkBox_sdept = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.studentTableAdapter = new 登录.schoolDataSetTableAdapters.StudentTableAdapter();
            this.button_BACK = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonclear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.FloralWhite;
            this.button_update.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.ForeColor = System.Drawing.Color.OrangeRed;
            this.button_update.Location = new System.Drawing.Point(975, 396);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(132, 55);
            this.button_update.TabIndex = 9;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // textBox_sdept
            // 
            this.textBox_sdept.BackColor = System.Drawing.Color.White;
            this.textBox_sdept.Font = new System.Drawing.Font("Segoe Script", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_sdept.Location = new System.Drawing.Point(1061, 311);
            this.textBox_sdept.Name = "textBox_sdept";
            this.textBox_sdept.Size = new System.Drawing.Size(100, 41);
            this.textBox_sdept.TabIndex = 30;
            // 
            // textBox_sage
            // 
            this.textBox_sage.BackColor = System.Drawing.Color.White;
            this.textBox_sage.Font = new System.Drawing.Font("Segoe Script", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_sage.Location = new System.Drawing.Point(1061, 204);
            this.textBox_sage.Name = "textBox_sage";
            this.textBox_sage.Size = new System.Drawing.Size(100, 41);
            this.textBox_sage.TabIndex = 29;
            // 
            // textBox_ssex
            // 
            this.textBox_ssex.BackColor = System.Drawing.Color.White;
            this.textBox_ssex.Font = new System.Drawing.Font("Segoe Script", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ssex.Location = new System.Drawing.Point(914, 311);
            this.textBox_ssex.Name = "textBox_ssex";
            this.textBox_ssex.Size = new System.Drawing.Size(100, 41);
            this.textBox_ssex.TabIndex = 28;
            // 
            // textBox_sname
            // 
            this.textBox_sname.BackColor = System.Drawing.Color.White;
            this.textBox_sname.Font = new System.Drawing.Font("Segoe Script", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_sname.Location = new System.Drawing.Point(914, 204);
            this.textBox_sname.Name = "textBox_sname";
            this.textBox_sname.Size = new System.Drawing.Size(100, 41);
            this.textBox_sname.TabIndex = 27;
            // 
            // label_sdept
            // 
            this.label_sdept.AutoSize = true;
            this.label_sdept.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sdept.ForeColor = System.Drawing.Color.OrangeRed;
            this.label_sdept.Location = new System.Drawing.Point(1067, 261);
            this.label_sdept.Name = "label_sdept";
            this.label_sdept.Size = new System.Drawing.Size(89, 38);
            this.label_sdept.TabIndex = 26;
            this.label_sdept.Text = "Sdept";
            // 
            // label_sage
            // 
            this.label_sage.AutoSize = true;
            this.label_sage.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sage.ForeColor = System.Drawing.Color.OrangeRed;
            this.label_sage.Location = new System.Drawing.Point(1074, 154);
            this.label_sage.Name = "label_sage";
            this.label_sage.Size = new System.Drawing.Size(74, 38);
            this.label_sage.TabIndex = 25;
            this.label_sage.Text = "Sage";
            // 
            // label_ssex
            // 
            this.label_ssex.AutoSize = true;
            this.label_ssex.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ssex.ForeColor = System.Drawing.Color.OrangeRed;
            this.label_ssex.Location = new System.Drawing.Point(930, 261);
            this.label_ssex.Name = "label_ssex";
            this.label_ssex.Size = new System.Drawing.Size(72, 38);
            this.label_ssex.TabIndex = 24;
            this.label_ssex.Text = "Ssex";
            // 
            // label_sname
            // 
            this.label_sname.AutoSize = true;
            this.label_sname.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sname.ForeColor = System.Drawing.Color.OrangeRed;
            this.label_sname.Location = new System.Drawing.Point(913, 154);
            this.label_sname.Name = "label_sname";
            this.label_sname.Size = new System.Drawing.Size(103, 38);
            this.label_sname.TabIndex = 23;
            this.label_sname.Text = "Sname";
            // 
            // label_sno
            // 
            this.label_sno.AutoSize = true;
            this.label_sno.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sno.ForeColor = System.Drawing.Color.OrangeRed;
            this.label_sno.Location = new System.Drawing.Point(948, 50);
            this.label_sno.Name = "label_sno";
            this.label_sno.Size = new System.Drawing.Size(63, 38);
            this.label_sno.TabIndex = 22;
            this.label_sno.Text = "Sno";
            // 
            // textBox_sno
            // 
            this.textBox_sno.BackColor = System.Drawing.Color.NavajoWhite;
            this.textBox_sno.Font = new System.Drawing.Font("Segoe Script", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_sno.Location = new System.Drawing.Point(1017, 50);
            this.textBox_sno.Name = "textBox_sno";
            this.textBox_sno.Size = new System.Drawing.Size(100, 41);
            this.textBox_sno.TabIndex = 21;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gold;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snoDataGridViewTextBoxColumn,
            this.snameDataGridViewTextBoxColumn,
            this.ssexDataGridViewTextBoxColumn,
            this.sageDataGridViewTextBoxColumn,
            this.sdeptDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(839, 439);
            this.dataGridView1.TabIndex = 31;
            // 
            // snoDataGridViewTextBoxColumn
            // 
            this.snoDataGridViewTextBoxColumn.DataPropertyName = "Sno";
            this.snoDataGridViewTextBoxColumn.HeaderText = "Sno";
            this.snoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.snoDataGridViewTextBoxColumn.Name = "snoDataGridViewTextBoxColumn";
            this.snoDataGridViewTextBoxColumn.Width = 150;
            // 
            // snameDataGridViewTextBoxColumn
            // 
            this.snameDataGridViewTextBoxColumn.DataPropertyName = "Sname";
            this.snameDataGridViewTextBoxColumn.HeaderText = "Sname";
            this.snameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.snameDataGridViewTextBoxColumn.Name = "snameDataGridViewTextBoxColumn";
            this.snameDataGridViewTextBoxColumn.Width = 150;
            // 
            // ssexDataGridViewTextBoxColumn
            // 
            this.ssexDataGridViewTextBoxColumn.DataPropertyName = "Ssex";
            this.ssexDataGridViewTextBoxColumn.HeaderText = "Ssex";
            this.ssexDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ssexDataGridViewTextBoxColumn.Name = "ssexDataGridViewTextBoxColumn";
            this.ssexDataGridViewTextBoxColumn.Width = 150;
            // 
            // sageDataGridViewTextBoxColumn
            // 
            this.sageDataGridViewTextBoxColumn.DataPropertyName = "Sage";
            this.sageDataGridViewTextBoxColumn.HeaderText = "Sage";
            this.sageDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sageDataGridViewTextBoxColumn.Name = "sageDataGridViewTextBoxColumn";
            this.sageDataGridViewTextBoxColumn.Width = 150;
            // 
            // sdeptDataGridViewTextBoxColumn
            // 
            this.sdeptDataGridViewTextBoxColumn.DataPropertyName = "Sdept";
            this.sdeptDataGridViewTextBoxColumn.HeaderText = "Sdept";
            this.sdeptDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sdeptDataGridViewTextBoxColumn.Name = "sdeptDataGridViewTextBoxColumn";
            this.sdeptDataGridViewTextBoxColumn.Width = 150;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.schoolDataSet;
            // 
            // schoolDataSet
            // 
            this.schoolDataSet.DataSetName = "schoolDataSet";
            this.schoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // checkBox_sname
            // 
            this.checkBox_sname.AutoSize = true;
            this.checkBox_sname.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_sname.Location = new System.Drawing.Point(885, 164);
            this.checkBox_sname.Name = "checkBox_sname";
            this.checkBox_sname.Size = new System.Drawing.Size(22, 21);
            this.checkBox_sname.TabIndex = 32;
            this.checkBox_sname.UseVisualStyleBackColor = true;
            // 
            // checkBox_sage
            // 
            this.checkBox_sage.AutoSize = true;
            this.checkBox_sage.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_sage.ForeColor = System.Drawing.Color.OrangeRed;
            this.checkBox_sage.Location = new System.Drawing.Point(1046, 164);
            this.checkBox_sage.Name = "checkBox_sage";
            this.checkBox_sage.Size = new System.Drawing.Size(22, 21);
            this.checkBox_sage.TabIndex = 33;
            this.checkBox_sage.UseVisualStyleBackColor = true;
            // 
            // checkBox_ssex
            // 
            this.checkBox_ssex.AutoSize = true;
            this.checkBox_ssex.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_ssex.Location = new System.Drawing.Point(885, 271);
            this.checkBox_ssex.Name = "checkBox_ssex";
            this.checkBox_ssex.Size = new System.Drawing.Size(22, 21);
            this.checkBox_ssex.TabIndex = 34;
            this.checkBox_ssex.UseVisualStyleBackColor = true;
            // 
            // checkBox_sdept
            // 
            this.checkBox_sdept.AutoSize = true;
            this.checkBox_sdept.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_sdept.ForeColor = System.Drawing.Color.OrangeRed;
            this.checkBox_sdept.Location = new System.Drawing.Point(1046, 271);
            this.checkBox_sdept.Name = "checkBox_sdept";
            this.checkBox_sdept.Size = new System.Drawing.Size(22, 21);
            this.checkBox_sdept.TabIndex = 35;
            this.checkBox_sdept.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Viner Hand ITC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(101, 454);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 45);
            this.label1.TabIndex = 36;
            this.label1.Text = "Tips：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("华文彩云", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(220, 494);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(490, 24);
            this.label2.TabIndex = 37;
            this.label2.Text = "输入更改学生的学号，选择并输入更改的信息";
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // button_BACK
            // 
            this.button_BACK.BackColor = System.Drawing.Color.FloralWhite;
            this.button_BACK.Font = new System.Drawing.Font("Viner Hand ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_BACK.ForeColor = System.Drawing.Color.OrangeRed;
            this.button_BACK.Location = new System.Drawing.Point(1024, 513);
            this.button_BACK.Name = "button_BACK";
            this.button_BACK.Size = new System.Drawing.Size(132, 55);
            this.button_BACK.TabIndex = 38;
            this.button_BACK.Text = "BACK";
            this.button_BACK.UseVisualStyleBackColor = false;
            this.button_BACK.Click += new System.EventHandler(this.button_BACK_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("华文彩云", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(356, 544);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 24);
            this.label4.TabIndex = 40;
            this.label4.Text = "可以选择多项";
            // 
            // buttonclear
            // 
            this.buttonclear.BackColor = System.Drawing.Color.FloralWhite;
            this.buttonclear.Font = new System.Drawing.Font("Segoe Script", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonclear.ForeColor = System.Drawing.Color.OrangeRed;
            this.buttonclear.Location = new System.Drawing.Point(852, 513);
            this.buttonclear.Name = "buttonclear";
            this.buttonclear.Size = new System.Drawing.Size(132, 55);
            this.buttonclear.TabIndex = 41;
            this.buttonclear.Text = "Clear All";
            this.buttonclear.UseVisualStyleBackColor = false;
            this.buttonclear.Click += new System.EventHandler(this.buttonclear_Click);
            // 
            // FormUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(1173, 589);
            this.Controls.Add(this.buttonclear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_BACK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox_sdept);
            this.Controls.Add(this.checkBox_ssex);
            this.Controls.Add(this.checkBox_sage);
            this.Controls.Add(this.checkBox_sname);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox_sdept);
            this.Controls.Add(this.textBox_sage);
            this.Controls.Add(this.textBox_ssex);
            this.Controls.Add(this.textBox_sname);
            this.Controls.Add(this.label_sdept);
            this.Controls.Add(this.label_sage);
            this.Controls.Add(this.label_ssex);
            this.Controls.Add(this.label_sname);
            this.Controls.Add(this.label_sno);
            this.Controls.Add(this.textBox_sno);
            this.Controls.Add(this.button_update);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "FormUpdate";
            this.Text = "修改学生信息";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormUpdate_FormClosed);
            this.Load += new System.EventHandler(this.FormUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.TextBox textBox_sdept;
        private System.Windows.Forms.TextBox textBox_sage;
        private System.Windows.Forms.TextBox textBox_ssex;
        private System.Windows.Forms.TextBox textBox_sname;
        private System.Windows.Forms.Label label_sdept;
        private System.Windows.Forms.Label label_sage;
        private System.Windows.Forms.Label label_ssex;
        private System.Windows.Forms.Label label_sname;
        private System.Windows.Forms.Label label_sno;
        private System.Windows.Forms.TextBox textBox_sno;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox checkBox_sname;
        private System.Windows.Forms.CheckBox checkBox_sage;
        private System.Windows.Forms.CheckBox checkBox_ssex;
        private System.Windows.Forms.CheckBox checkBox_sdept;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private schoolDataSet schoolDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private schoolDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ssexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdeptDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button_BACK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonclear;

        public string userid;
    }
}