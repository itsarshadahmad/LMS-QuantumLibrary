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
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\Documents\LMS-QuauntumLibrary.mdf;Integrated Security=True;Connect Timeout=30");
        private void button3_Click(object sender, EventArgs e)
        {
            Returnabook RB = new Returnabook();
            RB.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void issueABookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.Show();
            
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void issuebtn_Click(object sender, EventArgs e)
        {
            Issueabook IB = new Issueabook();
            IB.Show();
            this.Hide();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do You Want to Signout ? ", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            StaffLogin SL = new StaffLogin();
            SL.Show();
            this.Hide();

        }

        private void addremovebtn_Click(object sender, EventArgs e)
        {
            Registerabook RB = new Registerabook();
            RB.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want to Exit the Application", "EXIT", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            Application.Exit();


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegisterStudent RS = new RegisterStudent();
            RS.Show();
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            StaffRegister Stfreg = new StaffRegister();
            Stfreg.Show();
            this.Hide();
        }

        private void versionDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version 1.0 - Latest Version by AA King Software Team","Version Detail");
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Registerabook rb = new Registerabook();
            rb.Show();
            this.Close();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda1 = new SqlDataAdapter("select count(*) from BookTbl ", Con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            RBooks.Text = dt1.Rows[0][0].ToString();
            SqlDataAdapter sda2 = new SqlDataAdapter("select count(*) from IssueTbl ", Con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            IBooks.Text = dt2.Rows[0][0].ToString();
            SqlDataAdapter sda3 = new SqlDataAdapter("select count(*) from StudentTbl ", Con);
            DataTable dt3 = new DataTable();
            sda3.Fill(dt3);
            RStudents.Text = dt3.Rows[0][0].ToString();
            SqlDataAdapter sda4 = new SqlDataAdapter("select count(*) from LibrarinTbl ", Con);
            DataTable dt4 = new DataTable();
            sda4.Fill(dt4);
            RLibrarian.Text = dt4.Rows[0][0].ToString();

            Con.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void RStudents_Click(object sender, EventArgs e)
        {
            RegisterStudent rs = new RegisterStudent();
            rs.Show();
            this.Close();
        }

        private void RLibrarian_Click(object sender, EventArgs e)
        {
            StaffRegister sr = new StaffRegister();
            sr.Show();
            this.Close();
        }

        private void IBooks_Click(object sender, EventArgs e)
        {
            Issueabook ib = new Issueabook();
            ib.Show();
            this.Close();
        }

        private void Homepage_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void mailUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mailus ms = new mailus();
            ms.Show();
            
        }

        private void aboutSoftwareUsedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutQL AQL = new AboutQL();
            AQL.Show();
        }

        private void checkForUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No Update Found - You are currently using the Latest Version of Quantum Library ", "Check for Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
