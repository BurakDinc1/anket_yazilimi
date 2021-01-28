namespace AileGelirNotu
{
    partial class GelirFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GelirFormu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_isim = new System.Windows.Forms.TextBox();
            this.txt_soyisim = new System.Windows.Forms.TextBox();
            this.txt_telno = new System.Windows.Forms.TextBox();
            this.txt_ikametgah = new System.Windows.Forms.TextBox();
            this.txt_reismeslek = new System.Windows.Forms.TextBox();
            this.rdbttn_ilkokul = new System.Windows.Forms.RadioButton();
            this.rdbttn_ortaokul = new System.Windows.Forms.RadioButton();
            this.rdbttn_lise = new System.Windows.Forms.RadioButton();
            this.rdbttn_önlisans = new System.Windows.Forms.RadioButton();
            this.rdbttn_lisans = new System.Windows.Forms.RadioButton();
            this.rdbttn_lisansüstü = new System.Windows.Forms.RadioButton();
            this.rdbttn_ögörmemis = new System.Windows.Forms.RadioButton();
            this.cmbbx_gelir = new System.Windows.Forms.ComboBox();
            this.bttn_ekle = new System.Windows.Forms.Button();
            this.bttn_temizle = new System.Windows.Forms.Button();
            this.cmbbx_alankodu = new System.Windows.Forms.ComboBox();
            this.lbl_istegebagli = new System.Windows.Forms.Label();
            this.grid_kisibilgileri = new System.Windows.Forms.DataGridView();
            this.bttn_kisilericek = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_ara = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.bttn_ara = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_kisibilgileri)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(36, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anket Yapılan Bireyin;";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(39, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "İsmi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(39, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyismi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(39, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon Numarası:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(40, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "İkametgah Adresi (İL):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(40, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Aile Reisinin;";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(40, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Mesleği:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(40, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Öğrenim Durumu:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(40, 389);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Aylık Geliri:";
            // 
            // txt_isim
            // 
            this.txt_isim.Location = new System.Drawing.Point(73, 65);
            this.txt_isim.Name = "txt_isim";
            this.txt_isim.Size = new System.Drawing.Size(100, 20);
            this.txt_isim.TabIndex = 10;
            // 
            // txt_soyisim
            // 
            this.txt_soyisim.Location = new System.Drawing.Point(90, 98);
            this.txt_soyisim.Name = "txt_soyisim";
            this.txt_soyisim.Size = new System.Drawing.Size(100, 20);
            this.txt_soyisim.TabIndex = 11;
            // 
            // txt_telno
            // 
            this.txt_telno.Location = new System.Drawing.Point(206, 129);
            this.txt_telno.Name = "txt_telno";
            this.txt_telno.Size = new System.Drawing.Size(96, 20);
            this.txt_telno.TabIndex = 12;
            // 
            // txt_ikametgah
            // 
            this.txt_ikametgah.Location = new System.Drawing.Point(156, 161);
            this.txt_ikametgah.Name = "txt_ikametgah";
            this.txt_ikametgah.Size = new System.Drawing.Size(183, 20);
            this.txt_ikametgah.TabIndex = 13;
            this.txt_ikametgah.Tag = "";
            // 
            // txt_reismeslek
            // 
            this.txt_reismeslek.Location = new System.Drawing.Point(93, 287);
            this.txt_reismeslek.Name = "txt_reismeslek";
            this.txt_reismeslek.Size = new System.Drawing.Size(132, 20);
            this.txt_reismeslek.TabIndex = 14;
            // 
            // rdbttn_ilkokul
            // 
            this.rdbttn_ilkokul.AutoSize = true;
            this.rdbttn_ilkokul.BackColor = System.Drawing.Color.Transparent;
            this.rdbttn_ilkokul.Checked = true;
            this.rdbttn_ilkokul.Location = new System.Drawing.Point(134, 324);
            this.rdbttn_ilkokul.Name = "rdbttn_ilkokul";
            this.rdbttn_ilkokul.Size = new System.Drawing.Size(56, 17);
            this.rdbttn_ilkokul.TabIndex = 15;
            this.rdbttn_ilkokul.TabStop = true;
            this.rdbttn_ilkokul.Text = "İlkokul";
            this.rdbttn_ilkokul.UseVisualStyleBackColor = false;
            // 
            // rdbttn_ortaokul
            // 
            this.rdbttn_ortaokul.AutoSize = true;
            this.rdbttn_ortaokul.BackColor = System.Drawing.Color.Transparent;
            this.rdbttn_ortaokul.Location = new System.Drawing.Point(196, 324);
            this.rdbttn_ortaokul.Name = "rdbttn_ortaokul";
            this.rdbttn_ortaokul.Size = new System.Drawing.Size(65, 17);
            this.rdbttn_ortaokul.TabIndex = 16;
            this.rdbttn_ortaokul.Text = "Ortaokul";
            this.rdbttn_ortaokul.UseVisualStyleBackColor = false;
            // 
            // rdbttn_lise
            // 
            this.rdbttn_lise.AutoSize = true;
            this.rdbttn_lise.BackColor = System.Drawing.Color.Transparent;
            this.rdbttn_lise.Location = new System.Drawing.Point(267, 324);
            this.rdbttn_lise.Name = "rdbttn_lise";
            this.rdbttn_lise.Size = new System.Drawing.Size(44, 17);
            this.rdbttn_lise.TabIndex = 17;
            this.rdbttn_lise.Text = "Lise";
            this.rdbttn_lise.UseVisualStyleBackColor = false;
            // 
            // rdbttn_önlisans
            // 
            this.rdbttn_önlisans.AutoSize = true;
            this.rdbttn_önlisans.BackColor = System.Drawing.Color.Transparent;
            this.rdbttn_önlisans.Location = new System.Drawing.Point(317, 324);
            this.rdbttn_önlisans.Name = "rdbttn_önlisans";
            this.rdbttn_önlisans.Size = new System.Drawing.Size(65, 17);
            this.rdbttn_önlisans.TabIndex = 18;
            this.rdbttn_önlisans.Text = "Önlisans";
            this.rdbttn_önlisans.UseVisualStyleBackColor = false;
            // 
            // rdbttn_lisans
            // 
            this.rdbttn_lisans.AutoSize = true;
            this.rdbttn_lisans.BackColor = System.Drawing.Color.Transparent;
            this.rdbttn_lisans.Location = new System.Drawing.Point(134, 347);
            this.rdbttn_lisans.Name = "rdbttn_lisans";
            this.rdbttn_lisans.Size = new System.Drawing.Size(55, 17);
            this.rdbttn_lisans.TabIndex = 19;
            this.rdbttn_lisans.Text = "Lisans";
            this.rdbttn_lisans.UseVisualStyleBackColor = false;
            // 
            // rdbttn_lisansüstü
            // 
            this.rdbttn_lisansüstü.AutoSize = true;
            this.rdbttn_lisansüstü.BackColor = System.Drawing.Color.Transparent;
            this.rdbttn_lisansüstü.Location = new System.Drawing.Point(195, 347);
            this.rdbttn_lisansüstü.Name = "rdbttn_lisansüstü";
            this.rdbttn_lisansüstü.Size = new System.Drawing.Size(75, 17);
            this.rdbttn_lisansüstü.TabIndex = 20;
            this.rdbttn_lisansüstü.Text = "Lisansüstü";
            this.rdbttn_lisansüstü.UseVisualStyleBackColor = false;
            // 
            // rdbttn_ögörmemis
            // 
            this.rdbttn_ögörmemis.AutoSize = true;
            this.rdbttn_ögörmemis.BackColor = System.Drawing.Color.Transparent;
            this.rdbttn_ögörmemis.Location = new System.Drawing.Point(276, 347);
            this.rdbttn_ögörmemis.Name = "rdbttn_ögörmemis";
            this.rdbttn_ögörmemis.Size = new System.Drawing.Size(113, 17);
            this.rdbttn_ögörmemis.TabIndex = 21;
            this.rdbttn_ögörmemis.Text = "Öğrenim Görmemiş";
            this.rdbttn_ögörmemis.UseVisualStyleBackColor = false;
            // 
            // cmbbx_gelir
            // 
            this.cmbbx_gelir.FormattingEnabled = true;
            this.cmbbx_gelir.Items.AddRange(new object[] {
            "0-1606 TL",
            "1606-2000 TL",
            "2000-3000 TL",
            "3000-4000 TL",
            "4000-5000 TL",
            "5000+ TL"});
            this.cmbbx_gelir.Location = new System.Drawing.Point(104, 381);
            this.cmbbx_gelir.Name = "cmbbx_gelir";
            this.cmbbx_gelir.Size = new System.Drawing.Size(133, 21);
            this.cmbbx_gelir.TabIndex = 22;
            // 
            // bttn_ekle
            // 
            this.bttn_ekle.ForeColor = System.Drawing.Color.ForestGreen;
            this.bttn_ekle.Location = new System.Drawing.Point(42, 453);
            this.bttn_ekle.Name = "bttn_ekle";
            this.bttn_ekle.Size = new System.Drawing.Size(104, 32);
            this.bttn_ekle.TabIndex = 23;
            this.bttn_ekle.Text = "Ekle";
            this.bttn_ekle.UseVisualStyleBackColor = true;
            this.bttn_ekle.Click += new System.EventHandler(this.bttn_ekle_Click);
            // 
            // bttn_temizle
            // 
            this.bttn_temizle.ForeColor = System.Drawing.Color.Purple;
            this.bttn_temizle.Location = new System.Drawing.Point(152, 453);
            this.bttn_temizle.Name = "bttn_temizle";
            this.bttn_temizle.Size = new System.Drawing.Size(139, 32);
            this.bttn_temizle.TabIndex = 27;
            this.bttn_temizle.Text = "Formu Temizle";
            this.bttn_temizle.UseVisualStyleBackColor = true;
            this.bttn_temizle.Click += new System.EventHandler(this.bttn_temizle_Click);
            // 
            // cmbbx_alankodu
            // 
            this.cmbbx_alankodu.FormattingEnabled = true;
            this.cmbbx_alankodu.Items.AddRange(new object[] {
            "0501",
            "0502",
            "0503",
            "0504",
            "0505",
            "0506",
            "0507",
            "0508",
            "0509",
            "0510",
            "0511",
            "0512",
            "0513",
            "0514",
            "0515",
            "0516",
            "0517",
            "0518",
            "0519",
            "0520",
            "0521",
            "0522",
            "0523",
            "0524",
            "0525",
            "0526",
            "0527",
            "0528",
            "0529",
            "0530",
            "0531",
            "0532",
            "0533",
            "0534",
            "0535",
            "0536",
            "0537",
            "0538",
            "0539",
            "0540",
            "0541",
            "0542",
            "0543",
            "0544",
            "0545",
            "0546",
            "0547",
            "0548",
            "0549",
            "0550",
            "0551",
            "0552",
            "0553",
            "0554",
            "0555",
            "0556",
            "0557",
            "0558",
            "0559"});
            this.cmbbx_alankodu.Location = new System.Drawing.Point(137, 128);
            this.cmbbx_alankodu.Name = "cmbbx_alankodu";
            this.cmbbx_alankodu.Size = new System.Drawing.Size(63, 21);
            this.cmbbx_alankodu.TabIndex = 30;
            // 
            // lbl_istegebagli
            // 
            this.lbl_istegebagli.AutoSize = true;
            this.lbl_istegebagli.ForeColor = System.Drawing.Color.Red;
            this.lbl_istegebagli.Location = new System.Drawing.Point(345, 168);
            this.lbl_istegebagli.Name = "lbl_istegebagli";
            this.lbl_istegebagli.Size = new System.Drawing.Size(0, 13);
            this.lbl_istegebagli.TabIndex = 31;
            // 
            // grid_kisibilgileri
            // 
            this.grid_kisibilgileri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_kisibilgileri.Location = new System.Drawing.Point(434, 65);
            this.grid_kisibilgileri.Name = "grid_kisibilgileri";
            this.grid_kisibilgileri.Size = new System.Drawing.Size(743, 342);
            this.grid_kisibilgileri.TabIndex = 32;
            // 
            // bttn_kisilericek
            // 
            this.bttn_kisilericek.BackColor = System.Drawing.Color.Transparent;
            this.bttn_kisilericek.BackgroundImage = global::AileGelirNotu.Properties.Resources.list_flat;
            this.bttn_kisilericek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bttn_kisilericek.ForeColor = System.Drawing.Color.Black;
            this.bttn_kisilericek.Location = new System.Drawing.Point(1087, 423);
            this.bttn_kisilericek.Name = "bttn_kisilericek";
            this.bttn_kisilericek.Size = new System.Drawing.Size(90, 32);
            this.bttn_kisilericek.TabIndex = 33;
            this.bttn_kisilericek.UseVisualStyleBackColor = false;
            this.bttn_kisilericek.Click += new System.EventHandler(this.bttn_kisilericek_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(180, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 16);
            this.label10.TabIndex = 34;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(196, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 16);
            this.label11.TabIndex = 35;
            this.label11.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(308, 128);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 16);
            this.label12.TabIndex = 36;
            this.label12.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(243, 381);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 16);
            this.label13.TabIndex = 37;
            this.label13.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(454, 431);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(199, 15);
            this.label14.TabIndex = 39;
            this.label14.Text = "simgesi zorunlu alanları ifade eder.";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(430, 431);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(18, 24);
            this.label15.TabIndex = 40;
            this.label15.Text = "*";
            // 
            // txt_ara
            // 
            this.txt_ara.Location = new System.Drawing.Point(434, 40);
            this.txt_ara.Name = "txt_ara";
            this.txt_ara.Size = new System.Drawing.Size(100, 20);
            this.txt_ara.TabIndex = 97;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(1073, 49);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 13);
            this.label16.TabIndex = 101;
            this.label16.Text = "Anket Sayısı:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.ForeColor = System.Drawing.Color.Blue;
            this.label17.Location = new System.Drawing.Point(1147, 49);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(13, 13);
            this.label17.TabIndex = 102;
            this.label17.Text = "0";
            // 
            // bttn_ara
            // 
            this.bttn_ara.BackgroundImage = global::AileGelirNotu.Properties.Resources.mercek1;
            this.bttn_ara.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bttn_ara.Location = new System.Drawing.Point(540, 40);
            this.bttn_ara.Name = "bttn_ara";
            this.bttn_ara.Size = new System.Drawing.Size(60, 20);
            this.bttn_ara.TabIndex = 100;
            this.bttn_ara.UseVisualStyleBackColor = true;
            this.bttn_ara.Click += new System.EventHandler(this.bttn_ara_Click);
            // 
            // GelirFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AileGelirNotu.Properties.Resources._27020042_statistics_wallpapers;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1203, 507);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.bttn_ara);
            this.Controls.Add(this.txt_ara);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.bttn_kisilericek);
            this.Controls.Add(this.grid_kisibilgileri);
            this.Controls.Add(this.lbl_istegebagli);
            this.Controls.Add(this.cmbbx_alankodu);
            this.Controls.Add(this.bttn_temizle);
            this.Controls.Add(this.bttn_ekle);
            this.Controls.Add(this.cmbbx_gelir);
            this.Controls.Add(this.rdbttn_ögörmemis);
            this.Controls.Add(this.rdbttn_lisansüstü);
            this.Controls.Add(this.rdbttn_lisans);
            this.Controls.Add(this.rdbttn_önlisans);
            this.Controls.Add(this.rdbttn_lise);
            this.Controls.Add(this.rdbttn_ortaokul);
            this.Controls.Add(this.rdbttn_ilkokul);
            this.Controls.Add(this.txt_reismeslek);
            this.Controls.Add(this.txt_ikametgah);
            this.Controls.Add(this.txt_telno);
            this.Controls.Add(this.txt_soyisim);
            this.Controls.Add(this.txt_isim);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GelirFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aile Gelir Anketi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_kisibilgileri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_isim;
        private System.Windows.Forms.TextBox txt_soyisim;
        private System.Windows.Forms.TextBox txt_telno;
        private System.Windows.Forms.TextBox txt_ikametgah;
        private System.Windows.Forms.TextBox txt_reismeslek;
        private System.Windows.Forms.RadioButton rdbttn_ilkokul;
        private System.Windows.Forms.RadioButton rdbttn_ortaokul;
        private System.Windows.Forms.RadioButton rdbttn_lise;
        private System.Windows.Forms.RadioButton rdbttn_önlisans;
        private System.Windows.Forms.RadioButton rdbttn_lisans;
        private System.Windows.Forms.RadioButton rdbttn_lisansüstü;
        private System.Windows.Forms.RadioButton rdbttn_ögörmemis;
        private System.Windows.Forms.ComboBox cmbbx_gelir;
        private System.Windows.Forms.Button bttn_ekle;
        private System.Windows.Forms.Button bttn_temizle;
        private System.Windows.Forms.ComboBox cmbbx_alankodu;
        private System.Windows.Forms.Label lbl_istegebagli;
        private System.Windows.Forms.DataGridView grid_kisibilgileri;
        private System.Windows.Forms.Button bttn_kisilericek;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_ara;
        private System.Windows.Forms.Button bttn_ara;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
    }
}

