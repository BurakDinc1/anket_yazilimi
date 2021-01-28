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
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void bttn_geliranketi_Click(object sender, EventArgs e)
        {
            GelirFormu geliranketi = new GelirFormu();
            geliranketi.ShowDialog();
        }

        private void bttn_sosyalmedyanketi_Click(object sender, EventArgs e)
        {
            SosyalMedyaForm sosyalanket = new SosyalMedyaForm();
            sosyalanket.ShowDialog();
        }

        private void bttn_siyasianket_Click(object sender, EventArgs e)
        {
            SiyasiAnketForm siyasianketi = new SiyasiAnketForm();
            siyasianketi.ShowDialog();
        }
    }
    
}
