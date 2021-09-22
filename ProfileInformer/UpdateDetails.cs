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
    public partial class UpdateDetails : Form
    {
        public string path = "";
        public UpdateDetails()
        {
            InitializeComponent();
        }
        public UpdateDetails(string username)
        {
            InitializeComponent();
            txtUsername.Text = username;
        }

        private void UpdateDetails_Load(object sender, EventArgs e)
        {
            var connection = ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString;
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand(@"Select * from [User] where Username=@username", con);
            cmd.Parameters.AddWithValue("@username", txtUsername.Text);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                txtpassword.Text = ds.Tables[0].Rows[0][1].ToString();
                txtFirstname.Text = ds.Tables[0].Rows[0][2].ToString();
                txtLastname.Text = ds.Tables[0].Rows[0][3].ToString();
                datetimepickerDOB.Text = ds.Tables[0].Rows[0][4].ToString();
                txtGender.Text = ds.Tables[0].Rows[0][5].ToString();
                txtMobile.Text = ds.Tables[0].Rows[0][6].ToString();
                txtEmail.Text = ds.Tables[0].Rows[0][7].ToString();
                MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["Userimage"]);
                pictureBox1.Image = new Bitmap(ms);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                BitmapImage img = new BitmapImage(new Uri(path));
                MemoryStream ms = new MemoryStream();
                JpegBitmapEncoder encoder = new JpegBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create(img));
                encoder.Save(ms);
                byte[] bs = ms.ToArray();
                var connection = ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString;
                SqlConnection con = new SqlConnection(connection);
                SqlCommand cmd1 = new SqlCommand();
                cmd1.Connection = con;
                cmd1.CommandText = "update [User] set Password=@password, Firstname=@firstname, Lastname=@lastname, DOB=@dob, Gender=@gender, Mobileno=@mobileno, Email=@email, Userimage=@image Where Username = @username";
                cmd1.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd1.Parameters.AddWithValue("@password", txtpassword.Text);
                cmd1.Parameters.AddWithValue("@firstname", txtFirstname.Text);
                cmd1.Parameters.AddWithValue("@lastname", txtLastname.Text);
                cmd1.Parameters.AddWithValue("@dob", datetimepickerDOB.Text);
                cmd1.Parameters.AddWithValue("@gender", txtGender.Text);
                cmd1.Parameters.AddWithValue("@mobileno", txtMobile.Text);
                cmd1.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd1.Parameters.AddWithValue("@image", bs);
                con.Open();
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Details Updated");
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString() +"Contact to system admin"); 
            }
        }

        private void UpdateDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }
    }
}
