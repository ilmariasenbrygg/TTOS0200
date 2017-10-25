using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int rivit = 0;
            int nimet = 0;
            int j = 0;
            string nimi;
            string[] nimia = new string[rivit];
            try
            {
                string polku = @"D:\K1538\Visualstudio\Tekstit\nimet.txt";
                if (!File.Exists(polku))
                {
                    Console.WriteLine("Tiedosto on jo olemassa");
                }
                else
                {
                    string[] lines = System.IO.File.ReadAllLines(polku);
                    foreach (string line in lines)
                    {
                        Console.WriteLine(line);
                        rivit++;
                        nimia[j] = line;
                        j++;
                         
                    }
                    for (int i = 0; i < nimia.Length; i++)
                    {
                        if(nimia[i] = )
                    }
                }

            }
            catch { }
        }
    }
}
