using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._3
{
    class Äänenvoimakkuus
    {
        private readonly int Maxvolume = 9;
        private readonly int Minvolume = 0;

        private int volume;
        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value <= Maxvolume && value >= Minvolume) volume = value;
                else if (value > Maxvolume)
                {
                    Console.WriteLine("Maksimi volume on 9, asetetaan maksimiin.");
                    volume = Maxvolume;
                }
                else if (value < Minvolume)
                {
                    Console.WriteLine("Minimi volume on 0, asetetaan minimiin.");
                    volume = Minvolume;
                }
            }
        }
    }
}
