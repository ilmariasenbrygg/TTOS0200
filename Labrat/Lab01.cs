using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class Lab01
    {
        public static void Tehtava1()
        {
            int luku;
            Console.Write("Anna luku: ");
            luku = int.Parse(Console.ReadLine());
            Console.WriteLine("Annoit luvun: " + luku);

            if (luku == 1)
            {
                Console.WriteLine("Annoit luvun yksi.");
            }
            if (luku == 2)
            {
                Console.WriteLine("Annoit luvun kaksi.");
            }
            if (luku == 3)
            {
                Console.WriteLine("Annoit luvun kolme.");
            }
            else
            {
                Console.WriteLine("Joku muu luku.");
            }
        }
        public static void Tehtava2()
        {
            int luku;
            Console.Write("Anna pistemäärä: ");
            luku = int.Parse(Console.ReadLine());
            Console.WriteLine("Annoit pistemääräksi: " + luku);

            if (luku >= 0 && luku <= 12)
            {
                if (luku <= 1 && luku >= 0)
                {
                    Console.WriteLine("Sait arvosanaksi 0.");
                }
                if (luku <= 3 && luku >= 2)
                {
                    Console.WriteLine("Sait arvosanaksi 1.");
                }
                if (luku <= 5 && luku >= 4)
                {
                    Console.WriteLine("Sait arvosanaksi 2.");
                }
                if (luku <= 7 && luku >= 6)
                {
                    Console.WriteLine("Sait arvosanaksi 3.");
                }
                if (luku <= 9 && luku >= 8)
                {
                    Console.WriteLine("Sait arvosanaksi 4.");
                }
                if (luku <= 12 && luku >= 10)
                {
                    Console.WriteLine("Sait arvosanaksi 5.");
                }
            }
            else
            {
                Console.WriteLine("Pistemäärä on liian suuri, älä valehtele.");
            }
        }
        public static void Tehtava3()
        {
            int[] luku = new int[3];
            Console.Write("Anna ensimmäinen luku: ");
            luku[0] = int.Parse(Console.ReadLine());
            Console.Write("Anna toinen luku: ");
            luku[1] = int.Parse(Console.ReadLine());
            Console.Write("Anna kolmas luku: ");
            luku[2] = int.Parse(Console.ReadLine());
            int summa = luku[0] + luku[1] + luku[2];
            int keskiarvo = summa / 3;
            Console.WriteLine("Lukujen summa: " + summa);
            Console.WriteLine("Lukujen keskiarvo: " + keskiarvo);
        }
        public static void Tehtava4()
        {
            int luku;
            Console.Write("Anna ikäsi: ");
            luku = int.Parse(Console.ReadLine());
            Console.WriteLine("Annoit iäksesi: " + luku);

            if (luku <= 65)
            {
                if (luku < 0)
                {
                    Console.WriteLine("Ei niitä miinusvuosia saa edes kylmällä kahvilla.");
                }
                if (luku <= 17 && luku >= 0)
                {
                    Console.WriteLine("Alaikäinen.");
                }
                if (luku <= 65 && luku >= 18)
                {
                    Console.WriteLine("Aikuinen.");
                }
            }
            else
            {
                Console.WriteLine("Seniori.");
            }
        }
        public static void Tehtava5()
        {
            int sekuntit = 0;
            int minuutit = 0;
            int tunnit = 0;
            Console.Write("Anna sekuntit: ");
            sekuntit = int.Parse(Console.ReadLine());
            minuutit = sekuntit / 60;
            sekuntit = sekuntit % 60;
            tunnit = minuutit / 60;
            minuutit = minuutit % 60;
            Console.WriteLine("Tunnit: " + tunnit + " Minuutit:" + minuutit + " Sekuntit:" + sekuntit);
        }
        public static void Tehtava6()
        {
            double kilometrit = 0;
            double kulutus = 7.02;
            double LitraHinta = 1.595;
            double bensa = 0;
            double KokoHinta = 0;
            Console.Write("Anna kilometrit: ");
            kilometrit = int.Parse(Console.ReadLine());
            bensa = (kilometrit / 100) * kulutus;
            KokoHinta = bensa * LitraHinta; 
            Console.WriteLine("Bensaa kuluu " + bensa + " ja hintaa kertyy " + KokoHinta +" euroa");
        }
        public static void Tehtava7()
        {
            int vuosi = 0;
            int i;
            Console.Write("Anna vuosi: ");
            vuosi = int.Parse(Console.ReadLine());
            i = vuosi % 4;
            if (i == 0)
            {
                i = vuosi;
                if(i % 400 == 0)
                {
                    Console.WriteLine("Vuosi on karkausvuosi!");
                }
                i = vuosi;
                if( i % 100 == 0)
                {
                    Console.WriteLine("Vuosi ei ole karkausvuosi");
                }
                else
                {
                    Console.WriteLine("Vuosi on karkausvuosi");
                }
            }else
            {
                Console.WriteLine("Vuosi ei ole karkausvuosi");
            }
        }
        public static void Tehtava8()
        {
            int[] luku = new int[4];
            Console.Write("Anna ensimmäinen luku: ");
            luku[0] = int.Parse(Console.ReadLine());
            Console.Write("Anna toinen luku: ");
            luku[1] = int.Parse(Console.ReadLine());
            Console.Write("Anna kolmas luku: ");
            luku[2] = int.Parse(Console.ReadLine());
            if(luku[1] > luku[0])
            {

            }
        }
    }

}
