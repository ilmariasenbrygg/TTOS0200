using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11._2
{
    public class Pelaajat
    {
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public string Pelipaikka { get; set; }
        public string Katisyys { get; set; }
        public double Numero { get; set; }

        public Pelaajat(string etunimi, string sukunimi, string pelipaikka, string katisyys, int numero)
        {
            Etunimi = etunimi;
            Sukunimi = sukunimi;
            Pelipaikka = pelipaikka;
            Katisyys = katisyys;
            Numero = numero;

        }
    }
    public static class Joukkue
    {
        public static List<Pelaajat> HaePelaajat()
        {
            List < Pelaajat > Pelaaja = new List<Pelaajat>();

            Pelaaja.Add(new Pelaajat("Jaska", "Jokunen", "Pakki", "Left", 8));
            Pelaaja.Add(new Pelaajat("Jaska", "Jokunen", "Pakki", "Left", 8));
            Pelaaja.Add(new Pelaajat("Jaska", "Jokunen", "Pakki", "Left", 8));
            Pelaaja.Add(new Pelaajat("Jaska", "Jokunen", "Pakki", "Left", 8));
            Pelaaja.Add(new Pelaajat("Jaska", "Jokunen", "Pakki", "Left", 8));
            Pelaaja.Add(new Pelaajat("Jaska", "Jokunen", "Pakki", "Left", 8));
            Pelaaja.Add(new Pelaajat("Jaska", "Jokunen", "Pakki", "Left", 8));
            Pelaaja.Add(new Pelaajat("Jaska", "Jokunen", "Pakki", "Left", 8));
            Pelaaja.Add(new Pelaajat("Jaska", "Jokunen", "Pakki", "Left", 8));
            Pelaaja.Add(new Pelaajat("Jaska", "Jokunen", "Pakki", "Left", 8));

            return Pelaaja;
        }
    }
}
