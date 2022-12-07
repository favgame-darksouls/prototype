using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;
using System.Data.SqlClient;

namespace prototype
{
    public partial class login : Form
    {

        string username;
        string password;
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            try {
                string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);
            SqlConnection con = new SqlConnection(@"Data Source=tolmount.abertay.ac.uk;Initial Catalog=sql1804215;Persist Security Info=True;User ID=sql1804215;Password = eu8BP9s3zA");
            SqlCommand cmd = new SqlCommand("select ID from USERS where ID = @EMAIL AND PASS_HASH = @PASSWORD_HASH", con);
                con.Open();
                cmd.Parameters.AddWithValue("@EMAIL", username);
                cmd.Parameters.AddWithValue("@PASSWORD_HASH", passwordHash);

                int i = cmd.ExecuteNonQuery();
                

                if (i != 0)
                {
                    Home instance = new Home();
                    instance.Show();
                    //this.Close();
                }
                //else { MessageBox.Show(ys); }
                
            }
            catch { MessageBox.Show("Please Fill in all fields"); }



            

        
            

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
            this.password = textBox2.Text.ToString();
            
            

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.username = textBox1.Text.ToString();
        }
    }

}
