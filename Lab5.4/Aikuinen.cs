using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5._4
{
    class Aikuinen : Ihminen
    {
        public string Auto { get; set; }

        public override void Liiku()
        {
            Console.WriteLine("Kävelen");
        }
        public override string ToString()
        {
            return "Aikuinen:" + Nimi + " Ikä: " + Ikä + " Auto:" + Auto + " Pituus:" + Pituus + " Paino:" + Paino;
        }
    }
}
