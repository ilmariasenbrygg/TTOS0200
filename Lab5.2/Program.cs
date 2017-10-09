using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Jääkaappi IlmarinJääkaappi = new Jääkaappi();
            IlmarinJääkaappi.Name = "Ilmarin jääkaappi";
            IlmarinJääkaappi.sisältö.Add(new Asia("Maito", "Ovi"));
            IlmarinJääkaappi.sisältö.Add(new Asia("Ketsuppi", "Ovi"));
            IlmarinJääkaappi.sisältö.Add(new Asia("Margariini", "Ylähylly"));
            IlmarinJääkaappi.sisältö.Add(new Asia("Vihannekset", "Alahylly"));
            IlmarinJääkaappi.sisältö.Add(new Asia("Juusto", "Keskitaso"));
            Console.WriteLine(IlmarinJääkaappi.ToString());
        }
    }
}
