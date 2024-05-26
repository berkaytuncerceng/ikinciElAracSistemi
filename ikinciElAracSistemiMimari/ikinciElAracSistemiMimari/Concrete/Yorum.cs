using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ikinciElAracSistemiMimari.Concrete
{
    public class Yorum
    {
        public string metin { get; set; }
        public string yorumSahibi { get; set; }

        public Yorum(string Metin, string YorumSahibi)
        {
            metin = Metin;
            yorumSahibi = YorumSahibi;
        }
    }
}
