using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9._4
{
    class Program
    {
        static void Main(string[] args)
        {

            //List<Kuvio> Kuviot = new List<Kuvio>();

            //Ympyrä ympyrä = new Ympyrä();

            //ympyrä.Nimi = "Ympyrä";
            //ympyrä.r = 12.3;
            //ympyrä.Pintaala();
            //ympyrä.Ympärysmitta();
            ////Kuviot.Add(ympyrä.ToString);


            //Neliö neliö = new Neliö();
            //neliö.Nimi = "Neliö";
            //neliö.a = 3;
            //neliö.b = 4;
            //neliö.Pintaala();
            //neliö.Ympärysmitta();
            ////Kuviot.Add(neliö.ToString());
            try
            {
                Kuviot Muodot = new Kuviot();
                Console.WriteLine(Muodot.ToString());
            }
            catch(Exception ex) { Console.WriteLine(ex.Message); }
            

        }
    }
}
