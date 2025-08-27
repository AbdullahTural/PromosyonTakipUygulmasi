using promosyonTakip.core.BusinessLogicService;
using promosyonTakip.core.entities;
using promosyonTakip.core.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace promosyonTakip.UI.Musteri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtKullaniciAdi.Text) && !string.IsNullOrEmpty(txtSifre.Text))
            {
                sistemMagazaServis servisMagaza = new sistemMagazaServis();
               int magazaID = servisMagaza.magazaKullaniciKontrol(txtKullaniciAdi.Text, txtSifre.Text);
                if (magazaID > 0 )
                {
                    staticFieldList.magazaID = magazaID;
                    anaEkran _anaEkran = new anaEkran();
                    _anaEkran.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı adı veya sifre ", "Bilgilendirme" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Form alanlarını eksiksiz olarak doldurunuz " ,"Bilgilendirme" , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
              
        }
    }
}
