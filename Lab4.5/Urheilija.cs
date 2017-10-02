using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._5
{
    class Urheilija
    {
        public string Nimi { get; set; }
        public string Laji { get; set; }
        public int Pituus { get; set; }
        public int Paino { get; set; }
        public string Saavutukset { get; set; }

        public Urheilija()
        {
        }
        public Urheilija(string nimi, string laji, int pituus, int paino, string saavutukset)
        {
            Nimi = nimi;
            Laji = laji;
            Pituus = pituus;
            Paino = paino;
            Saavutukset = saavutukset;
        }
        public override string ToString()
        {
            return "Nimi> " + Nimi + " Laji>" + Laji + " Pituus>" + Pituus + " Paino>" + Paino + "Saavutukset>" + Saavutukset + "!**LAJIKOHTAISET**!";
        }
    }
}
