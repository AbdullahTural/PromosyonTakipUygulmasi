using promosyonTakip.core.entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace promosyonTakip.core.BusinessLogicService
{
    public class sistemMagazaServis : baseServis<sistemMagaza>
    {
        Database.promosyonSepeti db;
        public sistemMagazaServis()
        {
            db = new Database.promosyonSepeti();
        }


        public int magazaKullaniciKontrol(string kullaniciAdi , string sifre)
        {
            cmd = new SqlCommand("select id from sistemMagaza where kullaniciAdi = @kullaniciAdi and sifre = @sifre");
            cmd.Parameters.Add("@kullaniciAdi", System.Data.SqlDbType.NVarChar).Value = kullaniciAdi;
            cmd.Parameters.Add("@sifre", System.Data.SqlDbType.NVarChar).Value = sifre;
            obj = db.kolonGetir(cmd);
            return obj == null ? 0 : (int)obj;

        }
    }
}
