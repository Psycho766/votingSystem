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

        string no = "";
        public Voting(string text)
        {
            InitializeComponent();

            no = text;
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
            SqlCommand sec1 = new SqlCommand("select firstName,lastName from Candidates where position = '" + "secretary" + "' and partylist  = '" + "tingog" + "'", con);
            reader = sec1.ExecuteReader();
            while (reader.Read())
            {
                rbSec1.Text = reader[0].ToString();
                rbSec1.Text += " ";
                rbSec1.Text += reader[1].ToString();
            }


            con.Close();
            con.Open();
            SqlCommand sec2 = new SqlCommand("select firstName,lastName from Candidates where position = '" + "secretary" + "' and partylist  = '" + "padayon" + "'", con);
            reader = sec2.ExecuteReader();
            while (reader.Read())
            {
                rbSec2.Text = reader[0].ToString();
                rbSec2.Text += " ";
                rbSec2.Text += reader[1].ToString();
            }


            con.Close();
            con.Open();
            SqlCommand pir1 = new SqlCommand("select firstName,lastName from Candidates where position = '" + "piro" + "' and partylist  = '" + "tingog" + "'", con);
            reader = pir1.ExecuteReader();
            while (reader.Read())
            {
                rbPir1.Text = reader[0].ToString();
                rbPir1.Text += " ";
                rbPir1.Text += reader[1].ToString();
            }


            con.Close();
            con.Open();
            SqlCommand pir2 = new SqlCommand("select firstName,lastName from Candidates where position = '" + "piro" + "' and partylist  = '" + "padayon" + "'", con);
            reader = pir2.ExecuteReader();
            while (reader.Read())
            {
                rbPir2.Text = reader[0].ToString();
                rbPir2.Text += " ";
                rbPir2.Text += reader[1].ToString();
            }


            con.Close();
            con.Open();
            SqlCommand tre1 = new SqlCommand("select firstName,lastName from Candidates where position = '" + "treasurer" + "' and partylist  = '" + "tingog" + "'", con);
            reader = tre1.ExecuteReader();
            while (reader.Read())
            {
                rbTrea1.Text = reader[0].ToString();
                rbTrea1.Text += " ";
                rbTrea1.Text += reader[1].ToString();
            }


            con.Close();
            con.Open();
            SqlCommand tre2 = new SqlCommand("select firstName,lastName from Candidates where position = '" + "treasurer" + "' and partylist  = '" + "padayon" + "'", con);
            reader = tre2.ExecuteReader();
            while (reader.Read())
            {
                rbTrea2.Text = reader[0].ToString();
                rbTrea2.Text += " ";
                rbTrea2.Text += reader[1].ToString();
            }


            con.Close();
            con.Open();
            SqlCommand au1 = new SqlCommand("select firstName,lastName from Candidates where position = '" + "auditor" + "' and partylist  = '" + "tingog" + "'", con);
            reader = au1.ExecuteReader();
            while (reader.Read())
            {
                rbAu1.Text = reader[0].ToString();
                rbAu1.Text += " ";
                rbAu1.Text += reader[1].ToString();
            }


            con.Close();
            con.Open();
            SqlCommand au2 = new SqlCommand("select firstName,lastName from Candidates where position = '" + "auditor" + "' and partylist  = '" + "padayon" + "'", con);
            reader = au2.ExecuteReader();
            while (reader.Read())
            {
                rbAu2.Text = reader[0].ToString();
                rbAu2.Text += " ";
                rbAu2.Text += reader[1].ToString();
            }
            con.Close();
            con.Open();
            SqlCommand sample = new SqlCommand("select strand from voters where studentNo = '" + no +"'", con);
            reader = sample.ExecuteReader();

            string strand = "";
            while (reader.Read())
            {
                strand = reader[0].ToString();
            }
            con.Close();
            
            if(strand == "TVL")
            {
                con.Open();
                SqlCommand rep1 = new SqlCommand("select firstName,lastName from Candidates where position = '" + "TVL rep." + "' and partylist  = '" + "tingog" + "'", con);
                reader = rep1.ExecuteReader();
                while (reader.Read())
                {
                    rbRep1.Text = reader[0].ToString();
                    rbRep1.Text += " ";
                    rbRep1.Text += reader[1].ToString();
                }
                con.Close();
                con.Open();
                SqlCommand rep2 = new SqlCommand("select firstName,lastName from Candidates where position = '" + "TVL rep." + "' and partylist  = '" + "padayon" + "'", con);
                reader = rep2.ExecuteReader();
                while (reader.Read())
                {
                    rbRep2.Text = reader[0].ToString();
                    rbRep2.Text += " ";
                    rbRep2.Text += reader[1].ToString();
                }
                con.Close();
            }
            else if(strand == "ABM")
            {
                con.Open();
                SqlCommand rep1 = new SqlCommand("select firstName,lastName from Candidates where position = '" + "ABM rep." + "' and partylist  = '" + "tingog" + "'", con);
                reader = rep1.ExecuteReader();
                while (reader.Read())
                {
                    rbRep1.Text = reader[0].ToString();
                    rbRep1.Text += " ";
                    rbRep1.Text += reader[1].ToString();
                }
                con.Close();
                con.Open();
                SqlCommand rep2 = new SqlCommand("select firstName,lastName from Candidates where position = '" + "ABM rep." + "' and partylist  = '" + "padayon" + "'", con);
                reader = rep2.ExecuteReader();
                while (reader.Read())
                {
                    rbRep2.Text = reader[0].ToString();
                    rbRep2.Text += " ";
                    rbRep2.Text += reader[1].ToString();
                }
                con.Close();
            }
            else if (strand == "STEM")
            {
                con.Open();
                SqlCommand rep1 = new SqlCommand("select firstName,lastName from Candidates where position = '" + "STEM rep." + "' and partylist  = '" + "tingog" + "'", con);
                reader = rep1.ExecuteReader();
                while (reader.Read())
                {
                    rbRep1.Text = reader[0].ToString();
                    rbRep1.Text += " ";
                    rbRep1.Text += reader[1].ToString();
                }
                con.Close();
                con.Open();
                SqlCommand rep2 = new SqlCommand("select firstName,lastName from Candidates where position = '" + "STEM rep." + "' and partylist  = '" + "padayon" + "'", con);
                reader = rep2.ExecuteReader();
                while (reader.Read())
                {
                    rbRep2.Text = reader[0].ToString();
                    rbRep2.Text += " ";
                    rbRep2.Text += reader[1].ToString();
                }
                con.Close();
            }
            else
            {
                con.Open();
                SqlCommand rep1 = new SqlCommand("select firstName,lastName from Candidates where position = '" + "GAS rep." + "' and partylist  = '" + "tingog" + "'", con);
                reader = rep1.ExecuteReader();
                while (reader.Read())
                {
                    rbRep1.Text = reader[0].ToString();
                    rbRep1.Text += " ";
                    rbRep1.Text += reader[1].ToString();
                }
                con.Close();
                con.Open();
                SqlCommand rep2 = new SqlCommand("select firstName,lastName from Candidates where position = '" + "GAS rep." + "' and partylist  = '" + "padayon" + "'", con);
                reader = rep2.ExecuteReader();
                while (reader.Read())
                {
                    rbRep2.Text = reader[0].ToString();
                    rbRep2.Text += " ";
                    rbRep2.Text += reader[1].ToString();
                }
                con.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=PSYCHO\\SQLEXPRESS;Initial Catalog=SHS Automated Voting System;Integrated Security=True");
            SqlDataReader reader;

            if(rbPres1.Checked == false && rbPres2.Checked == false || rbVice1.Checked == false && rbVice2.Checked == false || rbSec1.Checked == false && rbSec2.Checked == false || rbPir1.Checked == false &&
                rbPir2.Checked == false || rbTrea1.Checked == false && rbTrea2.Checked == false || rbAu1.Checked == false && rbAu2.Checked == false || rbRep1.Checked == false && rbRep2.Checked == false)
            {
                MessageBox.Show("Please Select One from Each Position!");
            }
            else
            {
                if (rbPres1.Checked == true)
                {
                    con.Open();
                    string name = rbPres1.Text;
                    string[] split = name.Split(' ');
                    SqlCommand cmd = new SqlCommand("select vote from Candidates where firstname = '" + split[0] + "' and lastname = '" + split[1] +"'", con);
                    reader = cmd.ExecuteReader();

                    int count = 0;
                    while (reader.Read())
                    {
                        count = Int32.Parse(reader[0].ToString());
                    }
                    ++count;
                    con.Close();
                    con.Open();
                    SqlCommand update = new SqlCommand("update Candidates set vote = @vote where firstname = '" + split[0] + "' and lastname = '" + split[1] + "'", con);
                    update.Parameters.AddWithValue("@vote", count);
                    update.ExecuteNonQuery();
                    con.Close();

                }
                else
                {
                    con.Open();
                    string name = rbPres2.Text;
                    string[] split = name.Split(' ');
                    SqlCommand cmd = new SqlCommand("select vote from Candidates where firstname = '" + split[0] + "' and lastname = '" + split[1] + "'", con);
                    reader = cmd.ExecuteReader();

                    int count = 0;
                    while (reader.Read())
                    {
                        count = Int32.Parse(reader[0].ToString());
                    }
                    ++count;
                    con.Close();
                    con.Open();
                    SqlCommand update = new SqlCommand("update Candidates set vote = @vote where firstname = '" + split[0] + "' and lastname = '" + split[1] + "'", con);
                    update.Parameters.AddWithValue("@vote", count);
                    update.ExecuteNonQuery();
                    con.Close();
                }
                if (rbVice1.Checked == true)
                {
                    con.Open();
                    string name = rbVice1.Text;
                    string[] split = name.Split(' ');
                    SqlCommand cmd = new SqlCommand("select vote from Candidates where firstname = '" + split[0] + "' and lastname = '" + split[1] + "'", con);
                    reader = cmd.ExecuteReader();

                    int count = 0;
                    while (reader.Read())
                    {
                        count = Int32.Parse(reader[0].ToString());
                    }
                    ++count;
                    con.Close();
                    con.Open();
                    SqlCommand update = new SqlCommand("update Candidates set vote = @vote where firstname = '" + split[0] + "' and lastname = '" + split[1] + "'", con);
                    update.Parameters.AddWithValue("@vote", count);
                    update.ExecuteNonQuery();
                    con.Close();

                }
                else
                {
                    con.Open();
                    string name = rbVice2.Text;
                    string[] split = name.Split(' ');
                    SqlCommand cmd = new SqlCommand("select vote from Candidates where firstname = '" + split[0] + "' and lastname = '" + split[1] + "'", con);
                    reader = cmd.ExecuteReader();

                    int count = 0;
                    while (reader.Read())
                    {
                        count = Int32.Parse(reader[0].ToString());
                    }
                    ++count;
                    con.Close();
                    con.Open();
                    SqlCommand update = new SqlCommand("update Candidates set vote = @vote where firstname = '" + split[0] + "' and lastname = '" + split[1] + "'", con);
                    update.Parameters.AddWithValue("@vote", count);
                    update.ExecuteNonQuery();
                    con.Close();
                }
                if (rbSec1.Checked == true)
                {
                    con.Open();
                    string name = rbSec1.Text;
                    string[] split = name.Split(' ');
                    SqlCommand cmd = new SqlCommand("select vote from Candidates where firstname = '" + split[0] + "' and lastname = '" + split[1] + "'", con);
                    reader = cmd.ExecuteReader();

                    int count = 0;
                    while (reader.Read())
                    {
                        count = Int32.Parse(reader[0].ToString());
                    }
                    ++count;
                    con.Close();
                    con.Open();
                    SqlCommand update = new SqlCommand("update Candidates set vote = @vote where firstname = '" + split[0] + "' and lastname = '" + split[1] + "'", con);
                    update.Parameters.AddWithValue("@vote", count);
                    update.ExecuteNonQuery();
                    con.Close();

                }
                else
                {
                    con.Open();
                    string name = rbSec2.Text;
                    string[] split = name.Split(' ');
                    SqlCommand cmd = new SqlCommand("select vote from Candidates where firstname = '" + split[0] + "' and lastname = '" + split[1] + "'", con);
                    reader = cmd.ExecuteReader();

                    int count = 0;
                    while (reader.Read())
                    {
                        count = Int32.Parse(reader[0].ToString());
                    }
                    ++count;
                    con.Close();
                    con.Open();
                    SqlCommand update = new SqlCommand("update Candidates set vote = @vote where firstname = '" + split[0] + "' and lastname = '" + split[1] + "'", con);
                    update.Parameters.AddWithValue("@vote", count);
                    update.ExecuteNonQuery();
                    con.Close();
                }
                if (rbPir1.Checked == true)
                {
                    con.Open();
                    string name = rbPir1.Text;
                    string[] split = name.Split(' ');
                    SqlCommand cmd = new SqlCommand("select vote from Candidates where firstname = '" + split[0] + "' and lastname = '" + split[1] + "'", con);
                    reader = cmd.ExecuteReader();

                    int count = 0;
                    while (reader.Read())
                    {
                        count = Int32.Parse(reader[0].ToString());
                    }
                    ++count;
                    con.Close();
                    con.Open();
                    SqlCommand update = new SqlCommand("update Candidates set vote = @vote where firstname = '" + split[0] + "' and lastname = '" + split[1] + "'", con);
                    update.Parameters.AddWithValue("@vote", count);
                    update.ExecuteNonQuery();
                    con.Close();

                }
                else
                {
                    con.Open();
                    string name = rbPir2.Text;
                    string[] split = name.Split(' ');
                    SqlCommand cmd = new SqlCommand("select vote from Candidates where firstname = '" + split[0] + "' and lastname = '" + split[1] + "'", con);
                    reader = cmd.ExecuteReader();

                    int count = 0;
                    while (reader.Read())
                    {
                        count = Int32.Parse(reader[0].ToString());
                    }
                    ++count;
                    con.Close();
                    con.Open();
                    SqlCommand update = new SqlCommand("update Candidates set vote = @vote where firstname = '" + split[0] + "' and lastname = '" + split[1] + "'", con);
                    update.Parameters.AddWithValue("@vote", count);
                    update.ExecuteNonQuery();
                    con.Close();
                }
                if (rbTrea1.Checked == true)
                {
                    con.Open();
                    string name = rbTrea1.Text;
                    string[] split = name.Split(' ');
                    SqlCommand cmd = new SqlCommand("select vote from Candidates where firstname = '" + split[0] + "' and lastname = '" + split[1] + "'", con);
                    reader = cmd.ExecuteReader();

                    int count = 0;
                    while (reader.Read())
                    {
                        count = Int32.Parse(reader[0].ToString());
                    }
                    ++count;
                    con.Close();
                    con.Open();
                    SqlCommand update = new SqlCommand("update Candidates set vote = @vote where firstname = '" + split[0] + "' and lastname = '" + split[1] + "'", con);
                    update.Parameters.AddWithValue("@vote", count);
                    update.ExecuteNonQuery();
                    con.Close();

                }
                else
                {
                    con.Open();
                    string name = rbTrea2.Text;
                    string[] split = name.Split(' ');
                    SqlCommand cmd = new SqlCommand("select vote from Candidates where firstname = '" + split[0] + "' and lastname = '" + split[1] + "'", con);
                    reader = cmd.ExecuteReader();

                    int count = 0;
                    while (reader.Read())
                    {
                        count = Int32.Parse(reader[0].ToString());
                    }
                    ++count;
                    con.Close();
                    con.Open();
                    SqlCommand update = new SqlCommand("update Candidates set vote = @vote where firstname = '" + split[0] + "' and lastname = '" + split[1] + "'", con);
                    update.Parameters.AddWithValue("@vote", count);
                    update.ExecuteNonQuery();
                    con.Close();
                }
                if (rbAu1.Checked == true)
                {
                    con.Open();
                    string name = rbAu1.Text;
                    string[] split = name.Split(' ');
                    SqlCommand cmd = new SqlCommand("select vote from Candidates where firstname = '" + split[0] + "' and lastname = '" + split[1] + "'", con);
                    reader = cmd.ExecuteReader();

                    int count = 0;
                    while (reader.Read())
                    {
                        count = Int32.Parse(reader[0].ToString());
                    }
                    ++count;
                    con.Close();
                    con.Open();
                    SqlCommand update = new SqlCommand("update Candidates set vote = @vote where firstname = '" + split[0] + "' and lastname = '" + split[1] + "'", con);
                    update.Parameters.AddWithValue("@vote", count);
                    update.ExecuteNonQuery();
                    con.Close();

                }
                else
                {
                    con.Open();
                    string name = rbAu2.Text;
                    string[] split = name.Split(' ');
                    SqlCommand cmd = new SqlCommand("select vote from Candidates where firstname = '" + split[0] + "' and lastname = '" + split[1] + "'", con);
                    reader = cmd.ExecuteReader();

                    int count = 0;
                    while (reader.Read())
                    {
                        count = Int32.Parse(reader[0].ToString());
                    }
                    ++count;
                    con.Close();
                    con.Open();
                    SqlCommand update = new SqlCommand("update Candidates set vote = @vote where firstname = '" + split[0] + "' and lastname = '" + split[1] + "'", con);
                    update.Parameters.AddWithValue("@vote", count);
                    update.ExecuteNonQuery();
                    con.Close();
                }
                if (rbRep1.Checked == true)
                {
                    con.Open();
                    string name = rbRep1.Text;
                    string[] split = name.Split(' ');
                    SqlCommand cmd = new SqlCommand("select vote from Candidates where firstname = '" + split[0] + "' and lastname = '" + split[1] + "'", con);
                    reader = cmd.ExecuteReader();

                    int count = 0;
                    while (reader.Read())
                    {
                        count = Int32.Parse(reader[0].ToString());
                    }
                    ++count;
                    con.Close();
                    con.Open();
                    SqlCommand update = new SqlCommand("update Candidates set vote = @vote where firstname = '" + split[0] + "' and lastname = '" + split[1] + "'", con);
                    update.Parameters.AddWithValue("@vote", count);
                    update.ExecuteNonQuery();
                    con.Close();

                }
                else
                {
                    con.Open();
                    string name = rbRep2.Text;
                    string[] split = name.Split(' ');
                    SqlCommand cmd = new SqlCommand("select vote from Candidates where firstname = '" + split[0] + "' and lastname = '" + split[1] + "'", con);
                    reader = cmd.ExecuteReader();

                    int count = 0;
                    while (reader.Read())
                    {
                        count = Int32.Parse(reader[0].ToString());
                    }
                    ++count;
                    con.Close();
                    con.Open();
                    SqlCommand update = new SqlCommand("update Candidates set vote = @vote where firstname = '" + split[0] + "' and lastname = '" + split[1] + "'", con);
                    update.Parameters.AddWithValue("@vote", count);
                    update.ExecuteNonQuery();
                    con.Close();
                }

            }

            con.Open();
            SqlCommand status = new SqlCommand("update voters set status = @status where studentNo = '" + no + "'", con);
            status.Parameters.AddWithValue("@status", "voted");
            status.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Thank Your For Voting, Have a Nice Day!");
            Voter_Login vl = new Voter_Login();
            vl.Show();
            this.Hide();


        }
    }
}
