using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 33, 44, 55, 68, 77, 96, 100 };

            for(int i=0; i<9;i++)
            {
                Console.Write("\n" + arr[i]);
                if (arr[i] % 2 == 0)
                {
                    Console.Write(" HEP");
                }
                if (arr[i]==100)
                {
                    Console.Write("\n");
                }
            }
        }
    }
}
