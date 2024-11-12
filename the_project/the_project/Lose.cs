using System;
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
    public partial class Lose : Form
    {
        public Lose()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
                label2.Text = Stats.stats.ToString();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnRetry_Click(object sender, EventArgs e)
        {
            Stats.stats = 0;
            Hide();
            Start g = new Start();
            g.Show();

        }
    }
}
