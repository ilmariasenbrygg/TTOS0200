using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string mydocpath = @"C:\Users\Ilmari\Visual\lab8";
            System.IO.StreamWriter outputFile = new System.IO.StreamWriter(mydocpath + @"\ohjelmat.txt");

            outputFile.WriteLine(new Tvohjelma("Midsomerin murhat", "Tv2", "Tiistai klo 19.15", "Kertoo murhatutkijan tutkimuksista"));
            outputFile.WriteLine(new Tvohjelma("Posse", "Mtv3", "Lauantai 20.00", "Perheen hupiohjelma"));
            outputFile.WriteLine(new Tvohjelma("Kymppiuutiset", "Mtv3", "Joka päivä 22.00", "Uutisia"));
            outputFile.WriteLine(new Tvohjelma("Napakymppi", "Mtv3", "- klo 20.00", "Parin etsintä ohjelma"));
            outputFile.Close();

            string text = System.IO.File.ReadAllText(mydocpath + @"\ohjelmat.txt");
            System.Console.WriteLine("Tv ohjelmien luettelo:\n" + text);
        }
    }
}
