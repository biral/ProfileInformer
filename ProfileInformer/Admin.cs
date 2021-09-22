using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace ProfileInformer
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btnUserUpdate_Click(object sender, EventArgs e)
        {
            labelUsername.Visible = true;
            txtUsername.Visible = true;
            btnUpdate.Visible = true;
            labelNewUsername.Visible = false;
            txtNewUsername.Visible = false;
            labelPassword.Visible = false;
            txtPassword.Visible = false;
            btnCreate.Visible = false;
            btnFind.Visible = false;
            DataGridUserDetails.Visible = false;
            labelNew.Visible = false;
            txtNew.Visible = false;
            labelConNew.Visible = false;
            txtConNew.Visible = false;
            btnUpadtePass.Visible = false;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUser add = new AddUser();
            add.Show();
            this.Hide();            
        }

        private void btnUserDelete_Click(object sender, EventArgs e)
        {
            labelUsername.Visible = true;
            txtUsername.Visible = true;
            btnDelete.Visible = true;
            labelNewUsername.Visible = false;
            txtNewUsername.Visible = false;
            labelPassword.Visible = false;
            txtPassword.Visible = false;
            btnCreate.Visible = false;
            btnUpdate.Visible = false;
            DataGridUserDetails.Visible = false;
            labelNew.Visible = false;
            txtNew.Visible = false;
            labelConNew.Visible = false;
            txtConNew.Visible = false;
            btnUpadtePass.Visible = false;
        }

        private void btnFindUser_Click(object sender, EventArgs e)
        {
            labelUsername.Visible = true;
            txtUsername.Visible = true;
            btnFind.Visible = true;
            DataGridUserDetails.Visible = true;
            labelNewUsername.Visible = false;
            txtNewUsername.Visible = false;
            labelPassword.Visible = false;
            txtPassword.Visible = false;
            btnCreate.Visible = false;
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
            labelNew.Visible = false;
            txtNew.Visible = false;
            labelConNew.Visible = false;
            txtConNew.Visible = false;
            btnUpadtePass.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var connection = ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString;
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("Select * from [User] where Username=@username", con);
            cmd.Parameters.AddWithValue("@username", txtUsername.Text);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                UpdateDetails update = new UpdateDetails(txtUsername.Text);
                update.Show();
                this.Hide();
                con.Close();
            }
            else
            {
                MessageBox.Show("No such user exist");
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var connection = ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString;
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand(@"insert into [User] (Username,Password) values (@username,@password)", con);
            cmd.Parameters.AddWithValue("@username", txtNewUsername.Text);
            cmd.Parameters.AddWithValue("@password", txtPassword.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("User Created");
        }

        private void btnUpadtePass_Click(object sender, EventArgs e)
        {
            var connection = ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString;
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd1 = new SqlCommand(@"Select * from [User] where Username=@username", con);
            cmd1.Parameters.AddWithValue("@username", txtUsername.Text);
            con.Open();
            SqlDataAdapter ada = new SqlDataAdapter(cmd1);
            DataSet dsa = new DataSet();
            ada.Fill(dsa);
            con.Close();
            if (dsa.Tables[0].Rows.Count == 1)
            {
                if (txtNew.Text == txtConNew.Text)
                {
                    SqlCommand cmd = new SqlCommand(@"update [User] set Password=@password where Username=@username", con);
                    cmd.Parameters.AddWithValue("@password", txtNew.Text);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Password Changed");

                }
                else
                {
                    MessageBox.Show("Password and Confirm Password not match");
                    txtNew.Clear();
                    txtConNew.Clear();
                    txtNew.Focus();
                }
            }
                
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var connection = ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString;
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd1 = new SqlCommand(@"Select * from [User] where Username=@username", con);
            cmd1.Parameters.AddWithValue("@username", txtUsername.Text);
            con.Open();
            SqlDataAdapter ada = new SqlDataAdapter(cmd1);
            DataSet dsa = new DataSet();
            ada.Fill(dsa);
            con.Close();
            if (dsa.Tables[0].Rows.Count == 1)
            {
                SqlCommand cmd = new SqlCommand(@"delete from [User] where Username=@username",con);
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("User Deleted");
            }
            else
            {
                MessageBox.Show("There is no such user");
                txtUsername.Clear();
                txtUsername.Focus();
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            var connection = ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString;
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd1 = new SqlCommand(@"Select * from [User] where Username=@username", con);
            cmd1.Parameters.AddWithValue("@username", txtUsername.Text);
            con.Open();
            SqlDataAdapter ada = new SqlDataAdapter(cmd1);
            DataSet dsa = new DataSet();
            ada.Fill(dsa);
            if (dsa.Tables[0].Rows.Count == 1)
            {
                DataGridUserDetails.DataSource = dsa.Tables[0];
            }
            else
            {
                MessageBox.Show("There is no such user");
                txtUsername.Clear();
                txtUsername.Focus();

            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login ln = new Login();
            ln.Show();
            this.Hide();
        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();      
        }

        
    }
}