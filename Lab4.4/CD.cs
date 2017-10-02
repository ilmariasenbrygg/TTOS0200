using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._4
{
    class CD: Esine
    {
        public string Laulaja { get; set; }
        public int Biisit { get; set; }

        public CD()
        {

        }
        public CD(string nimi, string malli, string ostopäivämäärä, string takuu, string laulaja, int biisit): base(nimi, malli, ostopäivämäärä, takuu)
        {
            Laulaja = laulaja;
            Biisit = biisit;
        }
        public override string ToString()
        {
            return base.ToString() + " Laulaja:" + Laulaja + " Biisien määrä:" + Biisit;
        }
    }
}
