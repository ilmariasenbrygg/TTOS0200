using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6._4
{
    class Pelaaja
    {
        public string Nimi { get; set; }
        public string Pelipaikka { get; set; }
        public string Kätisyys { get; set; }
        public int Numero { get; set; }

        public Pelaaja()
        {
        }
        public Pelaaja(string nimi, string pelipaikka, string kätisyys, int numero)
        {
            Nimi = nimi;
            Pelipaikka = pelipaikka;
            Kätisyys = kätisyys;
            Numero = numero;
        }
        public override string ToString()
        {
            return Nimi + " pelipaikka " + Pelipaikka + " ,kätisyys" + Kätisyys + " ja pelinumero" + Numero;
        }
    }
}
