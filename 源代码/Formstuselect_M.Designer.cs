namespace 登录
{
    partial class FormSelect
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
            this.button_BACK = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ssexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdeptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolDataSet = new 登录.schoolDataSet();
            this.studentTableAdapter = new 登录.schoolDataSetTableAdapters.StudentTableAdapter();
            this.buttonall = new System.Windows.Forms.Button();
            this.checkBox_sdept = new System.Windows.Forms.CheckBox();
            this.checkBox_ssex = new System.Windows.Forms.CheckBox();
            this.checkBox_sage = new System.Windows.Forms.CheckBox();
            this.checkBox_sname = new System.Windows.Forms.CheckBox();
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
            this.checkBox_sno = new System.Windows.Forms.CheckBox();
            this.button_select = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button_BACK
            // 
            this.button_BACK.BackColor = System.Drawing.Color.IndianRed;
            this.button_BACK.Font = new System.Drawing.Font("Matura MT Script Capitals", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_BACK.Location = new System.Drawing.Point(881, 458);
            this.button_BACK.Name = "button_BACK";
            this.button_BACK.Size = new System.Drawing.Size(132, 55);
            this.button_BACK.TabIndex = 40;
            this.button_BACK.Text = "BACK";
            this.button_BACK.UseVisualStyleBackColor = false;
            this.button_BACK.Click += new System.EventHandler(this.button_BACK_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Bisque;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snoDataGridViewTextBoxColumn,
            this.snameDataGridViewTextBoxColumn,
            this.ssexDataGridViewTextBoxColumn,
            this.sageDataGridViewTextBoxColumn,
            this.sdeptDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 181);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(816, 332);
            this.dataGridView1.TabIndex = 42;
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
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // buttonall
            // 
            this.buttonall.BackColor = System.Drawing.Color.IndianRed;
            this.buttonall.Font = new System.Drawing.Font("Matura MT Script Capitals", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonall.ForeColor = System.Drawing.Color.LightYellow;
            this.buttonall.Location = new System.Drawing.Point(881, 280);
            this.buttonall.Name = "buttonall";
            this.buttonall.Size = new System.Drawing.Size(132, 87);
            this.buttonall.TabIndex = 43;
            this.buttonall.Text = "Show All";
            this.buttonall.UseVisualStyleBackColor = false;
            this.buttonall.Click += new System.EventHandler(this.buttonall_Click);
            // 
            // checkBox_sdept
            // 
            this.checkBox_sdept.AutoSize = true;
            this.checkBox_sdept.Font = new System.Drawing.Font("Matura MT Script Capitals", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_sdept.ForeColor = System.Drawing.Color.LightYellow;
            this.checkBox_sdept.Location = new System.Drawing.Point(835, 43);
            this.checkBox_sdept.Name = "checkBox_sdept";
            this.checkBox_sdept.Size = new System.Drawing.Size(22, 21);
            this.checkBox_sdept.TabIndex = 57;
            this.checkBox_sdept.UseVisualStyleBackColor = true;
            // 
            // checkBox_ssex
            // 
            this.checkBox_ssex.AutoSize = true;
            this.checkBox_ssex.Font = new System.Drawing.Font("Matura MT Script Capitals", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_ssex.ForeColor = System.Drawing.Color.LightYellow;
            this.checkBox_ssex.Location = new System.Drawing.Point(673, 44);
            this.checkBox_ssex.Name = "checkBox_ssex";
            this.checkBox_ssex.Size = new System.Drawing.Size(22, 21);
            this.checkBox_ssex.TabIndex = 56;
            this.checkBox_ssex.UseVisualStyleBackColor = true;
            // 
            // checkBox_sage
            // 
            this.checkBox_sage.AutoSize = true;
            this.checkBox_sage.Font = new System.Drawing.Font("Matura MT Script Capitals", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_sage.ForeColor = System.Drawing.Color.LightYellow;
            this.checkBox_sage.Location = new System.Drawing.Point(497, 43);
            this.checkBox_sage.Name = "checkBox_sage";
            this.checkBox_sage.Size = new System.Drawing.Size(22, 21);
            this.checkBox_sage.TabIndex = 55;
            this.checkBox_sage.UseVisualStyleBackColor = true;
            // 
            // checkBox_sname
            // 
            this.checkBox_sname.AutoSize = true;
            this.checkBox_sname.Font = new System.Drawing.Font("Matura MT Script Capitals", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_sname.ForeColor = System.Drawing.Color.LightYellow;
            this.checkBox_sname.Location = new System.Drawing.Point(301, 43);
            this.checkBox_sname.Name = "checkBox_sname";
            this.checkBox_sname.Size = new System.Drawing.Size(22, 21);
            this.checkBox_sname.TabIndex = 54;
            this.checkBox_sname.UseVisualStyleBackColor = true;
            // 
            // textBox_sdept
            // 
            this.textBox_sdept.BackColor = System.Drawing.Color.MistyRose;
            this.textBox_sdept.Font = new System.Drawing.Font("Segoe Script", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_sdept.Location = new System.Drawing.Point(845, 90);
            this.textBox_sdept.Name = "textBox_sdept";
            this.textBox_sdept.Size = new System.Drawing.Size(100, 41);
            this.textBox_sdept.TabIndex = 53;
            // 
            // textBox_sage
            // 
            this.textBox_sage.BackColor = System.Drawing.Color.MistyRose;
            this.textBox_sage.Font = new System.Drawing.Font("Segoe Script", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_sage.Location = new System.Drawing.Point(494, 90);
            this.textBox_sage.Name = "textBox_sage";
            this.textBox_sage.Size = new System.Drawing.Size(100, 41);
            this.textBox_sage.TabIndex = 52;
            // 
            // textBox_ssex
            // 
            this.textBox_ssex.BackColor = System.Drawing.Color.MistyRose;
            this.textBox_ssex.Font = new System.Drawing.Font("Segoe Script", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ssex.Location = new System.Drawing.Point(682, 90);
            this.textBox_ssex.Name = "textBox_ssex";
            this.textBox_ssex.Size = new System.Drawing.Size(100, 41);
            this.textBox_ssex.TabIndex = 51;
            // 
            // textBox_sname
            // 
            this.textBox_sname.BackColor = System.Drawing.Color.MistyRose;
            this.textBox_sname.Font = new System.Drawing.Font("Segoe Script", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_sname.Location = new System.Drawing.Point(320, 90);
            this.textBox_sname.Name = "textBox_sname";
            this.textBox_sname.Size = new System.Drawing.Size(100, 41);
            this.textBox_sname.TabIndex = 50;
            // 
            // label_sdept
            // 
            this.label_sdept.AutoSize = true;
            this.label_sdept.Font = new System.Drawing.Font("Matura MT Script Capitals", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sdept.ForeColor = System.Drawing.Color.LightYellow;
            this.label_sdept.Location = new System.Drawing.Point(856, 34);
            this.label_sdept.Name = "label_sdept";
            this.label_sdept.Size = new System.Drawing.Size(90, 37);
            this.label_sdept.TabIndex = 49;
            this.label_sdept.Text = "Sdept";
            // 
            // label_sage
            // 
            this.label_sage.AutoSize = true;
            this.label_sage.Font = new System.Drawing.Font("Matura MT Script Capitals", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sage.ForeColor = System.Drawing.Color.LightYellow;
            this.label_sage.Location = new System.Drawing.Point(525, 34);
            this.label_sage.Name = "label_sage";
            this.label_sage.Size = new System.Drawing.Size(81, 37);
            this.label_sage.TabIndex = 48;
            this.label_sage.Text = "Sage";
            // 
            // label_ssex
            // 
            this.label_ssex.AutoSize = true;
            this.label_ssex.Font = new System.Drawing.Font("Matura MT Script Capitals", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ssex.ForeColor = System.Drawing.Color.LightYellow;
            this.label_ssex.Location = new System.Drawing.Point(701, 34);
            this.label_ssex.Name = "label_ssex";
            this.label_ssex.Size = new System.Drawing.Size(81, 37);
            this.label_ssex.TabIndex = 47;
            this.label_ssex.Text = "Ssex";
            // 
            // label_sname
            // 
            this.label_sname.AutoSize = true;
            this.label_sname.Font = new System.Drawing.Font("Matura MT Script Capitals", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sname.ForeColor = System.Drawing.Color.LightYellow;
            this.label_sname.Location = new System.Drawing.Point(329, 34);
            this.label_sname.Name = "label_sname";
            this.label_sname.Size = new System.Drawing.Size(101, 37);
            this.label_sname.TabIndex = 46;
            this.label_sname.Text = "Sname";
            // 
            // label_sno
            // 
            this.label_sno.AutoSize = true;
            this.label_sno.Font = new System.Drawing.Font("Matura MT Script Capitals", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sno.ForeColor = System.Drawing.Color.LightYellow;
            this.label_sno.Location = new System.Drawing.Point(171, 34);
            this.label_sno.Name = "label_sno";
            this.label_sno.Size = new System.Drawing.Size(69, 37);
            this.label_sno.TabIndex = 45;
            this.label_sno.Text = "Sno";
            // 
            // textBox_sno
            // 
            this.textBox_sno.BackColor = System.Drawing.Color.MistyRose;
            this.textBox_sno.Font = new System.Drawing.Font("Segoe Script", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_sno.Location = new System.Drawing.Point(143, 90);
            this.textBox_sno.Name = "textBox_sno";
            this.textBox_sno.Size = new System.Drawing.Size(100, 41);
            this.textBox_sno.TabIndex = 44;
            // 
            // checkBox_sno
            // 
            this.checkBox_sno.AutoSize = true;
            this.checkBox_sno.Font = new System.Drawing.Font("Matura MT Script Capitals", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_sno.ForeColor = System.Drawing.Color.LightYellow;
            this.checkBox_sno.Location = new System.Drawing.Point(143, 43);
            this.checkBox_sno.Name = "checkBox_sno";
            this.checkBox_sno.Size = new System.Drawing.Size(22, 21);
            this.checkBox_sno.TabIndex = 58;
            this.checkBox_sno.UseVisualStyleBackColor = true;
            // 
            // button_select
            // 
            this.button_select.BackColor = System.Drawing.Color.IndianRed;
            this.button_select.Font = new System.Drawing.Font("Matura MT Script Capitals", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_select.ForeColor = System.Drawing.Color.LightYellow;
            this.button_select.Location = new System.Drawing.Point(881, 181);
            this.button_select.Name = "button_select";
            this.button_select.Size = new System.Drawing.Size(132, 61);
            this.button_select.TabIndex = 59;
            this.button_select.Text = "Select";
            this.button_select.UseVisualStyleBackColor = false;
            this.button_select.Click += new System.EventHandler(this.button_select_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Matura MT Script Capitals", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightYellow;
            this.label2.Location = new System.Drawing.Point(28, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 160);
            this.label2.TabIndex = 61;
            this.label2.Text = "What \r\nyou \r\nwant →\r\nto \r\nselect";
            // 
            // FormSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(1025, 545);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_select);
            this.Controls.Add(this.checkBox_sno);
            this.Controls.Add(this.checkBox_sdept);
            this.Controls.Add(this.checkBox_ssex);
            this.Controls.Add(this.checkBox_sage);
            this.Controls.Add(this.checkBox_sname);
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
            this.Controls.Add(this.buttonall);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_BACK);
            this.Name = "FormSelect";
            this.Text = "学生信息查询";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSelect_FormClosed);
            this.Load += new System.EventHandler(this.FormSelect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_BACK;
        private System.Windows.Forms.DataGridView dataGridView1;
        private schoolDataSet schoolDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private schoolDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ssexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdeptDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonall;
        private System.Windows.Forms.CheckBox checkBox_sdept;
        private System.Windows.Forms.CheckBox checkBox_ssex;
        private System.Windows.Forms.CheckBox checkBox_sage;
        private System.Windows.Forms.CheckBox checkBox_sname;
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
        private System.Windows.Forms.CheckBox checkBox_sno;
        private System.Windows.Forms.Button button_select;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}