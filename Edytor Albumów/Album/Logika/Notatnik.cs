using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Edytor_Albumów.Dane;

namespace Wyswietlacz.Logika
{
    class Notatnik
    {
        private Album Odtworz(FileInfo FI)
        {
            Album Wynik = null;

            string[] dane = null;
            dane = File.ReadAllLines(FI.FullName);

            int l = 0;
            
            while (l < dane.Length & !dane[l + 1].Equals("@"))
            {
                l++;
            }
            string[] opis = new string[l];
            for(l = 0; l < opis.Length; l++)
            {
                opis[l] = dane[l+1];
            }
            

            Wynik = new Album(dane[0], opis);
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
                                    Z.Sciezka = dane[i];
                                    FileInfo File = new FileInfo(Z.Sciezka);
                                    Z.Nazwa = File.Name;
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
                                    R.Rog = dane[i];
                                    faza++;
                                    break;
                                case 5://ścieżka do góry dołu ramki
                                    R.GD = dane[i];
                                    faza++;
                                    break;
                                case 6://ścieżka do lewego prawego boku ramki
                                    R.LP = dane[i];
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


        public Album Odczyt()
        {
            Album Wynik = null;

            FileInfo FI = new FileInfo(@"config.txt");
            if (!FI.Exists)
            {
                Wynik = null;
            }
            else
            {
                Wynik = Odtworz(FI);
            }

            return Wynik;
        }
    }
}
