using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9._4
{
    class Neliö : Kuvio
    {
        public override void Pintaala()
        {
            ala =a * b;
        }
        public override void Ympärysmitta()
        {
            ympärys=2 * a + 2 * b;
        }
        public override string ToString()
        {
            return Nimi + " Pinta-ala:" + ala + " piiri:" + ympärys;
        }
    }
}
