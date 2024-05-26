using ikinciElAracSistemiMimari.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ikinciElAracSistemiMimari.Interfaces
{
    internal interface IIlanFiltrele
    {
        public List<Vitrin> Filtrele(List<Vitrin> ilanlar, Arac kriterler)
        {
            // Filtreleme işlemlerini burada gerçekleştir
            List<Vitrin> filtrelenmisIlanlar = new List<Vitrin>();
            return filtrelenmisIlanlar;
        }
    }
}
