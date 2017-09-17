using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class Lab02
    {
        public class Kiuas
        {
            public int Tila { get; set; }
            public int Teho { get; set; }
            public int kosteus { get; set; }
            public Kiuas(int Tila, int Teho, int kosteus): base()
            {
                this.Tila = Tila;
                this.Teho = Teho;
                this.kosteus = kosteus;
            }
            public Kiuas()
            {
            }
            public string Löylyä(int kertaa)
            {
                string shh = "";
                for (int i = 0; i < kertaa; i++)
                {
                    shh += "SHHHH! ";
                }
                return shh;
            }
        }
        public class KiuasKäyttö
        {
            public static void TestaaKiuas()
            {
                Kiuas munKiuas = new Kiuas();
                Console.WriteLine("Päälle vai pois? 0/1");
                munKiuas.Tila = int.Parse(Console.ReadLine());
                if(munKiuas.Tila == 1)
                {
                    Console.WriteLine("Anna teho. (0,1,2,3,4)");
                    munKiuas.Teho = int.Parse(Console.ReadLine());
                    Console.WriteLine("Anna kosteus. (0-100)");
                    munKiuas.kosteus = int.Parse(Console.ReadLine());
                    Console.WriteLine("Heitetäänkö löylyä?0-10 kertaa.");
                    int a = int.Parse(Console.ReadLine());
                    if( a > 0)
                    {
                        Console.WriteLine(munKiuas.Löylyä(a));
                    }
                    else
                    {
                        Console.WriteLine("Sauna hiipuu..");
                    }
                }
                else
                {
                    Console.WriteLine("Kiuas on pois päältä");
                }
            }
        }
        public static void Tehtava01()
        {
             
        }
    }
}
