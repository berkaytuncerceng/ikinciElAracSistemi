using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ikinciElAracSistemiMimari.Enum.Enum;

namespace ikinciElAracSistemiMimari.Concrete
{

    public class Arac
    {
        public int aracID { get; set; }
        public AracTuru aracTuru { get; set; }
        public int uretimYili { get; set; }
        public string marka { get; set; }
        public string model { get; set; }
        public YakitTuru yakit { get; set; }
        public string motor { get; set; }
        public SanzimanTuru sanziman { get; set; }
        public int km { get; set; }
        public decimal fiyat { get; set; }
        public string gorsel { get; set; }

        public AracDonanim donanim { get; set; }

    }

}
