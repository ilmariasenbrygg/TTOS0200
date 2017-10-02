using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._5
{
    class Jalkapalloilija: Urheilija
    {
        public string Seura { get; set; }
        public int Maalit { get; set; }
        public int Syötöt { get; set; }

        public Jalkapalloilija()
        {

        }
        public Jalkapalloilija(string nimi, string laji, int pituus, int paino, string saavutukset, string seura, int maalit, int syötöt): base(nimi, laji, pituus, paino, saavutukset)
        {
            Seura = seura;
            Maalit = maalit;
            Syötöt = syötöt;
        }
        public override string ToString()
        {
            return base.ToString() + " Seura:" + Seura + " Maalit ja syötöt:" + Maalit + " | " + Syötöt;
        }
    }
}
