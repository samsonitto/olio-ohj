using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }

        public Person()
        {
            
        }

        public Person(string firstName, string latsName)
        {
            FirstName = firstName;
            LastName = latsName;
        }

        public void PersonMethod()
        {
            Console.WriteLine("This method belongs to Person!");
        }

        public override string ToString()
        {
            return "Name: " + FirstName + " " + LastName + ", Address: " + Address + ", Age: " + Age + ", Num: " + PhoneNumber;
        }
    }
}
