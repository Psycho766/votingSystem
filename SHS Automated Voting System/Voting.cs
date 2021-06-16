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
    public partial class Voting : Form
    {
        public Voting()
        {
            InitializeComponent();
        }

        private void Voting_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=PSYCHO\\SQLEXPRESS;Initial Catalog=SHS Automated Voting System;Integrated Security=True");
            con.Open();
            SqlDataReader reader;

            SqlCommand pres1 = new SqlCommand("select firstName,lastName from Candidates where position = '" + "president" + "' and partylist  = '" + "Tingog" + "'", con);
            reader = pres1.ExecuteReader();
            while (reader.Read())
            {
                rbPres1.Text = reader[0].ToString();
                rbPres1.Text += " ";
                rbPres1.Text += reader[1].ToString();
            }
            con.Close();
            con.Open();
            SqlCommand pres2 = new SqlCommand("select firstName,lastName from Candidates where position = '" + "president" + "' and partylist  = '" + "Padayon" + "'", con);
            reader = pres2.ExecuteReader();
            while (reader.Read())
            {
                rbPres2.Text = reader[0].ToString();
                rbPres2.Text += " ";
                rbPres2.Text += reader[1].ToString();
            }


            con.Close();
            con.Open();
            SqlCommand vice1 = new SqlCommand("select firstName,lastName from Candidates where position = '" + "vice president" + "' and partylist  = '" + "Tingog" + "'", con);
            reader = vice1.ExecuteReader();
            while (reader.Read())
            {
                rbVice1.Text = reader[0].ToString();
                rbVice1.Text += " ";
                rbVice1.Text += reader[1].ToString();
            }


            con.Close();
            con.Open();
            SqlCommand vice2 = new SqlCommand("select firstName,lastName from Candidates where position = '" + "vice president" + "' and partylist  = '" + "Padayon" + "'", con);
            reader = vice2.ExecuteReader();
            while (reader.Read())
            {
                rbVice2.Text = reader[0].ToString();
                rbVice2.Text += " ";
                rbVice2.Text += reader[1].ToString();
            }


            con.Close();
            con.Open();
            SqlCommand sec1 = new SqlCommand("select firstName,lastName from Candidates where position = '" + "vice president" + "' and partylist  = '" + "Padayon" + "'", con);
            reader = sec1.ExecuteReader();
            while (reader.Read())
            {
                rbVice2.Text = reader[0].ToString();
                rbVice2.Text += " ";
                rbVice2.Text += reader[1].ToString();
            }


            con.Close();
            con.Open();
            SqlCommand sec2 = new SqlCommand("select firstName,lastName from Candidates where position = '" + "secretary" + "' and partylist  = '" + "Padayon" + "'", con);
            reader = sec2.ExecuteReader();
            while (reader.Read())
            {
                rbSec1.Text = reader[0].ToString();
                rbSec1.Text += " ";
                rbSec1.Text += reader[1].ToString();
            }


            con.Close();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
