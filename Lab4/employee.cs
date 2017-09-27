using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Employee
    {
        public string Nimi { get; set; }
        public string Ammatti { get; set; }
        public int Palkka { get; set; }

        public Employee()
        {
        }
        public Employee(string nimi, string ammatti, int palkka)
        {
            Nimi = nimi;
            Ammatti = ammatti;
            Palkka = palkka;

        }
        public override string ToString()
        {
            return Nimi + " Ammatti>" + Ammatti + " Palkka:" + Palkka;
        }
    }
    


}
