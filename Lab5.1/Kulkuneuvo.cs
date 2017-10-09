using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5._1
{
    class Kulkuneuvo: Rengas
    {
        public string Nimi { get; set; }
        public string Malli { get; set; }


        public Kulkuneuvo()
        {
        }
        public Kulkuneuvo(string nimi, string malli)
        {
            Nimi = nimi;
            Malli = malli;
        }
        public override string ToString()
        {
            return "Nimi> " + Nimi + " Malli>" + Malli;
        }
    }
}
