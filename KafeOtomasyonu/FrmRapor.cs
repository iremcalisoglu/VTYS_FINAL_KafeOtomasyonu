using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kafe.BL1;

namespace KafeOtomasyonu
{
    public partial class FrmRapor : Form
    {
        RaporBL bl =
                   new RaporBL();
        public FrmRapor()
        {
            InitializeComponent();
        }

        private void FrmRapor_Load(object sender, EventArgs e)
        {
            lblSiparis.Text =
               "Toplam Sipariş: " +
                bl.ToplamSiparis() +
               " ₺";

            lblOdeme.Text =
                "Toplam Ödeme: " +
                bl.ToplamOdeme() +
                " ₺";

            lblMusteri.Text =
                "Toplam Müşteri: " +
                bl.ToplamMusteri();

            lblUrun.Text =
                "Toplam Ürün: " +
                bl.ToplamUrun();

            lblKDV.Text =
               "KDV'li Toplam: " +
               bl.KDVliSiparis() +
               " ₺";
        }

        private void lblKDV_Click(object sender, EventArgs e)
        {

        }
    }
}
