using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //testaaLuku();
            testaaPvm();
        }
        static void testaaLuku()
        {
            Console.WriteLine("Anna testattava teksti");
            string teksti = Console.ReadLine();
            Luku.OnkoLuku(teksti);
        }
        static void testaaPvm()
        {
            Console.WriteLine("Anna testattava päivämäärä");
            string paivamaara = Console.ReadLine();
            Luku.OnkoPvm(paivamaara);
        }
    }
}
