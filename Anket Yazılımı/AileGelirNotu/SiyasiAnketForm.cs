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
    public partial class SiyasiAnketForm : Form
    {
        public SiyasiAnketForm()
        {
            InitializeComponent();
        }

        private void bttn_ekle2_Click(object sender, EventArgs e)
        {
            if (txt_isim2.Text == "")
            {
                MessageBox.Show("İsim kısmı boş bırakılamaz !!!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string isim2 = txt_isim2.Text;
                if (txt_soyisim2.Text == "")
                {
                    MessageBox.Show("Soyisim kısmı boş bırakılamaz !!!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    string soyisim2 = txt_soyisim2.Text;
                    if (cmbbx_alankodu2.SelectedItem == null || txt_telno2.Text == "")
                    {
                        MessageBox.Show("Alan kodu veya telefon numarası boş bırakılamaz !!!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        int alankodu2 = Convert.ToInt32(cmbbx_alankodu2.SelectedItem);
                        Int64 telno2 = Convert.ToInt64(txt_telno2.Text);
                        string ikametgahadresi2 = txt_ikametgah2.Text;
                        if (cmbbx_parti.SelectedItem == null)
                        {
                            MessageBox.Show("Parti seçim kısmı boş bırakılamaz !!!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            string parti = Convert.ToString(cmbbx_parti.SelectedItem);
                            if (cmbbx_baskan.SelectedItem == null)
                            {
                                MessageBox.Show("Başkan seçim kısmı boş bırakılamaz !!!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                string baskan = Convert.ToString(cmbbx_baskan.SelectedItem);
                                if (cmbbx_genelkurmay.SelectedItem == null)
                                {
                                    MessageBox.Show("Genelkurmay Başkan seçimi boş bırakılamaz !!!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                                else
                                {
                                    string genelkurmay = Convert.ToString(cmbbx_genelkurmay.SelectedItem);
                                    string taraftype = "";
                                    if (rdbttn_rusya.Checked)
                                    {
                                        taraftype = "Rusya";
                                    }else if(rdbttn_amerika.Checked){
                                        taraftype = "Amerika";
                                    }else if(rdbttn_tarafsız.Checked){
                                        taraftype = "Tarafsızlık";
                                    }

                                    string kullanılantaraf = taraftype;

                                    Siyasi yenibirey2 = new Siyasi(isim2,soyisim2,alankodu2,telno2,ikametgahadresi2,parti,baskan,genelkurmay,kullanılantaraf);
                                    yenibirey2.KisiEkle();
                                    grid_kisibilgileri2.DataSource = yenibirey2.kisiListesi();
                                    int kayitsayisi2 = grid_kisibilgileri2.RowCount-1;
                                    label1812.Text = kayitsayisi2.ToString();

                                }
                            }
                        }
                    }
                }
            }
        }

        private void bttn_temizle2_Click(object sender, EventArgs e)
        {
            txt_isim2.Clear();
            txt_soyisim2.Clear();
            txt_telno2.Clear();
            txt_ikametgah2.Clear();
            cmbbx_alankodu2.ResetText();
            cmbbx_parti.ResetText();
            cmbbx_baskan.ResetText();
            cmbbx_genelkurmay.ResetText();
            if (rdbttn_rusya.Checked == false)
            {
                rdbttn_rusya.Checked = true;
            }
        }

        private void bttn_kisilericek2_Click(object sender, EventArgs e)
        {
            Siyasi datacıbirey2 = new Siyasi();
            grid_kisibilgileri2.DataSource = datacıbirey2.kisiListesi();
            int kayitsayisi2 = grid_kisibilgileri2.RowCount-1;
            label1812.Text = kayitsayisi2.ToString();
        }

        private void bttn_ara2_Click(object sender, EventArgs e)
        {
            Siyasi arayıcıbirey2 = new Siyasi();
            grid_kisibilgileri2.DataSource = arayıcıbirey2.kisiListesi();

            string aranan2 = txt_ara2.Text.Trim().ToUpper();

            for (int i = 0; i < grid_kisibilgileri2.Rows.Count - 1; i++)
            {
                foreach (DataGridViewRow row in grid_kisibilgileri2.Rows)
                {
                    foreach (DataGridViewCell cell in grid_kisibilgileri2.Rows[i].Cells)
                    {
                        if (cell.Value != null)
                        {
                            if (cell.Value.ToString().ToUpper() == aranan2)
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
