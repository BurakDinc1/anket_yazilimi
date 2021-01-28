using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AileGelirNotu
{
    interface Inter
    {
        void DataSetOlustur();

        void KisiEkle();

        DataTable kisiListesi();
    }
}
