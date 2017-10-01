using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._2
{
    class Pyörä: kulkuneuvo
    {
        public string Vaihteet { get; set; }
        public string VaihteidenMerkki { get; set; }

        public Pyörä()
        {

        }

        public Pyörä(string nimi, string malli, int vuosimalli, string väri, string vaihteet, string vaihteidenMerkki): base(nimi, malli, vuosimalli, väri)
        {
            Vaihteet = vaihteet;
            VaihteidenMerkki = vaihteidenMerkki;

        }

        public override string ToString()
        {
            return base.ToString() + " Vaihteet:" + Vaihteet + " Vaihteiden merkki:" + VaihteidenMerkki;
        }
    }
}
