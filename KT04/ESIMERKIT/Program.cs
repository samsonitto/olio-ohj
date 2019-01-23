using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person henkilo = new Person();
            henkilo.FirstName = "Pekka";
            henkilo.LastName = "Pouta";
            henkilo.Address = "Pilvilinna";
            henkilo.Age = 69;
            henkilo.PhoneNumber = "0404040404";
            Console.WriteLine(henkilo.ToString());

            Console.WriteLine("===========================");

            Teacher ope = new Teacher();
            ope.FirstName = "Lorppa";
            ope.LastName = "Huuli";
            ope.Address = "Lorppakatu";
            ope.Age = 31;
            ope.PhoneNumber = "000000000000";
            ope.Room = "D123";
            Console.WriteLine(ope.ToString());

            Console.WriteLine("===========================");

            Student opiskelija = new Student("hei", "hou", "m1234");
            opiskelija.Address = "let's go";
            opiskelija.Age = 20;
            opiskelija.PhoneNumber = "1234242";
            Console.WriteLine(opiskelija.ToString());

            henkilo.PersonMethod();
            ope.PersonMethod();
            ope.TeacherMethod();
            opiskelija.PersonMethod();
            opiskelija.StudentMethod();
        }
    }
}
