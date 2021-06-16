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

            SqlCommand cmd = new SqlCommand("SELECT * FROM Voters where studentNo = '" + tbNo.Text.Trim() + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);


            if (dt.Rows.Count == 1)
            {
                Voting v = new Voting();
                v.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Not Registered!");
            }


        }
    }
}
