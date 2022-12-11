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
    public partial class Edit : Form
    {
        string SYSTEM_NAME, MODEL, OBJECT_TYPE, IP_ADDRESS, LOCATION, NOTE, OWNER_F_NAME, OWNER_L_NAME;
        public Edit()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            this.MODEL = textBox3.Text.ToString();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.OWNER_L_NAME = textBox2.Text.ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.OWNER_F_NAME = textBox1.Text.ToString();
        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            this.SYSTEM_NAME = textBox5.Text.ToString();
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sql1804215DataSet1.HARDWARE' table. You can move, or remove it, as needed.
            this.hARDWARETableAdapter.Fill(this.sql1804215DataSet1.HARDWARE);

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            this.NOTE = textBox5.Text.ToString();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            this.LOCATION = textBox4.Text.ToString();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(@"Data Source=tolmount.abertay.ac.uk;Initial Catalog=sql1804215;Persist Security Info=True;User ID=sql1804215;Password = eu8BP9s3zA");
            //SqlCommand cmd = new SqlCommand("ALTER TABLE HARDWARE ALTER COLUMN column_name datatype; ( SYSTEM_NAME, MODEL, OBJECT_TYPE, IP_ADDRESS, LOCATION, NOTE, OWNER_F_NAME, OWNER_L_NAME) values ( @SYSTEM_NAME, @MODEL, @OBJECT_TYPE, @IP_ADDRESS, @LOCATION, @NOTE, @OWNER_F_NAME, @OWNER_L_NAME)", con);
            //con.Open();
            //cmd.Parameters.AddWithValue("@PRODUCT_NAME", PRODUCT_NAME);
            //cmd.Parameters.AddWithValue("@PRODUCT_INFO", PRODUCT_INFO);


            //int i = cmd.ExecuteNonQuery();

            //con.Close();
        }
    }
}
