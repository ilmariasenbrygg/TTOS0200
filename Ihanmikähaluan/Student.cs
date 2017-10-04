using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapselointiDemo
{
    public class Student
    {
        public string EtuNimi { get; set; }
        public string SukuNimi { get; set; }
        public string AsioID { get; set; }
        public Student()
        {
        }
        public Student(string Enimi, string Snimi)
        {
            EtuNimi = Enimi;
            SukuNimi = Snimi;
        }
        public override string ToString()
        {
            return EtuNimi + " " + SukuNimi + " Asio:" + AsioID;
        }
    }
    public class Group
    {
        public string Name { get; set; }
        public List<Student> Students;
        //Constructor
        public Group()
        {
            Students = new List<Student>();
            //Luettaisiin tietokannasta ne oppilaiden tiedot
            Students.Add(new Student("Pelle", "peloton"));
            Students.Add(new Student("Jaska", "Jalonen"));
            Students.Add(new Student("Julli", "Kalonen"));
        }
        //Ylikirjoitetaan Tostring
        public override string ToString()
        {
            string retval = "Luokka" + Name + " sisältää oppilaat\n";
            foreach (Student item in Students)
            {
                retval += item.ToString() + "\n";
            }
            return retval;
        }
    }
}
