using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nimi;
            string mydocpath = @"D:\K1538\Visualstudio\Tekstit\";
            System.IO.StreamWriter outputFile = new System.IO.StreamWriter(mydocpath + @"\test.txt");
            do
            {
                Console.WriteLine("Anna Tiedostoon tallennettavia nimiä: ");
                nimi = Console.ReadLine();
                outputFile.WriteLine(nimi);
            } while (nimi.Length != 0);
            outputFile.Close();
            
            try
            {
                string text = System.IO.File.ReadAllText(mydocpath + @"\test.txt");
                System.Console.WriteLine("Contents of test.txt:\n" + text);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found (FileNotFoundException)");
            }
        }
    }
}
