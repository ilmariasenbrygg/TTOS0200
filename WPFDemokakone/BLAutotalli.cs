﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFDemokakone
{
    public static class Autotalli
    {
        public static List<Auto> HaeAutot()
        {
            List<Auto> autot = new List<Auto>();
            //GUIn testaamista varten keksitään muutama auto
            Auto a = new Auto();
            a.Merkki = "Volvo";
            a.Malli = "V70";
            a.Vuosimalli = 2007;
            a.KM = 200000;
            a.Hinta = 9000F;
            a.URL = "VolvoV70.png";
            autot.Add(a);

            Auto b = new Auto() { Merkki = "Audi", Malli = "A4", Vuosimalli = 2010, KM = 100000, Hinta = 20000, URL="AudiA4.png" };
            autot.Add(b);

            Auto c = new Auto() { Merkki = "Saab", Malli = "99", Vuosimalli = 2000, KM = 1000000, Hinta = 900, URL="" };
            autot.Add(c);

            Auto d = new Auto() { Merkki = "Rellu", Malli = "99", Vuosimalli = 2000, KM = 1000000, Hinta = 200000, URL = "rellu.png" };
            autot.Add(d);

            return autot;
        }
    }
    public class Auto
    {
        public string Merkki { get; set; }
        public string Malli { get; set; }
        public int Vuosimalli { get; set; }
        public int KM { get; set; }
        public float Hinta { get; set; }
        public string URL { get; set; }
    }
}
