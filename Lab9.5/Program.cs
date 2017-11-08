using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9._5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                arraycalc.Plus();
                arraycalc.Ave();
                arraycalc.Min();
                arraycalc.Max();

                Console.WriteLine("Summa:" +arraycalc.summa);
                Console.WriteLine("Keski-arvo: "+arraycalc.ave);
                Console.WriteLine("Minimi: "+arraycalc.min);
                Console.WriteLine("Maksimi: "+arraycalc.max);

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
            
    
    }
    }

