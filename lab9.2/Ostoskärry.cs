using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9._2
{
    class Ostoskärry
    {
        public string Name { get; set; }
        public List<Asia> sisältö;
        //Constructor
        public Ostoskärry()
        {
            sisältö = new List<Asia>();

        }
        //Ylikirjoitetaan Tostring
        public override string ToString()
        {
            string retval = Name + " sisältö\n";
            foreach (Asia item in sisältö)
            {
                retval += item.ToString() + "\n";
            }
            return retval;
        }
    }
}
