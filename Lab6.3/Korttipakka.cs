using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6._3
{
    class Korttipakka
    {
        public List<Kortti> Kortit;

        public Korttipakka()
        {
            Kortit = new List<Kortti>();
        }

        public override string ToString()
        {
            int numero = 1;
            string retval = "";
            foreach (Kortti item in Kortit)
            {
                retval += numero + " " + item.ToString() + "\n";
                numero++;
            }
            return retval;
        }

    }
}
