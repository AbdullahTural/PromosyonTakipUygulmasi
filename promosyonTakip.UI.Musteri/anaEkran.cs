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
   
    public partial class anaEkran : Form
    {
        potansiyelMusteri data;
        public anaEkran()
        {
            InitializeComponent();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            GroupBox musteriBilgleri = (GroupBox)this.Controls["grpMusteriBigileri"];
            foreach (Control item in musteriBilgleri.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = string.Empty;
                }
                else if (item is CheckBox)
                {
                    ((CheckBox)item).Checked = false;
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            potansiyelMusteriServis potansiyelMusteriServis = new potansiyelMusteriServis();
          int TCKontrol =  potansiyelMusteriServis.TCSorgula(txtTcKimlikNo.Text);
            if (TCKontrol > 0)
            {
                MessageBox.Show("Daha önce kaydınız bulunmaktadır.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                data = new potansiyelMusteri();
                data.tcKimlikNumara = txtTcKimlikNo.Text;
                data.isim = txtIsim.Text;
                data.soyisim = txtSoyisim.Text;
                data.dogumTarih = txtDogumTarih.Value;
                data.cinsiyet = ((cinsiyet)cmbCinsiyet.SelectedItem).id;
                data.meslek = txtMeslek.Text;
                data.emailAdres = txtEpostaAdres.Text;
                data.emailBidirimOnay = chkEpostaOnay.Checked;
                data.telefon = txtTelefon.Text;
                data.telefonBidirimOnay = chkSmsOnay.Checked;
                data.olusturmaTarih = DateTime.Now;
                data.olusturanMagaza = staticFieldList.magazaID;

                int musteriKayit = potansiyelMusteriServis.kayitYeni(data);
                if (musteriKayit > 0)
                {
                MessageBox.Show("Kayıt başarılı .Lütfen hediye seçiniz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    HediyeSecimHazirla();

                }
                else
                {
                    MessageBox.Show("Sistemsel Hata", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        public void HediyeSecimHazirla()
        {
            List<promosyonUrun> hediyeUrunListesi = new List<promosyonUrun>();
            promosyonUrunServis servisPromosyon = new promosyonUrunServis();
            hediyeUrunListesi = servisPromosyon.UrunlisteGetir();
            if(hediyeUrunListesi != null && hediyeUrunListesi.Count > 0)
            {
                for (int i = 0; i < hediyeUrunListesi.Count; i++)
                {
                PictureBox pctBox = new PictureBox();
                    pctBox.Width = 62;
                    pctBox.Height = 67;
                pctBox.Image = Image.FromFile("C:/Users/karne/source/repos/promosyonTakipUygulaması/promosyonTakip/www.root/Hediyelik.png");
                pctBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pctBox.Tag = hediyeUrunListesi[i];
                    pctBox.Click += pctBox_Click;
                    hediyePanel.Controls.Add(pctBox);
                    
                }

              

            }
            else
            {
                MessageBox.Show("Kampanya Bitti . Hediye seçimi için ürün bulunmamaktadır.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pctBox_Click(object sender, EventArgs e)
        {
            PictureBox secilenHediye = (PictureBox)sender;
            promosyonUrun kazanılanUrun = (promosyonUrun)secilenHediye.Tag;
            if (kazanılanUrun != null && kazanılanUrun.id > 0)
            {
                katilimciPromosyonServis servisKatilimci = new katilimciPromosyonServis();
                promosyonUrunServis servisPromosyon = new promosyonUrunServis();
                potansiyelMusteriServis servisMusteri = new potansiyelMusteriServis();

                servisPromosyon.urunKullanildiIsaretle(kazanılanUrun.id);
                servisKatilimci.kayitYeni(new katilimciPromosyon()
                {
                    potansiyelMusteriId = servisMusteri.TCSorgula(txtTcKimlikNo.Text),
                    promosyonUrunId = kazanılanUrun.id,
                    olusturmaTarih = DateTime.Now,
                    magazaId = staticFieldList.magazaID
                });


                hediyeGoster hediyeGoster = new hediyeGoster(kazanılanUrun);
                hediyeGoster.ShowDialog();

                hediyePanel.Controls.Clear();

                GroupBox musteriBilgleri = (GroupBox)this.Controls["grpMusteriBigileri"];
                foreach (Control item in musteriBilgleri.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = string.Empty;
                    }
                    else if (item is CheckBox)
                    {
                        ((CheckBox)item).Checked = false;
                    }
                    else if (item is ComboBox)
                    {
                        ((ComboBox)item).SelectedIndex = -1;
                    }
                }


            }
            else
            {
                MessageBox.Show("Kampanya Bitti . Hediye seçimi için ürün bulunmamaktadır.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }

        private void anaEkran_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.DataSource = staticFieldList.cinsiyetYükle();
        }
    }
}
