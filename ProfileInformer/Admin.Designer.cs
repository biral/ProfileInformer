namespace ProfileInformer
{
    partial class Admin
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
            this.btnAddUser = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.labelNewUsername = new System.Windows.Forms.Label();
            this.txtNewUsername = new System.Windows.Forms.TextBox();
            this.btnUpadtePass = new System.Windows.Forms.Button();
            this.labelConNew = new System.Windows.Forms.Label();
            this.txtConNew = new System.Windows.Forms.TextBox();
            this.labelNew = new System.Windows.Forms.Label();
            this.txtNew = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.DataGridUserDetails = new System.Windows.Forms.DataGridView();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginSystemDataSet = new ProfileInformer.LoginSystemDataSet();
            this.btnFindUser = new System.Windows.Forms.Button();
            this.btnUserDelete = new System.Windows.Forms.Button();
            this.btnUserUpdate = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.userTableAdapter = new ProfileInformer.LoginSystemDataSetTableAdapters.UserTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridUserDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginSystemDataSet)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(3, 109);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(224, 100);
            this.btnAddUser.TabIndex = 0;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Controls.Add(this.labelPassword);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.labelNewUsername);
            this.panel1.Controls.Add(this.txtNewUsername);
            this.panel1.Controls.Add(this.btnUpadtePass);
            this.panel1.Controls.Add(this.labelConNew);
            this.panel1.Controls.Add(this.txtConNew);
            this.panel1.Controls.Add(this.labelNew);
            this.panel1.Controls.Add(this.txtNew);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnFind);
            this.panel1.Controls.Add(this.DataGridUserDetails);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.labelUsername);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(230, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 716);
            this.panel1.TabIndex = 9;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(215, 183);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(123, 50);
            this.btnCreate.TabIndex = 56;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Visible = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(107, 116);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(101, 21);
            this.labelPassword.TabIndex = 55;
            this.labelPassword.Text = "Password:";
            this.labelPassword.Visible = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(267, 116);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(170, 28);
            this.txtPassword.TabIndex = 54;
            this.txtPassword.Visible = false;
            // 
            // labelNewUsername
            // 
            this.labelNewUsername.AutoSize = true;
            this.labelNewUsername.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewUsername.Location = new System.Drawing.Point(107, 73);
            this.labelNewUsername.Name = "labelNewUsername";
            this.labelNewUsername.Size = new System.Drawing.Size(105, 21);
            this.labelNewUsername.TabIndex = 53;
            this.labelNewUsername.Text = "Username:";
            this.labelNewUsername.Visible = false;
            // 
            // txtNewUsername
            // 
            this.txtNewUsername.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewUsername.Location = new System.Drawing.Point(267, 73);
            this.txtNewUsername.Name = "txtNewUsername";
            this.txtNewUsername.Size = new System.Drawing.Size(170, 28);
            this.txtNewUsername.TabIndex = 52;
            this.txtNewUsername.Visible = false;
            // 
            // btnUpadtePass
            // 
            this.btnUpadtePass.Location = new System.Drawing.Point(224, 551);
            this.btnUpadtePass.Name = "btnUpadtePass";
            this.btnUpadtePass.Size = new System.Drawing.Size(123, 50);
            this.btnUpadtePass.TabIndex = 51;
            this.btnUpadtePass.Text = "Update";
            this.btnUpadtePass.UseVisualStyleBackColor = true;
            this.btnUpadtePass.Visible = false;
            this.btnUpadtePass.Click += new System.EventHandler(this.btnUpadtePass_Click);
            // 
            // labelConNew
            // 
            this.labelConNew.AutoSize = true;
            this.labelConNew.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConNew.Location = new System.Drawing.Point(74, 484);
            this.labelConNew.Name = "labelConNew";
            this.labelConNew.Size = new System.Drawing.Size(174, 21);
            this.labelConNew.TabIndex = 50;
            this.labelConNew.Text = "Confirm Password";
            this.labelConNew.Visible = false;
            // 
            // txtConNew
            // 
            this.txtConNew.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConNew.Location = new System.Drawing.Point(276, 484);
            this.txtConNew.Name = "txtConNew";
            this.txtConNew.Size = new System.Drawing.Size(170, 28);
            this.txtConNew.TabIndex = 49;
            this.txtConNew.Visible = false;
            // 
            // labelNew
            // 
            this.labelNew.AutoSize = true;
            this.labelNew.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNew.Location = new System.Drawing.Point(116, 441);
            this.labelNew.Name = "labelNew";
            this.labelNew.Size = new System.Drawing.Size(140, 21);
            this.labelNew.TabIndex = 48;
            this.labelNew.Text = "New Password";
            this.labelNew.Visible = false;
            // 
            // txtNew
            // 
            this.txtNew.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNew.Location = new System.Drawing.Point(276, 441);
            this.txtNew.Name = "txtNew";
            this.txtNew.Size = new System.Drawing.Size(170, 28);
            this.txtNew.TabIndex = 47;
            this.txtNew.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(345, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(108, 35);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(345, 10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 35);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(345, 10);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(108, 35);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Visible = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // DataGridUserDetails
            // 
            this.DataGridUserDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridUserDetails.Location = new System.Drawing.Point(51, 109);
            this.DataGridUserDetails.Name = "DataGridUserDetails";
            this.DataGridUserDetails.RowTemplate.Height = 24;
            this.DataGridUserDetails.Size = new System.Drawing.Size(390, 297);
            this.DataGridUserDetails.TabIndex = 2;
            this.DataGridUserDetails.Visible = false;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(182, 15);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(145, 22);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Visible = false;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(46, 12);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(117, 25);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Username:";
            this.labelUsername.Visible = false;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.loginSystemDataSet;
            // 
            // loginSystemDataSet
            // 
            this.loginSystemDataSet.DataSetName = "LoginSystemDataSet";
            this.loginSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnFindUser
            // 
            this.btnFindUser.Location = new System.Drawing.Point(3, 321);
            this.btnFindUser.Name = "btnFindUser";
            this.btnFindUser.Size = new System.Drawing.Size(224, 100);
            this.btnFindUser.TabIndex = 3;
            this.btnFindUser.Text = "Find User";
            this.btnFindUser.UseVisualStyleBackColor = true;
            this.btnFindUser.Click += new System.EventHandler(this.btnFindUser_Click);
            // 
            // btnUserDelete
            // 
            this.btnUserDelete.Location = new System.Drawing.Point(3, 215);
            this.btnUserDelete.Name = "btnUserDelete";
            this.btnUserDelete.Size = new System.Drawing.Size(224, 100);
            this.btnUserDelete.TabIndex = 2;
            this.btnUserDelete.Text = "Delete User";
            this.btnUserDelete.UseVisualStyleBackColor = true;
            this.btnUserDelete.Click += new System.EventHandler(this.btnUserDelete_Click);
            // 
            // btnUserUpdate
            // 
            this.btnUserUpdate.Location = new System.Drawing.Point(3, 3);
            this.btnUserUpdate.Name = "btnUserUpdate";
            this.btnUserUpdate.Size = new System.Drawing.Size(224, 100);
            this.btnUserUpdate.TabIndex = 1;
            this.btnUserUpdate.Text = "Update User-Details";
            this.btnUserUpdate.UseVisualStyleBackColor = true;
            this.btnUserUpdate.Click += new System.EventHandler(this.btnUserUpdate_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnUserUpdate);
            this.flowLayoutPanel1.Controls.Add(this.btnAddUser);
            this.flowLayoutPanel1.Controls.Add(this.btnUserDelete);
            this.flowLayoutPanel1.Controls.Add(this.btnFindUser);
            this.flowLayoutPanel1.Controls.Add(this.btnLogout);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(230, 716);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(3, 427);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(224, 100);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 716);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridUserDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginSystemDataSet)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.DataGridView DataGridUserDetails;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Button btnFindUser;
        private System.Windows.Forms.Button btnUserDelete;
        private System.Windows.Forms.Button btnUserUpdate;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label labelNewUsername;
        private System.Windows.Forms.TextBox txtNewUsername;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnUpadtePass;
        private System.Windows.Forms.Label labelConNew;
        private System.Windows.Forms.TextBox txtConNew;
        private System.Windows.Forms.Label labelNew;
        private System.Windows.Forms.TextBox txtNew;
        private LoginSystemDataSet loginSystemDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private LoginSystemDataSetTableAdapters.UserTableAdapter userTableAdapter;
    }
}