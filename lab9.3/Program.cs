using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Kalastaja Matti = new Kalastaja();
            Matti.Nimi = "Matti Meikäläinen";
            Matti.Phnro = "050-3456295";
            Console.WriteLine("Kalastaja lisätty: " + Matti.ToString());
            Matti.Kalat.Add(new Kala("Lohi", 3, 56));
            Matti.Kalat.Add(new Kala("Siika", 2, 20));
            Matti.Kalat.Add(new Kala("testi", 4, 40));

            Console.WriteLine("Kalastaja {0} sai kala(t):", Matti.Nimi);
            Console.WriteLine(Matti.Kalat[0]);
            Console.WriteLine(Matti.Kalat[1]);

            Paikka Järvi = new Paikka();
            Järvi.Kalapaikka = "Jyväsjärvi";
            Järvi.Sijainti = "Keski-Suomi";
            Console.WriteLine("-" + Järvi.ToString());
            Console.WriteLine("***********************");


            Console.WriteLine(Matti.ToString() +" kala saalis:");
            Matti.Kalat.Sort((x, y) => y.Paino.CompareTo(x.Paino));
            foreach (var Kala in Matti.Kalat)
            {
                
                Console.WriteLine(Kala);
                
            }
        }
    }
}
