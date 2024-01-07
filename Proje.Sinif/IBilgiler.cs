using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Sinif
{
    public interface IBilgiler
    {
        string isim { get; set; }
        string soyisim { get; set; }
        string department { get; set; }

        void Goster();



    }


}

