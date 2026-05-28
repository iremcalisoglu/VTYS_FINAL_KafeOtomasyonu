using System;
using Kafe.BL1;
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
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
        }

       
      
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void btnUrunler_Click(object sender, EventArgs e)
        {
            FrmUrunler frm = new FrmUrunler();


            frm.Show();
        }

        private void btnSiparis_Click(object sender, EventArgs e)
        {
            FrmSiparisler frm = new FrmSiparisler();


            frm.Show();
        }

        private void btnStok_Click(object sender, EventArgs e)
        {
            FrmStok frm = new FrmStok();


            frm.Show();
        }

        private void btnOdemeler_Click(object sender, EventArgs e)
        {
            FrmOdemeler frm = new FrmOdemeler();


            frm.Show();
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            FrmRapor frm =
       new FrmRapor();

            frm.Show();
        }

        private void Form1_Load(
                   object sender,
                   EventArgs e)
        {
           
        }
        private void btnMusteri_Click(object sender, EventArgs e)
        {
            FrmMusteriler frm =
        new FrmMusteriler();

            frm.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
