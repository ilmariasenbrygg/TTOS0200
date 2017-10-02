using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._4
{
    class Kirja: Esine
    {
        public string Kirjoittaja { get; set; }
        public string Genre { get; set; }

        public Kirja()
        {

        }
        public Kirja(string nimi, string malli, string ostopäivämäärä, string takuu, string kirjoittaja, string genre): base(nimi, malli, ostopäivämäärä, takuu)
        {
            Kirjoittaja = kirjoittaja;
            Genre = genre;
        }
        public override string ToString()
        {
            return base.ToString() + " Kirjoittaja:" + Kirjoittaja + " Genre:" + Genre;
        }
    }
}
