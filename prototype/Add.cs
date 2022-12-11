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
    public partial class Add : Form
    {
        string Fname, MODEL, LOCATION, system_name, NOTE;
        SqlConnection con = new SqlConnection(@"Data Source=tolmount.abertay.ac.uk;Initial Catalog=sql1804215;Persist Security Info=True;User ID=sql1804215;Password = eu8BP9s3zA");

        public Add()
        {
            InitializeComponent();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            this.LOCATION = this.textBox4.Text.ToString();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            this.NOTE = this.textBox5.Text.ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }


        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            this.system_name = this.textBox6.Text.ToString();

        }



        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            this.MODEL = this.textBox3.Text.ToString();

        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.Fname = this.textBox1.Text.ToString();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
          

                    //SYSTEM CONNECTION

                    SqlCommand cmd = new SqlCommand("INSERT INTO HARDWARE ( OWNER_NAME, MODEL, NOTE, SYSTEM_NAME, LOCATION) values ( @Fname, @model, @note, @system, @location)", con);


                    cmd.Parameters.AddWithValue("@model", MODEL);
                    cmd.Parameters.AddWithValue("@Fname", Fname);
                    cmd.Parameters.AddWithValue("@note", NOTE);
                    cmd.Parameters.AddWithValue("@system",system_name);
                    cmd.Parameters.AddWithValue("@location", LOCATION);


                    int i = cmd.ExecuteNonQuery();
                con.Close();
            }
            catch { MessageBox.Show("ERROR! Please ammend information."); }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("ERROR! Please ammend information.");
        }
    }
}
