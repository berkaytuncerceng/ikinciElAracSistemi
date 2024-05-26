using ikinciElAracSistemiMimari.Abstracts;
using ikinciElAracSistemiMimari.Interfaces;
using ikinciElAracSistemiMimari.Concrete;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static ikinciElAracSistemiMimari.Enum.Enum;

namespace ikinciElAracSistemiMimari.Concrete
{
internal class SistemYoneticisi : Kisi, IIlanOnayla, IDonanimEkle
    {
        private List<AracTuru> aracTurleri = new List<AracTuru>();
        private List<string> markalar = new List<string>();
        private List<string> modeller = new List<string>();
        private List<AracDonanim> donanimlar = new List<AracDonanim>();

        public Vitrin Vitrin { get; set; } // Vitrin ilanlarını saklamak için

        public void girisYap(string eposta, string sifre)
        {
            Console.WriteLine("Giriş Yapıldı");
        }

        public void ilanOnayla(Ilan ilan)
        {
            ilan.yayinda = true;
            Vitrin.VitrinIlanlari.Add(ilan); // Onaylanan ilanları vitrin ilanlarına ekle
            Console.WriteLine("İlan Onaylandı");
        }

        public bool DonanimEkle(AracDonanim donanim)
        {
            donanimlar.Add(donanim);
            Console.WriteLine("Donanım Eklendi");
            return true;
        }

        public void YeniAracTuruEkle(AracTuru aracTuru)
        {
            if (!aracTurleri.Contains(aracTuru))
            {
                aracTurleri.Add(aracTuru);
                Console.WriteLine($"Yeni Araç Türü Eklendi: {aracTuru}");
            }
        }

        public void YeniMarkaEkle(string marka)
        {
            if (!markalar.Contains(marka))
            {
                markalar.Add(marka);
                Console.WriteLine($"Yeni Marka Eklendi: {marka}");
            }
        }

        public void YeniModelEkle(string model)
        {
            if (!modeller.Contains(model))
            {
                modeller.Add(model);
                Console.WriteLine($"Yeni Model Eklendi: {model}");
            }
        }

        public void GuncelleAracTuru(AracTuru eskiAracTuru, AracTuru yeniAracTuru)
        {
            int index = aracTurleri.IndexOf(eskiAracTuru);
            if (index != -1)
            {
                aracTurleri[index] = yeniAracTuru;
                Console.WriteLine($"Araç Türü Güncellendi: {eskiAracTuru} -> {yeniAracTuru}");
            }
        }

        public void GuncelleMarka(string eskiMarka, string yeniMarka)
        {
            int index = markalar.IndexOf(eskiMarka);
            if (index != -1)
            {
                markalar[index] = yeniMarka;
                Console.WriteLine($"Marka Güncellendi: {eskiMarka} -> {yeniMarka}");
            }
        }

        public void GuncelleModel(string eskiModel, string yeniModel)
        {
            int index = modeller.IndexOf(eskiModel);
            if (index != -1)
            {
                modeller[index] = yeniModel;
                Console.WriteLine($"Model Güncellendi: {eskiModel} -> {yeniModel}");
            }
        }
    }
}
