using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace promosyonTakip.core.entities
{
    public class katilimciPromosyon
    {
        public int id { get; set; }
        public int potansiyelMusteriId { get; set; }
        public int promosyonUrunId { get; set; }
        public DateTime olusturmaTarih { get; set; }
        public int magazaId { get; set; }

        //        create table katilimciPromosyon
        //(
        //id int identity(1,1) primary key,
        //potansiyelMusteriId int,
        //promosyonUrunId int,
        //olusturmaTarih datetime,
        //magazaId int,

        //)
    }
}
