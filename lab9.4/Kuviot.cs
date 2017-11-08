using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9._4
{
    class Kuviot
    {
        public List<Kuvio> Kuvioita;
        public Kuviot() {
            Kuvioita = new List<Kuvio>();
            Ympyrä ympyrä1 = new Ympyrä();
            Ympyrä ympyrä2 = new Ympyrä();
            Neliö neliö1 = new Neliö();
            Neliö neliö2 = new Neliö();

            ympyrä1.Nimi = "Ympyrä 1 ";
            ympyrä1.r = 2.0;
            ympyrä1.Nimi = "Ympyrä 2 ";
            ympyrä2.r = 2.5;
            neliö1.Nimi = "Neliö 1 ";
            neliö1.a = 3.0;
            neliö1.b = 2.5;
            neliö2.Nimi = "Neliö 2 ";
            neliö2.a = 3.0;
            neliö2.b = 3.0;

            Kuvioita.Add(ympyrä1);
            Kuvioita.Add(ympyrä2);
            Kuvioita.Add(neliö1);
            Kuvioita.Add(neliö2);

            ympyrä1.Pintaala();
            ympyrä1.Ympärysmitta();
            ympyrä2.Pintaala();
            ympyrä2.Ympärysmitta();

            neliö1.Pintaala();
            neliö1.Ympärysmitta();

            neliö2.Pintaala();
            neliö2.Ympärysmitta();




        }
        public override string ToString()
        {
            string retval = "";
            foreach (Kuvio item in Kuvioita)
            {
                retval += item.ToString() + "\n";
            }
            return retval;
        }

    }
}
