﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace the_project
{
    public partial class Historical_Figures : Form
    {
        public Historical_Figures()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Continue_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Lenin")
            {
                Stats.His_fig = true;
                Stats.stats += 1;
                Hide();
                Start g = new Start();
                g.Show();
            }
            else
            {
                Hide();
                Lose g = new Lose();
                g.Show();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = Stats.stats.ToString();
        }
    }
}