using Edytor_Albumów.Dane;
using Edytor_Albumów.Logika;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edytor_Albumów.UI
{
    public partial class Edytor : Form
    {
        Narzedzia Narz;
        Notatnik Notes;
        List<Zdjecie> DaneZrodlowe;
        List<Ramka> Ramki;
        Album Alb;

        public Edytor()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Narz = new Narzedzia();
            Notes = new Notatnik();
            FileInfo FI = new FileInfo("Dane\\BezObrazka.jpg");
            if (FI.Exists)
            {
                this.Podglad.Image = Image.FromFile(@"Dane\BezObrazka.jpg");
                this.Alb = null;
                this.Ramki = new List<Ramka>();
                this.RamkiLista.DropDownStyle = ComboBoxStyle.DropDownList;
                this.DaneZrodlowe = new List<Zdjecie>();
                //ładowanie ramek
                string[] foldery = Directory.GetDirectories("Dane\\");
                foreach (string folder in foldery)
                {
                    FI = new FileInfo(folder + "\\Rog.jpg");
                    if (FI.Exists)
                    {
                        FI = new FileInfo(folder + "\\LP.jpg");
                        if (FI.Exists)
                        {
                            FI = new FileInfo(folder + "\\GD.jpg");
                            if (FI.Exists)
                            {
                                Ramka R = new Ramka();
                                DirectoryInfo DI = FI.Directory;
                                R.Nazwa = DI.Name;
                                R.Rog = folder + "\\Rog.jpg";
                                R.LP = folder + "\\LP.jpg";
                                R.GD = folder + "\\GD.jpg";
                                this.Ramki.Add(R);
                                this.RamkiLista.Items.Add(R.Nazwa);
                            }
                        }
                    }
                }

                if (Ramki.Count != 0)
                {
                    ZmienRamke(Ramki.First());
                    this.RamkiLista.SelectedIndex = 0;
                }
                else
                {
                    WyswietlOkno("Błąd", "Nie znaleziono ramek, program nie będzie działać poprawnie.");
                }
            }
            else
            {
                WyswietlOkno("Błąd", "Nie znaleziono plików programu, wyłącz program.");
            }
        }

        private void WyswietlOkno(string tytul, string opis)
        {
            MessageBox.Show(opis, tytul);
        }

        private void ZmienObraz(string sciezka, Ramka R)
        {
            Image Img = Image.FromFile(sciezka);
            ZmienRozmiar(Img.Width, Img.Height);
            this.Podglad.Image = Img;
            ZmienRamke(R);
        }

        /*
         * Ustawienie domyślnego rozmiaru podglądu
         */
        private void PodgladDonyslnie()
        {
            this.Podglad.Width = 864;
            this.RamkaD.Width = 864;
            this.RamkaG.Width = 864;
            this.RamkaP.Location = new Point(1237, 131);
            this.RamkaPD.Location = new Point(1237, 616);
            this.RamkaPG.Location = new Point(1237, 99);
        }
        /*
         * Zmienia szerokość podglądu
         * wz - szerokość zdjęcia
         * hz - wysokość zdjęcia
         */
        private void ZmienRozmiar(int wz, int hz)
        {
           
            double p = (486 * wz) / hz;
            int wp = (int)p;
            this.Podglad.Width = wp;
            this.RamkaD.Width = wp;
            this.RamkaG.Width = wp;
            this.RamkaP.Location = new Point(1238 - 865 + wp, 131);
            this.RamkaPD.Location = new Point(1238 - 865 + wp, 616);
            this.RamkaPG.Location = new Point(1238 - 865 + wp, 99);
        }

        /*
         * 
         */
        private void ZmienRamke(Ramka R)
        {
            Image RogLG = Image.FromFile(R.Rog);
            Image RogPG = Image.FromFile(R.Rog);
            Image RogPD = Image.FromFile(R.Rog);
            Image RogLD = Image.FromFile(R.Rog);
            Image L = Image.FromFile(R.LP);
            Image P = Image.FromFile(R.LP);
            Image G = Image.FromFile(R.GD);
            Image D = Image.FromFile(R.GD);
            this.RamkaG.Image = G;
            this.RamkaL.Image = L;
            this.RamkaLG.Image = RogLG;
            P.RotateFlip(RotateFlipType.Rotate180FlipY);
            this.RamkaP.Image = P;
            D.RotateFlip(RotateFlipType.Rotate180FlipX);
            this.RamkaD.Image = D;
            RogPG.RotateFlip(RotateFlipType.Rotate180FlipY);
            this.RamkaPG.Image = RogPG;
            RogPD.RotateFlip(RotateFlipType.Rotate90FlipY);
            this.RamkaPD.Image = RogPD;
            RogLD.RotateFlip(RotateFlipType.Rotate180FlipX);
            this.RamkaLD.Image = RogLD;
        }

        private void SzukajFolder_Click(object sender, EventArgs e)
        {
            //otwarcie okna do szukania folderu
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.ZrodloSciezka.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void ZatwierdzFolder_Click(object sender, EventArgs e)
        {
            string sciezka = this.ZrodloSciezka.Text;

            List<Zdjecie> NoweDane = Narz.AnalizujDane(sciezka);

            DaneZrodlowe.AddRange(NoweDane);

            if (NoweDane.Count > 0)
            {
                foreach (Zdjecie Z in NoweDane)
                {
                    this.ZrodloLista.Items.Add(Z.Nazwa);
                    if(Ramki.Count > 0)
                    {
                        Z.Rama = Ramki.First();
                    }
                }
                WyswietlOkno("Powiadomienie", "Wczytywanie zdjęć zakończone, wczytano: " + NoweDane.Count);
            }
        }

        private void ZrodloLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            //wybór zdjęcia na liście
            int index = this.ZrodloLista.SelectedIndex;
            if (index != -1)
            {
                Zdjecie Z = this.DaneZrodlowe.ElementAt(index);
                this.ZdjecieNazwa.Text = Z.Nazwa;
                this.ZdjecieData.Text = Z.Data;
                this.ZdjecieMiejsce.Text = Z.Miejsce;
                this.ZdjecieOpis.Text = Z.Opis;
                this.RamkiLista.SelectedIndex = 0;
                ZmienObraz(Z.Sciezka, Z.Rama);
                this.AlbumLista.ClearSelected();
            }
        }

        private void AlbumLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            //jeśli jest wybrany album do tworzenia/edycji
            if (Alb != null)
            {
                int index = this.AlbumLista.SelectedIndex;
                if (index != -1)
                {
                    Zdjecie Z = this.Alb.Zdjecia.ElementAt(index);
                    this.ZdjecieNazwa.Text = Z.Nazwa;
                    this.ZdjecieData.Text = Z.Data;
                    this.ZdjecieMiejsce.Text = Z.Miejsce;
                    this.ZdjecieOpis.Text = Z.Opis;
                    ZmienObraz(Z.Sciezka, Z.Rama);
                    this.ZrodloLista.ClearSelected();
                }
            }
            else
            {
                WyswietlOkno("Błąd", "Select Album Error");
            }
        }

        private void AlbumDodaj_Click(object sender, EventArgs e)
        {
            if (this.Alb != null)
            {
                int index = this.ZrodloLista.SelectedIndex;
                //jeśli jest cokolwiek wybrane
                if (index != -1)
                {
                    Zdjecie Z = this.DaneZrodlowe.ElementAt(index);
                    Zdjecie Kopia = new Zdjecie();
                    Kopia.Nazwa = Z.Nazwa;
                    Kopia.Data = Z.Data;
                    Kopia.Miejsce = Z.Miejsce;
                    Kopia.Sciezka = Z.Sciezka;
                    Kopia.Opis = Z.Opis;
                    Kopia.Rama = new Ramka();
                    Kopia.Rama.Nazwa = Z.Rama.Nazwa;
                    Kopia.Rama.Rog = Z.Rama.Rog;
                    Kopia.Rama.LP = Z.Rama.LP;
                    Kopia.Rama.GD = Z.Rama.GD;
                    Alb.DodajZdjecie(Kopia);
                    this.AlbumLista.Items.Add(Kopia.Nazwa);
                }
                else
                {
                    WyswietlOkno("Ostrzeżenie", "Nie wybrano zdjęcia.");
                }
            }
            else
            {
                WyswietlOkno("Ostrzeżenie", "Nie utworzono albumu.");
            }
        }

        private void AlbumUsun_Click(object sender, EventArgs e)
        {
            if (this.Alb != null)
            {
                int index = this.AlbumLista.SelectedIndex;
                //jeśli jest cokolwiek wybrane
                if (index != -1)
                {
                    this.Alb.Zdjecia.RemoveAt(index);
                    this.AlbumLista.Items.RemoveAt(index);
                }
                else
                {
                    WyswietlOkno("Ostrzeżenie", "Nie wybrano zdjęcia.");
                }
            }
            else
            {
                WyswietlOkno("Ostrzeżenie", "Nie utworzono albumu.");
            }
        }

        private void ZdjecieZapisz_Click(object sender, EventArgs e)
        {
            //jeśli wybrane zdjęcie ze albumu
            if(this.AlbumLista.SelectedIndex != -1)
            {
                
                this.Alb.Zdjecia.ElementAt(this.AlbumLista.SelectedIndex).Nazwa = this.ZdjecieNazwa.Text;
                this.Alb.Zdjecia.ElementAt(this.AlbumLista.SelectedIndex).Data = this.ZdjecieData.Text;
                this.Alb.Zdjecia.ElementAt(this.AlbumLista.SelectedIndex).Miejsce = this.ZdjecieMiejsce.Text;
                this.Alb.Zdjecia.ElementAt(this.AlbumLista.SelectedIndex).Opis = this.ZdjecieOpis.Text;
                this.Alb.Zdjecia.ElementAt(this.AlbumLista.SelectedIndex).Rama = this.Ramki.ElementAt(this.RamkiLista.SelectedIndex);
                if (!this.AlbumLista.Text.Equals(this.ZdjecieNazwa.Text))
                {
                    this.AlbumLista.Items.Clear();
                    foreach (Zdjecie Z in this.Alb.Zdjecia)
                    {
                        this.AlbumLista.Items.Add(Z.Nazwa);
                    }
                }
                WyswietlOkno("Powiadomienie", "Zmiany zapisane.");
            }
            else
            {
                WyswietlOkno("Ostrzezenie", "Wybierz zdjęcie z albumu");
            }
        }

        private void OknoNowyAlbum()
        {
            NowyAlbum NA = new NowyAlbum();
            if (NA.ShowDialog() == DialogResult.OK)
            {
                this.Alb = NA.A;
                this.AlbumNazwa.Text = "Album: " + this.Alb.Nazwa;
                this.AlbumNazwaBox.Text = this.Alb.Nazwa;
                this.AlbumOpis.Lines = this.Alb.Opis;
                this.AlbumLista.Items.Clear();
            }
        }

        private void AlbumNowy_Click(object sender, EventArgs e)
        {
            if(Alb != null)//jeśli album istnieje
            {
                DialogResult DR = MessageBox.Show("Zapisać aktualny album?", "Ostrzeżenie", MessageBoxButtons.OKCancel);

                if(DR == DialogResult.OK)
                {
                    ZapiszAlbum();
                    OknoNowyAlbum();
                }
                if(DR == DialogResult.Cancel)
                {
                    OknoNowyAlbum();
                }
            }
            else//jeśli nie wybrano wcześniej albumu
            {
                OknoNowyAlbum();
            }
        }

        private void AlbumEdytuj_Click(object sender, EventArgs e)
        {
            string sciezka;
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                sciezka = folderBrowserDialog1.SelectedPath;
                FileInfo FI = new FileInfo(sciezka + "\\config.txt");
                if(FI.Exists == false)
                {
                    WyswietlOkno("Błąd","Nie znaleziono albumu do edycji.");
                }
                else
                {
                    this.Notes.Otworz(FI.FullName);
                    string[] dane = this.Notes.Odczyt();
                    this.Alb = this.Narz.OdtworzAlbum(dane, sciezka);
                    this.AlbumNazwa.Text = "Album: " + dane[0];
                    this.AlbumLista.Items.Clear();
                    foreach(Zdjecie Z in this.Alb.Zdjecia)
                    {
                        this.AlbumLista.Items.Add(Z.Nazwa);
                    }
                    WyswietlOkno("Powiadomienie", "Wczytano album do edycji.");
                }
            }
        }

        private void AlbumZapisz_Click(object sender, EventArgs e)
        {
            if (this.Alb != null)
            {
                ZapiszAlbum();
                WyswietlOkno("Powiadomienie", "Zapisano album");
            }
            else
            {
                WyswietlOkno("Ostrzeżenie", "Nie utworzono/otwarto albumu.");
            }
        }
        
        /*
         * Zapisanie albumu
         */
        private void ZapiszAlbum()
        {
            string sciezka;
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                sciezka = folderBrowserDialog1.SelectedPath;
                if (sciezka.Length < 4)
                {
                    WyswietlOkno("Błąd", "Nieprawidłowa ścieżka");
                }
                else
                {
                    this.Narz.TworzFolder(sciezka + '\\' + this.Alb.Nazwa);
                    this.Narz.TworzFolder(sciezka + '\\' + this.Alb.Nazwa + '\\' + "Dane");
                    this.Narz.KopiujPlik("Dane" + '\\' + "okladka.jpg", sciezka + '\\' + this.Alb.Nazwa + '\\' + "Dane");
                    foreach(Ramka R in Ramki)
                    {
                        this.Narz.TworzFolder(sciezka + '\\' + this.Alb.Nazwa + '\\' + "Dane" + '\\' + R.Nazwa);
                        this.Narz.KopiujPlik("Dane" + '\\' + R.Nazwa + '\\' + "GD.jpg", sciezka + '\\' + this.Alb.Nazwa + '\\' + "Dane" + '\\' + R.Nazwa);
                        this.Narz.KopiujPlik("Dane" + '\\' + R.Nazwa + '\\' + "LP.jpg", sciezka + '\\' + this.Alb.Nazwa + '\\' + "Dane" + '\\' + R.Nazwa);
                        this.Narz.KopiujPlik("Dane" + '\\' + R.Nazwa + '\\' + "Rog.jpg", sciezka + '\\' + this.Alb.Nazwa + '\\' + "Dane" + '\\' + R.Nazwa);
                    }
                    this.Narz.KopiujPlik("Wyswietlacz.exe", sciezka + '\\' + this.Alb.Nazwa);
                    this.Notes.Otworz(sciezka + '\\' + this.Alb.Nazwa + '\\' + "config.txt");
                    this.Alb.Nazwa = this.AlbumNazwaBox.Text;
                    this.Alb.Opis = this.AlbumOpis.Lines;
                    int k = this.Notes.ZapiszAlbum(this.Alb, sciezka + '\\' + this.Alb.Nazwa);
                    if (k == 2)
                    {
                        WyswietlOkno("Błąd", "Nieautoryzowany dostęp.");
                    }
                }
            }
            
        }

        private void RamkiLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.RamkiLista.SelectedIndex;
            if (index != -1)
            {
                ZmienRamke(Ramki.ElementAt(index));
            }
                
        }
    }
}
