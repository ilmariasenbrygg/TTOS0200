using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6._1
{
    class Cd :Biisi
    {
        public string Name { get; set; }
        public string Artisti { get; set; }
        public List<Biisi> Biisit;

        public Cd()
        {
            Biisit = new List<Biisi>();
        }
        public override string ToString()
        {
            string retval =" -Nimi: "+ Name + "\n -Artisti: " + Artisti + "\n -Biisit: \n";
            foreach (Biisi item in Biisit)
            {
                retval +="  -"+ item.ToString() + "\n";
            }
            return retval;
        }
    }
}
