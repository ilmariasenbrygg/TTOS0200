using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6._3
{
    class Kortti
    {
        public string Maa { get; set; }
        public int Luku { get; set; }

        public Kortti()
        {

        }
        public Kortti(string maa, int luku)
        {
            Maa = maa;
            Luku = luku;
        }
        public override string ToString()
        {
            return "Kortti on " + Maa + "#" + Luku;
        }
    }
}
