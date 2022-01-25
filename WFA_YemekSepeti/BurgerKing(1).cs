using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;


namespace WFA_YemekSepeti
{
    public partial class BurgerKing : MetroForm
    {
        public BurgerKing()
        {
            InitializeComponent();
        }
        //textbox'lara dışardan erişimi propetieslerden Enable==False yaparak kapattık.



        //Seçilmiş Menü 3'Lü Whopper Menü yemekAdeti arttırma butonu.
        private void button2_Click(object sender, EventArgs e)
        {
            int yemekAdeti =1;
            int yemekFiyati = 68;

            if (int.TryParse(txt1.Text, out yemekAdeti))
            {
                txt1.Text = (yemekAdeti+1).ToString();
                label11.Text = Convert.ToString(yemekFiyati * (yemekAdeti+1)  + ",99 TL");
            }
        }

        //King Chıcken Menü yemekAdeti arttırma butonu.
        private void button3_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 37;

            if (int.TryParse(txt2.Text, out yemekAdeti))
            {
                txt2.Text = (yemekAdeti + 1).ToString();
                label12.Text = Convert.ToString(yemekFiyati * (yemekAdeti + 1) + ",99 TL");
            }
        }


        //Whopper yemekAdeti arttırma butonu.
        private void button5_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 49;

            if (int.TryParse(txt3.Text, out yemekAdeti))
            {
                txt3.Text = (yemekAdeti + 1).ToString();
                label13.Text = Convert.ToString(yemekFiyati * (yemekAdeti + 1) + ",99 TL");
            }
        }

        //Benim İkilim Menü yemekAdedi arttırma butonu.
        private void button7_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 46;

            if (int.TryParse(txt4.Text, out yemekAdeti))
            {
                txt4.Text = (yemekAdeti + 1).ToString();
                label14.Text = Convert.ToString(yemekFiyati * (yemekAdeti + 1) + ",99 TL");
            }
        }

        //sufle yemekAdeti arttırma butonu.
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


         //SEPETİM YAZILI LABEL RENKLENDİRME
        private void label10_MouseEnter(object sender, EventArgs e)
        {
            label10.BackColor = Color.DarkOrange;
        }

        //SEPETİM YAZILI LABEL RENKLENDİRME
        private void label10_MouseLeave(object sender, EventArgs e)
        {
            label10.BackColor = Color.Green;
        }

        //Seçilmiş menü 3'lü whopper yemekAdeti azaltma butonu.
        private void button8_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 68;

            if (int.TryParse(txt1.Text, out yemekAdeti))
            {
                txt1.Text = (yemekAdeti - 1).ToString();
                label11.Text = Convert.ToString(yemekFiyati * (yemekAdeti - 1) + ",99 TL");
            }
        }

        //Kıng Chıcken Menü yemekAdeti azaltma butonu.
        private void button6_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 37;

            if (int.TryParse(txt2.Text, out yemekAdeti))
            {
                txt2.Text = (yemekAdeti - 1).ToString();
                label12.Text = Convert.ToString(yemekFiyati * (yemekAdeti - 1) + ",99 TL");
            }
        }

        //Whopper menü yemekAdeti azaltma butonu.
        private void button1_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 49;

            if (int.TryParse(txt3.Text, out yemekAdeti))
            {
                txt3.Text = (yemekAdeti - 1).ToString();
                label13.Text = Convert.ToString(yemekFiyati * (yemekAdeti - 1) + ",99 TL");
            }
        }

        //Benim İkilim yemekAdeti azaltma butonu.
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

        //Sufle yemekAdeti azaltma butonu.
        private void button10_Click(object sender, EventArgs e)
        {
            int yemekAdeti = 1;
            int yemekFiyati = 12;

            if (int.TryParse(txt5.Text, out yemekAdeti))
            {
                txt5.Text = (yemekAdeti - 1).ToString();
                label15.Text = Convert.ToString(yemekFiyati * (yemekAdeti - 1) + ",99 TL");
            }
        }
    
    }
}
