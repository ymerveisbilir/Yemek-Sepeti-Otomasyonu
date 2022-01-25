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
    public partial class baydoner : Form
    {
        public static string iskender = "";
        public static string kankamenu = "";
        public static string beyti = "";
        public static string sutlac = "";
        public static string kunefe = "";
       
        public baydoner()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {

            Sepetim sepetim = new Sepetim();
            sepetim.Show();
        }

        private void button32_Click(object sender, EventArgs e)
        {

            Anasayfa anasayfa = new Anasayfa();
            this.Hide();
            anasayfa.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 40;

            if (int.TryParse(txt1.Text, out yemekAdeti))
            {
                txt1.Text = (yemekAdeti + 1).ToString();
                label11.Text = Convert.ToString(yemekFiyati * (yemekAdeti + 1) + ",00 TL");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 40;

            if (int.TryParse(txt1.Text, out yemekAdeti))
            {
                txt1.Text = (yemekAdeti - 1).ToString();
                label11.Text = Convert.ToString(yemekFiyati * (yemekAdeti - 1) + ",00 TL");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 70;

            if (int.TryParse(txt2.Text, out yemekAdeti))
            {
                txt2.Text = (yemekAdeti + 1).ToString();
                label1.Text = Convert.ToString(yemekFiyati * (yemekAdeti + 1) + ",00 TL");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 70;

            if (int.TryParse(txt2.Text, out yemekAdeti))
            {
                txt2.Text = (yemekAdeti - 1).ToString();
                label1.Text = Convert.ToString(yemekFiyati * (yemekAdeti -1) + ",00 TL");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            int yemekAdeti = 1;
            int yemekFiyati = 48;

            if (int.TryParse(txt3.Text, out yemekAdeti))
            {
                txt3.Text = (yemekAdeti + 1).ToString();
                label2.Text = Convert.ToString(yemekFiyati * (yemekAdeti + 1) + ",00 TL");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 48;

            if (int.TryParse(txt3.Text, out yemekAdeti))
            {
                txt3.Text = (yemekAdeti - 1).ToString();
                label2.Text = Convert.ToString(yemekFiyati * (yemekAdeti - 1) + ",00 TL");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 28;

            if (int.TryParse(txt4.Text, out yemekAdeti))
            {
                txt4.Text = (yemekAdeti + 1).ToString();
                label3.Text = Convert.ToString(yemekFiyati * (yemekAdeti + 1) + ",00 TL");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

            int yemekAdeti = 1;
            int yemekFiyati = 28;

            if (int.TryParse(txt4.Text, out yemekAdeti))
            {
                txt4.Text = (yemekAdeti - 1).ToString();
                label3.Text = Convert.ToString(yemekFiyati * (yemekAdeti -1) + ",00 TL");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 30;

            if (int.TryParse(txt5.Text, out yemekAdeti))
            {
                txt5.Text = (yemekAdeti + 1).ToString();
                label4.Text = Convert.ToString(yemekFiyati * (yemekAdeti + 1) + ",00 TL");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 30;

            if (int.TryParse(txt5.Text, out yemekAdeti))
            {
                txt5.Text = (yemekAdeti - 1).ToString();
                label4.Text = Convert.ToString(yemekFiyati * (yemekAdeti - 1) + ",00 TL");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            iskender = "\nBaydöner Restoran'ından" + "\n" + txt1.Text + " adet " + groupBox1.Text + " vardır.\n" + "Toplam Tutar : " + label11.Text + "'dir";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kankamenu = "\nBaydöner Restoran'ından" + "\n" + txt2.Text + " adet " + groupBox2.Text + " vardır.\n" + "Toplam Tutar : " + label1.Text + "'dir";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            beyti = "\nBaydöner Restoran'ından" + "\n" + txt3.Text + " adet " + groupBox3.Text + " vardır.\n" + "Toplam Tutar : " + label2.Text + "'dir";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            sutlac = "\nBaydöner Restoran'ından" + "\n" + txt4.Text + " adet " + groupBox4.Text + " vardır.\n" + "Toplam Tutar : " + label3.Text + "'dir";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            kunefe = "\nBaydöner Restoran'ından" + "\n" + txt5.Text + " adet " + groupBox5.Text + " vardır.\n" + "Toplam Tutar : " + label4.Text + "'dir";
        }

        private void label10_MouseEnter(object sender, EventArgs e)
        {
            label10.BackColor = Color.DarkGreen;
        }

        private void label10_MouseLeave(object sender, EventArgs e)
        {
            label10.BackColor = Color.MediumSeaGreen;
        }

        private void baydoner_Load(object sender, EventArgs e)
        {

        }
    }
}
