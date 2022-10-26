
namespace Entity_IlkOrnek
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnOgrenciListele = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDersListele = new System.Windows.Forms.Button();
            this.btnBul = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.gbOgrenci = new System.Windows.Forms.GroupBox();
            this.txtOgrFoto = new System.Windows.Forms.TextBox();
            this.txtOgrSoyad = new System.Windows.Forms.TextBox();
            this.txtOgrAd = new System.Windows.Forms.TextBox();
            this.txtOgrID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbNotlar = new System.Windows.Forms.GroupBox();
            this.btnJoinGetirme = new System.Windows.Forms.Button();
            this.btnNotHesapla = new System.Windows.Forms.Button();
            this.txtOrtalama = new System.Windows.Forms.TextBox();
            this.txtSinav3 = new System.Windows.Forms.TextBox();
            this.txtSinav2 = new System.Windows.Forms.TextBox();
            this.txtSinav1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gbDersler = new System.Windows.Forms.GroupBox();
            this.txtDersAd = new System.Windows.Forms.TextBox();
            this.txtDersId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnNotListele = new System.Windows.Forms.Button();
            this.btnDersKaydet = new System.Windows.Forms.Button();
            this.btnProsedur = new System.Windows.Forms.Button();
            this.rbIsimSiralama = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.rbIsimSıralamaZ = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbSinav3Ortalamasi = new System.Windows.Forms.RadioButton();
            this.rbSinav3Toplami = new System.Windows.Forms.RadioButton();
            this.rbSinav2Ortalamasi = new System.Windows.Forms.RadioButton();
            this.rbSinav2Toplami = new System.Windows.Forms.RadioButton();
            this.rbSinav1Ort = new System.Windows.Forms.RadioButton();
            this.rbSinav1 = new System.Windows.Forms.RadioButton();
            this.rbToplamOgrenciSayisi = new System.Windows.Forms.RadioButton();
            this.rbA_ile_bitenler = new System.Windows.Forms.RadioButton();
            this.rbA_ile_baslayanlar = new System.Windows.Forms.RadioButton();
            this.rbIDSiralama = new System.Windows.Forms.RadioButton();
            this.rbIlkUcSiralama = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbOgrenci.SuspendLayout();
            this.gbNotlar.SuspendLayout();
            this.gbDersler.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(718, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnOgrenciListele
            // 
            this.btnOgrenciListele.Location = new System.Drawing.Point(12, 168);
            this.btnOgrenciListele.Name = "btnOgrenciListele";
            this.btnOgrenciListele.Size = new System.Drawing.Size(128, 35);
            this.btnOgrenciListele.TabIndex = 1;
            this.btnOgrenciListele.Text = "Öğrenci Listele";
            this.btnOgrenciListele.UseVisualStyleBackColor = true;
            this.btnOgrenciListele.Click += new System.EventHandler(this.btnOgrenciListele_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(12, 208);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(128, 35);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Öğrenci Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(12, 330);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(128, 35);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDersListele
            // 
            this.btnDersListele.Location = new System.Drawing.Point(12, 289);
            this.btnDersListele.Name = "btnDersListele";
            this.btnDersListele.Size = new System.Drawing.Size(128, 35);
            this.btnDersListele.TabIndex = 6;
            this.btnDersListele.Text = "Ders Listele";
            this.btnDersListele.UseVisualStyleBackColor = true;
            this.btnDersListele.Click += new System.EventHandler(this.btnDersListele_Click);
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(12, 412);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(128, 35);
            this.btnBul.TabIndex = 5;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(12, 371);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(128, 35);
            this.btnGuncelle.TabIndex = 4;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // gbOgrenci
            // 
            this.gbOgrenci.Controls.Add(this.txtOgrFoto);
            this.gbOgrenci.Controls.Add(this.txtOgrSoyad);
            this.gbOgrenci.Controls.Add(this.txtOgrAd);
            this.gbOgrenci.Controls.Add(this.txtOgrID);
            this.gbOgrenci.Controls.Add(this.label4);
            this.gbOgrenci.Controls.Add(this.label3);
            this.gbOgrenci.Controls.Add(this.label2);
            this.gbOgrenci.Controls.Add(this.label1);
            this.gbOgrenci.Location = new System.Drawing.Point(146, 168);
            this.gbOgrenci.Name = "gbOgrenci";
            this.gbOgrenci.Size = new System.Drawing.Size(250, 175);
            this.gbOgrenci.TabIndex = 7;
            this.gbOgrenci.TabStop = false;
            this.gbOgrenci.Text = "Öğrenci";
            // 
            // txtOgrFoto
            // 
            this.txtOgrFoto.Location = new System.Drawing.Point(86, 139);
            this.txtOgrFoto.Name = "txtOgrFoto";
            this.txtOgrFoto.Size = new System.Drawing.Size(136, 20);
            this.txtOgrFoto.TabIndex = 7;
            // 
            // txtOgrSoyad
            // 
            this.txtOgrSoyad.Location = new System.Drawing.Point(86, 101);
            this.txtOgrSoyad.Name = "txtOgrSoyad";
            this.txtOgrSoyad.Size = new System.Drawing.Size(136, 20);
            this.txtOgrSoyad.TabIndex = 6;
            // 
            // txtOgrAd
            // 
            this.txtOgrAd.Location = new System.Drawing.Point(86, 65);
            this.txtOgrAd.Name = "txtOgrAd";
            this.txtOgrAd.Size = new System.Drawing.Size(136, 20);
            this.txtOgrAd.TabIndex = 5;
            this.txtOgrAd.TextChanged += new System.EventHandler(this.txtOgrAd_TextChanged);
            // 
            // txtOgrID
            // 
            this.txtOgrID.Location = new System.Drawing.Point(86, 29);
            this.txtOgrID.Name = "txtOgrID";
            this.txtOgrID.Size = new System.Drawing.Size(136, 20);
            this.txtOgrID.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "FOTOĞRAF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "SOYAD: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "AD:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID: ";
            // 
            // gbNotlar
            // 
            this.gbNotlar.Controls.Add(this.btnJoinGetirme);
            this.gbNotlar.Controls.Add(this.btnNotHesapla);
            this.gbNotlar.Controls.Add(this.txtOrtalama);
            this.gbNotlar.Controls.Add(this.txtSinav3);
            this.gbNotlar.Controls.Add(this.txtSinav2);
            this.gbNotlar.Controls.Add(this.txtSinav1);
            this.gbNotlar.Controls.Add(this.label7);
            this.gbNotlar.Controls.Add(this.label8);
            this.gbNotlar.Controls.Add(this.label9);
            this.gbNotlar.Controls.Add(this.label10);
            this.gbNotlar.Location = new System.Drawing.Point(402, 168);
            this.gbNotlar.Name = "gbNotlar";
            this.gbNotlar.Size = new System.Drawing.Size(328, 319);
            this.gbNotlar.TabIndex = 8;
            this.gbNotlar.TabStop = false;
            this.gbNotlar.Text = "Notlar";
            // 
            // btnJoinGetirme
            // 
            this.btnJoinGetirme.Location = new System.Drawing.Point(78, 215);
            this.btnJoinGetirme.Name = "btnJoinGetirme";
            this.btnJoinGetirme.Size = new System.Drawing.Size(128, 35);
            this.btnJoinGetirme.TabIndex = 17;
            this.btnJoinGetirme.Text = "Join ile Getir";
            this.btnJoinGetirme.UseVisualStyleBackColor = true;
            this.btnJoinGetirme.Click += new System.EventHandler(this.btnJoinGetirme_Click);
            // 
            // btnNotHesapla
            // 
            this.btnNotHesapla.Location = new System.Drawing.Point(78, 168);
            this.btnNotHesapla.Name = "btnNotHesapla";
            this.btnNotHesapla.Size = new System.Drawing.Size(128, 35);
            this.btnNotHesapla.TabIndex = 16;
            this.btnNotHesapla.Text = "Hesapla";
            this.btnNotHesapla.UseVisualStyleBackColor = true;
            // 
            // txtOrtalama
            // 
            this.txtOrtalama.Location = new System.Drawing.Point(108, 135);
            this.txtOrtalama.Name = "txtOrtalama";
            this.txtOrtalama.Size = new System.Drawing.Size(136, 20);
            this.txtOrtalama.TabIndex = 15;
            // 
            // txtSinav3
            // 
            this.txtSinav3.Location = new System.Drawing.Point(108, 101);
            this.txtSinav3.Name = "txtSinav3";
            this.txtSinav3.Size = new System.Drawing.Size(136, 20);
            this.txtSinav3.TabIndex = 14;
            // 
            // txtSinav2
            // 
            this.txtSinav2.Location = new System.Drawing.Point(108, 65);
            this.txtSinav2.Name = "txtSinav2";
            this.txtSinav2.Size = new System.Drawing.Size(136, 20);
            this.txtSinav2.TabIndex = 13;
            // 
            // txtSinav1
            // 
            this.txtSinav1.Location = new System.Drawing.Point(108, 29);
            this.txtSinav1.Name = "txtSinav1";
            this.txtSinav1.Size = new System.Drawing.Size(136, 20);
            this.txtSinav1.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "ORTALAMA: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "SINAV 3:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(52, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "SINAV 2:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(52, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "SINAV 1: ";
            // 
            // gbDersler
            // 
            this.gbDersler.Controls.Add(this.txtDersAd);
            this.gbDersler.Controls.Add(this.txtDersId);
            this.gbDersler.Controls.Add(this.label5);
            this.gbDersler.Controls.Add(this.label6);
            this.gbDersler.Location = new System.Drawing.Point(146, 355);
            this.gbDersler.Name = "gbDersler";
            this.gbDersler.Size = new System.Drawing.Size(250, 132);
            this.gbDersler.TabIndex = 9;
            this.gbDersler.TabStop = false;
            this.gbDersler.Text = "Dersler";
            // 
            // txtDersAd
            // 
            this.txtDersAd.Location = new System.Drawing.Point(47, 68);
            this.txtDersAd.Name = "txtDersAd";
            this.txtDersAd.Size = new System.Drawing.Size(175, 20);
            this.txtDersAd.TabIndex = 9;
            // 
            // txtDersId
            // 
            this.txtDersId.Location = new System.Drawing.Point(47, 32);
            this.txtDersId.Name = "txtDersId";
            this.txtDersId.Size = new System.Drawing.Size(175, 20);
            this.txtDersId.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "AD:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "ID: ";
            // 
            // btnNotListele
            // 
            this.btnNotListele.Location = new System.Drawing.Point(12, 452);
            this.btnNotListele.Name = "btnNotListele";
            this.btnNotListele.Size = new System.Drawing.Size(128, 35);
            this.btnNotListele.TabIndex = 10;
            this.btnNotListele.Text = "Not Listele";
            this.btnNotListele.UseVisualStyleBackColor = true;
            this.btnNotListele.Click += new System.EventHandler(this.btnNotListele_Click);
            // 
            // btnDersKaydet
            // 
            this.btnDersKaydet.Location = new System.Drawing.Point(12, 249);
            this.btnDersKaydet.Name = "btnDersKaydet";
            this.btnDersKaydet.Size = new System.Drawing.Size(128, 35);
            this.btnDersKaydet.TabIndex = 11;
            this.btnDersKaydet.Text = "Ders Kaydet";
            this.btnDersKaydet.UseVisualStyleBackColor = true;
            this.btnDersKaydet.Click += new System.EventHandler(this.btnDersKaydet_Click);
            // 
            // btnProsedur
            // 
            this.btnProsedur.Location = new System.Drawing.Point(12, 493);
            this.btnProsedur.Name = "btnProsedur";
            this.btnProsedur.Size = new System.Drawing.Size(128, 35);
            this.btnProsedur.TabIndex = 12;
            this.btnProsedur.Text = "Prosedür";
            this.btnProsedur.UseVisualStyleBackColor = true;
            this.btnProsedur.Click += new System.EventHandler(this.btnProsedur_Click);
            // 
            // rbIsimSiralama
            // 
            this.rbIsimSiralama.AutoSize = true;
            this.rbIsimSiralama.Location = new System.Drawing.Point(39, 22);
            this.rbIsimSiralama.Name = "rbIsimSiralama";
            this.rbIsimSiralama.Size = new System.Drawing.Size(139, 17);
            this.rbIsimSiralama.TabIndex = 13;
            this.rbIsimSiralama.TabStop = true;
            this.rbIsimSiralama.Text = "A\'dan Z\'ye İsim Sıralama";
            this.rbIsimSiralama.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 29);
            this.button1.TabIndex = 14;
            this.button1.Text = "LINQ Entity";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbIsimSıralamaZ
            // 
            this.rbIsimSıralamaZ.AutoSize = true;
            this.rbIsimSıralamaZ.Location = new System.Drawing.Point(39, 45);
            this.rbIsimSıralamaZ.Name = "rbIsimSıralamaZ";
            this.rbIsimSıralamaZ.Size = new System.Drawing.Size(139, 17);
            this.rbIsimSıralamaZ.TabIndex = 15;
            this.rbIsimSıralamaZ.TabStop = true;
            this.rbIsimSıralamaZ.Text = "Z\'den A\'ya İsim Sıralama";
            this.rbIsimSıralamaZ.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSinav3Ortalamasi);
            this.groupBox1.Controls.Add(this.rbSinav3Toplami);
            this.groupBox1.Controls.Add(this.rbSinav2Ortalamasi);
            this.groupBox1.Controls.Add(this.rbSinav2Toplami);
            this.groupBox1.Controls.Add(this.rbSinav1Ort);
            this.groupBox1.Controls.Add(this.rbSinav1);
            this.groupBox1.Controls.Add(this.rbToplamOgrenciSayisi);
            this.groupBox1.Controls.Add(this.rbA_ile_bitenler);
            this.groupBox1.Controls.Add(this.rbA_ile_baslayanlar);
            this.groupBox1.Controls.Add(this.rbIDSiralama);
            this.groupBox1.Controls.Add(this.rbIlkUcSiralama);
            this.groupBox1.Controls.Add(this.rbIsimSıralamaZ);
            this.groupBox1.Controls.Add(this.rbIsimSiralama);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(736, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 475);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İsim Sıralama";
            // 
            // rbSinav3Ortalamasi
            // 
            this.rbSinav3Ortalamasi.AutoSize = true;
            this.rbSinav3Ortalamasi.Location = new System.Drawing.Point(39, 295);
            this.rbSinav3Ortalamasi.Name = "rbSinav3Ortalamasi";
            this.rbSinav3Ortalamasi.Size = new System.Drawing.Size(110, 17);
            this.rbSinav3Ortalamasi.TabIndex = 26;
            this.rbSinav3Ortalamasi.TabStop = true;
            this.rbSinav3Ortalamasi.Text = "Sınav3 Ortalaması";
            this.rbSinav3Ortalamasi.UseVisualStyleBackColor = true;
            // 
            // rbSinav3Toplami
            // 
            this.rbSinav3Toplami.AutoSize = true;
            this.rbSinav3Toplami.Location = new System.Drawing.Point(39, 272);
            this.rbSinav3Toplami.Name = "rbSinav3Toplami";
            this.rbSinav3Toplami.Size = new System.Drawing.Size(98, 17);
            this.rbSinav3Toplami.TabIndex = 25;
            this.rbSinav3Toplami.TabStop = true;
            this.rbSinav3Toplami.Text = "Sınav3 Toplamı";
            this.rbSinav3Toplami.UseVisualStyleBackColor = true;
            // 
            // rbSinav2Ortalamasi
            // 
            this.rbSinav2Ortalamasi.AutoSize = true;
            this.rbSinav2Ortalamasi.Location = new System.Drawing.Point(39, 249);
            this.rbSinav2Ortalamasi.Name = "rbSinav2Ortalamasi";
            this.rbSinav2Ortalamasi.Size = new System.Drawing.Size(110, 17);
            this.rbSinav2Ortalamasi.TabIndex = 24;
            this.rbSinav2Ortalamasi.TabStop = true;
            this.rbSinav2Ortalamasi.Text = "Sınav2 Ortalaması";
            this.rbSinav2Ortalamasi.UseVisualStyleBackColor = true;
            // 
            // rbSinav2Toplami
            // 
            this.rbSinav2Toplami.AutoSize = true;
            this.rbSinav2Toplami.Location = new System.Drawing.Point(39, 226);
            this.rbSinav2Toplami.Name = "rbSinav2Toplami";
            this.rbSinav2Toplami.Size = new System.Drawing.Size(98, 17);
            this.rbSinav2Toplami.TabIndex = 23;
            this.rbSinav2Toplami.TabStop = true;
            this.rbSinav2Toplami.Text = "Sınav2 Toplamı";
            this.rbSinav2Toplami.UseVisualStyleBackColor = true;
            // 
            // rbSinav1Ort
            // 
            this.rbSinav1Ort.AutoSize = true;
            this.rbSinav1Ort.Location = new System.Drawing.Point(39, 205);
            this.rbSinav1Ort.Name = "rbSinav1Ort";
            this.rbSinav1Ort.Size = new System.Drawing.Size(110, 17);
            this.rbSinav1Ort.TabIndex = 22;
            this.rbSinav1Ort.TabStop = true;
            this.rbSinav1Ort.Text = "Sınav1 Ortalaması";
            this.rbSinav1Ort.UseVisualStyleBackColor = true;
            // 
            // rbSinav1
            // 
            this.rbSinav1.AutoSize = true;
            this.rbSinav1.Location = new System.Drawing.Point(39, 183);
            this.rbSinav1.Name = "rbSinav1";
            this.rbSinav1.Size = new System.Drawing.Size(98, 17);
            this.rbSinav1.TabIndex = 21;
            this.rbSinav1.TabStop = true;
            this.rbSinav1.Text = "Sınav1 Toplamı";
            this.rbSinav1.UseVisualStyleBackColor = true;
            // 
            // rbToplamOgrenciSayisi
            // 
            this.rbToplamOgrenciSayisi.AutoSize = true;
            this.rbToplamOgrenciSayisi.Location = new System.Drawing.Point(39, 160);
            this.rbToplamOgrenciSayisi.Name = "rbToplamOgrenciSayisi";
            this.rbToplamOgrenciSayisi.Size = new System.Drawing.Size(130, 17);
            this.rbToplamOgrenciSayisi.TabIndex = 20;
            this.rbToplamOgrenciSayisi.TabStop = true;
            this.rbToplamOgrenciSayisi.Text = "Toplam Öğrenci Sayısı";
            this.rbToplamOgrenciSayisi.UseVisualStyleBackColor = true;
            // 
            // rbA_ile_bitenler
            // 
            this.rbA_ile_bitenler.AutoSize = true;
            this.rbA_ile_bitenler.Location = new System.Drawing.Point(39, 137);
            this.rbA_ile_bitenler.Name = "rbA_ile_bitenler";
            this.rbA_ile_bitenler.Size = new System.Drawing.Size(101, 17);
            this.rbA_ile_bitenler.TabIndex = 19;
            this.rbA_ile_bitenler.TabStop = true;
            this.rbA_ile_bitenler.Text = "Adı A ile Bitenler";
            this.rbA_ile_bitenler.UseVisualStyleBackColor = true;
            // 
            // rbA_ile_baslayanlar
            // 
            this.rbA_ile_baslayanlar.AutoSize = true;
            this.rbA_ile_baslayanlar.Location = new System.Drawing.Point(39, 114);
            this.rbA_ile_baslayanlar.Name = "rbA_ile_baslayanlar";
            this.rbA_ile_baslayanlar.Size = new System.Drawing.Size(120, 17);
            this.rbA_ile_baslayanlar.TabIndex = 18;
            this.rbA_ile_baslayanlar.TabStop = true;
            this.rbA_ile_baslayanlar.Text = "Adı A ile Başlayanlar";
            this.rbA_ile_baslayanlar.UseVisualStyleBackColor = true;
            // 
            // rbIDSiralama
            // 
            this.rbIDSiralama.AutoSize = true;
            this.rbIDSiralama.Location = new System.Drawing.Point(39, 91);
            this.rbIDSiralama.Name = "rbIDSiralama";
            this.rbIDSiralama.Size = new System.Drawing.Size(104, 17);
            this.rbIDSiralama.TabIndex = 17;
            this.rbIDSiralama.TabStop = true;
            this.rbIDSiralama.Text = "ID\'ye Göre Sırala";
            this.rbIDSiralama.UseVisualStyleBackColor = true;
            // 
            // rbIlkUcSiralama
            // 
            this.rbIlkUcSiralama.AutoSize = true;
            this.rbIlkUcSiralama.Location = new System.Drawing.Point(39, 68);
            this.rbIlkUcSiralama.Name = "rbIlkUcSiralama";
            this.rbIlkUcSiralama.Size = new System.Drawing.Size(104, 17);
            this.rbIlkUcSiralama.TabIndex = 16;
            this.rbIlkUcSiralama.TabStop = true;
            this.rbIlkUcSiralama.Text = "İlk 3 Kişiyi Listele";
            this.rbIlkUcSiralama.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 796);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnProsedur);
            this.Controls.Add(this.btnDersKaydet);
            this.Controls.Add(this.btnNotListele);
            this.Controls.Add(this.gbDersler);
            this.Controls.Add(this.gbNotlar);
            this.Controls.Add(this.gbOgrenci);
            this.Controls.Add(this.btnDersListele);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnOgrenciListele);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbOgrenci.ResumeLayout(false);
            this.gbOgrenci.PerformLayout();
            this.gbNotlar.ResumeLayout(false);
            this.gbNotlar.PerformLayout();
            this.gbDersler.ResumeLayout(false);
            this.gbDersler.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnOgrenciListele;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDersListele;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.GroupBox gbOgrenci;
        private System.Windows.Forms.TextBox txtOgrFoto;
        private System.Windows.Forms.TextBox txtOgrSoyad;
        private System.Windows.Forms.TextBox txtOgrAd;
        private System.Windows.Forms.TextBox txtOgrID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbNotlar;
        private System.Windows.Forms.Button btnJoinGetirme;
        private System.Windows.Forms.Button btnNotHesapla;
        private System.Windows.Forms.TextBox txtOrtalama;
        private System.Windows.Forms.TextBox txtSinav3;
        private System.Windows.Forms.TextBox txtSinav2;
        private System.Windows.Forms.TextBox txtSinav1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gbDersler;
        private System.Windows.Forms.TextBox txtDersAd;
        private System.Windows.Forms.TextBox txtDersId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnNotListele;
        private System.Windows.Forms.Button btnDersKaydet;
        private System.Windows.Forms.Button btnProsedur;
        private System.Windows.Forms.RadioButton rbIsimSiralama;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbIsimSıralamaZ;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbIlkUcSiralama;
        private System.Windows.Forms.RadioButton rbIDSiralama;
        private System.Windows.Forms.RadioButton rbA_ile_baslayanlar;
        private System.Windows.Forms.RadioButton rbA_ile_bitenler;
        private System.Windows.Forms.RadioButton rbToplamOgrenciSayisi;
        private System.Windows.Forms.RadioButton rbSinav1;
        private System.Windows.Forms.RadioButton rbSinav1Ort;
        private System.Windows.Forms.RadioButton rbSinav3Ortalamasi;
        private System.Windows.Forms.RadioButton rbSinav3Toplami;
        private System.Windows.Forms.RadioButton rbSinav2Ortalamasi;
        private System.Windows.Forms.RadioButton rbSinav2Toplami;
    }
}

