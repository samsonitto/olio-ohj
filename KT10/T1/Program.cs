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
            Random rand = new Random();
            List<int> tulokset = new List<int>();
            int[] noppa = new int[6] { 1, 2, 3, 4, 5, 6 };

            int heittoLaskuri;
            int laskuri1 = 0;
            int laskuri2 = 0;
            int laskuri3 = 0;
            int laskuri4 = 0;
            int laskuri5 = 0;
            int laskuri6 = 0;

            

            int x = rand.Next(0, noppa.Length);
            Console.WriteLine("Dice, one test throw is {0}", noppa[x]);

            Console.Write("How many times do you want to throw a dice: ");
            heittoLaskuri = int.Parse(Console.ReadLine());

            
            for (int i = 0; i < heittoLaskuri ; i++)
            {
                x = rand.Next(0, noppa.Length);
                tulokset.Add(noppa[x]);

                if (noppa[x] == 1)
                {
                    laskuri1++;
                }
                if (noppa[x] == 2)
                {
                    laskuri2++;
                }
                if (noppa[x] == 3)
                {
                    laskuri3++;
                }
                if (noppa[x] == 4)
                {
                    laskuri4++;
                }
                if (noppa[x] == 5)
                {
                    laskuri5++;
                }
                if (noppa[x] == 6)
                {
                    laskuri6++;
                }
            }

            double avg = tulokset.Average();

            Console.WriteLine("Dice is now thrown {0} times", heittoLaskuri);
            Console.WriteLine("- Average is {0}", avg);
            Console.WriteLine("1 count is {0}", laskuri1);
            Console.WriteLine("2 count is {0}", laskuri2);
            Console.WriteLine("3 count is {0}", laskuri3);
            Console.WriteLine("4 count is {0}", laskuri4);
            Console.WriteLine("5 count is {0}", laskuri5);
            Console.WriteLine("6 count is {0}", laskuri6);
        }
    }
}
