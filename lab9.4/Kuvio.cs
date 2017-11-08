using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9._4
{
    abstract class Kuvio
    {
        public double r;
        public double a;
        public double b;
        public double ala;
        public double ympärys;

        public string Nimi { get; set; }

        public Kuvio()
        {

        }
        public Kuvio(string nimi)
        {
            Nimi = nimi;
        }
        public abstract void Pintaala();
        public abstract void Ympärysmitta();
        



    }
}
