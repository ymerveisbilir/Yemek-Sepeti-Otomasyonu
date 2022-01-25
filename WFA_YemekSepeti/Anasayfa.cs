using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_YemekSepeti
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            burger BK = new burger();
            this.Hide();
            BK.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GreenSalads gs = new GreenSalads();
            this.Hide();
            gs.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Dominos ds = new Dominos();
            this.Hide();
            ds.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {

            bayramoglu by = new bayramoglu();
            this.Hide();
            by.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            BakırköyProfiterol bp = new BakırköyProfiterol();
            this.Hide();
            bp.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            FarukGulluoglu fg = new FarukGulluoglu();
            this.Hide();
            fg.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            popeyes pp = new popeyes();
            this.Hide();
            pp.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            baydoner bd = new baydoner();
            this.Hide();
            bd.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            terrapizza tp = new terrapizza();
            this.Hide();
            tp.ShowDialog();    
           
        }
    }
}
