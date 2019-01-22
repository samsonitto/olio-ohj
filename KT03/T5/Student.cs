using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5
{
    class Student
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public string Group { get; set; }
        public int Credits { get; set; }
        public double AvgGrade { get; set; }

        public Student()
        {

        }

        int[] grades = { 0, 0, 0, 0, 0 };

        public void SetName()
        {
            Console.Write("Student's full name: ");
            Name = Console.ReadLine();
        }

        public void SetID()
        {
            Console.Write("Student's ID: ");
            ID = Console.ReadLine();
        }

        public void Grades()
        {
            Console.Write("Math: ");
            grades[0] = int.Parse(Console.ReadLine());
            Console.Write("Fysics: ");
            grades[1] = int.Parse(Console.ReadLine());
            Console.Write("Programming (basics): ");
            grades[2] = int.Parse(Console.ReadLine());
            Console.Write("English: ");
            grades[3] = int.Parse(Console.ReadLine());
            Console.Write("Web design: ");
            grades[4] = int.Parse(Console.ReadLine());

            if (grades[0] > 0)
            {
                Credits += 5;
            }
            if (grades[1] > 0)
            {
                Credits += 6;
            }
            if (grades[2] > 0)
            {
                Credits += 5;
            }
            if (grades[3] > 0)
            {
                Credits += 3;
            }
            if (grades[4] > 0)
            {
                Credits += 5;
            }
        }

        public void Avg()
        {
            AvgGrade = grades.Average();
        }

        public void PrintData()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("ID: " + Name);
            Console.WriteLine("Group: " + Group);
            Console.WriteLine("Total credits: " + Credits);
            Console.WriteLine("Average grade: " + AvgGrade);
        }

        public override string ToString()
        {
            return "Name: " + Name + ", ID: " + ID + ", Group: " + Group + ", Total credits: " + Credits + ", Average grade: " + AvgGrade;
        }

    }


}
