namespace Edytor_Albumów.UI
{
    partial class Edytor
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
            this.label1 = new System.Windows.Forms.Label();
            this.ZrodloSciezka = new System.Windows.Forms.TextBox();
            this.SzukajFolder = new System.Windows.Forms.Button();
            this.ZatwierdzFolder = new System.Windows.Forms.Button();
            this.ZrodloLista = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AlbumLista = new System.Windows.Forms.ListBox();
            this.AlbumNazwa = new System.Windows.Forms.Label();
            this.AlbumDodaj = new System.Windows.Forms.Button();
            this.AlbumUsun = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ZdjecieNazwa = new System.Windows.Forms.TextBox();
            this.ZdjecieData = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ZdjecieMiejsce = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ZdjecieOpis = new System.Windows.Forms.RichTextBox();
            this.ZdjecieZapisz = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.AlbumNowy = new System.Windows.Forms.Button();
            this.AlbumEdytuj = new System.Windows.Forms.Button();
            this.AlbumZapisz = new System.Windows.Forms.Button();
            this.Podglad = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.RamkaLG = new System.Windows.Forms.PictureBox();
            this.RamkaL = new System.Windows.Forms.PictureBox();
            this.RamkaG = new System.Windows.Forms.PictureBox();
            this.RamkaPD = new System.Windows.Forms.PictureBox();
            this.RamkaD = new System.Windows.Forms.PictureBox();
            this.RamkaLD = new System.Windows.Forms.PictureBox();
            this.RamkaPG = new System.Windows.Forms.PictureBox();
            this.RamkaP = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AlbumOpis = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.RamkiLista = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.AlbumNazwaBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Podglad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RamkaLG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RamkaL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RamkaG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RamkaPD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RamkaD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RamkaLD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RamkaPG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RamkaP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Folder Źródłowy";
            // 
            // ZrodloSciezka
            // 
            this.ZrodloSciezka.Location = new System.Drawing.Point(13, 30);
            this.ZrodloSciezka.Name = "ZrodloSciezka";
            this.ZrodloSciezka.Size = new System.Drawing.Size(274, 20);
            this.ZrodloSciezka.TabIndex = 1;
            // 
            // SzukajFolder
            // 
            this.SzukajFolder.Location = new System.Drawing.Point(293, 28);
            this.SzukajFolder.Name = "SzukajFolder";
            this.SzukajFolder.Size = new System.Drawing.Size(75, 23);
            this.SzukajFolder.TabIndex = 2;
            this.SzukajFolder.Text = "Szukaj";
            this.SzukajFolder.UseVisualStyleBackColor = true;
            this.SzukajFolder.Click += new System.EventHandler(this.SzukajFolder_Click);
            // 
            // ZatwierdzFolder
            // 
            this.ZatwierdzFolder.Location = new System.Drawing.Point(374, 28);
            this.ZatwierdzFolder.Name = "ZatwierdzFolder";
            this.ZatwierdzFolder.Size = new System.Drawing.Size(75, 23);
            this.ZatwierdzFolder.TabIndex = 3;
            this.ZatwierdzFolder.Text = "Zatwierdź";
            this.ZatwierdzFolder.UseVisualStyleBackColor = true;
            this.ZatwierdzFolder.Click += new System.EventHandler(this.ZatwierdzFolder_Click);
            // 
            // ZrodloLista
            // 
            this.ZrodloLista.FormattingEnabled = true;
            this.ZrodloLista.Location = new System.Drawing.Point(12, 83);
            this.ZrodloLista.Name = "ZrodloLista";
            this.ZrodloLista.Size = new System.Drawing.Size(121, 212);
            this.ZrodloLista.TabIndex = 4;
            this.ZrodloLista.SelectedIndexChanged += new System.EventHandler(this.ZrodloLista_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Zdjęcia źródłowe";
            // 
            // AlbumLista
            // 
            this.AlbumLista.FormattingEnabled = true;
            this.AlbumLista.Location = new System.Drawing.Point(139, 83);
            this.AlbumLista.Name = "AlbumLista";
            this.AlbumLista.Size = new System.Drawing.Size(122, 212);
            this.AlbumLista.TabIndex = 6;
            this.AlbumLista.SelectedIndexChanged += new System.EventHandler(this.AlbumLista_SelectedIndexChanged);
            // 
            // AlbumNazwa
            // 
            this.AlbumNazwa.AutoSize = true;
            this.AlbumNazwa.Location = new System.Drawing.Point(136, 64);
            this.AlbumNazwa.Name = "AlbumNazwa";
            this.AlbumNazwa.Size = new System.Drawing.Size(39, 13);
            this.AlbumNazwa.TabIndex = 7;
            this.AlbumNazwa.Text = "Album:";
            // 
            // AlbumDodaj
            // 
            this.AlbumDodaj.Location = new System.Drawing.Point(12, 302);
            this.AlbumDodaj.Name = "AlbumDodaj";
            this.AlbumDodaj.Size = new System.Drawing.Size(75, 23);
            this.AlbumDodaj.TabIndex = 8;
            this.AlbumDodaj.Text = "Dodaj";
            this.AlbumDodaj.UseVisualStyleBackColor = true;
            this.AlbumDodaj.Click += new System.EventHandler(this.AlbumDodaj_Click);
            // 
            // AlbumUsun
            // 
            this.AlbumUsun.Location = new System.Drawing.Point(139, 301);
            this.AlbumUsun.Name = "AlbumUsun";
            this.AlbumUsun.Size = new System.Drawing.Size(75, 23);
            this.AlbumUsun.TabIndex = 9;
            this.AlbumUsun.Text = "Usuń";
            this.AlbumUsun.UseVisualStyleBackColor = true;
            this.AlbumUsun.Click += new System.EventHandler(this.AlbumUsun_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Opcje zdjęcia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 429);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nazwa pliku:";
            // 
            // ZdjecieNazwa
            // 
            this.ZdjecieNazwa.Location = new System.Drawing.Point(89, 426);
            this.ZdjecieNazwa.Name = "ZdjecieNazwa";
            this.ZdjecieNazwa.Size = new System.Drawing.Size(230, 20);
            this.ZdjecieNazwa.TabIndex = 12;
            // 
            // ZdjecieData
            // 
            this.ZdjecieData.Location = new System.Drawing.Point(89, 452);
            this.ZdjecieData.Name = "ZdjecieData";
            this.ZdjecieData.Size = new System.Drawing.Size(230, 20);
            this.ZdjecieData.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 455);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Data:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 481);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Miejsce:";
            // 
            // ZdjecieMiejsce
            // 
            this.ZdjecieMiejsce.Location = new System.Drawing.Point(89, 478);
            this.ZdjecieMiejsce.Name = "ZdjecieMiejsce";
            this.ZdjecieMiejsce.Size = new System.Drawing.Size(230, 20);
            this.ZdjecieMiejsce.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 515);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Opis:";
            // 
            // ZdjecieOpis
            // 
            this.ZdjecieOpis.Location = new System.Drawing.Point(12, 531);
            this.ZdjecieOpis.Name = "ZdjecieOpis";
            this.ZdjecieOpis.Size = new System.Drawing.Size(307, 88);
            this.ZdjecieOpis.TabIndex = 18;
            this.ZdjecieOpis.Text = "";
            // 
            // ZdjecieZapisz
            // 
            this.ZdjecieZapisz.Location = new System.Drawing.Point(224, 626);
            this.ZdjecieZapisz.Name = "ZdjecieZapisz";
            this.ZdjecieZapisz.Size = new System.Drawing.Size(75, 23);
            this.ZdjecieZapisz.TabIndex = 19;
            this.ZdjecieZapisz.Text = "Zapisz";
            this.ZdjecieZapisz.UseVisualStyleBackColor = true;
            this.ZdjecieZapisz.Click += new System.EventHandler(this.ZdjecieZapisz_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(491, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Opcje Albumów";
            // 
            // AlbumNowy
            // 
            this.AlbumNowy.Location = new System.Drawing.Point(494, 28);
            this.AlbumNowy.Name = "AlbumNowy";
            this.AlbumNowy.Size = new System.Drawing.Size(75, 23);
            this.AlbumNowy.TabIndex = 22;
            this.AlbumNowy.Text = "Nowy";
            this.AlbumNowy.UseVisualStyleBackColor = true;
            this.AlbumNowy.Click += new System.EventHandler(this.AlbumNowy_Click);
            // 
            // AlbumEdytuj
            // 
            this.AlbumEdytuj.Location = new System.Drawing.Point(575, 28);
            this.AlbumEdytuj.Name = "AlbumEdytuj";
            this.AlbumEdytuj.Size = new System.Drawing.Size(75, 23);
            this.AlbumEdytuj.TabIndex = 23;
            this.AlbumEdytuj.Text = "Edytuj";
            this.AlbumEdytuj.UseVisualStyleBackColor = true;
            this.AlbumEdytuj.Click += new System.EventHandler(this.AlbumEdytuj_Click);
            // 
            // AlbumZapisz
            // 
            this.AlbumZapisz.Location = new System.Drawing.Point(656, 28);
            this.AlbumZapisz.Name = "AlbumZapisz";
            this.AlbumZapisz.Size = new System.Drawing.Size(75, 23);
            this.AlbumZapisz.TabIndex = 24;
            this.AlbumZapisz.Text = "Zapisz";
            this.AlbumZapisz.UseVisualStyleBackColor = true;
            this.AlbumZapisz.Click += new System.EventHandler(this.AlbumZapisz_Click);
            // 
            // Podglad
            // 
            this.Podglad.Location = new System.Drawing.Point(374, 131);
            this.Podglad.Name = "Podglad";
            this.Podglad.Size = new System.Drawing.Size(864, 486);
            this.Podglad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Podglad.TabIndex = 25;
            this.Podglad.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(339, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Podgląd:";
            // 
            // RamkaLG
            // 
            this.RamkaLG.Location = new System.Drawing.Point(342, 99);
            this.RamkaLG.Name = "RamkaLG";
            this.RamkaLG.Size = new System.Drawing.Size(33, 33);
            this.RamkaLG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RamkaLG.TabIndex = 27;
            this.RamkaLG.TabStop = false;
            // 
            // RamkaL
            // 
            this.RamkaL.Location = new System.Drawing.Point(342, 131);
            this.RamkaL.Name = "RamkaL";
            this.RamkaL.Size = new System.Drawing.Size(33, 486);
            this.RamkaL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RamkaL.TabIndex = 28;
            this.RamkaL.TabStop = false;
            // 
            // RamkaG
            // 
            this.RamkaG.Location = new System.Drawing.Point(374, 99);
            this.RamkaG.Name = "RamkaG";
            this.RamkaG.Size = new System.Drawing.Size(864, 33);
            this.RamkaG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RamkaG.TabIndex = 29;
            this.RamkaG.TabStop = false;
            // 
            // RamkaPD
            // 
            this.RamkaPD.Location = new System.Drawing.Point(1237, 616);
            this.RamkaPD.Name = "RamkaPD";
            this.RamkaPD.Size = new System.Drawing.Size(33, 33);
            this.RamkaPD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RamkaPD.TabIndex = 30;
            this.RamkaPD.TabStop = false;
            // 
            // RamkaD
            // 
            this.RamkaD.Location = new System.Drawing.Point(374, 616);
            this.RamkaD.Name = "RamkaD";
            this.RamkaD.Size = new System.Drawing.Size(864, 33);
            this.RamkaD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RamkaD.TabIndex = 31;
            this.RamkaD.TabStop = false;
            // 
            // RamkaLD
            // 
            this.RamkaLD.Location = new System.Drawing.Point(342, 616);
            this.RamkaLD.Name = "RamkaLD";
            this.RamkaLD.Size = new System.Drawing.Size(33, 33);
            this.RamkaLD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RamkaLD.TabIndex = 32;
            this.RamkaLD.TabStop = false;
            // 
            // RamkaPG
            // 
            this.RamkaPG.Location = new System.Drawing.Point(1237, 99);
            this.RamkaPG.Name = "RamkaPG";
            this.RamkaPG.Size = new System.Drawing.Size(33, 33);
            this.RamkaPG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RamkaPG.TabIndex = 33;
            this.RamkaPG.TabStop = false;
            // 
            // RamkaP
            // 
            this.RamkaP.Location = new System.Drawing.Point(1237, 131);
            this.RamkaP.Name = "RamkaP";
            this.RamkaP.Size = new System.Drawing.Size(33, 486);
            this.RamkaP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RamkaP.TabIndex = 34;
            this.RamkaP.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(840, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Opis albumu";
            // 
            // AlbumOpis
            // 
            this.AlbumOpis.Location = new System.Drawing.Point(843, 30);
            this.AlbumOpis.Name = "AlbumOpis";
            this.AlbumOpis.Size = new System.Drawing.Size(124, 62);
            this.AlbumOpis.TabIndex = 36;
            this.AlbumOpis.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 354);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 37;
            this.label11.Text = "Opcje Ramki";
            // 
            // RamkiLista
            // 
            this.RamkiLista.FormattingEnabled = true;
            this.RamkiLista.Location = new System.Drawing.Point(12, 371);
            this.RamkiLista.Name = "RamkiLista";
            this.RamkiLista.Size = new System.Drawing.Size(206, 21);
            this.RamkiLista.TabIndex = 38;
            this.RamkiLista.SelectedIndexChanged += new System.EventHandler(this.RamkiLista_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(735, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 39;
            this.label12.Text = "Nazwa Albumu";
            // 
            // AlbumNazwaBox
            // 
            this.AlbumNazwaBox.Location = new System.Drawing.Point(737, 28);
            this.AlbumNazwaBox.Name = "AlbumNazwaBox";
            this.AlbumNazwaBox.Size = new System.Drawing.Size(100, 20);
            this.AlbumNazwaBox.TabIndex = 40;
            // 
            // Edytor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.AlbumNazwaBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.RamkiLista);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.AlbumOpis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RamkaP);
            this.Controls.Add(this.RamkaPG);
            this.Controls.Add(this.RamkaLD);
            this.Controls.Add(this.RamkaD);
            this.Controls.Add(this.RamkaPD);
            this.Controls.Add(this.RamkaG);
            this.Controls.Add(this.RamkaL);
            this.Controls.Add(this.RamkaLG);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Podglad);
            this.Controls.Add(this.AlbumZapisz);
            this.Controls.Add(this.AlbumEdytuj);
            this.Controls.Add(this.AlbumNowy);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ZdjecieZapisz);
            this.Controls.Add(this.ZdjecieOpis);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ZdjecieMiejsce);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ZdjecieData);
            this.Controls.Add(this.ZdjecieNazwa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AlbumUsun);
            this.Controls.Add(this.AlbumDodaj);
            this.Controls.Add(this.AlbumNazwa);
            this.Controls.Add(this.AlbumLista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ZrodloLista);
            this.Controls.Add(this.ZatwierdzFolder);
            this.Controls.Add(this.SzukajFolder);
            this.Controls.Add(this.ZrodloSciezka);
            this.Controls.Add(this.label1);
            this.Name = "Edytor";
            this.Text = "Edytor";
            ((System.ComponentModel.ISupportInitialize)(this.Podglad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RamkaLG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RamkaL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RamkaG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RamkaPD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RamkaD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RamkaLD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RamkaPG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RamkaP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ZrodloSciezka;
        private System.Windows.Forms.Button SzukajFolder;
        private System.Windows.Forms.Button ZatwierdzFolder;
        private System.Windows.Forms.ListBox ZrodloLista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox AlbumLista;
        private System.Windows.Forms.Label AlbumNazwa;
        private System.Windows.Forms.Button AlbumDodaj;
        private System.Windows.Forms.Button AlbumUsun;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ZdjecieNazwa;
        private System.Windows.Forms.TextBox ZdjecieData;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ZdjecieMiejsce;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox ZdjecieOpis;
        private System.Windows.Forms.Button ZdjecieZapisz;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button AlbumNowy;
        private System.Windows.Forms.Button AlbumEdytuj;
        private System.Windows.Forms.Button AlbumZapisz;
        private System.Windows.Forms.PictureBox Podglad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox RamkaLG;
        private System.Windows.Forms.PictureBox RamkaL;
        private System.Windows.Forms.PictureBox RamkaG;
        private System.Windows.Forms.PictureBox RamkaPD;
        private System.Windows.Forms.PictureBox RamkaD;
        private System.Windows.Forms.PictureBox RamkaLD;
        private System.Windows.Forms.PictureBox RamkaPG;
        private System.Windows.Forms.PictureBox RamkaP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox AlbumOpis;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox RamkiLista;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox AlbumNazwaBox;
    }
}