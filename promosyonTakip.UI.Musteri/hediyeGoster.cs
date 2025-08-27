using promosyonTakip.core.entities;
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
    public partial class hediyeGoster : Form
    {
        public hediyeGoster(promosyonUrun data)
        {
            InitializeComponent();

            lblAciklama.Text = data.tanim.ToUpper() + " " + data.aciklama.ToUpper() + " " + "kazandınız";
        }

        private void hediyeGoster_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           Form anaEkranfrm = Application.OpenForms["anaEkran"];
            anaEkranfrm.Close();

            anaEkran anaEkran = new anaEkran();
            anaEkran.Show();
            this.Close();

        }
    }
}
