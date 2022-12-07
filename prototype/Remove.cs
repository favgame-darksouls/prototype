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
    public partial class Remove : Form
    {
        string Fname, Lname, MODEL, system_name, IP, ID;
        string[] array2 = new string[5];
        SqlConnection con = new SqlConnection(@"Data Source=tolmount.abertay.ac.uk;Initial Catalog=sql1804215;Persist Security Info=True;User ID=sql1804215;Password = eu8BP9s3zA");


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            this.array2[0] = this.textBox6.Text.ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            this.array2[1] = this.textBox6.Text.ToString();
        }

        private void Remove_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            this.array2[2] = this.textBox3.Text.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.array2[3] = this.textBox2.Text.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach( string i in array2) { 
                if (i != "") {
                    ID = ID + "and" + i;
                }
            }
            try { 
            SqlCommand cmd = new SqlCommand("DELETE FROM USERS WHERE IP = @IP" + ID, con);


            cmd.Parameters.AddWithValue("@strng", ID);
            cmd.Parameters.AddWithValue("@system", system_name);




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

        public Remove()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.array2[4] = this.textBox1.Text.ToString();
        }
    }
}
