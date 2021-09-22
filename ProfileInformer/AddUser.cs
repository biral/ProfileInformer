using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;

namespace ProfileInformer
{
    public partial class AddUser : Form
    {
        public string path="";
        public AddUser()
        {
            InitializeComponent();
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            var connection = ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString;
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("Select * from [User] where Username=@username", con);
            cmd.Parameters.AddWithValue("@username", txtUserName.Text);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                MessageBox.Show("Username Already Exist Change the username");
            }
            else
            {
                con.Close();
                if (txtPass.Text == txtConPass.Text)
                {
                    if(pictureBox1.Image!=null)
                    {
                        try
                        {
                            BitmapImage img = new BitmapImage(new Uri(path));
                            MemoryStream ms = new MemoryStream();
                            JpegBitmapEncoder encoder = new JpegBitmapEncoder();
                            encoder.Frames.Add(BitmapFrame.Create(img));
                            encoder.Save(ms);
                            byte[] bs = ms.ToArray();
                            SqlCommand cmd1 = new SqlCommand("insert into [User] (Username, Password, Firstname, Lastname, DOB, Gender, Mobileno, Email, Userimage) values (@username, @password, @firstname, @lastname, @dob, @gender, @mobileno, @email, @image)", con);
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
                            Login lg = new Login();
                            lg.Show();
                            this.Hide();
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex+"Something went wrong");
                        }

                        
                    }
                    else
                    {
                        try
                        {
                            SqlCommand cmd1 = new SqlCommand("insert into [User] (Username, Password, Firstname, Lastname, DOB, Gender, Mobileno, Email) values (@username, @password, @firstname, @lastname, @dob, @gender, @mobileno, @email)", con);
                            cmd1.Parameters.AddWithValue("@username", txtUserName.Text);
                            cmd1.Parameters.AddWithValue("@password", txtPass.Text);
                            cmd1.Parameters.AddWithValue("@firstname", txtFirstName.Text);
                            cmd1.Parameters.AddWithValue("@lastname", txtLastName.Text);
                            cmd1.Parameters.AddWithValue("@dob", datePickerDOB.Text);
                            cmd1.Parameters.AddWithValue("@gender", txtGen.Text);
                            cmd1.Parameters.AddWithValue("@mobileno", txtMob.Text);
                            cmd1.Parameters.AddWithValue("@email", txtEmail.Text);
                            con.Open();
                            int o = cmd1.ExecuteNonQuery();
                            MessageBox.Show("User Created");
                            Application.Exit();
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex+"Something went wrong");
                        }
                   }
                }
                else
                {
                    MessageBox.Show("Password Dont match");
                    txtPass.Clear();
                    txtConPass.Clear();
                }
            }
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            string filename;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            openFileDialog1.Filter = " JPEG files| *.jpg | PNG files | *.png | GIF Files | *.gif | TIFF Files | *.tif | BMP Files | *.bmp";
            filename = openFileDialog1.FileName;
            Image img = Image.FromFile(filename);
            pictureBox1.Image = img;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            path = openFileDialog1.FileName;
        }
    }
}
