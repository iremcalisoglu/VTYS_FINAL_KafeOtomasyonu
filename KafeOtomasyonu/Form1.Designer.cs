namespace KafeOtomasyonu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUrunler = new System.Windows.Forms.Button();
            this.btnSiparis = new System.Windows.Forms.Button();
            this.btnStok = new System.Windows.Forms.Button();
            this.btnOdemeler = new System.Windows.Forms.Button();
            this.btnRapor = new System.Windows.Forms.Button();
            this.btnMusteri = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUrunler
            // 
            this.btnUrunler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnUrunler.Location = new System.Drawing.Point(310, 75);
            this.btnUrunler.Name = "btnUrunler";
            this.btnUrunler.Size = new System.Drawing.Size(180, 50);
            this.btnUrunler.TabIndex = 10;
            this.btnUrunler.Text = "🍔 Ürünler";
            this.btnUrunler.UseVisualStyleBackColor = true;
            this.btnUrunler.Click += new System.EventHandler(this.btnUrunler_Click);
            // 
            // btnSiparis
            // 
            this.btnSiparis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSiparis.Location = new System.Drawing.Point(557, 75);
            this.btnSiparis.Name = "btnSiparis";
            this.btnSiparis.Size = new System.Drawing.Size(180, 50);
            this.btnSiparis.TabIndex = 11;
            this.btnSiparis.Text = "🛒 Siparişler";
            this.btnSiparis.UseVisualStyleBackColor = true;
            this.btnSiparis.Click += new System.EventHandler(this.btnSiparis_Click);
            // 
            // btnStok
            // 
            this.btnStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnStok.Location = new System.Drawing.Point(310, 236);
            this.btnStok.Name = "btnStok";
            this.btnStok.Size = new System.Drawing.Size(180, 50);
            this.btnStok.TabIndex = 12;
            this.btnStok.Text = "📦 Stok";
            this.btnStok.UseVisualStyleBackColor = true;
            this.btnStok.Click += new System.EventHandler(this.btnStok_Click);
            // 
            // btnOdemeler
            // 
            this.btnOdemeler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnOdemeler.Location = new System.Drawing.Point(61, 236);
            this.btnOdemeler.Name = "btnOdemeler";
            this.btnOdemeler.Size = new System.Drawing.Size(180, 50);
            this.btnOdemeler.TabIndex = 13;
            this.btnOdemeler.Text = "💳 Ödemeler";
            this.btnOdemeler.UseVisualStyleBackColor = true;
            this.btnOdemeler.Click += new System.EventHandler(this.btnOdemeler_Click);
            // 
            // btnRapor
            // 
            this.btnRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnRapor.Location = new System.Drawing.Point(557, 236);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(180, 50);
            this.btnRapor.TabIndex = 14;
            this.btnRapor.Text = "📊 Raporlar";
            this.btnRapor.UseVisualStyleBackColor = true;
            this.btnRapor.Click += new System.EventHandler(this.btnRapor_Click);
            // 
            // btnMusteri
            // 
            this.btnMusteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnMusteri.Location = new System.Drawing.Point(61, 75);
            this.btnMusteri.Name = "btnMusteri";
            this.btnMusteri.Size = new System.Drawing.Size(180, 50);
            this.btnMusteri.TabIndex = 15;
            this.btnMusteri.Text = "👤 Müşteriler";
            this.btnMusteri.UseVisualStyleBackColor = true;
            this.btnMusteri.Click += new System.EventHandler(this.btnMusteri_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnCikis.Location = new System.Drawing.Point(310, 393);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(180, 50);
            this.btnCikis.TabIndex = 16;
            this.btnCikis.Text = "❌ Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(806, 539);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnMusteri);
            this.Controls.Add(this.btnRapor);
            this.Controls.Add(this.btnOdemeler);
            this.Controls.Add(this.btnStok);
            this.Controls.Add(this.btnSiparis);
            this.Controls.Add(this.btnUrunler);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "☕ Kafe Otomasyonu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnUrunler;
        private System.Windows.Forms.Button btnSiparis;
        private System.Windows.Forms.Button btnStok;
        private System.Windows.Forms.Button btnOdemeler;
        private System.Windows.Forms.Button btnRapor;
        private System.Windows.Forms.Button btnMusteri;
        private System.Windows.Forms.Button btnCikis;
    }
}

