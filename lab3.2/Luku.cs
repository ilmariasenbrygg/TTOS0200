﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3._2
{
    public static class Luku
    {
        public static bool OnkoLuku(string syote)
        {
            if (syote.All(char.IsDigit) || syote.ToLower().Contains(','))
            {

                Console.WriteLine("Syöte on luku");
                return true;
            }
            else
            {
                Console.WriteLine("Syöte ei ole luku");
                return false;
            }
        }

        public static bool OnkoPvm(string syote)
        {
            string[] format = new string[] { "dd.MM.yyyy" };
            DateTime dateTime;

            if (DateTime.TryParseExact(syote, format, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.NoCurrentDateDefault, out dateTime))
                {
                Console.WriteLine("On päivämäärä");
                return true;
            }
            else
            {
                Console.WriteLine("Ei ole päivämäärä");
                return false;
            }
        }
    }
}
