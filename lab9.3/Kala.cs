using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9._3
{
    class Kala
    {
        public string Laji { get; set; }
        public double Paino { get; set; }
        public double Pituus { get; set; }
        public Kala()
        {

        }
        public Kala(string laji, double paino, double pituus)
        {
            Laji = laji;
            Paino = paino;
            Pituus = pituus;
        }
        public override string ToString()
        {
            return Laji + ": " + Paino + " kg ja " + Pituus + " cm.";
        }

    }
}
