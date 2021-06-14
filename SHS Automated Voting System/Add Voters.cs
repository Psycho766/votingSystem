using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHS_Automated_Voting_System
{
    public partial class Add_Voters : Form
    {
        public Add_Voters()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            d.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=PSYCHO\\SQLEXPRESS;Initial Catalog=SHS Automated Voting System;Integrated Security=True");
            con.Open();


            if (tbNo.Text == "" || tbName.Text == "" || tbStrand.Text == "")
            {

            }
            else
            {
                SqlCommand cmd = new SqlCommand("insert into Voters values(@studentNo,@name,@strand)", con);
                cmd.Parameters.AddWithValue("@studentNo", tbNo.Text);
                cmd.Parameters.AddWithValue("@name", tbName.Text.Trim());
                cmd.Parameters.AddWithValue("@strand", tbStrand.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Added Sucessfully!");

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
