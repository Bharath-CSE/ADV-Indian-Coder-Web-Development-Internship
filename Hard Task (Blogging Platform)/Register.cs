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
    public partial class Register : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Welcome\Documents\Blog.mdf;Integrated Security=True;Connect Timeout=30");
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void Register_Password_Click(object sender, EventArgs e)
        {
            if (UserId_Reg.Text == "" || Password_Reg.Text == "")
            {
                MessageBox.Show("Please Enter UserId And Password");
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into Users_tbl values('" + UserId_Reg.Text + "','" + Password_Reg.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Registered");
                Login log = new Login();
                log.Show();
                this.Hide();
                Con.Close();
            }
        }
    }
}