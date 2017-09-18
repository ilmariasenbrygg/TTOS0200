using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opiskelija
{
    class Opiskelija
    {
        public string Nimi { get; set; }
        public string opiskelijatunn { get; set; }
        public int ikä { get; set; }
        public string sposti { get; set; }
        public string osoite { get; set; }
        public Opiskelija(string Nimi, string opiskelijatunn, int ikä, string sposti, string osoite): base()
            {
            this.Nimi = Nimi;
            this.opiskelijatunn = opiskelijatunn;
            this.ikä = ikä;
            this.sposti = sposti;
            this.osoite = osoite;
            
        }
        public Opiskelija()
        {
        }
        public string tiedot()
        {
            return Nimi + ", " + ikä + ", " + opiskelijatunn + ", " + sposti + ", " + osoite;
        }
    }
}
