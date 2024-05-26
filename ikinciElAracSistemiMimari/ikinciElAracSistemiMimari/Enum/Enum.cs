using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ikinciElAracSistemiMimari.Enum
{
    public class Enum
    {
        public enum AracTuru
        {
            Sedan,
            Hatchback,
            SUV,
            Kamyonet,
            // Diğer araç türleri
        }

        public enum YakitTuru
        {
            Benzin,
            Dizel,
            Elektrik,
            Hibrit,
            // Diğer yakıt türleri
        }

        public enum SanzimanTuru
        {
            Manuel,
            Otomatik,
            YariOtomatik,
            // Diğer şanzıman türleri
        }
    }
}
