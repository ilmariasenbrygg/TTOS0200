using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            AnnaVolume();
        }
        static void AnnaVolume()
        {
            Vahvistin vahvistin = new Vahvistin();

            while (true)
            {
                Console.WriteLine("Anna volume(0-100)>");
                vahvistin.Volume = int.Parse(Console.ReadLine());
                Console.WriteLine("Volume on nyt> " + vahvistin.Volume);
            }
        }
    }
}
