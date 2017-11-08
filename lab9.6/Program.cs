using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9._6
{
    class Program
    {
        static void Main(string[] args)
        {
            double tuotteidenhinta = 0;

            Ostorkärry kiituri = new Ostorkärry();
            kiituri.Name = "Hopeinen ostos formula";
            kiituri.sisältö.Add(new Tuote("Kahvipaketti", 3.99,4));
            kiituri.sisältö.Add(new Tuote("Kalja x24", 18.45,2));
            kiituri.sisältö.Add(new Tuote("Maito", 0.74,3));
            kiituri.sisältö.Add(new Tuote("Murot", 2.05,6));
            


            Console.WriteLine(kiituri.Name + " sisältö:");
            foreach (var Asia in kiituri.sisältö)
            {
                Console.WriteLine(Asia);
            }
            
        }
    }
}
