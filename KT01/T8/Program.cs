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

                
                int[] num = new int[3];
                int x;

                for (int i = 0 ; i < 3 ; i++)
                {
                    Console.Write("Numero " + (i + 1) + " > ");
                    num[i] = int.Parse(Console.ReadLine());
                }
                
                for (int j = 1; j < 3; j++)
                {
                    if(num[j] > num[0])
                    {
                        x = num[0];
                        num[0] = num[j];
                        num [j] = num[0];
                    }
                }

                Console.WriteLine("Biggest number is: " + num[0]);

            }
        }
    }
}
