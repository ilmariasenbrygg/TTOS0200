using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6._1
{
    class Biisi
    {
        string Nimi { get; set; }
        string Pituus { get; set; }

        public Biisi()
        {

        }
        public Biisi(string nimi, string pituus)
        {
            Nimi = nimi;
            Pituus = pituus;
        }

        public override string ToString()
        {
            return Nimi + ", " + Pituus;
        }

    }
}
