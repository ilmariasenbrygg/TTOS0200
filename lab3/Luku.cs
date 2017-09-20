using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public static class Luku
    {

        public static bool OnkoLuku(string syote)
        {
            if (syote == "testi")
            {
                Console.WriteLine("Hyvä imbde");
                return true;
            }
            else
            { return false; }
        }

        public static bool OnkoPvm(string syote)
        {
            return false;
        }
    }
}
