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
using System.Data;

namespace KafeOtomasyonu
{
    public partial class FrmStok : Form
    {
        StokBL bl =
    new StokBL();

        UrunBL urunBL =
            new UrunBL();
        public FrmStok()
        {
            InitializeComponent();
        }
        void Listele()
        {
            dgwStok.DataSource =
                bl.TumStok();
        }

        void UrunleriGetir()
        {
            cmbUrun.DataSource =
                urunBL.ComboUrunler();

            cmbUrun.DisplayMember =
                "urun_adı";

            cmbUrun.ValueMember =
                "urun_id";
        }

        private void FrmStok_Load(object sender, EventArgs e)
        {
            Listele();

            UrunleriGetir();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int stok;

            if (int.TryParse(
                txtStok.Text,
                out stok))
            {
                bl.StokGuncelle(

                    Convert.ToInt32(
                        cmbUrun.SelectedValue),

                    stok
                );

                MessageBox.Show(
                    "Stok güncellendi");

                Listele();
            }
            else
            {
                MessageBox.Show(
                    "Geçerli stok giriniz");
            }
        }
    }
}
