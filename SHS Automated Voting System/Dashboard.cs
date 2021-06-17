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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            Create_Election ce = new Create_Election();
            ce.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Add_Candidate ac = new Add_Candidate();
            ac.Show();
            this.Hide();
        }

        private void btnVoters_Click(object sender, EventArgs e)
        {
            Add_Voters av = new Add_Voters();
            av.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Voter_Login vl = new Voter_Login();
            vl.Show();
            this.Hide();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=PSYCHO\\SQLEXPRESS;Initial Catalog=SHS Automated Voting System;Integrated Security=True");
            
            con.Open();
            SqlCommand election = new SqlCommand("select * from elections", con);
            SqlDataAdapter da = new SqlDataAdapter(election);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvElect.DataSource = dt;
            con.Close();


            con.Open();
            SqlCommand voter = new SqlCommand("select * from voters", con);
            SqlDataAdapter da1 = new SqlDataAdapter(voter);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dgvVoters.DataSource = dt1;
            con.Close();



            con.Open();
            SqlCommand candidates = new SqlCommand("select * from candidates", con);
            SqlDataAdapter da2 = new SqlDataAdapter(candidates);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dgvCandidates.DataSource = dt2;
            con.Close();




            con.Open();
            SqlCommand result = new SqlCommand("select * from candidates", con);
            SqlDataAdapter da3 = new SqlDataAdapter(result);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            dgvResult.DataSource = dt3;
            con.Close();


        }
    }
}
