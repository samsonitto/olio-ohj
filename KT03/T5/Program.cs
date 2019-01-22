using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>(); // Luo listan

            var M2222 = new Student();
            students.Add(M2222);
            M2222.SetName();
            M2222.SetID();
            M2222.Group = "TTV18S3";
            M2222.Grades();
            M2222.Avg();

            var M1111 = new Student();
            students.Add(M1111);
            M1111.SetName();
            M1111.SetID();
            M1111.Group = "TTV18S1";
            M1111.Grades();
            M1111.Avg();

            var M3333 = new Student();
            students.Add(M3333);
            M3333.SetName();
            M3333.SetID();
            M3333.Group = "TTV18S1";
            M3333.Grades();
            M3333.Avg();

            var M4444 = new Student();
            students.Add(M4444);
            M4444.SetName();
            M4444.SetID();
            M4444.Group = "TTV18S3";
            M4444.Grades();
            M4444.Avg();

            var M5555 = new Student();
            students.Add(M5555);
            M5555.SetName();
            M5555.SetID();
            M5555.Group = "TTV18S2";
            M5555.Grades();
            M5555.Avg();


            for (int i = 0; i<5;i++ )
            {
                Console.WriteLine(students[i].ToString());
            }

        }
    }
}
