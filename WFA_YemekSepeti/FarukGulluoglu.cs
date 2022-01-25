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
    public partial class FarukGulluoglu : Form
    {
        public static string sutluNuriye = "";
        public static string fıstıklıDurum = "";
        public static string midyeBaklava = "";
        public static string telKadayıf = "";
        public static string burmaKadayıf = "";
        public static string frambuazlı = "";
        public static string krokanlı = "";
        public FarukGulluoglu()
        {
            InitializeComponent();
        }
        //sütlü nuriye fiyat arttırma azaltma
        private void button19_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 182;

            if (int.TryParse(txt1.Text, out yemekAdeti))
            {
                txt1.Text = (yemekAdeti + 1).ToString();
                label12.Text = Convert.ToString(yemekFiyati * (yemekAdeti + 1) + ",00 TL");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            int yemekAdeti = 1;
            int yemekFiyati = 182;

            if (int.TryParse(txt1.Text, out yemekAdeti))
            {
                txt1.Text = (yemekAdeti - 1).ToString();
                label12.Text = Convert.ToString(yemekFiyati * (yemekAdeti - 1) + ",00 TL");
            }
        }
        //fıstıklı dürüm fiyat arttırma azaltma
        private void button3_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 275;

            if (int.TryParse(txt2.Text, out yemekAdeti))
            {
                txt2.Text = (yemekAdeti + 1).ToString();
                label1.Text = Convert.ToString(yemekFiyati * (yemekAdeti + 1) + ",00 TL");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                int yemekAdeti = 1;
                int yemekFiyati = 275;

                if (int.TryParse(txt2.Text, out yemekAdeti))
                {
                    txt2.Text = (yemekAdeti - 1).ToString();
                    label1.Text = Convert.ToString(yemekFiyati * (yemekAdeti - 1) + ",00 TL");
                }
            }
        }
        //midye baklava
        private void button7_Click(object sender, EventArgs e)
        {
            {
                int yemekAdeti = 1;
                int yemekFiyati = 264;

                if (int.TryParse(txt3.Text, out yemekAdeti))
                {
                    txt3.Text = (yemekAdeti + 1).ToString();
                    label2.Text = Convert.ToString(yemekFiyati * (yemekAdeti + 1) + ",00 TL");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                int yemekAdeti = 1;
                int yemekFiyati = 264;

                if (int.TryParse(txt3.Text, out yemekAdeti))
                {
                    txt3.Text = (yemekAdeti - 1).ToString();
                    label2.Text = Convert.ToString(yemekFiyati * (yemekAdeti - 1) + ",00 TL");
                }
            }
        }
        //tel kadayıf
        private void button10_Click(object sender, EventArgs e)
        {
            {
                int yemekAdeti = 1;
                int yemekFiyati = 187;

                if (int.TryParse(txt4.Text, out yemekAdeti))
                {
                    txt4.Text = (yemekAdeti + 1).ToString();
                    label3.Text = Convert.ToString(yemekFiyati * (yemekAdeti + 1) + ",00 TL");
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            {
                int yemekAdeti = 1;
                int yemekFiyati = 187;

                if (int.TryParse(txt4.Text, out yemekAdeti))
                {
                    txt4.Text = (yemekAdeti - 1).ToString();
                    label3.Text = Convert.ToString(yemekFiyati * (yemekAdeti - 1) + ",00 TL");
                }
            }
        }
        //burma kadayıf
        private void button15_Click(object sender, EventArgs e)
        {
            {
                int yemekAdeti = 1;
                int yemekFiyati = 220;

                if (int.TryParse(txt5.Text, out yemekAdeti))
                {
                    txt5.Text = (yemekAdeti + 1).ToString();
                    label4.Text = Convert.ToString(yemekFiyati * (yemekAdeti + 1) + ",00 TL");
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            {
                int yemekAdeti = 1;
                int yemekFiyati = 220;

                if (int.TryParse(txt5.Text, out yemekAdeti))
                {
                    txt5.Text = (yemekAdeti - 1).ToString();
                    label4.Text = Convert.ToString(yemekFiyati * (yemekAdeti - 1) + ",00 TL");
                }
            }
        }
        //frambuazlı pasta
        private void button18_Click(object sender, EventArgs e)
        {
            {
                int yemekAdeti = 1;
                int yemekFiyati = 160;

                if (int.TryParse(txt6.Text, out yemekAdeti))
                {
                    txt6.Text = (yemekAdeti + 1).ToString();
                    label5.Text = Convert.ToString(yemekFiyati * (yemekAdeti + 1) + ",00 TL");
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            {
                int yemekAdeti = 1;
                int yemekFiyati = 160;

                if (int.TryParse(txt6.Text, out yemekAdeti))
                {
                    txt6.Text = (yemekAdeti - 1).ToString();
                    label5.Text = Convert.ToString(yemekFiyati * (yemekAdeti - 1) + ",00 TL");
                }
            }
        }
        //krokanlı pasta
        private void button22_Click(object sender, EventArgs e)
        {
            {
                int yemekAdeti = 1;
                int yemekFiyati = 160;

                if (int.TryParse(txt7.Text, out yemekAdeti))
                {
                    txt7.Text = (yemekAdeti + 1).ToString();
                    label6.Text = Convert.ToString(yemekFiyati * (yemekAdeti + 1) + ",00 TL");
                }
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            {
                int yemekAdeti = 1;
                int yemekFiyati = 160;

                if (int.TryParse(txt7.Text, out yemekAdeti))
                {
                    txt7.Text = (yemekAdeti - 1).ToString();
                    label6.Text = Convert.ToString(yemekFiyati * (yemekAdeti - 1) + ",00 TL");
                }
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            this.Hide();
            anasayfa.Show();
        }

        private void FarukGulluoglu_Load(object sender, EventArgs e)
        {

        }

        //SEPETE TIKLANAN FORMU AÇMAK İÇİN BUTON.
        private void button11_Click(object sender, EventArgs e)
        {
            Sepetim sepetim = new Sepetim();
            sepetim.Show();
        }

        //Sütlü Nuriye sepete ekleme butonu.
        private void button13_Click(object sender, EventArgs e)
        {
            sutluNuriye = "\nFaruk Güllüoğlu Restoran'ından" + "\n" + txt1.Text + " adet " + groupBox1.Text + " vardır.\n" + "Toplam Tutar : " + label12.Text + "'dir";
        }

        // Fıstıklı Dürüm sepete ekleme butonu.
        private void button2_Click(object sender, EventArgs e)
        {
            fıstıklıDurum = "\nFaruk Güllüoğlu Restoran'ından" + "\n" + txt2.Text + " adet " + groupBox2.Text + " vardır.\n" + "Toplam Tutar : " + label1.Text + "'dir";
        }

        //Midye Baklava sepete ekleme butonu.
        private void button5_Click(object sender, EventArgs e)
        {
            midyeBaklava = "\nFaruk Güllüoğlu Restoran'ından" + "\n" + txt3.Text + " adet " + groupBox3.Text + " vardır.\n" + "Toplam Tutar : " + label2.Text + "'dir";
        }

        //Tel Kadayıf sepete ekleme butonu.
        private void button9_Click(object sender, EventArgs e)
        {
            telKadayıf = "\nFaruk Güllüoğlu Restoran'ından" + "\n" + txt4.Text + " adet " + groupBox4.Text + " vardır.\n" + "Toplam Tutar : " + label3.Text + "'dir";
        }

        //Burma Kadayıf sepete ekleme butonu.
        private void button14_Click(object sender, EventArgs e)
        {
            burmaKadayıf = "\nFaruk Güllüoğlu Restoran'ından" + "\n" + txt5.Text + " adet " + groupBox5.Text + " vardır.\n" + "Toplam Tutar : " + label4.Text + "'dir";
        }

        //Frambuazlı pasta sepete ekleme butonu.
        private void button17_Click(object sender, EventArgs e)
        {
            frambuazlı = "\n Sepetinizde : \n" + txt6.Text + " adet " + groupBox7.Text + " vardır.\n" + "Toplam Tutar : " + label5.Text + "'dir";
        }

        //Krokanlı pasta sepete ekleme butonu.
        private void button21_Click(object sender, EventArgs e)
        {
            krokanlı = "\nFaruk Güllüoğlu Restoran'ından" + "\n" + txt7.Text + " adet " + groupBox8.Text + " vardır.\n" + "Toplam Tutar : " + label6.Text + "'dir";
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
