using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Joukkue Tps = new Joukkue();
            Tps.Name = "TPS";
            Tps.pelaajat.Add(new Pelaaja("Teppo Numminen", "Hyökkääjä", "Right", 23));
            Tps.pelaajat.Add(new Pelaaja("Sami Joku", "Puolustaja", "Right", 22));
            Tps.pelaajat.Add(new Pelaaja("Esko Aho", "Hyökkääjä", "Right", 9));

            Console.WriteLine("Anna pelaajan nimi:");
            string Joku = Console.ReadLine();
            Pelaaja o = new Pelaaja();
            o.Nimi = Joku;

            

            
        }
    }
}
