using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AileGelirNotu
{
    class Siyasi:Birey, Inter
    {
        private string baskan;
        private string parti;
        private string genelkurmay;
        private string taraf;

        public string Baskan
        {
            get
            {
                return baskan;
            }
            set
            {
                baskan = value;
            }
        }
        public string Parti
        {
            get
            {
                return parti;
            }
            set
            {
                parti = value;
            }
        }
        public string Taraf
        {
            get
            {
                return taraf;
            }
            set
            {
                taraf = value;
            }
        }
        public string Genelkurmay
        {
            get
            {
                return genelkurmay;
            }
            set
            {
                genelkurmay = value;
            }
        }

        private string siyasiDosyasıAdı = "siyasiDosya.xml";

        DataSet dSet = new DataSet("SiyasiDataSet");
        DataTable dTable = new DataTable("Siyasiler");

        public Siyasi()
        {

        }

        public Siyasi(string isim, string soyisim, int alankodu, Int64 telno, string ikametgah,string parti, string baskan, string genelkurmay, string taraf)
        {
            DataSetOlustur();
            base.İsim = isim;
            base.Soyisim = soyisim;
            base.Alankodu = alankodu;
            base.Telno = telno;
            base.İkametgah = ikametgah;
            Parti = parti;
            Baskan = baskan;
            Genelkurmay = genelkurmay;
            Taraf = taraf;
        }

        public override void DataSetOlustur()
        {
            if (System.IO.File.Exists(siyasiDosyasıAdı))
            {
                dSet.ReadXml(siyasiDosyasıAdı);
                dTable = dSet.Tables[0];
            }
            else
            {
                dTable.Columns.Add("Adı");
                dTable.Columns.Add("Soyadı");
                dTable.Columns.Add("Telefonu");
                dTable.Columns.Add("İl");
                dTable.Columns.Add("Parti");
                dTable.Columns.Add("Baskan");
                dTable.Columns.Add("Genelkurmay Baskanı");
                dTable.Columns.Add("Savaş Tarafı");

                dSet.Tables.Add(dTable);
                dSet.WriteXml(siyasiDosyasıAdı);
            }
        }

        public override void KisiEkle()
        {
            DataRow satir = dTable.NewRow();
            satir["Adı"] = İsim;
            satir["Soyadı"] = Soyisim;
            satir["Telefonu"] = Alankodu + " " + Telno;
            satir["İl"] = İkametgah;
            satir["Parti"] = Parti;
            satir["Baskan"] = Baskan;
            satir["Genelkurmay Baskanı"] = Genelkurmay;
            satir["Savaş Tarafı"]= Taraf;
            dTable.Rows.Add(satir);

            dSet.WriteXml(siyasiDosyasıAdı);
        }

        public override DataTable kisiListesi()
        {
            DataSet data = new DataSet();
            data.ReadXml(siyasiDosyasıAdı);

            return data.Tables[0];
        }

    }
}
