using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Sinif
{
    public abstract class TemelCalisan
    {
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string Departman { get; set; }
        public int Maas { get; set; }
        public int IzinGunu { get; set; }
        public string Cinsiyet { get; set; }    
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public int IzinGunleri { get; set; }
        public List<string> x { get; set; }
        public static object Personel { get; set; }
       
        

        


    }
}
