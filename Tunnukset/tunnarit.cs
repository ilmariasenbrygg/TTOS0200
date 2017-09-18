using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tunnukset
{
    class tunnarit
    {
        public string Sivusto { get; set; }
        public string tunnus { get; set; }
        public string salasana { get; set; }
        public string sposti { get; set; }
        public tunnarit(string Sivusto, string tunnus, string sposti, string salasana): base()
            {
            this.Sivusto = Sivusto;
            this.tunnus = tunnus;
            this.salasana = salasana;
            this.sposti = sposti;

        }
        public tunnarit()
        {

        }
    }
}
