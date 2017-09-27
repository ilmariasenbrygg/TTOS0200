using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class boss : Employee
    {
        public string Auto { get; set; }
        public int Bonus { get; set; }

        public boss()
        {

        }

        public boss( string nimi, string ammatti, int palkka, string auto, int bonus): base(nimi, ammatti, palkka)
        {
            Auto = auto;
            Bonus = bonus;
        }
        public override string ToString()
        {
            return base.ToString() + " Auto:" + Auto + " Bonus:" + Bonus;
        }
    }
}
