using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public struct Ohjastaja
    {
        public string Nimi;
        public int Startit;
        public int Voitot;
        public float Voittopros;
    }
    class Program
 
    {
        static void LueOhjastajatVer2()
        {
            try
            {
                string erotin = ";";
                string[] rivit = System.IO.File.ReadAllLines(@"d:\K1538\Visualstudio\TTOS0200\tilasto2017.csv");
                Ohjastaja kuski;
                int lkm = rivit.Length;
                Console.WriteLine("Ohjastajia yhteensä {0}", lkm - 1);

                for (int i = 0; i < lkm; i++)
                {
                    string[] sanat = rivit[i].Split(erotin.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    //tietueita on kahdenlaisia, v1: etunimi+sukunimi v2:etunimi+väliosa+sukunimi
                    if (int.TryParse(sanat[2], out int apu))
                    {
                        kuski.Nimi = sanat[0] + " " + sanat[1];
                        kuski.Startit = int.Parse(sanat[2]);
                        kuski.Voitot = int.Parse(sanat[3]);
                        kuski.Voittopros = (100F * kuski.Voitot / kuski.Startit);

                        Console.WriteLine("{0}: {1} startit {2} voitot{3} voittoprosentti {4}", i, kuski.Nimi, kuski.Startit, kuski.Voitot, kuski.Voittopros);
                    }
                    else
                    {
                        kuski.Nimi = sanat[0] + " " + sanat[1] +" "+sanat[2];
                        kuski.Startit = int.Parse(sanat[3]);
                        kuski.Voitot = int.Parse(sanat[4]);
                        kuski.Voittopros = (100F * kuski.Voitot / kuski.Startit);

                        Console.WriteLine("{0}: {1} startit {2} voitot{3} voittoprosentti {4}", i, kuski.Nimi, kuski.Startit, kuski.Voitot, kuski.Voittopros);
                    }
                    
                }
                Console.WriteLine("The end");

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
        static void LueOhjastajatVer1()
        {
            try
            {
                int counter = 1;
                string line;
                System.IO.StreamReader stream = new System.IO.StreamReader(@"d:\K1538\Visualstudio\TTOS0200\tietoja.txt");
                while ((line = stream.ReadLine()) != null)
                {
                    Console.WriteLine(counter + ":" + line);
                    counter++;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        static void Main(string[] args)
        {
            try
            {
                LueOhjastajatVer2();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
        }
    }
}
