using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prototype
{
    public partial class SoftSearch : Form
    {
        public SoftSearch()
        {
            InitializeComponent();
        }

        private void SoftSearch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sql1804215DataSet.HARDWARE' table. You can move, or remove it, as needed.
            this.hARDWARETableAdapter.Fill(this.sql1804215DataSet.HARDWARE);

        }
    }
}
