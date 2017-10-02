using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._5
{
    class Yleisurheilija: Urheilija
    {
        public string Seura { get; set; }
        public string Ennätys { get; set; }


        public Yleisurheilija()
        {

        }
        public Yleisurheilija(string nimi, string laji, int pituus, int paino, string saavutukset, string seura, string ennätys): base(nimi, laji, pituus, paino, saavutukset)
        {
            Seura = seura;
            Ennätys = ennätys;

        }
        public override string ToString()
        {
            return base.ToString() + " Seura:" + Seura + " Ennätys:" + Ennätys;
        }
    }
}
