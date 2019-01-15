using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] points = new int[5];



            for (int i = 0; i < 5; i++)
            {
                Console.Write("Give a number > ");
                points[i] = int.Parse(Console.ReadLine());
            }

            int sum = points.Sum() - points.Max() - points.Min();

            Console.WriteLine("Summa on: " + sum);

        }
    }
}
