using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9._2
{
    class Asia
    {
        public string Nimi { get; set; }
        public double Hinta { get; set; }

        public Asia()
        {
        }
        public Asia(string nimi, double hinta)
        {
            Nimi = nimi;
            Hinta = hinta;
        }
        public override string ToString()
        {
            return " -" +Nimi + " " + Hinta +" e";
        }
    }
}
