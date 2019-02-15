using Edytor_Albumów.Dane;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edytor_Albumów.UI
{
    public partial class NowyAlbum : Form
    {
        private Album Alb;
        
        public Album A
        {
            get { return Alb; }
            set { Alb = value; }
        }

        public NowyAlbum()
        {
            InitializeComponent();
            this.Text = "Nowy Album";
        }

        private void Gotowe_Click(object sender, EventArgs e)
        {
            Alb = new Album(this.Nazwa.Text, this.Opis.Lines);

        }

        private void Anuluj_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
