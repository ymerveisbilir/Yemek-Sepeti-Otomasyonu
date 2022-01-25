using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace loginyemeksepeti
{
   
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
        }


        


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.ShowDialog();
            try
            {
                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.jet.oledb.4.0;data source=kullanicilogin.mdb");
                baglanti.Open();
                OleDbCommand sorgu = new OleDbCommand("select kullaniciadi,sifre from kullanici where kullaniciadi=@ad and sifre=@ ", baglanti);
                sorgu.Parameters.AddWithValue("@ad", textBox1.Text);
                sorgu.Parameters.AddWithValue("@sifre", textBox2.Text);
                OleDbDataReader dr;
                dr = sorgu.ExecuteReader();

                if (dr.Read())
                {
                    if (gkodu == Convert.ToInt16(textBox3.Text)) 

                    {
                        kullanici frm = new kullanici();
                        frm.Show();
                        this.Visible = false;
                    }

                else 
                {
                    MessageBox.Show("Güvenlik kodunu yanlış girdiniz.Lütfen tekrar deneyiniz.");
                }
                }
                else
                {
                    baglanti.Close();
                    MessageBox.Show("Yanlış kullanıcı adı veya şifre girdiniz.Lütfen tekrar deneyiniz..");

                }

            }
            catch
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifreniz ile giriş yapınız.");
 
            }
            finally
            {
                textBox1.Text = "";
                textBox2.Clear();
            }



        }
        int gkodu;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
             gkodu= rnd.Next(1000,9999);
            label4.Text = gkodu.ToString(); 
        
        
        
        }
       




    }
}
