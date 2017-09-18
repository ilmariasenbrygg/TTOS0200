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
        public class Pesukone
        {
            public string pesumuoto { get; set; }
            public int Lämpötila { get; set; }
            public int pesuaika { get; set; }
            public Pesukone(string pesumuoto, int Lämpötila, int pesuaika): base()
            {
                this.pesumuoto = pesumuoto;
                this.Lämpötila = Lämpötila;
                this.pesuaika = pesuaika;
            }
            public Pesukone()
            {
            }
            public string Hyrisee()
            {
                return "Hyrrrrhyrr";
            }
        }
        public class PesukoneKäyttö
        {
            public static void Pesepyykit()
            {
                Pesukone munKone = new Pesukone();
                Console.WriteLine("Pesukone pesumuoto?");
                munKone.pesumuoto = Console.ReadLine();
                
                Console.WriteLine("Anna lämpötila.");
                munKone.Lämpötila = int.Parse(Console.ReadLine());
                Console.WriteLine("Anna pesuaika(tunteina)");
                munKone.pesuaika = int.Parse(Console.ReadLine());

                Console.WriteLine("Koneesi pesumuoto>" + munKone.pesumuoto + " Pesu lämpötila>" + munKone.Lämpötila + " Pesuaika>" + munKone.pesuaika);
                Console.WriteLine("Haluatko jatkaa?1.kyllä 2.ei");
                int i = int.Parse(Console.ReadLine());
                if (i == 1)
                {
                    Console.WriteLine(munKone.Hyrisee());
                }
                else
                {
                    Console.WriteLine("Toiminto peruutettiin.");
                }

            }
        }
        public class Tv
        {
            public int Tila { get; set; }
            public int Kanava { get; set; }
            public int Volume { get; set; }
            public Tv(int Tila, int Kanava, int Volume): base()
            {
                this.Tila = Tila;
                this.Kanava = Kanava;
                this.Volume = Volume;
            }
            public Tv()
            {
            }
            public string Käynnistys() {
                return "Tsup";
            }

        }
        public class TvKäyttö
        {
            public static void Tvkäyttö()
            {
                Tv munTv = new Tv();
                Console.WriteLine("Käynnistetäänkö televisio?0/1");
                munTv.Tila = int.Parse(Console.ReadLine());
                if (munTv.Tila == 1)
                {
                    Console.WriteLine(munTv.Käynnistys());
                    do
                    {
                        Console.WriteLine("Anna kanava.1-10");
                        munTv.Kanava = int.Parse(Console.ReadLine());
                        Console.WriteLine("Säädä äänenvoimakkuutta 1-10");
                        munTv.Volume = int.Parse(Console.ReadLine());

                        Console.WriteLine("Kanava:" + munTv.Kanava + " Volume:" + munTv.Volume);
                        Console.WriteLine("Sammuta televisio painamalla 0 tai vaihda kanavaa.");
                        munTv.Tila = int.Parse(Console.ReadLine());

                    } while (munTv.Tila != 0);
                    Console.WriteLine(munTv.Käynnistys());
                }
            }
        }
    }
}
