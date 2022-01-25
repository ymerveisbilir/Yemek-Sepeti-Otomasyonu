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
    public partial class terrapizza : Form
    {
        public static string peynir = "";
        public static string bol = "";
        public static string kavurma = "";
        public static string sampiyon = "";
        public static string terra = "";
        public terrapizza()
        {
            InitializeComponent();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            this.Hide();
            anasayfa.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Sepetim sepetim = new Sepetim();
            sepetim.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 58;

            if (int.TryParse(txt1.Text, out yemekAdeti))
            {
                txt1.Text = (yemekAdeti + 1).ToString();
                label11.Text = Convert.ToString(yemekFiyati * (yemekAdeti + 1) + ",00 TL");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 58;

            if (int.TryParse(txt1.Text, out yemekAdeti))
            {
                txt1.Text = (yemekAdeti -1).ToString();
                label11.Text = Convert.ToString(yemekFiyati * (yemekAdeti - 1) + ",00 TL");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 65;

            if (int.TryParse(txt2.Text, out yemekAdeti))
            {
                txt2.Text = (yemekAdeti + 1).ToString();
                label1.Text = Convert.ToString(yemekFiyati * (yemekAdeti + 1) + ",00 TL");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 65;

            if (int.TryParse(txt2.Text, out yemekAdeti))
            {
                txt2.Text = (yemekAdeti - 1).ToString();
                label1.Text = Convert.ToString(yemekFiyati * (yemekAdeti - 1) + ",00 TL");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            int yemekAdeti = 1;
            int yemekFiyati = 75;

            if (int.TryParse(txt3.Text, out yemekAdeti))
            {
                txt3.Text = (yemekAdeti + 1).ToString();
                label2.Text = Convert.ToString(yemekFiyati * (yemekAdeti + 1) + ",00 TL");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            int yemekAdeti = 1;
            int yemekFiyati = 75;

            if (int.TryParse(txt3.Text, out yemekAdeti))
            {
                txt3.Text = (yemekAdeti -1).ToString();
                label2.Text = Convert.ToString(yemekFiyati * (yemekAdeti - 1) + ",00 TL");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 50;

            if (int.TryParse(txt4.Text, out yemekAdeti))
            {
                txt4.Text = (yemekAdeti + 1).ToString();
                label3.Text = Convert.ToString(yemekFiyati * (yemekAdeti + 1) + ",00 TL");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 50;

            if (int.TryParse(txt4.Text, out yemekAdeti))
            {
                txt4.Text = (yemekAdeti -1).ToString();
                label3.Text = Convert.ToString(yemekFiyati * (yemekAdeti - 1) + ",00 TL");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 25;

            if (int.TryParse(txt5.Text, out yemekAdeti))
            {
                txt5.Text = (yemekAdeti + 1).ToString();
                label4.Text = Convert.ToString(yemekFiyati * (yemekAdeti + 1) + ",00 TL");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 25;

            if (int.TryParse(txt5.Text, out yemekAdeti))
            {
                txt5.Text = (yemekAdeti -1).ToString();
                label4.Text = Convert.ToString(yemekFiyati * (yemekAdeti - 1) + ",00 TL");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            peynir = "\nTerra Pizza Restoran'ından" + "\n" + txt1.Text + " adet " + groupBox1.Text + " vardır.\n" + " Tutar : " + label11.Text + "'dir";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bol = "\nTerra Pizza Restoran'ından" +"\n"+ txt2.Text + " adet " + groupBox2.Text + " vardır.\n" + "Toplam Tutar : " + label1.Text + "'dir";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            kavurma = "\nTerra Pizza Restoran'ından" +"\n"+ txt3.Text + " adet " + groupBox3.Text + " vardır.\n" + "Toplam Tutar : " + label3.Text + "'dir";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            sampiyon = "\nTerra Pizza Restoran'ından" +"\n"+  txt4.Text + " adet " + groupBox4.Text + " vardır.\n" + "Toplam Tutar : " + label3.Text + "'dir";
        }
        
        private void button14_Click(object sender, EventArgs e)
        {
            terra ="\nTerra Pizza Restoran'ından"+"\n"+ txt5.Text + " adet " + groupBox5.Text + " vardır.\n" + "Toplam Tutar : " + label4.Text + "'dir";
           
        }

        private void label10_MouseEnter(object sender, EventArgs e)
        {
            label10.BackColor = Color.DarkGreen;
        }

        private void label10_MouseLeave(object sender, EventArgs e)
        {
            label10.BackColor = Color.MediumSeaGreen;
        }

        private void terrapizza_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }
    }
}
