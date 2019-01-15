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
            while(true)
            {

                Console.Write("Gice a number > ");
                int number = int.Parse(Console.ReadLine());

                for (int i=0 ; i < number ; i++)
                {
                    for (int j=0 ; j <= i ; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
