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
    public partial class FrmSiparisler : Form
    {
        SiparisBL bl =
    new SiparisBL();

        MusteriBL musteriBL =
            new MusteriBL();

        UrunBL urunBL =
            new UrunBL();
        public FrmSiparisler()
        {
            InitializeComponent();
        }

        void MusterileriGetir()
        {
            cmbMusteri.DataSource =
                musteriBL.ComboMusteriler();

            cmbMusteri.DisplayMember =
                "Adı";

            cmbMusteri.ValueMember =
                "ID";
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

        void Listele()
        {
            dgwSiparisler.DataSource =
                bl.TumSiparisler();
        }

        private void FrmSiparisler_Load(object sender, EventArgs e)
        {
            Listele();

            MusterileriGetir();

            UrunleriGetir();

        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            float toplam;

            if (float.TryParse( txtToplam.Text, out toplam))
            {
                bl.SiparisEkle(

                    Convert.ToInt32(
                        cmbMusteri.SelectedValue),

                    Convert.ToInt32(
                        cmbUrun.SelectedValue),

                    dtTarih.Value,

                    toplam
                );
                int siparisID = bl.SonSiparisID();


                bl.SiparisDetayEkle(

                    siparisID,

                    Convert.ToInt32(
                        cmbUrun.SelectedValue)

                );

                MessageBox.Show(
                    "Sipariş eklendi");

                Listele();
            }
            else
            {
                MessageBox.Show(
                    "Toplam tutarı doğru giriniz");
            }
        }
    }
}
