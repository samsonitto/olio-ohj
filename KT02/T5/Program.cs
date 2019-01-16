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
            Console.Write("The height of your christmas tree > ");
            int hei = int.Parse(Console.ReadLine());

            int b = 1;
            
            for (int i = 0 ; i < (hei-2) ; i++)
            {

                for (int a = hei - b; a > 0; a--)
                {
                    Console.Write(" ");
                    
                }

                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                for (int j = 0; j <= i-1; j++)
                {
                    Console.Write("*");
                }
                //Console.WriteLine();
                

                b++;
                Console.WriteLine();
            }
            
            for (int z = 0; z < 2; z++)
            {

                for (int y = 0; y <hei-1; y++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine("*");
                
            }
            

        }
    }
}
