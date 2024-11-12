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
    public partial class Start : Form
    {
        public Start()
        {
            if (Stats.meth)
            {
                btnMeth.Visible=false;
                btnMeth.Enabled = false;    
            }
            if (Stats.His)
            {
                btnHis.Visible = false;
                btnHis.Enabled = false;
            }
            if (Stats.His_fig)
            {
                btnHisFig.Visible = false;
                btnHisFig.Enabled = false;
            }
            if (Stats.Prog)
            {
                btnProg.Visible = false;
                btnProg.Enabled = false;
            }
            InitializeComponent();
        }

        private void btnGeo_Click(object sender, EventArgs e)
        {
            Hide();
            Geography g = new Geography();
            g.Show();
        }

        private void btnMeth_Click(object sender, EventArgs e)
        {
            Hide();
            Meth g = new Meth();
            g.Show();
        }

        private void btnHis_Click(object sender, EventArgs e)
        {
            Hide();
            History g = new History();
            g.Show();
        }

        private void btnHisFig_Click(object sender, EventArgs e)
        {
            Hide();
            Historical_Figures g = new Historical_Figures();
            g.Show();
        }

        private void btnProg_Click(object sender, EventArgs e)
        {
            Hide();
            Programing g = new Programing();
            g.Show();
        }
        private void Random_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            var n = rnd.Next(1, 6);
            switch (n)
            {
                case (1):
                    Hide();
                    Geography g = new Geography();
                    g.Show();
                break;
                case (2):
                    Hide();
                    Meth g1 = new Meth();
                    g1.Show();
                    break;
                case (3):
                    Hide();
                    History g2 = new History();
                    g2.Show();
                    break;
                case (4):
                    Hide();
                    Historical_Figures g3 = new Historical_Figures();
                    g3.Show();
                    break;
                case (5):
                    Hide();
                    Programing g4 = new Programing();
                    g4.Show();
                    break;
            }  
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label2.Text = Stats.stats.ToString();
        }
    }
    
} 

