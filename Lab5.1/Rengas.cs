using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5._1
{
    class Rengas
    {
        string Merkki { get; set; }
        string Tyyppi { get; set; }
        int Koko { get; set; }

        public Rengas()
        {

        }
        public Rengas(string merkki, string tyyppi, int koko)
        {
            Merkki = merkki;
            Tyyppi = tyyppi;
            Koko = koko;
        }
        public override string ToString()
        {
            return "Merkki> " + Merkki + " Tyyppi>" + Tyyppi + " Koko>" + Koko;
        }
        
    }
}
