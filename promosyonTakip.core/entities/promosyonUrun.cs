using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace promosyonTakip.core.entities
{
    public class promosyonUrun
    {
        public int id { get; set; }
        public string tanim { get; set; }
        public string aciklama { get; set; }
        public DateTime gecerlilikTarih { get; set; }
        public bool kullanimDurum { get; set; }



        //        create table promosyonUrun
        //(
        //id int identity(1,1) primary key,
        //tanim nvarchar(100),
        //aciklama nvarchar(250),
        //gecerlilikTarih datetime,
        //kulllanimDurum bit


    }
}
