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
    public partial class Sepetim : Form
    {

        public string siparis;
        public Sepetim()
        {
            InitializeComponent();
        }

       
        private void Sepetim_Load(object sender, EventArgs e)
        {

     
            
           label1.Text = GreenSalads.mevsimSalata.ToString() + GreenSalads.köriTavuk.ToString() + GreenSalads.napolitanPenne.ToString() + GreenSalads.tonBalık.ToString() + GreenSalads.ozelFettuccine.ToString() + GreenSalads.FettuccinePirzola.ToString() + BakırköyProfiterol.fırınSütlac.ToString() + BakırköyProfiterol.cikolatalıEkler.ToString() + BakırköyProfiterol.cikolatalıProfiterol.ToString() + BakırköyProfiterol.karisikEkler.ToString() + burger.ucluwhopper.ToString() + burger.kıngChıcken.ToString() + burger.whopper.ToString() + burger.benimİkilim.ToString() + burger.sufle.ToString() + Dominos.ikiOrta.ToString() + Dominos.buyukBoy.ToString() + Environment.NewLine + Dominos.ucAl.ToString() + Dominos.bolMolzemos.ToString() + Dominos.cikolatalıSufle.ToString() + Dominos.cokomis.ToString() + FarukGulluoglu.sutluNuriye.ToString() + FarukGulluoglu.fıstıklıDurum.ToString() + FarukGulluoglu.midyeBaklava.ToString() + FarukGulluoglu.telKadayıf.ToString() + FarukGulluoglu.burmaKadayıf.ToString() + FarukGulluoglu.frambuazlı.ToString() + FarukGulluoglu.krokanlı.ToString() + bayramoglu.porsiyonDoner.ToString() + bayramoglu.pilavDoner.ToString() + bayramoglu.DonerDurum1.ToString() + bayramoglu.DonerDurum2.ToString() + bayramoglu.DonerDurum3.ToString() + bayramoglu.salgam.ToString() + bayramoglu.gazlıİcecek.ToString() + bayramoglu.su.ToString() + bayramoglu.sutlac.ToString() + bayramoglu.havucDilim.ToString() + popeyes.secilmismenu.ToString() + popeyes.kovamenu.ToString() + popeyes.kemiksizmenu.ToString() + popeyes.kovapapates.ToString() + popeyes.cıtırsoganhalkası.ToString() + popeyes.sufle.ToString() + baydoner.iskender.ToString() + baydoner.kankamenu.ToString() + baydoner.beyti.ToString() + Environment.NewLine + baydoner.sutlac.ToString() + Environment.NewLine + baydoner.kunefe.ToString() + terrapizza.peynir.ToString() + terrapizza.bol.ToString() + terrapizza.kavurma.ToString() + terrapizza.sampiyon.ToString() + terrapizza.terra.ToString();
          
        }



        private void button1_Click(object sender, EventArgs e)
        {

            Onay onay = new Onay();
            onay.ShowDialog();
        }

        private void label55_Click(object sender, EventArgs e)
        {

        }


        //Sepeti Temizleme Butonu
        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label1.Text = "Sepetinizde ürün kalmamıştır." + Environment.NewLine + "Anasayfaya dönün";     
        }
        


        //Anasayfaya Dönme Butonu
        private void button32_Click_1(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            this.Hide();
            anasayfa.Show();
        }
    }
}
