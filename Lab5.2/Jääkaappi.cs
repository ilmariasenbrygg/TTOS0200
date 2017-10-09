using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5._2
{
    class Jääkaappi
    {
        public string Name { get; set; }
        public List<Asia> sisältö;
        //Constructor
        public Jääkaappi()
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
