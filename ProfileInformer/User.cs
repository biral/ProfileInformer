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

namespace ProfileInformer
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }
        public User(string username)
        {
            InitializeComponent();
            txtUsername.Text = username;
        }

        private void User_Load(object sender, EventArgs e)
        {
            var connection = ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString;
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand(@"Select * from [User] where Username=@username", con);
            cmd.Parameters.AddWithValue("@username", txtUsername.Text);            
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if(ds.Tables[0].Rows.Count > 0)
            {
                txtFirstname.Text = ds.Tables[0].Rows[0][2].ToString();
                txtLastname.Text = ds.Tables[0].Rows[0][3].ToString();
                txtDOB.Text = ds.Tables[0].Rows[0][4].ToString();
                txtGender.Text = ds.Tables[0].Rows[0][5].ToString();
                txtMobile.Text = ds.Tables[0].Rows[0][6].ToString();
                txtEmail.Text = ds.Tables[0].Rows[0][7].ToString();
                MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["Userimage"]);
                pictureBox1.Image = new Bitmap(ms);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;                   
            }         
        }

        private void User_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateDetails update = new UpdateDetails(txtUsername.Text);
            update.Show();
            this.Hide();
        }
    }
}
