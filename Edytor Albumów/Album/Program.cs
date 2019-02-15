using Wyswietlacz.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wyswietlacz.Logika;
using Edytor_Albumów.Dane;
using System.IO;

namespace Wyswietlacz
{
    class Program
    {
        static void Main(string[] args)
        {
            Notatnik Notka = new Notatnik();
            Album A = Notka.Odczyt();
            if (A == null)
            {
                MessageBox.Show("Nie znaleziono poprawnej konfiguracji", "Błąd");
            }
            else
            {
                bool spr = true;
                foreach (Zdjecie Z in A.Zdjecia)
                {
                    if (spr == true)
                    {
                        FileInfo FI = new FileInfo(Z.Sciezka);
                        spr = FI.Exists;
                    }
                }

                if (spr == true)//są zdjęcia
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new Okno(A));
                }
                else
                {
                    MessageBox.Show("Nie znaleziono poprawnej konfiguracji", "Błąd");
                }

                
            }
        }
    }
}
