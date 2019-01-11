using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T8
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.Write("Give a number: ");
                string input1 = Console.ReadLine();
                Console.Write("Give a number: ");
                string input2 = Console.ReadLine();
                Console.Write("Give a number: ");
                string input3 = Console.ReadLine();

                int n1, n2, n3;

                int.TryParse(input1, out n1);
                int.TryParse(input2, out n2);
                int.TryParse(input3, out n3);

                if (n1 > n2 && n2 > n3)
                {
                    Console.WriteLine("The biggest number is: " + n1);
                }
                if (n2 > n3 && n3 > n1)
                {
                    Console.WriteLine("The biggest number is: " + n2);
                }
                if (n3 > n2 && n2 > n1)
                {
                    Console.WriteLine("The biggest number is: " + n3);
                }
                if (n1 > n3 && n3 > n2)
                {
                    Console.WriteLine("The biggest number is: " + n1);
                }
                if (n2 > n1 && n1 > n3)
                {
                    Console.WriteLine("The biggest number is: " + n2);
                }
                if (n3 > n1 && n1 > n2)
                {
                    Console.WriteLine("The biggest number is: " + n3);
                }
                else
                {
                    Console.WriteLine("wut");
                }

            }
        }
    }
}
