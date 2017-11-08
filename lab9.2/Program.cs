using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Ostoskärry kiituri = new Ostoskärry();
            kiituri.Name = "Hopeinen ostos formula";
            kiituri.sisältö.Add(new Asia("Kahvipaketti", 3.99));
            kiituri.sisältö.Add(new Asia("Kalja x24", 18.45));
            kiituri.sisältö.Add(new Asia("Maito", 0.74));
            kiituri.sisältö.Add(new Asia("Murot", 2.05));

            Console.WriteLine(kiituri.Name + " sisältö:");
            foreach (var Asia in kiituri.sisältö)
            {
                Console.WriteLine(Asia);
            }
        }
    }
}
