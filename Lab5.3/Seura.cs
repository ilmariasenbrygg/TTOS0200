using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5._3
{
    class Seura
    {
        public string Name { get; set; }
        public List<Pelaaja> pelaajat;
        //Constructor
        public Seura()
        {
            pelaajat = new List<Pelaaja>();

        }
        //Ylikirjoitetaan Tostring
        public override string ToString()
        {
            string retval = Name + " sisältö\n";
            foreach (Pelaaja item in pelaajat)
            {
                retval += item.ToString() + "\n";
            }
            return retval;
        }
    }
}
