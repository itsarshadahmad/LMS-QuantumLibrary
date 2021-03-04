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
    public partial class StaffRegister : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\Documents\LMS-QuauntumLibrary.mdf;Integrated Security=True;Connect Timeout=30");
        public StaffRegister()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Homepage HP = new Homepage();
            HP.Show();
            this.Close();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Homepage HP = new Homepage();
            HP.Show();
            this.Close();
        }
        public void populate()
        {
            Con.Open();
            string query = "select * from LibrarinTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            LibrarianDGV.DataSource = ds.Tables[0];
            Con.Close();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if(LibId.Text=="" || LibName.Text=="" || Libpass.Text=="" || Libphone.Text=="")
            {
                MessageBox.Show("Opps ! Please Fill all the Fields to Proceed ","Field is Empty",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into LibrarinTbl values(" + LibId.Text + ",'" + LibName.Text + "','" + Libpass.Text + "','" + Libphone.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Librarian Added Successfully");
                Con.Close();
                populate();
                LibId.Text = "";
                LibName.Text = "";
                Libphone.Text = "";
                Libpass.Text = "";
              
            }
            
        }

        private void success_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void StaffRegister_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if(LibId.Text=="")
            {
                MessageBox.Show("Opps! Please Enter the Librarian ID ", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Con.Open();
                string query = "delete from LibrarinTbl where LibId=" + LibId.Text + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Librarian are Successfully Deleted");
                Con.Close();
                populate();
                LibId.Text = "";
                LibName.Text = "";
                Libphone.Text = "";
                Libpass.Text = "";
               
            }
        }
        
        private void LibrarianDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.LibrarianDGV.Rows[e.RowIndex];
                LibId.Text = row.Cells["LibID"].Value.ToString();
                LibName.Text = row.Cells["Libname"].Value.ToString();
                Libpass.Text = row.Cells["LibPassword"].Value.ToString();
                Libphone.Text = row.Cells["Libphone"].Value.ToString();

            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if(LibId.Text == "" || LibName.Text == "" || Libpass.Text == "" || Libphone.Text == "")
            {
                MessageBox.Show("Opps ! Please Enter the Librarian ID ", "Field is Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Con.Open();
                string query = "update LibrarinTbl set LibName='" + LibName.Text + "',LibPassword='" + Libpass.Text + "',Libphone='" + Libphone.Text + "'where LibId=" + LibId.Text + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Librarian Details Successfully Updated");
                Con.Close();
                populate();
                LibId.Text = "";
                LibName.Text = "";
                Libphone.Text = "";
                Libpass.Text = "";
                
            }
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            LibId.Text = "";
            LibName.Text = "";
            Libphone.Text = "";
            Libpass.Text = "";
        
        }
    }
}
