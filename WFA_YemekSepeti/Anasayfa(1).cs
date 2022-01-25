using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace WFA_YemekSepeti
{
    public partial class Anasayfa : MetroForm
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BurgerKing BK = new BurgerKing();
            BK.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GreenSalads GS = new GreenSalads();
            GS.ShowDialog();
        }
    }
}
