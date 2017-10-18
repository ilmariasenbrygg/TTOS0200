using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cd Eput = new Cd();
            Eput.Name = "Eput";
            Eput.Artisti = "Eppu Normaali";
            Eput.Biisit.Add(new Biisi("Vihreän joen rannalla", "3:45"));
            Eput.Biisit.Add(new Biisi("Murheellisten laulujen maa", "3:45"));
            Eput.Biisit.Add(new Biisi("Vuonna 85", "3:45"));
            Eput.Biisit.Add(new Biisi("Kitara, Taivas ja tähdet", "3:45"));
            Eput.Biisit.Add(new Biisi("En muistanu enempää", "3:45"));

            Console.WriteLine(Eput.ToString());
        }
    }
}
