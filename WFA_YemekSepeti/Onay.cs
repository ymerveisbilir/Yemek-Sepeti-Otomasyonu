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
    public partial class Onay : Form
    {
        public Onay()
        {
            InitializeComponent();
        }

        //KAYDET butonu basılınca sipariş alındı uyarısı.
        private void button1_Click(object sender, EventArgs e)
        {
            son sn= new son();
            this.Hide();
            sn.ShowDialog();
        }


        // Telefon numarası textboxa sadece sayı girişi 
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))//rakam giriliyor metin girilemiyor
            {
                e.Handled = true;
            }
        }

        //11 haneden daha fazla numara girilemez.
        //15 karakter yazma sebebimiz (+90) = +5 karakter var.
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int sınır = textBox2.TextLength;
            if (sınır == 15)
            {
                MessageBox.Show("Maksimum numara girme sınırına ulaştınız.");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Onay_Load(object sender, EventArgs e)
        {
            string[] iller = { "ANKARA", "BURSA", "ÇANAKKALE", "ESKİŞEHİR", "İSTANBUL", "TRABZON" };
            comboBox2.Items.AddRange(iller);    

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox2.Text=="ANKARA")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Akyurt");
                comboBox3.Items.Add("Altındağ");
                comboBox3.Items.Add("Beypazarı");
                comboBox3.Items.Add("Çamlıdere");
                comboBox3.Items.Add("Elmadağ");
                comboBox3.Items.Add("Güdül");
                comboBox3.Items.Add("Keçiören");
                comboBox3.Items.Add("Kızılcahamam");
                comboBox3.Items.Add("Polatlı");
            }
          else if (comboBox2.Text == "BURSA")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Büyükorhan");
                comboBox3.Items.Add("Gemlik");
                comboBox3.Items.Add("İnegöl");
                comboBox3.Items.Add("İznik");
                comboBox3.Items.Add("Mudanya");
                comboBox3.Items.Add("Nilüfer");
                comboBox3.Items.Add("Orhangazi");
                comboBox3.Items.Add("Osmangazi");
                comboBox3.Items.Add("Yıldırım");
            }
            else if (comboBox2.Text == "ÇANAKKALE")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Ayvacık");
                comboBox3.Items.Add("Biga");
                comboBox3.Items.Add("Bozcaada");
                comboBox3.Items.Add("Çan");
                comboBox3.Items.Add("Ezine");
                comboBox3.Items.Add("Gelibolu");
                comboBox3.Items.Add("Gökçeada");
                comboBox3.Items.Add("Lapseki");
                comboBox3.Items.Add("Yenice");
            }
            else if (comboBox2.Text == "ESKİŞEHİR")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Alpu");
                comboBox3.Items.Add("Han");
                comboBox3.Items.Add("Günyüzü");
                comboBox3.Items.Add("İnönü");
                comboBox3.Items.Add("Mahmudiye");
                comboBox3.Items.Add("Odunpazarı");
                comboBox3.Items.Add("Sivrihisar");
                comboBox3.Items.Add("Tepebaşı");
               
            }
            else if (comboBox2.Text == "İSTANBUL")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Ataşehir");
                comboBox3.Items.Add("Avcılar");
                comboBox3.Items.Add("Bağcılar");
                comboBox3.Items.Add("Bahçelievler");
                comboBox3.Items.Add("Bakırköy");
                comboBox3.Items.Add("Bayrampaşa");
                comboBox3.Items.Add("Çatalca");
                comboBox3.Items.Add("Esenler");
                comboBox3.Items.Add("Kartal");
                comboBox3.Items.Add("Küçükçekmece");
                comboBox3.Items.Add("Maltepe");
                comboBox3.Items.Add("Pendik");
                comboBox3.Items.Add("Sarıyer");
                comboBox3.Items.Add("Silivri");
                comboBox3.Items.Add("Üsküdar");
                comboBox3.Items.Add("Zeytinburnu");

            }

           else if (comboBox2.Text == "TRABZON")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Akçaabat");
                comboBox3.Items.Add("Beşikdüzü");
                comboBox3.Items.Add("Çaykara");
                comboBox3.Items.Add("Maçka");
                comboBox3.Items.Add("Of");
                comboBox3.Items.Add("Sürmene");
                comboBox3.Items.Add("Tonya");
                comboBox3.Items.Add("Vakfıkebir");
                
            }

        }
    }
}
