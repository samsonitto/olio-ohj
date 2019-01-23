using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp
{
    class Student : Person
    {
        public string StudentID { get; set; }

        public Student()
        {

        }

        public Student(string firstName, string lastName, string studentID)
            : base(firstName,lastName)
        {
            StudentID = studentID;
        }

        public void StudentMethod()
        {
            Console.WriteLine("This method belongs to Student!");
        }

        public override string ToString()
        {
            return base.ToString() + " " + StudentID;
        }
    }
}
