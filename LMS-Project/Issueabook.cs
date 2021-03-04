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
    public partial class Issueabook : Form
    {
        public Issueabook()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\Documents\LMS-QuauntumLibrary.mdf;Integrated Security=True;Connect Timeout=30");
        private void FillStudent()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select StudId from StudentTbl ", Con);
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("StudId", typeof(int));
            dt.Load(sdr);
            StdId.ValueMember = "StudId";
            StdId.DataSource = dt;
            Con.Close();
        }
        private void FillBook()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select BookName from BookTbl where Qty>"+0+"", Con);
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("BookName", typeof(string));
            dt.Load(sdr);
            BookCombo.ValueMember = "BookName";
            BookCombo.DataSource = dt;
            Con.Close();
        }
        public void populate()
        {
            Con.Open();
            string query = "select * from IssueTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            IssueDGV.DataSource = ds.Tables[0];
            Con.Close();

        }
        private void fetchstuddata()
        {
            Con.Open();
            string query = "select * from StudentTbl where StudId=" + StdId.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query,Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                StudName.Text = dr["StudName"].ToString();
                StudDept.Text = dr["StudDepartment"].ToString();
                Phonetxtbox.Text = dr["StudPhone"].ToString();

            }
            Con.Close();
        }
        private void updatebook()
        {
            int Qty,newQty;
            Con.Open();
            string query = "select * from BookTbl where BookName='" + BookCombo.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Qty = Convert.ToInt32(dr["Qty"].ToString());
                newQty = Qty - 1;
                string query1 = "update BookTbl set Qty=" + newQty + "where BookName='" + BookCombo.SelectedValue.ToString() + "';";
                SqlCommand cmd1 = new SqlCommand(query1, Con);
                cmd1.ExecuteNonQuery();
            }
            
            Con.Close();
        }
        private void cancelledbook()
        {
            int Qty, newQty;
            Con.Open();
            string query = "select * from BookTbl where BookName='" + BookCombo.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Qty = Convert.ToInt32(dr["Qty"].ToString());
                newQty = Qty + 1;
                string query1 = "update BookTbl set Qty=" + newQty + "where BookName='" + BookCombo.SelectedValue.ToString() + "';";
                SqlCommand cmd1 = new SqlCommand(query1, Con);
                cmd1.ExecuteNonQuery();
            }

            Con.Close();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Homepage hp = new Homepage();
            hp.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Issueabook_Load(object sender, EventArgs e)
        {
            FillStudent();
            FillBook();
            populate();
        }

        private void StdId_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void StdId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchstuddata();
        }

        private void Issuebtn_Click(object sender, EventArgs e)
        {
            if (IssueNum.Text == "" || StudName.Text == "" )
            {
                MessageBox.Show("Opps ! Please Fill all the Fields to Proceed ", "Field is Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string issuedate = IssueDate.Value.Day.ToString() + "/" + IssueDate.Value.Month.ToString() + "/" + IssueDate.Value.Year.ToString();
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into IssueTbl values(" + IssueNum.Text + ",'" + StdId.SelectedValue.ToString() + "','" + StudName.Text + "','" + StudDept.Text + "','" + Phonetxtbox.Text + "','" + issuedate + "','" + BookCombo.SelectedValue.ToString() + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Book Issued Successfully");
                Con.Close();
                updatebook();
                populate();
                IssueNum.Text = "";
                StdId.Text = "";
                StudName.Text = "";
                StudDept.Text = "";
                Phonetxtbox.Text = "";
                BookCombo.Text = "";
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (IssueNum.Text == "")
            {

                MessageBox.Show("Opps ! Please Enter Issue Num ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                Con.Open();
                string query = "delete from IssueTbl where IssueNum=" + IssueNum.Text + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Issue Book Cancelled Successfully ");
                Con.Close();
                cancelledbook();
                populate();
                IssueNum.Text = "";
                StdId.Text = "";
                StudName.Text = "";
                StudDept.Text = "";
                Phonetxtbox.Text = "";
                BookCombo.Text = "";
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            IssueNum.Text = "";
            StdId.Text = "";
            StudName.Text = "";
            StudDept.Text = "";
            Phonetxtbox.Text = "";
            BookCombo.Text = "";
        }

        private void IssueDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.IssueDGV.Rows[e.RowIndex];
                IssueNum.Text = row.Cells["IssueNum"].Value.ToString();
                StdId.Text = row.Cells["StdId"].Value.ToString();
                StudName.Text = row.Cells["StdName"].Value.ToString();
                StudDept.Text = row.Cells["StdDept"].Value.ToString();
                Phonetxtbox.Text = row.Cells["StdPhone"].Value.ToString();
                BookCombo.Text = row.Cells["IssuedBook"].Value.ToString();
                //IssueDate.Text = row.Cells["IssueDate"].Value.ToString();
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Homepage hp = new Homepage();
            hp.Show();
            this.Close();
        }
    }
}
