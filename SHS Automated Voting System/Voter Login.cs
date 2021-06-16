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
    public partial class Voter_Login : Form
    {
        public Voter_Login()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=PSYCHO\\SQLEXPRESS;Initial Catalog=SHS Automated Voting System;Integrated Security=True");
            con.Open();
            SqlDataReader reader;

            SqlCommand status = new SqlCommand("select status from Voters where studentNo = '" + tbNo.Text.Trim() + "'", con);
            reader = status.ExecuteReader();
            string stat = "";
            while (reader.Read())
            {
                stat = reader[0].ToString();
            }
            con.Close();

            if (stat != "voted")
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Voters where studentNo = '" + tbNo.Text.Trim() + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);


                if (dt.Rows.Count == 1)
                {
                    Voting v = new Voting(tbNo.Text);
                    v.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Not Registered!");
                }
            }
            else
            {
                MessageBox.Show("Already Voted!");
            }


            


        }

        public void tbNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
