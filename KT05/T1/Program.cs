using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee vesa = new Employee();
            vesa.Name = "Vesa Keskinen";
            vesa.Profession = "Myyjä";
            vesa.Salary = 2000;
            Console.WriteLine(vesa.ToString());

            Console.WriteLine("==============================");

            Boss pekka = new Boss();
            pekka.Name = "Pekka Puranen";
            pekka.Profession = "Toimitusjohtaja";
            pekka.Salary = 4000;
            pekka.Car = "Tesla Model S";
            pekka.Bonus = 2000;
            Console.WriteLine(pekka.ToString());

            Console.WriteLine("==============================");

            vesa.Profession = "Siivoja";
            vesa.Salary = 1500;
            Console.WriteLine(vesa.ToString());
        }
    }

    public class Employee
    {
        public string Name { get; set; }
        public string Profession { get; set; }
        public int Salary { get; set; }

        public Employee()
        {

        }

        public override string ToString()
        {
            return "Name: " + Name + ", Profession: " + Profession + ", Salary: " + Salary;
        }
    }

    public class Boss : Employee
    {
        public string Car { get; set; }
        public int Bonus { get; set; }

        public Boss()
        {

        }

        public override string ToString()
        {
            return base.ToString() + ", Car: " + ", Bonus: " + Bonus;
        }
    }
}
