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
            Console.Write("Age > ");
            string input = Console.ReadLine();
            int age;
            int.TryParse(input, out age);

            if (age < 18)
            {
                Console.WriteLine("Minor");
            }
            else if (age >= 18 && age < 66)
            {
                Console.WriteLine("Grownup");
            }
            else
            {
                Console.WriteLine("Dying");
            }
        }
    }
}
