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
    public partial class BakırköyProfiterol : Form
    {

        public static string fırınSütlac = "";
        public static string cikolatalıEkler = "";
        public static string cikolatalıProfiterol = "";
        public static string karisikEkler = "";
        public BakırköyProfiterol()
        {
            InitializeComponent();
        }

        //Fırın sütlaç adet ve fiyat arttırma.
        private void button15_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 18;

            if (int.TryParse(textBox8.Text, out yemekAdeti))
            {
                textBox8.Text = (yemekAdeti + 1).ToString();
                label8.Text = Convert.ToString(yemekFiyati * (yemekAdeti + 1)+",00 TL");
            }
        }

        //Fırın sütlaç adet ve fiyat azaltma.
        private void button13_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 18;

            if (int.TryParse(textBox8.Text, out yemekAdeti))
            {
                textBox8.Text = (yemekAdeti - 1).ToString();
                label8.Text = Convert.ToString(yemekFiyati * (yemekAdeti - 1) + ",00 TL");
            }
        
        }

        //Çikolatalı ekler adet ve fiyat arttırma.
        private void button3_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 18;

            if (int.TryParse(textBox1.Text, out yemekAdeti))
            {
                textBox1.Text = (yemekAdeti + 1).ToString();
                label1.Text = Convert.ToString(yemekFiyati * (yemekAdeti + 1) + ",00 TL");
            }
        }

        //Çikolatalı ekler adet ve fiyat azaltma.
        private void button1_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 18;

            if (int.TryParse(textBox1.Text, out yemekAdeti))
            {
                textBox1.Text = (yemekAdeti - 1).ToString();
                label1.Text = Convert.ToString(yemekFiyati * (yemekAdeti - 1) + ",00 TL");
            }
        }

        //Çikolata soslu profiterol adet ve fiyat arttırma.
        private void button6_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 18;

            if (int.TryParse(textBox2.Text, out yemekAdeti))
            {
                textBox2.Text = (yemekAdeti + 1).ToString();
                label2.Text = Convert.ToString(yemekFiyati * (yemekAdeti + 1) + ",00 TL");
            }
        }

        ////Çikolata soslu profiterol adet ve fiyat azaltma.
        private void button4_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 18;

            if (int.TryParse(textBox2.Text, out yemekAdeti))
            {
                textBox2.Text = (yemekAdeti - 1).ToString();
                label2.Text = Convert.ToString(yemekFiyati * (yemekAdeti - 1) + ",00 TL");
            }
        }

        //Karışık Ekler adet ve fiyat arttırma.
        private void button9_Click(object sender, EventArgs e)
        {

            int yemekAdeti = 1;
            int yemekFiyati = 18;

            if (int.TryParse(textBox3.Text, out yemekAdeti))
            {
                textBox3.Text = (yemekAdeti + 1).ToString();
                label3.Text = Convert.ToString(yemekFiyati * (yemekAdeti + 1) + ",00 TL");
            }
        }


        //Karışık Ekler adet ve fiyat azaltma.
        private void button7_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 18;

            if (int.TryParse(textBox3.Text, out yemekAdeti))
            {
                textBox3.Text = (yemekAdeti - 1).ToString();
                label3.Text = Convert.ToString(yemekFiyati * (yemekAdeti - 1) + ",00 TL");
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            this.Hide();
            anasayfa.Show();
        }


        //SEPETE TIKLANINCA FORM AÇMA BUTONU.
        private void button11_Click(object sender, EventArgs e)
        {
            Sepetim sepetim = new Sepetim();
            sepetim.Show();
        }

        //Fırın sütlaç sepete ekle butonu.
        private void button14_Click(object sender, EventArgs e)
        {
            fırınSütlac = "\nBakırköy Profiterol Restoran'ından" +"\n"+ textBox8.Text + " adet " + label4.Text + " vardır.\n" + "Toplam Tutar : " + label8.Text + "'dir";
        }

        //Çikolatalı Ekler sepete ekle butonu.
        private void button2_Click(object sender, EventArgs e)
        {
            cikolatalıEkler ="\nBakırköy Profiterol Restoran'ından" +"\n"+ textBox2.Text + " adet " + label7.Text + " vardır.\n" + "Toplam Tutar : " + label2.Text + "'dir";
        }


        //Çikolata Soslu Profiterol sepete ekle butonu.
        private void button5_Click(object sender, EventArgs e)
        {
            cikolatalıProfiterol = "\nBakırköy Profiterol Restoran'ından" + "\n" + textBox2.Text + " adet " + label7.Text + " vardır.\n" + "Toplam Tutar : " + label2.Text + "'dir";
        }

        //Karışık Ekler sepete ekle butonu.
        private void button8_Click(object sender, EventArgs e)
        {
            karisikEkler = "\nBakırköy Profiterol Restoran'ından" + "\n" + textBox3.Text + " adet " + label6.Text + " vardır.\n" + "Toplam Tutar : " + label3.Text + "'dir";
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
