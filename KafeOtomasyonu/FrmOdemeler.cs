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
    public partial class FrmOdemeler : Form
    {
        OdemeBL bl =
            new OdemeBL();

        MusteriBL musteriBL =
            new MusteriBL();
        public FrmOdemeler()
        {
            InitializeComponent();
        }
        void Listele()
        {
            dgwOdemeler.DataSource =
                bl.TumOdemeler();
        }

        void MusterileriGetir()
        {
            cmbMusteri.DisplayMember =
                "Adı";

            cmbMusteri.ValueMember =
                 "ID";

            cmbMusteri.DataSource =
               musteriBL.ComboMusteriler();
        }

        void OdemeTurleri()
        {
            cmbTur.Items.Add("Nakit");

            cmbTur.Items.Add("Kart");

            cmbTur.Items.Add("QR");
        }
        private void FrmOdemeler_Load(object sender, EventArgs e)
        {
            Listele();

            MusterileriGetir();

            OdemeTurleri();
        }

        private void btnOdemeEkle_Click(object sender, EventArgs e)
        {
            float tutar;

            if (float.TryParse(
                txtTutar.Text,
                out tutar))
            {
                bl.OdemeEkle(

                    Convert.ToInt32(
                        cmbMusteri.SelectedValue),

                    dtTarih.Value,

                    tutar,

                    cmbTur.Text,

                    txtAciklama.Text
                );

                MessageBox.Show(
                    "Ödeme eklendi");

                Listele();

                txtTutar.Clear();

                txtAciklama.Clear();
            }
            else
            {
                MessageBox.Show(
                    "Geçerli tutar giriniz");
            }
        }

        private void btnBakiye_Click(object sender, EventArgs e)
        {
            float bakiye =
        bl.MusteriBakiye(

            Convert.ToInt32(
                cmbMusteri.SelectedValue)

        );

            lblBakiye.Text =
                "Bakiye: " +
                bakiye.ToString() +
                " ₺";
        }
    }
}
