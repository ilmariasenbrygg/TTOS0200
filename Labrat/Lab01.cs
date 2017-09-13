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
            Console.WriteLine("Bensaa kuluu " + bensa + " ja hintaa kertyy " + KokoHinta + " euroa");
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
                if (vuosi % 400 == 0)
                {
                    Console.WriteLine("Vuosi on karkausvuosi!");
                }
                else if (vuosi % 100 == 0)
                {
                    Console.WriteLine("Vuosi ei ole karkausvuosi");
                }
                else
                {
                    Console.WriteLine("Vuosi on karkausvuosi");
                }
            } else
            {
                Console.WriteLine("Vuosi ei ole karkausvuosi");
            }
        }
        public static void Tehtava8()
        {
            int[] luku = new int[3];
            Console.Write("Anna ensimmäinen luku: ");
            luku[0] = int.Parse(Console.ReadLine());
            Console.Write("Anna toinen luku: ");
            luku[1] = int.Parse(Console.ReadLine());
            Console.Write("Anna kolmas luku: ");
            luku[2] = int.Parse(Console.ReadLine());
            if (luku[1] > luku[0])
            {
                luku[0] = luku[1];
                if (luku[2] > luku[0])
                {
                    luku[0] = luku[2];
                    Console.WriteLine("Suurin luku:" + luku[0]);
                }
            }
            if (luku[2] > luku[0])
            {
                luku[0] = luku[2];
                Console.WriteLine("Suurin luku:" + luku[0]);
            }
            else
            {
                Console.WriteLine("Suurin luku:" + luku[0]);
            }

        }
        public static void Tehtava9()
        {
            int luvut = 0;
            while (true)
            {
                Console.WriteLine("Anna luku>");
                int i = int.Parse(Console.ReadLine());
                luvut = luvut + i;
                if (i == 0)
                {
                    break;
                }
            }
            Console.WriteLine("Lukujen summa: " + luvut);
        }
        public static void Tehtava10()
        {
            int[] luvut = { 1, 2, 33, 44, 55, 68, 77, 96, 100 };
            int j = 0;
            for (int i = 0; i < 9;)
            {
                j = luvut[i] % 2;
                if (j == 0)
                {
                    Console.WriteLine("HEP!");
                }
                i++;
            }
        }
        public static void Tehtava11()
        {
            Console.WriteLine("Anna rivienlukumäärä:");
            int b = int.Parse(Console.ReadLine());
            b = b + 1;
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
        public static void Tehtava12()
        {
            int[] luvut = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Anna luku:");
                luvut[i] = int.Parse(Console.ReadLine());
            }
            Array.Reverse(luvut);
            for (int i = 0; i < 5; i++)
            {
                Console.Write(luvut[i] + ", ");
            }
            Console.WriteLine("\n");
        }
        public static void Tehtava13()
        {
            int[] luku = new int[5];
            Console.Write("Anna pisteet: ");
            luku[0] = int.Parse(Console.ReadLine());
            Console.Write("Anna pisteet: ");
            luku[1] = int.Parse(Console.ReadLine());
            Console.Write("Anna pisteet: ");
            luku[2] = int.Parse(Console.ReadLine());
            Console.Write("Anna pisteet: ");
            luku[3] = int.Parse(Console.ReadLine());
            Console.Write("Anna pisteet: ");
            luku[4] = int.Parse(Console.ReadLine());
            int j = 0;
            int i = 0;
            int summa = 0;
            // käytetään muuttujia i, j , d että saadaan for loopit pyörimään oikein.
            for (int k = 0; k < 5; k++)
            {
                if (luku[i] < luku[i + 1])
                {
                    j = luku[i + 1];
                    luku[i + 1] = luku[i];
                    luku[i] = j;
                }
                i++;
                if (luku[i] < luku[i + 1])
                {
                    j = luku[i + 1];
                    luku[i + 1] = luku[i];
                    luku[i] = j;
                }
                i++;
                if (luku[i] < luku[i + 1])
                {
                    j = luku[i + 1];
                    luku[i + 1] = luku[i];
                    luku[i] = j;
                }
                i++;
                if (luku[i] < luku[i + 1])
                {
                    j = luku[i + 1];
                    luku[i + 1] = luku[i];
                    luku[i] = j;
                }
                i = 0;
            }
            for (int d = 0; d < 3; d++)
            {
                summa = luku[d] + summa;
            }
            Console.WriteLine("Kokonaispisteet>" + summa);
        }
        public static void Tehtava14()
        {
            int j;
            int nollat = 0;
            int ykköset = 0;
            int kakkoset = 0;
            int kolmoset = 0;
            int neloset = 0;
            int vitoset = 0;
            Console.WriteLine("Anna opiskelijoiden määrä:");
            j = int.Parse(Console.ReadLine());
            int[] luvut = new int[j];
            for (int i = 0; i < j; i++)
            {
                Console.WriteLine("Anna arvosana 1-5:");
                luvut[i] = int.Parse(Console.ReadLine());
                if (luvut[i] == 0)
                {
                    nollat = nollat + 1;
                }
                if (luvut[i] == 1)
                {
                    ykköset = ykköset + 1;
                }
                if (luvut[i] == 2)
                {
                    kakkoset = kakkoset + 1;
                }
                if (luvut[i] == 3)
                {
                    kolmoset = kolmoset + 1;
                }
                if (luvut[i] == 4)
                {
                    neloset = neloset + 1;
                }
                if (luvut[i] == 5)
                {
                    vitoset = vitoset + 1;
                }
            }
            Console.WriteLine("Arvosanat:");
            Console.Write("0:");
            for (int d = 0; d < nollat; d++)
            {
                Console.Write("*");
            }
            Console.Write("\n 1:");
            for (int d = 0; d < ykköset; d++)
            {
                Console.Write("*");
            }
            Console.Write("\n 2:");
            for (int d = 0; d < kakkoset; d++)
            {
                Console.Write("*");
            }
            Console.Write("\n 3:");
            for (int d = 0; d < kolmoset; d++)
            {
                Console.Write("*");
            }
            Console.Write("\n 4:");
            for (int d = 0; d < neloset; d++)
            {
                Console.Write("*");
            }
            Console.Write("\n 5:");
            for (int d = 0; d < vitoset; d++)
            {
                Console.Write("*");
            }
            Console.Write("\n");
        }
        public static void Tehtava15kesken()
        {
            Console.WriteLine("Anna luku, max 10:");
            int luku = int.Parse(Console.ReadLine());
            luku = luku - 2;
            for (int i = 0; i < luku; i++)
            {
                Console.Write("*");
                if (i >= 0)
                {
                    Console.Write("\n ***");
                }
                if (i >= 1)
                {
                    Console.Write("\n *****");
                }
                if (i >= 2)
                {
                    Console.Write("\n *******");
                }
                if (i >= 3)
                {
                    Console.Write("\n *********");
                }
            }
        }
        public static void Tehtava16()
        {
            Random rnd = new Random();
            int randomi = rnd.Next(1, 100);
            int luku = 0;
            int yritykset = 0;
            do
            {
                Console.WriteLine("Anna luku:");
                luku = int.Parse(Console.ReadLine());
                if (luku > randomi)
                {
                    Console.WriteLine("Luku on pienempi");
                    yritykset++;
                }
                if (luku < randomi)
                {
                    Console.WriteLine("Luku on suurempi");
                    yritykset++;
                }
            } while (luku != randomi); //Ollaan do:n sisällä niin kauan kun luku veikkaus on eri kuin randomi.
            Console.WriteLine("Arvasit luvun oikein " + yritykset + " yrityksellä!");
        }
        public static void Tehtava17kesken()
        {
            int[] luvut = { 10, 20, 30, 40, 50 };
            int[] luvut2 = { 5, 15, 25, 35, 45 };
        }
        public static void Tehtava18()
        {
            string merkkijono;
            Console.WriteLine("Anna merkkijono");
            merkkijono = Console.ReadLine();

            char[] array = merkkijono.ToCharArray(); //Annettu sana taulukoksi

            for (int i = 0; i < array.Length; i++)
            {
                char letter = array[i]; //Kirjaimet taulukon paikkoihin
            }
            Array.Reverse(array); //kääntö
            string käännetty = new string(array);//Muunnos takaisin
            if (merkkijono == käännetty) //Vertailu
            {
                Console.WriteLine("Palindromi");
            }
            else
            {
                Console.WriteLine("Ei palindromi");
            }
        }
        public static void Tehtava19()
        {
            string sana = "pelti";
            char[] arvaus = new char[sana.Length];

            int yritykset = 0;
            for (int i = 0; i < arvaus.Length; i++)
            {
                arvaus[i] = '_';
            }
            int luku = 0;
            Console.WriteLine("Tervetuloa hirsipuuhun");
            do 
            {
                Console.WriteLine("Anna kirjain"); 
                char input = Console.ReadLine().ToCharArray()[0];
                yritykset++;
                for (int i = 0; i < sana.Length; i++)
                {
                    if (sana[i] == input)
                    {
                        luku++;
                        
                        arvaus[i] = input;

                        for (int h = 0; h < arvaus.Length; h++)
                        {
                            Console.Write(arvaus[h] + " ");
                        }
                    }
                    

                }
            } while (luku < arvaus.Length);
            Console.WriteLine("Voitit pelin " + yritykset +" yrityksellä");
        }

        public static void Tehtava20()
        {
            double kilometrit = 0;
            double Bmwkulutus = 7.02;
            double mopokulutus = 4.5;
            double kauppakassikulutus = 6.0;
            double LitraHinta = 1.595;
            double bensa = 0;
            double kokobensa = 0;
            double KokoHinta = 0;
            int ajoneuvo;
            do
            {
                Console.WriteLine("Perheen bensan kulutuslaskuri.");
                Console.WriteLine("Anna ajoneuvo(1.Mopo, 2.kauppakassi tai 3.bmw, syötä lukuna) lopeta nollalla:");
                ajoneuvo = int.Parse(Console.ReadLine());
                if (ajoneuvo == 1)
                {
                    Console.Write("Anna kilometrit: ");
                    kilometrit = int.Parse(Console.ReadLine());
                    bensa = (kilometrit / 100) * mopokulutus;
                    kokobensa = bensa + kokobensa;
                }
                else if (ajoneuvo == 2)
                {
                    Console.Write("Anna kilometrit: ");
                    kilometrit = int.Parse(Console.ReadLine());
                    bensa = (kilometrit / 100) * kauppakassikulutus;
                    kokobensa = bensa + kokobensa;
                }
                else if (ajoneuvo == 3)
                {
                    Console.Write("Anna kilometrit: ");
                    kilometrit = int.Parse(Console.ReadLine());
                    bensa = (kilometrit / 100) * Bmwkulutus;
                    kokobensa = bensa + kokobensa;
                }
                else if (ajoneuvo == 0)
                {
                    Console.WriteLine("Lopputulos");
                }
                else
                {
                    Console.WriteLine("Syötit väärin.");
                }
            } while (ajoneuvo != 0);
            KokoHinta = kokobensa * LitraHinta;
            Console.WriteLine("Perheen kokopäivän bensan kulutus " + kokobensa + " ja hintaa kertyy " + KokoHinta + " euroa");
        }
    }


}
