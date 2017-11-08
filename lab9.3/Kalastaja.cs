using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9._3
{
    class Kalastaja
    {
        public string Nimi { get; set; }
        public string Phnro { get; set; }
        public List<Kala> Kalat;
        

        public Kalastaja()
        {
            Kalat = new List<Kala>();
        }
        public Kalastaja(string nimi, string phnro)
        {
            Nimi = nimi;
            Phnro = phnro;
        }
        public override string ToString()
        {
            return Nimi + " ja puhelinnumero " + Phnro;
        }
    }
}
