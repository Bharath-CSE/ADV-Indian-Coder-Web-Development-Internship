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
    public partial class Post : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Welcome\Documents\Blog.mdf;Integrated Security=True;Connect Timeout=30");
        public void Populate()
        {
            Con.Open();
            string MyQuery = "select Id,Blog_Name from Blog_tbl";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(MyQuery, Con);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            View1.ReadOnly = true;
            View1.DataSource = ds.Tables[0];
            Con.Close();
        }
        public void Populate1()
        {
            Con.Open();
            string MyQuery = "select Title from Blog_tbl";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(MyQuery, Con);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            View2.ReadOnly = true;
            View2.DataSource = ds.Tables[0];
            Con.Close();
        }
        public void Populate2()
        {
            Con.Open();
            string MyQuery = "select Text from Blog_tbl";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(MyQuery, Con);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            View3.ReadOnly = true;
            View3.DataSource = ds.Tables[0];
            Con.Close();
        }
        public Post()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (Id_Blog.Text==""||Name_Blog.Text==""||Title.Text==""||Text_Blog.Text=="")
            {
                MessageBox.Show("Please Enter All The Informations");
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into Blog_tbl values('" + Id_Blog.Text + "', '" + Name_Blog.Text + "','" + Title.Text + "', '" + Text_Blog.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Post Created Successfully");
                Con.Close();
                Populate();
                Populate1();
                Populate2();
            }
        }

        private void View1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Update_BlogName_Click(object sender, EventArgs e)
        {
            if(Id_Blog.Text==""||Name_Blog.Text=="")
            {
                MessageBox.Show("Please Enter Id And Blog Name");
            }
            else
            {
                Con.Open();
                string MyQuery = "update Blog_tbl set Blog_Name='" + Name_Blog.Text + "' where Id='" + Id_Blog.Text + "';";
                SqlCommand cmd = new SqlCommand(MyQuery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Blog Name Updated Successfully");
                Con.Close();
                Populate();
            }
        }

        private void Post_Load(object sender, EventArgs e)
        {
            Populate();
            Populate1();
            Populate2();
        }

        private void Delete_BlogName_Click(object sender, EventArgs e)
        {
            if(Id_Blog.Text == "")
            {
                MessageBox.Show("Wrong Operation");
            }
            else
            {
                Con.Open();
                string MyQuery = "update Blog_tbl set Blog_Name=NULL where Id='"+Id_Blog.Text+"'";
                SqlCommand cmd = new SqlCommand(MyQuery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Blog Name Deleted Successfully");
                Con.Close();
                Populate();
            }
        }

        private void Update_BlogTitle_Click(object sender, EventArgs e)
        {
            if (Id_Blog.Text == "" || Title.Text == "")
            {
                MessageBox.Show("Please Enter Id And Title");
            }
            else
            {
                Con.Open();
                string MyQuery = "update Blog_tbl set Title='" + Title.Text + "' where Id='" + Id_Blog.Text + "';";
                SqlCommand cmd = new SqlCommand(MyQuery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Title Updated Successfully");
                Con.Close();
                Populate1();
            }
        }

        private void Delete_BlogTitle_Click(object sender, EventArgs e)
        {
            if (Id_Blog.Text == "")
            {
                MessageBox.Show("Wrong Operation");
            }
            else
            {
                Con.Open();
                string MyQuery = "update Blog_tbl set Title=NULL where Id='" + Id_Blog.Text + "'";
                SqlCommand cmd = new SqlCommand(MyQuery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Title Deleted Successfully");
                Con.Close();
                Populate1();
            }
        }

        private void Update_BlogText_Click(object sender, EventArgs e)
        {
            if (Id_Blog.Text == "" || Text_Blog.Text == "")
            {
                MessageBox.Show("Please Enter Id And Text");
            }
            else
            {
                Con.Open();
                string MyQuery = "update Blog_tbl set Text='" + Text_Blog.Text + "' where Id='" + Id_Blog.Text + "';";
                SqlCommand cmd = new SqlCommand(MyQuery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Text Updated Successfully");
                Con.Close();
                Populate2();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (Id_Blog.Text == "")
            {
                MessageBox.Show("Wrong Operation");
            }
            else
            {
                Con.Open();
                string MyQuery = "update Blog_tbl set Text=NULL where Id='" + Id_Blog.Text + "'";
                SqlCommand cmd = new SqlCommand(MyQuery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Text Deleted Successfully");
                Con.Close();
                Populate2();
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (Id_Blog.Text == "")
            {
                MessageBox.Show("Wrong Operation");
            }
            else
            {
                Con.Open();
                string MyQuery = "delete from Blog_tbl where Id='" + Id_Blog.Text + "'";
                SqlCommand cmd = new SqlCommand(MyQuery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Post Deleted Successfully");
                Con.Close();
                Populate();
                Populate1();
                Populate2();
            }
        }

        private void Id_Blog_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}