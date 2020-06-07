namespace 登录
{
    partial class FormUser_M
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
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userPassWordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userSchoolIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userMobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userBirthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdentityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userPhotoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.sysUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolDataSet1 = new 登录.schoolDataSet1();
            this.sysUserTableAdapter = new 登录.schoolDataSet1TableAdapters.SysUserTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.button_insert = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sysUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIDDataGridViewTextBoxColumn,
            this.userPassWordDataGridViewTextBoxColumn,
            this.userSchoolIDDataGridViewTextBoxColumn,
            this.userMobileDataGridViewTextBoxColumn,
            this.userBirthdayDataGridViewTextBoxColumn,
            this.userIdentityDataGridViewTextBoxColumn,
            this.userPhotoDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.sysUserBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(967, 421);
            this.dataGridView1.TabIndex = 0;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // userPassWordDataGridViewTextBoxColumn
            // 
            this.userPassWordDataGridViewTextBoxColumn.DataPropertyName = "UserPassWord";
            this.userPassWordDataGridViewTextBoxColumn.HeaderText = "UserPassWord";
            this.userPassWordDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.userPassWordDataGridViewTextBoxColumn.Name = "userPassWordDataGridViewTextBoxColumn";
            this.userPassWordDataGridViewTextBoxColumn.Width = 150;
            // 
            // userSchoolIDDataGridViewTextBoxColumn
            // 
            this.userSchoolIDDataGridViewTextBoxColumn.DataPropertyName = "UserSchoolID";
            this.userSchoolIDDataGridViewTextBoxColumn.HeaderText = "UserSchoolID";
            this.userSchoolIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.userSchoolIDDataGridViewTextBoxColumn.Name = "userSchoolIDDataGridViewTextBoxColumn";
            this.userSchoolIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // userMobileDataGridViewTextBoxColumn
            // 
            this.userMobileDataGridViewTextBoxColumn.DataPropertyName = "UserMobile";
            this.userMobileDataGridViewTextBoxColumn.HeaderText = "UserMobile";
            this.userMobileDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.userMobileDataGridViewTextBoxColumn.Name = "userMobileDataGridViewTextBoxColumn";
            this.userMobileDataGridViewTextBoxColumn.Width = 150;
            // 
            // userBirthdayDataGridViewTextBoxColumn
            // 
            this.userBirthdayDataGridViewTextBoxColumn.DataPropertyName = "UserBirthday";
            this.userBirthdayDataGridViewTextBoxColumn.HeaderText = "UserBirthday";
            this.userBirthdayDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.userBirthdayDataGridViewTextBoxColumn.Name = "userBirthdayDataGridViewTextBoxColumn";
            this.userBirthdayDataGridViewTextBoxColumn.Width = 150;
            // 
            // userIdentityDataGridViewTextBoxColumn
            // 
            this.userIdentityDataGridViewTextBoxColumn.DataPropertyName = "UserIdentity";
            this.userIdentityDataGridViewTextBoxColumn.HeaderText = "UserIdentity";
            this.userIdentityDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.userIdentityDataGridViewTextBoxColumn.Name = "userIdentityDataGridViewTextBoxColumn";
            this.userIdentityDataGridViewTextBoxColumn.Width = 150;
            // 
            // userPhotoDataGridViewImageColumn
            // 
            this.userPhotoDataGridViewImageColumn.DataPropertyName = "UserPhoto";
            this.userPhotoDataGridViewImageColumn.HeaderText = "UserPhoto";
            this.userPhotoDataGridViewImageColumn.MinimumWidth = 8;
            this.userPhotoDataGridViewImageColumn.Name = "userPhotoDataGridViewImageColumn";
            this.userPhotoDataGridViewImageColumn.Width = 150;
            // 
            // sysUserBindingSource
            // 
            this.sysUserBindingSource.DataMember = "SysUser";
            this.sysUserBindingSource.DataSource = this.schoolDataSet1;
            // 
            // schoolDataSet1
            // 
            this.schoolDataSet1.DataSetName = "schoolDataSet1";
            this.schoolDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sysUserTableAdapter
            // 
            this.sysUserTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.SeaShell;
            this.label1.Location = new System.Drawing.Point(67, 609);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(585, 84);
            this.label1.TabIndex = 1;
            this.label1.Text = "出于对用户信息的保护\r\n您只能做添加用户，删除用户和查看所有用户信息的操作\r\n\r\n用户的信息的修改只能由用户自己完成";
            // 
            // button_insert
            // 
            this.button_insert.BackColor = System.Drawing.Color.SeaShell;
            this.button_insert.Font = new System.Drawing.Font("Viner Hand ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_insert.ForeColor = System.Drawing.Color.Salmon;
            this.button_insert.Location = new System.Drawing.Point(239, 515);
            this.button_insert.Name = "button_insert";
            this.button_insert.Size = new System.Drawing.Size(163, 56);
            this.button_insert.TabIndex = 2;
            this.button_insert.Text = "Insert";
            this.button_insert.UseVisualStyleBackColor = false;
            this.button_insert.Click += new System.EventHandler(this.button_insert_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.SeaShell;
            this.button_delete.Font = new System.Drawing.Font("Viner Hand ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.ForeColor = System.Drawing.Color.Salmon;
            this.button_delete.Location = new System.Drawing.Point(638, 515);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(163, 56);
            this.button_delete.TabIndex = 3;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.SeaShell;
            this.label2.Location = new System.Drawing.Point(272, 475);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "新增用户";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.SeaShell;
            this.label3.Location = new System.Drawing.Point(662, 475);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "删除用户";
            // 
            // FormUser_M
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(1017, 750);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_insert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormUser_M";
            this.Text = "User Info Management";
            this.Load += new System.EventHandler(this.FormUser_M_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sysUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private schoolDataSet1 schoolDataSet1;
        private System.Windows.Forms.BindingSource sysUserBindingSource;
        private schoolDataSet1TableAdapters.SysUserTableAdapter sysUserTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPassWordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userSchoolIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userMobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userBirthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdentityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn userPhotoDataGridViewImageColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_insert;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public string userid;
    }
}