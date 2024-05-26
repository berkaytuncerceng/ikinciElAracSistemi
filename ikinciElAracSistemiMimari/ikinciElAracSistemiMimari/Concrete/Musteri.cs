using ikinciElAracSistemiMimari.Abstracts;
using ikinciElAracSistemiMimari.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ikinciElAracSistemiMimari.Concrete
{
    internal class Musteri : Kisi , IIlanGoruntule, IIlanKarsilastir, IIlanFiltrele, IYorumYap
    {
        public List<Ilan> FavoriIlanlar { get; set; } = new List<Ilan>();
        public void girisYap(string eposta, string sifre)
        {
            Console.WriteLine("Giriş Yapıldı");
        }

        public void Kaydol(string eposta, string sifre, string isim , string soyisim)
        {
            Console.WriteLine("Kayıt Olundu");
        }


        public void IlanlariGoruntule(Vitrin vitrin)
        {
            foreach (var ilan in vitrin.VitrinIlanlari)
            {
                // İlanları müşterilere gösterme işlemi
                Console.WriteLine($"ID: {ilan.ID}, Marka: {ilan.arac.marka}, Model: {ilan.arac.marka}, Fiyat: {ilan.arac.marka}");
            }
        }
        public void IlanDetaylariniGoruntule(Ilan ilan) 
        {
            Console.WriteLine("Ilan detayi goruntulendi.");
        }
        public void karsilastir(Ilan arac1, Ilan arac2)
        {
            Console.WriteLine("Ilanlar Karsilastirildi");
        }

        public List<Vitrin> Filtrele(List<Vitrin> ilanlar, Arac kriterler)
        {
            // Filtreleme işlemlerini burada gerçekleştir
            List<Vitrin> filtrelenmisIlanlar = new List<Vitrin>();
            return filtrelenmisIlanlar;
        }
        public List<Vitrin> IlanAra(Arac aramaKriterleri)
        {
            // İlanları arama kriterlerine göre filtreleme ve döndürme işlemi
            return new List<Vitrin>();
        }

        public void YorumYap(Yorum yorum)
        {
            Console.WriteLine("Yorum Yapildi");
        }
    }
}
