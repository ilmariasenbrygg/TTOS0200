using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opiskelija
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] opiskelijat = new string[2];

            for (int i = 0; i < opiskelijat.Length; i++)
            {
                Opiskelija uusiOpis = new Opiskelija();
                Console.WriteLine("====UUSIOPISKELIJA====");

                Console.WriteLine("Anna nimi>");
                uusiOpis.Nimi = Console.ReadLine();

                Console.WriteLine("Anna ikä>");
                uusiOpis.ikä = int.Parse(Console.ReadLine());

                Console.WriteLine("Anna opiskelijatunnus>");
                uusiOpis.opiskelijatunn = Console.ReadLine();

                Console.WriteLine("Anna sposti>");
                uusiOpis.sposti = Console.ReadLine();

                Console.WriteLine("Anna osoite>");
                uusiOpis.osoite = Console.ReadLine();

                opiskelijat[i] = uusiOpis.Nimi + ", " + uusiOpis.ikä + ", " + uusiOpis.opiskelijatunn + ", " + uusiOpis.sposti + ", " + uusiOpis.osoite;

                //opiskelijat[i] = uusiOpis.tiedot;
            }
            Console.WriteLine("**OPISKELIJOIDEN TIEDOT YHTEENVETONA**");
            for (int i = 0; i < opiskelijat.Length; i++)
            {
                Console.WriteLine("Tiedot> " + opiskelijat[i]);
                Console.WriteLine("====================");
            }

        }
    }
}
