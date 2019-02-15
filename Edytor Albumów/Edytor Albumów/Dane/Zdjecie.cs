using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edytor_Albumów.Dane
{
    public class Zdjecie
    {
        public string Nazwa { get; set; }
        public string Sciezka { get; set; }
        public string Data { get; set; }
        public string Miejsce { get; set; }
        public string Opis { get; set; }
        public Ramka Rama { get; set; }

        public Zdjecie()
        {
            this.Sciezka = "";
            this.Data = "";
            this.Miejsce = "";
            this.Opis = "";
        }

        public Zdjecie(string Sciezka)
        {
            this.Sciezka = Sciezka;
            this.Data = "";
            this.Miejsce = "";
            this.Opis = "";
        }

        public Zdjecie(string Sciezka, string Data)
        {
            this.Sciezka = Sciezka;
            this.Data = Data;
            this.Miejsce = "";
            this.Opis = "";
        }
        
    }
}
