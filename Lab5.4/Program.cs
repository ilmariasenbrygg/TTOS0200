using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Aikuinen Mies = new Aikuinen();
            Mies.Nimi = "Mikko";
            Mies.Ikä = 24;
            Mies.Pituus = 197;
            Mies.Paino = 120;
            Mies.Auto = "Audi";
            Console.WriteLine(Mies.ToString());
            Mies.Kasvu();
            Mies.Liiku();
            Mies.Kasvu();
            Mies.Liiku();
            Console.WriteLine("Miehen ikä:" +Mies.Ikä);

            Lapsi Vauva = new Lapsi();
            Vauva.Nimi = "Esa";
            Vauva.Ikä = 2;
            Vauva.Pituus = 60;
            Vauva.Paino = 15;
            Vauva.Vaippa = "LÖytyyy";
            Console.WriteLine(Vauva.ToString());
            Vauva.Kasvu();
            Vauva.Kasvu();
            Vauva.Liiku();
            Vauva.Liiku();
            Console.WriteLine("Vauvan ikä:" + Vauva.Ikä);

            Ihminen Joku = new Ihminen();
            Joku.Nimi = "Unknown";
            Joku.Ikä = 27;
            Joku.Pituus = 180;
            Joku.Paino = 75;
            Console.WriteLine(Joku.ToString());
            Joku.Liiku();
            Joku.Liiku();


        }
    }
}
