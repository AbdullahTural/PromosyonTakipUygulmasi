using promosyonTakip.core.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace promosyonTakip.core.Helper
{
    public class staticFieldList
    {
        public static int magazaID  { get; set; }

        public static List<cinsiyet> cinsiyetYükle()
        {
            List<cinsiyet> cinsiyetList = new List<cinsiyet>();
            cinsiyetList.Add(new cinsiyet { id = 1, tanim = "Erkek" });
            cinsiyetList.Add(new cinsiyet { id = 2, tanim = "Kadın" });
            return cinsiyetList;
        }
    }
}
