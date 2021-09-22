using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProfileInformer
{
    public partial class FirstTime : Form
    {
        public FirstTime()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var connection = ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString;
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand(@"insert into AdminLogin (Username,Password) values (@username,@password)", con);
            cmd.Parameters.AddWithValue("@username", txtAdmin.Text);
            cmd.Parameters.AddWithValue("@password", txtPass.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Thank You");
            MessageBox.Show("Start the application again.");
            Environment.Exit(0);
        }
    }
}
