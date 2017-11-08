using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9._6
{
    class Ostorkärry
    {
        public string Name { get; set; }
        public List<Tuote> sisältö;
        //Constructor
        public Ostorkärry()
        {
            sisältö = new List<Tuote>();

        }
        double Kokojutunhinta()
        {
           return sisältö.Sum(x => x.Kokonaishinta);
        }
        //Ylikirjoitetaan Tostring
        public override string ToString()
        {
            string retval = Name + " sisältö\n";
            foreach (Tuote item in sisältö)
            {
                retval += item.ToString() + "\n";
            }
            return retval += "\n" + Kokojutunhinta();
        }
    }
}
