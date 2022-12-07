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
namespace prototype
{
    public partial class AddUser : Form
    {
        string ID, Fname, Lname, password, position;
        SqlConnection con = new SqlConnection(@"Data Source=tolmount.abertay.ac.uk;Initial Catalog=sql1804215;Persist Security Info=True;User ID=sql1804215;Password = eu8BP9s3zA");

        public AddUser()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            this.ID = textBox3.Text.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.Lname = textBox2.Text.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.Fname = textBox1.Text.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);
                SqlCommand cmd = new SqlCommand("DELETE FROM USERS WHERE ID = @ID AND PASS_HASH = @password;", con);


                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@password", passwordHash);
                



                int i = cmd.ExecuteNonQuery();
                //string ys = i.ToString();
                //MessageBox.Show(ys);
                if (i != 0)
                {

                    MessageBox.Show("User " + ID + " deleted");
                }
                else
                {
                    MessageBox.Show("User doesn't exhists");
                };
            }
            catch { MessageBox.Show("Please fill in all fields!"); }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            this.password = textBox6.Text.ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            this.position = textBox4.Text.ToString();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // add user button
            try
            {
                string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);
                SqlCommand cmd = new SqlCommand("select ID from USERS where ID = @ID", con);
                //con.Open();

                cmd.Parameters.AddWithValue("@ID", ID);
                int i = cmd.ExecuteNonQuery();

                if (i == 0)
                {

                    //SYSTEM CONNECTION

                    cmd = new SqlCommand("INSERT INTO USERS ( FIRST_NAME, LAST_NAME, ID, PASS_HASH, TITLE) values ( @Fname, @Lname,@ID, @password, @position)", con);


                    cmd.Parameters.AddWithValue("@ID", ID);
                    cmd.Parameters.AddWithValue("@Fname", Fname);
                    cmd.Parameters.AddWithValue("@Lname", Lname);
                    cmd.Parameters.AddWithValue("@password", passwordHash);
                    cmd.Parameters.AddWithValue("@position", position);
                    


                    i = cmd.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("User already exhists");
                };
            }
            catch { MessageBox.Show("Please fill in all fields!"); }
        }
    }
}
