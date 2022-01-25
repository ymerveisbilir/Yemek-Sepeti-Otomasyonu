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
    public partial class bayramoglu : Form
    {

        public static string porsiyonDoner = "";
        public static string pilavDoner = "";
        public static string DonerDurum1= "";
        public static string DonerDurum2 = "";
        public static string DonerDurum3 = "";
        public static string salgam = "";
        public static string gazlıİcecek = "";
        public static string su = "";
        public static string sutlac = "";
        public static string havucDilim = "";

        public bayramoglu()
        {
            InitializeComponent();
        }


        private void button16_Click_1(object sender, EventArgs e)
        {int yemekAdeti = 1;
            int yemekFiyati = 55;

            if (int.TryParse(txt1.Text, out yemekAdeti))
            {
                txt1.Text = (yemekAdeti + 1).ToString();
                label14.Text = Convert.ToString(yemekFiyati * (yemekAdeti + 1) + ",00 TL");
            }
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 55;

            if (int.TryParse(txt1.Text, out yemekAdeti))
            {
                txt1.Text = (yemekAdeti -1).ToString();
                label14.Text = Convert.ToString(yemekFiyati * (yemekAdeti - 1) + ",00 TL");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            int yemekAdeti = 1;
            int yemekFiyati = 69;

            if (int.TryParse(txt2.Text, out yemekAdeti))
            {
                txt2.Text = (yemekAdeti + 1).ToString();
                label7.Text = Convert.ToString(yemekFiyati * (yemekAdeti + 1) + ",00 TL");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            int yemekAdeti = 1;
            int yemekFiyati = 69;

            if (int.TryParse(txt2.Text, out yemekAdeti))
            {
                txt2.Text = (yemekAdeti - 1).ToString();
                label7.Text = Convert.ToString(yemekFiyati * (yemekAdeti - 1) + ",00 TL");
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 44;

            if (int.TryParse(txt3.Text, out yemekAdeti))
            {
                txt3.Text = (yemekAdeti + 1).ToString();
                label8.Text = Convert.ToString(yemekFiyati * (yemekAdeti + 1) + ",00 TL");
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 44;

            if (int.TryParse(txt3.Text, out yemekAdeti))
            {
                txt3.Text = (yemekAdeti -1).ToString();
                label8.Text = Convert.ToString(yemekFiyati * (yemekAdeti- 1) + ",00 TL");
            }
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 50;

            if (int.TryParse(txt4.Text, out yemekAdeti))
            {
                txt4.Text = (yemekAdeti + 1).ToString();
                label9.Text = Convert.ToString(yemekFiyati * (yemekAdeti + 1) + ",00 TL");
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 50;

            if (int.TryParse(txt4.Text, out yemekAdeti))
            {
                txt4.Text = (yemekAdeti - 1).ToString();
                label9.Text = Convert.ToString(yemekFiyati * (yemekAdeti - 1) + ",00 TL");
            }
        }

        private void button13_Click_1(object sender, EventArgs e)
        {

            int yemekAdeti = 1;
            int yemekFiyati = 58;

            if (int.TryParse(txt5.Text, out yemekAdeti))
            {
                txt5.Text = (yemekAdeti + 1).ToString();
                label11.Text = Convert.ToString(yemekFiyati * (yemekAdeti + 1) + ",00 TL");
            }
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 58;

            if (int.TryParse(txt5.Text, out yemekAdeti))
            {
                txt5.Text = (yemekAdeti - 1).ToString();
                label11.Text = Convert.ToString(yemekFiyati * (yemekAdeti - 1) + ",00 TL");
            }
        }

        private void button25_Click_1(object sender, EventArgs e)
        {
            int icecekAdeti = 1;
            int icecekFiyati = 15;

            if (int.TryParse(txt6.Text, out icecekAdeti))
            {
                txt6.Text = (icecekAdeti + 1).ToString();
                label22.Text = Convert.ToString(icecekFiyati * (icecekAdeti + 1) + ",00 TL");
            }
        }

        private void button23_Click_1(object sender, EventArgs e)
        {
            int icecekAdeti = 1;
            int icecekFiyati = 15;

            if (int.TryParse(txt6.Text, out icecekAdeti))
            {
                txt6.Text = (icecekAdeti - 1).ToString();
                label22.Text = Convert.ToString(icecekFiyati * (icecekAdeti - 1) + ",00 TL");
            }
        }

        private void button28_Click_1(object sender, EventArgs e)
        {

            int icecekAdeti = 1;
            int icecekFiyati = 10;

            if (int.TryParse(txt7.Text, out icecekAdeti))
            {
                txt7.Text = (icecekAdeti + 1).ToString();
                label23.Text = Convert.ToString(icecekFiyati * (icecekAdeti + 1) + ",00 TL");
            }
        }

        private void button26_Click_1(object sender, EventArgs e)
        {
            int icecekAdeti = 1;
            int icecekFiyati = 10;

            if (int.TryParse(txt7.Text, out icecekAdeti))
            {
                txt7.Text = (icecekAdeti - 1).ToString();
                label23.Text = Convert.ToString(icecekFiyati * (icecekAdeti - 1) + ",00 TL");
            }
        }

        private void button31_Click_1(object sender, EventArgs e)
        {
            int icecekAdeti = 1;
            int icecekFiyati = 5;

            if (int.TryParse(txt8.Text, out icecekAdeti))
            {
                txt8.Text = (icecekAdeti + 1).ToString();
                label24.Text = Convert.ToString(icecekFiyati * (icecekAdeti + 1) + ",00 TL");
            }
        }

        private void button29_Click_1(object sender, EventArgs e)
        {
            int icecekAdeti = 1;
            int icecekFiyati = 5;

            if (int.TryParse(txt8.Text, out icecekAdeti))
            {
                txt8.Text = (icecekAdeti - 1).ToString();
                label24.Text = Convert.ToString(icecekFiyati * (icecekAdeti - 1) + ",00 TL");
            }
        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            int tatlıAdeti = 1;
            int tatlıFiyati = 27;

            if (int.TryParse(txt9.Text, out tatlıAdeti))
            {
                txt9.Text = (tatlıAdeti + 1).ToString();
                label13.Text = Convert.ToString(tatlıFiyati * (tatlıAdeti + 1) + ",00 TL");
            }
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            int tatlıAdeti = 1;
            int tatlıFiyati = 27;

            if (int.TryParse(txt9.Text, out tatlıAdeti))
            {
                txt9.Text = (tatlıAdeti - 1).ToString();
                label13.Text = Convert.ToString(tatlıFiyati * (tatlıAdeti - 1) + ",00 TL");
            }
        }

        private void button22_Click_1(object sender, EventArgs e)
        {

            int tatlıAdeti = 1;
            int tatlıFiyati = 35;

            if (int.TryParse(txt10.Text, out tatlıAdeti))
            {
                txt10.Text = (tatlıAdeti + 1).ToString();
                label16.Text = Convert.ToString(tatlıFiyati * (tatlıAdeti + 1) + ",00 TL");
            }
        }

        private void button20_Click_1(object sender, EventArgs e)
        {
            int tatlıAdeti = 1;
            int tatlıFiyati = 35;

            if (int.TryParse(txt10.Text, out tatlıAdeti))
            {
                txt10.Text = (tatlıAdeti - 1).ToString();
                label16.Text = Convert.ToString(tatlıFiyati * (tatlıAdeti - 1) + ",00 TL");
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
            Sepetim sepet = new Sepetim();
            sepet.ShowDialog();
        }
        //Porsiyon DÖner sepete ekle butonu
        private void button15_Click(object sender, EventArgs e)
        {
            porsiyonDoner = "\nBayramoğlu Restoran'ından" + "\n" + txt1.Text + " adet " + label2.Text + " vardır.\n" + "Toplam Tutar : " + label14.Text + "'dir";


        }

        //Pilav Üstü Döner
        private void button2_Click(object sender, EventArgs e)
        {
            pilavDoner = "\nBayramoğlu Restoran'ından" + "\n" + txt2.Text + " adet " + label3.Text + " vardır.\n" + "Toplam Tutar : " + label7.Text + "'dir";
        }

        //Döner Dürüm 60gr
        private void button5_Click(object sender, EventArgs e)
        {
            DonerDurum1 = "\nBayramoğlu Restoran'ından" + "\n" + txt3.Text + " adet " + label4.Text + " vardır.\n" + "Toplam Tutar : " + label8.Text + "'dir";
        }

        //Döner Dürüm 100gr
        private void button8_Click(object sender, EventArgs e)
        {
            DonerDurum2 = "\nBayramoğlu Restoran'ından" + "\n" + txt4.Text + " adet " + label5.Text + " vardır.\n" + "Toplam Tutar : " + label9.Text + "'dir";
        }

        //Döner Dürüm 150gr
        private void button12_Click(object sender, EventArgs e)
        {
            DonerDurum3 = "\nBayramoğlu Restoran'ından" + "\n" + txt5.Text + " adet " + label6.Text + " vardır.\n" + "Toplam Tutar : " + label11.Text + "'dir";
        }

        //Şalgam
        private void button24_Click(object sender, EventArgs e)
        {
            salgam = "\nBayramoğlu Restoran'ından" + "\n" + txt6.Text + " adet " + label19.Text + " vardır.\n" + "Toplam Tutar : " + label22.Text + "'dir";
        }

        //Gazlı İçecek 
        private void button27_Click(object sender, EventArgs e)
        {
            gazlıİcecek = "\nBayramoğlu Restoran'ından" + "\n" + txt7.Text + " adet " + label20.Text + " vardır.\n" + "Toplam Tutar : " + label23.Text + "'dir";
        }

        //Su
        private void button30_Click(object sender, EventArgs e)
        {
            su = "\nBayramoğlu Restoran'ından" + "\n" + txt8.Text + " adet " + label21.Text + " vardır.\n" + "Toplam Tutar : " + label24.Text + "'dir";
        }

        //Sütlaç
        private void button18_Click(object sender, EventArgs e)
        {
            sutlac = "\nBayramoğlu Restoran'ından" + "\n" + txt9.Text + " adet " + label15.Text + " vardır.\n" + "Toplam Tutar : " + label13.Text + "'dir";
        }
        //Havuç Dilim Baklava
        private void button21_Click(object sender, EventArgs e)
        {
            havucDilim = "\nBayramoğlu Restoran'ından" + "\n" + txt10.Text + " adet " + label17.Text + " vardır.\n" + "Toplam Tutar : " + label16.Text + "'dir";
        }

        private void label10_MouseEnter(object sender, EventArgs e)
        {
            label10.BackColor = Color.DarkGreen;
        }
    

        private void label10_MouseLeave(object sender, EventArgs e)
        {
        label10.BackColor = Color.MediumSeaGreen;
        }

        private void bayramoglu_Load(object sender, EventArgs e)
        {

        }
    }
    }


