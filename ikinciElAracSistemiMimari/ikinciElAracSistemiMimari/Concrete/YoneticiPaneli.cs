using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ikinciElAracSistemiMimari.Concrete
{
    public class SistemYoneticisiPaneli
{
    public void Calistir()
    {
        while (true)
        {
            Console.WriteLine("1. Yeni araç bilgisi gir");
            Console.WriteLine("2. Mevcut araç bilgisini güncelle");
            Console.WriteLine("3. Çıkış");
            Console.Write("Seçiminizi yapın: ");
            string secim = Console.ReadLine();

            switch (secim)
            {
                case "1":
                    YeniAracBilgisiGir();
                    break;
                case "2":
                    MevcutAracBilgisiniGuncelle();
                    break;
                case "3":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Geçersiz seçim! Lütfen tekrar deneyin.");
                    break;
            }
        }
    }

    private void YeniAracBilgisiGir()
    {
        // Yeni araç bilgisi girişini yap
        Console.WriteLine("Yeni araç bilgisi girişi yapılıyor...");
    }

    private void MevcutAracBilgisiniGuncelle()
    {
        // Mevcut araç bilgisini güncelleme işlemini yap
        Console.WriteLine("Mevcut araç bilgisi güncelleniyor...");
    }
}
}
