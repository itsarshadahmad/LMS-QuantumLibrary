using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS_Project
{
    public partial class mailus : Form
    {
        public mailus()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            WebBrowser web = new WebBrowser();
            web.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void mailus_Load(object sender, EventArgs e)
        {

        }
    }
}
