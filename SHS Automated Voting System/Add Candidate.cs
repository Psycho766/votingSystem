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
    public partial class Add_Candidate : Form
    {
        public Add_Candidate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=PSYCHO\\SQLEXPRESS;Initial Catalog=SHS Automated Voting System;Integrated Security=True");
            con.Open();


            SqlCommand el = new SqlCommand("select electionID from Elections where ElectionYear = '" + tbYear.Text.Trim() + "'",con);
            SqlDataReader reader = el.ExecuteReader();
            int id = 0;
            while (reader.Read())
            {
                id = reader.GetInt32(0);
            }

            con.Close();

            


            if (tbFirst.Text == "" || tbMiddle.Text == "" || tbLast.Text == "")
            {

            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Candidates values(@firstName,@middleName,@lastName,@partylist,@position,@strand,@year,@electionID,@vote)", con);
                cmd.Parameters.AddWithValue("@firstName", tbFirst.Text.ToLower());
                cmd.Parameters.AddWithValue("@middleName", tbMiddle.Text.ToLower());
                cmd.Parameters.AddWithValue("@lastName", tbLast.Text.ToLower());
                cmd.Parameters.AddWithValue("@partylist", cbPartylist.Text);
                cmd.Parameters.AddWithValue("@position", cbPosition.Text);
                cmd.Parameters.AddWithValue("@strand", cbStrand.Text);
                cmd.Parameters.AddWithValue("@year", tbYear.Text);
                cmd.Parameters.AddWithValue("@electionID", id);
                cmd.Parameters.AddWithValue("@vote", 0);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Added Sucessfully!");

            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            d.Show();
            this.Close();
        }
    }
}
