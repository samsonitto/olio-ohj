using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Opiskelijoiden maara > ");
            int stu = int.Parse(Console.ReadLine());
            int[] grades = new int[stu];

            for (int i = 0; i != stu; i++)
            {
                Console.Write("Opiskelija " + (i+1) + " > ");
                grades[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Arvosanat:");

            Console.Write("0:");
            for (int n = 0 ; n != stu ; n++)
            {
                if (grades[n] == 0)
                {
                    Console.Write("*");
                }
            }
            Console.Write("\n1:");
            for (int n = 0; n != stu; n++)
            {
                if (grades[n] == 1)
                {
                    Console.Write("*");
                }
            }
            Console.Write("\n2:");
            for (int n = 0; n != stu; n++)
            {
                if (grades[n] == 2)
                {
                    Console.Write("*");
                }
            }
            Console.Write("\n3:");
            for (int n = 0; n != stu; n++)
            {
                if (grades[n] == 3)
                {
                    Console.Write("*");
                }
            }
            Console.Write("\n4:");
            for (int n = 0; n != stu; n++)
            {
                if (grades[n] == 4)
                {
                    Console.Write("*");
                }
            }
            Console.Write("\n5:");
            for (int n = 0; n != stu; n++)
            {
                if (grades[n] == 5)
                {
                    Console.Write("*");
                }
            }
            Console.WriteLine();

            /*
            for (int j = 0; j != stu; j++)
            {
                Console.WriteLine(grades[j]);
            }
            */
        }
    }
}
