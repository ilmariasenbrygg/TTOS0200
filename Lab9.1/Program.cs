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
            int a = 0, b = 0, c=0,d=0,e=0,f=0;
            
            Random noppa = new Random();


            Console.WriteLine("Kuinka monta kertaa haluat heittää noppaa?");
            int kerrat = int.Parse(Console.ReadLine());

            for (int i = 0; i < kerrat; i++)
            {
                int dice = noppa.Next(1, 7);
                summa += dice;
                if(dice == 1)
                {
                    a++;
                }
                if (dice == 2)
                {
                    b++;
                }
                if (dice == 3)
                {
                    c++;
                }
                if (dice == 4)
                {
                    d++;
                }
                if (dice == 5)
                {
                    e++;
                }
                if (dice == 6)
                {
                    f++;
                }
            }
            Console.WriteLine("Noppaa on nyt heitetty {0} kertaa", kerrat);
            float keskiarvo =(1.0F* summa / kerrat);
            Console.WriteLine("Noppalukujen keskiarvo {0}", keskiarvo);
            Console.WriteLine("Noppalukujen lukumäärät:\n Ykkösiä({0})\n Kakkosia({1})\n Kolmosia({2})\n Nelosia({3})\n Vitosia({4})\n Kutosia({5})\n", a, b, c, d, e, f);
        }
    }
}
