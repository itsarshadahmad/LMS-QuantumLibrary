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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadingPanel2.Width += 4;
            if(LoadingPanel2.Width>=901)
            {
                timer1.Stop();
                Start L2 = new Start();
                L2.Show();
                this.Hide();
            }
        }

        private void LoadingPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SplashCommunity_Click(object sender, EventArgs e)
        {

        }

        private void SplashTagLine_Click(object sender, EventArgs e)
        {

        }
    }
}
