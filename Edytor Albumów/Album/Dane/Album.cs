using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edytor_Albumów.Dane
{
    public class Album
    {
        public string Nazwa { get; set; }
        public List<Zdjecie> Zdjecia { get; set; }
        public string[] Opis { get; set; }

        public Album()
        {
            this.Nazwa = "";
            this.Zdjecia = new List<Zdjecie>();
            this.Opis = new string[1];
        }

        public Album(string Nazwa)
        {
            this.Nazwa = Nazwa;
            this.Zdjecia = new List<Zdjecie>();
            this.Opis = new string[1];
        }

        public Album(string Nazwa, string[] Opis)
        {
            this.Nazwa = Nazwa;
            this.Zdjecia = new List<Zdjecie>();
            this.Opis = Opis;
        }

        public void DodajZdjecie(Zdjecie Z)
        {
            this.Zdjecia.Add(Z);
        }

        public void EdytujZdjecie(Zdjecie Z)
        {
            
        }
    }
}
