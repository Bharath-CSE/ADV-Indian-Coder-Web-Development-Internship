using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADV
{
    public partial class Login : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Welcome\Documents\Blog.mdf;Integrated Security=True;Connect Timeout=30");
        public Login()
        {
            InitializeComponent();
        }

        private void Password_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void UserId_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (UserId.Text == "" || Password.Text == "")
            {
                MessageBox.Show("Please Enter UserId And Password");
            }
            else
            {
                Con.Open();
                string query = "Select User_Id,Password from Users_tbl where User_Id='" + UserId.Text + "' and Password='" + Password.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Post post = new Post();
                    post.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please enter the correct UserId and Password. Or If you are new to Blogs, please register and then login");
                }
                Con.Close();
            }
        }

        private void Register_Login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register reg = new Register();
            reg.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}