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
    public partial class Dominos : Form
    {
        public static string ikiOrta = "";
        public static string buyukBoy = "";
        public static string ucAl = "";
        public static string bolMolzemos = "";
        public static string cikolatalıSufle = "";
        public static string cokomis = "";
        public Dominos()
        {
            InitializeComponent();
        }

        //SEPETİM YAZILI LABEL RENKLENDİRME
        private void label10_MouseLeave(object sender, EventArgs e)
        {
            label10.BackColor = Color.Green;
        }

       

       
       

        


        private void button2_Click_1(object sender, EventArgs e)
        {

            int yemekAdeti = 1;
            int yemekFiyati = 62;

            if (int.TryParse(txt1.Text, out yemekAdeti))
            {
                txt1.Text = (yemekAdeti + 1).ToString();
                label11.Text = Convert.ToString(yemekFiyati * (yemekAdeti + 1) + ",99 TL");
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 62;

            if (int.TryParse(txt1.Text, out yemekAdeti))
            {
                txt1.Text = (yemekAdeti - 1).ToString();
                label11.Text = Convert.ToString(yemekFiyati * (yemekAdeti - 1) + ",99 TL");
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
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

        private void button1_Click_1(object sender, EventArgs e)
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

        private void button7_Click_1(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 94;

            if (int.TryParse(txt3.Text, out yemekAdeti))
            {
                txt3.Text = (yemekAdeti + 1).ToString();
                label5.Text = Convert.ToString(yemekFiyati * (yemekAdeti + 1) + ",99 TL");
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 94;

            if (int.TryParse(txt3.Text, out yemekAdeti))
            {
                txt3.Text = (yemekAdeti - 1).ToString();
                label5.Text = Convert.ToString(yemekFiyati * (yemekAdeti - 1) + ",99 TL");
            }
        }

        private void button13_Click_1(object sender, EventArgs e)
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

        private void button9_Click_1(object sender, EventArgs e)
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

        private void button16_Click_1(object sender, EventArgs e)
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

        private void button14_Click_1(object sender, EventArgs e)
        {

            int yemekAdeti = 1;
            int yemekFiyati = 27;

            if (int.TryParse(txt5.Text, out yemekAdeti))
            {
                txt5.Text = (yemekAdeti - 1).ToString();
                label14.Text = Convert.ToString(yemekFiyati * (yemekAdeti - 1) + ",99 TL");
            }
        }

        private void button19_Click_1(object sender, EventArgs e)
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

        private void button17_Click_1(object sender, EventArgs e)
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

        private void button32_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            this.Hide();
            anasayfa.Show();
        }

       

        //SEPETE TIKLANINCA AÇILAN FORM BUTONU.
        private void button11_Click(object sender, EventArgs e)
        {
            Sepetim sepetim = new Sepetim();
            sepetim.Show();
        }

        // 2 Adet Orta Boy Pizza sepete ekleme butonu.
        private void button12_Click(object sender, EventArgs e)
        {
            ikiOrta = "\nDominos Restoran'ından" + "\n" + txt1.Text + " adet " + label3.Text + " vardır.\n" + "Toplam Tutar : " + label11.Text + "'dir";
        }


        //Büyük Boy Pizza sepete ekleme butonu.
        private void button3_Click(object sender, EventArgs e)
        {
            buyukBoy = "\nDominos Restoran'ından" + "\n" + txt2.Text + " adet " + label7.Text + " vardır.\n" + "Toplam Tutar : " + label4.Text + "'dir";
        }

        // 3 Al 1 Öde Pizza sepete ekleme butonu.
        private void button6_Click(object sender, EventArgs e)
        {
            ucAl = "\nDominos Restoran'ından" + "\n" + txt3.Text + " adet " + label8.Text + " vardır.\n" + "Toplam Tutar : " + label5.Text + "'dir";
        }


        //Bol Malzemos sepete ekleme butonu.
        private void button10_Click(object sender, EventArgs e)
        {
            bolMolzemos = "\nDominos Restoran'ından" + "\n" + txt4.Text + " adet " + label9.Text + " vardır.\n" + "Toplam Tutar : " + label6.Text + "'dir";
        }

        //Sufle  sepete ekleme butonu.
        private void button15_Click(object sender, EventArgs e)
        {
            cikolatalıSufle = "\nDominos Restoran'ından" + "\n" + txt5.Text + " adet " + label12.Text + " vardır.\n" + "Toplam Tutar : " + label14.Text + "'dir";
        }

        // Çokomis sepete ekleme butonu.
        private void button18_Click(object sender, EventArgs e)
        {
            cokomis = "\nDominos Restoran'ından" + "\n" + txt6.Text + " adet " + label13.Text + " vardır.\n" + "Toplam Tutar : " + label15.Text + "'dir";
        }

        private void Dominos_Load(object sender, EventArgs e)
        {

        }

        private void label10_MouseEnter(object sender, EventArgs e)
        {
            label10.BackColor = Color.DarkGreen;
        }

        private void label10_MouseLeave_1(object sender, EventArgs e)
        {
            label10.BackColor = Color.MediumSeaGreen;
        }
    }
}
