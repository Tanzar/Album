using Edytor_Albumów.Dane;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edytor_Albumów.Logika
{
    class Notatnik
    {
        private string Sciezka;
        private StreamWriter SW;
        private FileInfo FI;

        public Notatnik()
        {
            this.Sciezka = "";
            this.SW = null;
            this.FI = null;
        }

        /*
         * Sprawdzenie pliku konfiguracyjnego albumu, zwraca:
         * 0 - zapis
         * 1 - edycja
         * 2 - błąd, niepowodzenie
         */
        public int Otworz(string Sciezka)
        {
            int kod = 2;

            this.FI = new FileInfo(Sciezka);
            if (!this.FI.Exists)
            {
                kod = 0;
                this.Sciezka = Sciezka;
            }
            else
            {
                kod = 1;
                this.Sciezka = Sciezka;
                
            }

            return kod;
        }

        /*
         *Odczyt istniejącego pliku, zwraca
         * wszytkiego co plik zawiera
         * lub null jak nie znajdzie pliku, lub nie wywołano Otworz()
         */
        public string[] Odczyt()
        {
            string[] tekst = null;

            if(this.Sciezka != "")
            {
                tekst = File.ReadAllLines(this.Sciezka);
                this.Sciezka = "";
                this.SW = null;
                this.FI = null;
            }

            return tekst;
        }

        /*
         * Zapis albumu do pliku konfiguracyjnego, zamyka plik po zakończeniu, zwraca
         * 0 - powodzenie
         * 1 - błąd, nie wywołano Otworz()
         * 2 - nieautoryzowany dostęp
         */
        public int ZapiszAlbum(Album A, string folder)
        {
            int kod = 0;

            if (this.Sciezka != "" && folder != "")
            {
                try
                {
                    //kopiowanie danych
                    Narzedzia Narz = new Narzedzia();
                    Narz.TworzFolder(folder + '\\' + "Zdjęcia");


                    //zapis konfiguracji
                    this.SW = this.FI.AppendText();
                    SW.WriteLine(A.Nazwa);
                    int i = 0;
                    for(i = 0; i < A.Opis.Length; i++)
                    {

                        SW.WriteLine(A.Opis[i]);
                    }
                    SW.WriteLine("@");
                    foreach (Zdjecie Z in A.Zdjecia)
                    {
                        SW.WriteLine(";");
                        Narz.KopiujPlik(Z.Sciezka, folder + '\\' + "Zdjęcia");
                        FI = new FileInfo(Z.Sciezka);
                        Z.Sciezka = "Zdjęcia" + '\\' + Z.Nazwa;
                        Narz.ZmienNazwe(folder + '\\' + "Zdjęcia" + '\\' + FI.Name, Z.Nazwa + ".JPG");
                        SW.WriteLine(Z.Sciezka + ".JPG");
                        SW.WriteLine(Z.Data);
                        SW.WriteLine(Z.Miejsce);
                        SW.WriteLine(Z.Rama.Nazwa);
                        SW.WriteLine(Z.Rama.Rog);
                        SW.WriteLine(Z.Rama.GD);
                        SW.WriteLine(Z.Rama.LP);
                        SW.WriteLine(Z.Opis);
                        SW.WriteLine("@");
                    }
                    SW.Close();
                    this.Sciezka = "";
                    this.SW = null;
                    this.FI = null;
                }
                catch (UnauthorizedAccessException UAE)
                {
                    kod = 2;
                }
            }
            else
            {
                kod = 1;
            }

            return kod;
        }
    }
}
