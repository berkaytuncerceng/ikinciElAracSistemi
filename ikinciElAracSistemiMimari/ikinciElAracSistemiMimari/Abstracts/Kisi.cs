using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ikinciElAracSistemiMimari.Abstracts
{
    public abstract class Kisi
    {
        public int ID { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string eposta { get; set; }
        public string sifre { get; set; }

        public virtual void girisYap(string eposta, string sifre , Database database)
        {
            {
                database.baglan();
                database.kontrolEt();
                // Burada normalde e-posta ve şifre doğrulaması yapılır
                // Örneğin, veritabanına bağlanarak kullanıcı adı ve şifre kontrol edilir
                // Ancak bu örnek için basit bir doğrulama yapacağız

                // Örnek bir e-posta ve şifre
                string dogruEposta = "ornek@ornek.com";
                string dogruSifre = "sifre123";

                // Verilen e-posta ve şifre ile doğrulama yap
                if (eposta == dogruEposta && sifre == dogruSifre)
                {
                    Console.WriteLine("Giriş başarılı!");
                }
                else
                {
                    Console.WriteLine("E-posta veya şifre hatalı. Giriş başarısız!");
                }
            }

        }
        // virtual yapsaydım gövdesi olmak zorunda olacaktı ve
        //girişyap metodu isteğe bağlı olacaktı. Şu an giriş yapmak zorunlu.
    }
}
