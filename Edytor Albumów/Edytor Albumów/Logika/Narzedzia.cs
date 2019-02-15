using Edytor_Albumów.Dane;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edytor_Albumów.Logika
{
    class Narzedzia
    {
        public Narzedzia()
        {

        }

        /*
         * Tworzenie nowego folderu
         */
        public void TworzFolder(string sciezka)
        {
            Directory.CreateDirectory(sciezka);
        }

        /*
         * Kopiuje wybrany plik, jak nie istnieje scieżka docelowa to tworzy ją
         */
        public int KopiujPlik(string plik, string cel)
        {
            int kod = 0;

            if (Directory.Exists(cel))
            {
                if (File.Exists(plik))
                {
                    FileInfo FI = new FileInfo(plik);
                    string nazwa = FI.Name;
                    File.Copy(plik, cel + "\\" + nazwa, true);
                }
                else
                {
                    kod = 1;
                }
            }
            else
            {
                TworzFolder(cel);
            }

            return kod;
        }

        /*
         * Sprawdzanie czy znak jest cyfrą
         */
        public bool Jestcyfra(char c)
        {
            bool wynik = false;

            switch (c)
            {
                case '0':
                    wynik = true;
                    break;
                case '1':
                    wynik = true;
                    break;
                case '2':
                    wynik = true;
                    break;
                case '3':
                    wynik = true;
                    break;
                case '4':
                    wynik = true;
                    break;
                case '5':
                    wynik = true;
                    break;
                case '6':
                    wynik = true;
                    break;
                case '7':
                    wynik = true;
                    break;
                case '8':
                    wynik = true;
                    break;
                case '9':
                    wynik = true;
                    break;
            }

            return wynik;
        }

        /*
         * Zmienia nazwę pliku
         */
        public void ZmienNazwe(string plik, string nowa)
        {
            FileInfo FI = new FileInfo(plik);
            if (FI.Exists)
            {
                string sciezka = FI.DirectoryName;

                File.Move(plik, sciezka + '\\' + nowa);
            }
            
        }
        /*
         * Określenie czy sprawdzane słowo to miesiąc,
         * tekst musi być napisany małymi literami
         * rozpoznawanie także z lub bez polskich znaków
         * zwraca numery z zakresu <1, 12>
         */
        private int Miech(string m)
        {
            int miech = -1;

            switch (m)
            {
                case "styczeń":
                    miech = 1;
                    break;
                case "styczen":
                    miech = 1;
                    break;
                case "luty":
                    miech = 2;
                    break;
                case "marzec":
                    miech = 3;
                    break;
                case "kwiecień":
                    miech = 4;
                    break;
                case "kiwecien":
                    miech = 4;
                    break;
                case "maj":
                    miech = 5;
                    break;
                case "czerwiec":
                    miech = 6;
                    break;
                case "lipiec":
                    miech = 7;
                    break;
                case "sierpień":
                    miech = 8;
                    break;
                case "sierpien":
                    miech = 8;
                    break;
                case "wrzesień":
                    miech = 9;
                    break;
                case "wrzesien":
                    miech = 9;
                    break;
                case "październik":
                    miech = 10;
                    break;
                case "pazdziernik":
                    miech = 10;
                    break;
                case "listopad":
                    miech = 11;
                    break;
                case "grudzień":
                    miech = 12;
                    break;
                case "grudzien":
                    miech = 12;
                    break;
            }

            return miech;
        }

        /*
         * Określenie daty na podstawie podanej scieżki
         */
        private string OkreslDate(string sciezka)
        {
            string data = "";
            int miesiac = -1, rok = -1;//zmienne zapamiętujące date
            int licznik = 0;
            DateTime DataUtworzenia = File.GetCreationTime(sciezka);

            //analiza danego ciągu (sciezki do pliku)
            //przygotowanie tablicy z nazwami - liczenie rozmairu
            char[] s = sciezka.ToCharArray();
            int j = 0;
            licznik = 0;
            while (j < s.Length)
            {
                if (s[j] == '\\' || s[j] == ' ')
                {
                    licznik++;
                }
                j++;
            }

            string[] nazwy = new string[licznik];

            //przygotowanie tablicy z nazwami - wypełnienie tablicy
            j = 0;
            licznik = -1;//określa która nazwa aktualnie jest dodawana do tablicy
            while (j < s.Length)
            {
                if (licznik >= 0 && s[j] != '\\' && s[j] != ' ')
                {
                    //dla pustego elementu talicy
                    if (nazwy[licznik] == null)
                    {
                        nazwy[licznik] = "" + s[j];
                    }
                    else//dopisanie znaku do słowa
                    {
                        nazwy[licznik] = nazwy[licznik] + s[j];
                    }
                }

                if (s[j] == '\\' || s[j] == ' ')
                {
                    licznik++;
                }

                j++;
            }

            //określanie daty na podstawie nazw folderów
            //data w formacie dzien-miesiac
            for (int i = 0; i < nazwy.Length; i++)
            {
                char[] naz = nazwy[i].ToCharArray();
                if (Jestcyfra(naz[0]))
                {
                    if (naz.Length == 5)
                    {
                        //sprawdzenie czy jest układ cc-cc lub cc.cc (c - cyfra)
                        if (Jestcyfra(naz[1]) && Jestcyfra(naz[3]) && Jestcyfra(naz[4]) && (naz[2] == '-' || naz[2] == '.'))
                        {
                            string dz = "" + naz[0] + naz[1];
                            int dzi = Convert.ToInt32(dz);
                            string mi = "" + naz[3] + naz[4];
                            int mie = Convert.ToInt32(mi);
                            if (dzi > 0 && dzi < 32 && mie > 0 && mie < 13)
                            {
                                data = nazwy[i];
                                i = nazwy.Length;
                            }
                        }
                    }
                    else
                    {
                        if (naz.Length == 4)
                        {
                            //sprawdzenie czy jest układ c-cc lub c.cc (c - cyfra)
                            if (Jestcyfra(naz[2]) && Jestcyfra(naz[3]) && (naz[1] == '-' || naz[1] == '.'))
                            {
                                string dz = "" + naz[0];
                                int dzi = Convert.ToInt32(dz);
                                string mi = "" + naz[2] + naz[3];
                                int mie = Convert.ToInt32(mi);
                                if (dzi > 0 && dzi < 32 && mie > 0 && mie < 13)
                                {
                                    data = nazwy[i];
                                    i = nazwy.Length;
                                }
                            }
                        }
                    }

                }
            }

            //miesiac
            for (int i = 0; i < nazwy.Length; i++)
            {
                int m = Miech(nazwy[i]);
                if (m != -1)
                {
                    miesiac = m;
                    i = nazwy.Length;
                }
            }

            //rok
            for (int i = 0; i < nazwy.Length; i++)
            {
                char[] r = nazwy[i].ToCharArray();
                if (r.Length == 4)
                {
                    if (Jestcyfra(r[0]) && Jestcyfra(r[1]) && Jestcyfra(r[2]) && Jestcyfra(r[3]))
                    {
                        rok = Convert.ToInt32(nazwy[i]);
                    }
                }
            }

            //określanie daty - miesiąc i dzień
            //jeśli określona jest data i miesiąc
            if (!data.Equals("") && miesiac != -1)
            {
                int m = 0;
                if (data.Length == 5)
                {
                    m = Convert.ToInt32(data.ElementAt(3) + data.ElementAt(4));
                }
                else
                {
                    m = Convert.ToInt32(data.ElementAt(2) + data.ElementAt(3));
                }
                if (m > miesiac)
                {
                    data = "" + miesiac.ToString();
                }
                else
                {
                    miesiac = m;
                }
            }
            else
            {
                //data jest określona to nic nie robi bo jest ok
                //jeśli miesiąc to wpisz do daty
                if (miesiac != -1)
                {
                    data = "" + miesiac.ToString();
                }
            }

            //dopisanie roku jeśli jest określony
            if (rok != -1)
            {
                data = data + rok.ToString();
            }

            //określenie końcowej daty
            //jeśli określony rok jest późniejszy niż data utworzenia
            if (rok > DataUtworzenia.Year)
            {
                data = "" + DataUtworzenia.Day + "-" + DataUtworzenia.Month + "-" + DataUtworzenia.Year;
            }
            else
            {
                //ten sam rok
                if (rok == DataUtworzenia.Year && miesiac < DataUtworzenia.Month)
                {
                    data = "" + DataUtworzenia.Day + "-" + DataUtworzenia.Month + "-" + DataUtworzenia.Year;
                }
            }

            return data;
        }

        /*
         * 
         */
        private Zdjecie AnalizujZdjecia(string sciezka)
        {
            Zdjecie wynik = null;

            char[] c = sciezka.ToCharArray();
            string s = "";
            int i = 0;
            c[i] = ' ';
            for (i = 0; i < c.Length; i++)
            {
                if(c[i] == '\\' || c[i] == ':' || c[i] == '_')
                {
                    c[i] = ' ';
                }
                s = s + c[i];
            }

            DateTime DT = File.GetLastWriteTime(sciezka);
            FileInfo FI = new FileInfo(sciezka);
            wynik = new Zdjecie(sciezka, DT.ToString());
            wynik.Nazwa = FI.Name;
            wynik.Opis = s;


            return wynik;
        }
        
        /*
         * Analiza Zdjęć na podanej scieżce do folderu
         */
        public List<Zdjecie> AnalizujDane(string sciezka)
        {
            List<Zdjecie> Zdjecia = new List<Zdjecie>();
            string[] pliki = PobierzSciezki(sciezka, "*.jpg");
            if (pliki != null)
            {
                int i = 0;
                for (i = 0; i < pliki.Length; i++)
                {

                    Zdjecie Z = AnalizujZdjecia(pliki[i]);
                    Zdjecia.Add(Z);
                }
            }
            return Zdjecia;
            
        }

        /*
         * Pobiera wszystkie ściezki do plików obrazu
         * rozszerzenie to string w formacie "*. jpg" lub "*.txt"
         */
        public string[] PobierzSciezki(string sciezka, string rozszezenie)
        {
            string[] wynik = new string[1] ;
            try
            {
                wynik = Directory.GetFiles(@sciezka, rozszezenie, SearchOption.AllDirectories);
                long licznik = 0;
                foreach (string s in wynik)
                {
                    FileInfo FI = new FileInfo(s);
                    licznik += FI.Length;
                }
                Console.WriteLine("Znaleziono: " + wynik.Length + " plików i folderów");
                //liczenie rozmiaru folderu - licznik jest w bajtach => licznik/1024 to kB a licznik/1024/1024 to MB
                licznik = licznik / 1024 / 1024 / 1034;
                Console.WriteLine("Rozmiar: " + licznik + " GB");
                
            }
            catch (ArgumentNullException ANE)
            {
                wynik = null;
                MessageBox.Show("Agrument=NULL", "Błąd Ścieżki");
            }
            catch (DirectoryNotFoundException DNFE)
            {
                wynik = null;
                MessageBox.Show("Nie znaleziono folderu.", "Błąd Ścieżki");
            }
            catch (ArgumentException AE)
            {
                wynik = null;
                MessageBox.Show("Nieprawodłowa ścieżka.", "Błąd Ścieżki");
            }

            return wynik;
        }

        public Album OdtworzAlbum(string[] dane, string sciezka)
        {
            int l = 1;
            while (l < dane.Length & !dane[l + 1].Equals("@"))
            {
                l++;
            }
            string[] opis = new string[l];
            for (l = 0; l < opis.Length; l++)
            {
                opis[l] = dane[l + 1];
            }


            Album Wynik = new Album(dane[0], opis);
            if (dane.Length > l)
            {

                int i = l + 2;
                Zdjecie Z = null;
                for (i = l + 2; i < dane.Length; i++)
                {
                    if (dane[i].Equals(";"))
                    {
                        i = i + 1;
                        Z = new Zdjecie();
                        Ramka R = new Ramka();
                        int faza = 0;
                        while (!dane[i].Equals("@"))
                        {
                            switch (faza)
                            {
                                case 0://sciezka do zdjęcia
                                    Z.Sciezka = sciezka + '\\' + dane[i];
                                    FileInfo FI = new FileInfo(Z.Sciezka);
                                    Z.Nazwa = FI.Name;
                                    faza++;
                                    break;
                                case 1://data
                                    Z.Data = dane[i];
                                    faza++;
                                    break;
                                case 2://miejsce
                                    Z.Miejsce = dane[i];
                                    faza++;
                                    break;
                                case 3://nazwa ramki
                                    R.Nazwa = dane[i];
                                    faza++;
                                    break;
                                case 4://scieżka do rogu ramki
                                    R.Rog = sciezka + '\\' + dane[i];
                                    faza++;
                                    break;
                                case 5://ścieżka do góry dołu ramki
                                    R.GD = sciezka + '\\' + dane[i];
                                    faza++;
                                    break;
                                case 6://ścieżka do lewego prawego boku ramki
                                    R.LP = sciezka + '\\' + dane[i];
                                    Z.Rama = R;
                                    faza++;
                                    break;
                                case 7://opis zdjęcia
                                    Z.Opis = Z.Opis + dane[i] + '\n';
                                    break;
                            }
                            i = i + 1;
                        }
                        Wynik.DodajZdjecie(Z);
                        Z = null;
                    }
                }
            }

            return Wynik;
        }
    }
}
