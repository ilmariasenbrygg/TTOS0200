using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Jääkiekkoilija jäkis1 = new Jääkiekkoilija();
            jäkis1.Nimi = "Tiki Tikkanen";
            jäkis1.Laji = "Jääkiekko";
            jäkis1.Paino = 120;
            jäkis1.Pituus = 180;
            jäkis1.Saavutukset = "Mm kulta jee";
            jäkis1.Seura = "Tappara";
            jäkis1.Maalit = 690;
            jäkis1.Syötöt = 720;
            Console.WriteLine(jäkis1.ToString());

            Jalkapalloilija jalis1 = new Jalkapalloilija();
            jalis1.Nimi = "Jari Litti Litmanen";
            jalis1.Laji = "Jalkapalllo";
            jalis1.Paino = 85;
            jalis1.Pituus = 180;
            jalis1.Saavutukset = "Mestaruus";
            jalis1.Seura = "Ac Milan";
            jalis1.Maalit = 300;
            jalis1.Syötöt = 400;
            Console.WriteLine(jalis1.ToString());

            Yleisurheilija yleis = new Yleisurheilija();
            yleis.Nimi = "Paavo Nurmi";
            yleis.Laji = "Juoksija";
            yleis.Paino = 60;
            yleis.Pituus = 175;
            yleis.Saavutukset = "Mm kulta";
            yleis.Seura = "Tampe";
            yleis.Ennätys = "3:54;43";
            Console.WriteLine(yleis.ToString());
           
        }
    }
}
