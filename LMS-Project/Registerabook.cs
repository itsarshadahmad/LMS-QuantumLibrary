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
    public partial class Registerabook : Form
    {
        public Registerabook()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\Documents\LMS-QuauntumLibrary.mdf;Integrated Security=True;Connect Timeout=30");
        private void Registerabook_Load(object sender, EventArgs e)
        {
            populate();
        }
        public void populate()
        {
            Con.Open();
            string query = "select * from BookTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            BookDGV.DataSource = ds.Tables[0];
            Con.Close();

        }
        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Homepage hp = new Homepage();
            hp.Show();
            this.Hide();
        }


        private void label10_Click(object sender, EventArgs e)
        {

        }

       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (BookName.Text == "" || Author.Text == "" || Publisher.Text == "" || Price.Text == "" || Qty.Text == "")
            {
                MessageBox.Show("Opps ! Please Fill all the Fields to Proceed ", "Field is Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into BookTbl values('" + BookName.Text + "','" + Author.Text + "','" + Publisher.Text + "','" + Price.Text + "'," + Qty.Text + ")", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Book Added Successfully");
                Con.Close();
                populate();
                BookName.Text = "";
                Author.Text = "";
                Publisher.Text = "";
                Price.Text = "";
                Qty.Text = "";
            }
        }

        private void BookDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.BookDGV.Rows[e.RowIndex];
                BookName.Text = row.Cells["BookName"].Value.ToString();
                Author.Text = row.Cells["Author"].Value.ToString();
                Publisher.Text = row.Cells["Publisher"].Value.ToString();
                Price.Text = row.Cells["Price"].Value.ToString();
                Qty.Text = row.Cells["Qty"].Value.ToString();

            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (BookName.Text == "" || Author.Text == "" || Publisher.Text == "" || Price.Text == "" || Qty.Text == "")
            {
                MessageBox.Show("Opps ! Please Fill all the Fields to Proceed ", "Field is Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Con.Open();
                string query = "update BookTbl set BookName= '" + BookName.Text + "', Author='" + Author.Text + "',Publisher='" + Publisher.Text + "', Price='" + Price.Text + "', Qty=" + Qty.Text + " where BookName='" + BookName.Text + "';";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Book Details Successfully Updated");
                Con.Close();
                populate();
                BookName.Text = "";
                Author.Text = "";
                Publisher.Text = "";
                Price.Text = "";
                Qty.Text = "";
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (BookName.Text == "")
            {
                MessageBox.Show("Opps ! Please Enter the Book ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Con.Open();
                string query = "delete from BookTbl where BookName= '" + BookName.Text + "';";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Deleted the Book");
                Con.Close();
                populate();
                BookName.Text = "";
                Author.Text = "";
                Publisher.Text = "";
                Price.Text = "";
                Qty.Text = "";
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Homepage HP = new Homepage();
            HP.Show();
            this.Close();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            BookName.Text = "";
            Author.Text = "";
            Publisher.Text = "";
            Price.Text = "";
            Qty.Text = "";
        }
    }

}
