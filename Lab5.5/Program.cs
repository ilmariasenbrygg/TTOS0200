using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Vaatekaappi IsännänJaEmännän = new Vaatekaappi();
            IsännänJaEmännän.Name = "Isännän ja Emännän vaatekaappi";
            IsännänJaEmännän.sisältö.Add(new Vaate("Toppi", "ylähylly", "emännän"));
            IsännänJaEmännän.sisältö.Add(new Vaate("Farkut", "Alahylly", "Isännän"));
            IsännänJaEmännän.sisältö.Add(new Vaate("Nahkahousut", "Vasenkaappi", "emännän"));
            IsännänJaEmännän.sisältö.Add(new Vaate("Leviksen paita", "ylähylly", "emännän"));
            IsännänJaEmännän.sisältö.Add(new Vaate("Champion huppari", "keskitaso", "isäntä"));

            Console.WriteLine("Haluatko 1.Tulostaa vaatekaapin sisällön 2. Lisätä vaatteen?");
            int valinta = int.Parse(Console.ReadLine());
            if (valinta == 1)
            {
                Console.WriteLine(IsännänJaEmännän.ToString());
            }
            else if(valinta == 2)
            {
                Vaate kappale = new Vaate();
                Console.WriteLine("Anna nimi.");
                kappale.Nimi = Console.ReadLine();
                Console.WriteLine("Anna sijainti");
                kappale.Sijainti = Console.ReadLine();
                Console.WriteLine("Kenen");
                kappale.Kenen = Console.ReadLine();
                IsännänJaEmännän.sisältö.Add(kappale);
                Console.WriteLine(IsännänJaEmännän.ToString());
            }
            
        } 
    }
}
