using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._4
{
    class DVD: Esine
    {
        public string Ohjaaja { get; set; }
        public string Päänäyttelijät { get; set; }

        public DVD()
        {

        }
        public DVD(string nimi, string malli, string ostopäivämäärä, string takuu, string ohjaaja, string päänäyttelijät): base(nimi, malli, ostopäivämäärä, takuu)
        {
            Ohjaaja = ohjaaja;
            Päänäyttelijät = päänäyttelijät;
        }
        public override string ToString()
        {
            return base.ToString() + " Ohjaaja:" + Ohjaaja + " Päänäyttelijät:" + Päänäyttelijät;
        }
    }
}
