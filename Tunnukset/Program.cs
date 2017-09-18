using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tunnukset
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tunnukset = new string[2];

            for (int i = 0; i < tunnukset.Length; i++)
            {
                tunnarit uusiTunnus = new tunnarit();
                Console.WriteLine("====TUNNUSMUISTIO====");

                Console.WriteLine("Anna sivusto>");
                uusiTunnus.Sivusto = Console.ReadLine();

                Console.WriteLine("Anna tunnus>");
                uusiTunnus.tunnus = Console.ReadLine();

                Console.WriteLine("Anna salasana>");
                uusiTunnus.salasana = Console.ReadLine();

                Console.WriteLine("Anna sposti>");
                uusiTunnus.sposti = Console.ReadLine();

                tunnukset[i] = uusiTunnus.Sivusto + ", " + uusiTunnus.tunnus + ", " + uusiTunnus.salasana + ", " + uusiTunnus.sposti;

                //opiskelijat[i] = uusiOpis.tiedot;
            }
            Console.WriteLine("**KÄYTTÄJÄTUNNUSTEN YHTEENVETO**");
            for (int i = 0; i < tunnukset.Length; i++)
            {
                Console.WriteLine("Tiedot> " + tunnukset[i]);
                Console.WriteLine("====================");
            }
        }
    }
}
