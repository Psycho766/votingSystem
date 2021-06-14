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
    public partial class Create_Election : Form
    {
        public Create_Election()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            d.Show();
            this.Hide();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=PSYCHO\\SQLEXPRESS;Initial Catalog=SHS Automated Voting System;Integrated Security=True");
            con.Open();
            if(tbDuration.Text == "" || tbTitle.Text == "")
            {

            }
            else
            {
                SqlCommand cmd = new SqlCommand("insert into Elections values(@electionTitle,@electionDuration)", con);
                cmd.Parameters.AddWithValue("@electionTitle", tbTitle.Text);
                cmd.Parameters.AddWithValue("@electionDuration", tbDuration.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Created Sucessfully!");

            }

        }
    }
}
