using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5._5
{
    class Vaatekaappi
    {
        public string Name { get; set; }
        public List<Vaate> sisältö;
        //Constructor
        public Vaatekaappi()
        {
            sisältö = new List<Vaate>();

        }
        //Ylikirjoitetaan Tostring
        public override string ToString()
        {
            string retval = Name + " sisältö\n";
            foreach (Vaate item in sisältö)
            {
                retval += item.ToString() + "\n";
            }
            return retval;
        }
    }
}
