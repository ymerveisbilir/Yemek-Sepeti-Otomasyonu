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
    public partial class DominosPizza : Form
    {
        public DominosPizza()
        {
            InitializeComponent();
        }

        private void DominosPizza_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label10_MouseEnter(object sender, EventArgs e)
        {
            label10.BackColor = Color.DarkOrange;
        }

        //SEPETİM YAZILI LABEL RENKLENDİRME
        private void label10_MouseLeave(object sender, EventArgs e)
        {
            label10.BackColor = Color.Green;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int yemekAdeti = 1;
            int yemekFiyati = 62;

            if (int.TryParse(txt1.Text, out yemekAdeti))
            {
                txt1.Text = (yemekAdeti + 1).ToString();
                label11.Text = Convert.ToString(yemekFiyati * (yemekAdeti + 1) + ",99 TL");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 62;

            if (int.TryParse(txt1.Text, out yemekAdeti))
            {
                txt1.Text = (yemekAdeti - 1).ToString();
                label11.Text = Convert.ToString(yemekFiyati * (yemekAdeti - 1) + ",99 TL");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 94;

            if (int.TryParse(txt3.Text, out yemekAdeti))
            {
                txt3.Text = (yemekAdeti + 1).ToString();
                label5.Text = Convert.ToString(yemekFiyati * (yemekAdeti + 1) + ",99 TL");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 94;

            if (int.TryParse(txt3.Text, out yemekAdeti))
            {
                txt3.Text = (yemekAdeti - 1).ToString();
                label5.Text = Convert.ToString(yemekFiyati * (yemekAdeti - 1) + ",99 TL");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                int yemekAdeti = 1;
                int yemekFiyati = 78;

                if (int.TryParse(txt2.Text, out yemekAdeti))
                {
                    txt2.Text = (yemekAdeti + 1).ToString();
                    label4.Text = Convert.ToString(yemekFiyati * (yemekAdeti + 1) + ",99 TL");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                int yemekAdeti = 1;
                int yemekFiyati = 78;

                if (int.TryParse(txt2.Text, out yemekAdeti))
                {
                    txt2.Text = (yemekAdeti - 1).ToString();
                    label4.Text = Convert.ToString(yemekFiyati * (yemekAdeti - 1) + ",99 TL");
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            {
                int yemekAdeti = 1;
                int yemekFiyati = 51;

                if (int.TryParse(txt4.Text, out yemekAdeti))
                {
                    txt4.Text = (yemekAdeti + 1).ToString();
                    label6.Text = Convert.ToString(yemekFiyati * (yemekAdeti + 1) + ",99 TL");
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            {
                int yemekAdeti = 1;
                int yemekFiyati = 51;

                if (int.TryParse(txt4.Text, out yemekAdeti))
                {
                    txt4.Text = (yemekAdeti - 1).ToString();
                    label6.Text = Convert.ToString(yemekFiyati * (yemekAdeti - 1) + ",99 TL");
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            {
                int yemekAdeti = 1;
                int yemekFiyati = 27;

                if (int.TryParse(txt5.Text, out yemekAdeti))
                {
                    txt5.Text = (yemekAdeti + 1).ToString();
                    label14.Text = Convert.ToString(yemekFiyati * (yemekAdeti + 1) + ",99 TL");
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 27;

            if (int.TryParse(txt5.Text, out yemekAdeti))
            {
                txt5.Text = (yemekAdeti - 1).ToString();
                label14.Text = Convert.ToString(yemekFiyati * (yemekAdeti - 1) + ",99 TL");
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            {
                int yemekAdeti = 1;
                int yemekFiyati = 29;

                if (int.TryParse(txt6.Text, out yemekAdeti))
                {
                    txt6.Text = (yemekAdeti + 1).ToString();
                    label15.Text = Convert.ToString(yemekFiyati * (yemekAdeti + 1) + ",99 TL");
                }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            {
                int yemekAdeti = 1;
                int yemekFiyati = 29;

                if (int.TryParse(txt6.Text, out yemekAdeti))
                {
                    txt6.Text = (yemekAdeti - 1).ToString();
                    label15.Text = Convert.ToString(yemekFiyati * (yemekAdeti - 1) + ",99 TL");
                }
            }
        }
    }
}
