using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class Program
    {
        static void Main(string[] args)
        {
            testaaLuku();
        }

        static void testaaLuku()
        {
            Console.WriteLine("Anna testattava teksti");
            string teksti = Console.ReadLine();


            Luku.OnkoLuku(teksti);
        }
    }
}