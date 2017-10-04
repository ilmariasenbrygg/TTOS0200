using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Radionkäyttö();
        }
        static void Radionkäyttö()
        {
            Radio uusiradio = new Radio();

            while (true)
            {
                Console.WriteLine("Radio päälle syöttämällä 1, sammuu kaikilla muilla arvoilla.");
                if (uusiradio.Käynnistys(int.Parse(Console.ReadLine())))
                {
                    Console.WriteLine("Radio on päällä");
                    Console.WriteLine("Anna volumi(0-9);");
                    if (uusiradio.Säädävolumea(int.Parse(Console.ReadLine())))
                    {
                        Console.WriteLine("Volume: " + uusiradio.Volume);
                    }
                    else
                    {
                        Console.WriteLine("Ei mahdollista");
                        Console.WriteLine("Volume: " + uusiradio.Volume);
                    }
                    Console.WriteLine("Anna taajuus(2000.0-26000.0): ");
                    if (uusiradio.Säädätaajuus(Convert.ToDouble(Console.ReadLine())))
                    {
                        Console.WriteLine("Taajuus: " + uusiradio.Frekvenssi);
                    }
                    else
                    {
                        Console.WriteLine("Taajuus ei sovi");
                        Console.WriteLine("Taajuus: " + uusiradio.Frekvenssi);
                    }
                }
                else
                {
                    Console.WriteLine("Radio ei ole päällä");
                }
            }
        }
    }
}
