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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            

        }

        private void tbUserEnter(object sender, EventArgs e)
        {
            if (tbUser.Text.Equals(@"Username"))
            {
                tbUser.Text = "";
            }
        } 

        private void tbUserLeave(object sender, EventArgs e)
        {
            if (tbUser.Text.Equals(""))
            {
                tbUser.Text = @"Username";
            }
                
        }

        private void tbPassEnter(object sender, EventArgs e)
        {
            if (tbPass.Text.Equals(@"Password"))
            {
                tbPass.Text = "";
            }
        }

        private void tbPassLeave(object sender, EventArgs e)
        {
            if (tbPass.Text.Equals(""))
            {
                tbPass.Text = @"Password";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=PSYCHO\\SQLEXPRESS;Initial Catalog=SHS Automated Voting System;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Admin where username = '" + tbUser.Text.Trim() + "'and password = '" + tbPass.Text.Trim() + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            
            if (dt.Rows.Count == 1)
            {
                Dashboard d = new Dashboard();
                d.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("INVALID USERNAME/PASSWORD");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
