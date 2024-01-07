using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Sinif
{
    public class Yoneticiislemleri : TemelCalisan
    {
        private List<TemelCalisan> calisanlar;
        public Yoneticiislemleri()
        {
            calisanlar = new List<TemelCalisan>();
        }

        //yonlist in olusturulmasi
        public static List<Yoneticiislemleri> Yon_list = new List<Yoneticiislemleri>();

        //yoneticiislemleri sinifi calisanekle fonksiyonu kod blogu
        public void CalisanEkle(string isim, string soyisim, string departman , int maas, int izingunu, string kullaniciadi)
        {
            
            {
                Isim = isim;
                Soyisim = soyisim;
                Departman = departman;
                Maas = maas;
                IzinGunu = izingunu;
                KullaniciAdi = kullaniciadi;
            };

        }
        
        //yoneticiislemleri sinifi calisancikar fonksiyonu kod blogu
        public void CalisanCikar(string isim)
        {
            TemelCalisan personel = calisanlar.Find(c => c.Isim == isim);
            if (personel != null)
            {
                calisanlar.Remove(personel);
            }
        }

        //yoneticiislemleri sinifi calisangoruntule fonksiyonu kod blogu
        public void CalisanlariGoruntule(List<TemelCalisan> calisan1)
        {
            foreach (var calisan in calisanlar)
            {
          
            }
        }

        //yoneticiislemleri sinifi maasduzenle fonksiyonu kod blogu
        public void MaasDuzenle(string isim, int yeniMaas)
        {
            TemelCalisan personel = calisanlar.Find(c => c.Isim == isim);
            if (personel != null)
            {
                personel.Maas = yeniMaas;
            }
        }

        //yoneticiislemleri sinifi departmandegistir fonksiyonu kod blogu
        public void DepartmanDegistir(string isim, string yeniDepartman)
        {
            TemelCalisan personel = calisanlar.Find(c => c.Isim == isim);
            if (personel != null)
            {
                personel.Departman = yeniDepartman;
            }
        }

        
    }
}
