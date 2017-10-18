using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Korttipakka Hienopakka = new Korttipakka();

            for (int i = 1; i < 14; i++)
            {
                Hienopakka.Kortit.Add(new Kortti("Pata", i));
            }
            for (int i = 1; i < 14; i++)
            {
                Hienopakka.Kortit.Add(new Kortti("Ruutu", i));
            }
            for (int i = 1; i < 14; i++)
            {
                Hienopakka.Kortit.Add(new Kortti("Risti", i));
            }
            for (int i = 1; i < 14; i++)
            {
                Hienopakka.Kortit.Add(new Kortti("Hertta", i));
            }

            Console.WriteLine(Hienopakka.ToString());
        }
    }
}
