using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._2
{
    class kulkuneuvo
    {
        public string Nimi { get; set; }
        public string Malli { get; set; }
        public int Vuosimalli { get; set; }
        public string Väri { get; set; }

        public kulkuneuvo()
        {
        }
        public kulkuneuvo(string nimi, string malli, int vuosimalli, string väri)
        {
            Nimi = nimi;
            Malli = malli;
            Vuosimalli = vuosimalli;
            Väri = väri;

        }
        public override string ToString()
        {
            return "Nimi> " + Nimi + " Malli>" + Malli + " Vuosimalli>" + Vuosimalli + " Väri>" + Väri;
        }
    }
}
