using promosyonTakip.core.entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace promosyonTakip.core.BusinessLogicService
{
    public class promosyonUrunServis : baseServis<promosyonUrun>
    {
        Database.promosyonSepeti db;
        public promosyonUrunServis()
        {
            db = new Database.promosyonSepeti();
        }
        public List<promosyonUrun> UrunlisteGetir()
        {
            liste = new List<promosyonUrun>();
            cmd =  new SqlCommand("select top 48 * from promosyonUrun where kulllanimDurum = 1 order by NEWID()");
            reader = db.liste(cmd);
            while (reader.Read())
            {
                liste.Add(new promosyonUrun()
                {
                    id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                    tanim = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                    aciklama = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                     gecerlilikTarih = reader.IsDBNull(3) ? DateTime.MinValue : reader.GetDateTime(3),
                    kullanimDurum = reader.IsDBNull(4) ? false : reader.GetBoolean(4)

                });
            }
            reader.Close();
            db.BaglantiDurumuAyarla();
            return liste;
        }

        public promosyonUrun tekUrunGetir(int id)
        {
            data = new promosyonUrun();
            cmd = new SqlCommand("select * from promosyonUrun where id = @id");
            cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
            reader = db.liste(cmd);
            while (reader.Read())
            {
                data.id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                data.tanim = reader.IsDBNull(1) ? string.Empty : reader.GetString(1);
                data.aciklama = reader.IsDBNull(2) ? string.Empty : reader.GetString(2);
                data.gecerlilikTarih = reader.IsDBNull(3) ? DateTime.MinValue : reader.GetDateTime(3);
                data.kullanimDurum = reader.IsDBNull(4) ? false : reader.GetBoolean(4);
            }
            reader.Close();
            db.BaglantiDurumuAyarla();
            return data;
        }

        public int urunKullanildiIsaretle(int id)
        {
            cmd = new SqlCommand("update promosyonUrun set kulllanimDurum = @kullanimDurum where id = @id");
            cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@kullanimDurum", System.Data.SqlDbType.Bit).Value = false;
            sonuc = db.EkleDuzenleSil(cmd);
            return sonuc;
        }
    }
}
