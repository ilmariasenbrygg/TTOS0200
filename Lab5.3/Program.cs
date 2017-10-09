using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Seura Tps = new Seura();
            Tps.Name = "TPS";
            Tps.pelaajat.Add(new Pelaaja("Teppo Numminen", "Hyökkääjä", "Right"));
            Tps.pelaajat.Add(new Pelaaja("Sami Joku", "Puolustaja", "Right"));
            Tps.pelaajat.Add(new Pelaaja("Esko Aho", "Hyökkääjä", "Right"));

            Seura Hifk = new Seura();
            Hifk.Name = "HIFK";
            Hifk.pelaajat.Add(new Pelaaja("Sami Salin", "Hyökkääjä", "Right"));
            Hifk.pelaajat.Add(new Pelaaja("Jou hou", "Hyökkääjä", "Right"));
            Hifk.pelaajat.Add(new Pelaaja("Mika Häkkinen", "Hyökkääjä", "Left"));

            Seura Jokerit = new Seura();
            Jokerit.Name = "Jokerit";
            Jokerit.pelaajat.Add(new Pelaaja("Antti Anttonen", "Hyökkääjä", "Right"));
            Jokerit.pelaajat.Add(new Pelaaja("Antti Mikkonen", "Hyökkääjä", "Right"));
            Jokerit.pelaajat.Add(new Pelaaja("Antti Kaikkonen", "Puolustaja", "Right"));

            Console.WriteLine("Minkä seuran pelaajatiedot haluat tulostaa(valitse numerolla) \n 1.Tps \n 2.Hifk \n 3.Jokerit");
            int valinta = int.Parse(Console.ReadLine());
            if (valinta == 1)
            {
                Console.WriteLine(Tps.ToString());
            }
            else if (valinta == 2)
            {
                Console.WriteLine(Hifk.ToString());
            }
            else if (valinta == 3)
            {
                Console.WriteLine(Jokerit.ToString());
            }
            else
            {
                Console.WriteLine("Ei ole vaihtoehto");
            }

        }
    }
}
