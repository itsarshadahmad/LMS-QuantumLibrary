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
    public partial class Returnabook : Form
    {
        public Returnabook()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\Documents\LMS-QuauntumLibrary.mdf;Integrated Security=True;Connect Timeout=30");
        
        public void populate()
        {
            Con.Open();
            string query = "select * from IssueTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ReturnDGV.DataSource = ds.Tables[0];
            Con.Close();

        }
        //public void populatereturn()
        //{
        //    Con.Open();
        //    string query = "select * from ReturnTbl";
        //    SqlDataAdapter da = new SqlDataAdapter(query, Con);
        //    SqlCommandBuilder builder = new SqlCommandBuilder(da);
        //    var ds = new DataSet();
        //    da.Fill(ds);
        //    ReturnDGV.DataSource = ds.Tables[0];
        //    Con.Close();

        //}
        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Homepage hp = new Homepage();
            hp.Show();
            this.Hide();
        }

        private void backToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Homepage hp = new Homepage();
            hp.Show();
            this.Hide();
        }
        private void FillBook()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select BookName from BookTbl where Qty>" + 0 + "", Con);
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("BookName", typeof(string));
            dt.Load(sdr);
            //BookCombo.Text = "BookName";
           // BookCombo.DataSource = dt;
            Con.Close();
        }
        private void Returnabook_Load(object sender, EventArgs e)
        {
            populate();
            //populatereturn();
            FillBook();
        }

        private void IssuedDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.ReturnDGV.Rows[e.RowIndex];
                ReturnNum.Text = row.Cells["IssueNum"].Value.ToString();
                StdId.Text = row.Cells["StdId"].Value.ToString();
                StudName.Text = row.Cells["StdName"].Value.ToString();
                StudDept.Text = row.Cells["StdDept"].Value.ToString();
                Phonetxtbox.Text = row.Cells["StdPhone"].Value.ToString();
                BookCombo.Text = row.Cells["IssuedBook"].Value.ToString();
            }
        }
        private void updatebook()
        {
            int Qty, newQty;
            Con.Open();
            string query = "select * from BookTbl where BookName='" + BookCombo.Text + "'";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Qty = Convert.ToInt32(dr["Qty"].ToString());
                newQty = Qty + 1;
                string query1 = "update BookTbl set Qty=" + newQty + "where BookName='" + BookCombo.Text + "';";
                SqlCommand cmd1 = new SqlCommand(query1, Con);
                cmd1.ExecuteNonQuery();
            }

            Con.Close();
        }
        private void cancelledbook()
        {
            int Qty, newQty;
            Con.Open();
            string query = "select * from BookTbl where BookName='" + BookCombo.Text + "'";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Qty = Convert.ToInt32(dr["Qty"].ToString());
                newQty = Qty + 1;
                string query1 = "update BookTbl set Qty=" + newQty + "where BookName='" + BookCombo.Text + "';";
                SqlCommand cmd1 = new SqlCommand(query1, Con);
                cmd1.ExecuteNonQuery();
            }

            Con.Close();
        }
        private void Returnbtn_Click(object sender, EventArgs e)
        {
            if (ReturnNum.Text == "")
            {

                MessageBox.Show("Opps ! Please Fill all the Fields to Proceed ", "Field is Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                Con.Open();
                string query = "delete from IssueTbl where IssueNum=" + ReturnNum.Text + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Issue Book Returned and the Stock of Books updated Successfully  ");
                Con.Close();
                cancelledbook();
                populate();
                ReturnNum.Text = "";
                StdId.Text = "";
                StudName.Text = "";
                StudDept.Text = "";
                Phonetxtbox.Text = "";
                BookCombo.Text = "";
            }

        }

        private void ReturnedDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {

        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            ReturnNum.Text = "";
            StdId.Text = "";
            StudName.Text = "";
            StudDept.Text = "";
            Phonetxtbox.Text = "";
            BookCombo.Text = "";
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            Homepage hp = new Homepage();
            hp.Show();
            this.Close();
        }
    }
}
