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
    public partial class Bayramoğlu : Form
    {
        public Bayramoğlu()
        {
            InitializeComponent();
        }


        private void button16_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 55;

            if (int.TryParse(txt1.Text, out yemekAdeti))
            {
                txt1.Text = (yemekAdeti + 1).ToString();
                label14.Text = Convert.ToString(yemekFiyati * (yemekAdeti + 1) + ",99 TL");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 55;

            if (int.TryParse(txt1.Text, out yemekAdeti))
            {
                txt1.Text = (yemekAdeti - 1).ToString();
                label14.Text = Convert.ToString(yemekFiyati * (yemekAdeti - 1) + ",99 TL");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 69;

            if (int.TryParse(txt2.Text, out yemekAdeti))
            {
                txt2.Text = (yemekAdeti + 1).ToString();
                label7.Text = Convert.ToString(yemekFiyati * (yemekAdeti + 1) + ",99 TL");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 69;

            if (int.TryParse(txt2.Text, out yemekAdeti))
            {
                txt2.Text = (yemekAdeti - 1).ToString();
                label7.Text = Convert.ToString(yemekFiyati * (yemekAdeti - 1) + ",99 TL");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 44;

            if (int.TryParse(txt3.Text, out yemekAdeti))
            {
                txt3.Text = (yemekAdeti + 1).ToString();
                label8.Text = Convert.ToString(yemekFiyati * (yemekAdeti + 1) + ",99 TL");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 44;

            if (int.TryParse(txt3.Text, out yemekAdeti))
            {
                txt3.Text = (yemekAdeti - 1).ToString();
                label8.Text = Convert.ToString(yemekFiyati * (yemekAdeti - 1) + ",99 TL");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 50;

            if (int.TryParse(txt4.Text, out yemekAdeti))
            {
                txt4.Text = (yemekAdeti + 1).ToString();
                label9.Text = Convert.ToString(yemekFiyati * (yemekAdeti + 1) + ",99 TL");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 50;

            if (int.TryParse(txt4.Text, out yemekAdeti))
            {
                txt4.Text = (yemekAdeti - 1).ToString();
                label9.Text = Convert.ToString(yemekFiyati * (yemekAdeti - 1) + ",99 TL");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 58;

            if (int.TryParse(txt5.Text, out yemekAdeti))
            {
                txt5.Text = (yemekAdeti + 1).ToString();
                label1.Text = Convert.ToString(yemekFiyati * (yemekAdeti + 1) + ",99 TL");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 58;

            if (int.TryParse(txt5.Text, out yemekAdeti))
            {
                txt5.Text = (yemekAdeti - 1).ToString();
                label1.Text = Convert.ToString(yemekFiyati * (yemekAdeti - 1) + ",99 TL");
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            int icecekAdeti = 1;
            int icecekFiyati = 15;

            if (int.TryParse(txt6.Text, out icecekAdeti))
            {
                txt6.Text = (icecekAdeti + 1).ToString();
                label22.Text = Convert.ToString(icecekFiyati * (icecekAdeti + 1) + ",99 TL");
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            int icecekAdeti = 1;
            int icecekFiyati = 15;

            if (int.TryParse(txt6.Text, out icecekAdeti))
            {
                txt6.Text = (icecekAdeti - 1).ToString();
                label22.Text = Convert.ToString(icecekFiyati * (icecekAdeti - 1) + ",99 TL");
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            int icecekAdeti = 1;
            int icecekFiyati = 10;

            if (int.TryParse(txt7.Text, out icecekAdeti))
            {
                txt7.Text = (icecekAdeti + 1).ToString();
                label23.Text = Convert.ToString(icecekFiyati * (icecekAdeti + 1) + ",99 TL");
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            int icecekAdeti = 1;
            int icecekFiyati = 10;

            if (int.TryParse(txt7.Text, out icecekAdeti))
            {
                txt7.Text = (icecekAdeti - 1).ToString();
                label23.Text = Convert.ToString(icecekFiyati * (icecekAdeti - 1) + ",99 TL");
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            int icecekAdeti = 1;
            int icecekFiyati = 5;

            if (int.TryParse(txt8.Text, out icecekAdeti))
            {
                txt8.Text = (icecekAdeti + 1).ToString();
                label24.Text = Convert.ToString(icecekFiyati * (icecekAdeti + 1) + ",99 TL");
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            int icecekAdeti = 1;
            int icecekFiyati = 5;

            if (int.TryParse(txt8.Text, out icecekAdeti))
            {
                txt8.Text = (icecekAdeti - 1).ToString();
                label24.Text = Convert.ToString(icecekFiyati * (icecekAdeti - 1) + ",99 TL");
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            int tatlıAdeti = 1;
            int tatlıFiyati = 27;

            if (int.TryParse(txt9.Text, out tatlıAdeti))
            {
                txt9.Text = (tatlıAdeti + 1).ToString();
                label13.Text = Convert.ToString(tatlıFiyati * (tatlıAdeti + 1) + ",99 TL");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            int tatlıAdeti = 1;
            int tatlıFiyati = 27;

            if (int.TryParse(txt9.Text, out tatlıAdeti))
            {
                txt9.Text = (tatlıAdeti - 1).ToString();
                label13.Text = Convert.ToString(tatlıFiyati * (tatlıAdeti - 1) + ",99 TL");
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {

            int tatlıAdeti = 1;
            int tatlıFiyati = 35;

            if (int.TryParse(txt10.Text, out tatlıAdeti))
            {
                txt10.Text = (tatlıAdeti + 1).ToString();
                label16.Text = Convert.ToString(tatlıFiyati * (tatlıAdeti + 1) + ",99 TL");
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            int tatlıAdeti = 1;
            int tatlıFiyati = 35;

            if (int.TryParse(txt10.Text, out tatlıAdeti))
            {
                txt10.Text = (tatlıAdeti - 1).ToString();
                label16.Text = Convert.ToString(tatlıFiyati * (tatlıAdeti - 1) + ",99 TL");
            }
        }
    }
}
