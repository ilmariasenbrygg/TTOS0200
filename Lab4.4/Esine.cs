using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._4
{
    class Esine
    {
        public string Nimi { get; set; }
        public string Malli { get; set; }
        public string Ostopäivämäärä { get; set; }
        public string Takuu { get; set; }

        public Esine()
        {
        }
        public Esine(string nimi, string malli, string ostopäivämäärä, string takuu)
        {
            Nimi = nimi;
            Malli = malli;
            Ostopäivämäärä = ostopäivämäärä;
            Takuu = takuu;
        }
        public override string ToString()
        {
            return "Nimi> " + Nimi + " Malli>" + Malli + " Ostopäivämäärä>" + Ostopäivämäärä + " Takuu>" + Takuu;
        }
    }
}
