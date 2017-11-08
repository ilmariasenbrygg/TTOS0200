using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9._3
{
    class Paikka
    {
        public string Kalapaikka { get; set; }
        public string Sijainti { get; set; }
        public Paikka()
        {

        }
        public Paikka(string kalapaikka, string sijainti)
        {
            Kalapaikka = kalapaikka;
            Sijainti = sijainti;
        }
        public override string ToString()
        {
            return Kalapaikka + " joka sijaitsee: " + Sijainti;
        }
    }
}
