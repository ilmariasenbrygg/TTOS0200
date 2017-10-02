using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            CD cd = new CD();
            cd.Nimi = "Pikku G valtaa hoodit";
            cd.Laulaja = "Pikku G";
            cd.Malli = "CD";
            cd.Ostopäivämäärä = "23.10.2005";
            cd.Takuu = "-";
            cd.Biisit = 10;
            Console.WriteLine(cd.ToString());


            DVD Dvd = new DVD();
            Dvd.Nimi = "Troija";
            Dvd.Malli = "DVD";
            Dvd.Ostopäivämäärä = "23.10.2005";
            Dvd.Takuu = "-";
            Dvd.Ohjaaja = "En tiiä";
            Dvd.Päänäyttelijät = "Orlando";
            Console.WriteLine(Dvd.ToString());


            Kirja kirja1 = new Kirja();
            kirja1.Nimi = "Eikä yksikään selviytynyt";
            kirja1.Malli = "Kirja";
            kirja1.Ostopäivämäärä = "23.10.2005";
            kirja1.Takuu = "-";
            kirja1.Kirjoittaja = "Johnny Depp";
            kirja1.Genre = "Trilleri";
            Console.WriteLine(kirja1.ToString());
        }
    }
}
