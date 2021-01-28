using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AileGelirNotu
{
    class AileReisi:Birey, Inter
    {
        private string reismeslek;
        private string ögrenimdurumu;
        private string reisgelir;

        public string Reismeslek
        {
            get
            {
                return reismeslek;
            }
            set
            {
                reismeslek = value;
            }
        }
        public string Ögrenimdurumu
        {
            get
            {
                return ögrenimdurumu;
            }
            set
            {
                ögrenimdurumu = value;
            }
        }
        public string Reisgelir
        {
            get
            {
                return reisgelir;
            }
            set
            {
                reisgelir = value;
            }
        }

        private string aileDosyasıAdı = "ailereisDosya.xml";

        DataSet dSet = new DataSet("AileDataSet");
        DataTable dTable = new DataTable("Aileler");

        public AileReisi()
        {

        }

        public AileReisi(string isim, string soyisim, int alankodu, Int64 telno, string ikametgah,string reismeslek, string ögrenimdurumu, string reisgelir)
        {
            DataSetOlustur();
            Reismeslek = reismeslek;
            Ögrenimdurumu = ögrenimdurumu;
            Reisgelir = reisgelir;
            base.İsim = isim;
            base.Soyisim = soyisim;
            base.Alankodu = alankodu;
            base.Telno = telno;
            base.İkametgah = ikametgah;
        }

        public override void DataSetOlustur()
        {
            if (System.IO.File.Exists(aileDosyasıAdı))
            {
                dSet.ReadXml(aileDosyasıAdı);
                dTable = dSet.Tables[0];
            }
            else
            {
                dTable.Columns.Add("Adı");
                dTable.Columns.Add("Soyadı");
                dTable.Columns.Add("Telefonu");
                dTable.Columns.Add("İl");
                dTable.Columns.Add("Meslek");
                dTable.Columns.Add("Öğrenimi");
                dTable.Columns.Add("Geliri");

                dSet.Tables.Add(dTable);
                dSet.WriteXml(aileDosyasıAdı);
            }
        }

        public override void KisiEkle()
        {
            DataRow satir = dTable.NewRow();
            satir["Adı"] = İsim;
            satir["Soyadı"] = Soyisim;
            satir["Telefonu"] = Alankodu + " " + Telno;
            satir["İl"] = İkametgah;
            satir["Meslek"] = Reismeslek;
            satir["Öğrenimi"] = Ögrenimdurumu;
            satir["Geliri"] = Reisgelir;
            dTable.Rows.Add(satir);

            dSet.WriteXml(aileDosyasıAdı);
        }

        public override DataTable kisiListesi()
        {
            DataSet data = new DataSet();
            data.ReadXml(aileDosyasıAdı);

            return data.Tables[0];
        }       
        
    }
}
