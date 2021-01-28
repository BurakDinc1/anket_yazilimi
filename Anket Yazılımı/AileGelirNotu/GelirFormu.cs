using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AileGelirNotu
{
    public partial class GelirFormu : Form
    {
        public GelirFormu()
        {
            InitializeComponent();
        }

        private void bttn_ekle_Click(object sender, EventArgs e)
        {
            string ögrenimtype = "";
            if (rdbttn_ilkokul.Checked)
                ögrenimtype = "İlkokul";
            else if (rdbttn_ortaokul.Checked)
                ögrenimtype = "Ortaokul";
            else if (rdbttn_lise.Checked)
                ögrenimtype = "Lise";
            else if (rdbttn_önlisans.Checked)
                ögrenimtype = "Önlisans";
            else if (rdbttn_lisans.Checked)
                ögrenimtype = "Lisans";
            else if (rdbttn_lisansüstü.Checked)
                ögrenimtype = "Lisansüstü";
            else if (rdbttn_ögörmemis.Checked)
                ögrenimtype = "Öğretim Görmemiş";

            if (txt_isim.Text == "")
            {
                MessageBox.Show("İsim kısmı boş bırakılamaz !!!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string isim = txt_isim.Text;
                if (txt_soyisim.Text == "")
                {
                    MessageBox.Show("Soyisim kısmı boş bırakılamaz !!!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    string soyisim = txt_soyisim.Text;
                    if(cmbbx_alankodu.SelectedItem==null || txt_telno.Text == "")
                    {
                        MessageBox.Show("Alan kodu veya telefon numarası boş bırakılamaz !!!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        int alankodu = Convert.ToInt32(cmbbx_alankodu.SelectedItem);
                        Int64 telno = Convert.ToInt64(txt_telno.Text);
                        string ikametgahadresi = txt_ikametgah.Text;
                        string reisinmesleği = txt_reismeslek.Text;
                        string reisögrenimdurumu = ögrenimtype;
                        if (cmbbx_gelir.SelectedItem == null)
                            MessageBox.Show("Lütfen Belirlenen Seçeneklerden Bir Gelir Seçiniz !!!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        else
                        {
                            string reisgeliri = Convert.ToString(cmbbx_gelir.SelectedItem);

                            AileReisi yenibirey = new AileReisi(isim, soyisim, alankodu, telno, ikametgahadresi, reisinmesleği, reisögrenimdurumu, reisgeliri);

                            yenibirey.KisiEkle();
                            grid_kisibilgileri.DataSource = yenibirey.kisiListesi();
                            int kayitsayisi = grid_kisibilgileri.RowCount-1;
                            label17.Text = kayitsayisi.ToString();

                            //lstb_kisibilgileri.Items.Add(yenibirey.kisiBilgileriDerle(gelirNotu(gelirDerecelendir(reisgeliri), ögrenimDerecelendir(reisögrenimdurumu))));

                        }
                    }                  
                }             
            }                        
        }

        private void bttn_temizle_Click(object sender, EventArgs e)
        {
            txt_isim.Clear();
            txt_soyisim.Clear();
            txt_telno.Clear();
            txt_ikametgah.Clear();
            txt_reismeslek.Clear();
            cmbbx_alankodu.ResetText();
            cmbbx_gelir.ResetText();
            if (rdbttn_ilkokul.Checked == false)
            {
                rdbttn_ilkokul.Checked = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bttn_kisilericek_Click(object sender, EventArgs e)
        {
            AileReisi datacıbirey = new AileReisi();
            grid_kisibilgileri.DataSource = datacıbirey.kisiListesi();
            int kayitsayisi = grid_kisibilgileri.RowCount-1;
            label17.Text = kayitsayisi.ToString();
        }

        private void bttn_ara_Click(object sender, EventArgs e)
        {
            AileReisi arayıcıbirey = new AileReisi();
            grid_kisibilgileri.DataSource = arayıcıbirey.kisiListesi();

            string aranan = txt_ara.Text.Trim().ToUpper();

            for (int i=0; i<grid_kisibilgileri.Rows.Count-1; i++)
            {
                foreach(DataGridViewRow row in grid_kisibilgileri.Rows)
                {
                    foreach(DataGridViewCell cell in grid_kisibilgileri.Rows[i].Cells)
                    {
                        if (cell.Value != null)
                        {
                            if (cell.Value.ToString().ToUpper() == aranan)
                            {
                                cell.Style.BackColor = Color.DarkTurquoise;
                                break;
                            }
                        }
                    }
                }
            }

        }
    }
}
