using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5._2
{
    class Asia
    {
        public string Nimi { get; set; }
        public string Sijainti { get; set; }

        public Asia()
        {
        }
        public Asia(string nimi, string sijainti)
        {
            Nimi = nimi;
            Sijainti = sijainti;
        }
        public override string ToString()
        {
            return Nimi + " on paikassa " + Sijainti;
        }
    }
}
