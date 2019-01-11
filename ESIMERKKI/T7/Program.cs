using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give a year: ");
            string input = Console.ReadLine();
            int year;
            int.TryParse(input, out year);

            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                Console.WriteLine("Year is a leap year!");
            }
            else
            {
                Console.WriteLine("Year is not a leap year!");
            }
        }
    }
}
