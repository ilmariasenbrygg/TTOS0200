using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5._1
{
    class Group
    {
        public string Name { get; set; }
        public List<Rengas> renkaat;
        //Constructor
        public Group()
        {
            renkaat = new List<Rengas>();

        }
        //Ylikirjoitetaan Tostring
        public override string ToString()
        {
            string retval = Name + "renkaat\n";
            foreach (Rengas item in renkaat)
            {
                retval += item.ToString() + "\n";
            }
            return retval;
        }
    }
}
