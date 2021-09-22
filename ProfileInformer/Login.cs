using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.Sql;
using System.IO;
using System.Windows.Media.Imaging;


namespace ProfileInformer
{
    public partial class Login : Form
    {
        public static string Username = "";
        public string path = "";
        public Login()
        {
            InitializeComponent();
            
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            label_username.Visible = false;
            label_password.Visible = false;
            txt_username.Visible = false;
            txt_password.Visible = false;
            btnGuest.Visible = false;
            btnSignUp.Visible = false;
            btnGuest.Visible = false;
            btnLogin.Visible = false;
            radioAdmin.Visible = false;
            radioUser.Visible = false;                       
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            Guest gt = new Guest();
            gt.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            var connection = ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString;
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("Select * from AdminLogin", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                con.Close();
                tabControl1.Visible = false;
                radioAdmin.Checked = true;
            }  
            else
            {
                FirstTime fs = new FirstTime();
                fs.Show();
                this.Hide();
            }                    
        }

        private void btnTabSignup_Click(object sender, EventArgs e)
        {
            var connection = ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString;
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("Select * from [User] where Username=@username", con);
            cmd.Parameters.AddWithValue("@username", txtUserName.Text);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.HasRows)
            {
                MessageBox.Show("Username Already Exist Change the username");
            }
            else
            {
                con.Close();
                if(txtPass.Text == txtConPass.Text)
                {
                    BitmapImage img = new BitmapImage(new Uri(path));
                    MemoryStream ms = new MemoryStream();
                    JpegBitmapEncoder encoder = new JpegBitmapEncoder();
                    encoder.Frames.Add(BitmapFrame.Create(img));
                    encoder.Save(ms);
                    byte[] bs = ms.ToArray(); 
                    SqlCommand cmd1 = new SqlCommand("insert into [User] (Username, Password, Firstname, Lastname, DOB, Gender, Mobileno, Email, Userimage) values (@username, @password, @firstname, @lastname, @dob, @gender, @mobileno, @email, @image)",con);
                    cmd1.Parameters.AddWithValue("@username", txtUserName.Text);
                    cmd1.Parameters.AddWithValue("@password", txtPass.Text);
                    cmd1.Parameters.AddWithValue("@firstname", txtFirstName.Text);
                    cmd1.Parameters.AddWithValue("@lastname", txtLastName.Text);
                    cmd1.Parameters.AddWithValue("@dob", datePickerDOB.Text);
                    cmd1.Parameters.AddWithValue("@gender", txtGen.Text);
                    cmd1.Parameters.AddWithValue("@mobileno", txtMob.Text);
                    cmd1.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd1.Parameters.AddWithValue("@image", bs);
                    con.Open();
                    int o = cmd1.ExecuteNonQuery();                    
                    MessageBox.Show("User Created");
                    con.Close();
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Password Dont match");
                    txtPass.Clear();
                    txtConPass.Clear();
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "" || txt_password.Text == "")
            {
                MessageBox.Show("Username and Password should not be empty");
            }
            else if(radioAdmin.Checked==true)
            {
                var connection = ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString;
                SqlConnection con = new SqlConnection(connection);
                SqlCommand cmd = new SqlCommand("Select * from AdminLogin where Username=@username and Password=@password", con);
                cmd.Parameters.AddWithValue("@username", txt_username.Text);
                cmd.Parameters.AddWithValue("@password", txt_password.Text);
                con.Open();
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                ad.Fill(ds);
                con.Close();
                if (ds.Tables[0].Rows.Count == 1)
                {
                    Username = txt_username.Text; 
                    Admin admin = new Admin();
                    admin.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect Username and/or Password");
                    txt_username.Clear();
                    txt_password.Clear();
                    txt_username.Focus();
                }
            }
            else if(radioUser.Checked==true)
            {
                var connection = ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString;
                SqlConnection con = new SqlConnection(connection);
                SqlCommand cmd1 = new SqlCommand(@"Select * from [User] where Username=@username and Password=@password", con);
                cmd1.Parameters.AddWithValue("@username", txt_username.Text);
                cmd1.Parameters.AddWithValue("@password", txt_password.Text);
                con.Open();
                SqlDataAdapter ada = new SqlDataAdapter(cmd1);
                DataSet dsa = new DataSet();
                ada.Fill(dsa);
                con.Close();
                if (dsa.Tables[0].Rows.Count == 1)
                {
                    User u = new User(txt_username.Text);
                    u.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect Username and/or Password");
                    txt_username.Clear();
                    txt_password.Clear();
                    txt_username.Focus();
                }
            }           
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            string filename;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            openFileDialog1.Filter =" JPEG files| *.jpg | PNG files | *.png | GIF Files | *.gif | TIFF Files | *.tif | BMP Files | *.bmp" ;
            filename = openFileDialog1.FileName;
            Image img = Image.FromFile(filename);
            pictureBox1.Image = img;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            path = openFileDialog1.FileName;
        }
    }
}
