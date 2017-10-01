using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._2
{
    class Vene: kulkuneuvo
    {
        public int Istumapaikat { get; set; }
        public string VeneTyyppi { get; set; }

        public Vene()
        {

        }

        public Vene(string nimi, string malli, int vuosimalli, string väri, int istumapaikat, string venetyyppi): base(nimi, malli, vuosimalli, väri)
        {
            Istumapaikat = istumapaikat;
            VeneTyyppi = venetyyppi;

        }

        public override string ToString()
        {
            return base.ToString() + " Istumapaikat:" + Istumapaikat + " VeneTyyppi:" + VeneTyyppi;
        }
    }
}
