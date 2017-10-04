using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._3
{
    class Radio
    {
        private readonly int Tila = 1;
        private readonly int Maxvolume = 9;
        private readonly int Minvolume = 0;

        private readonly double Maxfrekvenssi = 26000.0;
        private readonly double Minfrekvenssi = 2000.0;

        private double frekvenssi;
        private int volume;
        private int virta;

        public bool Käynnistys(int luku)
        {
            if (luku == Tila)
            {
                virta = luku;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Säädävolumea(int voimakkuus)
        {
            if (voimakkuus >= Minvolume && voimakkuus <= Maxvolume)
            {
                volume = voimakkuus;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Säädätaajuus(double taajuus)
        {
            if (taajuus >= Minfrekvenssi && taajuus <= Maxfrekvenssi)
            {
                frekvenssi = taajuus;
                return true;
            }
            else
            {
                return false;
            }
        }
        public int Virta
        {
            get
            {
                return virta;
            }
        }
        public int Volume
        {
            get
            {
                return volume;
            }
        }
        public double Frekvenssi
        {
            get
            {
                return frekvenssi;
            }
        }

    }
}
