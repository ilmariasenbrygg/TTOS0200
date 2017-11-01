using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int summa = 0;
            Random noppa = new Random();


            Console.WriteLine("Kuinka monta kertaa haluat heittää noppaa?");
            int kerrat = int.Parse(Console.ReadLine());

            for (int i = 0; i < kerrat; i++)
            {
                int dice = noppa.Next(1, 7);
                summa += dice;
            }
            Console.WriteLine("Noppaa on nyt heitetty {0} kertaa", kerrat);
            float keskiarvo =(1.0F* summa / kerrat);
            Console.WriteLine("Noppalukujen keskiarvo {0}", keskiarvo);
        }
    }
}
