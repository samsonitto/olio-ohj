using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] randNum = new int[101];
            int g = 0;

            for (int i = 0;i<101 ;i++)
            {
                randNum[i] = i;
            }

            int r = randNum[rand.Next(0, randNum.Length)];

            while (true)
            {
            Console.Write("Guess a number 0-100: ");
            int num = int.Parse(Console.ReadLine());
                if (num==r)
                {
                    g++;
                    Console.WriteLine("Congrats! You won nothing and it took you " + g + " guesses!");
                    break;
                }
                
                if (num < r)
                {
                    Console.WriteLine("Your number is smaller");
                    g++;
                }

                if (num > r)
                {
                    Console.WriteLine("Your number is bigger");
                    g++;
                }
            }
            //Console.WriteLine(r);

            /*
             * for (int j = 0; j < 101; j++)
            {
                Console.Write(randNum[j] + " ");
            }
            */
        }
    }
}
