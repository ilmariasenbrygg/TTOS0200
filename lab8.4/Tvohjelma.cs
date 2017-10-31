using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8._4
{
    class Tvohjelma
    {
        public string Nimi { get; set; }
        public string Kanava { get; set; }
        public string Ajankohta { get; set; }
        public string Info { get; set; }

        public Tvohjelma()
        {

        }
        public Tvohjelma(string nimi, string kanava, string ajankohta, string info)
        {
            Nimi = nimi;
            Kanava = kanava;
            Ajankohta = ajankohta;
            Info = info;
        }
        public override string ToString()
        {
            return "Ohjelman nimi: " + Nimi + ", kanava: " + Kanava + ", ajankohta: " + Ajankohta + "ja info:" + Info;
        }
    }
}
