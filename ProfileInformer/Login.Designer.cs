namespace ProfileInformer
{
    partial class Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioUser = new System.Windows.Forms.RadioButton();
            this.radioAdmin = new System.Windows.Forms.RadioButton();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnTabSignup = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtConPass = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtMob = new System.Windows.Forms.TextBox();
            this.txtGen = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.labelConPass = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.datePickerDOB = new System.Windows.Forms.DateTimePicker();
            this.labelMob = new System.Windows.Forms.Label();
            this.labelGen = new System.Windows.Forms.Label();
            this.labelDOB = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.btnGuest = new System.Windows.Forms.Button();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioUser);
            this.panel1.Controls.Add(this.radioAdmin);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.btnGuest);
            this.panel1.Controls.Add(this.btnSignUp);
            this.panel1.Controls.Add(this.txt_password);
            this.panel1.Controls.Add(this.txt_username);
            this.panel1.Controls.Add(this.label_password);
            this.panel1.Controls.Add(this.label_username);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1405, 740);
            this.panel1.TabIndex = 0;
            // 
            // radioUser
            // 
            this.radioUser.AutoSize = true;
            this.radioUser.Location = new System.Drawing.Point(180, 288);
            this.radioUser.Name = "radioUser";
            this.radioUser.Size = new System.Drawing.Size(59, 21);
            this.radioUser.TabIndex = 18;
            this.radioUser.TabStop = true;
            this.radioUser.Text = "User";
            this.radioUser.UseVisualStyleBackColor = true;
            // 
            // radioAdmin
            // 
            this.radioAdmin.AutoSize = true;
            this.radioAdmin.Location = new System.Drawing.Point(180, 243);
            this.radioAdmin.Name = "radioAdmin";
            this.radioAdmin.Size = new System.Drawing.Size(68, 21);
            this.radioAdmin.TabIndex = 17;
            this.radioAdmin.TabStop = true;
            this.radioAdmin.Text = "Admin";
            this.radioAdmin.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(12, 378);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 64);
            this.btnLogin.TabIndex = 16;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(419, 56);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(912, 599);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnAddImage);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.btnTabSignup);
            this.tabPage2.Controls.Add(this.txtEmail);
            this.tabPage2.Controls.Add(this.txtPass);
            this.tabPage2.Controls.Add(this.txtConPass);
            this.tabPage2.Controls.Add(this.txtUserName);
            this.tabPage2.Controls.Add(this.txtMob);
            this.tabPage2.Controls.Add(this.txtGen);
            this.tabPage2.Controls.Add(this.txtLastName);
            this.tabPage2.Controls.Add(this.txtFirstName);
            this.tabPage2.Controls.Add(this.labelEmail);
            this.tabPage2.Controls.Add(this.labelPass);
            this.tabPage2.Controls.Add(this.labelConPass);
            this.tabPage2.Controls.Add(this.labelUserName);
            this.tabPage2.Controls.Add(this.datePickerDOB);
            this.tabPage2.Controls.Add(this.labelMob);
            this.tabPage2.Controls.Add(this.labelGen);
            this.tabPage2.Controls.Add(this.labelDOB);
            this.tabPage2.Controls.Add(this.labelLastName);
            this.tabPage2.Controls.Add(this.labelFirstName);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(904, 570);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sign-Up";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnTabSignup
            // 
            this.btnTabSignup.Location = new System.Drawing.Point(403, 463);
            this.btnTabSignup.Name = "btnTabSignup";
            this.btnTabSignup.Size = new System.Drawing.Size(123, 59);
            this.btnTabSignup.TabIndex = 21;
            this.btnTabSignup.Text = "Sign Up";
            this.btnTabSignup.UseVisualStyleBackColor = true;
            this.btnTabSignup.Click += new System.EventHandler(this.btnTabSignup_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(226, 220);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 30);
            this.txtEmail.TabIndex = 20;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(227, 123);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(100, 30);
            this.txtPass.TabIndex = 18;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // txtConPass
            // 
            this.txtConPass.Location = new System.Drawing.Point(227, 173);
            this.txtConPass.Name = "txtConPass";
            this.txtConPass.Size = new System.Drawing.Size(100, 30);
            this.txtConPass.TabIndex = 16;
            this.txtConPass.UseSystemPasswordChar = true;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(227, 74);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 30);
            this.txtUserName.TabIndex = 14;
            // 
            // txtMob
            // 
            this.txtMob.Location = new System.Drawing.Point(634, 178);
            this.txtMob.MaxLength = 10;
            this.txtMob.Name = "txtMob";
            this.txtMob.Size = new System.Drawing.Size(100, 30);
            this.txtMob.TabIndex = 11;
            // 
            // txtGen
            // 
            this.txtGen.Location = new System.Drawing.Point(634, 121);
            this.txtGen.Name = "txtGen";
            this.txtGen.Size = new System.Drawing.Size(100, 30);
            this.txtGen.TabIndex = 10;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(634, 26);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 30);
            this.txtLastName.TabIndex = 8;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(227, 23);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 30);
            this.txtFirstName.TabIndex = 7;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(30, 223);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(72, 25);
            this.labelEmail.TabIndex = 19;
            this.labelEmail.Text = "Email:";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(30, 123);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(113, 25);
            this.labelPass.TabIndex = 17;
            this.labelPass.Text = "Password:";
            // 
            // labelConPass
            // 
            this.labelConPass.AutoSize = true;
            this.labelConPass.Location = new System.Drawing.Point(18, 173);
            this.labelConPass.Name = "labelConPass";
            this.labelConPass.Size = new System.Drawing.Size(194, 25);
            this.labelConPass.TabIndex = 15;
            this.labelConPass.Text = "Confirm Password:";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(30, 74);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(117, 25);
            this.labelUserName.TabIndex = 13;
            this.labelUserName.Text = "Username:";
            // 
            // datePickerDOB
            // 
            this.datePickerDOB.Checked = false;
            this.datePickerDOB.Location = new System.Drawing.Point(634, 72);
            this.datePickerDOB.Name = "datePickerDOB";
            this.datePickerDOB.Size = new System.Drawing.Size(251, 30);
            this.datePickerDOB.TabIndex = 12;
            // 
            // labelMob
            // 
            this.labelMob.AutoSize = true;
            this.labelMob.Location = new System.Drawing.Point(482, 178);
            this.labelMob.Name = "labelMob";
            this.labelMob.Size = new System.Drawing.Size(116, 25);
            this.labelMob.TabIndex = 4;
            this.labelMob.Text = "Mobile No:";
            // 
            // labelGen
            // 
            this.labelGen.AutoSize = true;
            this.labelGen.Location = new System.Drawing.Point(482, 126);
            this.labelGen.Name = "labelGen";
            this.labelGen.Size = new System.Drawing.Size(90, 25);
            this.labelGen.TabIndex = 3;
            this.labelGen.Text = "Gender:";
            // 
            // labelDOB
            // 
            this.labelDOB.AutoSize = true;
            this.labelDOB.Location = new System.Drawing.Point(482, 77);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(138, 25);
            this.labelDOB.TabIndex = 2;
            this.labelDOB.Text = "Date of Birth:";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(482, 26);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(122, 25);
            this.labelLastName.TabIndex = 1;
            this.labelLastName.Text = "Last Name:";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(30, 26);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(123, 25);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "First Name:";
            // 
            // btnGuest
            // 
            this.btnGuest.Location = new System.Drawing.Point(257, 378);
            this.btnGuest.Name = "btnGuest";
            this.btnGuest.Size = new System.Drawing.Size(100, 64);
            this.btnGuest.TabIndex = 14;
            this.btnGuest.Text = "Login As Guest";
            this.btnGuest.UseVisualStyleBackColor = true;
            this.btnGuest.Click += new System.EventHandler(this.btnGuest_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(134, 378);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(100, 64);
            this.btnSignUp.TabIndex = 13;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(190, 186);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(100, 22);
            this.txt_password.TabIndex = 11;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(190, 104);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(100, 22);
            this.txt_username.TabIndex = 10;
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.Location = new System.Drawing.Point(60, 186);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(113, 25);
            this.label_password.TabIndex = 9;
            this.label_password.Text = "Password:";
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.Location = new System.Drawing.Point(55, 104);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(117, 25);
            this.label_username.TabIndex = 8;
            this.label_username.Text = "Username:";
            // 
            // btnAddImage
            // 
            this.btnAddImage.Location = new System.Drawing.Point(403, 267);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(195, 34);
            this.btnAddImage.TabIndex = 23;
            this.btnAddImage.Text = "Upload Image";
            this.btnAddImage.UseVisualStyleBackColor = true;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(625, 235);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 121);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 740);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.Text = "Login-131040107040";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnTabSignup;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtConPass;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtMob;
        private System.Windows.Forms.TextBox txtGen;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Label labelConPass;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.DateTimePicker datePickerDOB;
        private System.Windows.Forms.Label labelMob;
        private System.Windows.Forms.Label labelGen;
        private System.Windows.Forms.Label labelDOB;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Button btnGuest;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.RadioButton radioUser;
        private System.Windows.Forms.RadioButton radioAdmin;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

