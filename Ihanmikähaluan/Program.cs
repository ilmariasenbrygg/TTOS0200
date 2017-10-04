using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapselointiDemo
{
    class Thing
    {
        //public string Name;
        //parempi vaihtoehto, ominaisuus AutoImplemented Property avulla
        //public string Name { get; set; }
        //ToString -metodi käyttää jäsenmuuttujaa tai propertyä
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        //CONSTRUCTORS
        public Thing()
        {
            name = "Nobody here";
        }

        public override string ToString()
        {
            //return "nimeni on: " + Name;
            //mutta mielummin jos on sisäinen muuttuja niin käytetään sitä
            return "nimeni on: " + name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Se jostakin testaus
            //Thing t = new Thing();
            //Console.WriteLine(t.ToString());
            //t.Name = "Jotakin";
            //Console.WriteLine(t.Name);
            //Console.WriteLine(t.ToString());

            //Student olion testaus
            Student s = new Student();
            s.EtuNimi = "Ilmari";
            s.SukuNimi = "Ossinberg";
            Student s2 = new Student("oskari", "Olematon");
            //luodaan kokoelma student-olioita, käytetään List
            List<Student> students = new List<Student>();
            students.Add(s);
            students.Add(s2);
            students.Add(new Student("Arska", "Aaltonen"));
            //näytetään oppilaat
            Console.WriteLine("Luokan oppilaat: ");
            foreach (Student item in students)
            {
                Console.WriteLine(item.ToString());
            }
            Group luokka = new Group();
            luokka.Name = "TTV16S1";
            luokka.Students.Add(new Student("Anna", "puu"));
            Console.WriteLine(luokka.ToString());
        }
    }
}
