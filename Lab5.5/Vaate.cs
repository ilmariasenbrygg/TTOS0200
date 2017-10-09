using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5._5
{
    class Vaate
    {
        public string Nimi { get; set; }
        public string Sijainti { get; set; }
        public string Kenen { get; set; }

        public Vaate()
        {
        }
        public Vaate(string nimi, string sijainti, string kenen)
        {
            Nimi = nimi;
            Sijainti = sijainti;
            Kenen = kenen;
        }
        public override string ToString()
        {
            return Nimi + " on paikassa " + Sijainti +" ja kuuluu: " + Kenen;
        }
    }
}
