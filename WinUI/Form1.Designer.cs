namespace WinUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpPersonelKayit = new GroupBox();
            cmbBirim = new ComboBox();
            rdbKadin = new RadioButton();
            rdbErkek = new RadioButton();
            dtDogumTarihi = new DateTimePicker();
            txtTCNo = new TextBox();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnTemizle = new Button();
            btnKaydet = new Button();
            btniletisimBilgisi = new Button();
            grpPersonelKayit.SuspendLayout();
            SuspendLayout();
            // 
            // grpPersonelKayit
            // 
            grpPersonelKayit.Controls.Add(cmbBirim);
            grpPersonelKayit.Controls.Add(rdbKadin);
            grpPersonelKayit.Controls.Add(rdbErkek);
            grpPersonelKayit.Controls.Add(dtDogumTarihi);
            grpPersonelKayit.Controls.Add(txtTCNo);
            grpPersonelKayit.Controls.Add(txtSoyad);
            grpPersonelKayit.Controls.Add(txtAd);
            grpPersonelKayit.Controls.Add(label6);
            grpPersonelKayit.Controls.Add(label5);
            grpPersonelKayit.Controls.Add(label4);
            grpPersonelKayit.Controls.Add(label3);
            grpPersonelKayit.Controls.Add(label2);
            grpPersonelKayit.Controls.Add(label1);
            grpPersonelKayit.Location = new Point(57, 48);
            grpPersonelKayit.Name = "grpPersonelKayit";
            grpPersonelKayit.Size = new Size(394, 282);
            grpPersonelKayit.TabIndex = 0;
            grpPersonelKayit.TabStop = false;
            grpPersonelKayit.Text = "Personel Kayıt Ekranı";
            // 
            // cmbBirim
            // 
            cmbBirim.FormattingEnabled = true;
            cmbBirim.Items.AddRange(new object[] { "Yazılım", "Muhasebe", "ERP", "Yönetim", "İnsan Kaynakları", "IT", "Pazarlama", "Satis" });
            cmbBirim.Location = new Point(107, 234);
            cmbBirim.Name = "cmbBirim";
            cmbBirim.Size = new Size(121, 23);
            cmbBirim.TabIndex = 4;
            // 
            // rdbKadin
            // 
            rdbKadin.AutoSize = true;
            rdbKadin.Location = new Point(176, 196);
            rdbKadin.Name = "rdbKadin";
            rdbKadin.Size = new Size(55, 19);
            rdbKadin.TabIndex = 3;
            rdbKadin.TabStop = true;
            rdbKadin.Text = "Kadın";
            rdbKadin.UseVisualStyleBackColor = true;
            // 
            // rdbErkek
            // 
            rdbErkek.AutoSize = true;
            rdbErkek.Location = new Point(107, 196);
            rdbErkek.Name = "rdbErkek";
            rdbErkek.Size = new Size(53, 19);
            rdbErkek.TabIndex = 3;
            rdbErkek.TabStop = true;
            rdbErkek.Text = "Erkek";
            rdbErkek.UseVisualStyleBackColor = true;
            // 
            // dtDogumTarihi
            // 
            dtDogumTarihi.Location = new Point(107, 152);
            dtDogumTarihi.Name = "dtDogumTarihi";
            dtDogumTarihi.Size = new Size(124, 23);
            dtDogumTarihi.TabIndex = 2;
            // 
            // txtTCNo
            // 
            txtTCNo.Location = new Point(107, 112);
            txtTCNo.Name = "txtTCNo";
            txtTCNo.Size = new Size(124, 23);
            txtTCNo.TabIndex = 1;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(107, 76);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(124, 23);
            txtSoyad.TabIndex = 1;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(107, 38);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(124, 23);
            txtAd.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 237);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 0;
            label6.Text = "Birimler :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 196);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 0;
            label5.Text = "Cinsiyet :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 158);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 0;
            label4.Text = "Dogum Tarihi :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 115);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 0;
            label3.Text = "TC Kimlik No :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 79);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 0;
            label2.Text = "Soyadı :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 41);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 0;
            label1.Text = "Adı :";
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(64, 363);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(75, 23);
            btnTemizle.TabIndex = 1;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(185, 363);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(78, 23);
            btnKaydet.TabIndex = 1;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btniletisimBilgisi
            // 
            btniletisimBilgisi.Location = new Point(301, 363);
            btniletisimBilgisi.Name = "btniletisimBilgisi";
            btniletisimBilgisi.Size = new Size(150, 23);
            btniletisimBilgisi.TabIndex = 1;
            btniletisimBilgisi.Text = "İletişim Bilgilerini Gör";
            btniletisimBilgisi.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 450);
            Controls.Add(btniletisimBilgisi);
            Controls.Add(btnKaydet);
            Controls.Add(btnTemizle);
            Controls.Add(grpPersonelKayit);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            grpPersonelKayit.ResumeLayout(false);
            grpPersonelKayit.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpPersonelKayit;
        private TextBox txtTCNo;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cmbBirim;
        private RadioButton rdbKadin;
        private RadioButton rdbErkek;
        private DateTimePicker dtDogumTarihi;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnTemizle;
        private Button btnKaydet;
        private Button btniletisimBilgisi;
    }
}