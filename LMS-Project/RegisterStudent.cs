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
    public partial class RegisterStudent : Form
    {
        public RegisterStudent()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\Documents\LMS-QuauntumLibrary.mdf;Integrated Security=True;Connect Timeout=30");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Homepage H = new Homepage();
            H.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RegisterStudent_Load(object sender, EventArgs e)
        {
            populate();
        }
        public void populate()
        {
            Con.Open();
            string query = "select * from StudentTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            StudentDGV.DataSource = ds.Tables[0];
            Con.Close();

        }
        private void Save_Click(object sender, EventArgs e)
        {
            if (StudId.Text == "" || StudName.Text == ""  || StudSem.Text == "" || StudDept.Text=="" || StudPhone.Text=="")
            {
                MessageBox.Show("Opps ! Please Fill all the Fields to Proceed ", "Field is Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into StudentTbl values(" + StudId.Text + ",'" + StudName.Text + "','" + StudDept.Text + "','"+StudSem.Text+"'," + StudPhone.Text + ")", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student Added Successfully");
                Con.Close();
                populate();
                StudId.Text = "";
                StudName.Text = "";
                StudDept.Text = "";
                StudPhone.Text = "";
                StudSem.Text = "";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.StudentDGV.Rows[e.RowIndex];
                StudId.Text = row.Cells["StudId"].Value.ToString();
                StudName.Text = row.Cells["StudName"].Value.ToString();
                StudDept.Text = row.Cells["StudDepartment"].Value.ToString();
                StudSem.Text = row.Cells["StudSem"].Value.ToString();
                StudPhone.Text = row.Cells["StudPhone"].Value.ToString();

            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (StudId.Text == "")
            {
                MessageBox.Show("Opps ! Please Enter Student ID ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Con.Open();
                string query = "delete from StudentTbl where StudId=" + StudId.Text + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student are Successfully Deleted");
                Con.Close();
                populate();
                StudId.Text = "";
                StudName.Text = "";
                StudDept.Text = "";
                StudPhone.Text = "";
                StudSem.Text = "";
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Homepage HP = new Homepage();
            HP.Show();
            this.Close();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (StudId.Text == "" || StudName.Text == "" || StudDept.Text == "" || StudPhone.Text == "" || StudSem.Text=="")
            {
                MessageBox.Show("Opps ! Please Fill all the Fields to Proceed ", "Field is Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Con.Open();
                string query = "update StudentTbl set StudName='" + StudName.Text + "', StudDepartment='" + StudDept.Text + "',StudSem='" + StudSem.SelectedItem.ToString() + "', StudPhone='" + StudPhone.Text + "' where StudId=" + StudId.Text + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student Details Successfully Updated");
                Con.Close();
                populate();
                StudId.Text = "";
                StudName.Text = "";
                StudDept.Text = "";
                StudPhone.Text = "";
                StudSem.Text = "";
            }
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            StudId.Text = "";
            StudName.Text = "";
            StudDept.Text = "";
            StudPhone.Text = "";
            StudSem.Text = "";

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
