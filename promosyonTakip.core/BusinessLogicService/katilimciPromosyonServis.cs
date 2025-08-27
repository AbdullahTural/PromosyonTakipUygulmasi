using promosyonTakip.core.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace promosyonTakip.core.BusinessLogicService
{
    public class katilimciPromosyonServis
    {

        Database.promosyonSepeti db;
        public katilimciPromosyonServis()
        {
            db = new Database.promosyonSepeti();
        }

        public int kayitYeni(katilimciPromosyon data)
        {
            var cmd = new System.Data.SqlClient.SqlCommand("insert into katilimciPromosyon values (@potansiyelMusteriId,@promosyonUrunId,@olusturmaTarih,@magazaId)");
            cmd.Parameters.Add("@potansiyelMusteriId", System.Data.SqlDbType.Int).Value = data.potansiyelMusteriId;
            cmd.Parameters.Add("@promosyonUrunId", System.Data.SqlDbType.Int).Value = data.promosyonUrunId;
            cmd.Parameters.Add("@olusturmaTarih", System.Data.SqlDbType.DateTime).Value = data.olusturmaTarih;
            cmd.Parameters.Add("@magazaId", System.Data.SqlDbType.Int).Value = data.magazaId;
            int sonuc = db.EkleDuzenleSil(cmd);
            return sonuc;
        }
    }
}
