using Edytor_Albumów.Dane;
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

namespace Wyswietlacz.UI
{
    public partial class Okno : Form
    {
        private Album A;
        private int index;
        private List<Ramka> Ramki;

        public Okno()
        {
            
            this.A = null;
            this.index = -1;
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Obraz.Image = Image.FromFile("Dane\\okladka.jpg");
            this.AlbumNazwa.Text = A.Nazwa;
            this.ZdjecieData.Text = "";
            this.ZdjecieMiejsce.Text = "";
            this.ZdjecieOpis.Clear();
            this.ZdjecieOpis.BorderStyle = BorderStyle.None;
            this.ZdjecieOpis.ReadOnly = true;
            int i = 0;
            for(i = 0; i < A.Opis.Length; i++)
            {
                this.AlbumOpis.AppendText(A.Opis[i] + Environment.NewLine);
            }
            this.AlbumOpis.BorderStyle = BorderStyle.None;
        }

        public Okno(Album A)
        {
            this.A = A;
            this.index = -1;
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Obraz.Image = Image.FromFile("Dane\\okladka.jpg");
            this.AlbumNazwa.Text = A.Nazwa;
            this.ZdjecieData.Text = "";
            this.ZdjecieMiejsce.Text = "";
            this.ZdjecieOpis.Clear();
            this.ZdjecieOpis.BorderStyle = BorderStyle.None;
            this.ZdjecieOpis.ReadOnly = true;
            int i = 0;
            for (i = 0; i < A.Opis.Length; i++)
            {
                this.AlbumOpis.AppendText(A.Opis[i] + Environment.NewLine);
            }
            this.AlbumNazwa.BackColor = Color.White;
            this.AlbumOpis.BackColor = Color.White;
            this.AlbumOpis.BorderStyle = BorderStyle.None;
        }

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

        private void Domyslne()
        {
            this.Obraz.Size = new Size(895, 434);
            this.RamkaD.Width = 895;
            this.RamkaG.Width = 895;
            this.RamkaP.Location = new Point(939, 85);
            this.RamkaPD.Location = new Point(939, 518);
            this.RamkaPG.Location = new Point(939, 53);
            this.Obraz.Image = Image.FromFile("Dane\\okladka.jpg");
        }

        private void ZmienRozmiar(int wz, int hz)
        {
            double p = (434 * wz) / hz;
            int wp = (int)p;
            if (wp > 895)
            {
                wp = 895;
            }
            this.Obraz.Width = wp;
            this.RamkaD.Width = wp;
            this.RamkaG.Width = wp;
            this.RamkaP.Location = new Point(939 - 895 + wp, 85);
            this.RamkaPD.Location = new Point(939 - 895 + wp, 518);
            this.RamkaPG.Location = new Point(939 - 895 + wp, 53);
        }

        private void Poprzednie_Click(object sender, EventArgs e)
        {
            if(index == 0)
            {
                index = -1;
                Domyslne();
                
                this.AlbumNazwa.Visible = true;
                this.AlbumOpis.Visible = true;
                this.ZdjecieOpis.Clear();
                this.AlbumNazwa.Text = A.Nazwa;
                int i = 0;
                this.ZdjecieData.Text = "";
                this.ZdjecieMiejsce.Text = "";
                this.AlbumOpis.Clear();
                for (i = 0; i < A.Opis.Length; i++)
                {
                    this.AlbumOpis.AppendText(A.Opis[i] + Environment.NewLine);
                }
            }
            else
            {
                if(index -1 < -1)
                {
                    index = -1;
                }
                else
                {
                    //wyświetl obraz
                    index--;
                    this.AlbumNazwa.Visible = false;
                    this.AlbumOpis.Visible = false;
                    Zdjecie Z = A.Zdjecia.ElementAt(index);
                    Image Img = Image.FromFile(Z.Sciezka);
                    ZmienRozmiar(Img.Width, Img.Height);
                    this.Obraz.Image = Img;
                    ZmienRamke(Z.Rama);
                    this.ZdjecieData.Text = Z.Data;
                    this.ZdjecieMiejsce.Text = Z.Miejsce;
                    this.ZdjecieOpis.Clear();
                    this.ZdjecieOpis.Text = Z.Opis;
                }
            }
        }

        private void Nastepne_Click(object sender, EventArgs e)
        {
            if(index == -1)
            {
                index = 0;
                this.AlbumNazwa.Visible = false;
                this.AlbumOpis.Visible = false;
                Zdjecie Z = A.Zdjecia.ElementAt(index);
                Image Img = Image.FromFile(Z.Sciezka);
                ZmienRozmiar(Img.Width, Img.Height);
                this.Obraz.Image = Img;
                ZmienRamke(Z.Rama);
                this.ZdjecieData.Text = Z.Data;
                this.ZdjecieMiejsce.Text = Z.Miejsce;
                this.ZdjecieOpis.Clear();
                this.ZdjecieOpis.Text = Z.Opis;
            }
            else
            {
                if(index + 1 < A.Zdjecia.Count)
                {
                    index++;
                    this.AlbumNazwa.Visible = false;
                    this.AlbumOpis.Visible = false;
                    Zdjecie Z = A.Zdjecia.ElementAt(index);
                    Image Img = Image.FromFile(Z.Sciezka);
                    ZmienRozmiar(Img.Width, Img.Height);
                    this.Obraz.Image = Img;
                    ZmienRamke(Z.Rama);
                    this.ZdjecieData.Text = Z.Data;
                    this.ZdjecieMiejsce.Text = Z.Miejsce;
                    this.ZdjecieOpis.Clear();
                    this.ZdjecieOpis.Text = Z.Opis;
                }
            }
        }
    }
}
