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
    public partial class burger : Form
    {
        public static string ucluwhopper = "";
        public static string kıngChıcken = "";
        public static string whopper = "";
        public static string benimİkilim = "";
        public static string sufle = "";
        public burger()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 68;

            if (int.TryParse(textBox2.Text, out yemekAdeti))
            {
                textBox2.Text = (yemekAdeti + 1).ToString();
                label4.Text = Convert.ToString(yemekFiyati * (yemekAdeti + 1) + ",99 TL");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 68;

            if (int.TryParse(textBox2.Text, out yemekAdeti))
            {
                textBox2.Text = (yemekAdeti - 1).ToString();
                label4.Text = Convert.ToString(yemekFiyati * (yemekAdeti - 1) + ",99 TL");
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 49;

            if (int.TryParse(txt2.Text, out yemekAdeti))
            {
                txt2.Text = (yemekAdeti + 1).ToString();
                label12.Text = Convert.ToString(yemekFiyati * (yemekAdeti + 1) + ",99 TL");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            int yemekAdeti = 1;
            int yemekFiyati = 49;

            if (int.TryParse(txt2.Text, out yemekAdeti))
            {
                txt2.Text = (yemekAdeti - 1).ToString();
                label12.Text = Convert.ToString(yemekFiyati * (yemekAdeti - 1) + ",99 TL");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {

            int yemekAdeti = 1;
            int yemekFiyati = 46;

            if (int.TryParse(txt3.Text, out yemekAdeti))
            {
                txt3.Text = (yemekAdeti + 1).ToString();
                label13.Text = Convert.ToString(yemekFiyati * (yemekAdeti + 1) + ",99 TL");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int yemekAdeti = 1;
            int yemekFiyati = 46;

            if (int.TryParse(txt3.Text, out yemekAdeti))
            {
                txt3.Text = (yemekAdeti - 1).ToString();
                label13.Text = Convert.ToString(yemekFiyati * (yemekAdeti - 1) + ",99 TL");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {

            int yemekAdeti = 1;
            int yemekFiyati = 46;

            if (int.TryParse(txt4.Text, out yemekAdeti))
            {
                txt4.Text = (yemekAdeti + 1).ToString();
                label14.Text = Convert.ToString(yemekFiyati * (yemekAdeti + 1) + ",99 TL");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 46;

            if (int.TryParse(txt4.Text, out yemekAdeti))
            {
                txt4.Text = (yemekAdeti - 1).ToString();
                label14.Text = Convert.ToString(yemekFiyati * (yemekAdeti - 1) + ",99 TL");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

            int yemekAdeti = 1;
            int yemekFiyati = 12;

            if (int.TryParse(txt5.Text, out yemekAdeti))
            {
                txt5.Text = (yemekAdeti + 1).ToString();
                label15.Text = Convert.ToString(yemekFiyati * (yemekAdeti + 1) + ",99 TL");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 12;

            if (int.TryParse(txt5.Text, out yemekAdeti))
            {
                txt5.Text = (yemekAdeti + 1).ToString();
                label15.Text = Convert.ToString(yemekFiyati * (yemekAdeti + 1) + ",99 TL");
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            this.Hide();
            anasayfa.Show();
        }

        //SEPETİM FORMUNU AÇMAK İÇİN BUTON
        private void button5_Click(object sender, EventArgs e)
        {
            Sepetim sepetim = new Sepetim();
            sepetim.Show();
        }

        //3LÜ Whopper menü sepete ekle butonu.
        private void button7_Click(object sender, EventArgs e)
        {
            ucluwhopper = "\nBurger King Restoran'ından" +"\n"+ textBox2.Text + " adet " + label19.Text + label18.Text +" vardır.\n" + "Toplam Tutar : " + label4.Text + "'dir";
        }

        //Kıng Chıcken menü sepete ekle butonu.
        private void button13_Click(object sender, EventArgs e)
        {
            kıngChıcken = "\nBurger King Restoran'ından" +"\n"+ txt2.Text + " adet " + label17.Text + label16.Text + " vardır.\n" + "Toplam Tutar : " + label12.Text + "'dir";

        }

        //Whopper menü sepete ekle butonu.
        private void button14_Click(object sender, EventArgs e)
        {
            whopper = "\nBurger King Restoran'ından" +"\n"+ txt3.Text + " adet " + label6.Text + " vardır.\n" + "Toplam Tutar : " + label13.Text + "'dir";

        }

        //Benim İkilim sepete ekle butonu.

        private void button15_Click(object sender, EventArgs e)
        {
            benimİkilim = "\nBurger King Restoran'ından" + "\n" + txt4.Text + " adet " + label7.Text + " vardır.\n" + "Toplam Tutar : " + label14.Text + "'dir";

        }

        //Sufle sepete ekle butonu.
        private void button17_Click(object sender, EventArgs e)
        {
            sufle = "\nBurger King Restoran'ından" + "\n" + txt5.Text + " adet " + label8.Text + " vardır.\n" + "Toplam Tutar : " + label15.Text + "'dir";
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            label5.BackColor = Color.DarkGreen;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.BackColor = Color.MediumSeaGreen;
        }
    }
}
