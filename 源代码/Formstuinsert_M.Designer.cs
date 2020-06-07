namespace 登录
{
    partial class Formstuinsert_M
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
            this.snameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ssexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdeptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolDataSet = new 登录.schoolDataSet();
            this.studentTableAdapter = new 登录.schoolDataSetTableAdapters.StudentTableAdapter();
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
            this.button_insert = new System.Windows.Forms.Button();
            this.button_BACK = new System.Windows.Forms.Button();
            this.buttonclear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Purple;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snoDataGridViewTextBoxColumn,
            this.snameDataGridViewTextBoxColumn,
            this.ssexDataGridViewTextBoxColumn,
            this.sageDataGridViewTextBoxColumn,
            this.sdeptDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(47, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(1040, 464);
            this.dataGridView1.TabIndex = 2;
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
            this.studentBindingSource.DataSource = this.schoolDataSetBindingSource;
            // 
            // schoolDataSetBindingSource
            // 
            this.schoolDataSetBindingSource.DataSource = this.schoolDataSet;
            this.schoolDataSetBindingSource.Position = 0;
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
            // textBox_sdept
            // 
            this.textBox_sdept.BackColor = System.Drawing.Color.LavenderBlush;
            this.textBox_sdept.Font = new System.Drawing.Font("Segoe Script", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_sdept.Location = new System.Drawing.Point(762, 541);
            this.textBox_sdept.Name = "textBox_sdept";
            this.textBox_sdept.Size = new System.Drawing.Size(100, 41);
            this.textBox_sdept.TabIndex = 30;
            // 
            // textBox_sage
            // 
            this.textBox_sage.BackColor = System.Drawing.Color.LavenderBlush;
            this.textBox_sage.Font = new System.Drawing.Font("Segoe Script", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_sage.Location = new System.Drawing.Point(604, 541);
            this.textBox_sage.Name = "textBox_sage";
            this.textBox_sage.Size = new System.Drawing.Size(100, 41);
            this.textBox_sage.TabIndex = 29;
            // 
            // textBox_ssex
            // 
            this.textBox_ssex.BackColor = System.Drawing.Color.LavenderBlush;
            this.textBox_ssex.Font = new System.Drawing.Font("Segoe Script", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ssex.Location = new System.Drawing.Point(448, 541);
            this.textBox_ssex.Name = "textBox_ssex";
            this.textBox_ssex.Size = new System.Drawing.Size(100, 41);
            this.textBox_ssex.TabIndex = 28;
            // 
            // textBox_sname
            // 
            this.textBox_sname.BackColor = System.Drawing.Color.LavenderBlush;
            this.textBox_sname.Font = new System.Drawing.Font("Segoe Script", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_sname.Location = new System.Drawing.Point(271, 541);
            this.textBox_sname.Name = "textBox_sname";
            this.textBox_sname.Size = new System.Drawing.Size(100, 41);
            this.textBox_sname.TabIndex = 27;
            // 
            // label_sdept
            // 
            this.label_sdept.AutoSize = true;
            this.label_sdept.BackColor = System.Drawing.Color.Thistle;
            this.label_sdept.Font = new System.Drawing.Font("Segoe Script", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sdept.ForeColor = System.Drawing.Color.Crimson;
            this.label_sdept.Location = new System.Drawing.Point(759, 491);
            this.label_sdept.Name = "label_sdept";
            this.label_sdept.Size = new System.Drawing.Size(104, 44);
            this.label_sdept.TabIndex = 26;
            this.label_sdept.Text = "Sdept";
            // 
            // label_sage
            // 
            this.label_sage.AutoSize = true;
            this.label_sage.BackColor = System.Drawing.Color.Thistle;
            this.label_sage.Font = new System.Drawing.Font("Segoe Script", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sage.ForeColor = System.Drawing.Color.Crimson;
            this.label_sage.Location = new System.Drawing.Point(610, 491);
            this.label_sage.Name = "label_sage";
            this.label_sage.Size = new System.Drawing.Size(85, 44);
            this.label_sage.TabIndex = 25;
            this.label_sage.Text = "Sage";
            // 
            // label_ssex
            // 
            this.label_ssex.AutoSize = true;
            this.label_ssex.BackColor = System.Drawing.Color.Thistle;
            this.label_ssex.Font = new System.Drawing.Font("Segoe Script", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ssex.ForeColor = System.Drawing.Color.Crimson;
            this.label_ssex.Location = new System.Drawing.Point(457, 491);
            this.label_ssex.Name = "label_ssex";
            this.label_ssex.Size = new System.Drawing.Size(83, 44);
            this.label_ssex.TabIndex = 24;
            this.label_ssex.Text = "Ssex";
            // 
            // label_sname
            // 
            this.label_sname.AutoSize = true;
            this.label_sname.BackColor = System.Drawing.Color.Thistle;
            this.label_sname.Font = new System.Drawing.Font("Segoe Script", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sname.ForeColor = System.Drawing.Color.Crimson;
            this.label_sname.Location = new System.Drawing.Point(264, 491);
            this.label_sname.Name = "label_sname";
            this.label_sname.Size = new System.Drawing.Size(119, 44);
            this.label_sname.TabIndex = 23;
            this.label_sname.Text = "Sname";
            // 
            // label_sno
            // 
            this.label_sno.AutoSize = true;
            this.label_sno.BackColor = System.Drawing.Color.Thistle;
            this.label_sno.Font = new System.Drawing.Font("Segoe Script", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sno.ForeColor = System.Drawing.Color.Crimson;
            this.label_sno.Location = new System.Drawing.Point(122, 491);
            this.label_sno.Name = "label_sno";
            this.label_sno.Size = new System.Drawing.Size(73, 44);
            this.label_sno.TabIndex = 22;
            this.label_sno.Text = "Sno";
            // 
            // textBox_sno
            // 
            this.textBox_sno.BackColor = System.Drawing.Color.LavenderBlush;
            this.textBox_sno.Font = new System.Drawing.Font("Segoe Script", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_sno.Location = new System.Drawing.Point(103, 541);
            this.textBox_sno.Name = "textBox_sno";
            this.textBox_sno.Size = new System.Drawing.Size(100, 41);
            this.textBox_sno.TabIndex = 21;
            // 
            // button_insert
            // 
            this.button_insert.BackColor = System.Drawing.Color.LavenderBlush;
            this.button_insert.Font = new System.Drawing.Font("Segoe Script", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_insert.ForeColor = System.Drawing.Color.Crimson;
            this.button_insert.Location = new System.Drawing.Point(432, 610);
            this.button_insert.Name = "button_insert";
            this.button_insert.Size = new System.Drawing.Size(132, 55);
            this.button_insert.TabIndex = 31;
            this.button_insert.Text = "Insert";
            this.button_insert.UseVisualStyleBackColor = false;
            this.button_insert.Click += new System.EventHandler(this.button_insert_Click);
            // 
            // button_BACK
            // 
            this.button_BACK.BackColor = System.Drawing.Color.LavenderBlush;
            this.button_BACK.Font = new System.Drawing.Font("Viner Hand ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_BACK.Location = new System.Drawing.Point(955, 624);
            this.button_BACK.Name = "button_BACK";
            this.button_BACK.Size = new System.Drawing.Size(132, 55);
            this.button_BACK.TabIndex = 40;
            this.button_BACK.Text = "BACK";
            this.button_BACK.UseVisualStyleBackColor = false;
            this.button_BACK.Click += new System.EventHandler(this.button_BACK_Click);
            // 
            // buttonclear
            // 
            this.buttonclear.BackColor = System.Drawing.Color.LavenderBlush;
            this.buttonclear.Font = new System.Drawing.Font("Segoe Script", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonclear.ForeColor = System.Drawing.Color.Crimson;
            this.buttonclear.Location = new System.Drawing.Point(955, 524);
            this.buttonclear.Name = "buttonclear";
            this.buttonclear.Size = new System.Drawing.Size(132, 72);
            this.buttonclear.TabIndex = 41;
            this.buttonclear.Text = "clear all";
            this.buttonclear.UseVisualStyleBackColor = false;
            this.buttonclear.Click += new System.EventHandler(this.buttonclear_Click);
            // 
            // Formstuinsert_M
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1121, 687);
            this.Controls.Add(this.buttonclear);
            this.Controls.Add(this.button_BACK);
            this.Controls.Add(this.button_insert);
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
            this.Controls.Add(this.dataGridView1);
            this.Name = "Formstuinsert_M";
            this.Text = "新增学生信息";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Forminsert_FormClosed);
            this.Load += new System.EventHandler(this.Forminsert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource schoolDataSetBindingSource;
        private schoolDataSet schoolDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private schoolDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ssexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdeptDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.Button button_insert;
        private System.Windows.Forms.Button button_BACK;
        private System.Windows.Forms.Button buttonclear;

        public string userid;
    }
}