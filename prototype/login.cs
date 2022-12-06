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

namespace prototype
{
    public partial class login : Form
    {


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
            //label1.Text = "Hi"; label1.Refresh();
            try { 
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);
            //MessageBox.Show(passwordHash);
            }
            catch { MessageBox.Show("Please enter a password"); }
            
            
            Home instance = new Home();
            instance.Show();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
            this.password = textBox2.Text.ToString();
            
            

        }

    }

}
