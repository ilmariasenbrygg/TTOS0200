using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9._6
{
    class Tuote
    {
        public string Nimi { get; set; }
        public double Hinta { get; set; }
        public int Määrä { get; set; }
        public double Kokonaishinta { get; set; }



        public Tuote()
        {
        }
        public Tuote(string nimi, double hinta, int määrä)
        {
            Nimi = nimi;
            Hinta = hinta;
            Määrä = määrä;
            Kokonaishinta = hinta *määrä;

        }
        

        public override string ToString()
        {
            return " -" + Nimi + " " + Määrä + " kpl " + Kokonaishinta +"  kokonaishinta";
        }
        

    }
}
