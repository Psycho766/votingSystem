﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    }
}
