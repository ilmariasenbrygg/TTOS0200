using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8._3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string numero;
                string mydocpath = @"C:\Users\Ilmari\Visual\lab8";
                System.IO.StreamWriter outputFile = new System.IO.StreamWriter(mydocpath + @"\integers.txt");
                System.IO.StreamWriter outputFile2 = new System.IO.StreamWriter(mydocpath + @"\doubles.txt");
                do
                {
                    int integer;
                    double duble;
                    Console.WriteLine("Anna tallennettavia numeroita(lopetus nollalla): ");
                    numero = Console.ReadLine();
                    if (int.TryParse(numero, out integer))
                    {
                        outputFile.WriteLine(numero);
                    }
                    else if (double.TryParse(numero, out duble))
                    {
                        outputFile2.WriteLine(numero);
                    }
                    else
                    {
                        Console.WriteLine("Syötä numeroita.");
                    }

                } while (numero.Length != 0);
                outputFile.Close();
                outputFile2.Close();
                string text = System.IO.File.ReadAllText(mydocpath + @"\integers.txt");
                System.Console.WriteLine("Integers:\n" + text);
                string text2 = System.IO.File.ReadAllText(mydocpath + @"\doubles.txt");
                System.Console.WriteLine("Doubles:\n" + text2);
            }
            catch(FileNotFoundException)
            {
                Console.WriteLine("File not found (FileNotFoundException)");
            }
        }
    }
}
