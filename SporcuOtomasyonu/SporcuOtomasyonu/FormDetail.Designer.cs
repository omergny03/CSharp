namespace SporcuOtomasyonu
{
    partial class FormDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetail));
            this.lblLoginPageName = new System.Windows.Forms.Label();
            this.lblLoginPageUsername = new System.Windows.Forms.Label();
            this.lblLoginPageEmail = new System.Windows.Forms.Label();
            this.groupBoxKullanici = new System.Windows.Forms.GroupBox();
            this.groupBoxEat = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtYag = new System.Windows.Forms.TextBox();
            this.txtProtein = new System.Windows.Forms.TextBox();
            this.txtKarbonhidrat = new System.Windows.Forms.TextBox();
            this.lblKcalValue = new System.Windows.Forms.Label();
            this.lblKcal = new System.Windows.Forms.Label();
            this.lblYag = new System.Windows.Forms.Label();
            this.lblProtein = new System.Windows.Forms.Label();
            this.lblKarbonhidrat = new System.Windows.Forms.Label();
            this.btnListe = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnKarbonhidrat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnProtein = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnYag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnKcal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnChart = new System.Windows.Forms.Button();
            this.groupBoxKullanici.SuspendLayout();
            this.groupBoxEat.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLoginPageName
            // 
            this.lblLoginPageName.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblLoginPageName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLoginPageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLoginPageName.Location = new System.Drawing.Point(0, 0);
            this.lblLoginPageName.Name = "lblLoginPageName";
            this.lblLoginPageName.Size = new System.Drawing.Size(1295, 56);
            this.lblLoginPageName.TabIndex = 0;
            this.lblLoginPageName.Text = "HOŞGELDİNİZ name + username";
            this.lblLoginPageName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblLoginPageUsername
            // 
            this.lblLoginPageUsername.Location = new System.Drawing.Point(6, 32);
            this.lblLoginPageUsername.Name = "lblLoginPageUsername";
            this.lblLoginPageUsername.Size = new System.Drawing.Size(375, 33);
            this.lblLoginPageUsername.TabIndex = 0;
            this.lblLoginPageUsername.Text = "Kullanıcı Adı : ....................";
            // 
            // lblLoginPageEmail
            // 
            this.lblLoginPageEmail.Location = new System.Drawing.Point(6, 65);
            this.lblLoginPageEmail.Name = "lblLoginPageEmail";
            this.lblLoginPageEmail.Size = new System.Drawing.Size(375, 33);
            this.lblLoginPageEmail.TabIndex = 0;
            this.lblLoginPageEmail.Text = "Email : ..............................";
            // 
            // groupBoxKullanici
            // 
            this.groupBoxKullanici.BackColor = System.Drawing.SystemColors.Info;
            this.groupBoxKullanici.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBoxKullanici.Controls.Add(this.lblLoginPageUsername);
            this.groupBoxKullanici.Controls.Add(this.lblLoginPageEmail);
            this.groupBoxKullanici.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBoxKullanici.Location = new System.Drawing.Point(29, 77);
            this.groupBoxKullanici.Name = "groupBoxKullanici";
            this.groupBoxKullanici.Size = new System.Drawing.Size(386, 162);
            this.groupBoxKullanici.TabIndex = 1;
            this.groupBoxKullanici.TabStop = false;
            this.groupBoxKullanici.Text = "KULLANICI BİLGİLERİ";
            // 
            // groupBoxEat
            // 
            this.groupBoxEat.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBoxEat.Controls.Add(this.btnKaydet);
            this.groupBoxEat.Controls.Add(this.btnHesapla);
            this.groupBoxEat.Controls.Add(this.txtYag);
            this.groupBoxEat.Controls.Add(this.txtProtein);
            this.groupBoxEat.Controls.Add(this.txtKarbonhidrat);
            this.groupBoxEat.Controls.Add(this.lblKcalValue);
            this.groupBoxEat.Controls.Add(this.lblKcal);
            this.groupBoxEat.Controls.Add(this.lblYag);
            this.groupBoxEat.Controls.Add(this.lblProtein);
            this.groupBoxEat.Controls.Add(this.lblKarbonhidrat);
            this.groupBoxEat.Location = new System.Drawing.Point(840, 77);
            this.groupBoxEat.Name = "groupBoxEat";
            this.groupBoxEat.Size = new System.Drawing.Size(443, 484);
            this.groupBoxEat.TabIndex = 2;
            this.groupBoxEat.TabStop = false;
            this.groupBoxEat.Text = "GÜNLÜK ÖĞÜN BİLGİSİ";
            this.groupBoxEat.Visible = false;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(3, 437);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(437, 44);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(140, 144);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(195, 34);
            this.btnHesapla.TabIndex = 2;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // txtYag
            // 
            this.txtYag.Location = new System.Drawing.Point(140, 106);
            this.txtYag.Name = "txtYag";
            this.txtYag.Size = new System.Drawing.Size(195, 22);
            this.txtYag.TabIndex = 1;
            // 
            // txtProtein
            // 
            this.txtProtein.Location = new System.Drawing.Point(140, 68);
            this.txtProtein.Name = "txtProtein";
            this.txtProtein.Size = new System.Drawing.Size(195, 22);
            this.txtProtein.TabIndex = 1;
            // 
            // txtKarbonhidrat
            // 
            this.txtKarbonhidrat.Location = new System.Drawing.Point(140, 29);
            this.txtKarbonhidrat.Name = "txtKarbonhidrat";
            this.txtKarbonhidrat.Size = new System.Drawing.Size(195, 22);
            this.txtKarbonhidrat.TabIndex = 1;
            // 
            // lblKcalValue
            // 
            this.lblKcalValue.AutoSize = true;
            this.lblKcalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKcalValue.Location = new System.Drawing.Point(136, 192);
            this.lblKcalValue.Name = "lblKcalValue";
            this.lblKcalValue.Size = new System.Drawing.Size(89, 20);
            this.lblKcalValue.TabIndex = 0;
            this.lblKcalValue.Text = "1000 kcal";
            // 
            // lblKcal
            // 
            this.lblKcal.AutoSize = true;
            this.lblKcal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKcal.Location = new System.Drawing.Point(23, 192);
            this.lblKcal.Name = "lblKcal";
            this.lblKcal.Size = new System.Drawing.Size(70, 20);
            this.lblKcal.TabIndex = 0;
            this.lblKcal.Text = "Kalori :";
            // 
            // lblYag
            // 
            this.lblYag.AutoSize = true;
            this.lblYag.Location = new System.Drawing.Point(23, 109);
            this.lblYag.Name = "lblYag";
            this.lblYag.Size = new System.Drawing.Size(41, 16);
            this.lblYag.TabIndex = 0;
            this.lblYag.Text = "Yağ : ";
            // 
            // lblProtein
            // 
            this.lblProtein.AutoSize = true;
            this.lblProtein.Location = new System.Drawing.Point(23, 71);
            this.lblProtein.Name = "lblProtein";
            this.lblProtein.Size = new System.Drawing.Size(58, 16);
            this.lblProtein.TabIndex = 0;
            this.lblProtein.Text = "Protein : ";
            // 
            // lblKarbonhidrat
            // 
            this.lblKarbonhidrat.AutoSize = true;
            this.lblKarbonhidrat.Location = new System.Drawing.Point(23, 32);
            this.lblKarbonhidrat.Name = "lblKarbonhidrat";
            this.lblKarbonhidrat.Size = new System.Drawing.Size(92, 16);
            this.lblKarbonhidrat.TabIndex = 0;
            this.lblKarbonhidrat.Text = "Karbonhidrat : ";
            // 
            // btnListe
            // 
            this.btnListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListe.Location = new System.Drawing.Point(29, 269);
            this.btnListe.Name = "btnListe";
            this.btnListe.Size = new System.Drawing.Size(96, 41);
            this.btnListe.TabIndex = 3;
            this.btnListe.Text = "Listele";
            this.btnListe.UseVisualStyleBackColor = true;
            this.btnListe.Click += new System.EventHandler(this.btnListe_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(147, 269);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(138, 41);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = " Öğün Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnId,
            this.columnKarbonhidrat,
            this.columnProtein,
            this.columnYag,
            this.columnKcal});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(424, 77);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(413, 484);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Visible = false;
            // 
            // columnId
            // 
            this.columnId.Text = "Gün";
            // 
            // columnKarbonhidrat
            // 
            this.columnKarbonhidrat.Text = "Karbonhidrat";
            this.columnKarbonhidrat.Width = 98;
            // 
            // columnProtein
            // 
            this.columnProtein.Text = "Protein";
            this.columnProtein.Width = 84;
            // 
            // columnYag
            // 
            this.columnYag.Text = "Yağ";
            // 
            // columnKcal
            // 
            this.columnKcal.Text = "kCal";
            // 
            // btnChart
            // 
            this.btnChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnChart.Location = new System.Drawing.Point(29, 316);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(256, 41);
            this.btnChart.TabIndex = 5;
            this.btnChart.Text = "Kalori Oranı";
            this.btnChart.UseVisualStyleBackColor = true;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // FormDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1295, 602);
            this.Controls.Add(this.btnChart);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnListe);
            this.Controls.Add(this.groupBoxEat);
            this.Controls.Add(this.groupBoxKullanici);
            this.Controls.Add(this.lblLoginPageName);
            this.Name = "FormDetail";
            this.Text = "FormDetail";
            this.Load += new System.EventHandler(this.FormDetail_Load);
            this.groupBoxKullanici.ResumeLayout(false);
            this.groupBoxEat.ResumeLayout(false);
            this.groupBoxEat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLoginPageName;
        private System.Windows.Forms.Label lblLoginPageUsername;
        private System.Windows.Forms.Label lblLoginPageEmail;
        private System.Windows.Forms.GroupBox groupBoxKullanici;
        private System.Windows.Forms.GroupBox groupBoxEat;
        private System.Windows.Forms.Label lblYag;
        private System.Windows.Forms.Label lblProtein;
        private System.Windows.Forms.Label lblKarbonhidrat;
        private System.Windows.Forms.TextBox txtYag;
        private System.Windows.Forms.TextBox txtProtein;
        private System.Windows.Forms.TextBox txtKarbonhidrat;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblKcal;
        private System.Windows.Forms.Label lblKcalValue;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnListe;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnId;
        private System.Windows.Forms.ColumnHeader columnKarbonhidrat;
        private System.Windows.Forms.ColumnHeader columnProtein;
        private System.Windows.Forms.ColumnHeader columnYag;
        private System.Windows.Forms.ColumnHeader columnKcal;
        private System.Windows.Forms.Button btnChart;
    }
}