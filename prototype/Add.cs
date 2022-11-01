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
        string SYSTEM_NAME, MODEL, OBJECT_TYPE, IP_ADDRESS, LOCATION, NOTE, OWNER_F_NAME, OWNER_L_NAME;

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
            this.LOCATION = this.textBox3.Text.ToString();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            this.NOTE = this.textBox3.Text.ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }


        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            this.LOCATION = this.textBox3.Text.ToString();

        }



        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            this.MODEL = this.textBox3.Text.ToString();

        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.OWNER_L_NAME = this.textBox3.Text.ToString();

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.OWNER_F_NAME = this.textBox3.Text.ToString();

        }


        private void button1_Click(object sender, EventArgs e)
        {
           // SqlConnection con = new SqlConnection(@"Data Source=tolmount.abertay.ac.uk;Initial Catalog=sql1804215;Persist Security Info=True;User ID=sql1804215;Password = eu8BP9s3zA");
            //SqlCommand cmd = new SqlCommand("INSERT INTO PRODUCTS ( PRODUCT_NAME, PRODUCT_INFO, CATEGORY, TOTAL_STOCK, PRICE, DISCOUNT, AVAILABLE_STOCK, DISCOUNT_START, DISCOUNT_END) values ( @PRODUCT_NAME, @PRODUCT_INFO, @CATEGORY, @TOTAL_STOCK, @PRICE, @DISCOUNT, @AVAILABLE_STOCK, @DISCOUNT_START, @DISCOUNT_END)", con);
            //con.Open();
            //cmd.Parameters.AddWithValue("@PRODUCT_NAME", PRODUCT_NAME);
            //cmd.Parameters.AddWithValue("@PRODUCT_INFO", PRODUCT_INFO);
            

            //int i = cmd.ExecuteNonQuery();

            //con.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
