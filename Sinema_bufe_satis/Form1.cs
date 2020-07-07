using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_bufe_satis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
        int kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, bilet, su, cay,toplam;
            misir = Convert.ToInt16(TxtMisir.Text);
            cay = Convert.ToInt16(TxtCay.Text);
            su = Convert.ToInt16(TxtSu.Text);
            bilet = Convert.ToInt16(TxtBilet.Text);
            toplam = misir * 4 + cay * 2 + su * 1 + bilet * 8;
            LblToplam.Text = toplam.ToString()+" TL";
            kasatutar = kasatutar + toplam;
            LblKasa.Text = kasatutar.ToString()+" TL";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtBilet.Text = "";
            TxtCay.Text = "";
            TxtMisir.Text = "";
            TxtSu.Text = "";
            TxtMisir.Focus();
            //LblKasa.Text = "0 TL";
            //LblToplam.Text = "0 TL";
             
        }
    }
}
