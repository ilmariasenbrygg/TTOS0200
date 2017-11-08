using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9._4
{
    class Ympyrä : Kuvio
    {
        public override void Pintaala()
        {
            ala =Math.PI* r*r;
        }
        public override void Ympärysmitta()
        {
            ympärys =2 *Math.PI*r;
        }
        public override string ToString()
        {
            return Nimi + " Pinta-ala: " + ala + " piiri: " + ympärys;
        }
    }
}
