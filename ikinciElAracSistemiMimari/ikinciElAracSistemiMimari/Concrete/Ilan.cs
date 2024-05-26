using ikinciElAracSistemiMimari.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ikinciElAracSistemiMimari.Concrete
{
    public class Ilan
    {
        public bool yayinda { get; set; }
        public int ID { get; set; }
        public Arac arac { get; set; } // ilandaki araç
        public Kisi sahip { get; set; }// ilan veren kişi

    }
}
