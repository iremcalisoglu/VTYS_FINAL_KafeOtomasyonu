using Kafe.BL1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KafeOtomasyonu
{
    public partial class FrmMusteriler : Form
    {

        MusteriBL bl =
           new MusteriBL();
        public FrmMusteriler()
        {
            InitializeComponent();
        }


        void Listele()
        {
            DataTable dt =
                bl.TumMusteriler();

            dgwMusteriler.DataSource = null;

            dgwMusteriler.Rows.Clear();

            dgwMusteriler.DataSource = dt;


        }

        private void btnEkle_Click(
            object sender,
            EventArgs e)
        {
            bl.MusteriEkle(
                txtAd.Text,
                txtSoyad.Text,
                txtTel.Text
            );

            MessageBox.Show(
                "Müşteri eklendi");
        }

        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            bl.MusteriEkle(

              txtAd.Text,
              txtSoyad.Text,
              txtTel.Text
            );

            dgwMusteriler.DataSource =
                bl.TumMusteriler();

            MessageBox.Show(
                "Müşteri eklendi");
        }
        private void dgwMusteriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text =
                dgwMusteriler.CurrentRow.Cells[0].Value.ToString();

            txtAd.Text =
                dgwMusteriler.CurrentRow.Cells[1].Value.ToString();

            txtSoyad.Text =
                dgwMusteriler.CurrentRow.Cells[2].Value.ToString();

            txtTel.Text =
                dgwMusteriler.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            bl.MusteriGuncelle(
            Convert.ToInt32(txtID.Text),
            txtAd.Text,
            txtSoyad.Text,
            txtTel.Text
            );

            MessageBox.Show(
                "Müşteri güncellendi");

            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            bl.MusteriSil(
           Convert.ToInt32(txtID.Text));

            MessageBox.Show(
                "Müşteri silindi");

            Listele();
        }
        void Ara()
        {
            dgwMusteriler.DataSource =
                bl.MusteriBul(txtAra.Text);
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            Ara();
        }
        

        private void FrmMusteriler_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            dgwMusteriler.DataSource =
        bl.MusteriBul(
            txtAra.Text);
        }
    }
}
