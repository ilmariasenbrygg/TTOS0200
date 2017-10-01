using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pyörä pyörä1 = new Pyörä();
            pyörä1.Nimi = "Tunturi";
            pyörä1.Malli = "Mummopyörä";
            pyörä1.Vuosimalli = 1989;
            pyörä1.Väri = "Musta";
            pyörä1.Vaihteet = "Ei";
            pyörä1.VaihteidenMerkki = "-";
            Console.WriteLine(pyörä1.ToString());

            Pyörä pyörä2 = new Pyörä("Jopo", "rento", 2002, "Punainen", "Ei", "-");
            Console.WriteLine(pyörä2.ToString());

            Vene vene1 = new Vene();
            vene1.Nimi = "Suvi";
            vene1.Malli = "S750";
            vene1.Vuosimalli = 2005;
            vene1.Väri = "Valkoinen";
            vene1.Istumapaikat = 4;
            vene1.VeneTyyppi = "Soutuvene";
            Console.WriteLine(vene1.ToString());

            Vene vene2 = new Vene("Metso", "670", 2011, "Musta", 7, "Huvivene");
            Console.WriteLine(vene2.ToString());

        }
    }
}
