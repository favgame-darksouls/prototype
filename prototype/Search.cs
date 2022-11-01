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
    public partial class Search : Form
    {
        string SYSTEM_NAME, MODEL, OBJECT_TYPE, IP_ADDRESS, LOCATION, NOTE, OWNER_F_NAME, OWNER_L_NAME;

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            this.LOCATION = this.textBox4.Text.ToString();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            this.SYSTEM_NAME = this.textBox6.Text.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            this.MODEL = this.textBox3.Text.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.OWNER_L_NAME = this.textBox2.Text.ToString();
        }

        public Search()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.OWNER_F_NAME = this.textBox1.Text.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(@"Data Source=tolmount.abertay.ac.uk;Initial Catalog=sql1804215;Persist Security Info=True;User ID=sql1804215;Password = eu8BP9s3zA");
            //SqlCommand cmd = new SqlCommand("INSERT INTO PRODUCTS ( PRODUCT_NAME, PRODUCT_INFO, CATEGORY, TOTAL_STOCK, PRICE, DISCOUNT, AVAILABLE_STOCK, DISCOUNT_START, DISCOUNT_END) values ( @PRODUCT_NAME, @PRODUCT_INFO, @CATEGORY, @TOTAL_STOCK, @PRICE, @DISCOUNT, @AVAILABLE_STOCK, @DISCOUNT_START, @DISCOUNT_END)", con);
            //con.Open();
            //cmd.Parameters.AddWithValue("@PRODUCT_NAME", PRODUCT_NAME);
            //cmd.Parameters.AddWithValue("@PRODUCT_INFO", PRODUCT_INFO);


            //int i = cmd.ExecuteNonQuery();

            //con.Close();
        }
    }
}
