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

namespace LMS_Project
{
    public partial class StaffLogin : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\Documents\LMS-QuauntumLibrary.mdf;Integrated Security=True;Connect Timeout=30");
        public StaffLogin()
        {
            InitializeComponent();
        }

      

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Start S = new Start();
            S.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ClearBbtn_Click(object sender, EventArgs e)
        {
            Username_txtbox.Text = "";
            password_textbox.Text = "";
        }

        private void username_txtbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {

            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from LibrarinTbl where LibName='" + Username_txtbox.Text + "' and LibPassword='" + password_textbox.Text + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows[0][0].ToString()=="1")
            {
                Homepage H = new Homepage();
                H.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password else One or More Field is Empty - Check Again", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            Con.Close();
        }

        private void password_textbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}