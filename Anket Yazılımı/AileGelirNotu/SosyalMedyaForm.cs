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
    public partial class SosyalMedyaForm : Form
    {
        public SosyalMedyaForm()
        {
            InitializeComponent();
        }

        private void SosyalMedyaForm_Load(object sender, EventArgs e)
        {

        }

        private void bttn_ekle1_Click(object sender, EventArgs e)
        {
            if (txt_isim1.Text == "")
            {
                MessageBox.Show("İsim kısmı boş bırakılamaz !!!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string isim1 = txt_isim1.Text;
                if (txt_soyisim1.Text == "")
                {
                    MessageBox.Show("Soyisim kısmı boş bırakılamaz !!!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    string soyisim1 = txt_soyisim1.Text;
                    if (cmbbx_alankodu1.SelectedItem == null || txt_telno1.Text == "")
                    {
                        MessageBox.Show("Alan kodu veya telefon numarası boş bırakılamaz !!!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        int alankodu1 = Convert.ToInt32(cmbbx_alankodu1.SelectedItem);
                        Int64 telno1 = Convert.ToInt64(txt_telno1.Text);
                        string ikametgahadresi1 = txt_ikametgah1.Text;
                        if (cmbbx_sosyalmedya.SelectedItem==null)
                        {
                            MessageBox.Show("Lütfen belirtilen sosyal medya platformlarından birini seçiniz !!!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            string sosyalmedya = Convert.ToString(cmbbx_sosyalmedya.SelectedItem);
                            if (cmbbx_gunluksaat.SelectedItem==null)
                            {
                                MessageBox.Show("Lütfen belirtilen kullanım saatlerinden birini seçiniz !!!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                Int32 gunlukkulanımsaati = Convert.ToInt32(cmbbx_gunluksaat.SelectedItem);
                                string tarayıcıtype = " ";

                                if (rdbbttn_chrome.Checked)
                                {
                                    tarayıcıtype = "Google Chrome";
                                }else if (rdbbttn_explorer.Checked)
                                {
                                    tarayıcıtype = "Internet Explorer";
                                }else if (rdbbttn_mozilla.Checked)
                                {
                                    tarayıcıtype = "Mozilla Firefox";
                                }else if (rdbbttn_yandex.Checked)
                                {
                                    tarayıcıtype = "Yandex";
                                }else if (rdbbttn_safari.Checked)
                                {
                                    tarayıcıtype = "Safari";
                                }else if (rdbbttn_opera.Checked)
                                {
                                    tarayıcıtype = "Opera";
                                }else if (rdbbttn_theworld.Checked)
                                {
                                    tarayıcıtype = "TheWorld";
                                }

                                string kullanılantarayıcı = tarayıcıtype;

                                if (cmbbx_reklamatlama.SelectedItem == null)
                                {
                                    MessageBox.Show("Lütfen 'Reklam Atlama' durumu belirtiniz !!!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                                else
                                {
                                    string reklamatlama = Convert.ToString(cmbbx_reklamatlama.SelectedItem);

                                    SosyalMedya yenibirey1 = new SosyalMedya(isim1,soyisim1,alankodu1,telno1,ikametgahadresi1,sosyalmedya,gunlukkulanımsaati,kullanılantarayıcı,reklamatlama);
                                    yenibirey1.KisiEkle();
                                    grid_kisibilgileri1.DataSource = yenibirey1.kisiListesi();
                                    int kayitsayisi1 = grid_kisibilgileri1.RowCount-1;
                                    label18.Text = kayitsayisi1.ToString();
                                }
                            }
                        }
                    }
                }
            }

           

        }

        private void bttn_temizle1_Click(object sender, EventArgs e)
        {
            txt_isim1.Clear();
            txt_soyisim1.Clear();
            txt_telno1.Clear();
            txt_ikametgah1.Clear();
            cmbbx_alankodu1.ResetText();
            cmbbx_sosyalmedya.ResetText();
            cmbbx_gunluksaat.ResetText();
            cmbbx_reklamatlama.ResetText();
            if (rdbbttn_chrome.Checked == false)
            {
                rdbbttn_chrome.Checked = true;
            }
        }

        private void bttn_kisilericek1_Click(object sender, EventArgs e)
        {
            SosyalMedya datacıbirey1 = new SosyalMedya();
            grid_kisibilgileri1.DataSource = datacıbirey1.kisiListesi();

            int kayitsayisi1 = grid_kisibilgileri1.RowCount-1;
            label18.Text = kayitsayisi1.ToString();
        }

        private void bttn_ara1_Click(object sender, EventArgs e)
        {
            SosyalMedya arayıcıbirey1 = new SosyalMedya();
            grid_kisibilgileri1.DataSource = arayıcıbirey1.kisiListesi();

            string aranan1 = txt_ara1.Text.Trim().ToUpper();

            for (int i = 0; i < grid_kisibilgileri1.Rows.Count - 1; i++)
            {
                foreach (DataGridViewRow row in grid_kisibilgileri1.Rows)
                {
                    foreach (DataGridViewCell cell in grid_kisibilgileri1.Rows[i].Cells)
                    {
                        if (cell.Value != null)
                        {
                            if (cell.Value.ToString().ToUpper() == aranan1)
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
