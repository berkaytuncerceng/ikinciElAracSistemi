using ikinciElAracSistemiMimari.Abstracts;
using ikinciElAracSistemiMimari.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ikinciElAracSistemiMimari.Enum.Enum;

namespace ikinciElAracSistemiMimari.Concrete
{
    internal class AracSahibi : Kisi, IIlanEkle , IIlanGuncelle
    {
        public List<Ilan> Ilanlar { get; set; } = new List<Ilan>();

        public void GirisYap(string eposta, string sifre, Database database)
        {
            database.baglan();

            string dogruEposta = "ornek@ornek.com";
            string dogruSifre = "sifre123";

            if (eposta == dogruEposta && sifre == dogruSifre)
            {
                Console.WriteLine("Giriş başarılı!");
            }
            else
            {
                Console.WriteLine("E-posta veya şifre hatalı. Giriş başarısız!");
            }
        }

        public void IlanEkle(Ilan ilan, SistemYoneticisi sistemYoneticisi)
        {
            Ilanlar.Add(ilan);
            Console.WriteLine("Yeni ilan eklendi ve onay bekliyor.");
            sistemYoneticisi.ilanOnayla(ilan);
        }

        public void IlanGuncelle(Ilan ilan , SistemYoneticisi sistemYoneticisi)
        {
            var mevcutIlan = Ilanlar.Find(i => i.ID == ilan.ID);
            if (mevcutIlan != null)
            {
                mevcutIlan = ilan;
                Console.WriteLine("İlan güncellendi ve onay bekliyor.");
                sistemYoneticisi.ilanOnayla(ilan);
            }
        }

        public Arac AracOlustur(AracTuru aracTuru, int uretimYili, string marka, string model, YakitTuru yakit, string motor, SanzimanTuru sanziman, int km, decimal fiyat, string gorsel)
        {
            return new Arac
            {
                aracTuru = aracTuru,
                uretimYili = uretimYili,
                marka = marka,
                model = model,
                yakit = yakit,
                motor = motor,
                sanziman = sanziman,
                km = km,
                fiyat = fiyat,
                gorsel = gorsel,
                donanim = new AracDonanim()
            };
        }

        public void DonanimEkle(Arac arac, bool camTavan, bool sisFari, bool katlanabilirAyna, bool parkSensoru, bool merkeziKilit)
        {
            if (arac.donanim == null)
            {
                arac.donanim = new AracDonanim();
            }

            arac.donanim.camTavan = camTavan;
            arac.donanim.sisFari = sisFari;
            arac.donanim.katlanabilirAyna = katlanabilirAyna;
            arac.donanim.parkSensoru = parkSensoru;
            arac.donanim.merkeziKilit = merkeziKilit;

            Console.WriteLine("Araca donanım eklendi.");
        }
    }

}
