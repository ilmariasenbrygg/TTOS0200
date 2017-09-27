using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Nimi = "Keijo";
            employee.Ammatti = "Ruohonleikkaaja";
            employee.Palkka = 5000;
            Console.WriteLine(employee.ToString());

            boss pomo = new boss();
            pomo.Nimi = "Esa";
            pomo.Ammatti = "Varastopomo";
            pomo.Palkka = 3000;
            pomo.Auto = "Bemmi";
            pomo.Bonus = 40;
            Console.WriteLine(pomo.ToString());

            boss pomo2 = new boss("Antti", "Ammattilainen", 400, "audi", 40);
        }
    }
}
