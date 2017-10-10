using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5._4
{
    class Lapsi : Ihminen
    {
        public string Vaippa { get; set; }

        public override void Liiku()
        {
            Console.WriteLine("Konttaan");
        }
        public override string ToString()
        {
            return "Lapsi: " + Nimi + " Ikä:" + Ikä + " Pituus: " + Pituus + " Paino:" + Paino + " Vaippa(?)" + Vaippa;
        }
    }
}
