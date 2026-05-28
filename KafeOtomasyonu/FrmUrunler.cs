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
    public partial class FrmUrunler : Form
    {
        UrunBL bl =
               new UrunBL();
        public FrmUrunler()
        {
            InitializeComponent();
        }
        void Listele()
        {
            dgwUrunler.DataSource =
                bl.TumUrunler();
        }
        private void FrmUrunler_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            float fiyat;

            if (float.TryParse(
                txtFiyat.Text,
                out fiyat))
            {
                bl.UrunEkle(
                    txtUrunAdi.Text,
                    txtKategori.Text,
                    fiyat
                );

                MessageBox.Show(
                    "Ürün eklendi");

                Listele();

                txtUrunAdi.Clear();

                txtFiyat.Clear();

                txtKategori.Clear();
            }
            else
            {
                MessageBox.Show(
                    "Fiyatı doğru giriniz");
            }
        }

        private void dgwUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text =
                dgwUrunler.CurrentRow.Cells[0].Value.ToString();

            txtUrunAdi.Text =
                dgwUrunler.CurrentRow.Cells[1].Value.ToString();

            txtKategori.Text =
                dgwUrunler.CurrentRow.Cells[2].Value.ToString();

            txtFiyat.Text =
                dgwUrunler.CurrentRow.Cells[3].Value.ToString();

            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            float fiyat;

            if (float.TryParse(
                txtFiyat.Text,
                out fiyat))
            {
                bl.UrunGuncelle(
                    Convert.ToInt32(txtID.Text),
                    txtUrunAdi.Text,
                    txtKategori.Text,
                    fiyat
                );

                MessageBox.Show(
                    "Ürün güncellendi");

                Listele();
            }
            else
            {
                MessageBox.Show(
                    "Fiyatı doğru giriniz");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            bl.UrunSil(
            Convert.ToInt32(txtID.Text));

            MessageBox.Show(
                "Ürün silindi");

            Listele();
        }
        void Ara()
        {
            dgwUrunler.DataSource =
                bl.UrunBul(txtAra.Text);
        }
        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            Ara();
        }
    }
}
