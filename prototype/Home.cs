using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace prototype
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            
        }

        //MorganGet System Information using enviroment [source code]. https://morgantechspace.com/2015/08/get-system-information-in-c-sharp.html
        
        private void dvd_Click(object sender, EventArgs e)
        {
            Edit instance = new Edit();
            instance.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add instance = new Add();
            instance.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Remove instance = new Remove();
            instance.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Search instance = new Search();
            instance.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            //MorganGet System Information using enviroment [source code]. https://morgantechspace.com/2015/08/get-system-information-in-c-sharp.html
            // get IP infor
            string localIP = string.Empty;
            using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
            {
                socket.Connect("8.8.8.8", 65530);
                IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
                localIP = endPoint.Address.ToString();
            }
            // Get OS Name
         
            

               


            // Other computer INFORMATION
            string SYSTEM_NAME = Environment.MachineName;
            string OWNER_F_NAME = Environment.UserName;
            Environment.UserDomainName.ToString();
            Environment.OSVersion.Version.ToString(); // the numbers




            //SYSTEM CONNECTION
            SqlConnection con = new SqlConnection(@"Data Source=tolmount.abertay.ac.uk;Initial Catalog=sql1804215;Persist Security Info=True;User ID=sql1804215;Password = eu8BP9s3zA");
            SqlCommand cmd = new SqlCommand("INSERT INTO HARDWARE ( SYSTEM_NAME, IP_ADDRESS, OWNER_F_NAME) values ( @SYSTEM_NAME, @IP_ADDRESS, @OWNER_F_NAME)", con);
            con.Open(); 


            cmd.Parameters.AddWithValue("@SYSTEM_NAME", SYSTEM_NAME);
            cmd.Parameters.AddWithValue("@IP_ADDRESS", localIP);
            cmd.Parameters.AddWithValue("@OWNER_F_NAME", OWNER_F_NAME);


            int i = cmd.ExecuteNonQuery();

            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Oh noes!", "My Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
