using promosyonTakip.core.entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace promosyonTakip.core.BusinessLogicService
{
    public class potansiyelMusteriServis : baseServis<potansiyelMusteri>
    {
        Database.promosyonSepeti db;
        public potansiyelMusteriServis()
        {
            db = new Database.promosyonSepeti();
        }

        public int kayitYeni(potansiyelMusteri data)
        {
            cmd = new SqlCommand("insert into potansiyelMusteri values (@tcKimlikNumara,@isim,@soyisim,@dogumTarih,@cinsiyet,@meslek," +
    "@emailAdres,@emailBildirimOnay,@telefon,@telefonBildirimOnay,@olusturmaTarih,@olusturanMagaza)");
            cmd.Parameters.Add("@tcKimlikNumara" ,System.Data.SqlDbType.NVarChar).Value = data.tcKimlikNumara;
            cmd.Parameters.Add("@isim", System.Data.SqlDbType.NVarChar).Value = data.isim;
            cmd.Parameters.Add("@soyisim", System.Data.SqlDbType.NVarChar).Value = data.soyisim;
            cmd.Parameters.Add("@dogumTarih", System.Data.SqlDbType.DateTime).Value = data.dogumTarih;
            cmd.Parameters.Add("@cinsiyet", System.Data.SqlDbType.Int).Value = data.cinsiyet;
            cmd.Parameters.Add("@meslek", System.Data.SqlDbType.NVarChar).Value = data.meslek;
            cmd.Parameters.Add("@emailAdres", System.Data.SqlDbType.NVarChar).Value = data.emailAdres;
            cmd.Parameters.Add("@emailBildirimOnay", System.Data.SqlDbType.Bit).Value = data.emailBidirimOnay;
            cmd.Parameters.Add("@telefon", System.Data.SqlDbType.NVarChar).Value = data.telefon;
            cmd.Parameters.Add("@telefonBildirimOnay", System.Data.SqlDbType.Bit).Value = data.telefonBidirimOnay;
            cmd.Parameters.Add("@olusturmaTarih", System.Data.SqlDbType.DateTime).Value = data.olusturmaTarih;
            cmd.Parameters.Add("@olusturanMagaza", System.Data.SqlDbType.Int).Value = data.olusturanMagaza;
            sonuc =  db.EkleDuzenleSil(cmd);
            return sonuc;
        }

        public int TCSorgula(string tcKimlikNumara)
        {
            cmd = new SqlCommand("select id from potansiyelMusteri where tcKimlikNumara = @tcKimlikNumara");
            cmd.Parameters.Add("@tcKimlikNumara", System.Data.SqlDbType.NVarChar).Value = tcKimlikNumara;
            obj = db.kolonGetir(cmd);
            return obj == null ? 0 : (int)obj;
        }
    }
}
//create table potansiyelMusteri
//(
//id int identity(1,1) primary key,
//tcKimlikNumara nvarchar(15),
//isim nvarchar(15),
//soyisim nvarchar(15),
//dogumTarih datetime ,
//cinsiyet int,
//meslek nvarchar(100),
//emailAdres nvarchar(100),
//emailBildirimOnay bit,
//telefon nvarchar(15),
//telefonBildirimOnay bit,
//olusturmaTarih datetime,
//olusturanMagaza int
//)