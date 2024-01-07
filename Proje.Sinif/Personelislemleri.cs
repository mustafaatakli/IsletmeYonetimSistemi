using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Sinif
{
    public class Personelislemleri : Personel, IBilgiler
    {
        string IBilgiler.isim { get; set; }
        string IBilgiler.soyisim { get; set; }
        string IBilgiler.department { get; set; }


        public void Goster()
        {
            Console.WriteLine("Kişisel bilgiler ekrana yazdırılıyor.");
        }


        private string izinBilgisi;
        private string maasBilgisi;
        private string oneriBilgisi;

        public void IzinGoruntule(string IzinGunleri)
        {
            izinBilgisi = IzinGunleri;
        }

        public string IzinGoruntule()
        {
            return izinBilgisi;
        }

        public void MaasGoruntule(string Maas)
        {
            maasBilgisi = Maas;
        }

        public string MaasGoruntule()
        {
            return maasBilgisi;
        }

        public void OneriGoruntule(string oneri)
        {
            oneriBilgisi = oneri;
        }

        public string OneriGoruntule()
        {
            return oneriBilgisi;
        }

    }

    
}
