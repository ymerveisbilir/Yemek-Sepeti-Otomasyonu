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
    public partial class popeyes : Form
    {
        
            public static string secilmismenu = "";
            public static string kovamenu = "";
            public static string kemiksizmenu = "";
            public static string kovapapates = "";
            public static string cıtırsoganhalkası = "";
            public static string sufle = "";
        public popeyes()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

            int yemekAdeti = 1;
            int yemekFiyati = 80;

            if (int.TryParse(txt1.Text, out yemekAdeti))
            {
                txt1.Text = (yemekAdeti + 1).ToString();
                label12.Text = Convert.ToString(yemekFiyati * (yemekAdeti + 1) + ",00 TL");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 80;

            if (int.TryParse(txt1.Text, out yemekAdeti))
            {
                txt1.Text = (yemekAdeti - 1).ToString();
                label12.Text = Convert.ToString(yemekFiyati * (yemekAdeti - 1) + ",00 TL");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int yemekAdeti = 1;
            int yemekFiyati = 70;

            if (int.TryParse(txt2.Text, out yemekAdeti))
            {
                txt2.Text = (yemekAdeti + 1).ToString();
                label6.Text = Convert.ToString(yemekFiyati * (yemekAdeti + 1) + ",00 TL");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 70;

            if (int.TryParse(txt2.Text, out yemekAdeti))
            {
                txt2.Text = (yemekAdeti - 1).ToString();
                label6.Text = Convert.ToString(yemekFiyati * (yemekAdeti - 1) + ",00 TL");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 54;

            if (int.TryParse(txt3.Text, out yemekAdeti))
            {
                txt3.Text = (yemekAdeti + 1).ToString();
                label8.Text = Convert.ToString(yemekFiyati * (yemekAdeti + 1) + ",00 TL");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 54;

            if (int.TryParse(txt3.Text, out yemekAdeti))
            {
                txt3.Text = (yemekAdeti - 1).ToString();
                label8.Text = Convert.ToString(yemekFiyati * (yemekAdeti -1) + ",00 TL");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {

            int yemekAdeti = 1;
            int yemekFiyati = 32;

            if (int.TryParse(txt4.Text, out yemekAdeti))
            {
                txt4.Text = (yemekAdeti + 1).ToString();
                label9.Text = Convert.ToString(yemekFiyati * (yemekAdeti + 1) + ",00 TL");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 32;

            if (int.TryParse(txt4.Text, out yemekAdeti))
            {
                txt4.Text = (yemekAdeti - 1).ToString();
                label9.Text = Convert.ToString(yemekFiyati * (yemekAdeti - 1) + ",00 TL");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 12;

            if (int.TryParse(txt5.Text, out yemekAdeti))
            {
                txt5.Text = (yemekAdeti + 1).ToString();
                label11.Text = Convert.ToString(yemekFiyati * (yemekAdeti + 1) + ",00 TL");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 12;

            if (int.TryParse(txt5.Text, out yemekAdeti))
            {
                txt5.Text = (yemekAdeti - 1).ToString();
                label11.Text = Convert.ToString(yemekFiyati * (yemekAdeti - 1) + ",00 TL");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 18;

            if (int.TryParse(txt6.Text, out yemekAdeti))
            {
                txt6.Text = (yemekAdeti + 1).ToString();
                label13.Text = Convert.ToString(yemekFiyati * (yemekAdeti + 1) + ",00 TL");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 18;

            if (int.TryParse(txt6.Text, out yemekAdeti))
            {
                txt6.Text = (yemekAdeti - 1).ToString();
                label13.Text = Convert.ToString(yemekFiyati * (yemekAdeti - 1) + ",00 TL");
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {

            Anasayfa anasayfa = new Anasayfa();
            this.Hide();
            anasayfa.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Sepetim sepetim = new Sepetim();
            sepetim.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            secilmismenu = "\nPopeyes Restoran'ından" + "\n" + txt1.Text + " adet " + label1.Text + " vardır.\n" + "Toplam Tutar : " + label12.Text + "'dir";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kovamenu = "\nPopeyes Restoran'ından" + "\n" + txt2.Text + " adet " + label7.Text + " vardır.\n" + "Toplam Tutar : " + label6.Text + "'dir";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            kemiksizmenu = "\nPopeyes Restoran'ından" + "\n" + txt3.Text + " adet " + label2.Text + " vardır.\n" + "Toplam Tutar : " + label8.Text + "'dir";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            kovapapates = "\nPopeyes Restoran'ından" + "\n" + txt4.Text + " adet " + label3.Text + " vardır.\n" + "Toplam Tutar : " + label9.Text + "'dir";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            cıtırsoganhalkası = "\nPopeyes Restoran'ından" + "\n" + txt5.Text + " adet " + label4.Text + " vardır.\n" + "Toplam Tutar : " + label11.Text + "'dir";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            sufle = "\nPopeyes Restoran'ından" + "\n" + txt6.Text + " adet " + label5.Text + " vardır.\n" + "Toplam Tutar : " + label13.Text + "'dir";
        }

        private void popeyes_Load(object sender, EventArgs e)
        {

        }

        private void label10_MouseEnter(object sender, EventArgs e)
        {
            label10.BackColor = Color.DarkGreen;
        }

        private void label10_MouseLeave(object sender, EventArgs e)
        {
            label10.BackColor = Color.MediumSeaGreen;
        }
    }
}
