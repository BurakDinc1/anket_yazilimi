using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AileGelirNotu
{
    class SosyalMedya:Birey, Inter
    {

        private string kullanılansosyalmdy;
        private Int32 kullanılansaat;
        private string kullanılantryc;
        private string reklamatlama;

        public string Kullanılansosyalmdy
        {
            get
            {
                return kullanılansosyalmdy;
            }
            set
            {
                kullanılansosyalmdy = value;
            }
        }
        public Int32 Kullanılansaat
        {
            get
            {
                return kullanılansaat;
            }
            set
            {
                kullanılansaat = value;
            }
        }
        public string Kullanılantryc
        {
            get
            {
                return kullanılantryc;
            }
            set
            {
                kullanılantryc = value;
            }
        }
        public string Reklamatlama
        {
            get
            {
                return reklamatlama;
            }
            set
            {
                reklamatlama = value;
            }
        }

        private string sosyalDosyasıAdı = "sosyalDosya.xml";

        DataSet dSet = new DataSet("SosyalDataSet");
        DataTable dTable = new DataTable("İnsanlar");

        public SosyalMedya()
        {

        }

        public SosyalMedya(string isim, string soyisim, int alankodu, Int64 telno, string ikametgah, string kullanılansosyalmdy, Int32 kullanılansaat, string kullanılantryc, string reklamatlama)
        {
            DataSetOlustur();
            Kullanılansosyalmdy = kullanılansosyalmdy;
            Kullanılansaat = kullanılansaat;
            Kullanılantryc = kullanılantryc;
            Reklamatlama = reklamatlama;
            base.İsim = isim;
            base.Soyisim = soyisim;
            base.Alankodu = alankodu;
            base.Telno = telno;
            base.İkametgah = ikametgah;
        }

        public override void DataSetOlustur()
        {
            if (System.IO.File.Exists(sosyalDosyasıAdı))
            {
                dSet.ReadXml(sosyalDosyasıAdı);
                dTable = dSet.Tables[0];
            }
            else
            {
                dTable.Columns.Add("Adı");
                dTable.Columns.Add("Soyadı");
                dTable.Columns.Add("Telefonu");
                dTable.Columns.Add("İl");
                dTable.Columns.Add("Sosyal Medya");
                dTable.Columns.Add("Kull. Saat");
                dTable.Columns.Add("Tarayıcı");
                dTable.Columns.Add("Reklam Atlama");

                dSet.Tables.Add(dTable);
                dSet.WriteXml(sosyalDosyasıAdı);
            }
        }

        public override void KisiEkle()
        {
            DataRow satir = dTable.NewRow();
            satir["Adı"] = İsim;
            satir["Soyadı"] = Soyisim;
            satir["Telefonu"] = Alankodu + " " + Telno;
            satir["İl"] = İkametgah;
            satir["Sosyal Medya"] = Kullanılansosyalmdy;
            satir["Kull. Saat"] = Kullanılansaat;
            satir["Tarayıcı"] = Kullanılantryc;
            satir["Reklam Atlama"] = Reklamatlama;
            dTable.Rows.Add(satir);

            dSet.WriteXml(sosyalDosyasıAdı);
        }

        public override DataTable kisiListesi()
        {
            DataSet data = new DataSet();
            data.ReadXml(sosyalDosyasıAdı);

            return data.Tables[0];
        }

    }
}
