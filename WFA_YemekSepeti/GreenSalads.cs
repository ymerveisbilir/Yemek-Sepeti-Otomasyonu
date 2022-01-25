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
    public partial class GreenSalads : Form
    {

        public static string mevsimSalata = "";
        public static string köriTavuk = "";
        public static string napolitanPenne = "";
        public static string tonBalık = "";
        public static string ozelFettuccine = "";
        public static string FettuccinePirzola = "";

        public GreenSalads()
        {
            InitializeComponent();
        }

        //textbox'lara dışardan erişimi propetieslerden Enable==False yaparak kapattık.

        //4 Mevsim Salata yemekAdeti artırma ve fiyat arttırma.
        private void button15_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 29;

            if (int.TryParse(textBox8.Text, out yemekAdeti))
            {
                textBox8.Text = (yemekAdeti + 1).ToString();
                label8.Text = Convert.ToString(yemekFiyati * (yemekAdeti + 1) + ",00 TL");
            }
        }

        //4 Mevsim Salata yemekyemekAdeti azaltma ve fiyat azaltma.
        private void button13_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 29;

            if (int.TryParse(textBox8.Text, out yemekAdeti))
            {
                textBox8.Text = (yemekAdeti - 1).ToString();
                label8.Text = Convert.ToString(yemekFiyati * (yemekAdeti - 1) + ",00 TL");
            }
        }


        //Ton Balıklı Salata yemekAdeti arttırma ve fiyat arttırma.
        private void button19_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 44;

            if (int.TryParse(textBox10.Text, out yemekAdeti))
            {
                textBox10.Text = (yemekAdeti + 1).ToString();
                label11.Text = Convert.ToString(yemekFiyati * (yemekAdeti + 1) + ",00 TL");
            }

        }

        //Ton Balıklı Salata yemekAdeti azaltma ve fiyat azaltma.
        private void button16_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 44;

            if (int.TryParse(textBox10.Text, out yemekAdeti))
            {
                textBox10.Text = (yemekAdeti - 1).ToString();
                label11.Text = Convert.ToString(yemekFiyati * (yemekAdeti - 1) + ",00 TL");
            }
        }


        //Köri Soslu Tavuk yemekAdeti arttırma ve fiyat arttırma.
        private void button11_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 49;

            if (int.TryParse(textBox7.Text, out yemekAdeti))
            {
                textBox7.Text = (yemekAdeti + 1).ToString();
                label7.Text = Convert.ToString(yemekFiyati * (yemekAdeti + 1) + ",00 TL");
            }

        }

        //Köri Soslu Tavuk yemekAdeti azaltma ve fiyat azaltma.
        private void button7_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 49;

            if (int.TryParse(textBox7.Text, out yemekAdeti))
            {
                textBox7.Text = (yemekAdeti - 1).ToString();
                label7.Text = Convert.ToString(yemekFiyati * (yemekAdeti - 1) + ",00 TL");
            }

        }

        //Napolitan Soslu Penne yemekAdeti arttırma ve fiyat arttırma.
        private void button3_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 34;

            if (int.TryParse(textBox3.Text, out yemekAdeti))
            {
                textBox3.Text = (yemekAdeti + 1).ToString();
                label3.Text = Convert.ToString(yemekFiyati * (yemekAdeti + 1) + ",00 TL");
            }

        }


        //Napolitan Soslu Penne yemekAdeti azaltma ve fiyat azaltma.
        private void button1_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 34;

            if (int.TryParse(textBox3.Text, out yemekAdeti))
            {
                textBox3.Text = (yemekAdeti - 1).ToString();
                label3.Text = Convert.ToString(yemekFiyati * (yemekAdeti - 1) + ",00 TL");
            }
        }

        //Özel Soslu Fettuccine yemekAdeti arttırma ve fiyat arttırma.
        private void button9_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 29;

            if (int.TryParse(txt5.Text, out yemekAdeti))
            {
                txt5.Text = (yemekAdeti + 1).ToString();
                label15.Text = Convert.ToString(yemekFiyati * (yemekAdeti + 1) + ",00 TL");
            }
        }

        //Özel Soslu Fettuccine yemekAdeti azaltma ve fiyat azaltma.
        private void button10_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 29;

            if (int.TryParse(txt5.Text, out yemekAdeti))
            {
                txt5.Text = (yemekAdeti - 1).ToString();
                label15.Text = Convert.ToString(yemekFiyati * (yemekAdeti - 1) + ",00 TL");
            }
        }


        //Fettuccine Pirzola yemekAdeti arttırma ve fiyat arttırma.
        private void button6_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 39;

            if (int.TryParse(textBox5.Text, out yemekAdeti))
            {
                textBox5.Text = (yemekAdeti + 1).ToString();
                label5.Text = Convert.ToString(yemekFiyati * (yemekAdeti + 1) + ",00 TL");
            }
        }


        ////Fettuccine Pirzola yemekAdeti azaltma ve fiyat azaltma.
        private void button4_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 39;

            if (int.TryParse(textBox5.Text, out yemekAdeti))
            {
                textBox5.Text = (yemekAdeti - 1).ToString();
                label5.Text = Convert.ToString(yemekFiyati * (yemekAdeti - 1) + ",00 TL");
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            this.Hide();
            anasayfa.Show();
        }


        //4mevsim salata sepete ekle butonu.
        private void button14_Click(object sender, EventArgs e) 
        {
        mevsimSalata = "\nGreen Salads Restoran'ından" + "\n" + textBox8.Text + " adet " +label9.Text + " vardır.\n" + "Toplam Tutar : " +label8.Text +"'dir";
        
        }

        //Köri Soslu Tavuk sepete ekle butonu.
        private void button8_Click(object sender, EventArgs e)
        {
        köriTavuk = "\nGreen Salads Restoran'ından" + "\n" + textBox7.Text + " adet " + label6.Text + " vardır.\n" + "Toplam Tutar : " + label7.Text + "'dir";

        }

        //Napolitan soslu penne sepete ekle butonu.
        private void button2_Click(object sender, EventArgs e)
        {
         napolitanPenne = "\nGreen Salads Restoran'ından" + "\n" + textBox3.Text + " adet " + label2.Text + " vardır.\n" + "Toplam Tutar : " + label3.Text + "'dir";
        }


        //Ton Balıklı Salata sepete ekle butonu.
        private void button18_Click(object sender, EventArgs e)
        {
            tonBalık = "\nGreen Salads Restoran'ından" + "\n" + textBox10.Text + " adet " + label12.Text + " vardır.\n" + "Toplam Tutar : " + label11.Text + "'dir";
        }


        //Özel Soslu Fettuccine sepete ekle butonu.
        private void button17_Click(object sender, EventArgs e)
        {
            ozelFettuccine = "\nGreen Salads Restoran'ından" + "\n" + txt5.Text + " adet " + label1.Text + " vardır.\n" + "Toplam Tutar : " + label15.Text + "'dir";
        }

        //Fettuccine Pirzola sepete ekle butonu.
        private void button5_Click(object sender, EventArgs e)
        {
            FettuccinePirzola = "\nGreen Salads Restoran'ından" + "\n" + textBox5.Text + " adet " + label4.Text + " vardır.\n" + "Toplam Tutar : " + label5.Text + "'dir";
        }

        //SEPETE TIKLANINCA AÇILAN FORM
        private void button12_Click(object sender, EventArgs e)
        {

            Sepetim sepetim = new Sepetim();
            sepetim.Show();
        }

        private void label10_MouseEnter(object sender, EventArgs e)
        {
            label10.BackColor = Color.DarkGreen;
        }

        private void label10_MouseLeave(object sender, EventArgs e)
        {
            label10.BackColor = Color.MediumSeaGreen;
        }

        private void GreenSalads_Load(object sender, EventArgs e)
        {

        }
    }
}
