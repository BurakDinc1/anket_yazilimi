using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AileGelirNotu
{
    abstract class Birey
    {
        private string isim;
        private string soyisim;
        private Int64 telno;
        private int alankodu;
        private string ikametgah;

        public string İsim
        {
            get
            {
                return isim;
            }
            set
            {
                isim = value;
            }
        }

        public string Soyisim
        {
            get
            {
                return soyisim;
            }
            set
            {
                soyisim = value;
            }
        }

        public Int64 Telno
        {
            get
            {
                return telno;
            }
            set
            {
                telno = value;
            }
        }

        public int Alankodu
        {
            get
            {
                return alankodu;
            }
            set
            {
                alankodu = value;
            }
        }

        public string İkametgah
        {
            get
            {
                return ikametgah;
            }
            set
            {
                ikametgah = value;
            }
        }

        public abstract void DataSetOlustur();

        public abstract void KisiEkle();

        public abstract DataTable kisiListesi();

    }
}
