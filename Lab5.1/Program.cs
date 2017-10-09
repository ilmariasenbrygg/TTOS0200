using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5._1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Kulkuneuvo auto = new Kulkuneuvo();
            auto.Nimi = "Audi";
            auto.Malli = "A4";


            Console.WriteLine(auto.ToString());
            Group Audi = new Group();
            Audi.Name = "Audin";
            Audi.renkaat.Add(new Rengas("PIrelli", "Hakkapelitta", 20));
            Audi.renkaat.Add(new Rengas("PIrelli", "Hakkapelitta", 20));
            Audi.renkaat.Add(new Rengas("PIrelli", "Hakkapelitta", 20));
            Audi.renkaat.Add(new Rengas("PIrelli", "Hakkapelitta", 20));
            Console.WriteLine(Audi.ToString());

            Kulkuneuvo mopo = new Kulkuneuvo();
            mopo.Nimi = "Suzuki";
            mopo.Nimi = "PV";

            Console.WriteLine(mopo.ToString());
            Group PV = new Group();
            PV.Name = "PV:n";
            PV.renkaat.Add(new Rengas("Nokia", "Jotain", 12));
            PV.renkaat.Add(new Rengas("Nokia", "Jotain", 12));
            Console.WriteLine(PV.ToString());
        }
    }
}
