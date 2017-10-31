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
            try
            {
                int a = 0;
                string polku = @"C:\Users\Ilmari\Visual\nimet.txt";
                if (!File.Exists(polku))
                {
                    
                    var nameCount = new SortedDictionary<string, int>();

                    foreach (String s in File.ReadAllLines(@"C:\Users\Ilmari\Visual\nimet.txt.txt"))
                    {
                        if (nameCount.ContainsKey(s))
                        {
                            nameCount[s] = nameCount[s] + 1;
                            a++;
                        }
                        else
                        {
                            nameCount.Add(s, 1);
                            a++;
                        }
                    }

                    // and printing
                    Console.WriteLine("Sisälsi {0} riviä ja {1} nimeä.", a, nameCount.Count);
                    foreach (var pair in nameCount)
                    {
                        Console.WriteLine("{0} count:{1}", pair.Key, pair.Value);
                    }
                }
                else
                {
                    Console.WriteLine("Tiedosto on jo olemassa");
                }
            }
            catch(FileNotFoundException)
            {
                Console.WriteLine("File not found (FileNotFoundException)");
            }
            
        }
    }
}
