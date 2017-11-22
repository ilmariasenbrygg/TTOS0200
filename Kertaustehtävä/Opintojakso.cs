using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kertaustehtävä
{
    public class Opintojakso
    {
        string Nimi { get; set; }
        public List<Opiskelija> OP;
        public List<Opettaja> OPE;


        public Opintojakso(string nimi)
        {
            Nimi = nimi;
            OP = new List<Opiskelija>();
            OPE = new List<Opettaja>();
        }
        public override string ToString()
        {
            string retval = Nimi + " sisältö\n";
            retval += "*****Oppilaat*****\n";
            foreach (Opiskelija item in OP)
            {
                retval += item.ToString() + "\n";
            }
            retval += "*****Opettaja*****\n";
            foreach (Opettaja item in OPE)
            {
                retval += item.ToString() + "\n";
            }
            return retval;
        }




    }
}
