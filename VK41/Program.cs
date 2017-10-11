using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT.MiniAsio
{
    class TestaaMiniAsio
    {
        static void Testaa()
        {
            //luodaan list
            List<Opiskelija> opiskelijat = new List<Opiskelija>();
            //erilaisia tapoja lisätä opiskelijoita
            Opiskelija masa = new Opiskelija("masa", "niemi");
            opiskelijat.Add(masa);
            opiskelijat.Add(new Opiskelija("Allan", "Aalto", "A1245"));
            //myös näin
            opiskelijat.Add(new Opiskelija { Etunimi = "Hanna", Sukunimi = "Husso", AsioID = "H2453"});
            opiskelijat.Add(new Opiskelija { Etunimi = "Hanna", Sukunimi = "Husso", AsioID = "H2453", Ryhmä = "tttv16s69" });
            Opiskelija kalle = new Opiskelija();
            kalle.Etunimi = "Kalle";
            kalle.Sukunimi = "Ankka";
            kalle.AsioID = "k2425";
            opiskelijat.Add(kalle);
            //yhden opiskelija tietojen näyttäminen
            Console.WriteLine("Anna numero väliltä 1-5");
            int i = int.Parse(Console.ReadLine());
            if (i-1 < opiskelijat.Count) {
                Console.WriteLine("MiniASIOn {0} opiskelija on {1}", i, opiskelijat[i-1].ToString());
            }
            else {
                Console.WriteLine("MiniASIOssa on vain {0} opiskelijaa", opiskelijat.Count);

            }
            //Kaikkien opiskelijoiden tiedot
            Console.WriteLine("MiniASIOn kaikki opiskelijat:");
            foreach (var o in opiskelijat)
            {
                Console.WriteLine(o.ToString());
            }
            //Opiskelijat aakkosjärjestyksessä
            opiskelijat.Sort((x,y) => x.Sukunimi.CompareTo(y.Sukunimi));
            Console.WriteLine("MiniASIOn kaikki opiskelijat aakkosjärjestyksessä:");
            foreach (var o in opiskelijat)
            {
                Console.WriteLine(o.ToString());
            }
            //uuden opiskelijan lisääminen
            Console.WriteLine("Anna uuden opiskelijan AsioID");
            string asioid = Console.ReadLine();
            //tutkitaan onko listassa
            bool lippu = false;
            foreach (Opiskelija o in opiskelijat)
            {
                if( asioid == o.AsioID)
                {
                    lippu = true;
                    break;
                }
                if (lippu)
                {
                    Console.WriteLine("AsioID {0} on jo käytössä", asioid);
                }
                else
                {
                    Console.WriteLine("Anna uuden opiskelijan etunimi");
                    string etunimi = Console.ReadLine();
                    Console.WriteLine("ANna sukunimi");
                    string sukunimi = Console.ReadLine();
                    Console.WriteLine("Anna ryhmä");
                    string ryhmä = Console.ReadLine();
                    //lUodaan uusi opiskl olio
                    Opiskelija uusi = new Opiskelija(etunimi, sukunimi, asioid, ryhmä);
                    opiskelijat.Add(uusi);
                    Console.WriteLine("MiniASIOn kaikki opiskelijat:");
                    foreach (var j in opiskelijat)
                    {
                        Console.WriteLine(j.ToString());
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Testaa();
        }
    }
}
